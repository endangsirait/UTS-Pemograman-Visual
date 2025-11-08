using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Dealermotor.Models
{
    public class Motor
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Transmission { get; set; } = string.Empty;
        public string FuelType { get; set; } = string.Empty;
        public int Mileage { get; set; }
        public int EngineCapacity { get; set; } // CC untuk motor
        public string Type { get; set; } = string.Empty; // Sport, Cruiser, Scooter, dll
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

