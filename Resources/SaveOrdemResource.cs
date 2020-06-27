using DesafioBahia.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBahia.Resources
{
    public class SaveOrdemResource
    {
        [Required]
        public double Quantidade { get; set; }

        [Required]
        public double Preco { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public char Classe_negociacao { get; set; }

        [Required]
        public int Fk_id_ativo { get; set; }
    }
}
