using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Text.Json.Serialization;

namespace astonesport.api.Team.Models;

/// <summary>
/// Représente les informations d'une équipe
/// </summary>
public class Team
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    /// <summary>
    /// Obtient ou définit la date de création
    /// </summary>
    [BsonElement("created")]
    public DateTime Created { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Obtient ou définit la date de modification
    /// </summary>*
    [BsonElement("updated")]
    public DateTime Updated { get; set; }

    /// <summary>
    /// Obtient ou définit le nom d'une équipe
    /// </summary>
    [BsonElement("name")]
    public string Name { get; set; }

    /// <summary>
    /// Obtient ou définit les regions
    /// </summary>
    [BsonElement("areas")]
    [JsonPropertyName("areas")]
    public List<string> Areas { get; set; }

    /// <summary>
    /// Obtient ou définit la liste des rosters
    /// </summary>
    [BsonElement("rosters")]
    public List<Roster> Rosters { get; set; }

    /// <summary>
    /// Obtient ou définit la liste des remplaçants
    /// </summary>
    [BsonElement("substitute")]
    public List<Player> Substitute { get; set; }

    /// <summary>
    /// Obtient ou définit la liste des coach
    /// </summary>
    [BsonElement("coaches")]
    public List<Person> Coaches { get; set; }
}

