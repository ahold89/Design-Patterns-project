using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP._302856026322057712
{
    public class HoroscopeFacade
    {
        public string m_BirthDay { get; set; }

        public HoroscopeFacade(string i_BirthDay)
        {
            m_BirthDay = i_BirthDay;
        }

        public string GetTodayHoroscope()
        {
            string returnedHoroscope = string.Empty;

            Astrology[] signsArray = new Astrology[12];

            // fill the array with all the astroligies
            for (int i = 0; i < 12; i++)
            {
                signsArray[i] = new Astrology(Astrology.Sr_Signs[i], Astrology.Sr_Signs[(i + 1) % 12], Astrology.Sr_SwitchingDayArr[i]);
            }

            HoroscopeLogic horoscopeLogic = new HoroscopeLogic(m_BirthDay, signsArray);

            returnedHoroscope = horoscopeLogic.StartProcedure();

            return returnedHoroscope;
        }
    }
}
