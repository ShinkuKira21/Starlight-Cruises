using Microsoft.AspNetCore.Mvc;
using Server.Repositories;
using Server.Controllers;
using Server.DTO;
using Server.Models;
using Server.Settings;

namespace Server.Controllers;

[ApiController]
[Route("services")]
public class ServiceController : ControllerBase
{
    private readonly IServiceRepository repository;

	public ServiceController(IServiceRepository repository)
	{ this.repository = repository; }

	[HttpGet]
	public IEnumerable<ServiceDTO> GetServices()
	{
		IEnumerable<Services> services = repository.GetServices().Result;

		return services.Select(services => services.AsDTO());
	}

	[HttpGet("{id}")]
	public ActionResult<ServiceDTO> GetService(Guid id)
	{
		Services service = repository.GetService(id).Result;

		if(service == null) return NotFound();
		
		return Ok(service.AsDTO());
	}

	[HttpPost]
	public ActionResult AppendService(AppendServiceDTO serviceDTO)
	{
		if(serviceDTO.minPrice > serviceDTO.midPrice)
			return BadRequest("Mid Price is less than Min Price");
		if(serviceDTO.midPrice > serviceDTO.maxPrice)
			return BadRequest("Max Price is less than Min Price");
		if(serviceDTO.maxPrice < serviceDTO.midPrice)
			return BadRequest("Max Price is less than Min Price");
		
		Services service = new Services()
		{
			id = Guid.NewGuid(),
			name = serviceDTO.name,
			description = serviceDTO.description,
			type = serviceDTO.type,
			imgDirectory = serviceDTO.imgDirectory,
			minPrice = serviceDTO.minPrice,
			midPrice = serviceDTO.midPrice,
			maxPrice = serviceDTO.maxPrice,
			link = serviceDTO.link,
			createdAt = DateTimeOffset.Now
		};
		
		repository.AppendService(service);

		return Ok("Service Appended Successfully");
	}

	[HttpPut("{id}")]
	public ActionResult UpdateService(Guid id, UpdateServiceDTO updatedService)
	{
		Services eService = repository.GetService(id).Result;
		
		if (eService == null) return NotFound();
		
		return Ok("Not implemented");
	}

	[HttpDelete("{id}/{confirmation}")]
	public ActionResult DeleteService(Guid id, string confirmation)
	{
		if (!AdminSettings.CheckConfirmationCode(confirmation)) return Forbid("Confirmation Code Invalid");

		Services existingService = repository.GetService(id).Result;
		if (existingService == null) return NotFound();

		repository.DeleteService(id);
		return Ok("Service Deleted Successfully");
	}

	[HttpDelete("{confirmation}")]
	public ActionResult DeleteAllServices(string confirmation)
	{
		if(!AdminSettings.CheckConfirmationCode(confirmation)) return Forbid("Confirmation Code Invalid");
		
		repository.DeleteAllServices();

		return Ok("Deletion of All Services are Successful");
	}
}