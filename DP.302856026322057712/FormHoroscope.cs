using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace DP._302856026322057712
{
    public partial class FormHoroscope : Form
    {
        // members
        private HoroscopeFacade m_HoroscopeFacade { get; set; }

        // constructor
        public FormHoroscope()
        {
            m_HoroscopeFacade = new HoroscopeFacade(FormMain.s_User.Birthday);
            InitializeComponent();
        }

        // write the horoscope to the textbox
        public void WriteHoroscopeToTextBox()
        {
            string horoscopeToShow = string.Empty;

            try
            {
                horoscopeToShow = m_HoroscopeFacade.GetTodayHoroscope();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            this.textBox1.Text = horoscopeToShow;
            this.textBox1.Enabled = false;
        }

        private void buttonPostHoroscope_Click(object sender, EventArgs e)
        {
            tryToPostHoroscope();
        }

        private void tryToPostHoroscope()
        {
            string doneMessage = "Done!";

            try
            {
                StatusFromUser horoscope = StatusFactory.Create(textBox1.Text, DateTime.Now);
                horoscope.Post();
                MessageBox.Show(doneMessage);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            // in order not to post again
            this.buttonPostHoroscope.Enabled = false;
        }
    }
}