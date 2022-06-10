using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaiNaFesta.Controllers
{
    public class EventoController : Controller
    {
        public EventoController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }      
    }
}
