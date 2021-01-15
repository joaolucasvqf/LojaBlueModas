using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBlueModas.Models
{
    public class Produto
    {
        [Key]
        public int id { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string categoria { get; set; }
        public int tamanho { get; set; }
        public string cor { get; set; }
        public int quantidade { get; set; }
        public byte[] imagem { get; set; }
    }
}
