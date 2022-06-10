using CaiNaFesta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
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
