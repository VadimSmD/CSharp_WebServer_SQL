using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab_12.Data;
using Lab_12.Models;

namespace Lab_12.Pages.Pharmacist
{
    public class DetailsModel : PageModel
    {
        private readonly Lab_12.Data.ApplicationContext _context = new ApplicationContext();

        public PharmacistM Pharmacist { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Pharmacists == null)
            {
                return NotFound();
            }

            var pharmacist = await _context.Pharmacists.FirstOrDefaultAsync(m => m.Id == id);
            if (pharmacist == null)
            {
                return NotFound();
            }
            else 
            {
                Pharmacist = pharmacist;
            }
            return Page();
        }
    }
}
