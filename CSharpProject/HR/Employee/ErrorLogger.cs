using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    static class ErrorLogger
    {
        private static string logFile = @"Exception log.txt";
        public static void log(this Exception ex)
        {
            using (StreamWriter writer = new StreamWriter(logFile,true))
            {
                writer.WriteLine("\n-----------");
                writer.WriteLine(DateTime.Now.ToShortTimeString()+" - "+ DateTime.Now.ToShortDateString());
                writer.WriteLine("Error message: "+ex.Message);
                writer.WriteLine("Stack stace:");
                writer.WriteLine(ex.StackTrace);
            }
        }
    }
}
