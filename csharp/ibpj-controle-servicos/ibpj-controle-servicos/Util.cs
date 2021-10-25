using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ibpj_controle_servicos
{
    public class Util
    {
        public const String TodosItens = "[Todos os itens]";
        public const String NenhumItem = "[Nenhum]";
        public const int IntervaloFamilia = 1000;

        public enum ModoTela
        {
            Inserir,
            Alterar,
            SomenteLeitura,
            Excluir
        }

    }
}
