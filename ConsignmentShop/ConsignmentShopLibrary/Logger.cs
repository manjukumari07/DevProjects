using System;
using System.IO;

namespace ConsignmentShopLibrary
{
    public class Logger
    {
        private string filePath = string.Empty;
   
        public void LogWrite(string logMessage)
        {
            filePath = Path.GetDirectoryName(@"C:\Users\panka\source\repos\ConsignmentShop\ConsignmentShop");
            try
            {
                using (StreamWriter w = File.AppendText(filePath + "\\" + "logFile.txt"))
                {
                    Log(logMessage, w);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Log(string logMessage, TextWriter txtWriter)
        {
            try
            {
                txtWriter.Write("\r\nLog Information:");
                txtWriter.WriteLine("\n {0} {1} :", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                txtWriter.WriteLine("{0}", logMessage);
                txtWriter.WriteLine("\n-------------------------------");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
