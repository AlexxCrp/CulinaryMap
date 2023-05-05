namespace CulinaryMap.Models.Request
{
    public class RecipeModel
    {
        public int RegionId { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string Name { get; set; }
        public string PrepMode { get; set; }
        public string? History { get; set; }
        public string Type { get; set; }
        public string? PrepTime { get; set; }
    }
}
