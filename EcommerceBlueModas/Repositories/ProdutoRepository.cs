using EcommerceBlueModas.DataBase;
using EcommerceBlueModas.Models;
using EcommerceBlueModas.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBlueModas.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;
        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Produto> produtos => throw new NotImplementedException();

        public Produto GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
