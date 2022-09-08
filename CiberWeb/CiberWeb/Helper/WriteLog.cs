using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CiberWeb.Helper
{
    public class WriteLog
    {
        public static void LogToText(string message)
        {
            var baseUrl = AppDomain.CurrentDomain.BaseDirectory;
            var pathLog = baseUrl + "log.txt";
            DateTime dt = DateTime.Now;
            File.AppendAllText(pathLog,"\n" + dt + " :" + message);
        }
    }
}
