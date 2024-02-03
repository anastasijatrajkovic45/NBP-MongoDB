using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TuristickiHub.Models;
//treba da povezem mongoClient, mongoDatabase i mongoCollection
public class Agencija
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } //id je string!
}