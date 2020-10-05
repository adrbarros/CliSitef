using System.Collections.Generic;

namespace App.CliSiTef_DLL.Classes
{
    public class Cupom
    {
        public string TipoOperacao { get; set; }
        public string DocumentoVinculado { get; set; }
        public decimal ValorTotal { get; set; }

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
