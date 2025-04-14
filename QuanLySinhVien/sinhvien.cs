using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

public class sinhvien
{
    [BsonId]
    public ObjectId Id { get; set; }

    [BsonElement("name")]
    public string Name { get; set; }

    [BsonElement("birthdate")]
    public DateTime Birthdate { get; set; }

    [BsonElement("class")]
    public string Class { get; set; }

    [BsonElement("email")]
    public string Email { get; set; }

    [BsonElement("gender")]
    public string Gender { get; set; }
}
