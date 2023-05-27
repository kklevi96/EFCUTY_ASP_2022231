using EFCUTY_ASP_2022231.Models;
using EFCUTY_ASP_2022231.Repository;
using EFCUTY_ASP_2022231.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EFCUTY_ASP_2022231.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsApiController : ControllerBase
    {
        private readonly IPostsRepository repository;
        private readonly UserManager<ApiUser> userManager;

        public PostsApiController(IPostsRepository repository, UserManager<ApiUser> userManager)
        {
            this.repository = repository;
            this.userManager = userManager;
        }


        // GET: Posts
        [HttpGet]

        public IActionResult Index()
        {
            return Ok(this.repository.GetAll());

        }

        // GET: Posts/Details/5
        [HttpGet("Details/{id}")]
        public IActionResult Details(string id)
        {
            var post = this.repository.GetOne(id);

            return Ok(post);
        }

        // POST: Posts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("Create")]
        public IActionResult Create(PostViewModel pvm)
        {
            if (userManager.GetUserId(User) == null)
            {
                return Unauthorized();
            }
            if (ModelState.IsValid)
            {
                Post p = new Post()
                {
                    Content = pvm.Content,
                    SiteUserId = userManager.GetUserId(User),
                    SubjectCode = pvm.SubjectCode,
                    Timestamp = DateTime.Now
                };
                this.repository.Create(p);
                return Ok(p);
            }
            return BadRequest();
        }


        // POST: Posts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut("Edit/{id}")]
        public IActionResult Edit(string id, Post post)
        {
            var p = this.repository.GetOne(id);

            if (!String.IsNullOrEmpty(post.Content))
            {
                if ((userManager.GetUserId(User) == p.SiteUserId) || User.IsInRole("Admin"))
                {

                    var old = this.repository.GetOne(id);
                    old.Content = post.Content;
                    this.repository.Update(old);

                    return Ok();
                }

                return Unauthorized();
            }

            return BadRequest();
        }

        // GET: Posts/Delete/5
        [HttpDelete("Delete")]
        public IActionResult Delete(string id)
        {
            var post = this.repository.GetOne(id);
            if (userManager.GetUserId(User) != post.SiteUserId && !User.IsInRole("Admin"))
            {
                return Unauthorized();
            }
            if (post == null)
            {
                return BadRequest();
            }

            this.repository.Delete(post);
            return Ok();
        }
    }
}
