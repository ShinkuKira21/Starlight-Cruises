using Server.Models;

namespace Server.Repositories;

public interface IServiceRepository
{
    Task<Services> GetService(Guid id);
    Task<IEnumerable<Services>> GetServices();

    void AppendService(Services service);
    void UpdateService(Guid id, Services service);
    void DeleteService(Guid id);
    void DeleteAllServices();
};