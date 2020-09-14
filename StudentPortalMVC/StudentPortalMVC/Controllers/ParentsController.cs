using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentPortalMVC.Models;

namespace StudentPortalMVC.Controllers
{
    public class ParentsController : Controller
    {
        private readonly StudentPortalDbContext _context;

        public ParentsController(StudentPortalDbContext context)
        {
            _context = context;
        }

        // GET: Parents
        public async Task<IActionResult> Index()
        {
            var studentPortalDbContext = _context.Parents.Include(p => p.Student);
            return View(await studentPortalDbContext.ToListAsync());
        }

        // GET: Parents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parents = await _context.Parents
                .Include(p => p.Student)
                .FirstOrDefaultAsync(m => m.ParentsId == id);
            if (parents == null)
            {
                return NotFound();
            }

            return View(parents);
        }

        // GET: Parents/Create
        public IActionResult Create()
        {
            ViewData["StudentId"] = new SelectList(_context.Student, "StudentId", "StudentId");
            return View();
        }

        // POST: Parents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ParentsId,StudentId,ParentsName,Email,MobileNo,BloodGroup,Address,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,Status,Image")] Parents parents)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parents);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StudentId"] = new SelectList(_context.Student, "StudentId", "StudentId", parents.StudentId);
            return View(parents);
        }

        // GET: Parents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parents = await _context.Parents.FindAsync(id);
            if (parents == null)
            {
                return NotFound();
            }
            ViewData["StudentId"] = new SelectList(_context.Student, "StudentId", "StudentId", parents.StudentId);
            return View(parents);
        }

        // POST: Parents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ParentsId,StudentId,ParentsName,Email,MobileNo,BloodGroup,Address,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,Status,Image")] Parents parents)
        {
            if (id != parents.ParentsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parents);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParentsExists(parents.ParentsId))
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
            ViewData["StudentId"] = new SelectList(_context.Student, "StudentId", "StudentId", parents.StudentId);
            return View(parents);
        }

        // GET: Parents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parents = await _context.Parents
                .Include(p => p.Student)
                .FirstOrDefaultAsync(m => m.ParentsId == id);
            if (parents == null)
            {
                return NotFound();
            }

            return View(parents);
        }

        // POST: Parents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var parents = await _context.Parents.FindAsync(id);
            _context.Parents.Remove(parents);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParentsExists(int id)
        {
            return _context.Parents.Any(e => e.ParentsId == id);
        }
    }
}
