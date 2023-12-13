using astonesport.Models;
using MongoDB.Bson;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
var mongoSetting = new MongoDBSettings();
mongoSetting.ConnextionURI = "mongodb://sa:0000@localhost:27017";
mongoSetting.DatabaseName = "astonesport";
mongoSetting.CollectionName = "player";

var dbClient = new MongoClient(mongoSetting.ConnextionURI);
IMongoDatabase db = dbClient.GetDatabase(mongoSetting.DatabaseName);
var playerCollection = db.GetCollection<Player>(mongoSetting.CollectionName);

var player = new Player { FisrtName = "Damien", LastName = "Leusiere", Nationality = "Français", Role = "Gardien", Pseudo = "Zertyr" };

await playerCollection.InsertOneAsync(player);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
