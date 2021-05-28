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
    public class ThreeCompartmentsFlightsController : Controller
    {
        private readonly SCCContext _context;

        public ThreeCompartmentsFlightsController(SCCContext context)
        {
            _context = context;
        }

        // GET: ThreeCompartmentsFlights
        public async Task<IActionResult> Index()
        {
            return View(await _context.ThreeCompartmentsFlights.ToListAsync());
        }

        // GET: ThreeCompartmentsFlights/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var threeCompartmentsFlight = await _context.ThreeCompartmentsFlights
                .FirstOrDefaultAsync(m => m.Id == id);
            if (threeCompartmentsFlight == null)
            {
                return NotFound();
            }

            return View(threeCompartmentsFlight);
        }

        // GET: ThreeCompartmentsFlights/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ThreeCompartmentsFlights/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FlightNumber,DepDateFrom,DepDateTo,CreateBy,CreateDate,UpdateBy,UpdateDate")] ThreeCompartmentsFlight threeCompartmentsFlight)
        {
            if (ModelState.IsValid)
            {
                _context.Add(threeCompartmentsFlight);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(threeCompartmentsFlight);
        }

        // GET: ThreeCompartmentsFlights/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var threeCompartmentsFlight = await _context.ThreeCompartmentsFlights.FindAsync(id);
            if (threeCompartmentsFlight == null)
            {
                return NotFound();
            }
            return View(threeCompartmentsFlight);
        }

        // POST: ThreeCompartmentsFlights/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FlightNumber,DepDateFrom,DepDateTo,CreateBy,CreateDate,UpdateBy,UpdateDate")] ThreeCompartmentsFlight threeCompartmentsFlight)
        {
            if (id != threeCompartmentsFlight.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(threeCompartmentsFlight);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThreeCompartmentsFlightExists(threeCompartmentsFlight.Id))
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
            return View(threeCompartmentsFlight);
        }

        // GET: ThreeCompartmentsFlights/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var threeCompartmentsFlight = await _context.ThreeCompartmentsFlights
                .FirstOrDefaultAsync(m => m.Id == id);
            if (threeCompartmentsFlight == null)
            {
                return NotFound();
            }

            return View(threeCompartmentsFlight);
        }

        // POST: ThreeCompartmentsFlights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var threeCompartmentsFlight = await _context.ThreeCompartmentsFlights.FindAsync(id);
            _context.ThreeCompartmentsFlights.Remove(threeCompartmentsFlight);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThreeCompartmentsFlightExists(int id)
        {
            return _context.ThreeCompartmentsFlights.Any(e => e.Id == id);
        }
    }
}
