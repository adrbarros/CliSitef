using System.Drawing;

namespace Lib.Utils.Classes
{
    public class Functions
    {
        public static Bitmap Gerar_QRCode(int width, int height, string text)
        {
            try
            {
                ZXing.Windows.Compatibility.BarcodeWriter bw = new ZXing.Windows.Compatibility.BarcodeWriter();
                var encOptions = new ZXing.Common.EncodingOptions() { Width = width, Height = height, Margin = 0 };
                bw.Options = encOptions;
                bw.Format = ZXing.BarcodeFormat.QR_CODE;
                Bitmap resultado = new Bitmap(bw.Write(text));
                return resultado;
            }
            catch
            {
                throw;
            }
        }
    }
}