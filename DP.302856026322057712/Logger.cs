using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DP._302856026322057712
{
    public class Logger
    {
        // fields
        public const string k_FileName = @"\LoggerResults.txt";

        public StreamWriter m_StreamWriter { get; set; }

        // constructor
        public Logger()
        {
            string filePath = Directory.GetCurrentDirectory() + k_FileName;
            if (!File.Exists(filePath))
            {
                m_StreamWriter = File.CreateText(filePath);
            }
            else
            {
                m_StreamWriter = File.AppendText(filePath);
                m_StreamWriter.WriteLine(Environment.NewLine);
            }
        }

        public void WriteToLogger(string i_Line)
        {
            m_StreamWriter.WriteLine(i_Line);
            m_StreamWriter.Flush();
        }
    }
}
