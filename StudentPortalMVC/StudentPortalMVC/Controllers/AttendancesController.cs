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
    public class AttendancesController : Controller
    {
        private readonly StudentPortalDbContext _context;

        public AttendancesController(StudentPortalDbContext context)
        {
            _context = context;
        }

        // GET: Attendances
        public async Task<IActionResult> Index()
        {
            var studentPortalDbContext = _context.Attendances.Include(a => a.Course).Include(a => a.Student).Include(a => a.Teacher);
            return View(await studentPortalDbContext.ToListAsync());
        }

        // GET: Attendances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attendances = await _context.Attendances
                .Include(a => a.Course)
                .Include(a => a.Student)
                .Include(a => a.Teacher)
                .FirstOrDefaultAsync(m => m.AttendanceId == id);
            if (attendances == null)
            {
                return NotFound();
            }

            return View(attendances);
        }

        // GET: Attendances/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseId");
            ViewData["StudentId"] = new SelectList(_context.Student, "StudentId", "StudentId");
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "TeacherId", "Email");
            return View();
        }

        // POST: Attendances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AttendanceId,CourseId,TeacherId,StudentId,Attendance,AttendanceDate,SemesterId,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,Status")] Attendances attendances)
        {
            if (ModelState.IsValid)
            {
                _context.Add(attendances);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseId", attendances.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Student, "StudentId", "StudentId", attendances.StudentId);
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "TeacherId", "Email", attendances.TeacherId);
            return View(attendances);
        }

        // GET: Attendances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attendances = await _context.Attendances.FindAsync(id);
            if (attendances == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseId", attendances.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Student, "StudentId", "StudentId", attendances.StudentId);
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "TeacherId", "Email", attendances.TeacherId);
            return View(attendances);
        }

        // POST: Attendances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AttendanceId,CourseId,TeacherId,StudentId,Attendance,AttendanceDate,SemesterId,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,Status")] Attendances attendances)
        {
            if (id != attendances.AttendanceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(attendances);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AttendancesExists(attendances.AttendanceId))
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
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseId", attendances.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Student, "StudentId", "StudentId", attendances.StudentId);
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "TeacherId", "Email", attendances.TeacherId);
            return View(attendances);
        }

        // GET: Attendances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attendances = await _context.Attendances
                .Include(a => a.Course)
                .Include(a => a.Student)
                .Include(a => a.Teacher)
                .FirstOrDefaultAsync(m => m.AttendanceId == id);
            if (attendances == null)
            {
                return NotFound();
            }

            return View(attendances);
        }

        // POST: Attendances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var attendances = await _context.Attendances.FindAsync(id);
            _context.Attendances.Remove(attendances);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AttendancesExists(int id)
        {
            return _context.Attendances.Any(e => e.AttendanceId == id);
        }
    }
}
