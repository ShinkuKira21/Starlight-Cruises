using Server.Models;
using MongoDB.Driver;
namespace Server.Repositories;

public class MDBServiceRepository : IServiceRepository
{
    private const string databaseName = "InSiteSolutions";
    private const string collectionName = "Services";
    
    private readonly IMongoCollection<Services> serviceCollection;
    
    public MDBServiceRepository(IMongoClient client)
    {
        IMongoDatabase db = client.GetDatabase(databaseName);
        serviceCollection = db.GetCollection<Services>(collectionName);
    }
    
    public async Task<Services> GetService(Guid id)
    {
        IAsyncCursor<Services> result = await serviceCollection.FindAsync(index => index.id == id);
        return await result.FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Services>> GetServices()
    {
        Task<IAsyncCursor<Services>> result = serviceCollection.FindAsync(service => true);

        return await result.Result.ToListAsync(); 
    }

    public async void AppendService(Services service)
    { await serviceCollection.InsertOneAsync(service); }

    public async void UpdateService(Guid id, Services service)
    { await serviceCollection.ReplaceOneAsync(eService => eService.id == id, service); }

    public async void DeleteService(Guid id)
    { await serviceCollection.DeleteOneAsync(service => service.id == id); }

    public async void DeleteAllServices()
    { await serviceCollection.DeleteManyAsync(service => true); }
}