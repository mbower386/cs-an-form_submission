using FormSubmission.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormSubmission.Controllers
{
    public class FormSubmissionController : Controller
    {
        // Index
        [HttpGet]
        [Route ("")]
        public ViewResult Index ()
        {
            return View ();
        }

        [HttpPost]
        [Route ("submit")]
        public IActionResult Submit ()
        {

            return View ("Success");
        }
    }
}