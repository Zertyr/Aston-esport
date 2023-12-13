using astonesport.Models;

namespace aston_esport.Services;
public partial class PlayerService
{
    public Player Create(Player player)
    {
        return player;
    }

    public Player Update(int id, Player player)
    {
        //return this.repository.Update(id, player);
        return player;
    }

    public bool Delete(int id)
    {
        //return this.repository.Delete(id);
        return true;
    }

    public Player FindOne(int id)
    {
        // return this.repository.FindById(id)
        return new Player();

    }

/*    public Player[] FindMany(int[] ids)
    {
        Player[] players;
        for (int i = 0; i < ids.Length; i++)
        {
            players.push(this.FindOne(ids[i]));
        }
        return players;
    }*/
}


 