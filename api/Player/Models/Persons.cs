using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace astonesport.Models;

/// <summary>
/// Représente les informations d'une équipe
/// </summary>
public abstract class Person
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
    /// </summary>
    [BsonElement("updated")]
    public DateTime Updated { get; set; }


    /// <summary>
    /// Obtient ou définit le prénom d'un joueur
    /// </summary>
    [BsonElement("firstname")]
    public string FisrtName { get; set; }


    /// <summary>
    /// Obtient ou définit le nom d'un joueur
    /// </summary>
    [BsonElement("lastname")]
    public string LastName { get; set; }

    /// <summary>
    /// Obtient ou définit le nom d'un joueur
    /// </summary>
    [BsonElement("fullname")]
    public string FullName { get; set; }

    /// <summary>
    /// Obtient ou définit le Role  d'un joueur
    /// </summary>
    [BsonElement("role")]
    public string Role { get; set; }

    /// <summary>
    /// Obtient ou définit la nationalité  d'un joueur
    /// </summary>
    [BsonElement("nationality")]
    public string Nationality { get; set; }


}

