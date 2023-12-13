using System;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace astonesport.Models;

    /// <summary>
    /// Repr�sente les informations d'une �quipe
    /// </summary>
    public class Player : Person
    {
    /// <summary>
    /// Obtient ou d�finit le pseudo d'un joueur
    /// </summary>
    [BsonElement("pseudo")]
    public string Pseudo { get; set; }
    }


