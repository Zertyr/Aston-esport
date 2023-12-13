/*using astonesport.Models;

namespace aston_esport.Services;
public partial class TeamService
{

    public Team Create(Team team)
    {
        return team;
    }

    public Team Update(int id, Team team)
    {
        return team;
    }

    public bool Delete(int id)
    {
        return true;
    }

*//*    public Team FindOne(int id)
    {
        return this.repository.FindById(id);
    }
*//*
    public Team[] FindMany(int[] ids)
    {
        Team[] teams;
        for (int i = 0; i < ids.Length; i++)
        {
*//*            teams.push(this.FindOne(ids[i]));
*//*        }
        return teams;
    }

*//*    public bool AddCoach(int teamId, Person coach)
    {
        Team team = this.FindOne(teamId);
        team.Coaches.push(coach);
        this.Update(team.id, team);
    }*//*
}*/