﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModBusRTU.Controllers
{
    public class AuthorizationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration() 
        {
            return View();
        }

        public IActionResult Input() 
        {
            return View();
        }
    }
}
