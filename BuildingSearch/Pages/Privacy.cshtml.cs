using BuildingSearch.Data;
using BuildingSearch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BuildingSearch.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly SearchContext _context;

        public PrivacyModel(ILogger<PrivacyModel> logger, SearchContext context)
        {
            _logger = logger;
            _context = context;
        }


        public Building Building { get; set; }
        public void OnGet()
        {
        }

        [BindProperty]
        public Searching? Customer { get; set; }

        public IActionResult OnPost()
        {
            var plotno = Convert.ToInt64(Customer.PlotNo.Trim().ToLower());
            var cadZone = Customer.Zone.Trim().ToLower();


            var building = new Building
            {
                PLOT_NO = Convert.ToInt64(Customer.PlotNo),
                CAD_ZONE = Customer.Zone,
                FILE_NUMBER = Customer.File_No.Trim(),
                DEVELOPER_S_NAME = Customer.DeveloperName.Trim(),




            };
            _context.Buildings.Add(building);
            _context.SaveChanges();
            return RedirectToPage("/Index");
        }


        public class Searching
        {


            [Required, StringLength(10)]
            public string PlotNo { get; set; }

            [Required, StringLength(10)]
            public string Zone { get; set; }

            [Required, StringLength(100)]
            public string File_No { get; set; }

            [Required, StringLength(100)]
            public string DeveloperName { get; set; }


        }
    }

}
