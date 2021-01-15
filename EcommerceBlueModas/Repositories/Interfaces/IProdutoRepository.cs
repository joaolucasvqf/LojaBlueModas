using EcommerceBlueModas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBlueModas.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> produtos { get; }
        Produto GetById(int id);
    }
}
