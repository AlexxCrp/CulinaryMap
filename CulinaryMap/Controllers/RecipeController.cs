using CulinaryMap.Models.Request;
using CulinaryMap.Services;
using CulinaryMap.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace CulinaryMap.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService recipeService;
        public RecipeController(IRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }

        
        [HttpGet("ById")]
        [Authorize(Policy = "User")]
        public async Task<IActionResult> GetRecipeById(int id)
        {
            try
            {
                var response = await recipeService.GetRecipe(id);
                if (response == null)
                {
                    return BadRequest();
                }
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Authorize(Policy = "User")]
        public async Task<IActionResult> GetRecipes()
        {
            try
            {
                var response = recipeService.GetRecipes();
                if (response == null)
                {
                    return BadRequest();
                }
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> CreateRecipe(RecipeModel model)
        {
            try
            {
                var response = await recipeService.CreateRecipe(model);
                if (response == null)
                {
                    return BadRequest();
                }
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> UpdateRecipe(UpdateRecipeModel model)
        {
            try
            {
                var response = await recipeService.UpdateRecipe(model);
                if (response == null)
                {
                    return BadRequest();
                }
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Authorize(Policy = "Admin")]
        public IActionResult DeleteRecipe(int id)
        {
            try
            {
                recipeService.DeleteRecipe(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
