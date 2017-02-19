using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DP._302856026322057712
{
    public partial class FormInformer : Form
    {
        public FormInformer()
        {
            InitializeComponent();
        }

        public void UpdateText(string i_StatusToShow)
        {
            this.labelStatus.Text = i_StatusToShow;
        }

        private void buttonThankYou_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
