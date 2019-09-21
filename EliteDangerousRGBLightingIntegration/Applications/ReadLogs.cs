using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteDangerousRGBLightingIntegration.Applications
{
    class ReadLogs
    {
        public static string ReadLogFile(string log)
        {
            string line = File.ReadLines(log).First();
            return line;
        }
    }
}
