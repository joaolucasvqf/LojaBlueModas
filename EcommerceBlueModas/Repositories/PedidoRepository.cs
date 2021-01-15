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
            _context.Pedido.Update(pedido);
            _context.SaveChanges();
        }

        public void CancelarPedido(int idPedido)
        {
            throw new NotImplementedException();
        }

        public Pedido GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> GetPedidosByCliente(int idCliente)
        {
            throw new NotImplementedException();
        }

        public int NovoPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }
}
