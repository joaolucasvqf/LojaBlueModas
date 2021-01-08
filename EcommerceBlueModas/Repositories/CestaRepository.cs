using EcommerceBlueModas.DataBase;
using EcommerceBlueModas.Models;
using EcommerceBlueModas.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBlueModas.Repositories
{
    public class CestaRepository : ICestaRepository
    {
        private readonly AppDbContext _context;
        public CestaRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Cesta> Cesta => _context.Cesta.ToList();
        public int CriarCesta(Cesta cesta)
        {
            _context.Cesta.Add(cesta);
            _context.SaveChanges();
            return cesta.id;
        }
        public Cesta GetById(string id)
        {
            throw new NotImplementedException();
        }
        public void IncluirProduto(int idProduto)
        {
            throw new NotImplementedException();
        }
        public void LimparCesta(int idCesta)
        {
            throw new NotImplementedException();
        }
        public void RemoverProduto(int idProduto)
        {
            throw new NotImplementedException();
        }
    }
}
