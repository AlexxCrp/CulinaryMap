using CulinaryMap.Entities;
using CulinaryMap.Repositories;
using CulinaryMap.Repositories.Interfaces;
using CulinaryMap.Services;
using CulinaryMap.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "CulinaryMap", Version = "v1" });
        c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
            Name = "Authorization",
            In = ParameterLocation.Header,
            Type = SecuritySchemeType.ApiKey,
            Scheme = "Bearer"
        });
        c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header
                        },
                        new List<string>()
                    }
                });
    });

//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new OpenApiInfo { Title = "CulinaryMap", Version = "v1" });
//    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
//    {
//        Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
//                      Enter 'Bearer' [space] and then your token in the text input below.
//                      \r\n\r\nExample: 'Bearer 12345abcdef'",
//        Name = "Authorization",
//        In = ParameterLocation.Header,
//        Type = SecuritySchemeType.ApiKey,
//        Scheme = "Bearer"
//    });

//    c.AddSecurityRequirement(new OpenApiSecurityRequirement
//                {
//                    {
//                        new OpenApiSecurityScheme
//                        {
//                            Reference = new OpenApiReference
//                            {
//                                Type = ReferenceType.SecurityScheme,
//                                Id = "Bearer"
//                            },
//                            Scheme = "oauth2",
//                            Name = "Bearer",
//                            In = ParameterLocation.Header
//                        },
//                        new List<string>()
//                    }
//                });
//});

builder.Services.AddDbContext<CulinaryMapDbContext>(options => options.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=CulinaryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
builder.Services.AddIdentity<User, Role>()
    .AddRoles<Role>()
    .AddEntityFrameworkStores<CulinaryMapDbContext>();
builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings.
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;

    // Lockout settings.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;

    // User settings.
    options.User.AllowedUserNameCharacters =
    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = true;
});

builder.Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer("AuthScheme", options =>
    {
        options.SaveToken = true;

        var secretKey =
            builder.Configuration
            .GetSection("JwtSettings")
            .GetSection("SecretKey")
            .Get<string>()
            ?? "safhwegfdjgfde8943jgla4920ghd@JG)(h(W)h)S(hS@";

        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,    
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
            ValidateAudience = false,
            ValidateLifetime = true,
            RequireExpirationTime = true,
            ValidateIssuer = false
        };
    });

builder.Services.AddAuthorization(opt =>
{
    opt.AddPolicy("User", policy => policy.RequireRole("User", "Admin").RequireAuthenticatedUser().AddAuthenticationSchemes("AuthScheme").Build());
    opt.AddPolicy("Admin", policy => policy.RequireRole("Admin").RequireAuthenticatedUser().AddAuthenticationSchemes("AuthScheme").Build());

});

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "_allowSpecificOrigins",
        builder =>
        {
            builder
            .WithOrigins("localhost:4200",
            "http://localhost:4200",
            "https://localhost:4200",
            "localhost:4200/",
            "http://localhost:4200/",
            "https://localhost:4200/")
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
});

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddTransient<IIdentityService, IdentityService>();
builder.Services.AddTransient<IIngredientService, IngredientService>();
builder.Services.AddTransient<IIngredientRepository, IngredientRepository>();
builder.Services.AddTransient<IRecipeRepository, RecipeRepository>();
builder.Services.AddTransient<IRecipeService, RecipeService>();
builder.Services.AddTransient<IRegionRepository, RegionRepository>();
builder.Services.AddTransient<IImageRepository, ImageRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors("_allowSpecificOrigins");

app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();
