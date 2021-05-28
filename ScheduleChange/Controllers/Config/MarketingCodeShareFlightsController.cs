using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScheduleChange.Models.Config;
using ScheduleChange.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleChange.Controllers.Config
{
    public class MarketingCodeShareFlightsController : Controller
    {
        private readonly SCContext _context;

        public MarketingCodeShareFlightsController(SCContext context)
        {
            _context = context;
        }

        // GET: MarketingCodeShareFlights
        public async Task<IActionResult> Index()
        {
            return View(await _context.MarketingCodeShareFlights.ToListAsync());
        }

        // GET: MarketingCodeShareFlights/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marketingCodeShareFlight = await _context.MarketingCodeShareFlights
                .FirstOrDefaultAsync(m => m.Id == id);
            if (marketingCodeShareFlight == null)
            {
                return NotFound();
            }

            return View(marketingCodeShareFlight);
        }

        // GET: MarketingCodeShareFlights/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MarketingCodeShareFlights/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VN_OPS_FlightNumber,MarketingAirline,MarketingFlightNumber,DOW,Segment,CreateBy,CreateDate,UpdateBy,UpdateDate")] MarketingCodeShareFlight marketingCodeShareFlight)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marketingCodeShareFlight);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(marketingCodeShareFlight);
        }

        // GET: MarketingCodeShareFlights/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marketingCodeShareFlight = await _context.MarketingCodeShareFlights.FindAsync(id);
            if (marketingCodeShareFlight == null)
            {
                return NotFound();
            }
            return View(marketingCodeShareFlight);
        }

        // POST: MarketingCodeShareFlights/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,VN_OPS_FlightNumber,MarketingAirline,MarketingFlightNumber,DOW,Segment,CreateBy,CreateDate,UpdateBy,UpdateDate")] MarketingCodeShareFlight marketingCodeShareFlight)
        {
            if (id != marketingCodeShareFlight.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(marketingCodeShareFlight);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarketingCodeShareFlightExists(marketingCodeShareFlight.Id))
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
            return View(marketingCodeShareFlight);
        }

        // GET: MarketingCodeShareFlights/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marketingCodeShareFlight = await _context.MarketingCodeShareFlights
                .FirstOrDefaultAsync(m => m.Id == id);
            if (marketingCodeShareFlight == null)
            {
                return NotFound();
            }

            return View(marketingCodeShareFlight);
        }

        // POST: MarketingCodeShareFlights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var marketingCodeShareFlight = await _context.MarketingCodeShareFlights.FindAsync(id);
            _context.MarketingCodeShareFlights.Remove(marketingCodeShareFlight);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarketingCodeShareFlightExists(int id)
        {
            return _context.MarketingCodeShareFlights.Any(e => e.Id == id);
        }
    }
}
