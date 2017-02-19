using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP._302856026322057712
{
    public class DelayedStatus : StatusFromUser
    {
        public DelayedStatus(string i_Text, DateTime i_TimeToPost)
        {
            m_Text = i_Text;
            m_TimeToPost = i_TimeToPost;
        }

        public override void Post()
        {
            // flag to tell if we want to add status to the database or post status and remove it
            bool v_AddToTheDataBase = true;

            // cancle the seconds in order to prevent bugs
            DateTime timeToPostWithoutSeconds = new DateTime(m_TimeToPost.Year, m_TimeToPost.Month, m_TimeToPost.Day, m_TimeToPost.Hour, m_TimeToPost.Minute, 0);

            PostDelayedStatusLogic postDelayedStatusLogic = PostDelayedStatusLogic.Instance;
            postDelayedStatusLogic.AddOrRemoveStatusFromDictionary(timeToPostWithoutSeconds.ToString(), m_Text, v_AddToTheDataBase);
        }

        public override string ToString()
        {
            string returnedString = "Delayed Status";
            return returnedString;
        }
    }
}
