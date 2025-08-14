using CadastroDeProdutos.Data;
using CadastroDeProdutos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeProdutos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext _cadastroDbContext;

        public ProdutosController(AppDbContext cadastroDbContext)
        {
            _cadastroDbContext = cadastroDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddProdutos(Produtos produtos)
        {
            _cadastroDbContext.Cadastro.Add(produtos);
            await _cadastroDbContext.SaveChangesAsync();

            return Ok(produtos);
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Produtos>>> GetProdutos()
        {
            var produtos = await _cadastroDbContext.Cadastro.ToListAsync();

            return Ok(produtos);
        }
       
    }
}