using AutoMapper;
using CulinaryMap.Entities;
using CulinaryMap.Models.Request;
using CulinaryMap.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CulinaryMap.Services
{
    public class IdentityService :IIdentityService
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly IConfiguration configuration;
        private readonly IMapper mapper;

        public IdentityService(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration, IMapper mapper)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.configuration = configuration;
            this.mapper = mapper;
        }

        public async Task<string> Login(LoginModel loginModel)
        {
            User? user = await userManager.FindByEmailAsync(loginModel.Email);
            if (user is null)
            {
                return $"Utilizatorul cu adresa de email {loginModel.Email} nu exista";
            }

            bool userHasValidPassword = await userManager.CheckPasswordAsync(user, loginModel.Password);
            if(!userHasValidPassword) 
            {
                return "Logarea a esuat, incearca din nou!";
            }

            string token = await CreateToken(user);

            return token;

        }

        public async Task<string> Register(RegisterModel registerModel)
        {
            User? existingUser = await userManager.FindByEmailAsync(registerModel.Email);
            if (existingUser is not null) 
            {
                return $"Email {registerModel.Email} deja inregistrat";
            }

            User newUser = mapper.Map<User>(registerModel);
            newUser.UserName = registerModel.Email;

            var result = await userManager.CreateAsync(newUser, registerModel.Password);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(newUser, registerModel.Role);
            }
            string token = await CreateToken(newUser);

            return token;

        }

        private async Task<string> CreateToken(User user)
        {
            byte[] secretKey = Encoding.UTF8.GetBytes(configuration.GetSection("JwtSettings").GetSection("SecretKey").Get<string>());
            var roles = await userManager.GetRolesAsync(user);
            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.NameId, user.Id)
            };

            foreach(var role in roles) 
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            SecurityTokenDescriptor tokenDescriptor = new()
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKey), SecurityAlgorithms.HmacSha256Signature)
            };

            JwtSecurityTokenHandler tokenHandler = new();
            SecurityToken securityToken = tokenHandler.CreateToken(tokenDescriptor);
            string token = tokenHandler.WriteToken(securityToken);

            return token;
        }
    }
}
