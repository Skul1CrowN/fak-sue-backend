using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Backend.Models;

public class Blog
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = ObjectId.GenerateNewId().ToString();

    [BsonElement("topic")] 
    public string Topic { get; set; } = null!;

    [BsonElement("detail")] 
    public string Detail { get; set; } = "";

    [BsonElement("timestamp")] 
    public DateTime TimeStamp { get; set; } = DateTime.Now;

    [BsonElement("user_id")]
    [BsonRepresentation(BsonType.ObjectId)]
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = null!;

    [BsonElement("hide")]
    [JsonPropertyName("hide")]
    public bool Hide { get; set; } = false;

    [BsonElement("deleted")]
    [JsonPropertyName("deleted")]
    public bool Deleted { get; set; } = false;
    
    [BsonElement("created_date")]
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    
    [BsonElement("updated_date")]
    public DateTime UpdatedDate { get; set; } = DateTime.Now;
}