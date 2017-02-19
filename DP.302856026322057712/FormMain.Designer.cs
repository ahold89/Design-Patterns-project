using System;

namespace DP._302856026322057712
{
    public partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.buttonHoroscope = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonUploadPhoto = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonWatchPhotos = new System.Windows.Forms.Button();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.pictureBoxFriends = new System.Windows.Forms.PictureBox();
            this.labelMind = new System.Windows.Forms.Label();
            this.buttonPostLink = new System.Windows.Forms.Button();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.labelLink = new System.Windows.Forms.Label();
            this.textBoxMessageForLink = new System.Windows.Forms.TextBox();
            this.labelAddMessageToLink = new System.Windows.Forms.Label();
            this.labelDelayedPostInstructions = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.buttonDeclined = new System.Windows.Forms.Button();
            this.buttonMaybe = new System.Windows.Forms.Button();
            this.buttonAttending = new System.Windows.Forms.Button();
            this.buttonNotReplied = new System.Windows.Forms.Button();
            this.buttonPost = new System.Windows.Forms.Button();
            this.checkBoxOwnerPicture = new System.Windows.Forms.CheckBox();
            this.buttonGetTheDocumentLogger = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(427, 280);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(144, 55);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // buttonHoroscope
            // 
            this.buttonHoroscope.Location = new System.Drawing.Point(800, 584);
            this.buttonHoroscope.Name = "buttonHoroscope";
            this.buttonHoroscope.Size = new System.Drawing.Size(140, 32);
            this.buttonHoroscope.TabIndex = 2;
            this.buttonHoroscope.Text = "Get my daily horoscope";
            this.buttonHoroscope.UseVisualStyleBackColor = true;
            this.buttonHoroscope.Click += new System.EventHandler(this.buttonHoroscope_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(417, 36);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(406, 23);
            this.textBoxStatus.TabIndex = 4;
            this.textBoxStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBoxStatus_TextChanged);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(171, 157);
            this.pictureBoxProfile.TabIndex = 6;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonUploadPhoto
            // 
            this.buttonUploadPhoto.Location = new System.Drawing.Point(800, 374);
            this.buttonUploadPhoto.Name = "buttonUploadPhoto";
            this.buttonUploadPhoto.Size = new System.Drawing.Size(139, 32);
            this.buttonUploadPhoto.TabIndex = 10;
            this.buttonUploadPhoto.Text = "Upload Photo";
            this.buttonUploadPhoto.UseVisualStyleBackColor = true;
            this.buttonUploadPhoto.Click += new System.EventHandler(this.buttonUploadPhoto_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd MMMM yyyy HH:mm";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(657, 68);
            this.dateTimePicker.MinDate = new System.DateTime(2015, 12, 27, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(167, 20);
            this.dateTimePicker.TabIndex = 13;
            // 
            // buttonWatchPhotos
            // 
            this.buttonWatchPhotos.Location = new System.Drawing.Point(800, 338);
            this.buttonWatchPhotos.Name = "buttonWatchPhotos";
            this.buttonWatchPhotos.Size = new System.Drawing.Size(139, 30);
            this.buttonWatchPhotos.TabIndex = 15;
            this.buttonWatchPhotos.Text = "Watch photos";
            this.buttonWatchPhotos.UseVisualStyleBackColor = true;
            this.buttonWatchPhotos.Click += new System.EventHandler(this.buttonWatchPhotos_Click);
            // 
            // buttonFriends
            // 
            this.buttonFriends.Location = new System.Drawing.Point(13, 181);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(75, 23);
            this.buttonFriends.TabIndex = 16;
            this.buttonFriends.Text = "Friends";
            this.buttonFriends.UseVisualStyleBackColor = true;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(13, 210);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(120, 459);
            this.listBoxFriends.TabIndex = 17;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // pictureBoxFriends
            // 
            this.pictureBoxFriends.Location = new System.Drawing.Point(139, 210);
            this.pictureBoxFriends.Name = "pictureBoxFriends";
            this.pictureBoxFriends.Size = new System.Drawing.Size(118, 118);
            this.pictureBoxFriends.TabIndex = 18;
            this.pictureBoxFriends.TabStop = false;
            // 
            // labelMind
            // 
            this.labelMind.AutoSize = true;
            this.labelMind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMind.Location = new System.Drawing.Point(250, 36);
            this.labelMind.Name = "labelMind";
            this.labelMind.Size = new System.Drawing.Size(161, 20);
            this.labelMind.TabIndex = 19;
            this.labelMind.Text = "What\'s on your mind?";
            // 
            // buttonPostLink
            // 
            this.buttonPostLink.Location = new System.Drawing.Point(830, 146);
            this.buttonPostLink.Name = "buttonPostLink";
            this.buttonPostLink.Size = new System.Drawing.Size(110, 23);
            this.buttonPostLink.TabIndex = 21;
            this.buttonPostLink.Text = "Post link";
            this.buttonPostLink.UseVisualStyleBackColor = true;
            this.buttonPostLink.Click += new System.EventHandler(this.buttonPostLink_Click);
            // 
            // textBoxLink
            // 
            this.textBoxLink.Location = new System.Drawing.Point(418, 149);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(406, 20);
            this.textBoxLink.TabIndex = 22;
            this.textBoxLink.TextChanged += new System.EventHandler(this.textBoxLink_TextChanged);
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLink.Location = new System.Drawing.Point(285, 149);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(127, 20);
            this.labelLink.TabIndex = 23;
            this.labelLink.Text = "Type link to post:";
            // 
            // textBoxMessageForLink
            // 
            this.textBoxMessageForLink.Location = new System.Drawing.Point(647, 178);
            this.textBoxMessageForLink.Multiline = true;
            this.textBoxMessageForLink.Name = "textBoxMessageForLink";
            this.textBoxMessageForLink.Size = new System.Drawing.Size(177, 89);
            this.textBoxMessageForLink.TabIndex = 25;
            // 
            // labelAddMessageToLink
            // 
            this.labelAddMessageToLink.AutoSize = true;
            this.labelAddMessageToLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddMessageToLink.Location = new System.Drawing.Point(458, 213);
            this.labelAddMessageToLink.Name = "labelAddMessageToLink";
            this.labelAddMessageToLink.Size = new System.Drawing.Size(183, 20);
            this.labelAddMessageToLink.TabIndex = 26;
            this.labelAddMessageToLink.Text = "Add message to the link:";
            // 
            // labelDelayedPostInstructions
            // 
            this.labelDelayedPostInstructions.AutoSize = true;
            this.labelDelayedPostInstructions.Location = new System.Drawing.Point(305, 70);
            this.labelDelayedPostInstructions.Name = "labelDelayedPostInstructions";
            this.labelDelayedPostInstructions.Size = new System.Drawing.Size(346, 13);
            this.labelDelayedPostInstructions.TabIndex = 27;
            this.labelDelayedPostInstructions.Text = "Choose a date and time for statuses you would like to post in the future :";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(358, 341);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(406, 329);
            this.listBoxEvents.TabIndex = 28;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.Location = new System.Drawing.Point(198, 498);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(133, 118);
            this.pictureBoxEvent.TabIndex = 34;
            this.pictureBoxEvent.TabStop = false;
            // 
            // buttonDeclined
            // 
            this.buttonDeclined.Location = new System.Drawing.Point(198, 432);
            this.buttonDeclined.Name = "buttonDeclined";
            this.buttonDeclined.Size = new System.Drawing.Size(133, 22);
            this.buttonDeclined.TabIndex = 32;
            this.buttonDeclined.Text = "Declined";
            this.buttonDeclined.UseVisualStyleBackColor = true;
            this.buttonDeclined.Click += new System.EventHandler(this.buttonDeclined_Click);
            // 
            // buttonMaybe
            // 
            this.buttonMaybe.Location = new System.Drawing.Point(198, 403);
            this.buttonMaybe.Name = "buttonMaybe";
            this.buttonMaybe.Size = new System.Drawing.Size(133, 22);
            this.buttonMaybe.TabIndex = 31;
            this.buttonMaybe.Text = "Maybe";
            this.buttonMaybe.UseVisualStyleBackColor = true;
            this.buttonMaybe.Click += new System.EventHandler(this.buttonMaybe_Click);
            // 
            // buttonAttending
            // 
            this.buttonAttending.Location = new System.Drawing.Point(198, 374);
            this.buttonAttending.Name = "buttonAttending";
            this.buttonAttending.Size = new System.Drawing.Size(133, 22);
            this.buttonAttending.TabIndex = 30;
            this.buttonAttending.Text = "Attending";
            this.buttonAttending.UseVisualStyleBackColor = true;
            this.buttonAttending.Click += new System.EventHandler(this.buttonAccepted_Click);
            // 
            // buttonNotReplied
            // 
            this.buttonNotReplied.Location = new System.Drawing.Point(199, 460);
            this.buttonNotReplied.Name = "buttonNotReplied";
            this.buttonNotReplied.Size = new System.Drawing.Size(133, 22);
            this.buttonNotReplied.TabIndex = 35;
            this.buttonNotReplied.Text = "Not Replied";
            this.buttonNotReplied.UseVisualStyleBackColor = true;
            this.buttonNotReplied.Click += new System.EventHandler(this.buttonNotReplied_Click);
            // 
            // buttonPost
            // 
            this.buttonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPost.Location = new System.Drawing.Point(830, 36);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(109, 52);
            this.buttonPost.TabIndex = 36;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // checkBoxOwnerPicture
            // 
            this.checkBoxOwnerPicture.AutoSize = true;
            this.checkBoxOwnerPicture.Location = new System.Drawing.Point(199, 347);
            this.checkBoxOwnerPicture.Name = "checkBoxOwnerPicture";
            this.checkBoxOwnerPicture.Size = new System.Drawing.Size(157, 17);
            this.checkBoxOwnerPicture.TabIndex = 37;
            this.checkBoxOwnerPicture.Text = "Show event owner\'s picture";
            this.checkBoxOwnerPicture.UseVisualStyleBackColor = true;
            this.checkBoxOwnerPicture.CheckedChanged += new System.EventHandler(this.checkBoxOwnerPicture_CheckedChanged);
            // 
            // buttonGetTheDocumentLogger
            // 
            this.buttonGetTheDocumentLogger.Location = new System.Drawing.Point(800, 622);
            this.buttonGetTheDocumentLogger.Name = "buttonGetTheDocumentLogger";
            this.buttonGetTheDocumentLogger.Size = new System.Drawing.Size(140, 33);
            this.buttonGetTheDocumentLogger.TabIndex = 38;
            this.buttonGetTheDocumentLogger.Text = "Get the document logger";
            this.buttonGetTheDocumentLogger.UseVisualStyleBackColor = true;
            this.buttonGetTheDocumentLogger.Click += new System.EventHandler(this.buttonGetTheDocumentLogger_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(951, 679);
            this.Controls.Add(this.buttonGetTheDocumentLogger);
            this.Controls.Add(this.checkBoxOwnerPicture);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.buttonNotReplied);
            this.Controls.Add(this.pictureBoxEvent);
            this.Controls.Add(this.buttonDeclined);
            this.Controls.Add(this.buttonMaybe);
            this.Controls.Add(this.buttonAttending);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.labelDelayedPostInstructions);
            this.Controls.Add(this.labelAddMessageToLink);
            this.Controls.Add(this.textBoxMessageForLink);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.buttonPostLink);
            this.Controls.Add(this.labelMind);
            this.Controls.Add(this.pictureBoxFriends);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.buttonFriends);
            this.Controls.Add(this.buttonWatchPhotos);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonUploadPhoto);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonHoroscope);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button buttonHoroscope;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonUploadPhoto;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonWatchPhotos;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.PictureBox pictureBoxFriends;
        private System.Windows.Forms.Label labelMind;
        private System.Windows.Forms.Button buttonPostLink;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.TextBox textBoxMessageForLink;
        private System.Windows.Forms.Label labelAddMessageToLink;
        private System.Windows.Forms.Label labelDelayedPostInstructions;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.Button buttonDeclined;
        private System.Windows.Forms.Button buttonMaybe;
        private System.Windows.Forms.Button buttonAttending;
        private System.Windows.Forms.Button buttonNotReplied;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.CheckBox checkBoxOwnerPicture;
        private System.Windows.Forms.Button buttonGetTheDocumentLogger;
    }
}