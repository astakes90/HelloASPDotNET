﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    [Route("/hello")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("welcome/{name?}")]
        [HttpPost]
        public IActionResult Welcome(string name = "World", string language = "english")
        {
            ViewBag.person = name;
            return View();
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

