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
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using EFCUTY_ASP_2022231.ViewModels;
using Microsoft.Extensions.Hosting;

namespace EFCUTY_ASP_2022231.Controllers
{
    public class SubjectsController : Controller
    {
         private readonly ISubjectsRepository repository;
        private readonly UserManager<SiteUser> userManager;

        public SubjectsController(ISubjectsRepository repository, UserManager<SiteUser> userManager)
        {
            this.repository = repository;
            this.userManager = userManager;
        }



        // GET: Subjects
        [Authorize]
        public IActionResult Index()
        {
              return View(this.repository.GetAll().OrderBy(s=>s.Semester));
        }

        // GET: Subjects/Details/5
        [Authorize]
        public IActionResult Details(string id)
        {
            var subject = this.repository.GetOne(id);

            if (id == null || subject == null)
            {
                return NotFound();
            }

            return View(subject);
        }

        // GET: Subjects/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Subjects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        public IActionResult Create(Subject subject)
        {
            if (!String.IsNullOrEmpty(subject.Name) && !String.IsNullOrEmpty(subject.SubjectCode) && User.IsInRole("Admin"))
            {
                Subject n = new Subject()
                {
                    Semester = subject.Semester,
                    CreditValue = subject.CreditValue,
                    ExamSubject = subject.ExamSubject,
                    Name = subject.Name,
                    SubjectCode = subject.SubjectCode
                };
                this.repository.Create(subject);
                return RedirectToAction(nameof(Index));
            }
            return View(subject);
        }

        // GET: Subjects/Edit/5
        [Authorize]
        public IActionResult Edit(string id)
        {
            var subject = this.repository.GetOne(id);

            if(subject != null && User.IsInRole("Admin"))
            {
                return View(subject);
            }

            return RedirectToAction(nameof(Index));
        }

        // POST: Subjects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        public IActionResult Edit(string id, Subject subject)
        {
            if (!String.IsNullOrEmpty(subject.Name))
            {
                var old = this.repository.GetOne(id);

                if (!User.IsInRole("Admin"))
                {
                    return RedirectToAction(nameof(Index));
                }

                old.Name = subject.Name;
                old.Semester = subject.Semester;
                old.ExamSubject = subject.ExamSubject;
                old.CreditValue = subject.CreditValue;
                this.repository.Update(old);

                return RedirectToAction(nameof(Index));
            }
            return View(subject);
        }

        // GET: Subjects/Delete/5
        [Authorize]
        public IActionResult Delete(string id)
        {
            var subject = this.repository.GetOne(id);

            if (subject != null && User.IsInRole("Admin"))
            {
                this.repository.Delete(subject);
            }

            return RedirectToAction(nameof(Index));
        }


    }
}
