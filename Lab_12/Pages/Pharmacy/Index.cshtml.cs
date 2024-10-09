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
    public class IndexModel : PageModel
    {
        private readonly Lab_12.Data.ApplicationContext _context = new ApplicationContext();

        public IList<PharmacyM> PharmacyM { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Pharmacies != null)
            {
                PharmacyM = await _context.Pharmacies.ToListAsync();
            }
        }
    }
}
