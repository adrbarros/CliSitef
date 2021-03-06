﻿using System;
using System.Collections.Generic;

namespace Lib.CliSitef.Classes
{
    public class TefTransacao
    {
        public TefTransacao()
        {
            IdentificadorTransacao = Guid.NewGuid();
        }

        public Guid IdentificadorTransacao { get; set; }
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
