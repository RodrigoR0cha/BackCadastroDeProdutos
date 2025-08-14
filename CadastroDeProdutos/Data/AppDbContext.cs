using CadastroDeProdutos.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeProdutos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            // Configurações do banco de dados
        }
        
        public DbSet<Produtos> Cadastro{ get; set; }
    }
}