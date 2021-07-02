using System;
using System.Collections.Generic;

namespace Lib.CliSitef.ConstantValues
{
    public class SatNfceBandeiraConst
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
                return string.IsNullOrWhiteSpace(Nome) ? "" : Codigo + "|" + Nome;
            }
        }
    }

    public class SatNfceBandeira
    {
        public static List<SatNfceBandeiraConst> RetornarLista()
        {
            return new List<SatNfceBandeiraConst>()
            {
                new SatNfceBandeiraConst() { Codigo = "01", Nome = "VISA" },
                new SatNfceBandeiraConst() { Codigo = "02", Nome = "MASTERCARD" },
                new SatNfceBandeiraConst() { Codigo = "03", Nome = "AMERICAN EXPRESS" },
                new SatNfceBandeiraConst() { Codigo = "04", Nome = "SOROCRED" },
                new SatNfceBandeiraConst() { Codigo = "05", Nome = "DINERS CLUB" },
                new SatNfceBandeiraConst() { Codigo = "06", Nome = "ELO" },
                new SatNfceBandeiraConst() { Codigo = "07", Nome = "HIPERCARD" },
                new SatNfceBandeiraConst() { Codigo = "08", Nome = "AURA" },
                new SatNfceBandeiraConst() { Codigo = "09", Nome = "CABAL" },
                new SatNfceBandeiraConst() { Codigo = "10", Nome = "ALELO" },
                new SatNfceBandeiraConst() { Codigo = "11", Nome = "BANES CARD" },
                new SatNfceBandeiraConst() { Codigo = "12", Nome = "CALCARD" },
                new SatNfceBandeiraConst() { Codigo = "13", Nome = "CREDZ" },
                new SatNfceBandeiraConst() { Codigo = "14", Nome = "DISCOVER" },
                new SatNfceBandeiraConst() { Codigo = "15", Nome = "GOODCARD" },
                new SatNfceBandeiraConst() { Codigo = "16", Nome = "GREENCARD" },
                new SatNfceBandeiraConst() { Codigo = "17", Nome = "HIPER" },
                new SatNfceBandeiraConst() { Codigo = "18", Nome = "JCB" },
                new SatNfceBandeiraConst() { Codigo = "19", Nome = "MAIS" },
                new SatNfceBandeiraConst() { Codigo = "20", Nome = "MAXVAN" },
                new SatNfceBandeiraConst() { Codigo = "21", Nome = "POLICARD" },
                new SatNfceBandeiraConst() { Codigo = "22", Nome = "REDECOMPRAS" },
                new SatNfceBandeiraConst() { Codigo = "23", Nome = "SODEXO" },
                new SatNfceBandeiraConst() { Codigo = "24", Nome = "VALECARD" },
                new SatNfceBandeiraConst() { Codigo = "25", Nome = "VEROCHEQUE" },
                new SatNfceBandeiraConst() { Codigo = "26", Nome = "VR" },
                new SatNfceBandeiraConst() { Codigo = "27", Nome = "TICKET" },
                new SatNfceBandeiraConst() { Codigo = "99", Nome = "OUTROS" }
            };
        }

        public static SatNfceBandeiraConst RetornarSatNfceBandeira(int _codigo)
        {
            SatNfceBandeiraConst obj = RetornarLista().Find(p => p.CodigoInt == _codigo);
            if (obj == null)
            {
                obj = RetornarLista().Find(p => p.CodigoInt == 99);
                obj.Nome += " - " + _codigo.ToString("00");
            }
            return obj;
        }
    }
}

