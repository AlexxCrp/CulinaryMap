using CulinaryMap.Controllers;

namespace CulinaryMap.Models.Response
{
    public class RecipeResponse
    {
        public int Id { get; set; }
        public int RegionId { get; set; }
        public string Region { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string Name { get; set; }
        public string PrepMode { get; set; }
        public string? History { get; set; }
        public string Type { get; set; }
        public string? PrepTime { get; set; }
        public List<RecipeIngredientResponseModel> Ingredients { get; set; }
    }
}
