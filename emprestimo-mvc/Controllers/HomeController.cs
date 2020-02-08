using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using emprestimo_mvc.Models;
using emprestimomvc.Data.Entities;
using emprestimomvc.Services;
using emprestimomvc.Data.DTO;
using emprestimomvc.Data;

namespace emprestimo_mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmprestimoData emprestimoData;

        [BindProperty]
        public Pessoa Pessoa { get; set; }

        public HomeController(IEmprestimoData emprestimoData)
        {
            this.emprestimoData = emprestimoData;
        }

        public IActionResult Index()
        {
            throw new InvalidOperationException("Exceção gerada para teste");
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        [HttpGet("NovoEmprestimo")]
        public IActionResult NovoEmprestimo()
        {
            return View();
        }

        public IActionResult ValorNovoEmprestimo()
        {
            return View();
        }

        [HttpGet("Home/ConfirmarEmprestimo")]
        public IActionResult ConfirmarEmprestimo()
        {
            return View();
        }
        [HttpPost("Home/ConfirmarEmprestimo")]
        public IActionResult ConfirmarEmprestimo(Emprestimo emprestimo)
        {
            var pessoa = emprestimoData.BuscarPessoa(emprestimo.NomeCliente);

            var newPessoa = new Pessoa();
            newPessoa.Id = pessoa.Id;

            emprestimoData.Add(emprestimo);

            return RedirectToAction("EncerramentoNovoEmprestimo", emprestimo);
        }

        [HttpGet("Home/EncerramentoNovoEmprestimo")]
        public IActionResult EncerramentoNovoEmprestimo()
        {
            return View();
        }

        public IActionResult EntradaNovoEmprestimo()
        {
            return View();
        }

        public IActionResult PrazoNovoEmprestimo()
        {
            return View();
        }

        [HttpGet("CadastrarNovoCliente")]
        public IActionResult CadastrarNovoCliente()
        {
            return View();
        }

        [HttpPost("CadastrarNovoCliente")]
        public IActionResult CadastrarNovoCliente(Pessoa pessoa)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            emprestimoData.Add(Pessoa);
            emprestimoData.Commit();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
