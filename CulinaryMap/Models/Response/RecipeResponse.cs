using CulinaryMap.Controllers;
using CulinaryMap.Entities;

namespace CulinaryMap.Models.Response
{
    public class RecipeResponse
    {
        public int Id { get; set; }
        public int RegionId { get; set; }
        public string Region { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Name { get; set; }
        public string PrepMode { get; set; }
        public string? History { get; set; }
        public string Type { get; set; }
        public string? PrepTime { get; set; }
        public List<RecipeIngredientResponseModel> Ingredients { get; set; }
        public List<string> Images { get; set; }
    }
}
