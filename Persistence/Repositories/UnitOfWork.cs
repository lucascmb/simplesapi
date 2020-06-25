using DesafioBahia.Domain.Repositories;
using DesafioBahia.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBahia.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly DBContext _context;

        public UnitOfWork(DBContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
