using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace DP._302856026322057712
{
    public class Informer
    {
        // fields
        public FormInformer m_form { get; set; }

        // constructor 
        public Informer()
        {
            PostDelayedStatusLogic DelayedStatusLogic = PostDelayedStatusLogic.Instance;
            DelayedStatusLogic.Attach(new ReportDelayedStatusWasPosted(this.Notify));
        }

        public void Notify(string i_StatusToShow)
        {
            m_form = new FormInformer();
            m_form.UpdateText(i_StatusToShow);
            m_form.ShowDialog();
        }
    }
}
