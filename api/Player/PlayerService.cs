using aston_esport.Models;
using astonesport.Models;
using MongoDB.Driver;

namespace aston_esport.Services;
public partial class PlayerService
{
    private IMongoCollection<Player> repository;
    [ActivatorUtilitiesConstructor] 
    public PlayerService(PlayerStoreDatabaseSettings playerStoreDatabaseSettings, IMongoClient mongoClient)
    {
        var db = mongoClient.GetDatabase(playerStoreDatabaseSettings.DatabaseName);
        repository = db.GetCollection<Player>(playerStoreDatabaseSettings.CollectionName);
    }

    public Player Create(Player player)
    {
        repository.InsertOne(player);
        return player;
    }

    public Player Update(string id, Player player)
    {
        this.repository.ReplaceOne(x => x.Id == id,player);
        return player;
    }

    public bool Delete(string id)
    {
        this.repository.DeleteOne(id);
        return true;
    }

    public List<Player> Find()
    {
        var player = repository.Find(x => true).ToList();
        return player;
    }


    public Player FindOne(string id)
    {
        var player = repository.Find(x => x.Id == id).First();
        return player;
    }

   public List<Player> FindMany(string[] ids)
    {
        var players = repository.Find(x => ids.Contains(x.Id)).ToList();
        return players;
    }
}


 