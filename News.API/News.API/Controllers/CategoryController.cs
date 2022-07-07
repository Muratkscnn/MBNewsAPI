using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.API.Models;
using News.Business.Abstract;
using News.Entity;

namespace News.API.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> GetCategoryList()
        {
            var values = await _categoryService.GetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryWithNews(int id)
        {
            var values = await _categoryService.GetCategoryWithNews(id);
            return Ok(values);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> CategoryUpdate(int id,CategoryAddModel entity)
        {
            var model = await _categoryService.GetById(id);
            if (model==null)
            {
                return BadRequest($"{id} numaralı kategori bulunamadı..");
            }
            model.CategoryName = entity.CategoryName;
            await _categoryService.Update(model);
            return Ok(model);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> CategoryDelete(int id)
        {
            var category = await _categoryService.GetById(id);
            if (category==null)
            {
                return BadRequest($"{id} numaralı kategori bulunamadı..");
            }
            await _categoryService.Delete(category);
            return Ok("Silme işlemi Başarılı..");
        }
       
    }
}
