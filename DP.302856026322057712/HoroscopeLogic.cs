using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace DP._302856026322057712
{
    public class HoroscopeLogic
    {
        // members
        private string m_BirthDay { get; set; }

        private Astrology[] m_AstroArray { get; set; }

        private const string k_WebsiteLink = "http://www.horoscopeservices.co.uk/daily-horoscopes/b1-daily-horoscopes.asp";

        private const int k_MaxCount = 1000;

        private const int k_ParagraphGap = 3;

        // constructor
        public HoroscopeLogic(string i_BirthDay, Astrology[] i_AstroArray)
        {
            m_BirthDay = i_BirthDay;

            m_AstroArray = i_AstroArray;
        }

        // Returns the horoscope paragraph from the website as a string.
        private static string horoscopeFinder(string i_Sign)
        {
            string horoscope = string.Empty;
            string pageContent = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(k_WebsiteLink);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader webStream = new StreamReader(response.GetResponseStream());
            pageContent = webStream.ReadToEnd();
            horoscope = horoscopeHelper(i_Sign, pageContent);

            return horoscope;
        }

        // Filters the given sign horoscope out of website's page content.
        private static string horoscopeHelper(string i_Sign, string i_PageContent)
        {
            // the return string initialize to message in case we face a problem to read the horoscope
            string returnString = "couldn't find";
            string horoscopeAsString = string.Empty;
            string horoscopeRaw = string.Empty;
            int startIndex = 0;
            int endIndex = 0;
            int lengthOfParagraph = 0;

            if (i_PageContent.Contains(i_Sign))
            {
                // Found It
                int signIndex = i_PageContent.IndexOf(i_Sign);

                // The length read ensures to read the whole astrologic sign paragraph:
                horoscopeRaw = i_PageContent.Substring(signIndex, k_MaxCount);
                startIndex = horoscopeRaw.IndexOf("<p>") + k_ParagraphGap;
                endIndex = horoscopeRaw.IndexOf("</p>");
                lengthOfParagraph = endIndex - startIndex;
                horoscopeAsString = string.Format("{0} horoscope: {1}", i_Sign, horoscopeRaw.Substring(startIndex, lengthOfParagraph));

                returnString = horoscopeAsString;
            }

            return returnString;
        }

        // returns the string that will appear on the form ultimately.
        public string StartProcedure()
        {
            // will hold the horscope
            string horoscopeToShow = string.Empty;

            // will hold the user's bithday day and month as int array 
            int[] dayAndMonth = stringDateToIntArray(m_BirthDay);
            horoscopeToShow = horoscopeFinder(signFinder(dayAndMonth));

            return horoscopeToShow;
        }

        // Returns a 2 cell array -> {day, month}
        private int[] stringDateToIntArray(string i_DateAsString)
        {
            int[] dayAndMonth = new int[2];

            string monthStr = i_DateAsString.Substring(0, 2);
            string dayStr = i_DateAsString.Substring(3, 2);

                int monthInt = int.Parse(monthStr);
                int dayInt = int.Parse(dayStr);

                dayAndMonth[0] = dayInt;
                dayAndMonth[1] = monthInt;
            
            return dayAndMonth;
        }

        // Using Astrology Class and User's birthday we return its sign.
        private string signFinder(int[] i_DayAndMonth)
        {
            string signToReturn = string.Empty;
            int day = i_DayAndMonth[0];

            // We subtract 1 because the array is zero based.
            int month = i_DayAndMonth[1] - 1;

            // If user's birthday is before the cut the sign returned will be the first sign of the month.
            signToReturn = (day < this.m_AstroArray[month].m_SwitchDayOfSign) ?
                this.m_AstroArray[month].m_FirstSignOfMonth : this.m_AstroArray[month].m_SecondSignOfMonth;

            return signToReturn;
        }
    }
}
