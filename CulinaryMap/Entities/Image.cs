namespace CulinaryMap.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public string Source { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}
