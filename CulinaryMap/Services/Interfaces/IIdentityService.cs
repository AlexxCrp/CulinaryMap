using CulinaryMap.Entities;
using CulinaryMap.Models.Request;

namespace CulinaryMap.Services.Interfaces
{
    public interface IIdentityService
    {
        Task<string> Login(LoginModel loginModel);
        Task<string> Register(RegisterModel registerModel);
    }
}
