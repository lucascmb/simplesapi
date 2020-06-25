using DesafioBahia.Domain.Models;
using DesafioBahia.Domain.Repositories;
using DesafioBahia.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBahia.Persistence.Repositories
{
    public class OrdemRepository : BaseRepository, IOrdemRepository
    {
        public OrdemRepository(DBContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Ordem>> ListAsync()
        {
            return await _context.Ordens.OrderBy(o => o.data).ToListAsync();
        }

        public async Task AddAsync(Ordem ordem)
        {
            await _context.Ordens.AddAsync(ordem);
        }
    }
}
