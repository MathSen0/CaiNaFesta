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
        private readonly IIngressoRepositorio _ingressorepositorio;


        public EventoController(IConfiguration configuration, IEventoRepositorio eventoRepositorio, IIngressoRepositorio ingressoRepositorio)
        {
            _configuration = configuration;
            _eventorepositorio = eventoRepositorio;
            _ingressorepositorio = ingressoRepositorio;

        }
            public IActionResult Index(EventoModel BuscarPor)
        {
            List<EventoModel> evento = new();

            evento = _eventorepositorio.Buscarevento();
            
            if(BuscarPor.Nome != null)
            {
                evento = _eventorepositorio.BuscarNome(BuscarPor.Nome);
            }
            if(BuscarPor.Data != null)
            {
                evento = _eventorepositorio.BuscarData(BuscarPor.Data);
            }
            if(BuscarPor.Cidade != null)
            {
                evento = _eventorepositorio.BuscarCidade(BuscarPor.Cidade);
            }
            if(BuscarPor.Estado != null)
            {
                evento = _eventorepositorio.BuscarEstado(BuscarPor.Estado);
            }

            return View(evento);


        }
        public IActionResult Cadastrar(EventoModel Evento)
        {
            return View();
        }
        public IActionResult Inserir (EventoModel evento)
        {
            var retorno = _eventorepositorio.Cadastrar(evento);
            return RedirectToAction("index", "Home");
        }
        public IActionResult Comprar(EventoModel evento)
        {
            var retorno = _eventorepositorio.BuscarId(evento.Id);
            evento = retorno;
            return View(evento);
        }
        public IActionResult Ingresso()
        {
            return View();
        }

        public IActionResult RegistroCompra (IngressoModel ingresso)
        {
            var retorno = _ingressorepositorio.RegistroCompra(ingresso);
            if (retorno != null)
            {
                TempData["Mensagem4"] = "Reserva feita com sucesso! Em breve o produtor do evento entrará em contato";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["Mensagem5"] = "Não foi possível resgistrar a reserva, tente novamente mais tarde! Caso repetir o erro, entre em contato com o nosso Suporte";
                return RedirectToAction("Ingresso");
            }
        }

    }
}
