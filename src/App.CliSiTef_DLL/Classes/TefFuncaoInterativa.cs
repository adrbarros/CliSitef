namespace App.CliSiTef_DLL.Classes
{
    public enum DataTypeEnum { Alphanumeric, Numeric, Currency, Information, Confirmation, Await, Menu, QrCode }
    public class TefFuncaoInterativa
    {
        public TefFuncaoInterativa()
        {
            DataType = DataTypeEnum.Alphanumeric;
            RespostaSitef = "";
        }

        public DataTypeEnum DataType { get; set; }
        public long TipoCampo { get; set; }
        public short TamanhoMinimo { get; set; }
        public short TamanhoMaximo { get; set; }
        public string[] ItensMenu { get; set; }
        public string RespostaSitef { get; set; }
        public bool Interromper { get; set; }
        public string Titulo { get; set; }
        public string Mensagem { get; set; }
    }
}
