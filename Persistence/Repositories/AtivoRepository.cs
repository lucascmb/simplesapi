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
    public class AtivoRepository : BaseRepository, IAtivoRepository
    {
        public AtivoRepository(DBContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Ativo>> ListAsync()
        {
            return await _context.Ativos.ToListAsync();
        }
    }
}
