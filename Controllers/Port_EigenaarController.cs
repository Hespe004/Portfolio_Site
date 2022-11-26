using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio_Site.Data;
using Portfolio_Site.Models;
using Portfolio_Site.ViewModels;
using Microsoft.AspNetCore.Identity;
using Portfolio_Site.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Portfolio_Site.Controllers
{
    public class Port_EigenaarController : Controller
    {
        private readonly _Portfolio_Site_Dbcontext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public Port_EigenaarController(_Portfolio_Site_Dbcontext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Port_Eigenaar
        public async Task<IActionResult> Index()
        {
            return View(await _context.Port_Eigenaar.ToListAsync());
        }

        // GET: Port_Eigenaar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var port_Eigenaar = await _context.Port_Eigenaar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (port_Eigenaar == null)
            {
                return NotFound();
            }

            return View(port_Eigenaar);
        }

        // GET: Port_Eigenaar/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Port_Eigenaar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]        
        public async Task<IActionResult> Create(Port_EigenaarViewModel model)
        {
            if (ModelState.IsValid)  
            {  
                string uniqueFileName = UploadedFile(model);  
  
                Port_Eigenaar employee = new Port_Eigenaar  
                {  
                    Naam = model.Naam,  
                    Leeftijd = model.Leeftijd,
                    Geboortedatum = model.Geboortedatum,
                    Nationaliteit = model.Nationaliteit,
                    Adres = model.Adres,
                    PostCode = model.PostCode,
                    Plaats = model.Plaats,
                    LinkedIn = model.LinkedIn,
                    Telefoon = model.Telefoon,
                    Email = model.Email,
                    BeschrijvingProgrammeer = model.BeschrijvingProgrammeer,
                    ProfilePicture = uniqueFileName,  
                };  
                _context.Add(employee);  
                await _context.SaveChangesAsync();  
                return RedirectToAction(nameof(Index));  
            }  
            return View();  
        }

        // public async Task<IActionResult> Create([Bind("Id,Naam,Leeftijd,Geboortedatum,Adres,BeschrijvingProgrammeer,MiddelbareSchool,HogereSchool,Foto,ImageName")] Port_Eigenaar port_Eigenaar)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         _context.Add(port_Eigenaar);
        //         await _context.SaveChangesAsync();
        //         return RedirectToAction(nameof(Index));
        //     }
        //     return View(port_Eigenaar);
        // }

        private string UploadedFile(Port_EigenaarViewModel model)  
        {  
            string uniqueFileName = null;  
  
            if (model.ProfileImage != null)  
            {  
                string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "images");  
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProfileImage.FileName;  
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);  
                using (var fileStream = new FileStream(filePath, FileMode.Create))  
                {  
                    model.ProfileImage.CopyTo(fileStream);  
                }  
            }  
            return uniqueFileName;  
        }  

        // GET: Port_Eigenaar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var port_Eigenaar = await _context.Port_Eigenaar.FindAsync(id);
            if (port_Eigenaar == null)
            {
                return NotFound();
            }
            return View(port_Eigenaar);
        }

        // POST: Port_Eigenaar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Port_Eigenaar port_Eigenaar)
        {
            if (id != port_Eigenaar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(port_Eigenaar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Port_EigenaarExists(port_Eigenaar.Id))
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
            return View(port_Eigenaar);
        }

        // GET: Port_Eigenaar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var port_Eigenaar = await _context.Port_Eigenaar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (port_Eigenaar == null)
            {
                return NotFound();
            }

            return View(port_Eigenaar);
        }

        // POST: Port_Eigenaar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var port_Eigenaar = await _context.Port_Eigenaar.FindAsync(id);
            _context.Port_Eigenaar.Remove(port_Eigenaar);

            foreach(var item in _context.Programeertaal.Where(x=>x.port_Eigenaar.Id==port_Eigenaar.Id))
                _context.Programeertaal.Remove(item);

            foreach(var item in _context.MiddelbareSchools.Where(x=>x.port_Eigenaar.Id==port_Eigenaar.Id))
                _context.MiddelbareSchools.Remove(item);

            foreach(var item in _context.HogereSchools.Where(x=>x.port_Eigenaar.Id==port_Eigenaar.Id))
                _context.HogereSchools.Remove(item);

            foreach(var item in _context.Hobbys.Where(x=>x.port_Eigenaar.Id==port_Eigenaar.Id))
                _context.Hobbys.Remove(item);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Port_EigenaarExists(int id)
        {
            return _context.Port_Eigenaar.Any(e => e.Id == id);
        }
    }
}
