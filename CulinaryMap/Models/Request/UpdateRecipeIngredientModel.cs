namespace CulinaryMap.Models.Request
{
    public class UpdateRecipeIngredientModel
    {
        public int Id { get; set; }
        public int IngredientId { get; set; }
        public int RecipeId { get; set; }
        public string? Quantity { get; set; }
    }
}
