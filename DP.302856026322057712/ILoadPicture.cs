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
    public interface ILoadPicture
    {
        void LoadPicture(Event i_Event, PictureBox i_PictureBox);
    }
}
