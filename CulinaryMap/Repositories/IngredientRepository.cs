using AutoMapper;
using CulinaryMap.Entities;
using CulinaryMap.Models.Request;
using CulinaryMap.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CulinaryMap.Repositories
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly CulinaryMapDbContext dbContext;
        private readonly DbSet<IngredientDetails> ingredientEntities;
        private readonly DbSet<RecipeIngredient> recipeIngredientEntities;

        public IngredientRepository(CulinaryMapDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.ingredientEntities = dbContext.IngredientDetails;
            this.recipeIngredientEntities = dbContext.RecipeIngredients;
        }

        public async Task<IngredientDetails> CreateIngredient(IngredientDetails ingredient)
        {
            ingredientEntities.Add(ingredient);

            int rowsAffected = await dbContext.SaveChangesAsync();
            if(rowsAffected <= 0) 
            {
                return null;
            }

            return ingredient;
        }

        public async Task<RecipeIngredient> CreateRecipeIngredient(RecipeIngredient ingredient)
        {
            recipeIngredientEntities.Add(ingredient);

            int rowsAffected = await dbContext.SaveChangesAsync();
            if (rowsAffected <= 0)
            {
                return null;
            }

            return ingredient;
        }

        public void DeleteIngredient(int id)
        {
            IngredientDetails? ingredient = ingredientEntities.FirstOrDefault(i => i.Id == id);
            ingredientEntities.Remove(ingredient);
            dbContext.SaveChanges();
        }

        public void DeleteRecipeIngredient(int id)
        {
            RecipeIngredient? ingredient = recipeIngredientEntities.FirstOrDefault(i => i.Id == id);
            recipeIngredientEntities.Remove(ingredient);
            dbContext.SaveChanges();
        }

        public async Task<IngredientDetails> GetIngredientById(int id)
        {
            IngredientDetails? ingredient = await ingredientEntities.FirstOrDefaultAsync(i => i.Id == id);

            return ingredient;
        }

        public IQueryable<IngredientDetails> GetIngredients()
        {
            return ingredientEntities.AsQueryable();
        }

        public async Task<RecipeIngredient> GetRecipeIngredientById(int id)
        {
            RecipeIngredient? ingredient = await recipeIngredientEntities.FirstOrDefaultAsync(i => i.Id == id);

            return ingredient;
        }

        public IQueryable<RecipeIngredient> GetRecipeIngredients()
        {
            return recipeIngredientEntities.AsQueryable();
        }

        public async Task<IngredientDetails> UpdateIngredient(IngredientDetails ingredient)
        {
            ingredientEntities.Update(ingredient);
            int rowsAffected = await dbContext.SaveChangesAsync();

            if (rowsAffected <= 0)
            {
                return null;
            }

            return ingredient;
        }

        public async Task<RecipeIngredient> UpdateRecipeIngredient(RecipeIngredient ingredient)
        {
            recipeIngredientEntities.Update(ingredient);
            int rowsAffected = await dbContext.SaveChangesAsync();

            if (rowsAffected <= 0)
            {
                return null;
            }

            return ingredient;
        }
    }
}
