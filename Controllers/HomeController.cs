using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DnD4Calculator.Models;
using DnD4Calculator.Models.Creatures.Beasts;


namespace DnD4Calculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var type = new Tag {SysName = "MONSTER", Name = "Монстр"};
            var roles = new List<Tag>();

            Tag nature = new Tag {Name = "Природный", SysName = "NATURE", ParentTag = type };
            roles.Add(nature);

            Tag humanoid = new Tag {Name = "Гуманоид", SysName = "HUMANOID", ParentTag = type };
            roles.Add(humanoid);

            Tag raider = new Tag {Name = "Налетчик", SysName = "RAIDER", ParentTag = type };
            roles.Add(raider);

            string description = "Гоблины - это злобные предатлеьские существа, которым нравятся грабежи и жестокость. Они не большие и не сильные, " +
                "но могут представлять опасность, если навалятся всем скопом. Гоблины быстро размножаются, и могут жить в любых местах, от пещер и руин - до городской канализации. " +
                "Они совершают набеги и ограбления, забирая у жертв все, что может пригодиться.";
            
            var monster = new Monster { id = 1, Level = 1, Name = "Гоблин Воин", Type = type, Roles = roles, Description = description};

            return View(monster);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
