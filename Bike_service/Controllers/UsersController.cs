﻿using Microsoft.AspNetCore.Mvc;

namespace Bike_service.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
