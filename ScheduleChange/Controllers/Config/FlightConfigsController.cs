using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScheduleChange.Data.Config;
using ScheduleChange.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleChange.Controllers.Config
{
    public class FlightConfigsController : Controller
    {
        private readonly SCCContext _context;

        public FlightConfigsController(SCCContext context)
        {
            _context = context;
        }

        // GET: FlightConfigs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Configs.ToListAsync());
        }

        // GET: FlightConfigs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flightConfig = await _context.Configs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flightConfig == null)
            {
                return NotFound();
            }

            return View(flightConfig);
        }

        // GET: FlightConfigs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FlightConfigs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TableNbr,Carrier,DomeIntl,NumberOfCompartments,EQPCode,NumberOfClasses,Cap1,Cap2,Cap3,Classes,Remark,FromDate,Todate,CreateBy,CreateDate,UpdateBy,UpdateDate")] FlightConfig flightConfig)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flightConfig);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flightConfig);
        }

        // GET: FlightConfigs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flightConfig = await _context.Configs.FindAsync(id);
            if (flightConfig == null)
            {
                return NotFound();
            }
            return View(flightConfig);
        }

        // POST: FlightConfigs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TableNbr,Carrier,DomeIntl,NumberOfCompartments,EQPCode,NumberOfClasses,Cap1,Cap2,Cap3,Classes,Remark,FromDate,Todate,CreateBy,CreateDate,UpdateBy,UpdateDate")] FlightConfig flightConfig)
        {
            if (id != flightConfig.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flightConfig);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlightConfigExists(flightConfig.Id))
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
            return View(flightConfig);
        }

        // GET: FlightConfigs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flightConfig = await _context.Configs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flightConfig == null)
            {
                return NotFound();
            }

            return View(flightConfig);
        }

        // POST: FlightConfigs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flightConfig = await _context.Configs.FindAsync(id);
            _context.Configs.Remove(flightConfig);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlightConfigExists(int id)
        {
            return _context.Configs.Any(e => e.Id == id);
        }
    }
}
