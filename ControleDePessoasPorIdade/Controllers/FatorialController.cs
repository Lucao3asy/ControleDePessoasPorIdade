using ControleDePessoasPorIdade.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleDePessoasPorIdade.Controllers
{
    public class FatorialController : Controller
    {
        public ActionResult Fatorial()
        {
            return View(new FatorialModel());
        }

        [HttpPost]
        public ActionResult Fatorial(FatorialModel model)
        {
            model.Resultado = CalcularFatorial(model.Numero);
            return View(model);
        }

        private long CalcularFatorial(int numero)
        {
            if (numero <= 1)
                return 1;

            return numero * CalcularFatorial(numero - 1);
        }

    }
}
