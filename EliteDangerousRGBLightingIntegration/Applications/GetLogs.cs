using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteDangerousRGBLightingIntegration.Applications
{
    class GetLogs
    {
        public string logFolder;

        public static string GetLogFile(string location)
        {

            var directory = new DirectoryInfo(location);
            var log = (from f in directory.GetFiles()
                          orderby f.LastWriteTime descending
                          select f).First().FullName;
            return log;
        }
    }
}