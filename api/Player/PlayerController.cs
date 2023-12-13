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
    public readonly PlayerService service; 
    [ActivatorUtilitiesConstructor] public PlayerController( MongoDBService db){
        this.service = new PlayerService(db);
    }

    [HttpGet("getPlayer/{id}")]
    public IEnumerable<Player> Get([FromRoute(Name = "id")] int id)
    {
        this.service.FindOne(id)
    }

    [HttpPost(Name = "getPlayers")]
    public Player GetMany([FromBody] string ids)
    {
        JsonDocument.Parse(ids);
        this.service.FindMany(ids);
    }

    [HttpPost(Name = "postPlayer")]
    public Player Create([FromBody] string player)
    {
        JsonDocument.Parse(player);
        this.service.Create(player);
    }

    [HttpPatch(Name = "patchPlayer")]
    public Player Update([FromBody] string player)
    {
        this.service.Update(player);
    }

    [HttpDelete("deletePlayer/{id}")]
    public bool Delete([FromRoute(Name = "id")] int id)
    {
        this.service.Delete(id);
    }
}
