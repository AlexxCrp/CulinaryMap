using CulinaryMap.Entities;
using CulinaryMap.Models.Request;
using CulinaryMap.Models.Response;

namespace CulinaryMap.Services.Interfaces
{
    public interface IRecipeService
    {
        Task<RecipeResponse> GetRecipe(int id);
        Task<Recipe> UpdateRecipe(UpdateRecipeModel recipeModel);
        void DeleteRecipe(int id);
        Task<Recipe> CreateRecipe(RecipeModel recipeModel);
        List<RecipeResponse> GetRecipes();
    }
}
