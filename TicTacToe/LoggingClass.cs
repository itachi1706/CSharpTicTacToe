using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class LoggingClass
    {
        private static ArrayList logFile;

        public static void initLog()
        {
            logFile = new ArrayList();
        }

        public static void logInfo(String title, String message)
        {
            DateTime now = DateTime.Now;
            String msg = "[INFO] [" + now + "] " + title + ": " + message;
            logFile.Add(msg);
        }

        public static void logError(String title, String message)
        {
            DateTime now = DateTime.Now;
            String msg = "[ERROR] [" + now + "] " + title + ": " + message;
            logFile.Add(msg);
        }

        public static ArrayList getLogList()
        {
            return logFile;
        }
    }
}
