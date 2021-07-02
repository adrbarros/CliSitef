using System;
using System.Collections.Generic;

namespace Lib.CliSitef.ConstantValues
{
    public class CarteiraDigitalTipoPagamentoConst
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }

        public int CodigoInt
        {
            get
            {
                return string.IsNullOrWhiteSpace(Codigo) ? 0 : Convert.ToInt32(Codigo);
            }
        }
        public string CodigoNome
        {
            get
            {
                return string.IsNullOrWhiteSpace(Nome) ? "" : Codigo + "|" + Nome + "|CARTEIRA DIGITAL";
            }
        }
    }

    public class CarteiraDigitalTipoPagamento
    {
        public static List<CarteiraDigitalTipoPagamentoConst> RetornarLista()
        {
            return new List<CarteiraDigitalTipoPagamentoConst>()
            {
                new CarteiraDigitalTipoPagamentoConst(){Codigo = "01", Nome = "CREDITO"},
                new CarteiraDigitalTipoPagamentoConst(){Codigo = "02", Nome = "DEBITO"},
                new CarteiraDigitalTipoPagamentoConst(){Codigo = "03", Nome = "PRE-PAGO"},
                new CarteiraDigitalTipoPagamentoConst(){Codigo = "04", Nome = "FROTA"},
                new CarteiraDigitalTipoPagamentoConst(){Codigo = "05", Nome = "CREDIARIO"},
                new CarteiraDigitalTipoPagamentoConst(){Codigo = "09", Nome = "NAO DEFINIDO"}
            };
        }
        public static CarteiraDigitalTipoPagamentoConst RetornarTipoPagamento(int _codigo)
        {
            return RetornarLista().Find(p => p.CodigoInt == _codigo);
        }
    }
}
