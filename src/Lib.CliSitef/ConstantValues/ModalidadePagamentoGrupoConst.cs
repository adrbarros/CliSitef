using System.Collections.Generic;

namespace Lib.CliSitef.ConstantValues
{
    public class ModalidadePagamentoGrupoConst
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
    }

    public class ModalidadePagamentoGrupo
    {
        public static List<ModalidadePagamentoGrupoConst> RetornarLista()
        {
            return new List<ModalidadePagamentoGrupoConst>()
            {
                new ModalidadePagamentoGrupoConst(){Codigo = "00", Nome = "CHEQUE"},
                new ModalidadePagamentoGrupoConst(){Codigo = "01", Nome = "CARTAO DE DEBITO"},
                new ModalidadePagamentoGrupoConst(){Codigo = "02", Nome = "CARTAO DE CREDITO"},
                new ModalidadePagamentoGrupoConst(){Codigo = "03", Nome = "CARTAO TIPO VOUCHER"},
                new ModalidadePagamentoGrupoConst(){Codigo = "05", Nome = "CARTAO FIDELIDADE"},
                new ModalidadePagamentoGrupoConst(){Codigo = "98", Nome = "DINHEIRO"},
                new ModalidadePagamentoGrupoConst(){Codigo = "99", Nome = "OUTRO TIPO DE CARTAO"}
            };
        }
        public static ModalidadePagamentoGrupoConst RetornarModalidadePagamentoGrupo(string _codigo)
        {
            return RetornarLista().Find(p => p.Codigo == _codigo);
        }
    }
}