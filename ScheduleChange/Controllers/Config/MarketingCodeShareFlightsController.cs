using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScheduleChange.Data.Config;
using ScheduleChange.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleChange.Controllers.Config
{
    public class MarketingCodeShareFlightsController : Controller
    {
        private readonly SCCContext _context;

        public MarketingCodeShareFlightsController(SCCContext context)
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

            var marketingCodeShareFlights = await _context.MarketingCodeShareFlights
                .FirstOrDefaultAsync(m => m.Id == id);
            if (marketingCodeShareFlights == null)
            {
                return NotFound();
            }

            return View(marketingCodeShareFlights);
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
        public async Task<IActionResult> Create([Bind("Id,VN_OPS_FlightNumber,MarketingAirline,MarketingFlightNumber,DOW,Segment,CreateBy,CreateDate,UpdateBy,UpdateDate")] MarketingCodeShareFlights marketingCodeShareFlights)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marketingCodeShareFlights);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(marketingCodeShareFlights);
        }

        // GET: MarketingCodeShareFlights/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marketingCodeShareFlights = await _context.MarketingCodeShareFlights.FindAsync(id);
            if (marketingCodeShareFlights == null)
            {
                return NotFound();
            }
            return View(marketingCodeShareFlights);
        }

        // POST: MarketingCodeShareFlights/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,VN_OPS_FlightNumber,MarketingAirline,MarketingFlightNumber,DOW,Segment,CreateBy,CreateDate,UpdateBy,UpdateDate")] MarketingCodeShareFlights marketingCodeShareFlights)
        {
            if (id != marketingCodeShareFlights.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(marketingCodeShareFlights);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarketingCodeShareFlightsExists(marketingCodeShareFlights.Id))
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
            return View(marketingCodeShareFlights);
        }

        // GET: MarketingCodeShareFlights/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marketingCodeShareFlights = await _context.MarketingCodeShareFlights
                .FirstOrDefaultAsync(m => m.Id == id);
            if (marketingCodeShareFlights == null)
            {
                return NotFound();
            }

            return View(marketingCodeShareFlights);
        }

        // POST: MarketingCodeShareFlights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var marketingCodeShareFlights = await _context.MarketingCodeShareFlights.FindAsync(id);
            _context.MarketingCodeShareFlights.Remove(marketingCodeShareFlights);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarketingCodeShareFlightsExists(int id)
        {
            return _context.MarketingCodeShareFlights.Any(e => e.Id == id);
        }
    }
}
