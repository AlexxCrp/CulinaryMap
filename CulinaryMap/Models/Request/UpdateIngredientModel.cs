namespace CulinaryMap.Models.Request
{
    public class UpdateIngredientModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Kcal { get; set; }
    }
}
