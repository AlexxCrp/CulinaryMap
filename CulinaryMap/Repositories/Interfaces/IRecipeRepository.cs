using CulinaryMap.Entities;

namespace CulinaryMap.Repositories.Interfaces
{
    public interface IRecipeRepository
    {
        Task<Recipe> CreateRecipe(Recipe recipe);
        Task<Recipe> UpdateRecipe(Recipe recipe);
        void DeleteRecipe(int id);
        IQueryable<Recipe> GetRecipes();
        Task<Recipe> GetRecipeById(int id);
    }
}
