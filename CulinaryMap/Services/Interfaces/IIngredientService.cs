using CulinaryMap.Entities;
using CulinaryMap.Models.Request;
using CulinaryMap.Models.Response;

namespace CulinaryMap.Services.Interfaces
{
    public interface IIngredientService
    {
        Task<IngredientDetails> GetIngredient(int id);
        Task<IngredientDetails> UpdateIngredient(UpdateIngredientModel ingredientModel);
        void DeleteIngredient(int id);
        Task<IngredientDetails> CreateIngredient(IngredientModel ingredientModel);
        List<IngredientDetails> GetIngredients();
        Task<RecipeIngredientResponseModel> GetRecipeIngredient(int id);
        Task<RecipeIngredient> UpdateRecipeIngredient(UpdateRecipeIngredientModel ingredientModel);
        void DeleteRecipeIngredient(int id);
        Task<RecipeIngredient> CreateRecipeIngredient(RecipeIngredientModel ingredientModel);
        List<RecipeIngredientResponseModel> GetRecipeIngredients();
    }
}
