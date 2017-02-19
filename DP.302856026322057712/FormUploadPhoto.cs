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
    public partial class FormUploadPhoto : Form
    {
        // members
        private User m_User { get; set; }

        private List<Album> m_UserAlbums { get; set; }
        
        private Album m_ChoosenAlbum { get; set; }
        
        private string m_PhotoPath { get; set; }

        // constructor
        public FormUploadPhoto(User i_User)
        {
            m_User = i_User;
            m_UserAlbums = i_User.Albums.ToList();
            InitializeComponent();
            progressBar1.Visible = false;
        }

        private void buttonChooseAlbums_Click(object sender, EventArgs e)
        {
            showAllAlbums();
        }

        private void showAllAlbums()
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";
            foreach (Album album in m_UserAlbums)
            {
                listBoxAlbums.Items.Add(album);
            }
        }

        // change the final album we want to upload photo to, according to the selects of the user
        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                m_ChoosenAlbum = listBoxAlbums.SelectedItem as Album;
            }
        }

        private void buttonChoosePhoto_Click(object sender, EventArgs e)
        {
            getPhotoPath();
        }

        private void getPhotoPath() 
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                m_PhotoPath = fileDialog.FileName;
            }
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            bool v_Visible = true;
            bool v_Enable = true;

            // when uploading photo- make all the buttons enbaled false
            progressBar1.Visible = v_Visible;
            buttonChoosePhoto.Enabled = !v_Enable;
            buttonChooseAlbums.Enabled = !v_Enable;
            buttonUpload.Enabled = !v_Enable;
            buttonCreateAlbum.Enabled = !v_Enable;
            listBoxAlbums.Enabled = !v_Enable;
            textBoxDescription.Enabled = !v_Enable;

            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string postPhotoMessage = string.Format("{0}: Post photo", DateTime.Now.ToString());

            try
            {
                m_ChoosenAlbum.UploadPhoto(m_PhotoPath, textBoxDescription.Text);
                FormMain.s_Logger.WriteToLogger(postPhotoMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bool v_Visible = true;
            bool v_Enable = true;

            // after the upload has finished- make all the buttons enabled true
            progressBar1.Visible = !v_Visible;
            buttonChoosePhoto.Enabled = v_Enable;
            buttonChooseAlbums.Enabled = v_Enable;
            buttonUpload.Enabled = v_Enable;
            buttonCreateAlbum.Enabled = v_Enable;
            listBoxAlbums.Enabled = v_Enable;
            textBoxDescription.Enabled = v_Enable;
        
            // restart the text box
            textBoxDescription.Text = string.Empty;

            // restart the path member
            m_PhotoPath = string.Empty;
        }

        private void buttonCreateAlbum_Click(object sender, EventArgs e)
        {
            FormCreateAlbum CreateAlbumForm = new FormCreateAlbum(m_User);
            CreateAlbumForm.ShowDialog();

            // restart the albums list to see the new album if was created
            m_UserAlbums = m_User.Albums.ToList();

            this.listBoxAlbums.Items.Clear();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
