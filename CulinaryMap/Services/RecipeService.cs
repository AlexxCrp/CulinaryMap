using AutoMapper;
using CulinaryMap.Entities;
using CulinaryMap.Models.Request;
using CulinaryMap.Models.Response;
using CulinaryMap.Repositories.Interfaces;
using CulinaryMap.Services.Interfaces;

namespace CulinaryMap.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IMapper mapper;
        private readonly IIngredientRepository ingredientRepository;
        private readonly IRecipeRepository recipeRepository;
        private readonly IRegionRepository regionRepository;

        public RecipeService(IMapper mapper, IIngredientRepository ingredientRepository, IRecipeRepository recipeRepository, IRegionRepository regionRepository)
        {
            this.mapper = mapper;
            this.ingredientRepository = ingredientRepository;
            this.recipeRepository = recipeRepository;
            this.regionRepository = regionRepository;
        }

        public async Task<Recipe> CreateRecipe(RecipeModel recipeModel)
        {
            Recipe recipe = await recipeRepository.CreateRecipe(mapper.Map<Recipe>(recipeModel));
            return recipe;
        }

        public void DeleteRecipe(int id)
        {
            recipeRepository.DeleteRecipe(id);
        }

        public async Task<RecipeResponse> GetRecipe(int id)
        {
            Recipe recipe = await recipeRepository.GetRecipeById(id);
            List<RecipeIngredient> recipeIngredients = ingredientRepository.GetRecipeIngredientsByRecipeId(id).ToList();

            RecipeResponse response = mapper.Map<RecipeResponse>(recipe);

            List<IngredientDetails> ingredientDetails = ingredientRepository.GetIngredients().ToList();
            List<RecipeIngredientResponseModel> recipeIngredientResponseModels = new List<RecipeIngredientResponseModel>();

            foreach (var item in recipeIngredients)
            {
                IngredientDetails? currentIngredient = ingredientDetails.FirstOrDefault(i => i.Id == item.IngredientId);

                if (currentIngredient == null || recipe == null)
                {
                    return null;
                }
                RecipeIngredientResponseModel listItem = new RecipeIngredientResponseModel()
                {
                    Id = item.Id,
                    IngredientName = currentIngredient.Name,
                    IngredientId = currentIngredient.Id,
                    RecipeId = recipe.Id,
                    RecipeName = recipe.Name,
                    Quantity = item.Quantity,
                    
                };

                recipeIngredientResponseModels.Add(listItem);
            }

            response.Ingredients = recipeIngredientResponseModels;

            List<Region> regions = regionRepository.GetRegions().ToList();
            response.Region = regions.FirstOrDefault(r => r.Id == recipe.RegionId).Name;

            return response;
        }

        public List<RecipeResponse> GetRecipes()
        {
            List<Recipe> recipes = recipeRepository.GetRecipes().ToList();
            List<RecipeResponse> response = new List<RecipeResponse>();
            List<Region> regions = regionRepository.GetRegions().ToList();

            foreach (var recipe in recipes)
            {
                List<RecipeIngredient> recipeIngredients = ingredientRepository.GetRecipeIngredientsByRecipeId(recipe.Id).ToList();

                RecipeResponse currentRecipe = mapper.Map<RecipeResponse>(recipe);

                List<IngredientDetails> ingredientDetails = ingredientRepository.GetIngredients().ToList();
                List<RecipeIngredientResponseModel> recipeIngredientResponseModels = new List<RecipeIngredientResponseModel>();

                foreach (var item in recipeIngredients)
                {
                    IngredientDetails? currentIngredient = ingredientDetails.FirstOrDefault(i => i.Id == item.IngredientId);

                    if (currentIngredient == null || recipe == null)
                    {
                        return null;
                    }
                    RecipeIngredientResponseModel listItem = new RecipeIngredientResponseModel()
                    {
                        Id = item.Id,
                        IngredientName = currentIngredient.Name,
                        IngredientId = currentIngredient.Id,
                        RecipeId = recipe.Id,
                        RecipeName = recipe.Name,
                        Quantity = item.Quantity,
                    };

                    recipeIngredientResponseModels.Add(listItem);
                }
                currentRecipe.Region = regions.FirstOrDefault(r => r.Id == recipe.RegionId).Name;
                currentRecipe.Ingredients = recipeIngredientResponseModels;
                response.Add(currentRecipe);
            }
            
            return response;
        }

        public async Task<Recipe> UpdateRecipe(UpdateRecipeModel recipeModel)
        {
            Recipe recipe = await recipeRepository.UpdateRecipe(mapper.Map<Recipe>(recipeModel));
            return recipe;
        }
    }
}
