using Microsoft.AspNetCore.Mvc;
namespace TimeDisplay
{
    public class HomeController:Controller
    {
        //Requests
        //localhost:5000
        [Route("")]
        [HttpGet]
        //[HttpGet("")] //both the statements can be simplifiedc like this
        public IActionResult Index()
        {
            return View();
        }



    }
}