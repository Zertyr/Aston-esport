using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using astonesport.Models;
/// <summary>
/// Représente les informations d'un roster
/// </summary>

public class Roster
    {
        /// <summary>
        /// Obtient ou définit le nom d'un roster
        /// </summary>
        [BsonElement("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Obtient ou définit le nom d'un roster
        /// </summary>
        [BsonElement("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Obtient ou définit la liste des membres
        /// </summary>
        public List<Player> Players { get; set; }
    }