using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBahia.Persistence.Context;

namespace DesafioBahia.Persistence.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly DBContext _context;

        public BaseRepository(DBContext context)
        {
            _context = context;
        }
    }
}
