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
    public class IndexModel : PageModel
    {
        private readonly Lab_12.Data.ApplicationContext _context = new ApplicationContext();

        public IList<PharmacistM> Pharmacist { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Pharmacists != null)
            {
                Pharmacist = await _context.Pharmacists.ToListAsync();
            }
        }
    }
}
