using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MopShop.Data;
using MopShop.Models;

namespace MopShop.Controllers
{
    public class MopsController : Controller
    {
        private readonly MopShopContext _context;

        public MopsController(MopShopContext context)
        {
            _context = context;
        }

        // GET: Mops
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mops.ToListAsync());
        }

        // GET: Mops/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mops = await _context.Mops
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mops == null)
            {
                return NotFound();
            }

            return View(mops);
        }

        // GET: Mops/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mops/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Type,CleaningPurpose,TypeOfSurface,Material,Price,CustomerRating,ProductImage")] Mops mops)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mops);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mops);
        }

        // GET: Mops/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mops = await _context.Mops.FindAsync(id);
            if (mops == null)
            {
                return NotFound();
            }
            return View(mops);
        }

        // POST: Mops/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Type,CleaningPurpose,TypeOfSurface,Material,Price,CustomerRating,ProductImage")] Mops mops)
        {
            if (id != mops.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mops);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MopsExists(mops.Id))
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
            return View(mops);
        }

        // GET: Mops/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mops = await _context.Mops
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mops == null)
            {
                return NotFound();
            }

            return View(mops);
        }

        // POST: Mops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mops = await _context.Mops.FindAsync(id);
            _context.Mops.Remove(mops);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MopsExists(int id)
        {
            return _context.Mops.Any(e => e.Id == id);
        }
    }
}
