namespace CulinaryMap.Models.Response
{
    public class RecipeIngredientResponseModel
    {
        public int Id { get; set; }
        public string IngredientName { get; set; }
        public int IngredientId { get; set; }
        public string RecipeName { get; set; }
        public int RecipeId { get; set; }
        public string? Quantity { get; set; }
    }
}
