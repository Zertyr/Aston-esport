using System;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace astonesport.Models;

    /// <summary>
    /// Représente les informations d'une équipe
    /// </summary>
    public class Player : Person
    {
    /// <summary>
    /// Obtient ou définit le pseudo d'un joueur
    /// </summary>
    [BsonElement("pseudo")]
    public string Pseudo { get; set; }
    }


