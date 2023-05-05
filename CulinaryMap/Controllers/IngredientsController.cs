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

        [HttpGet("By Id")]
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

        [HttpGet("All")]
        public async Task<IActionResult> GetAllIngredients()
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

        [HttpDelete]
        public async Task<IActionResult> CreateIngredient(int id)
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
    }
}
