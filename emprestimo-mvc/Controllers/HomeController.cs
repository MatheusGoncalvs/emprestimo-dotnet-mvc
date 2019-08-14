using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using emprestimo_mvc.Models;
using emprestimomvc.Data.Entities;

namespace emprestimo_mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
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

        [HttpPost("NovoEmprestimo")]
        public IActionResult NovoEmprestimo(Pessoa pessoa)
        {

            return View();
        }

        public IActionResult ValorNovoEmprestimo()
        {
            return View();
        }

        [HttpGet("Home/EncerramentoNovoEmprestimo")]
        public IActionResult EncerramentoNovoEmprestimo()
        {
            return View();
        }
        [HttpPost("Home/EncerramentoNovoEmprestimo")]
        public IActionResult EncerramentoNovoEmprestimo(Emprestimo emprestimo)
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
            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
