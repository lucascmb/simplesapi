using DesafioBahia.Domain.Models;
using DesafioBahia.Domain.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBahia.Extensions.Validator
{
    public class OrdemValidator : IOrdemValidator
    {
        public bool CheckOrdemRules(Ordem ordem)
        {
            var ativo = ordem.Ativo;

            if( ! ((ordem.Quantidade % ativo.Lote_minimo) == 0) )
            {
                throw new Exception("A quantidade escolhida não é múltipla do lote mínimo exigido pelo ativo.");
            }

            if (! (ordem.Classe_negociacao.Equals('C') || ordem.Classe_negociacao.Equals('V')) )
            {
                throw new Exception("A classe de negociação escolhida não é válida. Escolha entre Venda ou Compra.");
            }

            return true;
        }
    }
}
