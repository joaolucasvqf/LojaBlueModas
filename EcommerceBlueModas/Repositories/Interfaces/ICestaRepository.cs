using EcommerceBlueModas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBlueModas.Repositories.Interfaces
{
    public interface ICestaRepository
    {
        IEnumerable<Cesta> Cesta { get; }
        int CriarCesta(Cesta cesta);
        Cesta GetById(string id);
        void IncluirProduto(int idProduto);
        void RemoverProduto(int idProduto);
        void LimparCesta(int idCesta)
    }
}
