namespace CulinaryMap.Entities
{
    public class IngredientDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Kcal { get; set; }
        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
