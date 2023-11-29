using Lib.CliSitef.ConstantValues;

namespace Lib.CliSitef.Classes
{
    public class CampoAberto
    {
        public MensagemExibidaEnum MensagemExibidaPinPad { get; set; }
        public int TamanhoMinimo { get; set; }
        public int TamanhoMaximo { get; set; }
        public int TempoEsperaInatividade { get; set; }
    }

    public class CampoAbertoMsg
    {
        public static string RetornarMensagemPinPad(MensagemExibidaEnum _msg)
        {
            string msg = "";
            switch (_msg)
            {
                case MensagemExibidaEnum.DigiteDDD:
                    msg = "1";
                    break;
                case MensagemExibidaEnum.RedigiteDDD:
                    msg = "2";
                    break;
                case MensagemExibidaEnum.DigiteTelefone:
                    msg = "3";
                    break;
                case MensagemExibidaEnum.RedigiteTtelefone:
                    msg = "4";
                    break;
                case MensagemExibidaEnum.DigiteDDDTelefone:
                    msg = "5";
                    break;
                case MensagemExibidaEnum.RedigiteDDDTelefone:
                    msg = "6";
                    break;
                case MensagemExibidaEnum.DigiteCpf:
                    msg = "7";
                    break;
                case MensagemExibidaEnum.RedigiteCpf:
                    msg = "8";
                    break;
                case MensagemExibidaEnum.DigiteRg:
                    msg = "9";
                    break;
                case MensagemExibidaEnum.RedigiteRg:
                    msg = "A";
                    break;
                case MensagemExibidaEnum.Digite4UltimosDigitos:
                    msg = "B";
                    break;
                case MensagemExibidaEnum.DigiteCodigoSeguranca:
                    msg = "C";
                    break;
                case MensagemExibidaEnum.DigiteCnpj:
                    msg = "D";
                    break;
                case MensagemExibidaEnum.RedigiteCnpj:
                    msg = "E";
                    break;
                case MensagemExibidaEnum.DigiteDataDDMMAAAA:
                    msg = "F";
                    break;
                case MensagemExibidaEnum.DigiteDataDDMMAA:
                    msg = "10";
                    break;
                case MensagemExibidaEnum.DigiteDataDDMM:
                    msg = "11";
                    break;
                case MensagemExibidaEnum.DigiteDiaDD:
                    msg = "12";
                    break;
                case MensagemExibidaEnum.DigiteMesMM:
                    msg = "13";
                    break;
                case MensagemExibidaEnum.DigiteAnoAA:
                    msg = "14";
                    break;
                case MensagemExibidaEnum.DigiteAnoAAAA:
                    msg = "15";
                    break;
                case MensagemExibidaEnum.DataNascimentoDDMMAAAA:
                    msg = "16";
                    break;
                case MensagemExibidaEnum.DataNascimentoDDMMAA:
                    msg = "17";
                    break;
                case MensagemExibidaEnum.DataNascimentoDDMM:
                    msg = "18";
                    break;
                case MensagemExibidaEnum.DiaNascimentoDD:
                    msg = "19";
                    break;
                case MensagemExibidaEnum.MesNascimentoMM:
                    msg = "1A";
                    break;
                case MensagemExibidaEnum.AnoNascimentoAA:
                    msg = "1B";
                    break;
                case MensagemExibidaEnum.AnoNascimentoAAAA:
                    msg = "1C";
                    break;
                case MensagemExibidaEnum.DigiteIdentificacao:
                    msg = "1D";
                    break;
                case MensagemExibidaEnum.CodigoFidelidade:
                    msg = "1E";
                    break;
                case MensagemExibidaEnum.NumeroMesa:
                    msg = "1F";
                    break;
                case MensagemExibidaEnum.QuantidadePessoas:
                    msg = "20";
                    break;
                case MensagemExibidaEnum.DigiteQuantidade:
                    msg = "21";
                    break;
                case MensagemExibidaEnum.NumeroBomba:
                    msg = "22";
                    break;
                case MensagemExibidaEnum.NumeroVaga:
                    msg = "23";
                    break;
                case MensagemExibidaEnum.NumeroGuicheCaixa:
                    msg = "24";
                    break;
                case MensagemExibidaEnum.CodigoVendedor:
                    msg = "25";
                    break;
                case MensagemExibidaEnum.CodigoGarcom:
                    msg = "26";
                    break;
                case MensagemExibidaEnum.NotaAtendimento:
                    msg = "27";
                    break;
                case MensagemExibidaEnum.NumeroNotaFiscal:
                    msg = "28";
                    break;
                case MensagemExibidaEnum.NumeroComanda:
                    msg = "29";
                    break;
                case MensagemExibidaEnum.PlacaVeiculo:
                    msg = "2A";
                    break;
                case MensagemExibidaEnum.DigiteQuilometragem:
                    msg = "2B";
                    break;
                case MensagemExibidaEnum.QuilometragemInicial:
                    msg = "2C";
                    break;
                case MensagemExibidaEnum.QuilometragemFinal:
                    msg = "2D";
                    break;
                case MensagemExibidaEnum.DigitePorcentagem:
                    msg = "2E";
                    break;
                case MensagemExibidaEnum.PesquisaSatisfacao0a10:
                    msg = "2F";
                    break;
                case MensagemExibidaEnum.AvalieAtendimento0a10:
                    msg = "30";
                    break;
                case MensagemExibidaEnum.DigiteToken:
                    msg = "31";
                    break;
                case MensagemExibidaEnum.NumeroParcelas:
                    msg = "33";
                    break;
                case MensagemExibidaEnum.CodigoPlano:
                    msg = "34";
                    break;
                case MensagemExibidaEnum.CodigoProduto:
                    msg = "35";
                    break;
                default:
                    break;
            }
            return msg;
        }
    }
}
