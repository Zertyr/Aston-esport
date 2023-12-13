using astonesport.Models;

namespace aston_esport.Models
{
    public class PlayerStoreDatabaseSettings : IMongoDBSettings
    {
        public string ConnextionURI { get; set; } = "mongodb://sa:0000@localhost:27017";
        public string DatabaseName { get; set; } = "astonesport";
        public string CollectionName { get; set; } = "player";
    }
}
