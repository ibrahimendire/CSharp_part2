using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloASPDotNET.Data;
using HelloASPDotNET.Models;
using HelloASPDotNET.ViewModels;
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

            // ViewBag.events = EventData.GetAll();
            List<Event> events = new List<Event>(EventData.GetAll());
            return View(events);
        }
        [HttpGet]
        public IActionResult Add()
        {
            AddEventViewModel addEventViewModel = new AddEventViewModel();
            return View(addEventViewModel);
        }

        [HttpPost]
        //[Route("/Events/Add")]
        ///public IActionResult NewEvent(String name ,string desc) //Model-Binding
        public IActionResult Add(AddEventViewModel addEventViewMode)
        {

            //Events.Add(new Event(name ,desc));
            //EventData.Add(new Event(name, desc));   //Model-Binding

            
                if (ModelState.IsValid)
                {
                    Event newEvent = new Event
                    {
                        Name = addEventViewMode.Name,
                        Description = addEventViewMode.Description,
                        TimeOfEvent = addEventViewMode.TimeOfEvent,
                        ContactEmail = addEventViewMode.ContactEmail
                    };
                    EventData.Add(newEvent);
                    return Redirect("/Events");
                }
                return View(addEventViewMode);
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
