using System;

namespace CaiNaFesta.Models
{
    public class EventoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime? Data { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }  
        public string Descricao { get; set; }
        public string Email { get; set; }  
        public int Lotacao { get; set; }
        public string Imagem { get;set; }
        public EventoModel()
        {

        }
    }
}
