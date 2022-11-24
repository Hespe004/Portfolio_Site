using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio_Site.Data;
using Portfolio_Site.Models;
using Microsoft.AspNetCore.Identity;
using Portfolio_Site.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Portfolio_Site.Models.ViewModels;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Portfolio_Site.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {
        private readonly _Portfolio_Site_Dbcontext _context;
        private readonly UserManager<_Portfolio_Site_User> _userManager;
        private readonly IWebHostEnvironment _hostEnvironment;
        //private readonly IActionContextAccessor _accessor;

        public ProjectController(_Portfolio_Site_Dbcontext context, UserManager<_Portfolio_Site_User> userManager, IWebHostEnvironment hostEnvironment/*, IActionContextAccessor accessor*/)
        {
            _context = context;
            _userManager = userManager;
            _hostEnvironment = hostEnvironment;
            //_accessor = accessor;
        }

        // GET: Projects
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> Index()
        {
            var wDPR_BuurtApp_3GContext = _context.Projects.Include(m => m.Categorie).Include(m => m.User);
            return View(await wDPR_BuurtApp_3GContext.ToListAsync());
        }

        // GET: Projects/Details/5
        public async Task<IActionResult> Details(int? id, String sorteerVolgorde, string sorteerType)
        {
            if (sorteerType == null)
            {
                sorteerType = "Votes";
            }
            if (sorteerVolgorde == null)
            {
                sorteerVolgorde = "aflopend";
            }
            var user = await _userManager.FindByIdAsync(this.User.FindFirst(ClaimTypes.NameIdentifier).Value);
            //Check of ingelogd user moderator is. Boolean wordt meegestuurd in de viewdata
            ViewData["UserIsModerator"] = false;
            if (await _userManager.IsInRoleAsync(user, "Moderator"))
            {
                ViewData["UserIsModerator"] = true;
            }
            ViewData["sorteerVolgorde"] = sorteerVolgorde;
            ViewData["sorteerType"] = sorteerType;

            ViewData["LoggedInID"] = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (id == null)
            {
                return NotFound();
            }

            var Project = await _context.Projects
                .Include(m => m.User)
                .Include(x=>x.Categorie)
                .FirstOrDefaultAsync(m => m.MeldingID == id);
            if (Project == null)
            {
                return NotFound();
            }

            Project.AantalViews += 1;
            _context.Update(Project);
            await _context.SaveChangesAsync();

            MaakProjectVM reactieVM = new MaakProjectVM();
            return View(Project);
        }
        
        // GET: Projects/Create
        public IActionResult Create()
        {
            ViewData["LoggedInID"] = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["CategorieID"] = new SelectList(_context.Categorie, "CategorieID", "CategorieID");
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id");
            List<Categorie> categorieLijst = _context.Categorie.ToList();
            ViewBag.categorieLijst = categorieLijst;
            return View();
        }
        
        // POST: Projects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectID,UserID,Titel,Omschrijving,CategorieID,ImageFile,Datum,Gesloten")] Project ervaring)
        {
            if(_context.Projects.Where(m => m.Titel.Contains(ervaring.Titel)).Any())
            {
               ModelState.AddModelError("Titel", "Titel lijkt te erg op een bestaande titel.");
            }
            if (ModelState.IsValid)
            {
                //Afbeelding van de Project wordt een generieke "geen afbeelding" indien de gebruiker geen foto upload
                if (ervaring.ImageFile == null)
                {
                    ervaring.ImageName = "geenafbeelding211259326.png";
                }
                else
                {
                    //Verander de filenaam voor het model naar de bestandsnaam + de extensie. De foto wordt opgeslagen in de wwwroot folder.
                    string wwwrootPath = _hostEnvironment.WebRootPath;
                    string FileName = Path.GetFileNameWithoutExtension(ervaring.ImageFile.FileName);
                    string extension = Path.GetExtension(ervaring.ImageFile.FileName);
                    ervaring.ImageName = FileName = FileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwrootPath + "/Images/" + FileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await ervaring.ImageFile.CopyToAsync(fileStream);
                    }
                }

                _context.Add(ervaring);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(OverzichtProjecten));
            }
            ViewData["CategorieID"] = new SelectList(_context.Categorie, "CategorieID", "CategorieID", ervaring.CategorieID);
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", ervaring.UserID);
            ViewData["LoggedInID"] = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            List<Categorie> categorieLijst = _context.Categorie.ToList();
            ViewBag.categorieLijst = categorieLijst;
            return View();
        }
        [Authorize(Roles = "Moderator")]
        // GET: Projects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Project = await _context.Projects.FindAsync(id);
            if (Project == null)
            {
                return NotFound();
            }
            ViewData["CategorieID"] = new SelectList(_context.Categorie, "CategorieID", "CategorieID", Project.CategorieID);
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", Project.UserID);
            return View(Project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectID,UserID,Titel,Omschrijving,CategorieID,Datum,Foto,Gesloten")] Project ervaring)
        {
            if (id != ervaring.MeldingID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ervaring);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectExists(ervaring.MeldingID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategorieID"] = new SelectList(_context.Categorie, "CategorieID", "CategorieID", ervaring.CategorieID);
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", ervaring.UserID);
            return View(ervaring);
        }

        // GET: Projects/Delete/5
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Project = await _context.Projects
                .Include(m => m.Categorie)
                .Include(m => m.User)
                .FirstOrDefaultAsync(m => m.MeldingID == id);
            if (Project == null)
            {
                return NotFound();
            }

            return View(Project);
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Project = await _context.Projects.FindAsync(id);
            _context.Projects.Remove(Project);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(OverzichtProjecten));
        }

        private bool ProjectExists(int id)
        {
            return _context.Projects.Any(e => e.MeldingID == id);
        }

        //Indexpagina die wordt gebruikt om Projecten weer te geven, opgedeeld in pagina's
        public async Task<IActionResult> OverzichtProjecten(int pagina, string sorteerType, string sorteerVolgorde, string filter, string status, string poster, DateTime date1, DateTime date2, bool likedby)
        {
            //var ip = _accessor.ActionContext.HttpContext.Connection.RemoteIpAddress.ToString();
            //Console.WriteLine(ip);
            //Standaardwaarden indien parameters null zijn
            if (sorteerType == null)
            {
                sorteerType = "Datum";
            }
            if (sorteerVolgorde == null)
            {
                sorteerVolgorde = "aflopend";
            }
            if (status == null)
            {
                status = "Open";
            }
            if (poster == null)
            {
                poster = "Toon alles";
            }
            //Viewdatas om de input van de gebruiker te onthouden
            ViewData["Likedby"] = likedby;
            ViewData["Filter"] = filter;
            ViewData["SorteerType"] = sorteerType;
            ViewData["SorteerVolgorde"] = sorteerVolgorde;
            ViewData["Status"] = status;
            ViewData["Poster"] = poster;
            ViewData["Date1"] = DateFormat(date1);
            ViewData["Date2"] = DateFormat(date2);
            ViewData["LoggedInID"] = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            Boolean inclverwijderd = false;
            //Stuur een gepagineerde, gesorteerde en gefilterde lijst mee terug aan de view.
            return View(await GepagineerdeLijst<Project>.CreateAsync(DateRange(Filter(Sort(sorteerVolgorde, sorteerType), filter, status, poster, likedby, inclverwijderd), date1, date2), pagina, 5));
        }

        //Indexpagina die wordt gebruikt om eigen Projecten weer te geven, opgedeeld in pagina's
        public async Task<IActionResult> OverzichtMijnProjecten(int pagina, string sorteerType, string sorteerVolgorde, string filter, DateTime date1, DateTime date2)
        {

            //Standaardwaarden indien parameters null zijn
            if (sorteerType == null)
            {
                sorteerType = "Datum";
            }
            if (sorteerVolgorde == null)
            {
                sorteerVolgorde = "aflopend";
            }
            ViewData["Filter"] = filter;
            ViewData["SorteerType"] = sorteerType;
            ViewData["SorteerVolgorde"] = sorteerVolgorde;
            ViewData["Date1"] = DateFormat(date1);
            ViewData["Date2"] = DateFormat(date2);
            ViewData["LoggedInID"] = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            string poster = "Eigen";
            string status = "Toon alles";
            bool likedby = false;
            bool inclverwijderd = true;
            //Stuur een gepagineerde, gesorteerde en gefilterde lijst mee terug aan de view.
            return View(await GepagineerdeLijst<Project>.CreateAsync(DateRange(Filter(Sort(sorteerVolgorde, sorteerType), filter, status, poster, likedby, inclverwijderd), date1, date2), pagina, 5));
        }

        //Filtermethode die in een meegegeven lijst zoekt naar een bepaalde string. Geeft gefilterde lijst terug.
        private IQueryable<Project> Filter(IQueryable<Project> lijst, string filter, string status, string poster, bool likedby, bool inclverwijderd)
        {

            //Filter de lijst op basis van een zoekopdracht
            if (!String.IsNullOrEmpty(filter))
                lijst = lijst.Where(s => s.Omschrijving.Contains(filter));
            //Filter de lijst op basis van wie de Projectingen in de lijst hebben gedaan (iedereen of alleen de Projecten van de aanvrager)
            switch (poster)
            {
                case "Eigen": lijst = lijst.Where(m => m.UserID == this.User.FindFirst(ClaimTypes.NameIdentifier).Value); break;
                case "Toon alles": break;
            }
            return lijst;
        }

        private IQueryable<Project> DateRange(IQueryable<Project> lijst, DateTime date1, DateTime date2)
        {
            //Nullwaarde instellen
            DateTime datumIsNull = new DateTime(1, 1, 0001, 00, 00, 00);
            if (!date1.Equals(datumIsNull) && !date2.Equals(datumIsNull))
            {
                //Filter de lijst zodat alleen Projecten tussen twee datums erin terug komen. Deze methode is zo geschreven dat het niet uitmaakt als de einddatum vroeger is dan de begindatum.
                List<DateTime> datumlijst = new List<DateTime>() { date1, date2.AddHours(23).AddMinutes(59).AddSeconds(59) };
                lijst = lijst.Where(m => m.Datum >= datumlijst.Min() && m.Datum <= datumlijst.Max());
            }
            //Filter de lijst zodat alleen Projecten terug komen die na de begindatum zijn gemaakt
            else if (!date1.Equals(datumIsNull) && date2.Equals(datumIsNull))
            {
                lijst = lijst.Where(m => m.Datum >= date1);
            }
            //Filter de lijst zodat alleen Projecten terug komen die voor de einddatum zijn gemaakt
            else if (date1.Equals(datumIsNull) && !date2.Equals(datumIsNull))
            {
                lijst = lijst.Where(m => m.Datum <= date2.AddHours(23).AddMinutes(59).AddSeconds(59));
            }
            return lijst;
        }

        //Sorteermethode die lijst sorteerd op basis van de meegegeven parameters.
        private IQueryable<Project> Sort(string sorteerVolgorde, string sorteerType)
        {
            //Maak een nieuwe lijst met Projecten aan
            IQueryable<Project> lijst = _context.Projects.Include(m => m.Categorie).Include(m => m.User);

            //Sorteer op datum oplopend/aflopend
            if (sorteerType == "Datum")
            {
                switch (sorteerVolgorde)
                {
                    case "aflopend": lijst = lijst.OrderByDescending(s => s.Datum); break;
                    default: lijst = lijst.OrderBy(s => s.Datum); break;
                }
            }
            return lijst;
        }

        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> ProjectSluiten(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Project = await _context.Projects
                .Include(m => m.Categorie)
                .Include(m => m.User)
                .FirstOrDefaultAsync(m => m.MeldingID == id);
            if (Project == null)
            {
                return NotFound();
            }

            return View(Project);
        }

        // // POST: Projects/Delete/5
        // [HttpPost, ActionName("ProjectSluiten")]
        // [ValidateAntiForgeryToken]
        // [Authorize(Roles = "Moderator")]
        // public async Task<IActionResult> ProjectSluitenConfirmed(int id)
        // {
        //     //Zoek Project in context, sluit de Project, update de context, sla veranderingen op
        //     var Project = await _context.Projects.FindAsync(id);
        //     _context.ProjectsUpdate(Project);
        //     if (reports.Any())
        //     {
        //         foreach(Report report in reports)
        //         {
        //             _context.Report.Remove(report);
        //         }
        //     }
        //     await _context.SaveChangesAsync();
        //     return RedirectToAction(nameof(OverzichtProjecten));
        // }

        public string DateFormat(DateTime datum)
        {
            //Zet een datetime in het goede format zodat de notatie voor dagen en maanden /01/01 is ipv /1/1
            string maand;
            string dag;

            if (datum.Month.ToString().Length < 2)
            {
                maand = 0 + datum.Month.ToString();
            }
            else maand = datum.Month.ToString();
            if (datum.Day.ToString().Length < 2)
            {
                dag = 0 + datum.Day.ToString();
            }
            else dag = datum.Day.ToString();

            return (datum.Year.ToString() + "-" + maand + "-" + dag);

        }
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> ProjectVerwijderen(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Project = await _context.Projects
                .Include(m => m.Categorie)
                .Include(m => m.User)
                .FirstOrDefaultAsync(m => m.MeldingID == id);
            if (Project == null)
            {
                return NotFound();
            }
            //Viewmodel zodat een moderator een Project kan verwijderen en een reden kan geven voor de verwijdering
            // ProjectVerwijderenVM ProjectVerwijderenVM = new ProjectVerwijderenVM() { Project = Project };
            return View(Project);
        }

        [HttpPost, ActionName("ProjectVerwijderen")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> ProjectVerwijderen(int id, string reden, DateTime verwijderdatum)
        {
            //Sluit de Project en markeer de Project als "wordtverwijderd". De Project wordt 7 dagen na de verwijderdatum verwijderd uit de database. De methode hiervoor staat in de startup.cs
            var Project = await _context.Projects.FindAsync(id);
            Project.Titel = "Verwijderd: " + Project.Titel;
            Project.Omschrijving = "Deze Project is verwijderd en zal op " + verwijderdatum.AddDays(7).ToShortDateString() + " uit de database verdwijnen. Reden: " + reden + " | " + Project.Omschrijving;
            _context.Projects.Update(Project);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(OverzichtProjecten));
        }

    }
}
