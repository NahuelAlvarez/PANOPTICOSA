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
    public class EmergenciasController : Controller
    {
        private readonly PanopticoSAContext _context;

        public EmergenciasController(PanopticoSAContext context)
        {
            _context = context;
        }

        // GET: Emergencias
        public async Task<IActionResult> Index()
        {
            var panopticoSAContext = _context.Emergencia.Include(e => e.IdClienteNavigation);
            return View(await panopticoSAContext.ToListAsync());
        }

        // GET: Emergencias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emergencia = await _context.Emergencia
                .Include(e => e.IdClienteNavigation)
                .FirstOrDefaultAsync(m => m.IdEmergencia == id);
            if (emergencia == null)
            {
                return NotFound();
            }

            return View(emergencia);
        }

        // GET: Emergencias/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "IdCliente");
            return View();
        }

        // POST: Emergencias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEmergencia,IdCliente,IdJefe")] Emergencia emergencia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emergencia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "IdCliente", emergencia.IdCliente);
            return View(emergencia);
        }

        // GET: Emergencias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emergencia = await _context.Emergencia.FindAsync(id);
            if (emergencia == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "IdCliente", emergencia.IdCliente);
            return View(emergencia);
        }

        // POST: Emergencias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEmergencia,IdCliente,IdJefe")] Emergencia emergencia)
        {
            if (id != emergencia.IdEmergencia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emergencia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmergenciaExists(emergencia.IdEmergencia))
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
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "IdCliente", emergencia.IdCliente);
            return View(emergencia);
        }

        // GET: Emergencias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emergencia = await _context.Emergencia
                .Include(e => e.IdClienteNavigation)
                .FirstOrDefaultAsync(m => m.IdEmergencia == id);
            if (emergencia == null)
            {
                return NotFound();
            }

            return View(emergencia);
        }

        // POST: Emergencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var emergencia = await _context.Emergencia.FindAsync(id);
            _context.Emergencia.Remove(emergencia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmergenciaExists(int id)
        {
            return _context.Emergencia.Any(e => e.IdEmergencia == id);
        }
    }
}
