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
    public class ProgrameertaalController : Controller
    {
        private readonly _Portfolio_Site_Dbcontext _context;

        public ProgrameertaalController(_Portfolio_Site_Dbcontext context)
        {
            _context = context;
        }

        // GET: Programeertaal
        public async Task<IActionResult> Index()
        {
            return View(await _context.Programeertaal.ToListAsync());
        }

        // GET: Programeertaal/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programeertaal = await _context.Programeertaal
                .FirstOrDefaultAsync(m => m.Id == id);
            if (programeertaal == null)
            {
                return NotFound();
            }

            return View(programeertaal);
        }

        // GET: Programeertaal/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Programeertaal/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, [Bind("Naam,Kennis")] Programeertaal programeertaal)
        {
            //programeertaal.port_Eigenaar = eigenaar;
            if (ModelState.IsValid)
            {
                Port_Eigenaar eigenaar = await _context.Port_Eigenaar.FindAsync(id);
                programeertaal.port_Eigenaar = eigenaar;
                _context.Add(programeertaal);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(programeertaal);
        }

        // GET: Programeertaal/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programeertaal = await _context.Programeertaal.FindAsync(id);
            if (programeertaal == null)
            {
                return NotFound();
            }
            return View(programeertaal);
        }

        // POST: Programeertaal/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam,Kennis")] Programeertaal programeertaal)
        {
            if (id != programeertaal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(programeertaal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgrameertaalExists(programeertaal.Id))
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
            return View(programeertaal);
        }

        // GET: Programeertaal/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programeertaal = await _context.Programeertaal
                .FirstOrDefaultAsync(m => m.Id == id);
            if (programeertaal == null)
            {
                return NotFound();
            }

            return View(programeertaal);
        }

        // POST: Programeertaal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var programeertaal = await _context.Programeertaal.FindAsync(id);
            _context.Programeertaal.Remove(programeertaal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProgrameertaalExists(int id)
        {
            return _context.Programeertaal.Any(e => e.Id == id);
        }
    }
}
