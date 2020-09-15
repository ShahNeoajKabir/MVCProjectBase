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
    public class TeachersController : Controller
    {
        private readonly StudentPortalDbContext _context;

        public TeachersController(StudentPortalDbContext context)
        {
            _context = context;
        }

        // GET: Teachers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Teacher.ToListAsync());
        }

        // GET: Teachers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teacher
                .FirstOrDefaultAsync(m => m.TeacherId == id);
            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        // GET: Teachers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Teachers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TeacherId,TeacherName,TeacherCode,TeacherInitial,Email,Mobile,DateOfBirth,BloodGroup,Address,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,Status,Image")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _context.Database.BeginTransaction();
                teacher.CreatedBy = "CoOrdinator";
                teacher.CreatedDate = DateTime.Now;
                teacher.Status = (int)StudentPortalMVC.Enum.Enum.Status.Active;
                _context.Add(teacher);
                await _context.SaveChangesAsync();

                User user = new User()
                {
                    UserName = teacher.TeacherName,
                    Email = teacher.Email,
                    UserTypeId = (int)StudentPortalMVC.Enum.Enum.UserType.Teacher,
                    Status = (int)StudentPortalMVC.Enum.Enum.Status.Active,
                    CreatedBy = teacher.CreatedBy,
                    CreatedDate = teacher.CreatedDate,
                    Password = "123456",
                    MobileNo = teacher.Mobile
                };
                _context.User.Add(user);
                await _context.SaveChangesAsync();

                UserMapping userMapping = new UserMapping
                {
                    IdentityId = teacher.TeacherId,
                    Status = (int)StudentPortalMVC.Enum.Enum.Status.Active,
                    UserId = user.UserId,
                    CreatedBy = teacher.CreatedBy,
                    CreatedDate = teacher.CreatedDate,
                    UserTypeId = (int)StudentPortalMVC.Enum.Enum.UserType.Teacher
                };
                _context.UserMapping.Add(userMapping);
                await _context.SaveChangesAsync();
                _context.Database.CommitTransaction();
                return RedirectToAction(nameof(Index));
            }
            else { _context.Database.RollbackTransaction(); }
            return View(teacher);
        }

        // GET: Teachers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teacher.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return View(teacher);
        }

        // POST: Teachers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TeacherId,TeacherName,TeacherCode,TeacherInitial,Email,Mobile,DateOfBirth,BloodGroup,Address,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,Status,Image")] Teacher teacher)
        {
            if (id != teacher.TeacherId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teacher);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeacherExists(teacher.TeacherId))
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
            return View(teacher);
        }

        // GET: Teachers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teacher
                .FirstOrDefaultAsync(m => m.TeacherId == id);
            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        // POST: Teachers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teacher = await _context.Teacher.FindAsync(id);
            _context.Teacher.Remove(teacher);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeacherExists(int id)
        {
            return _context.Teacher.Any(e => e.TeacherId == id);
        }
    }
}
