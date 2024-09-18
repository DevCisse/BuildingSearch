using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BuildingSearch.Data;
using BuildingSearch.Models;

namespace BuildingSearch.Pages.Bh
{
    public class DetailsModel : PageModel
    {
        private readonly BuildingSearch.Data.SearchContext _context;

        public DetailsModel(BuildingSearch.Data.SearchContext context)
        {
            _context = context;
        }

        public Building Building { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var building = await _context.Buildings.FirstOrDefaultAsync(m => m.Id == id);
            if (building == null)
            {
                return NotFound();
            }
            else
            {
                Building = building;
            }
            return Page();
        }
    }
}
