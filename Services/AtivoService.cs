using DesafioBahia.Domain.Models;
using DesafioBahia.Domain.Repositories;
using DesafioBahia.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBahia.Services
{
    public class AtivoService : IAtivoService
    {

        private readonly IAtivoRepository _ativoRepository;

        public AtivoService(IAtivoRepository ativoRepository)
        {
            _ativoRepository = ativoRepository;
        }
        public async Task<IEnumerable<Ativo>> ListAsync()
        {
            return await _ativoRepository.ListAsync();
        }
    }
}
