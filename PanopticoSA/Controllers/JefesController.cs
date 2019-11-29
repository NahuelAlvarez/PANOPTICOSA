using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PanopticoSA.Models;

namespace PanopticoSA.Controllers
{
    public class JefesController : Controller
    {
        private readonly PanopticoSAContext _context;

        public JefesController(PanopticoSAContext context)
        {
            _context = context;
        }

        // GET: Jefes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Jefe.ToListAsync());
        }

        // GET: Jefes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jefe = await _context.Jefe
                .FirstOrDefaultAsync(m => m.IdJefe == id);
            if (jefe == null)
            {
                return NotFound();
            }

            return View(jefe);
        }

        // GET: Jefes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Jefes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdJefe,IdEmpleado,Tipo")] Jefe jefe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jefe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jefe);
        }

        // GET: Jefes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jefe = await _context.Jefe.FindAsync(id);
            if (jefe == null)
            {
                return NotFound();
            }
            return View(jefe);
        }

        // POST: Jefes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdJefe,IdEmpleado,Tipo")] Jefe jefe)
        {
            if (id != jefe.IdJefe)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jefe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JefeExists(jefe.IdJefe))
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
            return View(jefe);
        }

        // GET: Jefes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jefe = await _context.Jefe
                .FirstOrDefaultAsync(m => m.IdJefe == id);
            if (jefe == null)
            {
                return NotFound();
            }

            return View(jefe);
        }

        // POST: Jefes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jefe = await _context.Jefe.FindAsync(id);
            _context.Jefe.Remove(jefe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JefeExists(int id)
        {
            return _context.Jefe.Any(e => e.IdJefe == id);
        }
    }
}
