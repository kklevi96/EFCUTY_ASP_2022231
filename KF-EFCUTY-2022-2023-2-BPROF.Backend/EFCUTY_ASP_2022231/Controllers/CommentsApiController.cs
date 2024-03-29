﻿using EFCUTY_ASP_2022231.Models;
using EFCUTY_ASP_2022231.Repository;
using EFCUTY_ASP_2022231.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EFCUTY_ASP_2022231.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentsApiController : ControllerBase
    {
        private readonly ICommentsRepository repository;
        private readonly IPostsRepository postsRepository;
        private readonly UserManager<SiteUser> userManager;

        public CommentsApiController(ICommentsRepository repository, UserManager<SiteUser> userManager, IPostsRepository postsRepository)
        {
            this.repository = repository;
            this.userManager = userManager;
            this.postsRepository = postsRepository;
        }

        // GET: Comments
        public IActionResult Index(string postId)
        {
            var vm = new CommentsViewModel(postsRepository.GetOne(postId))
            {
                Comments = this.repository.GetAll()
                .Where(c => c.PostId == postId)
                .OrderBy(c => c.Timestamp)
            };
            return Ok(vm);

        }

        // POST: Comments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public IActionResult Create(Comment comment)
        {
            if (ModelState.IsValid)
            {
                Comment c = new Comment()
                {
                    Content = comment.Content,
                    SiteUserId = userManager.GetUserId(User),
                    PostId = comment.PostId,
                    Timestamp = DateTime.Now
                };
                this.repository.Create(c);
                return Ok(c);
            }
            return BadRequest();
        }

        // POST: Comments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        public IActionResult Edit(string id, Comment comment)
        {
            var c = this.repository.GetOne(id);

            if (!String.IsNullOrEmpty(comment.Content))
            {
                if ((userManager.GetUserId(User) == c.SiteUserId) || User.IsInRole("Admin"))
                {

                    var old = this.repository.GetOne(id);
                    old.Content = comment.Content;
                    this.repository.Update(old);


                    return Ok(old);
                }
                return Unauthorized();

            }
            return BadRequest();
        }

        // GET: Comments/Delete/5
        [Authorize]
        public IActionResult Delete(string id)
        {
            var comment = this.repository.GetOne(id);

            if (comment != null && (userManager.GetUserId(User) == comment.SiteUserId) || User.IsInRole("Admin"))
            {
                this.repository.Delete(comment);
            }

            return Ok(comment);

        }
    }
}
