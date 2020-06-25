using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBahia.Domain.Models
{
    public enum ClasseNegociacao : byte
    {
        [Description("Compra")]
        C = 1,

        [Description("Venda")]
        V = 2
    }
}
