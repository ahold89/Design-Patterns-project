using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace DP._302856026322057712
{
    public delegate void ReportDelayedStatusWasPosted(string i_StatusText);

    public sealed class PostDelayedStatusLogic
    {
        // members
        private static PostDelayedStatusLogic s_Instance = null;

        private User m_User { get; set; }

        public static Dictionary<string, Queue<string>> s_DelayedPosts = new Dictionary<string, Queue<string>>();
        
        private static object s_LockObj = new object();

        private ReportDelayedStatusWasPosted m_ReportDelayedStatusWasPosted;

        public static PostDelayedStatusLogic Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new PostDelayedStatusLogic(FormMain.s_User);
                        }
                    }
                }

                return s_Instance;
            }
        }

        // constructor
        private PostDelayedStatusLogic(User i_User)
        {
            m_User = i_User;

            // create thread for checking if the requsted time for delayed status has come
            Thread newThread = new Thread(checkAndPostDelayedStatus);

            // needed for killing the thread automatically when closing the form 
            newThread.IsBackground = true;
            newThread.Start();
        }

        // notify all the observers that delayed status was postedS
        private void notify(string i_Status)
        {
            if (m_ReportDelayedStatusWasPosted != null)
            {
                m_ReportDelayedStatusWasPosted.Invoke(i_Status);
            }
        }

        // add new observer
        public void Attach(ReportDelayedStatusWasPosted i_ObserverDelegate)
        {
            m_ReportDelayedStatusWasPosted += i_ObserverDelegate;
        }

        // remove observer
        public void Detach(ReportDelayedStatusWasPosted i_ObserverDelegate)
        {
            m_ReportDelayedStatusWasPosted -= i_ObserverDelegate;
        }

        // object to lock the critical section
        private object locker = new object();

        // the method that handles withe the database of the delayed status. the method add new status to the list, or call other method 
        // to post the delayed status if its time has come and than remove it from the database.
        // the i_Addflag indicate if we should add a new status or post and remove status.
        public void AddOrRemoveStatusFromDictionary(string i_TimeToAddOrRemove, string i_Status, bool i_AddFlag)
        {
            lock (locker)
            {
                if (i_AddFlag)
                {
                    if (s_DelayedPosts.ContainsKey(i_TimeToAddOrRemove))
                    {
                        s_DelayedPosts[i_TimeToAddOrRemove].Enqueue(i_Status);
                    }
                    else
                    {
                        Queue<string> newStatusQueu = new Queue<string>();
                        newStatusQueu.Enqueue(i_Status);
                        s_DelayedPosts.Add(i_TimeToAddOrRemove, newStatusQueu);
                    }
                }
                else
                {
                    if (s_DelayedPosts.ContainsKey(i_TimeToAddOrRemove))
                    {
                        foreach (string status in s_DelayedPosts[i_TimeToAddOrRemove])
                        {
                            try
                            {
                                m_User.PostStatus(status);

                                // after posting the delayed status, call to the notify method to inform the relevents observers
                                notify(status);
                            }
                            catch(Facebook.FacebookApiException e)
                            {
                                MessageBox.Show(string.Format("{0}{1}It seems you tried to post too many status at the same time,{1}Some of them hasn't been posted.", e.Message, Environment.NewLine));
                            }
                        }

                        s_DelayedPosts.Remove(i_TimeToAddOrRemove);
                    }
                }
            }
        }

        // the method has a thread that wake up every 30 seconds in order to check if it is time to post delayed status.
        private void checkAndPostDelayedStatus()
        {
            // the flag will indicate the next method if we want to post and remove status from the database, or add a new one
            bool v_AddNewStatus = true;

            // get the current time 
            DateTime now = DateTime.Now;

            // remove the seconds in order to prevente bugs
            DateTime nowWithoutSeconds = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, 0);

            // the time as string needed to check the keys of the database
            string nowWithoutSecondsAsString = nowWithoutSeconds.ToString();

            while (true)
            {
                Thread.Sleep(30000);

                // get the current time 
                now = DateTime.Now;

                // remove the seconds in order to prevente bugs
                nowWithoutSeconds = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, 0);

                // the time as string needed to check the keys of the database
                nowWithoutSecondsAsString = nowWithoutSeconds.ToString();

                AddOrRemoveStatusFromDictionary(nowWithoutSecondsAsString, string.Empty, !v_AddNewStatus);
            }
        }
    }
}
