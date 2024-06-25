using Microsoft.AspNetCore.Mvc;
using Quiz_Application.Models;

namespace Quiz_Application.Controllers
{
    public class QuestionController : Controller
    {
        // GET: Question/AddQuestion
        public IActionResult AddQuestion()
        {
            var model = new Question(); // Ensure this is not null
            return View(model);
        }

        // POST: Question/RegisterQ
        [HttpPost]
        public IActionResult RegisterQ(Question model)
        {
            if (ModelState.IsValid)
            {
                // Save the question to the database or perform other actions
                // For example:
                ////_context.questions.add(model);
                // _context.savechanges();

                // Return a success message
                return Json(new { Message = "Question added successfully!" });
            }
            // Return an error message if the model is invalid
            return Json(new { Message = "There was an error adding the question." });
        }
    }
}
