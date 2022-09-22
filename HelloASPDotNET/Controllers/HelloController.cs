using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/'>" +
                "<input type ='text' name='name' />" +
                "<select name='language'> <option value='english'>english</option> <option value='french'>french</option> <option value='german'>german</option> <option value='spanish'>spanish</option> <option value='polish'>polish</option> </select>" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        [HttpGet("welcome/{name?}")]
        [HttpPost]
        public IActionResult Welcome(string name = "World", string language = "english")
        {
            return Content(CreateMessage(name, language));
        }

        public static string CreateMessage(string name, string language)
        {
            string helloTranslation = "";
            switch (language)
            {
                case "english":
                    helloTranslation = "Hello ";
                    break;
                case "french":
                    helloTranslation = "Bonjour ";
                    break;
                case "german":
                    helloTranslation = "Hallo ";
                    break;
                case "spanish":
                    helloTranslation = "Hola ";
                    break;
                case "polish":
                    helloTranslation = "Witam ";
                    break;
            }
            return helloTranslation + name;
        }
    }
}

