using BuildingSearch.Models;
using Microsoft.EntityFrameworkCore;

namespace BuildingSearch.Data
{ 
    public class SearchContext : DbContext
    {
        public SearchContext(DbContextOptions options) : base(options)
        {
                
        }

        public DbSet<Building>  Buildings { get; set; }
    }
}
