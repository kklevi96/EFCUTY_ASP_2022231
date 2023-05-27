//using EFCUTY_ASP_2022231.Models;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using System.Diagnostics;

//namespace EFCUTY_ASP_2022231.Controllers
//{
//    public class HomeController : Controller
//    {
//        private readonly ILogger<HomeController> _logger;
//        private readonly UserManager<SiteUser> _userManager;
//        private readonly RoleManager<IdentityRole> _roleManager;


//        public HomeController(ILogger<HomeController> logger, UserManager<SiteUser> userManager, RoleManager<IdentityRole> roleManager)
//        {
//            _logger = logger;
//            _userManager = userManager;
//            _roleManager = roleManager;
//        }

//        public IActionResult Index()
//        {
//            return RedirectToAction("Index", "Subjects");
//        }

//        public IActionResult Privacy()
//        {
//            return View();
//        }

//        public async Task<IActionResult> DelegateAdmin()
//        {
//            var principal = this.User;
//            var user = await _userManager.GetUserAsync(principal);
//            var role = new IdentityRole()
//            {
//                Name = "Admin"
//            };
//            if (!await _roleManager.RoleExistsAsync("Admin"))
//            {
//                await _roleManager.CreateAsync(role);
//            }
//            await _userManager.AddToRoleAsync(user, "Admin");
//            return RedirectToAction(nameof(Index));
//        }

//        [Authorize(Roles = "Admin")]
//        public async Task<IActionResult> RemoveAdmin(string uid)
//        {
//            var user = _userManager.Users.FirstOrDefault(t => t.Id == uid);
//            await _userManager.RemoveFromRoleAsync(user, "Admin");
//            return RedirectToAction(nameof(Admin));
//        }

//        [Authorize(Roles = "Admin")]
//        public async Task<IActionResult> GrantAdmin(string uid)
//        {
//            var user = _userManager.Users.FirstOrDefault(t => t.Id == uid);
//            await _userManager.AddToRoleAsync(user, "Admin");
//            return RedirectToAction(nameof(Admin));
//        }


//        [Authorize(Roles = "Admin")]
//        public IActionResult Admin()
//        {
//            return View(_userManager.Users);
//        }

//        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//        public IActionResult Error()
//        {
//            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//        }
//    }
//}