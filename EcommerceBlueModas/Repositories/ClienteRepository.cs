using EcommerceBlueModas.DataBase;
using EcommerceBlueModas.Models;
using EcommerceBlueModas.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBlueModas.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;
        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Cliente> Clientes => throw new NotImplementedException();

        public void CadastrarCliente(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            _context.SaveChanges();
        }

        public Cliente GetById(int id)
        {
            return _context.Cliente.FirstOrDefault(c => c.id == id);
        }
    }
}
