using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceBlueModas.Models;
using EcommerceBlueModas.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EcommerceBlueModas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        private IConfiguration _config;
        private IPedidoRepository _pedidoRepository;
        public PedidoController(IConfiguration config, IPedidoRepository pedidoRepository)
        {
            _config = config;
            _pedidoRepository = pedidoRepository;
        }
        [HttpPost()]
        public async Task<IActionResult> NovoPedido(Pedido pedido)
        {
            try
            {
                _pedidoRepository.NovoPedido(pedido);
                return Ok(pedido);
            }
            catch (Exception e)
            {
                return UnprocessableEntity(e.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPediById(int id)
        {
            try
            {
                Pedido pedido;
                try
                {
                    pedido = _pedidoRepository.GetById(id);
                }
                catch (Exception)
                {
                    return NotFound();
                }
                return Ok(pedido);
            }
            catch (Exception e)
            {
                return UnprocessableEntity(e.Message);
            }

        }
    }
}
