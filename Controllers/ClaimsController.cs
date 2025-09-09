using Microsoft.AspNetCore.Mvc;
using CMCSPrototype.Models;
using System.Collections.Generic;

namespace CMCSPrototype.Controllers
{
    public class ClaimsController : Controller
    {
        // Sample data for prototype views
        private static readonly List<Claim> SampleClaims = new()
        {
            new Claim { Id = 1, LecturerName = "t.mokoena", ClaimMonth = "March 2025", HoursWorked = 12, HourlyRate = 450, Status = "Pending", SupportingDocument = "timesheet_mar.pdf" },
            new Claim { Id = 2, LecturerName = "n.khanye",   ClaimMonth = "March 2025", HoursWorked = 8,  HourlyRate = 500, Status = "Approved", SupportingDocument = "timesheet_mar.pdf" },
            new Claim { Id = 3, LecturerName = "a.naidoo",   ClaimMonth = "April 2025", HoursWorked = 10, HourlyRate = 420, Status = "Pending", SupportingDocument = "evidence.zip" }
        };

        // Front-end prototype screens
        [HttpGet]
        public IActionResult Submit()
        {
            return View(new Claim());
        }

        // Prototype: no server processing; show a banner via TempData
        [HttpPost]
        public IActionResult Submit(Claim _)
        {
            TempData["PrototypeMessage"] = "Prototype only: your claim would be submitted here.";
            return RedirectToAction(nameof(Submit));
        }

        public IActionResult Verify()
        {
            return View(SampleClaims);
        }

        // Prototype: no state change
        [HttpPost]
        public IActionResult Approve(int id)
        {
            TempData["PrototypeMessage"] = $"Prototype only: claim #{id} would be approved here.";
            return RedirectToAction(nameof(Verify));
        }

        public IActionResult Track()
        {
            return View(SampleClaims);
        }
    }
}
