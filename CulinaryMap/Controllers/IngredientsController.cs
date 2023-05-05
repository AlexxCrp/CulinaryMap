using CulinaryMap.Models.Request;
using CulinaryMap.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CulinaryMap.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientService ingredientService;

        public IngredientsController(IIngredientService ingredientService)
        {
            this.ingredientService = ingredientService;
        }

        [HttpGet("ById")]
        public async Task<IActionResult> GetIngredientById(int id)
        {
            try
            {
                var response = await ingredientService.GetIngredient(id);
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

        [HttpGet("ForRecipeById")]
        public async Task<IActionResult> GetRecipeIngredientById(int id)
        {
            try
            {
                var response = await ingredientService.GetRecipeIngredient(id);
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

        [HttpGet("All")]
        public ActionResult GetAllIngredients()
        {
            try
            {
                var response = ingredientService.GetIngredients();
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

        [HttpGet("AllForRecipe")]
        public ActionResult GetAllRecipeIngredients()
        {
            try
            {
                var response = ingredientService.GetRecipeIngredients();
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
        public async Task<IActionResult> CreateIngredient(IngredientModel model)
        {
            try
            {
                var response = await ingredientService.CreateIngredient(model);
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

        [HttpPost("ForRecipe")]
        public async Task<IActionResult> CreateRecipeIngredient(RecipeIngredientModel model)
        {
            try
            {
                var response = await ingredientService.CreateRecipeIngredient(model);
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
        public async Task<IActionResult> UpdateIngredient(UpdateIngredientModel model)
        {
            try
            {
                var response = await ingredientService.UpdateIngredient(model);
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

        [HttpPut("ForRecipe")]
        public async Task<IActionResult> UpdateRecipeIngredient(UpdateRecipeIngredientModel model)
        {
            try
            {
                var response = await ingredientService.UpdateRecipeIngredient(model);
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
        public IActionResult DeleteIngredient(int id)
        {
            try
            {
                ingredientService.DeleteIngredient(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("ForRecipe")]
        public IActionResult DeleteRecipeIngredient(int id)
        {
            try
            {
                ingredientService.DeleteRecipeIngredient(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
