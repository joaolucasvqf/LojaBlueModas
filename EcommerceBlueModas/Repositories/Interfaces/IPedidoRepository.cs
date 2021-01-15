using EcommerceBlueModas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBlueModas.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        IEnumerable<Pedido> Pedidos { get; }
        int NovoPedido(Pedido pedido);
        Pedido GetById(int id);
        IEnumerable<Pedido> GetPedidosByCliente(int idCliente);
        void AtualizarPedido(Pedido pedido);
        void CancelarPedido(int idPedido);
    }
}
