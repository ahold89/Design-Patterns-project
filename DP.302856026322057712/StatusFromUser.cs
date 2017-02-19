using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace DP._302856026322057712
{
    public abstract class StatusFromUser
    {
        public string m_Text { get; set; }

        public DateTime m_TimeToPost { get; set; }

        public void WriteToLogAndPost()
        {
            documentToLogger();
            Post();
        }

        private void documentToLogger()
        {
            string lineForTheLogger = string.Format("{0}: {1} was written.", DateTime.Now.ToString(), this.ToString());
            FormMain.s_Logger.WriteToLogger(lineForTheLogger);
        }

        public abstract void Post();
    }
}
