using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using News.API.Models;
using News.Business.Abstract;
using News.Entity;

namespace News.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private ICommentService _commentService;
        private UserManager<AppUser> _userManager;

        public CommentController(ICommentService commentService, UserManager<AppUser> userManager)
        {
            _commentService = commentService;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> CommentAdd(CommentAddModel entity)
        {
            var userid = User.Claims.FirstOrDefault(x => x.Type == "id").Value;
            var user = await _userManager.FindByIdAsync(userid);
            Comment model = new Comment() { InfoId = entity.InfoId, AppUserId = user.Id, Content = entity.Content };
            var value = await _commentService.CreateAsync(model);
            return Ok(entity);
        }
    }
}
