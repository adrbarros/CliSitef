using System;
using System.IO;

namespace Lib.Utils.Logs
{
    public class Log
    {
        public static void GerarLogProcessoExecucao(string _path, string _msg)
        {
            string pathFinal = _path + "\\Logs";
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