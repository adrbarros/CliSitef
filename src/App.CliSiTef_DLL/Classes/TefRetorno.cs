namespace App.CliSiTef_DLL.Classes
{
    public class TefRetorno
    {
        public TefRetorno()
        { }

        public TefRetorno(int _codigo, int _indice, string _valor)
        {
            Codigo = _codigo;
            Indice = _indice;
            Valor = _valor;
        }

        public int Codigo { get; set; }
        public int Indice { get; set; }
        public string Valor { get; set; }
    }
}
