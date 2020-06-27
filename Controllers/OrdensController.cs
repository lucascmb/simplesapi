using AutoMapper;
using DesafioBahia.Domain.Models;
using DesafioBahia.Domain.Services;
using DesafioBahia.Resources;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBahia.Extensions;

namespace DesafioBahia.Controllers
{
    [Route("DesafioBahiaAPI/ordens")]
    public class OrdensController : Controller
    {
        private readonly IOrdemService _ordemService;
        private readonly IMapper _mapper;

        public OrdensController(IOrdemService ordemService, IMapper mapper)
        {
            _ordemService = ordemService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<OrdemResource>> GetAllAsync()
        {
            var ordens = await _ordemService.ListAsync();
            var result = _mapper.Map<IEnumerable<Ordem>, IEnumerable<OrdemResource>>(ordens);

            return result;
        }

        [HttpGet("{dataInicial}/{dataFinal}")]
        public async Task<IEnumerable<OrdemResource>> GetByDataRangeAsync(DateTime dataInicial, DateTime dataFinal)
        {
            var ordens = await _ordemService.ByDateRangeListAsync(dataInicial, dataFinal);
            var result = _mapper.Map<IEnumerable<Ordem>, IEnumerable<OrdemResource>>(ordens);

            return result;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveOrdemResource resource)
        {
            if( !ModelState.IsValid )
            {
                return BadRequest(ModelState.GetErrorMessages());
            }

            var ordem = _mapper.Map<SaveOrdemResource, Ordem>(resource);
            var result = await _ordemService.SaveAsync(ordem);

            if ( !result.Success )
            {
                return BadRequest(result.Message);
            }

            var ordemResource = _mapper.Map<Ordem, OrdemResource>(result.Ordem);
            return Ok(ordemResource);
        }
    }   
}
