using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EFCUTY_ASP_2022231.Data;
using EFCUTY_ASP_2022231.Models;
using EFCUTY_ASP_2022231.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;
using EFCUTY_ASP_2022231.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace EFCUTY_ASP_2022231.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ICommentsRepository repository;
        private readonly UserManager<SiteUser> userManager;

        public CommentsController(ICommentsRepository repository, UserManager<SiteUser> userManager)
        {
            this.repository = repository;
            this.userManager = userManager;
        }


        // GET: Comments
        public IActionResult Index(string postId)
        {
            var vm = new CommentsViewModel()
            {
                Comments = this.repository.GetAll()
                .Where(c => c.PostId == postId)
                .OrderBy(c => c.Timestamp),
                PostId = postId
            };
            return View(vm);

        }

        // GET: Comments/Create
        [Authorize]
        public IActionResult Create(string postId)
        {
            CommentViewModel cvm = new()
            {
                PostId = postId
            };
            return View(cvm);
        }

        // POST: Comments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        public IActionResult Create(CommentViewModel cvm)
        {
            if (ModelState.IsValid)
            {
                Comment c = new Comment()
                {
                    Content = cvm.Content,
                    SiteUserId = userManager.GetUserId(User),
                    PostId = cvm.PostId,
                    Timestamp = DateTime.Now
                };
                this.repository.Create(c);
                return RedirectToAction(nameof(Index), new
                {
                    postId = c.PostId
                });
            }
            return View(cvm);
        }

        // GET: Comments/Edit/5
        [Authorize]
        public IActionResult Edit(string id)
        {
            var comment = this.repository.GetOne(id);


            if (comment != null && (User.IsInRole("Admin") || comment.SiteUserId == userManager.GetUserId(User)))
            {
                return View(comment);
            }

            return RedirectToAction(nameof(Index), new
            {
                postId = comment.PostId
            });
        }

        // POST: Comments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        public IActionResult Edit(string id, Comment comment)
        {
            if (ModelState.IsValid)
            {
                if (userManager.GetUserId(User) != comment.SiteUserId || !User.IsInRole("Admin"))
                {
                    return RedirectToAction(nameof(Index), new
                    {
                        postId = comment.PostId
                    });
                }

                var old = this.repository.GetOne(id);
                old.Content = comment.Content;


                return RedirectToAction(nameof(Index), new
                {
                    postId=old.PostId
                });
            }
            return View(comment);
        }

        // GET: Comments/Delete/5
        public IActionResult Delete(string id)
        {
            var comment = this.repository.GetOne(id);

            if (comment != null && (userManager.GetUserId(User) != comment.SiteUserId) || User.IsInRole("Admin"))
            {
                this.repository.Delete(comment);
            }

            return RedirectToAction(nameof(Index), new
            {
                postId = comment.PostId
            });

        }
    }
}
