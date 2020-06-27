using DesafioBahia.Domain.Models;
using DesafioBahia.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBahia.Domain.Repositories
{
    public interface IAtivoRepository
    {
        Task<IEnumerable<Ativo>> ListAsync();
        Task<IEnumerable<Ordem>> GetPositionAsync(DateTime data, int id);
    }
}
