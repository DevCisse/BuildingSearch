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
    public class IndexModel : PageModel
    {
        private readonly BuildingSearch.Data.SearchContext _context;

        public IndexModel(BuildingSearch.Data.SearchContext context)
        {
            _context = context;
        }

        public IList<Building> Building { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Building = await _context.Buildings.ToListAsync();
        }
    }
}
