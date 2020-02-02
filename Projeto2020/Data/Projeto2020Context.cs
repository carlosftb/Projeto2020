using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto2020.Models;

namespace Projeto2020.Data
{
    public class Projeto2020Context : DbContext
    {
        public Projeto2020Context (DbContextOptions<Projeto2020Context> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Setor> Setor { get; set; }
    }
}
