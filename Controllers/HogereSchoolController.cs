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
    public class HogereSchoolController : Controller
    {
        private readonly _Portfolio_Site_Dbcontext _context;

        public HogereSchoolController(_Portfolio_Site_Dbcontext context)
        {
            _context = context;
        }

        // GET: HogereSchool
        public async Task<IActionResult> Index()
        {
            return View(await _context.HogereSchools.ToListAsync());
        }

        // GET: HogereSchool/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hogereSchool = await _context.HogereSchools
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hogereSchool == null)
            {
                return NotFound();
            }

            return View(hogereSchool);
        }

        // GET: HogereSchool/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HogereSchool/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, [Bind("Naam,Opleiding,Begin_Datum,Eind_Datum")] HogereSchool hogereSchool)
        {
            if (ModelState.IsValid)
            {
                Port_Eigenaar eigenaar = await _context.Port_Eigenaar.FindAsync(id);
                hogereSchool.port_Eigenaar = eigenaar;
                _context.Add(hogereSchool);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hogereSchool);
        }

        // GET: HogereSchool/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hogereSchool = await _context.HogereSchools.FindAsync(id);
            if (hogereSchool == null)
            {
                return NotFound();
            }
            return View(hogereSchool);
        }

        // POST: HogereSchool/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam,Opleiding,Begin_Datum,Eind_Datum")] HogereSchool hogereSchool)
        {
            if (id != hogereSchool.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hogereSchool);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HogereSchoolExists(hogereSchool.Id))
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
            return View(hogereSchool);
        }

        // GET: HogereSchool/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hogereSchool = await _context.HogereSchools
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hogereSchool == null)
            {
                return NotFound();
            }

            return View(hogereSchool);
        }

        // POST: HogereSchool/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hogereSchool = await _context.HogereSchools.FindAsync(id);
            _context.HogereSchools.Remove(hogereSchool);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HogereSchoolExists(int id)
        {
            return _context.HogereSchools.Any(e => e.Id == id);
        }
    }
}
