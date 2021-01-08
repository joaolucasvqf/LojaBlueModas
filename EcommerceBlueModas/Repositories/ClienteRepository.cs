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
            throw new NotImplementedException();
        }

        public Cliente GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
