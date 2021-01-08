using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBlueModas.Models
{
    public class Pedido
    {
        [Key]
        public int id { get; set; }
        public Cliente cliente { get; set; }
        public List<Produto> produtos { get; set; }
    }
}
