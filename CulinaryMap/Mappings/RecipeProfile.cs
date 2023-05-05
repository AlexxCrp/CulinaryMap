using AutoMapper;
using CulinaryMap.Entities;
using CulinaryMap.Models.Request;
using CulinaryMap.Models.Response;

namespace CulinaryMap.Mappings
{
    public class RecipeProfile : Profile
    {
        public RecipeProfile()
        {
            CreateMap<RecipeModel, Recipe>();
            CreateMap<UpdateRecipeModel, Recipe>();
            CreateMap<Recipe, RecipeResponse>();
        }
    }
}
