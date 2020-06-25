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
        public float quantidade { get; set; }

        [Required]
        public float preco { get; set; }

        [Required]
        public DateTime data { get; set; }

        [Required]
        public ClasseNegociacao classe_negociacao { get; set; }
    }
}
