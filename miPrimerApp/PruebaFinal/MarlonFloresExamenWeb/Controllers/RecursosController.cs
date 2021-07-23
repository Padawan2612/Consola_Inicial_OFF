using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarlonFloresExamenWeb.Controllers
{
    public class RecursosController : Controller

    {

        readonly string[] pinturas = new string[]

            {

                "El Grito II (La Edad de la Ira)",

                "El Grito de Munch",

                "La Gioconda"

            };

        [HttpPost]

        public IActionResult Index()

        {

            return View(pinturas);

        }

    }
}

