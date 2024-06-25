using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Quiz_Application.Models;
using System.Diagnostics;

namespace Quiz_Application.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Data _context; // Assuming your DbContext class is named ApplicationDbContext
        int[] questionId = new int[] { };
        public HomeController(ILogger<HomeController> logger, Data context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Question()
        {
            //var questions = _context.Question.ToList(); // Assuming your DbSet<Question> is named Questions

            var questions = await _context.Question.FirstOrDefaultAsync();
            return View(questions);
        }
        [HttpPost]
        public async Task<IActionResult> Question(int id, Question model)
        {

            var selectedOption = Request.Form["selectedOption"];

            //incorrect answer
            model = await _context.Question.Where(x => x.Id == id).FirstOrDefaultAsync();
            switch (selectedOption)
            {
                case "A":
                    model.OptionA = "checked";
                    break;
                case "B":
                    model.OptionB = "checked";
                    break;
                case "C":
                    model.OptionC = "checked";
                    break;
                case "D":
                    model.OptionD = "checked";
                    break;
                default:
                    break;
            }
            return View(model);
        }

        public IActionResult AddQuestion()
        {
            return View();
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
