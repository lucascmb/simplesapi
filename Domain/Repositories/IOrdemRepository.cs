using DesafioBahia.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBahia.Domain.Repositories
{
    public interface IOrdemRepository
    {
        Task<IEnumerable<Ordem>> ListAsync();
        Task AddAsync(Ordem ordem);
    }
}
