using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP._302856026322057712
{
    public class RegularStatus : StatusFromUser
    {
        public RegularStatus(string i_Text)
        {
            m_Text = i_Text;
            m_TimeToPost = DateTime.Now;
        }

        public override void Post()
        {
            try
            {
                FormMain.s_User.PostStatus(m_Text);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public override string ToString()
        {
            string returnedString = "Regular Status";
            return returnedString;
        }
    }
}
