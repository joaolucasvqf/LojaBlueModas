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
        Pedido GetById(string id);
        IEnumerable<Pedido> GetPedidosByCliente(string idCliente);
        void AtualizarPedido(Pedido pedido);
        void CancelarPedido(string idPedido);
    }
}
