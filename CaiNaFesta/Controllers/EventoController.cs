using CaiNaFesta.Data.Repositorio.Interfaces;
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
        private readonly IConfiguration _configuration;
        private readonly IEventoRepositorio _eventorepositorio;



        public EventoController(IConfiguration configuration, IEventoRepositorio eventoRepositorio)
        {
            _configuration = configuration;
            _eventorepositorio = eventoRepositorio;
        }
            public IActionResult Index()
        {
            List<EventoModel> Evento = new();

            Evento = _eventorepositorio.Buscarevento();
            return View();
        }
    }
}
