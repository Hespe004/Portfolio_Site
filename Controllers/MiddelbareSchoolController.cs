using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio_Site.Data;
using Portfolio_Site.Models;

namespace Portfolio_Site.Controllers
{
    public class MiddelbareSchoolController : Controller
    {
        private readonly _Portfolio_Site_Dbcontext _context;

        public MiddelbareSchoolController(_Portfolio_Site_Dbcontext context)
        {
            _context = context;
        }

        // GET: MiddelbareSchool
        public async Task<IActionResult> Index()
        {
            return View(await _context.MiddelbareSchools.ToListAsync());
        }

        // GET: MiddelbareSchool/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var middelbareSchool = await _context.MiddelbareSchools
                .FirstOrDefaultAsync(m => m.Id == id);
            if (middelbareSchool == null)
            {
                return NotFound();
            }

            return View(middelbareSchool);
        }

        // GET: MiddelbareSchool/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MiddelbareSchool/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, [Bind("Naam,Opleiding,Begin_Datum,Eind_Datum")] MiddelbareSchool middelbareSchool)
        {
            if (ModelState.IsValid)
            {
                Port_Eigenaar eigenaar = await _context.Port_Eigenaar.FindAsync(id);
                middelbareSchool.port_Eigenaar = eigenaar;
                _context.Add(middelbareSchool);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(middelbareSchool);
        }

        // GET: MiddelbareSchool/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var middelbareSchool = await _context.MiddelbareSchools.FindAsync(id);
            if (middelbareSchool == null)
            {
                return NotFound();
            }
            return View(middelbareSchool);
        }

        // POST: MiddelbareSchool/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam,Opleiding,Begin_Datum,Eind_Datum")] MiddelbareSchool middelbareSchool)
        {
            if (id != middelbareSchool.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(middelbareSchool);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MiddelbareSchoolExists(middelbareSchool.Id))
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
            return View(middelbareSchool);
        }

        // GET: MiddelbareSchool/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var middelbareSchool = await _context.MiddelbareSchools
                .FirstOrDefaultAsync(m => m.Id == id);
            if (middelbareSchool == null)
            {
                return NotFound();
            }

            return View(middelbareSchool);
        }

        // POST: MiddelbareSchool/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var middelbareSchool = await _context.MiddelbareSchools.FindAsync(id);
            _context.MiddelbareSchools.Remove(middelbareSchool);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MiddelbareSchoolExists(int id)
        {
            return _context.MiddelbareSchools.Any(e => e.Id == id);
        }
    }
}
