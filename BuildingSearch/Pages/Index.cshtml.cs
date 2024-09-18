using BuildingSearch.Data;
using BuildingSearch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;


namespace BuildingSearch.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly SearchContext _context;


        public bool SearchResult = default;
        public IndexModel(ILogger<IndexModel> logger, IWebHostEnvironment webHostEnvironment, SearchContext context)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
            _context = context;
        }
        public Building Building { get; set; }
        public void OnGet()
        {
            ////var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);


            ////var brankds = System.IO.File.ReadAllText(path + @"/datajson.json");

            /////    var file = _webHostEnvironment.WebRootPath + "\\datajson.json";
            /////    
            //var list = _context.Buildings.ToList();

            //_context.Buildings.RemoveRange(list);

            //_context.SaveChanges();
            //var read = System.IO.File.ReadAllText(_webHostEnvironment.WebRootPath + "\\sample.json");

            //var brands = JsonSerializer.Deserialize<List<Building>>(read);


            //_context.AddRange(brands);
            //_context.SaveChanges();



            //no need of the element count as I use LINQ to create the sum instead of iterating the array explicitly in my code.
            //Console.ReadLine();
            //var ar_temp = Console.ReadLine().Split(' ');
            //var ar = Array.ConvertAll(ar_temp, int.Parse);
            //Console.WriteLine(ar.Sum()); //LINQ's sum method has O(n) time complexity.




        }



        public void OnPost()
        {
            var plotno = Convert.ToInt64(Customer.PlotNo.Trim().ToLower());
            var cadZone = Customer.Zone.Trim().ToLower();


            var first = _context.Buildings.FirstOrDefault(x => x.PLOT_NO == plotno && x.CAD_ZONE.ToLower() == cadZone);

            if (first is not null)
            {
                SearchResult = true;
                Building = first;
        
            }
        }

        [BindProperty]
        public Searching? Customer { get; set; }


        public class Searching
        {


            [Required, StringLength(10)]
            public string PlotNo { get; set; }

            [Required, StringLength(10)]
            public string Zone { get; set; }
        }

    }
}
