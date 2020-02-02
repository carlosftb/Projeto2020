using System;
using System.ComponentModel.DataAnnotations;
using Projeto2020.Models.Enums;

namespace Projeto2020.Models
{
    public class Produto
    {
        [Key]
        public int Codigo { get; set; }

        public String Nome { get; set; }

        public float Preco { get; set; }

        public Unidade Status { get; set; }

        public Setor Setor { get; set; }

        public Produto()
        {

        }

        public Produto(int codigo, string nome, float preco, Unidade status, Setor setor)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Status = status;
            Setor = setor;
        }
    }
}