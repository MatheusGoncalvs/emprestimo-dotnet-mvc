﻿using System;
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
        //Verificar como pegar e passar o Id da pessoa pelas telas para inserir na tabela de emprestimos
        [HttpPost("NovoEmprestimo")]
        public IActionResult NovoEmprestimo(string pessoaNome)
        {
            if (pessoaNome != null)
            {
                var pessoas = emprestimoData.BuscarPessoa(pessoaNome);
                return View(pessoas);
            }
            else
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
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
        public IActionResult ConfirmarEmprestimo(EmprestimoModelView emprestimo)
        {
            return RedirectToAction("EncerramentoNovoEmprestimo");
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
