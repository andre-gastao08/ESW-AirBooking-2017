using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AirBookingESW17.Data;
using AirBookingESW17.Models;

namespace AirBookingESW17.Controllers
{
    public class AvioesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AvioesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Avioes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Avioes.Include(a => a.Frotas).Include(a => a.Voos);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Avioes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aviao = await _context.Avioes.SingleOrDefaultAsync(m => m.Id == id);
            if (aviao == null)
            {
                return NotFound();
            }

            return View(aviao);
        }

        // GET: Avioes/Create
        public IActionResult Create()
        {
            ViewData["FrotaId"] = new SelectList(_context.Frotas, "FrotaId", "Morada");
            ViewData["VooId"] = new SelectList(_context.Voos, "Id", "Destino");
            return View();
        }

        // POST: Avioes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AvCapacidade,AvNome,AvPartilhado,AvSerie,FrotaId,VooId")] Aviao aviao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aviao);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["FrotaId"] = new SelectList(_context.Frotas, "FrotaId", "Morada", aviao.FrotaId);
            ViewData["VooId"] = new SelectList(_context.Voos, "Id", "Destino", aviao.VooId);
            return View(aviao);
        }

        // GET: Avioes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aviao = await _context.Avioes.SingleOrDefaultAsync(m => m.Id == id);
            if (aviao == null)
            {
                return NotFound();
            }
            ViewData["FrotaId"] = new SelectList(_context.Frotas, "FrotaId", "Nome", aviao.FrotaId);
            ViewData["VooId"] = new SelectList(_context.Voos, "Id", "Origem", aviao.VooId);
            return View(aviao);
        }

        // POST: Avioes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AvCapacidade,AvNome,AvPartilhado,AvSerie,FrotaId,VooId")] Aviao aviao)
        {
            if (id != aviao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aviao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AviaoExists(aviao.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            ViewData["FrotaId"] = new SelectList(_context.Frotas, "FrotaId", "Morada", aviao.FrotaId);
            ViewData["VooId"] = new SelectList(_context.Voos, "Id", "Destino", aviao.VooId);
            return View(aviao);
        }

        // GET: Avioes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aviao = await _context.Avioes.SingleOrDefaultAsync(m => m.Id == id);
            if (aviao == null)
            {
                return NotFound();
            }

            return View(aviao);
        }

        // POST: Avioes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aviao = await _context.Avioes.SingleOrDefaultAsync(m => m.Id == id);
            _context.Avioes.Remove(aviao);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool AviaoExists(int id)
        {
            return _context.Avioes.Any(e => e.Id == id);
        }
    }
}
