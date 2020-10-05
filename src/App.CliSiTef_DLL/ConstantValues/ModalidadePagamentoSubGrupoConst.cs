using System.Collections.Generic;

namespace App.CliSiTef_DLL.ConstantValues
{
    public class ModalidadePagamentoSubGrupoConst
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
    }

    public class ModalidadePagamentoSubGrupo
    {
        public static List<ModalidadePagamentoSubGrupoConst> RetornarLista()
        {
            return new List<ModalidadePagamentoSubGrupoConst>()
            {
                new ModalidadePagamentoSubGrupoConst(){Codigo = "00", Nome = "A VISTA"},
                new ModalidadePagamentoSubGrupoConst(){Codigo = "01", Nome = "PRE-DATADO"},
                new ModalidadePagamentoSubGrupoConst(){Codigo = "02", Nome = "PARCELADO COM FINANCIAMENTO PELO ESTABELECIMENTO"},
                new ModalidadePagamentoSubGrupoConst(){Codigo = "03", Nome = "PARCELADO COM FINANCIAMENTO PELA ADMINISTRADORA"},
                new ModalidadePagamentoSubGrupoConst(){Codigo = "04", Nome = "A VISTA COM JUROS"},
                new ModalidadePagamentoSubGrupoConst(){Codigo = "05", Nome = "CREDIARIO"},
                new ModalidadePagamentoSubGrupoConst(){Codigo = "99", Nome = "OUTRO TIPO DE PAGAMENTO"}
            };
        }
        public static ModalidadePagamentoSubGrupoConst RetornarModalidadePagamentoSubGrupo(string _codigo)
        {
            return RetornarLista().Find(p => p.Codigo == _codigo);
        }
    }
}
