using System;
using System.IO;
using System.Windows.Forms;

namespace Lib.Utils.Logs
{
    public class Log
    {
        public static void GerarLogProcessoExecucao(string _msg, string _path = "")
        {
            string pathFinal = !string.IsNullOrWhiteSpace(_path) ? _path : Application.StartupPath + "\\Logs";
            if (!Directory.Exists(pathFinal))
                Directory.CreateDirectory(pathFinal);

            string nomeArquivo = "Log" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
            using (StreamWriter sr = File.AppendText(pathFinal + "\\" + nomeArquivo))
            {
                sr.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " -> " + _msg);
                sr.Flush();
            }
        }
    }
}