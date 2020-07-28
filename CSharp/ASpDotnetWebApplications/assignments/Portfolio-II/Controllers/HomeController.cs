using Microsoft.AspNetCore.Mvc;
namespace Portfolio_II
{
    public class HomeController:Controller
    {
        //Requests
        //localhost:5000
        [Route("")]
        [HttpGet]
        //[HttpGet("")] //both the statements can be simplifiedc like this
        public ViewResult Index()
        {
            return View();
        }
        
        [Route("projects")]
        [HttpGet]
        //[HttpGet("")] //both the statements can be simplifiedc like this
        public ViewResult projects()
        {
            return View();
        }

        [Route("contacts")]
        [HttpGet]
        //[HttpGet("")] //both the statements can be simplifiedc like this
        public ViewResult contacts()
        {
            return View();
        }

        [Route("contacts")]
        [HttpPost]
        public ViewResult RedirectcontactPostRequest()
        {
            return View("index");
        }

    }
}