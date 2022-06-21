using CaiNaFesta.Data.Repositorio.Interfaces;
using CaiNaFesta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaiNaFesta.Data.Repositorio
{
    public class EventoRepositorio : IEventoRepositorio
    {
        private readonly BancoContexto _bancoContexto;
        public EventoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }
        public List<EventoModel> Buscarevento()
        {
            return _bancoContexto.Evento.ToList();
        }
    }
}
