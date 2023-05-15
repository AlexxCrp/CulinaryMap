using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace CulinaryMap.Entities
{
    public class Recipe
    {
        public int Id { get; set; }
        public int RegionId { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Latitude { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Longitude { get; set; }
        public virtual Region Region { get; set; }
        public string Name { get; set; }
        public string PrepMode { get; set; }
        public string? History { get; set; }
        public string Type { get; set; }
        public string? PrepTime { get; set; }
        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}
