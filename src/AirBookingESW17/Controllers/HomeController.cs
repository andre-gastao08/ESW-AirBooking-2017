using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AirBookingESW17.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InfoContactos()
        {
            ViewData["Message"] = "Aqui ficará a informação dos contactos.";

            return View();
        }
        public IActionResult InfoFrota()
        {
            ViewData["Message"] = "Aqui ficará a informação das frotas.";

            return View();
        }
        public IActionResult InfoSobreNos()
        {
            ViewData["Message"] = "Aqui ficará a informação da empresa.";

            return View();
        }
        public IActionResult InfoTripulacoes()
        {
            ViewData["Message"] = "Aqui ficará a informação das tripulações.";

            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
