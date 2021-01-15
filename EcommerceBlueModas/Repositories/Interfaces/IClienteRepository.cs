﻿using EcommerceBlueModas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBlueModas.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> Clientes { get; }
        void CadastrarCliente(Cliente cliente);
        Cliente GetById(int id);
    }
}
