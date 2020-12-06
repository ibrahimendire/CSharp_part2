using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloASPDotNET.Data;
using HelloASPDotNET.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    public class EventsController : Controller
    {
        //static private List<Event> Events = new List<Event>(); 
        //static private Dictionary<string, string> Events = new Dictionary<string, string>();
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            //Events.Add("Strange Loop");
            //Events.Add("Grace Hopper");
            //Events.Add("Code With Pride");
            ViewBag.events = EventData.GetAll();
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Events/Add")]
        ///public IActionResult NewEvent(String name ,string desc) //Model-Binding
        public IActionResult NewEvent(Event newEvent)
        {

            //Events.Add(new Event(name ,desc));
            //EventData.Add(new Event(name, desc));   //Model-Binding
            EventData.Add(newEvent);
            return Redirect("/Events"); 
        }
        public IActionResult Delete()
        {
            ViewBag.events = EventData.GetAll();

            return View();
        }
        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            foreach (int eventId in eventIds)
            {
                EventData.Remove(eventId);
            }

            return Redirect("/Events");
        }

    }
}
