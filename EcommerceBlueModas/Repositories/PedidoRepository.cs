using EcommerceBlueModas.DataBase;
using EcommerceBlueModas.Models;
using EcommerceBlueModas.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBlueModas.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _context;
        public PedidoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Pedido> Pedidos => throw new NotImplementedException();

        public void AtualizarPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public void CancelarPedido(string idPedido)
        {
            throw new NotImplementedException();
        }

        public Pedido GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> GetPedidosByCliente(string idCliente)
        {
            throw new NotImplementedException();
        }

        public int NovoPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }
}
