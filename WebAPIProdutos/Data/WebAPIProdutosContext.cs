using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIProdutos.Models;

namespace WebAPIProdutos.Data
{
    public class WebAPIProdutosContext : DbContext
    {
        public WebAPIProdutosContext (DbContextOptions<WebAPIProdutosContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPIProdutos.Models.Produto> Produto { get; set; }
    }
}
