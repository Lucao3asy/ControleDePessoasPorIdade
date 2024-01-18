using ControleDePessoasPorIdade.Models;
using Microsoft.AspNetCore.Mvc;

public class PessoaController : Controller
{
    private static List<PessoaModel> pessoas = new List<PessoaModel>();

    public ActionResult CadastroPessoa()
    {
        return View(pessoas);
    }

    [HttpPost]
    public ActionResult Create(string nome, int idade, string email)
    {
        PessoaModel novaPessoa = new PessoaModel(nome, idade, email);
        pessoas.Add(novaPessoa);
        return RedirectToAction("CadastroPessoa");
    }

    public ActionResult FiltrarPorIdade()
    {
        var pessoasFiltradas = pessoas.Where(p => p.Idade >= 30).ToList();
        return View("CadastroPessoa", pessoasFiltradas);
    }
}
