using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;
namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Form()
        {
            return View();
        }
        [Route("/story")]
        public ActionResult Story()
        {
            WordVariables myWordVariables = new WordVariables();
            myWordVariables.SetPerson1(Request.Query["person1"]);
            myWordVariables.SetPerson2(Request.Query["person2"]);
            myWordVariables.SetAnimal(Request.Query["animal"]);
            myWordVariables.SetExclamation(Request.Query["exclamation"]);
            myWordVariables.SetVerb(Request.Query["verb"]);
            myWordVariables.SetNoun(Request.Query["noun"]);
            return View("Story", myWordVariables);
        
        }
    }
}