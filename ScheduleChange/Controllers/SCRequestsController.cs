using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScheduleChange.Models;
using ScheduleChange.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleChange.Controllers
{
    public class SCRequestsController : Controller
    {
        private readonly SCContext _context;

        public SCRequestsController(SCContext context)
        {
            _context = context;
        }

        // GET: SCRequests
        public async Task<IActionResult> Index()
        {
            return View(await _context.SCRequests.ToListAsync());
        }

        // GET: SCRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sCRequest = await _context.SCRequests
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sCRequest == null)
            {
                return NotFound();
            }

            return View(sCRequest);
        }

        // GET: SCRequests/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SCRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MessageId,SCType,Airline,FlightNumber,FlightDate,BoardPoint,OffPoint,BoardTime,OffTime,Frequency,DayChangeIndicator,EquipType,EquipConfig,SCReason,Overbooking,ProtectionPlan,VIPNote,OtherNote")] SCRequest sCRequest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sCRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sCRequest);
        }

        // GET: SCRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sCRequest = await _context.SCRequests.FindAsync(id);
            if (sCRequest == null)
            {
                return NotFound();
            }
            return View(sCRequest);
        }

        // POST: SCRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MessageId,SCType,Airline,FlightNumber,FlightDate,BoardPoint,OffPoint,BoardTime,OffTime,Frequency,DayChangeIndicator,EquipType,EquipConfig,SCReason,Overbooking,ProtectionPlan,VIPNote,OtherNote")] SCRequest sCRequest)
        {
            if (id != sCRequest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sCRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SCRequestExists(sCRequest.Id))
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
            return View(sCRequest);
        }

        // GET: SCRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sCRequest = await _context.SCRequests
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sCRequest == null)
            {
                return NotFound();
            }

            return View(sCRequest);
        }

        // POST: SCRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sCRequest = await _context.SCRequests.FindAsync(id);
            _context.SCRequests.Remove(sCRequest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SCRequestExists(int id)
        {
            return _context.SCRequests.Any(e => e.Id == id);
        }
    }
}
