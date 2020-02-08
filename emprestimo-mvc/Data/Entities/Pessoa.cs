using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emprestimomvc.Data.Entities
{
    public class Pessoa
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome Obrigatório")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Digite o Nome e Sobrenome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Email Obrigatório")]
        [EmailAddress(ErrorMessage = "Digite um Email válido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefone Obrigatório")]
        [MinLength(11, ErrorMessage = "Telefone Inválido")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "N° Obrigatório")]
        [MinLength(2, ErrorMessage = "Cidade Inválida")]
        public string Numero { get; set; }
        [Required(ErrorMessage = "Bairro Obrigatório")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "Cidade Obrigatório")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Rua Obrigatório")]
        public string Rua { get; set; }
    }
}
