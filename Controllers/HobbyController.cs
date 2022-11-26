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
    public class HobbyController : Controller
    {
        private readonly _Portfolio_Site_Dbcontext _context;

        public HobbyController(_Portfolio_Site_Dbcontext context)
        {
            _context = context;
        }

        // GET: Hobby
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hobbys.ToListAsync());
        }

        // GET: Hobby/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hobby = await _context.Hobbys
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hobby == null)
            {
                return NotFound();
            }

            return View(hobby);
        }

        // GET: Hobby/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hobby/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, [Bind("Naam")] Hobby hobby)
        {
            if (ModelState.IsValid)
            {
                Port_Eigenaar eigenaar = await _context.Port_Eigenaar.FindAsync(id);
                hobby.port_Eigenaar = eigenaar;
                _context.Add(hobby);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hobby);
        }

        // GET: Hobby/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hobby = await _context.Hobbys.FindAsync(id);
            if (hobby == null)
            {
                return NotFound();
            }
            return View(hobby);
        }

        // POST: Hobby/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam")] Hobby hobby)
        {
            if (id != hobby.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hobby);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HobbyExists(hobby.Id))
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
            return View(hobby);
        }

        // GET: Hobby/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hobby = await _context.Hobbys
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hobby == null)
            {
                return NotFound();
            }

            return View(hobby);
        }

        // POST: Hobby/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hobby = await _context.Hobbys.FindAsync(id);
            _context.Hobbys.Remove(hobby);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HobbyExists(int id)
        {
            return _context.Hobbys.Any(e => e.Id == id);
        }
    }
}
