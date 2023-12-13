using astonesport.Models;

namespace aston_esport.Services;
public partial class TeamService
{
    private IMongoCollection<Team> repository;
    [ActivatorUtilitiesConstructor] 
    public TeamService(TeamStoreDatabaseSettings teamStoreDatabaseSettings, IMongoClient mongoClient)
    {
        var db = mongoClient.GetDatabase(teamStoreDatabaseSettings.DatabaseName);
        repository = db.GetCollection<Team>(teamStoreDatabaseSettings.CollectionName);
    }

    public Team Create(Team team)
    {
        repository.InsertOne(team);
        return team;
    }

    public Team Update(string id, Team team)
    {
        this.repository.ReplaceOne(x => x.Id == id,team);
        return team;
    }

    public bool Delete(string id)
    {
        this.repository.DeleteOne(id);
        return true;
    }

    public List<Team> Find()
    {
        var team = repository.Find(x => true).ToList();
        return team;
    }


    public Team FindOne(string id)
    {
        var team = repository.Find(x => x.Id == id).First();
        return team;
    }

   public List<Team> FindMany(string[] ids)
    {
        var teams = repository.Find(x => ids.Contains(x.Id)).ToList();
        return teams;
    }



    // TODO controller
    public Team AddRoster(string id, Roster roster){
        var team = FindOne(id);
        team.Rosters.push(roster);
        return Update(id, team);
    }

    // TODO controller
    public Team RemoveRoster(string id, Roster roster){
        var team = FindOne(id);
        roster = team.Rosters.Contains(x => x.id == roster.id);
        team.Rosters.Remove(roster);
        return Update(id, team);
    }

    public Team AddRosterPlayer(string id, string rosterId, Player player){
        var team = FindOne(id);
        roster = team.Rosters.Contains(x => x.id == roster.id);
        team.Rosters.Remove(roster);

        roster.push(player);
        team.Rosters.push(roster);
        return Update(id, team);
    }

    public Team RemoveRosterPlayer(string id, string rosterId, string playerId){
        var team = FindOne(id);
        roster = team.Rosters.Contains(x => x.id == playerId);
        team.Rosters.Remove(roster);
        roster.Remove(player);

        team.Rosters.push(roster);
        return Update(id, team);
    }
}