using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaginacaoBasica.Models
{
    public class LojaContext: DbContext
    {
        //public LojaContext() : base("Loja")
        //{
        //}

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-1OGBH22\SQLEXPRESS;Database=PaginacaoBasicaMvc;User ID=sa;Password=123456");
        }
    }
}
