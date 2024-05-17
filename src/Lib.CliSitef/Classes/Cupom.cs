using System.Collections.Generic;

namespace Lib.CliSitef.Classes
{
    public class Cupom
    {
        public string TipoOperacao { get; set; }
        public string DocumentoVinculado { get; set; }
        public decimal ValorTotal { get; set; }
        public bool Cancelamento {  get; set; }
        public string DataStr { get; set; }
        public string HoraStr { get; set; }
        public int FuncaoCodigo { get; set; }
        public string FuncaoDescricao
        {
            get
            {
                return FuncaoCodigo == 0 ? "" : FuncaoCodigo == 2 ? "DEBITO" : FuncaoCodigo == 3 ? "CREDITO" : "OUTROS";
            }
        }

        List<TefTransacao> transacoes;
        public List<TefTransacao> Transacoes
        {
            get
            {
                if (transacoes == null)
                    transacoes = new List<TefTransacao>();
                return transacoes;
            }
        }
    }
}
