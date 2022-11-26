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

            GetPort_Eigenaar_Lists();
            
            return View(await GetPort_EigenaarAsync());
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

        public async Task<IActionResult> OverMijAsync()
        {
            GetPort_Eigenaar_Lists();
            return View(await GetPort_EigenaarAsync());
        }
        public async Task<IActionResult> Contact()
        {
            GetPort_Eigenaar_Lists();
            return View(await GetPort_EigenaarAsync());
        }

        public async Task<Port_Eigenaar> GetPort_EigenaarAsync() {
            var port_Eigenaar = new Port_Eigenaar() {Naam="...", Leeftijd=0};
            var MiddelbareTemp = new MiddelbareSchool() {Naam="...", Opleiding="...", port_Eigenaar=port_Eigenaar};
            var HogereTemp = new HogereSchool() {Naam="...", Opleiding="...", port_Eigenaar=port_Eigenaar};

            if (_context.Port_Eigenaar.Count()>=1) {
                port_Eigenaar = await _context.Port_Eigenaar.FirstAsync();
            }

            return port_Eigenaar;
        }

        public void GetPort_Eigenaar_Lists()
        {
            var port_EigenaarTemp = new Port_Eigenaar() {Naam="...", Leeftijd=0};
            var Port_Eigenaar = GetPort_EigenaarAsync().Result;
            if (_context.MiddelbareSchools.Count()>=1) {
                ViewBag.Middelbare = _context.MiddelbareSchools.Where(x=>x.port_Eigenaar.Id==Port_Eigenaar.Id).First();
            }
            else {
                ViewBag.Middelbare = new MiddelbareSchool() {Naam="...", Opleiding="...", port_Eigenaar=port_EigenaarTemp};
            }
            if (_context.HogereSchools.Count()>=1) {
                ViewBag.HogereSchool = _context.HogereSchools.Where(x=>x.port_Eigenaar.Id==Port_Eigenaar.Id).First();
            }
            else {
                ViewBag.HogereSchool = new HogereSchool() {Naam="...", Opleiding="...", port_Eigenaar=port_EigenaarTemp};
            }
            if (_context.Hobbys.Count()>=1) {
                ViewBag.Hobbys = _context.Hobbys.Where(x=>x.port_Eigenaar.Id==Port_Eigenaar.Id).ToArray();
                ViewBag.HobbyString = String.Join(", ", _context.Hobbys.Where(x=>x.port_Eigenaar.Id==Port_Eigenaar.Id).Select(x => x.Naam).ToList());
            }
            else {
                ViewBag.Hobbys = _context.Hobbys.Where(x=>x.port_Eigenaar.Id==Port_Eigenaar.Id).ToArray();
                ViewBag.HobbyString = "...";
            }
            if (_context.Programeertaal.Count()>=1) {
                ViewBag.Talen = _context.Programeertaal.Where(x=>x.port_Eigenaar.Id==Port_Eigenaar.Id).ToArray();
                ViewBag.TalenString = String.Join(", ", _context.Programeertaal.Where(x=>x.port_Eigenaar.Id==Port_Eigenaar.Id).Select(x => x.Naam).ToList());
            }
            else {
                ViewBag.Talen = _context.Programeertaal.Where(x=>x.port_Eigenaar.Id==Port_Eigenaar.Id).ToArray();
                ViewBag.TalenString = "...";
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
