using CulinaryMap.Entities;
using CulinaryMap.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CulinaryMap.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly CulinaryMapDbContext dbContext;
        private readonly DbSet<Recipe> recipesEntities;

        public RecipeRepository(CulinaryMapDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.recipesEntities = dbContext.Recipes;
        }

        public async Task<Recipe> CreateRecipe(Recipe recipe)
        {
            recipesEntities.Add(recipe);

            int rowsAffected = await dbContext.SaveChangesAsync();
            if (rowsAffected <= 0)
            {
                return null;
            }

            return recipe;
        }

        public void DeleteRecipe(int id)
        {
            Recipe? recipe = recipesEntities.FirstOrDefault(i => i.Id == id);
            recipesEntities.Remove(recipe);
            dbContext.SaveChanges();
        }

        public IQueryable<Recipe> GetRecipes()
        {
            return recipesEntities.AsQueryable();
        }

        public async Task<Recipe> GetRecipeById(int id)
        {
            Recipe? recipe = await recipesEntities.FirstOrDefaultAsync(i => i.Id == id);
            return recipe;
        }

        public async Task<Recipe> UpdateRecipe(Recipe recipe)
        {
            recipesEntities.Update(recipe);
            int rowsAffected = await dbContext.SaveChangesAsync();

            if (rowsAffected <= 0)
            {
                return null;
            }

            return recipe;
        }
    }
}
