using astonesport.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace aston_esport.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeamController : ControllerBase
{
    public readonly TeamService _service; 
    [ActivatorUtilitiesConstructor] 
    public TeamController( TeamService teamService){
        this._service = teamService;
    }

    [HttpGet("getTeam/{id}")]
    public Team Get([FromRoute(Name = "id")] string id)
    {
        return this._service.FindOne(id);
    }

    [HttpPost(Name = "getTeams")]
    public IEnumerable<Team> GetMany([FromBody] string[] ids)
    {
       return this._service.FindMany(ids);
    }

    [HttpPost(Name = "postTeam")]
    public Team Create([FromBody] Team team)
    {
        return this._service.Create(team);
    }

    [HttpPatch(Name = "patchTeam/{id}")]
    public Team Update([FromRoute(Name = "id")] string id, [FromBody] Team team)
    {
        return this._service.Update(id,team);
    }

    [HttpDelete("deleteTeam/{id}")]
    public bool Delete([FromRoute(Name = "id")] string id)
    {
        if (this._service.Delete(id))
        {
            return true;
        }
        else
        {
            return false;
        };
    }
}
