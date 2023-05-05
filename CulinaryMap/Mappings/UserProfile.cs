using AutoMapper;
using CulinaryMap.Entities;
using CulinaryMap.Models.Request;

namespace CulinaryMap.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<RegisterModel, User>();
        }
    }
}
