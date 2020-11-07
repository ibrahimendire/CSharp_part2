﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld/")]  //replace all   commented DRY
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        //[Route("/helloworld/")] //DRY
        public IActionResult Index()
        {
            //string html = "<h1>Hello World!</h1>";

            return View();
        }
        //GET /hello/welcome
        //[HttpGet]
        //[Route("/helloworld/welCome/{name?}")]
        [HttpGet("wel-Come/{name?}")]
        [HttpPost]
        //[Route("/helloworld/")]    //DRY
        public IActionResult Welcome(string name="World")
        {
            ViewBag.person = name;
            return View();
        }
    }
}
