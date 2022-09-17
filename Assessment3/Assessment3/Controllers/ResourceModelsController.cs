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
    public class ResourceModelsController : Controller
    {
        private readonly ResourceContext _context;

        public ResourceModelsController(ResourceContext context)
        {
            _context = context;
        }

        // GET: ResourceModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.ResourceModels.ToListAsync());
        }

        // GET: ResourceModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resourceModel = await _context.ResourceModels
                .FirstOrDefaultAsync(m => m.ResourceId == id);
            if (resourceModel == null)
            {
                return NotFound();
            }

            return View(resourceModel);
        }

        // GET: ResourceModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ResourceModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ResourceId,ResourceName,ResourceType,ResourceAvailability,ResourceQuantity")] ResourceModel resourceModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(resourceModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(resourceModel);
        }

        // GET: ResourceModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resourceModel = await _context.ResourceModels.FindAsync(id);
            if (resourceModel == null)
            {
                return NotFound();
            }
            return View(resourceModel);
        }

        // POST: ResourceModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ResourceId,ResourceName,ResourceType,ResourceAvailability,ResourceQuantity")] ResourceModel resourceModel)
        {
            if (id != resourceModel.ResourceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(resourceModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResourceModelExists(resourceModel.ResourceId))
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
            return View(resourceModel);
        }

        // GET: ResourceModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resourceModel = await _context.ResourceModels
                .FirstOrDefaultAsync(m => m.ResourceId == id);
            if (resourceModel == null)
            {
                return NotFound();
            }

            return View(resourceModel);
        }

        // POST: ResourceModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resourceModel = await _context.ResourceModels.FindAsync(id);
            _context.ResourceModels.Remove(resourceModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResourceModelExists(int id)
        {
            return _context.ResourceModels.Any(e => e.ResourceId == id);
        }
    }
}
