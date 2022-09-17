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
    public class TeacherModelsController : Controller
    {
        private readonly ResourceContext _context;

        public TeacherModelsController(ResourceContext context)
        {
            _context = context;
        }

        // GET: TeacherModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.TeacherModels.ToListAsync());
        }

        // GET: TeacherModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacherModel = await _context.TeacherModels
                .FirstOrDefaultAsync(m => m.TeacherId == id);
            if (teacherModel == null)
            {
                return NotFound();
            }

            return View(teacherModel);
        }

        // GET: TeacherModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TeacherModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TeacherId,FirstName,LastName,Email,Address,Contact")] TeacherModel teacherModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teacherModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teacherModel);
        }

        // GET: TeacherModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacherModel = await _context.TeacherModels.FindAsync(id);
            if (teacherModel == null)
            {
                return NotFound();
            }
            return View(teacherModel);
        }

        // POST: TeacherModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TeacherId,FirstName,LastName,Email,Address,Contact")] TeacherModel teacherModel)
        {
            if (id != teacherModel.TeacherId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teacherModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeacherModelExists(teacherModel.TeacherId))
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
            return View(teacherModel);
        }

        // GET: TeacherModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacherModel = await _context.TeacherModels
                .FirstOrDefaultAsync(m => m.TeacherId == id);
            if (teacherModel == null)
            {
                return NotFound();
            }

            return View(teacherModel);
        }

        // POST: TeacherModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teacherModel = await _context.TeacherModels.FindAsync(id);
            _context.TeacherModels.Remove(teacherModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeacherModelExists(int id)
        {
            return _context.TeacherModels.Any(e => e.TeacherId == id);
        }
    }
}
