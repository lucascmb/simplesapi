using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace DesafioBahia.Domain.Models
{
    public class Ativo
    {
        public int Id { get; set; }
        public string descricao { get; set; }
        public int lote_minimo { get; set; }

        public IList<Ordem> Ordens { get; set; } = new List<Ordem>();
    }
}
