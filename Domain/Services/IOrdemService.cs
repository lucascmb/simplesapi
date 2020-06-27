using DesafioBahia.Domain.Models;
using DesafioBahia.Resources;
using DesafioBahia.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBahia.Domain.Services
{
    public interface IOrdemService
    {
        Task<IEnumerable<Ordem>> ListAsync();
        Task<SaveOrdemResponse> SaveAsync(Ordem ordem);
        Task<IEnumerable<Ordem>> ByDateRangeListAsync(DateTime dataInicial, DateTime dataFinal);
    }
}
