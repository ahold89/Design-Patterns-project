using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace DP._302856026322057712
{
    public partial class FormMain : Form
    {
        // members
        public static User s_User { get; set; }

        public static Logger s_Logger { get; set; }

        public ILoadPicture m_LoadPicture { get; set; }

        // constructor
        public FormMain()
        {
            bool v_Visible = true;
            InitializeComponent();

            // hide all the buttons till login
            this.loginButton.Visible = v_Visible;
            this.buttonHoroscope.Visible = !v_Visible;
            this.buttonWatchPhotos.Visible = !v_Visible;
            this.textBoxStatus.Visible = !v_Visible;
            this.buttonUploadPhoto.Visible = !v_Visible;
            this.dateTimePicker.Visible = !v_Visible;
            this.buttonFriends.Visible = !v_Visible;
            this.listBoxFriends.Visible = !v_Visible;
            this.buttonPostLink.Visible = !v_Visible;
            this.textBoxLink.Visible = !v_Visible;
            this.textBoxMessageForLink.Visible = !v_Visible;
            this.labelMind.Visible = !v_Visible;
            this.labelLink.Visible = !v_Visible;
            this.labelAddMessageToLink.Visible = !v_Visible;
            this.labelDelayedPostInstructions.Visible = !v_Visible;
            this.listBoxEvents.Visible = !v_Visible;
            this.buttonAttending.Visible = !v_Visible;
            this.buttonDeclined.Visible = !v_Visible;
            this.buttonMaybe.Visible = !v_Visible;
            this.buttonNotReplied.Visible = !v_Visible;
            this.buttonPost.Visible = !v_Visible;
            this.checkBoxOwnerPicture.Visible = !v_Visible;
            this.buttonGetTheDocumentLogger.Visible = !v_Visible;

            s_Logger = new Logger();

            FacebookWrapper.FacebookService.s_CollectionLimit = 1000;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool v_Visible = true;
            bool v_Enable = true;
            LoginResult result = FacebookService.Login("1003530996377302", "user_about_me", "user_friends", "publish_actions", "user_events", "user_posts", "user_photos", "user_status", "user_birthday");

            string loggedInMessage = string.Format("{0}: LoggedIn", DateTime.Now.ToString());

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                // initialize members
                s_User = result.LoggedInUser;
                
                string welcomeMessage = string.Format("Welcome {0}!", s_User.Name);
                MessageBox.Show(welcomeMessage);

                s_Logger.WriteToLogger(loggedInMessage);

                m_LoadPicture = new LoadEventPicture();

                // will inform the user when a delayed status is post
                Informer informer = new Informer();

                // load profile picture
                this.pictureBoxProfile.LoadAsync(s_User.PictureNormalURL);

                // after login- make all the buttons visible
                this.loginButton.Visible = !v_Visible;
                this.buttonHoroscope.Visible = v_Visible;
                this.textBoxStatus.Visible = v_Visible;
                this.buttonUploadPhoto.Visible = v_Visible;
                this.buttonWatchPhotos.Visible = v_Visible;
                this.buttonPost.Visible = v_Visible;
                this.buttonPost.Enabled = !v_Enable;
                this.dateTimePicker.Visible = v_Visible;
                this.buttonFriends.Visible = v_Visible;
                this.listBoxFriends.Visible = v_Visible;
                this.buttonPostLink.Visible = v_Visible;
                this.buttonPostLink.Enabled = !v_Enable;
                this.textBoxLink.Visible = v_Visible;
                this.textBoxMessageForLink.Visible = v_Visible;
                this.labelMind.Visible = v_Visible;
                this.labelLink.Visible = v_Visible;
                this.labelAddMessageToLink.Visible = v_Visible;
                this.labelDelayedPostInstructions.Visible = v_Visible;
                this.listBoxEvents.Visible = v_Visible;
                this.buttonAttending.Visible = v_Visible;
                this.buttonDeclined.Visible = v_Visible;
                this.buttonMaybe.Visible = v_Visible;
                this.buttonNotReplied.Visible = v_Visible;
                this.checkBoxOwnerPicture.Visible = v_Visible;
                this.buttonGetTheDocumentLogger.Visible = v_Visible;
                this.dateTimePicker.MinDate = DateTime.Now;
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(createStatusAndPost));
            t.IsBackground = true;
            t.Start();
        }

        private void emptyText(TextBox i_TextBox)
        {
            i_TextBox.Text = string.Empty;
        }

        private void createStatusAndPost()
        {
            string tryAgainMessage = "please try again";
            string problemMessage = string.Empty;
            
            StatusFromUser status = StatusFactory.Create(this.textBoxStatus.Text, this.dateTimePicker.Value);

            this.Invoke(new Action(() => emptyText(this.textBoxStatus)));
            try
            {
                status.WriteToLogAndPost();
            }
            catch (Exception e)
            {
                problemMessage = string.Format("{0}{1}{2}", e.Message, Environment.NewLine, tryAgainMessage);
                MessageBox.Show(problemMessage);
            }
        }

        private void buttonUploadPhoto_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(buttonUploadHelper));
            t.SetApartmentState(ApartmentState.STA);
            t.IsBackground = true;
            t.Start();
        }

        private void buttonUploadHelper()
        {
            FormUploadPhoto UploadPhotoForm = new FormUploadPhoto(s_User);
            UploadPhotoForm.ShowDialog();
        }

        private void buttonWatchPhotos_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(buttonWatchHelper));
            t.IsBackground = true;
            t.Start();
        }

        private void buttonWatchHelper()
        {
            FormWatchPhotos WatchPhotosForm = new FormWatchPhotos(s_User);
            WatchPhotosForm.ShowDialog();
        } 

        private void buttonHoroscope_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(buttonHoroscopeHelper));
            t.IsBackground = true;
            t.Start();
        }

        private void buttonHoroscopeHelper()
        {
            FormHoroscope horoscope = new FormHoroscope();
            horoscope.WriteHoroscopeToTextBox();
            horoscope.ShowDialog();
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => addToListBox(s_User.Friends.ToList(), listBoxFriends));
            t.IsBackground = true;
            t.Start();
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSelectedIndexChanged(listBoxFriends, pictureBoxFriends, listBoxFriends.SelectedItem);
        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {
            textBoxChanged(textBoxStatus, buttonPost);
        }

        private void buttonPostLink_Click(object sender, EventArgs e)
        {
            // created to work with thread with more ease
            string link = this.textBoxLink.Text;
            string textAboutLink = this.textBoxMessageForLink.Text;
            Thread t = new Thread(() => postLink(link, textAboutLink));
            t.IsBackground = true;
            t.Start();
            emptyText(this.textBoxLink);
            emptyText(this.textBoxMessageForLink);
        }

        private void postLink(string i_Link, string i_AboutLink)
        {
            string successfulMessage = "Posted successfully";
            string postLinkMessage = string.Format("{0}: Post link", DateTime.Now.ToString());

            try
            {
                s_User.PostLink(i_Link, i_AboutLink);
                s_Logger.WriteToLogger(postLinkMessage);
                MessageBox.Show(successfulMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxLink_TextChanged(object sender, EventArgs e)
        {
            textBoxChanged(textBoxLink, buttonPostLink);
        }

        private void buttonAccepted_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => addToListBox(s_User.Events.ToList(), listBoxEvents));
            t.IsBackground = true;
            t.Start();
        }

        private void buttonMaybe_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => addToListBox(s_User.EventsMaybe.ToList(), listBoxEvents));
            t.IsBackground = true;
            t.Start();
        }

        private void buttonDeclined_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => addToListBox(s_User.EventsDeclined.ToList(), listBoxEvents));
            t.IsBackground = true;
            t.Start();
        }

        private void buttonNotReplied_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => addToListBox(s_User.EventsNotYetReplied.ToList(), listBoxEvents));
            t.IsBackground = true;
            t.Start();
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSelectedIndexChanged(listBoxEvents, pictureBoxEvent, listBoxEvents.SelectedItem);
        }

        // gets list of objects and a list box, and show the object's names in the requested list box
        private void addToListBox<T>(List<T> i_ListToShow, ListBox i_ListBoxToFill)
        {
            string nothingToShowMessage = "Nothing to show";            
            i_ListBoxToFill.Invoke(new Action(() => i_ListBoxToFill.Items.Clear()));
            i_ListBoxToFill.DisplayMember = "Name";

            if (i_ListToShow.Capacity > 0)
            {
                foreach (T item in i_ListToShow)
                {
                    i_ListBoxToFill.Invoke(new Action(() => i_ListBoxToFill.Items.Add(item)));
                }
            }
            else
            {
                i_ListBoxToFill.Invoke(new Action(() => i_ListBoxToFill.Items.Add(nothingToShowMessage)));
            }
        }

        // control the enable of the requsted buttons according to typing. the method can get one or more buttons 
        private void textBoxChanged(TextBox i_TextBox, params Button[] i_Buttons)
        {
            if (i_TextBox.Text != string.Empty && i_TextBox.Text != null)
            {
                foreach (Button button in i_Buttons)
                {
                    button.Enabled = true;
                }
            }
            else
            {
                foreach (Button button in i_Buttons)
                {
                    button.Enabled = false;
                }
            }
        }

        // show the image in the requsted picture box, according to the selects of the user in the list boxes
        private void listBoxSelectedIndexChanged<T>(ListBox i_ListBox, PictureBox i_PictureBox, T i_SelctedItem)
        {
            User friend = new User();
            Event Event = new Event();
            
            if (i_ListBox.SelectedItems.Count == 1)
            {
                if (i_SelctedItem is User)
                {
                    friend = i_SelctedItem as User;

                    if (friend != null)
                    {
                        i_PictureBox.LoadAsync(friend.PictureNormalURL);
                    }
                }

                if (i_SelctedItem is Event)
                {
                    Event = i_SelctedItem as Event;

                    m_LoadPicture.LoadPicture(Event, i_PictureBox);
                }
            }
        }

        private void checkBoxOwnerPicture_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxOwnerPicture.Checked == true)
            {
                m_LoadPicture = new LoadEventOwnerPicture();
            }
            else
            {
                m_LoadPicture = new LoadEventPicture();
            }
        }

        // the method responsible to ask the user is he sure he want to go out when there are delayed status to post
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            string areYouLeavingMessage = "Delayed status will not be posted, are you sure you want to close the app?";
            string loggedOutMessage = string.Format("{0}: LoggedOut", DateTime.Now.ToString());

            if (PostDelayedStatusLogic.s_DelayedPosts.Count != 0 && loginButton.Visible == false)
            {
                // determine the button that will be show are 'yes' and 'no' buttons
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // show the form
                result = MessageBox.Show(areYouLeavingMessage, string.Empty, buttons);

                // if the button that has been clicked is 'No'
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    this.DialogResult = DialogResult.Cancel;
                }
                else
                {
                    // if the button that has been clicked is 'Yes'
                    this.DialogResult = DialogResult.OK;
                    s_Logger.WriteToLogger(loggedOutMessage);
                    Environment.Exit(0);
                }
            }
            else
            {
                if (!(s_User == null))
                {
                    s_Logger.WriteToLogger(loggedOutMessage);
                }

                base.OnFormClosing(e);
            }
        }

        private void buttonGetTheDocumentLogger_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\LoggerResults.txt");
        }
    }
}
