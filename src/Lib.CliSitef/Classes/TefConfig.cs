namespace Lib.CliSitef.Classes
{
    public class TefConfig
    {
        public string Tef_Ip { get; set; }
        public string Tef_Empresa { get; set; }
        public string Tef_EmpresaCnpj { get; set; }
        public string Tef_Terminal { get; set; }
        public string Tef_SoftwareHouseCnpj { get; set; }
        public string Tef_PinPadPorta { get; set; }
        public string Tef_PinPadMensagem { get; set; }
        public bool Tef_PinPadVerificar { get; set; }
        public bool Tef_PinPadQrCode { get; set; }
        public string Tef_PathArquivos { get; set; }
        public int Tef_SenhaCodigoSupervisor { get; set; }
        public string Tef_TipoComunicacaoExterna { get; set; }
    }
}
