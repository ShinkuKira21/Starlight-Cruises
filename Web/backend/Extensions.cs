using Server.DTO;
using Server.Models;

namespace Server;

// JSON Data Type
public static class Extensions
{
    public static ServiceDTO AsDTO(this Services service)
    {
        return new ServiceDTO
        {
            id = service.id,
            name = service.name,
            description = service.description,
            type = service.type,
            imgDirectory = service.imgDirectory,
            minPrice = service.minPrice,
            midPrice = service.midPrice,
            maxPrice = service.maxPrice,
            link = service.link
        };
    }
}