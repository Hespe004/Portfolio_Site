using Portfolio_Site.Areas.Identity.Data;
using Portfolio_Site.Data;
using Portfolio_Site.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Portfolio_Site.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly _Portfolio_Site_Dbcontext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<_Portfolio_Site_User> _userManager;

        public HomeController(_Portfolio_Site_Dbcontext context, ILogger<HomeController> logger, RoleManager<IdentityRole> roleManager, UserManager<_Portfolio_Site_User> userManager)
        {
            _roleManager = roleManager;
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }
        public async void CreateRoles() {
            bool ModeratorRoleExists = await _roleManager.RoleExistsAsync("Moderator");
            
            if (!ModeratorRoleExists) {
                await _roleManager.CreateAsync(new IdentityRole { Name = "Moderator" });
            }

        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            CreateRoles();

            var user = await _userManager.GetUserAsync(User);

            if(user!=null) {
                // _3GBuurtappUser user2 = await _userManager.FindByIdAsync(this.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                if (user.UserName.ToString().Equals("admin@admin.nl")) {
                    await _userManager.AddToRoleAsync(user, "Moderator"); 
                }
            }

            var port_Eigenaar = new Port_Eigenaar() {Naam="...", Leeftijd=0, MiddelbareSchool="...", HogereSchool="..."};

            if (_context.Port_Eigenaar.Count()>=1) {
                port_Eigenaar = await _context.Port_Eigenaar.FirstOrDefaultAsync();
            }
            
            return View(port_Eigenaar);
        }
        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Helpdesk()
        {
            return View();
        }
        public IActionResult Rondleiding()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
