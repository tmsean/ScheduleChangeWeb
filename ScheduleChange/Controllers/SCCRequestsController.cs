using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ScheduleChange.Data;
using ScheduleChange.Repository;

namespace ScheduleChange.Controllers
{
    public class SCCRequestsController : Controller
    {
        private readonly SCCContext _context;

        public SCCRequestsController(SCCContext context)
        {
            _context = context;
        }

        // GET: SCCRequests
        public async Task<IActionResult> Index()
        {
            return View(await _context.SCCRequests.ToListAsync());
        }

        // GET: SCCRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sCCRequest = await _context.SCCRequests
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sCCRequest == null)
            {
                return NotFound();
            }

            return View(sCCRequest);
        }

        // GET: SCCRequests/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SCCRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MessageId,SCType,Airline,FlightNumber,FlightDate,BoardPoint,OffPoint,BoardTime,OffTime,Frequency,DayChangeIndicator,EquipType,EquipConfig,SCReason,Overbooking,ProtectionPlan,VIPNote,OtherNote")] SCCRequest sCCRequest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sCCRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sCCRequest);
        }

        // GET: SCCRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sCCRequest = await _context.SCCRequests.FindAsync(id);
            if (sCCRequest == null)
            {
                return NotFound();
            }
            return View(sCCRequest);
        }

        // POST: SCCRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MessageId,SCType,Airline,FlightNumber,FlightDate,BoardPoint,OffPoint,BoardTime,OffTime,Frequency,DayChangeIndicator,EquipType,EquipConfig,SCReason,Overbooking,ProtectionPlan,VIPNote,OtherNote")] SCCRequest sCCRequest)
        {
            if (id != sCCRequest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sCCRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SCCRequestExists(sCCRequest.Id))
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
            return View(sCCRequest);
        }

        // GET: SCCRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sCCRequest = await _context.SCCRequests
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sCCRequest == null)
            {
                return NotFound();
            }

            return View(sCCRequest);
        }

        // POST: SCCRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sCCRequest = await _context.SCCRequests.FindAsync(id);
            _context.SCCRequests.Remove(sCCRequest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SCCRequestExists(int id)
        {
            return _context.SCCRequests.Any(e => e.Id == id);
        }
    }
}
