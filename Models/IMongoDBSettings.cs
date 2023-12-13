namespace astonesport.Models;

public interface IMongoDBSettings {
    string ConnextionURI {get; set;}
    string DatabaseName {get; set;}
    string CollectionName {get; set;}
}