using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace PruebaDatos.Controllers
{
    public class CargaRegistrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
