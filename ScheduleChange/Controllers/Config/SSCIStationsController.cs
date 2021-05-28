using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ScheduleChange.Repository;
using Webgentle.BookStore.Data;

namespace ScheduleChange.Controllers
{
    public class SSCIStationsController : Controller
    {
        private readonly SCCContext _context;

        public SSCIStationsController(SCCContext context)
        {
            _context = context;
        }

        // GET: SSCIStations
        public async Task<IActionResult> Index()
        {
            return View(await _context.SSCIStations.ToListAsync());
        }

        // GET: SSCIStations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sSCIStation = await _context.SSCIStations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sSCIStation == null)
            {
                return NotFound();
            }

            return View(sSCIStation);
        }

        // GET: SSCIStations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SSCIStations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CityCode,Addresses,EffectiveDateFrom,EffectiveDateTo,CreateBy,CreateDate,UpdateBy,UpdateDate")] SSCIStation sSCIStation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sSCIStation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sSCIStation);
        }

        // GET: SSCIStations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sSCIStation = await _context.SSCIStations.FindAsync(id);
            if (sSCIStation == null)
            {
                return NotFound();
            }
            return View(sSCIStation);
        }

        // POST: SSCIStations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CityCode,Addresses,EffectiveDateFrom,EffectiveDateTo,CreateBy,CreateDate,UpdateBy,UpdateDate")] SSCIStation sSCIStation)
        {
            if (id != sSCIStation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sSCIStation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SSCIStationExists(sSCIStation.Id))
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
            return View(sSCIStation);
        }

        // GET: SSCIStations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sSCIStation = await _context.SSCIStations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sSCIStation == null)
            {
                return NotFound();
            }

            return View(sSCIStation);
        }

        // POST: SSCIStations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sSCIStation = await _context.SSCIStations.FindAsync(id);
            _context.SSCIStations.Remove(sSCIStation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SSCIStationExists(int id)
        {
            return _context.SSCIStations.Any(e => e.Id == id);
        }
    }
}
