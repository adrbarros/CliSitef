using System;
using System.Collections.Generic;

namespace Lib.CliSitef.ConstantValues
{
    public class SatNfceCredenciadoraConst
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        public int CodigoInt
        {
            get
            {
                return string.IsNullOrWhiteSpace(Codigo) ? 0 : Convert.ToInt32(Codigo);
            }
        }
        public string CodigoNomeCnpj
        {
            get
            {
                return string.IsNullOrWhiteSpace(Nome) ? "" : Codigo + "|" + Nome + "|" + Cnpj;
            }
        }
    }

    public class SatNfceCredenciadora
    {
        public static List<SatNfceCredenciadoraConst> RetornarLista()
        {
            return new List<SatNfceCredenciadoraConst>()
            {
                new SatNfceCredenciadoraConst() { Codigo = "001", Nome = "ADMINISTRADORA DE CARTÕES SICREDI LTDA.", Cnpj = "03.106.213/0001-90"},
                new SatNfceCredenciadoraConst() { Codigo = "002", Nome = "ADMINISTRADORA DE CARTÕES SICREDI LTDA.(FILIAL RS)", Cnpj = "03.106.213/0002-71"},
                new SatNfceCredenciadoraConst() { Codigo = "003", Nome = "BANCO AMERICAN EXPRESS S/A - AMEX", Cnpj = "60.419.645/0001-95"},
                new SatNfceCredenciadoraConst() { Codigo = "004", Nome = "BANCO GE - CAPITAL", Cnpj = "62.421.979/0001-29"},
                new SatNfceCredenciadoraConst() { Codigo = "005", Nome = "BANCO SAFRA S/A", Cnpj = "58.160.789/0001-28"},
                new SatNfceCredenciadoraConst() { Codigo = "006", Nome = "BANCO TOPÁZIO S/A", Cnpj = "07.679.404/0001-00"},
                new SatNfceCredenciadoraConst() { Codigo = "007", Nome = "BANCO TRIANGULO S/A", Cnpj = "17.351.180/0001-59"},
                new SatNfceCredenciadoraConst() { Codigo = "008", Nome = "BIGCARD ADM. DE CONVENIOS E SERV.", Cnpj = "04.627.085/0001-93"},
                new SatNfceCredenciadoraConst() { Codigo = "009", Nome = "BOURBON ADM. DE CARTÕES DE CRÉDITO", Cnpj = "01.418.852/0001-66"},
                new SatNfceCredenciadoraConst() { Codigo = "010", Nome = "CABAL BRASIL LTDA.", Cnpj = "03.766.873/0001-06"},
                new SatNfceCredenciadoraConst() { Codigo = "011", Nome = "CETELEM BRASIL S/A - CFI", Cnpj = "03.722.919/0001-87"},
                new SatNfceCredenciadoraConst() { Codigo = "012", Nome = "CIELO S/A", Cnpj = "01.027.058/0001-91"},
                new SatNfceCredenciadoraConst() { Codigo = "013", Nome = "CREDI 21 PARTICIPAÇÕES LTDA.", Cnpj = "03.529.067/0001-06"},
                new SatNfceCredenciadoraConst() { Codigo = "014", Nome = "ECX CARD ADM. E PROCESSADORA DE CARTÕES S/A", Cnpj = "71.225.700/0001-22"},
                new SatNfceCredenciadoraConst() { Codigo = "015", Nome = "EMPRESA BRAS. TEC. ADM. CONV. HOM. LTDA. - EMBRATEC", Cnpj = "03.506.307/0001-57"},
                new SatNfceCredenciadoraConst() { Codigo = "016", Nome = "EMPÓRIO CARD LTDA", Cnpj = "04.432.048/0001-20"},
                new SatNfceCredenciadoraConst() { Codigo = "017", Nome = "FREEDDOM E TECNOLOGIA E SERVIÇOS S/A", Cnpj = "07.953.674/0001-50"},
                new SatNfceCredenciadoraConst() { Codigo = "018", Nome = "FUNCIONAL CARD LTDA.", Cnpj = "03.322.366/0001-75"},
                new SatNfceCredenciadoraConst() { Codigo = "019", Nome = "HIPERCARD BANCO MULTIPLO S/A", Cnpj = "03.012.230/0001-69"},
                new SatNfceCredenciadoraConst() { Codigo = "020", Nome = "MAPA ADMIN. CONV. E CARTÕES LTDA.", Cnpj = "03.966.317/0001-75"},
                new SatNfceCredenciadoraConst() { Codigo = "021", Nome = "NOVO PAG ADM. E PROC. DE MEIOS ELETRÔNICOS DE PAGTO. LTDA.", Cnpj = "00.163.051/0001-34"},
                new SatNfceCredenciadoraConst() { Codigo = "022", Nome = "PERNAMBUCANAS FINANCIADORA S/A CRÉDITO, FIN.E INVEST.", Cnpj = "43.180.355/0001-12"},
                new SatNfceCredenciadoraConst() { Codigo = "023", Nome = "POLICARD SYSTEMS E SERVIÇOS LTDA.", Cnpj = "00.904.951/0001-95"},
                new SatNfceCredenciadoraConst() { Codigo = "024", Nome = "PROVAR NEGÓCIOS DE VAREJO LTDA.", Cnpj = "33.098.658/0001-37"},
                new SatNfceCredenciadoraConst() { Codigo = "025", Nome = "REDECARD S/A", Cnpj = "01.425.787/0001-04"},
                new SatNfceCredenciadoraConst() { Codigo = "026", Nome = "RENNER ADM. CARTÕES DE CRÉDITO LTDA.", Cnpj = "90.055.609/0001-50"},
                new SatNfceCredenciadoraConst() { Codigo = "027", Nome = "RP ADMINISTRAÇÃO DE CONVÊNIOS LTDA.", Cnpj = "03.007.699/0001-00"},
                new SatNfceCredenciadoraConst() { Codigo = "028", Nome = "SANTINVEST S/A CRÉDITO, FINANCIAMENTO E INVESTIMENTOS", Cnpj = "00.122.327/0001-36"},
                new SatNfceCredenciadoraConst() { Codigo = "029", Nome = "SODEXHO PASS DO BRASIL SERVIÇOS E COMÉRCIO S/A", Cnpj = "69.034.668/0001-56"},
                new SatNfceCredenciadoraConst() { Codigo = "030", Nome = "SOROCRED MEIOS DE PAGAMENTOS LTDA.", Cnpj = "60.114.865/0001-00"},
                new SatNfceCredenciadoraConst() { Codigo = "031", Nome = "TECNOLOGIA BANCÁRIA S/A - TECBAN", Cnpj = "51.427.102/0004-71"},
                new SatNfceCredenciadoraConst() { Codigo = "032", Nome = "TICKET SERVIÇOS S/A", Cnpj = "47.866.934/0001-74"},
                new SatNfceCredenciadoraConst() { Codigo = "033", Nome = "TRIVALE ADMINISTRAÇÃO LTDA.", Cnpj = "00.604.122/0001-97"},
                new SatNfceCredenciadoraConst() { Codigo = "034", Nome = "UNICARD BANCO MÚLTIPLO S/A - TRICARD", Cnpj = "61.071.387/0001-61"},
                new SatNfceCredenciadoraConst() { Codigo = "999", Nome = "OUTROS", Cnpj = ""}
            };
        }
        public static SatNfceCredenciadoraConst RetornarSatNfceCredenciadora(int _codigo)
        {
            SatNfceCredenciadoraConst obj = RetornarLista().Find(p => p.CodigoInt == _codigo);
            if (obj == null)
            {
                obj = RetornarLista().Find(p => p.CodigoInt == 999);
                obj.Nome += " - " + _codigo.ToString("000");
            }
            return obj;
        }
    }
}
