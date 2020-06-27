using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBahia.Domain.Models;
using DesafioBahia.Resources;

namespace DesafioBahia.Domain.Services
{
    public interface IAtivoService
    {
        Task<IEnumerable<Ativo>> ListAsync();
        Task<IEnumerable<Ordem>> GetPositionAsync(DateTime data, int id);
    }
}
