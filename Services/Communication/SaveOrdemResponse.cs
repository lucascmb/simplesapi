using DesafioBahia.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBahia.Services.Communication
{
    public class SaveOrdemResponse : BaseResponse
    {
        public Ordem Ordem { get; private set; }

        private SaveOrdemResponse(bool success, string message, Ordem ordem) : base (success, message)
        {
            Ordem = ordem;
        }

        public SaveOrdemResponse(Ordem ordem) : this(true, string.Empty, ordem)
        {

        }

        public SaveOrdemResponse(string message) : this(false, message, null)
        {

        }
    }
}
