using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.API.Models;
using News.Business.Abstract;
using News.DataAccess.Abstract;
using News.Entity;
using System.Net;

namespace News.API.Controllers
{
    
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        private IInfoService _infoService;

        public InfoController(IInfoService infoService)
        {
            _infoService = infoService;
        }
        [HttpGet]
        public async Task<IActionResult> GetNews()
        {
            var infos = await _infoService.GetList();
            return Ok(infos);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetNewsByIdWithAllDetails(int id)
        {
            var info = await _infoService.GetByIdWithAllDetails(id);
            return Ok(info);
        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> NewsAdd(NewsAddModel entity)
        {
            Info model = new Info()
            {
                CategoryId = entity.CategoryId,
                Content = entity.NewsContent,
                ImageUrl = entity.ImageUrl,
                NewsName = entity.NewsName
            };
            await _infoService.Add(model);
            return Ok();
        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> NewsUpdate(int id, NewsAddModel entity)
        {
            var news=await _infoService.GetById(id);
            if (news==null)
            {
                return BadRequest($"{id} no'lu haber bulunamadı");
            }
            news.Content = entity.NewsContent;
            news.ImageUrl = entity.ImageUrl;
            news.NewsName = entity.NewsName;
            news.CategoryId = entity.CategoryId;
            await _infoService.Update(news);
            return Ok(news);
        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> NewsDelete(int id)
        {
            var model = await _infoService.GetById(id);
            await _infoService.Delete(model);
            return Ok(model);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLastNewsById(int id)
        {
            var news=await _infoService.GetLastNewsById(id);
            return Ok(news);
        }
    }
}
