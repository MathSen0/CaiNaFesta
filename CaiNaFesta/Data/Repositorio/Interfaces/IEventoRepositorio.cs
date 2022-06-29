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

        List<EventoModel> BuscarNome(string nome);
        public EventoModel BuscarId(int id);
        public List<EventoModel> BuscarData(DateTime data);
        public List<EventoModel> BuscarCidade(string cidade);
        public List<EventoModel> BuscarEstado(string estado);



    }
}
