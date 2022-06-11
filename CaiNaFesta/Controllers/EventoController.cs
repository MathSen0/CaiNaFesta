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
        private readonly IEventoRepositorio _eventoRepositorio;
        public EventoController(IConfiguration configuration, IEventoRepositorio eventoRepositorio)
        {
            _configuration = configuration;
            _eventoRepositorio = eventoRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cadastrar(EventoModel Evento)
        {
            var retorno = _eventoRepositorio.Cadastrar(Evento);
            return View(null);
        }
    }
}
