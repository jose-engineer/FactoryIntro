﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public sealed class Log : ILog
    {
        private Log()
        {
        }

        private static readonly Lazy<Log> instance = new Lazy<Log>(() => new Log());

        public static Log GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        public void LogException(string message)
        {
            string fileName = string.Format("{0}_{1}.log", "Exception", "fechadehoy");
            string logFilePath = string.Format(@"{0}\{1}", "C:\\Users\\Alayn Juarez\\Documents\\Visual Studio 2017", fileName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }
    }
}
