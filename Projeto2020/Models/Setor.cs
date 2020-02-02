using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2020.Models
{
     
    public class Setor
    {
        public int Id  { get; set; }
        public string nome { get; set; }
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();

        public Setor()
        {
        }

        public Setor(int id, string nome)
        {
            Id = id;
            this.nome = nome;
        }
        
        
        
    }
}
