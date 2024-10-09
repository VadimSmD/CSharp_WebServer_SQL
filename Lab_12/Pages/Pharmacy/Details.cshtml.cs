using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab_12.Data;
using Lab_12.Models;

namespace Lab_12.Pages.Pharmacy
{
    public class DetailsModel : PageModel
    {
        private readonly Lab_12.Data.ApplicationContext _context = new ApplicationContext();

        public PharmacyM PharmacyM { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Pharmacies == null)
            {
                return NotFound();
            }

            var pharmacym = await _context.Pharmacies.FirstOrDefaultAsync(m => m.Id == id);
            if (pharmacym == null)
            {
                return NotFound();
            }
            else 
            {
                PharmacyM = pharmacym;
            }
            return Page();
        }
    }
}
