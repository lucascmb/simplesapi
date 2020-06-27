using AutoMapper.Configuration.Conventions;
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
            var ordens = _context.Ordem.OrderByDescending(o => o.Data);
            var ativos = _context.Ativo.ToList();

            foreach(Ordem o in ordens)
            {
                o.Ativo = ativos.Where(a => a.Id_ativo == o.Fk_id_ativo).FirstOrDefault();
            }

            return await ordens.ToListAsync();
        }

        public async Task AddAsync(Ordem ordem)
        {
            ordem.Ativo = _context.Ativo.Where(a => a.Id_ativo == ordem.Fk_id_ativo).FirstOrDefault();
            await _context.Ordem.AddAsync(ordem);
        }

        public async Task<IEnumerable<Ordem>> ByDateRangeListAsync(DateTime dataInicial, DateTime dataFinal)
        {
            var ordens = _context.Ordem.Where(o => o.Data > dataInicial).Where(o => o.Data <= dataFinal).OrderByDescending(o => o.Data);
            var ativos = _context.Ativo.ToList();

            foreach(Ordem o in ordens)
            {
                o.Ativo = ativos.Where(a => a.Id_ativo == o.Fk_id_ativo).FirstOrDefault();
            }

            return await ordens.ToListAsync();
        }

    }
}
