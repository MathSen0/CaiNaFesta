namespace CaiNaFesta.Models
{
    public class EventoModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }  
        public string Descrição { get; set; }
        public string Email { get; set; }  
        public int Lotacao { get; set; }

    }
}
