﻿using CaiNaFesta.Data.Repositorio.Interfaces;
using CaiNaFesta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace CaiNaFesta.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly ISuporteRepositorio _suporterepositorio;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration, ISuporteRepositorio suporterepositorio)
        {
            _logger = logger;
            _configuration = configuration;
            _suporterepositorio = suporterepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Suporte()
        {
            return View();
        }

        public IActionResult Ticket(SuporteModel suporte)
        {
            var retorno = _suporterepositorio.Ticket(suporte);
            if (retorno != null)
            {
                TempData["Mensagem"] = "Mensagem enviada com socesso! Entraremos em contato assim que possível";
            }
            return View("suporte");
        }
    }
}