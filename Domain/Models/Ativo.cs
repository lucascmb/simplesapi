﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace DesafioBahia.Domain.Models
{
    public class Ativo
    {
        public int Id_ativo { get; set; }
        public string Descricao { get; set; }
        public int Lote_minimo { get; set; }

        public IList<Ordem> Ordens { get; set; } = new List<Ordem>();
    }
}
