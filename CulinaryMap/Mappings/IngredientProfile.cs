using AutoMapper;
using CulinaryMap.Entities;
using CulinaryMap.Models.Request;

namespace CulinaryMap.Mappings
{
    public class IngredientProfile : Profile
    {
        public IngredientProfile()
        {
            CreateMap<IngredientModel, IngredientDetails>();
            CreateMap<UpdateIngredientModel, IngredientDetails>();
        }
    }
}
