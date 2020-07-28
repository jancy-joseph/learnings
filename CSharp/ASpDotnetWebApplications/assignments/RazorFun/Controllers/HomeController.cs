using Microsoft.AspNetCore.Mvc;
namespace RazorFun
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
            string[] myarray = new string[]{"Apple Pie","burritos","Clams casino","Donuts"};
            return View(myarray);
        }

    }
}