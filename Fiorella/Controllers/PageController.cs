﻿using Microsoft.AspNetCore.Mvc;

namespace Fiorella.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
