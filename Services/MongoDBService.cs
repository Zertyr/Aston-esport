/*using astonesport.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;

namespace aston_esport.Services
{
    public class MongoDBService
    {
        public IMongoCollection<Team> _teamCollection;
        public IMongoCollection<Player> _playerCollection;
        public bool Init(){
            var mongoSetting = new MongoDBSettings();
            mongoSetting.ConnextionURI = "mongodb://sa:0000@localhost:27017";
            mongoSetting.DatabaseName = "astonesport";

            var dbClient = new MongoClient(mongoSetting.ConnextionURI);
            IMongoDatabase db = dbClient.GetDatabase(mongoSetting.DatabaseName);
            _teamCollection = db.GetCollection<Team>("team");
            _playerCollection = db.GetCollection<Player>("player");

            //var player = new Player { FisrtName = "Damien", LastName = "Leusiere", Nationality = "Fran�ais", Role = "Gardien", Pseudo = "Zertyr" };

            //await playerCollection.InsertOneAsync(player);
            return true;
        }
    }
}
*/