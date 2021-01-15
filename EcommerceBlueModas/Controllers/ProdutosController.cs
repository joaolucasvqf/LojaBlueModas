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
    public class ProdutosController : ControllerBase
    {
        private IConfiguration _config;
        private IProdutoRepository _produtoRepository;
        public ProdutosController(IConfiguration config, IProdutoRepository produtoRepository)
        {
            _config = config;
            _produtoRepository = produtoRepository;
        }
        /// <summary>
        /// Retorna uma lista com todos os produtos, separados por categoria.
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public async Task<IActionResult> ListarProdutos()
        {
            try
            {
                List<dynamic> ret = new List<dynamic>();
                List<Produto> produtos;
                try
                {
                    produtos = _produtoRepository.produtos.ToList();
                }
                catch (Exception)
                {
                    produtos = new List<Produto>();
                }
                produtos.ForEach(p =>
                {
                    if (ret.Count == 0 || !ret.Any(x => x.categoria == p.categoria))
                    {
                        ret.Add(new { categoria = p.categoria, produtos = new List<Produto>() { p } });
                    }
                    else
                    {
                        ret.Find(r => r.categoria == p.categoria).produtos.Add(p);
                    }
                });
                return Ok(ret);
            }
            catch (Exception e)
            {
                return UnprocessableEntity(e.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> ObterProdutoById(int id)
        {
            try
            {
                Produto produto;
                try
                {
                    produto = _produtoRepository.GetById(id);
                }
                catch (Exception)
                {
                    return NotFound();
                }
                return Ok(produto);
            }
            catch (Exception e)
            {
                return UnprocessableEntity(e.Message);
            }
        }
    }
}
