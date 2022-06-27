using CaiNaFesta.Data.Repositorio.Interfaces;
using CaiNaFesta.Models;

namespace CaiNaFesta.Data.Repositorio
{
    public class IngressoRepositorio : IIngressoRepositorio
    {
        private readonly BancoContexto _bancoContexto;
        public IngressoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public IngressoModel RegistroCompra(IngressoModel ingresso)
        {
            _bancoContexto.Ingresso.Add(ingresso);
            _bancoContexto.SaveChanges();
            return ingresso;
        }
    }
}
