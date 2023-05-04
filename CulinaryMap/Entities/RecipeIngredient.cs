namespace CulinaryMap.Entities
{
    public class RecipeIngredient
    {
        public int Id { get; set; }
        public int IngredientId { get; set; }
        public int RecipeId { get; set; }
        public string? Quantity { get; set; }
        public virtual IngredientDetails Ingredient { get; set; }
        public virtual Recipe Recipe { get; set; }

    }
}
