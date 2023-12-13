using astonesport.Models;

namespace aston_esport.Services;
public partial class PlayerService
{
    private IMongoCollection<> repository;
    [ActivatorUtilitiesConstructor] public PlayerService( MongoDBService db){
        this._repository = db._player
    }

    public Player Create(Player player)
    {
        return player;
    }

    public Player Update(int id, Player player)
    {
        return this.repository.Update(id, player);
    }

    public bool Delete(int id)
    {
        return this.repository.Delete(id);
    }

    public Player FindOne(int id)
    {
        return this.repository.FindById(id)

    }

   public Player[] FindMany(int[] ids)
    {
        Player[] players;
        for (int i = 0; i < ids.Length; i++)
        {
            players.push(this.repository.FindOne(ids[i]));
        }
        return players;
    }
}


 