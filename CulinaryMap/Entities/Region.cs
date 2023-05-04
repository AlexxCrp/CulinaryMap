namespace CulinaryMap.Entities
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CulinaryHistory { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
