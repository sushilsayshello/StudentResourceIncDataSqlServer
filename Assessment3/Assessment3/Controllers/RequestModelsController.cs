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
    public class RequestModelsController : Controller
    {
        private readonly ResourceContext _context;

        public RequestModelsController(ResourceContext context)
        {
            _context = context;
        }
        public IActionResult Reequest()
        {
            return View();
        }

        // GET: RequestModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Requests.ToListAsync());
        }

        // GET: RequestModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requestModel = await _context.Requests
                .FirstOrDefaultAsync(m => m.RequestId == id);
            if (requestModel == null)
            {
                return NotFound();
            }

            return View(requestModel);
        }

        // GET: RequestModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RequestModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RequestId,StudentId,ResourceId,Approval")] RequestModel requestModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requestModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(requestModel);
        }

        // GET: RequestModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requestModel = await _context.Requests.FindAsync(id);
            if (requestModel == null)
            {
                return NotFound();
            }
            return View(requestModel);
        }

        // POST: RequestModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RequestId,StudentId,ResourceId,Approval")] RequestModel requestModel)
        {
            if (id != requestModel.RequestId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requestModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequestModelExists(requestModel.RequestId))
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
            return View(requestModel);
        }

        // GET: RequestModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requestModel = await _context.Requests
                .FirstOrDefaultAsync(m => m.RequestId == id);
            if (requestModel == null)
            {
                return NotFound();
            }

            return View(requestModel);
        }

        // POST: RequestModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var requestModel = await _context.Requests.FindAsync(id);
            _context.Requests.Remove(requestModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequestModelExists(int id)
        {
            return _context.Requests.Any(e => e.RequestId == id);
        }
    }
}
