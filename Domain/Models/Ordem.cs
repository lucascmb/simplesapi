using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBahia.Domain.Models
{
    public class Ordem
    {
        public int Id_ordem { get; set; }
        public double Quantidade { get; set; }
        public double Preco { get; set; }
        public DateTime Data { get; set; }
        public char Classe_negociacao { get; set; }

        public int Fk_id_ativo { get; set; }
        public Ativo Ativo { get; set; }

    }
}
