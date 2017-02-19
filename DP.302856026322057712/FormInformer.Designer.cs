namespace DP._302856026322057712
{
    public partial class FormInformer
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
            this.buttonThankYou = new System.Windows.Forms.Button();
            this.labelYourStatus = new System.Windows.Forms.Label();
            this.labelHasJustBeenPosted = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonThankYou
            // 
            this.buttonThankYou.Location = new System.Drawing.Point(140, 227);
            this.buttonThankYou.Name = "buttonThankYou";
            this.buttonThankYou.Size = new System.Drawing.Size(75, 23);
            this.buttonThankYou.TabIndex = 0;
            this.buttonThankYou.Text = "Thank You!";
            this.buttonThankYou.UseVisualStyleBackColor = true;
            this.buttonThankYou.Click += new System.EventHandler(this.buttonThankYou_Click);
            // 
            // labelYourStatus
            // 
            this.labelYourStatus.AutoSize = true;
            this.labelYourStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelYourStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYourStatus.Location = new System.Drawing.Point(12, 30);
            this.labelYourStatus.Name = "labelYourStatus";
            this.labelYourStatus.Size = new System.Drawing.Size(124, 26);
            this.labelYourStatus.TabIndex = 1;
            this.labelYourStatus.Text = "Your Status:";
            // 
            // labelHasJustBeenPosted
            // 
            this.labelHasJustBeenPosted.AutoSize = true;
            this.labelHasJustBeenPosted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHasJustBeenPosted.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasJustBeenPosted.Location = new System.Drawing.Point(133, 158);
            this.labelHasJustBeenPosted.Name = "labelHasJustBeenPosted";
            this.labelHasJustBeenPosted.Size = new System.Drawing.Size(222, 26);
            this.labelHasJustBeenPosted.TabIndex = 2;
            this.labelHasJustBeenPosted.Text = "Has Just Been Posted!";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelStatus.Location = new System.Drawing.Point(31, 106);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(45, 16);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "label1";
            // 
            // FormInformer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 262);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelHasJustBeenPosted);
            this.Controls.Add(this.labelYourStatus);
            this.Controls.Add(this.buttonThankYou);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormInformer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInformer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThankYou;
        private System.Windows.Forms.Label labelYourStatus;
        private System.Windows.Forms.Label labelHasJustBeenPosted;
        private System.Windows.Forms.Label labelStatus;
    }
}