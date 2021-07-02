using System;
using System.Collections.Generic;

namespace Lib.CliSitef.ConstantValues
{
    public class CarteiraDigitalTipoVoucherConst
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
    public class CarteiraDigitalTipoVoucher
    {
        public static List<CarteiraDigitalTipoVoucherConst> RetornarLista()
        {
            return new List<CarteiraDigitalTipoVoucherConst>()
                {
                    new CarteiraDigitalTipoVoucherConst(){Codigo = "00", Nome = "NAO E VOUCHER"},
                    new CarteiraDigitalTipoVoucherConst(){Codigo = "01", Nome = "ALIMENTACAO"},
                    new CarteiraDigitalTipoVoucherConst(){Codigo = "02", Nome = "REFEICAO"},
                    new CarteiraDigitalTipoVoucherConst(){Codigo = "03", Nome = "CULTURA"},
                    new CarteiraDigitalTipoVoucherConst(){Codigo = "04", Nome = "PREMIUM"},
                    new CarteiraDigitalTipoVoucherConst(){Codigo = "05", Nome = "BENEFICIO"},
                    new CarteiraDigitalTipoVoucherConst(){Codigo = "06", Nome = "FARMACIA"},
                    new CarteiraDigitalTipoVoucherConst(){Codigo = "07", Nome = "MULTIPLOS"},
                    new CarteiraDigitalTipoVoucherConst(){Codigo = "99", Nome = "OUTROS"}
                };
        }
        public static CarteiraDigitalTipoVoucherConst RetornarTipoVoucher(int _codigo)
        {
            return RetornarLista().Find(p => p.CodigoInt == _codigo);
        }
    }
}
