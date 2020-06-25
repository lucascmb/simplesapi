using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBahia.Domain.Models;
using DesafioBahia.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace DesafioBahia.Controllers
{
    [Route("ativos")]
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
    }
}
