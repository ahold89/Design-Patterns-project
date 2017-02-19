using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP._302856026322057712
{
    public class Astrology
    {
        public static readonly string[] Sr_Signs = { "Capricorn", "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius" };
        public static readonly int[] Sr_SwitchingDayArr = { 21, 20, 21, 21, 21, 22, 23, 23, 24, 24, 23, 22 };

        // members
        public string m_FirstSignOfMonth { get; set; }

        public string m_SecondSignOfMonth { get; set; }
        
        public int m_SwitchDayOfSign { get; set; }

        // constructor
        public Astrology(string i_FirstSignOfMonth, string i_SecondSignOfMonth, int i_SwitchDayOfSign)
        {
            m_FirstSignOfMonth = i_FirstSignOfMonth;
            m_SecondSignOfMonth = i_SecondSignOfMonth;
            m_SwitchDayOfSign = i_SwitchDayOfSign;
        }
    }
}