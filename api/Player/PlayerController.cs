using aston_esport.Services;
using astonesport.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.Json;

namespace aston_esport.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayerController : ControllerBase
{
    public readonly PlayerService _service; 
    [ActivatorUtilitiesConstructor] 
    public PlayerController( PlayerService playerService){
        this._service = playerService;
    }

    [HttpGet("getPlayer/{id}")]
    public Player Get([FromRoute(Name = "id")] string id)
    {
        return this._service.FindOne(id);
    }

    [HttpPost(Name = "getPlayers")]
    public IEnumerable<Player> GetMany([FromBody] string[] ids)
    {
       return this._service.FindMany(ids);
    }

    [HttpPost(Name = "postPlayer")]
    public Player Create([FromBody] Player player)
    {
        return this._service.Create(player);
    }

    [HttpPatch(Name = "patchPlayer/{id}")]
    public Player Update([FromRoute(Name = "id")] string id, [FromBody] Player player)
    {
        return this._service.Update(id,player);
    }

    [HttpDelete("deletePlayer/{id}")]
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
