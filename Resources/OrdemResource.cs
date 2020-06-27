using DesafioBahia.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBahia.Resources
{
    public class OrdemResource
    {
        [Required]
        public int Id_ordem { get; set; }
        [Required]
        public double Quantidade { get; set; }
        [Required]
        public double Preco { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public char Classe_negociacao { get; set; }
        [Required]
        public AtivoResource Ativo { get; set; }

    }
}
