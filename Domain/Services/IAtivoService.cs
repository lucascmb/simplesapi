using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBahia.Domain.Models;


namespace DesafioBahia.Domain.Services
{
    public interface IAtivoService
    {
        Task<IEnumerable<Ativo>> ListAsync();
    }
}
