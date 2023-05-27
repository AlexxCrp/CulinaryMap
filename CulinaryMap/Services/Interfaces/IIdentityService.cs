using CulinaryMap.Entities;
using CulinaryMap.Models.Request;
using CulinaryMap.Models.Response;

namespace CulinaryMap.Services.Interfaces
{
    public interface IIdentityService
    {
        Task<AuthResponseModel> Login(LoginModel loginModel);
        Task<AuthResponseModel> Register(RegisterModel registerModel);
    }
}
