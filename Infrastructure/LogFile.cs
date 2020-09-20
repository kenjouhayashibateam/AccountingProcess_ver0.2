using Domain.Repositories;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Infrastructure
{
    class LogFile : ILogger
    {
        public void Log(ILogger.LogInfomation info, string message)
        {
            StreamWriter streamWriter = new StreamWriter(Properties.Resources.LogFilePath, true);

            streamWriter.WriteLine($"{info}{"\t"}{message}");
            streamWriter.Flush();
        }
    }
}
