﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareYourFavPlaces.Controllers
{
    public class TypesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}