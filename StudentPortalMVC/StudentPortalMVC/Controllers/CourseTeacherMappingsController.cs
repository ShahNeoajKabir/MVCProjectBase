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
    public class CourseTeacherMappingsController : Controller
    {
        private readonly StudentPortalDbContext _context;

        public CourseTeacherMappingsController(StudentPortalDbContext context)
        {
            _context = context;
        }

        // GET: CourseTeacherMappings
        public async Task<IActionResult> Index()
        {
            var studentPortalDbContext = _context.CourseTeacherMapping.Include(c => c.Course).Include(c => c.Semester).Include(c => c.Teacher);
            return View(await studentPortalDbContext.ToListAsync());
        }

        // GET: CourseTeacherMappings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseTeacherMapping = await _context.CourseTeacherMapping
                .Include(c => c.Course)
                .Include(c => c.Semester)
                .Include(c => c.Teacher)
                .FirstOrDefaultAsync(m => m.CourseTeacherMappingId == id);
            if (courseTeacherMapping == null)
            {
                return NotFound();
            }

            return View(courseTeacherMapping);
        }

        // GET: CourseTeacherMappings/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseId");
            ViewData["SemesterId"] = new SelectList(_context.Semester, "SemesterId", "SemesterName");
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "TeacherId", "Email");
            return View();
        }

        // POST: CourseTeacherMappings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourseTeacherMappingId,CourseId,TeacherId,SemesterId,SectionId,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,Status")] CourseTeacherMapping courseTeacherMapping)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseTeacherMapping);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseId", courseTeacherMapping.CourseId);
            ViewData["SemesterId"] = new SelectList(_context.Semester, "SemesterId", "SemesterName", courseTeacherMapping.SemesterId);
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "TeacherId", "Email", courseTeacherMapping.TeacherId);
            return View(courseTeacherMapping);
        }

        // GET: CourseTeacherMappings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseTeacherMapping = await _context.CourseTeacherMapping.FindAsync(id);
            if (courseTeacherMapping == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseId", courseTeacherMapping.CourseId);
            ViewData["SemesterId"] = new SelectList(_context.Semester, "SemesterId", "SemesterName", courseTeacherMapping.SemesterId);
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "TeacherId", "Email", courseTeacherMapping.TeacherId);
            return View(courseTeacherMapping);
        }

        // POST: CourseTeacherMappings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CourseTeacherMappingId,CourseId,TeacherId,SemesterId,SectionId,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,Status")] CourseTeacherMapping courseTeacherMapping)
        {
            if (id != courseTeacherMapping.CourseTeacherMappingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseTeacherMapping);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseTeacherMappingExists(courseTeacherMapping.CourseTeacherMappingId))
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
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseId", courseTeacherMapping.CourseId);
            ViewData["SemesterId"] = new SelectList(_context.Semester, "SemesterId", "SemesterName", courseTeacherMapping.SemesterId);
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "TeacherId", "Email", courseTeacherMapping.TeacherId);
            return View(courseTeacherMapping);
        }

        // GET: CourseTeacherMappings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseTeacherMapping = await _context.CourseTeacherMapping
                .Include(c => c.Course)
                .Include(c => c.Semester)
                .Include(c => c.Teacher)
                .FirstOrDefaultAsync(m => m.CourseTeacherMappingId == id);
            if (courseTeacherMapping == null)
            {
                return NotFound();
            }

            return View(courseTeacherMapping);
        }

        // POST: CourseTeacherMappings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseTeacherMapping = await _context.CourseTeacherMapping.FindAsync(id);
            _context.CourseTeacherMapping.Remove(courseTeacherMapping);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseTeacherMappingExists(int id)
        {
            return _context.CourseTeacherMapping.Any(e => e.CourseTeacherMappingId == id);
        }
    }
}
