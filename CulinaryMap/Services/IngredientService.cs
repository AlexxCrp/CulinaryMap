using AutoMapper;
using CulinaryMap.Entities;
using CulinaryMap.Models.Request;
using CulinaryMap.Repositories.Interfaces;
using CulinaryMap.Services.Interfaces;

namespace CulinaryMap.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IMapper mapper;
        private readonly IIngredientRepository repository;

        public IngredientService(IMapper mapper, IIngredientRepository repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        public async Task<IngredientDetails> CreateIngredient(IngredientModel ingredientModel)
        {
            IngredientDetails ingredient = await repository.CreateIngredient(mapper.Map<IngredientDetails>(ingredientModel));
            return ingredient;
        }

        public void DeleteIngredient(int id)
        {
            repository.DeleteIngredient(id);
        }

        public async Task<IngredientDetails> GetIngredient(int id)
        {
            return await repository.GetIngredientById(id);
        }

        public List<IngredientDetails> GetIngredients()
        {
            return repository.GetIngredients().ToList();
        }

        public async Task<IngredientDetails> UpdateIngredient(UpdateIngredientModel ingredientModel)
        {
            IngredientDetails ingredient = await repository.UpdateIngredient(mapper.Map<IngredientDetails>(ingredientModel));
            return ingredient;
        }
    }
}
