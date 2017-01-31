using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AirBookingESW17.Controllers
{
    public class AreaUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CaixaCorreio()
        {
            return View();
        }
        public IActionResult MinhasReservas()
        {
            return View();
        }
    }
}