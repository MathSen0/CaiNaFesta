using CaiNaFesta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CaiNaFesta.Data.Repositorio.Interfaces
{
    public interface IEventoRepositorio
    {  
        public EventoModel Cadastrar(EventoModel evento);
        List<EventoModel> Buscarevento();
      
    }
}
