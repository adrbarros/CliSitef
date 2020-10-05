using System;
using System.Collections.Generic;

namespace App.CliSiTef_DLL.Classes
{
    public class TefTransacao
    {
        public string DocumentoVinculado { get; set; }
        public decimal ValorTransacao { get; set; }

        List<TefRetorno> retornos;
        public List<TefRetorno> Retornos
        {
            get
            {
                if (retornos == null)
                    retornos = new List<TefRetorno>();
                return retornos;
            }
        }
    }
}
