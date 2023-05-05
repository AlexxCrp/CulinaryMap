using CulinaryMap.Entities;
using CulinaryMap.Models.Request;

namespace CulinaryMap.Services.Interfaces
{
    public interface IIngredientService
    {
        Task<IngredientDetails> GetIngredient(int id);
        Task<IngredientDetails> UpdateIngredient(UpdateIngredientModel ingredientModel);
        void DeleteIngredient(int id);
        Task<IngredientDetails> CreateIngredient(IngredientModel ingredientModel);
        List<IngredientDetails> GetIngredients();

    }
}
