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
    public class UserMappingsController : Controller
    {
        private readonly StudentPortalDbContext _context;

        public UserMappingsController(StudentPortalDbContext context)
        {
            _context = context;
        }

        // GET: UserMappings
        public async Task<IActionResult> Index()
        {
            var studentPortalDbContext = _context.UserMapping.Include(u => u.User);
            return View(await studentPortalDbContext.ToListAsync());
        }

        // GET: UserMappings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userMapping = await _context.UserMapping
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.UserMappingId == id);
            if (userMapping == null)
            {
                return NotFound();
            }

            return View(userMapping);
        }

        // GET: UserMappings/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId");
            return View();
        }

        // POST: UserMappings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserMappingId,UserId,UserTypeId,IdentityId,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,Status")] UserMapping userMapping)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userMapping);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId", userMapping.UserId);
            return View(userMapping);
        }

        // GET: UserMappings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userMapping = await _context.UserMapping.FindAsync(id);
            if (userMapping == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId", userMapping.UserId);
            return View(userMapping);
        }

        // POST: UserMappings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserMappingId,UserId,UserTypeId,IdentityId,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,Status")] UserMapping userMapping)
        {
            if (id != userMapping.UserMappingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userMapping);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserMappingExists(userMapping.UserMappingId))
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
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId", userMapping.UserId);
            return View(userMapping);
        }

        // GET: UserMappings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userMapping = await _context.UserMapping
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.UserMappingId == id);
            if (userMapping == null)
            {
                return NotFound();
            }

            return View(userMapping);
        }

        // POST: UserMappings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userMapping = await _context.UserMapping.FindAsync(id);
            _context.UserMapping.Remove(userMapping);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserMappingExists(int id)
        {
            return _context.UserMapping.Any(e => e.UserMappingId == id);
        }
    }
}
