using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP._302856026322057712
{
    public static class StatusFactory
    {
        public static StatusFromUser Create(string i_Text, DateTime i_TimeToPost)
        {
            DateTime timeToPostWithoutSeconds = new DateTime(i_TimeToPost.Year, i_TimeToPost.Month, i_TimeToPost.Day, i_TimeToPost.Hour, i_TimeToPost.Minute, 0);

            if (checkIfFutureTime(timeToPostWithoutSeconds))
            {
                // it's delayed
                return new DelayedStatus(i_Text, timeToPostWithoutSeconds);
            }
            else
            {
                // it's now
                return new RegularStatus(i_Text);
            }
        }

        // check if the given time is in past or future
        private static bool checkIfFutureTime(DateTime i_TimeToCheck)
        {
            bool returnValue = true;
            DateTime now = DateTime.Now;

            if (DateTime.Compare(i_TimeToCheck, now) <= 0)
            {
                returnValue = false;
            }

            return returnValue;
        }
    }
}
