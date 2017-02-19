using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace DP._302856026322057712
{
    public class LoadEventPicture : ILoadPicture
    {
        public void LoadPicture(Event i_Event, PictureBox i_PictureBox)
        {
            if (i_Event != null)
            {
                i_PictureBox.LoadAsync(i_Event.PictureNormalURL);
            }
        }
    }
}
