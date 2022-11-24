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
using Microsoft.AspNetCore.Authorization;
using EFCUTY_ASP_2022231.ViewModels;

namespace EFCUTY_ASP_2022231.Controllers
{
    public class PostsController : Controller
    {
        private readonly IPostsRepository repository;
        private readonly UserManager<SiteUser> userManager;

        public PostsController(IPostsRepository repository, UserManager<SiteUser> userManager)
        {
            this.repository = repository;
            this.userManager = userManager;
        }


        // GET: Posts
        [Authorize]
        public IActionResult Index(string subjectCode)
        {
            var vm = new PostsViewModel()
            {
                Posts = this.repository.GetAll()
                .Where(p => p.SubjectCode == subjectCode)
                .OrderBy(p => p.Timestamp),
                SubjectCode = subjectCode

            };
            return View(vm);
        }

        // GET: Posts/Details/5
        [Authorize]
        public IActionResult Details(string id)
        {
            var post = this.repository.GetOne(id);

            return View(post);
        }

        // GET: Posts/Create
        [Authorize]
        public IActionResult Create(string subjectCode)
        {
            PostViewModel pvm = new()
            {
                SubjectCode = subjectCode
            };
            return View(pvm);
        }

        // POST: Posts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        public IActionResult Create(PostViewModel pvm)
        {
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
                return RedirectToAction(nameof(Index), new
                {
                    subjectCode = p.SubjectCode
                });
            }
            return View(pvm);
        }


        // GET: Posts/Edit/5
        [Authorize]
        public IActionResult Edit(string id)
        {
            var post = this.repository.GetOne(id);

            if (post != null && (User.IsInRole("Admin") || post.SiteUserId == userManager.GetUserId(User)))
            {
                return View(post);
            }

            return RedirectToAction(nameof(Index), new
            {
                subjectCode = post.SubjectCode
            });
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        public IActionResult Edit(string id, Post post)
        {

            if (ModelState.IsValid)
            {
                if (userManager.GetUserId(User) != post.SiteUserId || !User.IsInRole("Admin"))
                {
                    return RedirectToAction(nameof(Index), new
                    {
                        subjectCode = post.SubjectCode
                    });
                }

                var old = this.repository.GetOne(id);
                old.Content = post.Content;


                return RedirectToAction(nameof(Index), new
                {
                    subjectCode = old.SubjectCode,
                });
            }
            return View(post);

        }

        // GET: Posts/Delete/5
        [Authorize]
        public IActionResult Delete(string id)
        {
            var post = this.repository.GetOne(id);

            if (post != null && (userManager.GetUserId(User) == post.SiteUserId) || User.IsInRole("Admin"))
            {
                this.repository.Delete(post);
            }

            return RedirectToAction(nameof(Index), new
            {
                subjectCode = post.SubjectCode
            });
        }
    }
}
