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
    public class PresupuestoesController : Controller
    {
        private readonly PanopticoSAContext _context;

        public PresupuestoesController(PanopticoSAContext context)
        {
            _context = context;
        }

        // GET: Presupuestoes
        public async Task<IActionResult> Index()
        {
            var panopticoSAContext = _context.Presupuesto.Include(p => p.IdJefeNavigation).Include(p => p.IdServicioNavigation);
            return View(await panopticoSAContext.ToListAsync());
        }

        // GET: Presupuestoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var presupuesto = await _context.Presupuesto
                .Include(p => p.IdJefeNavigation)
                .Include(p => p.IdServicioNavigation)
                .FirstOrDefaultAsync(m => m.IdPresupuesto == id);
            if (presupuesto == null)
            {
                return NotFound();
            }

            return View(presupuesto);
        }

        // GET: Presupuestoes/Create
        public IActionResult Create()
        {
            ViewData["IdJefe"] = new SelectList(_context.Jefe, "IdJefe", "Tipo");
            ViewData["IdServicio"] = new SelectList(_context.Servicio, "IdServicio", "IdServicio");
            return View();
        }

        // POST: Presupuestoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPresupuesto,IdJefe,IdServicio")] Presupuesto presupuesto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(presupuesto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdJefe"] = new SelectList(_context.Jefe, "IdJefe", "Tipo", presupuesto.IdJefe);
            ViewData["IdServicio"] = new SelectList(_context.Servicio, "IdServicio", "IdServicio", presupuesto.IdServicio);
            return View(presupuesto);
        }

        // GET: Presupuestoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var presupuesto = await _context.Presupuesto.FindAsync(id);
            if (presupuesto == null)
            {
                return NotFound();
            }
            ViewData["IdJefe"] = new SelectList(_context.Jefe, "IdJefe", "Tipo", presupuesto.IdJefe);
            ViewData["IdServicio"] = new SelectList(_context.Servicio, "IdServicio", "IdServicio", presupuesto.IdServicio);
            return View(presupuesto);
        }

        // POST: Presupuestoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPresupuesto,IdJefe,IdServicio")] Presupuesto presupuesto)
        {
            if (id != presupuesto.IdPresupuesto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(presupuesto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PresupuestoExists(presupuesto.IdPresupuesto))
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
            ViewData["IdJefe"] = new SelectList(_context.Jefe, "IdJefe", "Tipo", presupuesto.IdJefe);
            ViewData["IdServicio"] = new SelectList(_context.Servicio, "IdServicio", "IdServicio", presupuesto.IdServicio);
            return View(presupuesto);
        }

        // GET: Presupuestoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var presupuesto = await _context.Presupuesto
                .Include(p => p.IdJefeNavigation)
                .Include(p => p.IdServicioNavigation)
                .FirstOrDefaultAsync(m => m.IdPresupuesto == id);
            if (presupuesto == null)
            {
                return NotFound();
            }

            return View(presupuesto);
        }

        // POST: Presupuestoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var presupuesto = await _context.Presupuesto.FindAsync(id);
            _context.Presupuesto.Remove(presupuesto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PresupuestoExists(int id)
        {
            return _context.Presupuesto.Any(e => e.IdPresupuesto == id);
        }
    }
}
