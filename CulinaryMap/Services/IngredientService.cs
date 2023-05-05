using AutoMapper;
using CulinaryMap.Entities;
using CulinaryMap.Models.Request;
using CulinaryMap.Models.Response;
using CulinaryMap.Repositories.Interfaces;
using CulinaryMap.Services.Interfaces;

namespace CulinaryMap.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IMapper mapper;
        private readonly IIngredientRepository repository;
        private readonly IRecipeRepository recipeRepository;

        public IngredientService(IMapper mapper, IIngredientRepository repository, IRecipeRepository recipeRepository)
        {
            this.mapper = mapper;
            this.repository = repository;
            this.recipeRepository = recipeRepository;
        }

        public async Task<IngredientDetails> CreateIngredient(IngredientModel ingredientModel)
        {
            IngredientDetails ingredient = await repository.CreateIngredient(mapper.Map<IngredientDetails>(ingredientModel));
            return ingredient;
        }

        public async Task<RecipeIngredient> CreateRecipeIngredient(RecipeIngredientModel ingredientModel)
        {
            RecipeIngredient ingredient = await repository.CreateRecipeIngredient(mapper.Map<RecipeIngredient>(ingredientModel));
            return ingredient;
        }

        public void DeleteIngredient(int id)
        {
            repository.DeleteIngredient(id);
        }

        public void DeleteRecipeIngredient(int id)
        {
            repository.DeleteRecipeIngredient(id);
        }

        public async Task<IngredientDetails> GetIngredient(int id)
        {
            return await repository.GetIngredientById(id);
        }

        public List<IngredientDetails> GetIngredients()
        {
            return repository.GetIngredients().ToList();
        }

        public async Task<RecipeIngredientResponseModel> GetRecipeIngredient(int id)
        {
            RecipeIngredient recipeIngredient = await repository.GetRecipeIngredientById(id);
            IngredientDetails ingredientDetails = await repository.GetIngredientById(recipeIngredient.IngredientId);
            Recipe recipe = await recipeRepository.GetRecipeById(recipeIngredient.RecipeId);
            RecipeIngredientResponseModel responseModel = new RecipeIngredientResponseModel()
            {
                Id= id,
                IngredientName = ingredientDetails.Name,
                IngredientId= ingredientDetails.Id,
                RecipeId = recipeIngredient.RecipeId,
                RecipeName = recipe.Name,
                Quantity = recipeIngredient.Quantity
            };

            return responseModel;
        }

        public List<RecipeIngredientResponseModel> GetRecipeIngredients()
        {
            List<RecipeIngredient> recipeIngredients = repository.GetRecipeIngredients().ToList();
            List<IngredientDetails> ingredientDetails = repository.GetIngredients().ToList();
            List<RecipeIngredientResponseModel> response = new List<RecipeIngredientResponseModel>();
            List<Recipe> recipes = recipeRepository.GetRecipes().ToList();

            foreach (var item in recipeIngredients)
            {
                IngredientDetails? currentIngredient = ingredientDetails.FirstOrDefault(i => i.Id == item.IngredientId);
                Recipe? currentRecipe = recipes.FirstOrDefault(i => i.Id == item.RecipeId);

                if (currentIngredient == null || currentRecipe == null)
                {
                    return null;
                }
                RecipeIngredientResponseModel listItem = new RecipeIngredientResponseModel()
                {
                    Id = item.Id,
                    IngredientName = currentIngredient.Name,
                    IngredientId = currentIngredient.Id,
                    RecipeId = item.RecipeId,
                    RecipeName = currentRecipe.Name,
                    Quantity= item.Quantity,
                };

                response.Add(listItem);
            }

            return response;
        }

        public async Task<IngredientDetails> UpdateIngredient(UpdateIngredientModel ingredientModel)
        {
            IngredientDetails ingredient = await repository.UpdateIngredient(mapper.Map<IngredientDetails>(ingredientModel));
            return ingredient;
        }

        public async Task<RecipeIngredient> UpdateRecipeIngredient(UpdateRecipeIngredientModel ingredientModel)
        {
            RecipeIngredient ingredient = await repository.UpdateRecipeIngredient(mapper.Map<RecipeIngredient>(ingredientModel));
            return ingredient;
        }
    }
}
