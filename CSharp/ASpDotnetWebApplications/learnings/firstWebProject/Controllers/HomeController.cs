using Microsoft.AspNetCore.Mvc;
namespace firstWebProject
{
    public class HomeController:Controller
    {
        //Requests
        //localhost:5000
        [Route("")]
        [HttpGet]
        //[HttpGet("")] //both the statements can be simplifiedc like this
        public string Index()
        {
            return "This is my Index!";
        }

        [Route("projects")]
        [HttpGet]
        public string Hello()
        {
            return "These are my projects";
        }
        [Route("contacts")]
        [HttpGet]
        public string HelloContact()
        {
            return "This is my Contact!";
        }

        [Route("hello/{username}")]
        [HttpGet]
        public string HelloUsername(string username)
        {
            return "hi from hello func"+username;
        }

    }
}