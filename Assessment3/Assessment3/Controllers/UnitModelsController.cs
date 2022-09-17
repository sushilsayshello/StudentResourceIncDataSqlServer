using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assessment3.Data;
using Assessment3.Models;

namespace Assessment3.Controllers
{
    public class UnitModelsController : Controller
    {
        private readonly ResourceContext _context;

        public UnitModelsController(ResourceContext context)
        {
            _context = context;
        }

        // GET: UnitModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.UnitModels.ToListAsync());
        }

        // GET: UnitModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unitModel = await _context.UnitModels
                .FirstOrDefaultAsync(m => m.UnitId == id);
            if (unitModel == null)
            {
                return NotFound();
            }

            return View(unitModel);
        }

        // GET: UnitModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UnitModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UnitId,UnitSpecification,ResourceRequirements")] UnitModel unitModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(unitModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(unitModel);
        }

        // GET: UnitModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unitModel = await _context.UnitModels.FindAsync(id);
            if (unitModel == null)
            {
                return NotFound();
            }
            return View(unitModel);
        }

        // POST: UnitModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UnitId,UnitSpecification,ResourceRequirements")] UnitModel unitModel)
        {
            if (id != unitModel.UnitId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(unitModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UnitModelExists(unitModel.UnitId))
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
            return View(unitModel);
        }

        // GET: UnitModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unitModel = await _context.UnitModels
                .FirstOrDefaultAsync(m => m.UnitId == id);
            if (unitModel == null)
            {
                return NotFound();
            }

            return View(unitModel);
        }

        // POST: UnitModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var unitModel = await _context.UnitModels.FindAsync(id);
            _context.UnitModels.Remove(unitModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UnitModelExists(int id)
        {
            return _context.UnitModels.Any(e => e.UnitId == id);
        }
    }
}
