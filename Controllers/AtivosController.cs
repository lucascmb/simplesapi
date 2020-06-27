using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBahia.Domain.Models;
using DesafioBahia.Domain.Services;
using DesafioBahia.Resources;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace DesafioBahia.Controllers
{
    [Route("DesafioBahiaAPI/ativos")]
    public class AtivosController : Controller
    {
        private readonly IAtivoService _ativoService;

        public AtivosController(IAtivoService ativoService)
        {
            _ativoService = ativoService;
        }

        [HttpGet]
        public async Task<IEnumerable<Ativo>> GetAllAsync()
        {
            var ativos = await _ativoService.ListAsync();
            return ativos;
        }

        [HttpGet("{data}/{id}")]
        public async Task<PosicaoAtivoResource> GetAsyncByDate(DateTime data, int id)
        {
            var ordens = await _ativoService.GetPositionAsync(data, id);

            double sum = 0.0;

            foreach(Ordem o in ordens)
            {
                if (o.Classe_negociacao.Equals('C')) sum += o.Quantidade;
                else sum -= o.Quantidade;
            }

            var retorno = new PosicaoAtivoResource { Descricao = "aa", posicao = sum, RefData = data };

            return retorno;
        }

    }
}
