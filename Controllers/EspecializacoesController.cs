using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BENEFICALIGHT.Data;
using BENEFICALIGHT.Models;

namespace BENEFICALIGHT.Controllers
{
    public class EspecializacoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EspecializacoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Especializacoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Especializacao.ToListAsync());
        }

        // GET: Especializacoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var especializacao = await _context.Especializacao
                .FirstOrDefaultAsync(m => m.EspecializacaoId == id);
            if (especializacao == null)
            {
                return NotFound();
            }

            return View(especializacao);
        }

        // GET: Especializacoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Especializacoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EspecializacaoId,Nome")] Especializacao especializacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(especializacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(especializacao);
        }

        // GET: Especializacoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var especializacao = await _context.Especializacao.FindAsync(id);
            if (especializacao == null)
            {
                return NotFound();
            }
            return View(especializacao);
        }

        // POST: Especializacoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EspecializacaoId,Nome")] Especializacao especializacao)
        {
            if (id != especializacao.EspecializacaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(especializacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EspecializacaoExists(especializacao.EspecializacaoId))
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
            return View(especializacao);
        }

        // GET: Especializacoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var especializacao = await _context.Especializacao
                .FirstOrDefaultAsync(m => m.EspecializacaoId == id);
            if (especializacao == null)
            {
                return NotFound();
            }

            return View(especializacao);
        }

        // POST: Especializacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var especializacao = await _context.Especializacao.FindAsync(id);
            if (especializacao != null)
            {
                _context.Especializacao.Remove(especializacao);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EspecializacaoExists(int id)
        {
            return _context.Especializacao.Any(e => e.EspecializacaoId == id);
        }
    }
}
