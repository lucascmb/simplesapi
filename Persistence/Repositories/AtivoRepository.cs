using DesafioBahia.Domain.Models;
using DesafioBahia.Domain.Repositories;
using DesafioBahia.Persistence.Context;
using DesafioBahia.Resources;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBahia.Persistence.Repositories
{
    public class AtivoRepository : BaseRepository, IAtivoRepository
    {
        public AtivoRepository(DBContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Ativo>> ListAsync()
        {
            return await _context.Ativo.ToListAsync();
        }

        public async Task<IEnumerable<Ordem>> GetPositionAsync(DateTime data, int id)
        {
            var ordens = _context.Ordem.Where(o => o.Fk_id_ativo == id).Where(o => o.Data <= data).ToListAsync();
            return await ordens;
        }
    }
}
