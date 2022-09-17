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
    public class CourseModelsController : Controller
    {
        private readonly ResourceContext _context;

        public CourseModelsController(ResourceContext context)
        {
            _context = context;
        }

        // GET: CourseModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.CourseModels.ToListAsync());
        }

        // GET: CourseModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseModel = await _context.CourseModels
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (courseModel == null)
            {
                return NotFound();
            }

            return View(courseModel);
        }

        // GET: CourseModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CourseModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourseId,CourseName,CourseUnits")] CourseModel courseModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(courseModel);
        }

        // GET: CourseModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseModel = await _context.CourseModels.FindAsync(id);
            if (courseModel == null)
            {
                return NotFound();
            }
            return View(courseModel);
        }

        // POST: CourseModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CourseId,CourseName,CourseUnits")] CourseModel courseModel)
        {
            if (id != courseModel.CourseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseModelExists(courseModel.CourseId))
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
            return View(courseModel);
        }

        // GET: CourseModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseModel = await _context.CourseModels
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (courseModel == null)
            {
                return NotFound();
            }

            return View(courseModel);
        }

        // POST: CourseModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseModel = await _context.CourseModels.FindAsync(id);
            _context.CourseModels.Remove(courseModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseModelExists(int id)
        {
            return _context.CourseModels.Any(e => e.CourseId == id);
        }
    }
}
