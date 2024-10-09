using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lab_12.Data;
using Lab_12.Models;

namespace Lab_12.Pages.Supplies
{
    public class CreateModel : PageModel
    {
        private readonly Lab_12.Data.ApplicationContext _context = new ApplicationContext();

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SupplyM Supply { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Supplies == null || Supply == null)
            {
                return Page();
            }

            _context.Supplies.Add(Supply);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
