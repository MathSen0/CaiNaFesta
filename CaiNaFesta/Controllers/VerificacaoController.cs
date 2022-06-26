using CaiNaFesta.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace CaiNaFesta.Controllers
{
    public class VerificacaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Verificar(VerificacaoModel verificacao)
        {
            string codigo = "158";
            if (verificacao.codigo == codigo)
                {
                    TempData["Mensagem"] = "Verificado com sucesso! Cadastre o seu evento.";
                    return RedirectToAction("Cadastrar", "Evento");
                }
            else   
                {
                     TempData["Mensagem1"] = "Código incorreto! Caso esteja com dificuldade contate nossa equipe pelo Suporte";
                    return View("Index");
                }
        }
    }
}
