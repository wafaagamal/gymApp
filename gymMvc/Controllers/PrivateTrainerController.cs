﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gymMvc.Controllers
{
    public class PrivateTrainerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}