﻿using AutoMapper;
using CulinaryMap.Entities;
using CulinaryMap.Models.Request;
using CulinaryMap.Models.Response;
using CulinaryMap.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
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

        public async Task<AuthResponseModel> Login(LoginModel loginModel)
        {
            User? user = await userManager.FindByEmailAsync(loginModel.Email);
            if (user is null)
            {
                throw new Exception($"User inexistent");
            }

            bool userHasValidPassword = await userManager.CheckPasswordAsync(user, loginModel.Password);
            if(!userHasValidPassword) 
            {
                throw new Exception($"Utilizatorul cu adresa de email {loginModel.Email} nu exista");
            }

            string token = await CreateToken(user);
            var role = await userManager.GetRolesAsync(user);

            return new AuthResponseModel() { Token = token, Role = role[0] };

        }

        public async Task<AuthResponseModel> Register(RegisterModel registerModel)
        {
            User? existingUser = await userManager.FindByEmailAsync(registerModel.Email);
            if (existingUser is not null) 
            {
                throw new Exception($"Email {registerModel.Email} deja inregistrat");
            }

            User newUser = mapper.Map<User>(registerModel);
            newUser.UserName = registerModel.Email;

            var result = await userManager.CreateAsync(newUser, registerModel.Password);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(newUser, registerModel.Role);
            }
            string token = await CreateToken(newUser);
            var role = await userManager.GetRolesAsync(newUser);


            return new AuthResponseModel() { Token = token, Role = role[0] };

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
