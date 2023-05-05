using CulinaryMap.Entities;
using CulinaryMap.Models.Request;

namespace CulinaryMap.Repositories.Interfaces
{
    public interface IIngredientRepository
    {
        Task<IngredientDetails> CreateIngredient(IngredientDetails ingredient);
        Task<IngredientDetails> UpdateIngredient(IngredientDetails ingredient);
        void DeleteIngredient(int id);
        IQueryable<IngredientDetails> GetIngredients();
        Task<IngredientDetails> GetIngredientById(int id);
        Task<RecipeIngredient> CreateRecipeIngredient(RecipeIngredient ingredient);
        Task<RecipeIngredient> UpdateRecipeIngredient(RecipeIngredient ingredient);
        void DeleteRecipeIngredient(int id);
        IQueryable<RecipeIngredient> GetRecipeIngredients();
        Task<RecipeIngredient> GetRecipeIngredientById(int id);
    }
}
