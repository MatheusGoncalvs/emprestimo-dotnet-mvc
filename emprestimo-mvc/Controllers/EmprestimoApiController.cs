using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using emprestimomvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace emprestimo_mvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmprestimoApiController : Controller
    {
        private readonly IEmprestimoData emprestimoData;

        public EmprestimoApiController(IEmprestimoData emprestimoData)
        {
            this.emprestimoData = emprestimoData;
        }

        [Produces("application/json")]
        [HttpGet("search")]
        public async Task<IActionResult> Search()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                var search = emprestimoData.BuscarNomePessoa(term);

                return Ok(search);
            }catch
            {
                return BadRequest();
            }
        }
    }
}