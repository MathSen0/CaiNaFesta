using System;

namespace CaiNaFesta.Models
{
    public class IngressoModel
    {
        public int Id { get; set; }
        public int IdEvento { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Data { get; set; }
    }
}
