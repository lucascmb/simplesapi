using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBahia.Resources
{
    public class AtivoResource
    {
        [Required]
        public int Id_ativo { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public int Lote_minimo { get; set; }
    }
}
