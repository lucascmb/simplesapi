using DesafioBahia.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBahia.Domain.Validator
{
    public interface IOrdemValidator
    {
        bool CheckOrdemRules(Ordem ordem);
    }
}
