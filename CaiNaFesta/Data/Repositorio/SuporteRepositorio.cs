using CaiNaFesta.Data.Repositorio.Interfaces;
using CaiNaFesta.Models;

namespace CaiNaFesta.Data.Repositorio
{
    public class SuporteRepositorio : ISuporteRepositorio
    {
        private readonly BancoContexto _bancoContexto;
        public SuporteRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }
        public SuporteModel Ticket(SuporteModel suporte)
        {
            _bancoContexto.Suporte.Add(suporte);
            _bancoContexto.SaveChanges();
            return suporte;
        }
    }
}
