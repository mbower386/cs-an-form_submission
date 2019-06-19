using FormSubmission.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Diagnostics;

namespace FormSubmission.Controllers {
    public class FormSubmissionController : Controller {
        // Index
        [HttpGet ("")]
        public IActionResult Index () {
            return View (new User());
        }

        // In HomeController
        [HttpPost("user/create")]
        public IActionResult Create(User user)
        {
            if(ModelState.IsValid)
            {
                // do somethng!  maybe insert into db?  then we will redirect
                return View("Success");
            }
            else
            {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("Index", user);
            }
        }
    }
}