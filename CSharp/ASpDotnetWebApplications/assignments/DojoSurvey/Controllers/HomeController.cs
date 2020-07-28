using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;
namespace DojoSurvey
{
    public class HomeController:Controller
    {
        private const string V = "Seattle";

        //Requests
        //localhost:5000
        [Route("")]
        [HttpGet]
        //[HttpGet("")] //both the statements can be simplifiedc like this
        public IActionResult Index()
        {
            string[] dojolocations = new string[]{"Seattle","sanjose","chicago"};
            string[] dojolanguages = new string[]{"c#","java","python"};
            Dojo d1= new Dojo(dojolocations,dojolanguages);
            return View(d1);
        }

        [HttpPost("postandredirect")]
        public IActionResult postandredirectFunc(string name,string locate,string lang,string comments)
        {

            return RedirectToAction("result",new {name =name,locate=locate,lang=lang,comments=comments});
        }

        [HttpGet("result")]
        public IActionResult result(string name,string locate,string lang,string comments)
        {
            string[] loc = new string[]{locate};
            string[] lan = new string[]{lang};
            Dojo d2 = new Dojo(loc,lan,name,comments);
            return View(d2);
        }



        

        



    }
}