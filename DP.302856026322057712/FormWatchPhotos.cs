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
    public partial class FormWatchPhotos : Form
    {
        // members
        private User m_User;
        private List<Album> m_UserAlbums;

        // constructor
        public FormWatchPhotos(User i_User)
        {
            m_User = i_User;
            m_UserAlbums = i_User.Albums.ToList();
            InitializeComponent();
            this.buttonComment.Enabled = false;
            this.buttonLike.Enabled = false;

            // show all the albums by default
            listBoxAlbums.DisplayMember = "Name";

            // Two-way data binding
            albumBindingSource.DataSource = m_User.Albums;
        }

        // show all the photos of the select album
        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                
                this.listBoxPhotos.Items.Clear();
                listBoxPhotos.DisplayMember = "Name";
                foreach (Photo photo in selectedAlbum.Photos)
                {
                    listBoxPhotos.Items.Add(photo);
                }
            }
        }

        // show the photo when select it's name
        private void listBoxPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Photo selectedPhoto = listBoxPhotos.SelectedItem as Photo;
            pictureBox1.LoadAsync(selectedPhoto.PictureNormalURL);
            this.buttonLike.Enabled = true;
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            postCommentToPhoto();
        }

        private void postCommentToPhoto()
        {
            if (!(textBoxComment.Text == null) && !(textBoxComment.Text == string.Empty))
            {
                Photo selectedPhoto = listBoxPhotos.SelectedItem as Photo;
                selectedPhoto.Comment(textBoxComment.Text);
                textBoxComment.Text = string.Empty;
            }
        }

        // do when there is typing in the comment's text box
        private void textBoxComment_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxComment.Text == null) || (textBoxComment.Text == string.Empty))
            {
                this.buttonComment.Enabled = false;
            }
            else
            {
                this.buttonComment.Enabled = true;
            }
        }

        private void buttonLike_Click(object sender, EventArgs e)
        {
            giveLikeToPhoto();
        }

        private void giveLikeToPhoto()
        {
            Photo selectedPhoto = listBoxPhotos.SelectedItem as Photo;
            if (!selectedPhoto.LikedBy.Contains(m_User))
            {
                selectedPhoto.Like();
            }
            else
            {
                MessageBox.Show("You already liked this photo");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}