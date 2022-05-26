namespace CaiNaFesta.Models
{
    public class EventoModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dia { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFim { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }  
        public string Descrição { get; set; }
        public string Email { get; set; }  
        public int Lotacao { get; set; }

        //Coloquei os campos Dia, HoraInicio e HoraFim como String por que não apareceu as opções certas de vetores --Matheus
    }
}
