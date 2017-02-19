using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace DP._302856026322057712
{
    public partial class FormCreateAlbum : Form
    {
        private User m_User { get; set; }

        // constructor
        public FormCreateAlbum(User i_User)
        {
            m_User = i_User;
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            tryToCreateAlbum();
        }
        
        private void tryToCreateAlbum()
        {
            string doneMessage = "Done!";
            string albumCreatedMessage = string.Format("{0}: Album created", DateTime.Now.ToString());

            try
            {
                m_User.CreateAlbum(textBoxName.Text, textBoxDescription.Text);
                FormMain.s_Logger.WriteToLogger(albumCreatedMessage);
                MessageBox.Show(doneMessage);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            this.Close();
        }
    }
}
