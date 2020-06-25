using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBahia.Domain.Models
{
    public class Ordem
    {
        public int id { get; set; }
        public float quantidade { get; set; }
        public float preco { get; set; }
        public DateTime data { get; set; }
        public ClasseNegociacao classe_negociacao { get; set; }

        public int id_ativo { get; set; }
        public Ativo ativo { get; set; }

    }
}
