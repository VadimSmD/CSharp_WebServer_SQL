using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lab_12.Data;
using Lab_12.Models;

namespace Lab_12.Pages.Pharmacy
{
    public class CreateModel : PageModel
    {
        private readonly Lab_12.Data.ApplicationContext _context = new ApplicationContext();

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PharmacyM PharmacyM { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Pharmacies == null || PharmacyM == null)
            {
                return Page();
            }

            _context.Pharmacies.Add(PharmacyM);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
