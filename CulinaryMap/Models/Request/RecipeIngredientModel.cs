namespace CulinaryMap.Models.Request
{
    public class RecipeIngredientModel
    {
        public int IngredientId { get; set; }
        public int RecipeId { get; set; }
        public string? Quantity { get; set; }
    }
}
