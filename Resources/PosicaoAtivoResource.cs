using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBahia.Resources
{
    public class PosicaoAtivoResource
    {
        [Required]
        public string Descricao { get; set; }
        [Required]
        public DateTime RefData { get; set; }
        [Required]
        public double posicao { get; set; }
    }
}
