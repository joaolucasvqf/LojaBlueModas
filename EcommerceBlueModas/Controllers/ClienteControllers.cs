using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceBlueModas.Models;
using EcommerceBlueModas.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EcommerceBlueModas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteControllers : ControllerBase
    {
        private IConfiguration _config;
        private IClienteRepository _clienteRepository;
        public ClienteControllers(IConfiguration config, IClienteRepository clienteRepository)
        {
            _config = config;
            _clienteRepository = clienteRepository;
        }
        /// <summary>
        /// Retorna uma lista com todos os clientes.
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public async Task<IActionResult> ListarClientes()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> ObterClienteById(int id)
        {
            try
            {
                Cliente cliente;
                try
                {
                    cliente = _clienteRepository.GetById(id);
                }
                catch (Exception)
                {
                    return NotFound();
                }
                return Ok(cliente);
            }
            catch (Exception e)
            {
                return UnprocessableEntity(e.Message);
            }
        }
    }
}
