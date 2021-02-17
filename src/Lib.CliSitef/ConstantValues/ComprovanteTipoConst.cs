using System.Collections.Generic;

namespace Lib.CliSitef.ConstantValues
{
    public class ComprovanteTipoConst
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string CodigoNome
        {
            get
            {
                return string.IsNullOrWhiteSpace(Nome) ? "" : Codigo + "|" + Nome;
            }
        }
    }
    public class ComprovanteTipo
    {
        public static List<ComprovanteTipoConst> RetornarLista()
        {
            return new List<ComprovanteTipoConst>()
            {
                new ComprovanteTipoConst(){Codigo = "00", Nome = "COMPROVANTE_COMPRAS"},
                new ComprovanteTipoConst(){Codigo = "01", Nome = "COMPROVANTE_VOUCHER"},
                new ComprovanteTipoConst(){Codigo = "02", Nome = "COMPROVANTE_CHEQUE"},
                new ComprovanteTipoConst(){Codigo = "03", Nome = "COMPROVANTE_PAGAMENTO"},
                new ComprovanteTipoConst(){Codigo = "04", Nome = "COMPROVANTE_GERENCIAL"},
                new ComprovanteTipoConst(){Codigo = "05", Nome = "COMPROVANTE_CB"},
                new ComprovanteTipoConst(){Codigo = "06", Nome = "COMPROVANTE_RECARGA_CELULAR"},
                new ComprovanteTipoConst(){Codigo = "07", Nome = "COMPROVANTE_RECARGA_BONUS"},
                new ComprovanteTipoConst(){Codigo = "08", Nome = "COMPROVANTE_RECARGA_PRESENTE"},
                new ComprovanteTipoConst(){Codigo = "09", Nome = "COMPROVANTE_RECARGA_SP_TRANS"},
                new ComprovanteTipoConst(){Codigo = "10", Nome = "COMPROVANTE_MEDICAMENTOS"}
            };
        }
        public static ComprovanteTipoConst RetornarComprovanteTipo(string _codigo)
        {
            return RetornarLista().Find(p => p.Codigo == _codigo);
        }
    }
}
