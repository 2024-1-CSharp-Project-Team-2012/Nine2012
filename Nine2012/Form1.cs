using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nine2012
{
    public partial class Form1 : Form
    {
        int greenCount = 9;
        int pinkCount = 9;

        bool greenTurn = true;

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);
        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;      // The left button is down.
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private Point startPoint;

        enum tagType { Blank = 0, Green = 1, Pink = 2 };

        public Form1()
        {
            InitializeComponent();
        }

        // pictureBoxGreen 
        private void pictureBoxGreen1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxGreen1.Image = null;
        }

        private void pictureBoxGreen2_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxGreen2.Image = null;
        }

        private void pictureBoxGreen3_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxGreen3.Image = null;
        }

        private void pictureBoxGreen4_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxGreen4.Image = null;
        }

        private void pictureBoxGreen5_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxGreen5.Image = null;
        }

        private void pictureBoxGreen6_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxGreen6.Image = null;
        }

        private void pictureBoxGreen7_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxGreen7.Image = null;
        }

        private void pictureBoxGreen8_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxGreen8.Image = null;
        }

        private void pictureBoxGreen9_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxGreen9.Image = null;
        }

        // pictureBoxPink 
        private void pictureBoxPink1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxPink1.Image = null;
        }

        private void pictureBoxPink2_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxPink2.Image = null;
        }
        private void pictureBoxPink3_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxPink3.Image = null;
        }
        private void pictureBoxPink4_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxPink4.Image = null;
        }
        private void pictureBoxPink5_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxPink5.Image = null;
        }
        private void pictureBoxPink6_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxPink6.Image = null;
        }
        private void pictureBoxPink7_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxPink7.Image = null;
        }
        private void pictureBoxPink8_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxPink8.Image = null;
        }
        private void pictureBoxPink9_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxPink9.Image = null;
        }

        // pictureBoxBlank00
        private void pictureBoxBlank00_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pictureBoxGreen1.Image == null || pictureBoxGreen2.Image == null || pictureBoxGreen3.Image == null || pictureBoxGreen4.Image == null
                 || pictureBoxGreen5.Image == null || pictureBoxGreen6.Image == null || pictureBoxGreen7.Image == null || pictureBoxGreen8.Image == null || pictureBoxGreen9.Image == null)
            {
                pictureBoxBlank00.Tag = tagType.Green;
                pictureBoxBlank00.Image = Properties.Resources.Green;
            }

            if (pictureBoxPink1.Image == null || pictureBoxPink2.Image == null || pictureBoxPink3.Image == null || pictureBoxPink4.Image == null
                || pictureBoxPink5.Image == null || pictureBoxPink6.Image == null || pictureBoxPink7.Image == null || pictureBoxPink8.Image == null || pictureBoxPink9.Image == null)
            {
                pictureBoxBlank00.Tag = tagType.Pink;
                pictureBoxBlank00.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank01 -> pictureBoxBlank00
            else if (pictureBoxBlank01.Image == null  || (int)pictureBoxBlank01.Tag == 1)
            {
                pictureBoxBlank01.Tag = tagType.Blank;
                pictureBoxBlank00.Tag = tagType.Green;
                pictureBoxBlank00.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank01.Image == null || (int)pictureBoxBlank01.Tag == 2)
            {
                pictureBoxBlank01.Tag = tagType.Blank;
                pictureBoxBlank00.Tag = tagType.Pink;
                pictureBoxBlank00.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank07 -> pictureBoxBlank00
            else if (pictureBoxBlank07.Image == null || (int)pictureBoxBlank07.Tag == 1)
            {
                pictureBoxBlank07.Tag = tagType.Blank;
                pictureBoxBlank00.Tag = tagType.Green;
                pictureBoxBlank00.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank07.Image == null || (int)pictureBoxBlank07.Tag == 2)
            {
                pictureBoxBlank07.Tag = tagType.Blank;
                pictureBoxBlank00.Tag = tagType.Pink;
                pictureBoxBlank00.Image = Properties.Resources.Pink;
            }
        }

        private void pictureBoxBlank00_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank00.Image = null;
        }

        // pictureBoxBlank01
        private void pictureBoxBlank01_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pictureBoxGreen1.Image == null || pictureBoxGreen2.Image == null || pictureBoxGreen3.Image == null || pictureBoxGreen4.Image == null
                 || pictureBoxGreen5.Image == null || pictureBoxGreen6.Image == null || pictureBoxGreen7.Image == null || pictureBoxGreen8.Image == null || pictureBoxGreen9.Image == null)
            {
                pictureBoxBlank01.Tag = tagType.Green;
                pictureBoxBlank01.Image = Properties.Resources.Green;
            }

            if (pictureBoxPink1.Image == null || pictureBoxPink2.Image == null || pictureBoxPink3.Image == null || pictureBoxPink4.Image == null
                || pictureBoxPink5.Image == null || pictureBoxPink6.Image == null || pictureBoxPink7.Image == null || pictureBoxPink8.Image == null || pictureBoxPink9.Image == null)
            {
                pictureBoxBlank01.Tag = tagType.Pink;
                pictureBoxBlank01.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank00 -> pictureBoxBlank01
            else if (pictureBoxBlank00.Image == null || (int)pictureBoxBlank00.Tag == 1)
            {
                pictureBoxBlank00.Tag = tagType.Blank;
                pictureBoxBlank01.Tag = tagType.Green;
                pictureBoxBlank01.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank00.Image == null || (int)pictureBoxBlank00.Tag == 2)
            {
                pictureBoxBlank00.Tag = tagType.Blank;
                pictureBoxBlank01.Tag = tagType.Pink;
                pictureBoxBlank01.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank02 -> pictureBoxBlank01
            else if (pictureBoxBlank02.Image == null || (int)pictureBoxBlank02.Tag == 1)
            {
                pictureBoxBlank02.Tag = tagType.Blank;
                pictureBoxBlank01.Tag = tagType.Green;
                pictureBoxBlank01.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank02.Image == null || (int)pictureBoxBlank02.Tag == 2)
            {
                pictureBoxBlank02.Tag = tagType.Blank;
                pictureBoxBlank01.Tag = tagType.Pink;
                pictureBoxBlank01.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank11 -> pictureBoxBlank01
            else if (pictureBoxBlank11.Image == null || (int)pictureBoxBlank11.Tag == 1)
            { 
                pictureBoxBlank11.Tag = tagType.Blank;
                pictureBoxBlank01.Tag = tagType.Green;
                pictureBoxBlank01.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank11.Image == null || (int)pictureBoxBlank11.Tag == 2)
            {
                pictureBoxBlank11.Tag = tagType.Blank;
                pictureBoxBlank01.Tag = tagType.Pink;
                pictureBoxBlank01.Image = Properties.Resources.Pink;
            }
        }

        private void pictureBoxBlank01_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank01.Image = null;
        }

        // pictureBoxBlank02
        private void pictureBoxBlank02_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pictureBoxGreen1.Image == null || pictureBoxGreen2.Image == null || pictureBoxGreen3.Image == null || pictureBoxGreen4.Image == null
                || pictureBoxGreen5.Image == null || pictureBoxGreen6.Image == null || pictureBoxGreen7.Image == null || pictureBoxGreen8.Image == null || pictureBoxGreen9.Image == null)
            {
                pictureBoxBlank02.Tag = tagType.Green;
                pictureBoxBlank02.Image = Properties.Resources.Green;
            }

            if (pictureBoxPink1.Image == null || pictureBoxPink2.Image == null || pictureBoxPink3.Image == null || pictureBoxPink4.Image == null
                || pictureBoxPink5.Image == null || pictureBoxPink6.Image == null || pictureBoxPink7.Image == null || pictureBoxPink8.Image == null || pictureBoxPink9.Image == null)
            {
                pictureBoxBlank02.Tag = tagType.Pink;
                pictureBoxBlank02.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank01 -> pictureBoxBlank02
            else if (pictureBoxBlank01.Image == null || (int)pictureBoxBlank01.Tag == 1)
            {
                pictureBoxBlank01.Tag = tagType.Blank;
                pictureBoxBlank02.Tag = tagType.Green;
                pictureBoxBlank02.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank01.Image == null || (int)pictureBoxBlank01.Tag == 2)
            {
                pictureBoxBlank01.Tag = tagType.Blank;
                pictureBoxBlank02.Tag = tagType.Pink;
                pictureBoxBlank02.Image = Properties.Resources.Pink;
            }

            //pictureBoxBlank03 -> pictureBoxBlank02
            else if (pictureBoxBlank03.Image == null || (int)pictureBoxBlank03.Tag == 1)
            {
                pictureBoxBlank03.Tag = tagType.Blank;
                pictureBoxBlank02.Tag = tagType.Green;
                pictureBoxBlank02.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank03.Image == null || (int)pictureBoxBlank03.Tag == 2)
            {
                pictureBoxBlank03.Tag = tagType.Blank;
                pictureBoxBlank02.Tag = tagType.Pink;
                pictureBoxBlank02.Image = Properties.Resources.Pink;
            }
        }

        private void pictureBoxBlank02_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank02.Image = null;
        }

        // pictureBoxBlank03
        private void pictureBoxBlank03_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pictureBoxGreen1.Image == null || pictureBoxGreen2.Image == null || pictureBoxGreen3.Image == null || pictureBoxGreen4.Image == null
                 || pictureBoxGreen5.Image == null || pictureBoxGreen6.Image == null || pictureBoxGreen7.Image == null || pictureBoxGreen8.Image == null || pictureBoxGreen9.Image == null)
            {
                pictureBoxBlank03.Tag = tagType.Green;
                pictureBoxBlank03.Image = Properties.Resources.Green;
            }

            if (pictureBoxPink1.Image == null || pictureBoxPink2.Image == null || pictureBoxPink3.Image == null || pictureBoxPink4.Image == null
                || pictureBoxPink5.Image == null || pictureBoxPink6.Image == null || pictureBoxPink7.Image == null || pictureBoxPink8.Image == null || pictureBoxPink9.Image == null)
            {
                pictureBoxBlank03.Tag = tagType.Pink;
                pictureBoxBlank03.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank02 -> pictureBoxBlank03
            else if (pictureBoxBlank02.Image == null || (int)pictureBoxBlank02.Tag == 1)
            {
                pictureBoxBlank02.Tag = tagType.Blank;
                pictureBoxBlank03.Tag = tagType.Green;
                pictureBoxBlank03.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank02.Image == null || (int)pictureBoxBlank02.Tag == 2)
            {
                pictureBoxBlank02.Tag = tagType.Blank;
                pictureBoxBlank03.Tag = tagType.Pink;
                pictureBoxBlank03.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank04 -> pictureBoxBlank03
            else if (pictureBoxBlank04.Image == null || (int)pictureBoxBlank04.Tag == 1)
            {
                pictureBoxBlank04.Tag = tagType.Blank;
                pictureBoxBlank03.Tag = tagType.Green;
                pictureBoxBlank03.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank04.Image == null || (int)pictureBoxBlank04.Tag == 2)
            {
                pictureBoxBlank04.Tag = tagType.Blank;
                pictureBoxBlank03.Tag = tagType.Pink;
                pictureBoxBlank03.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank13 -> pictureBoxBlank03
            else if (pictureBoxBlank13.Image == null || (int)pictureBoxBlank13.Tag == 1)
            {
                pictureBoxBlank13.Tag = tagType.Blank;
                pictureBoxBlank03.Tag = tagType.Green;
                pictureBoxBlank03.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank13.Image == null || (int)pictureBoxBlank13.Tag == 2) //수정
            {
                pictureBoxBlank13.Tag = tagType.Blank;
                pictureBoxBlank03.Tag = tagType.Pink;
                pictureBoxBlank03.Image = Properties.Resources.Pink;
            }
        }

        private void pictureBoxBlank03_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank03.Image = null;
        }

        // pictureBoxBlank04
        private void pictureBoxBlank04_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pictureBoxGreen1.Image == null || pictureBoxGreen2.Image == null || pictureBoxGreen3.Image == null || pictureBoxGreen4.Image == null
                 || pictureBoxGreen5.Image == null || pictureBoxGreen6.Image == null || pictureBoxGreen7.Image == null || pictureBoxGreen8.Image == null || pictureBoxGreen9.Image == null)
            {
                pictureBoxBlank04.Tag = tagType.Green;
                pictureBoxBlank04.Image = Properties.Resources.Green;
            }

            if (pictureBoxPink1.Image == null || pictureBoxPink2.Image == null || pictureBoxPink3.Image == null || pictureBoxPink4.Image == null
                || pictureBoxPink5.Image == null || pictureBoxPink6.Image == null || pictureBoxPink7.Image == null || pictureBoxPink8.Image == null || pictureBoxPink9.Image == null)
            {
                pictureBoxBlank04.Tag = tagType.Pink;
                pictureBoxBlank04.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank03 -> pictureBoxBlank04
            else if (pictureBoxBlank03.Image == null || (int)pictureBoxBlank03.Tag == 1)
            {
                pictureBoxBlank03.Tag = tagType.Blank;
                pictureBoxBlank04.Tag = tagType.Green;
                pictureBoxBlank04.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank03.Image == null || (int)pictureBoxBlank03.Tag == 2)
            {
                pictureBoxBlank03.Tag = tagType.Blank;
                pictureBoxBlank04.Tag = tagType.Pink;
                pictureBoxBlank04.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank05 -> pictureBoxBlank04
            else if (pictureBoxBlank05.Image == null || (int)pictureBoxBlank05.Tag == 1)
            {
                pictureBoxBlank05.Tag = tagType.Blank;
                pictureBoxBlank04.Tag = tagType.Green;
                pictureBoxBlank04.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank05.Image == null || (int)pictureBoxBlank05.Tag == 2)
            {
                pictureBoxBlank05.Tag = tagType.Blank;
                pictureBoxBlank04.Tag = tagType.Pink;
                pictureBoxBlank04.Image = Properties.Resources.Pink;
            }
        }

        private void pictureBoxBlank04_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank04.Image = null;
        }

        // pictureBoxBlank05
        private void pictureBoxBlank05_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pictureBoxGreen1.Image == null || pictureBoxGreen2.Image == null || pictureBoxGreen3.Image == null || pictureBoxGreen4.Image == null
                 || pictureBoxGreen5.Image == null || pictureBoxGreen6.Image == null || pictureBoxGreen7.Image == null || pictureBoxGreen8.Image == null || pictureBoxGreen9.Image == null)
            {
                pictureBoxBlank05.Tag = tagType.Green;
                pictureBoxBlank05.Image = Properties.Resources.Green;
            }

            if (pictureBoxPink1.Image == null || pictureBoxPink2.Image == null || pictureBoxPink3.Image == null || pictureBoxPink4.Image == null
                || pictureBoxPink5.Image == null || pictureBoxPink6.Image == null || pictureBoxPink7.Image == null || pictureBoxPink8.Image == null || pictureBoxPink9.Image == null)
            {
                pictureBoxBlank05.Tag = tagType.Pink;
                pictureBoxBlank05.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank04 -> pictureBoxBlank05
            else if (pictureBoxBlank04.Image == null || (int)pictureBoxBlank04.Tag == 1)
            {
                pictureBoxBlank04.Tag = tagType.Blank;
                pictureBoxBlank05.Tag = tagType.Green;
                pictureBoxBlank05.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank04.Image == null || (int)pictureBoxBlank04.Tag == 2)
            {
                pictureBoxBlank04.Tag = tagType.Blank;
                pictureBoxBlank05.Tag = tagType.Pink;
                pictureBoxBlank05.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank06 -> pictureBoxBlank05
            else if (pictureBoxBlank06.Image == null || (int)pictureBoxBlank06.Tag == 1)
            {
                pictureBoxBlank06.Tag = tagType.Blank;
                pictureBoxBlank05.Tag = tagType.Green;
                pictureBoxBlank05.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank06.Image == null || (int)pictureBoxBlank06.Tag == 2)
            {
                pictureBoxBlank06.Tag = tagType.Blank;
                pictureBoxBlank05.Tag = tagType.Pink;
                pictureBoxBlank05.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank015 -> pictureBoxBlank05
            else if (pictureBoxBlank15.Image == null || (int)pictureBoxBlank15.Tag == 1)
            {
                pictureBoxBlank15.Tag = tagType.Blank;
                pictureBoxBlank05.Tag = tagType.Green;
                pictureBoxBlank05.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank15.Image == null || (int)pictureBoxBlank15.Tag == 2)
            {
                pictureBoxBlank15.Tag = tagType.Blank;
                pictureBoxBlank05.Tag = tagType.Pink;
                pictureBoxBlank05.Image = Properties.Resources.Pink;
            }
        }

        private void pictureBoxBlank05_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank05.Image = null;
        }

        // pictureBoxBlank06
        private void pictureBoxBlank06_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pictureBoxGreen1.Image == null || pictureBoxGreen2.Image == null || pictureBoxGreen3.Image == null || pictureBoxGreen4.Image == null
                 || pictureBoxGreen5.Image == null || pictureBoxGreen6.Image == null || pictureBoxGreen7.Image == null || pictureBoxGreen8.Image == null || pictureBoxGreen9.Image == null)
            {
                pictureBoxBlank06.Tag = tagType.Green;
                pictureBoxBlank06.Image = Properties.Resources.Green;
            }

            if (pictureBoxPink1.Image == null || pictureBoxPink2.Image == null || pictureBoxPink3.Image == null || pictureBoxPink4.Image == null
                || pictureBoxPink5.Image == null || pictureBoxPink6.Image == null || pictureBoxPink7.Image == null || pictureBoxPink8.Image == null || pictureBoxPink9.Image == null)
            {
                pictureBoxBlank06.Tag = tagType.Pink;
                pictureBoxBlank06.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank05 -> pictureBoxBlank06
            else if (pictureBoxBlank05.Image == null || (int)pictureBoxBlank05.Tag == 1)
            {
                pictureBoxBlank05.Tag = tagType.Blank;
                pictureBoxBlank06.Tag = tagType.Green;
                pictureBoxBlank06.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank05.Image == null || (int)pictureBoxBlank05.Tag == 2)
            {
                pictureBoxBlank05.Tag = tagType.Blank;
                pictureBoxBlank06.Tag = tagType.Pink;
                pictureBoxBlank06.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank07 -> pictureBoxBlank06
            else if (pictureBoxBlank07.Image == null || (int)pictureBoxBlank07.Tag == 1)
            {
                pictureBoxBlank07.Tag = tagType.Blank;
                pictureBoxBlank06.Tag = tagType.Green;
                pictureBoxBlank06.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank07.Image == null || (int)pictureBoxBlank07.Tag == 2)
            {
                pictureBoxBlank07.Tag = tagType.Blank;
                pictureBoxBlank06.Tag = tagType.Pink;
                pictureBoxBlank06.Image = Properties.Resources.Pink;
            }
        }

        private void pictureBoxBlank06_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank06.Image = null;
        }

        // pictureBoxBlank07
        private void pictureBoxBlank07_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pictureBoxGreen1.Image == null || pictureBoxGreen2.Image == null || pictureBoxGreen3.Image == null || pictureBoxGreen4.Image == null
                 || pictureBoxGreen5.Image == null || pictureBoxGreen6.Image == null || pictureBoxGreen7.Image == null || pictureBoxGreen8.Image == null || pictureBoxGreen9.Image == null)
            {
                pictureBoxBlank07.Tag = tagType.Green;
                pictureBoxBlank07.Image = Properties.Resources.Green;
            }

            if (pictureBoxPink1.Image == null || pictureBoxPink2.Image == null || pictureBoxPink3.Image == null || pictureBoxPink4.Image == null
                || pictureBoxPink5.Image == null || pictureBoxPink6.Image == null || pictureBoxPink7.Image == null || pictureBoxPink8.Image == null || pictureBoxPink9.Image == null)
            {
                pictureBoxBlank07.Tag = tagType.Pink;
                pictureBoxBlank07.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank00 -> pictureBoxBlank07
            else if (pictureBoxBlank00.Image == null || (int)pictureBoxBlank00.Tag == 1)
            {
                pictureBoxBlank00.Tag = tagType.Blank;
                pictureBoxBlank07.Tag = tagType.Green;
                pictureBoxBlank07.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank00.Image == null || (int)pictureBoxBlank00.Tag == 2)
            {
                pictureBoxBlank00.Tag = tagType.Blank;
                pictureBoxBlank07.Tag = tagType.Pink;
                pictureBoxBlank07.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank06 -> pictureBoxBlank07
            else if (pictureBoxBlank06.Image == null || (int)pictureBoxBlank06.Tag == 1)
            {
                pictureBoxBlank06.Tag = tagType.Blank;
                pictureBoxBlank07.Tag = tagType.Green;
                pictureBoxBlank07.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank06.Image == null || (int)pictureBoxBlank06.Tag == 2)
            {
                pictureBoxBlank06.Tag = tagType.Blank;
                pictureBoxBlank07.Tag = tagType.Pink;
                pictureBoxBlank07.Image = Properties.Resources.Pink;
            }
        }

        private void pictureBoxBlank07_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank07.Image = null;
        }

        // pictureBoxBlank10
        private void pictureBoxBlank10_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pictureBoxGreen1.Image == null || pictureBoxGreen2.Image == null || pictureBoxGreen3.Image == null || pictureBoxGreen4.Image == null
                 || pictureBoxGreen5.Image == null || pictureBoxGreen6.Image == null || pictureBoxGreen7.Image == null || pictureBoxGreen8.Image == null || pictureBoxGreen9.Image == null)
            {
                pictureBoxBlank10.Tag = tagType.Green;
                pictureBoxBlank10.Image = Properties.Resources.Green;
            }

            if (pictureBoxPink1.Image == null || pictureBoxPink2.Image == null || pictureBoxPink3.Image == null || pictureBoxPink4.Image == null
                || pictureBoxPink5.Image == null || pictureBoxPink6.Image == null || pictureBoxPink7.Image == null || pictureBoxPink8.Image == null || pictureBoxPink9.Image == null)
            {
                pictureBoxBlank10.Tag = tagType.Pink;
                pictureBoxBlank10.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank11 -> pictureBoxBlank10
            else if (pictureBoxBlank11.Image == null || (int)pictureBoxBlank11.Tag == 1)
            {
                pictureBoxBlank11.Tag = tagType.Blank;
                pictureBoxBlank10.Tag = tagType.Green;
                pictureBoxBlank10.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank11.Image == null || (int)pictureBoxBlank11.Tag == 2)
            {
                pictureBoxBlank11.Tag = tagType.Blank;
                pictureBoxBlank10.Tag = tagType.Pink;
                pictureBoxBlank10.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank17 -> pictureBoxBlank10
            else if (pictureBoxBlank17.Image == null || (int)pictureBoxBlank17.Tag == 1)
            {
                pictureBoxBlank17.Tag = tagType.Blank;
                pictureBoxBlank10.Tag = tagType.Green;
                pictureBoxBlank10.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank17.Image == null || (int)pictureBoxBlank17.Tag == 2)
            {
                pictureBoxBlank17.Tag = tagType.Blank;
                pictureBoxBlank10.Tag = tagType.Pink;
                pictureBoxBlank10.Image = Properties.Resources.Pink;
            }
        }

        private void pictureBoxBlank100_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank10.Image = null;
        }

        // pictureBoxBlank11
        private void pictureBoxBlank11_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pictureBoxGreen1.Image == null || pictureBoxGreen2.Image == null || pictureBoxGreen3.Image == null || pictureBoxGreen4.Image == null
                 || pictureBoxGreen5.Image == null || pictureBoxGreen6.Image == null || pictureBoxGreen7.Image == null || pictureBoxGreen8.Image == null || pictureBoxGreen9.Image == null)
            {
                pictureBoxBlank11.Tag = tagType.Green;
                pictureBoxBlank11.Image = Properties.Resources.Green;
            }

            if (pictureBoxPink1.Image == null || pictureBoxPink2.Image == null || pictureBoxPink3.Image == null || pictureBoxPink4.Image == null
                || pictureBoxPink5.Image == null || pictureBoxPink6.Image == null || pictureBoxPink7.Image == null || pictureBoxPink8.Image == null || pictureBoxPink9.Image == null)
            {
                pictureBoxBlank11.Tag = tagType.Pink;
                pictureBoxBlank11.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank01 -> pictureBoxBlank11
            else if (pictureBoxBlank01.Image == null || (int)pictureBoxBlank01.Tag == 1)
            {
                pictureBoxBlank01.Tag = tagType.Blank;
                pictureBoxBlank11.Tag = tagType.Green;
                pictureBoxBlank11.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank01.Image == null || (int)pictureBoxBlank01.Tag == 2)
            {
                pictureBoxBlank01.Tag = tagType.Blank;
                pictureBoxBlank11.Tag = tagType.Pink;
                pictureBoxBlank11.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank10 -> pictureBoxBlank11
            else if (pictureBoxBlank10.Image == null || (int)pictureBoxBlank10.Tag == 1)
            {
                pictureBoxBlank10.Tag = tagType.Blank;
                pictureBoxBlank11.Tag = tagType.Green;
                pictureBoxBlank11.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank10.Image == null || (int)pictureBoxBlank10.Tag == 2)
            {
                pictureBoxBlank10.Tag = tagType.Blank;
                pictureBoxBlank11.Tag = tagType.Pink;
                pictureBoxBlank11.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank12 -> pictureBoxBlank11
            else if (pictureBoxBlank12.Image == null || (int)pictureBoxBlank12.Tag == 1)
            {
                pictureBoxBlank12.Tag = tagType.Blank;
                pictureBoxBlank11.Tag = tagType.Green;
                pictureBoxBlank11.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank12.Image == null || (int)pictureBoxBlank12.Tag == 2)
            {
                pictureBoxBlank12.Tag = tagType.Blank;
                pictureBoxBlank11.Tag = tagType.Pink;
                pictureBoxBlank11.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank21 -> pictureBoxBlank11
            else if (pictureBoxBlank21.Image == null || (int)pictureBoxBlank21.Tag == 1)
            {
                pictureBoxBlank21.Tag = tagType.Blank;
                pictureBoxBlank11.Tag = tagType.Green;
                pictureBoxBlank11.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank21.Image == null || (int)pictureBoxBlank21.Tag == 2)
            {
                pictureBoxBlank21.Tag = tagType.Blank;
                pictureBoxBlank11.Tag = tagType.Pink;
                pictureBoxBlank11.Image = Properties.Resources.Pink;
            }
        }

        private void pictureBoxBlank11_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank11.Image = null;
        }

        // pictureBoxBlank12
        private void pictureBoxBlank12_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pictureBoxGreen1.Image == null || pictureBoxGreen2.Image == null || pictureBoxGreen3.Image == null || pictureBoxGreen4.Image == null
                 || pictureBoxGreen5.Image == null || pictureBoxGreen6.Image == null || pictureBoxGreen7.Image == null || pictureBoxGreen8.Image == null || pictureBoxGreen9.Image == null)
            {
                pictureBoxBlank12.Tag = tagType.Green;
                pictureBoxBlank12.Image = Properties.Resources.Green;
            }

            if (pictureBoxPink1.Image == null || pictureBoxPink2.Image == null || pictureBoxPink3.Image == null || pictureBoxPink4.Image == null
                || pictureBoxPink5.Image == null || pictureBoxPink6.Image == null || pictureBoxPink7.Image == null || pictureBoxPink8.Image == null || pictureBoxPink9.Image == null)
            {
                pictureBoxBlank12.Tag = tagType.Pink;
                pictureBoxBlank12.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank11 -> pictureBoxBlank12
            else if (pictureBoxBlank11.Image == null || (int)pictureBoxBlank11.Tag == 1)
            {
                pictureBoxBlank11.Tag = tagType.Blank;
                pictureBoxBlank12.Tag = tagType.Green;
                pictureBoxBlank12.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank11.Image == null || (int)pictureBoxBlank11.Tag == 2)
            {
                pictureBoxBlank11.Tag = tagType.Blank;
                pictureBoxBlank12.Tag = tagType.Pink;
                pictureBoxBlank12.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank13 -> pictureBoxBlank12
            else if (pictureBoxBlank13.Image == null || (int)pictureBoxBlank13.Tag == 1)
            {
                pictureBoxBlank13.Tag = tagType.Blank;
                pictureBoxBlank12.Tag = tagType.Green;
                pictureBoxBlank12.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank13.Image == null || (int)pictureBoxBlank13.Tag == 2)
            {
                pictureBoxBlank13.Tag = tagType.Blank;
                pictureBoxBlank12.Tag = tagType.Pink;
                pictureBoxBlank12.Image = Properties.Resources.Pink;
            }
        }

        private void pictureBoxBlank12_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank12.Image = null;
        }

        // pictureBoxBlank13
        private void pictureBoxBlank13_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pictureBoxGreen1.Image == null || pictureBoxGreen2.Image == null || pictureBoxGreen3.Image == null || pictureBoxGreen4.Image == null
                 || pictureBoxGreen5.Image == null || pictureBoxGreen6.Image == null || pictureBoxGreen7.Image == null || pictureBoxGreen8.Image == null || pictureBoxGreen9.Image == null)
            {
                pictureBoxBlank13.Tag = tagType.Green;
                pictureBoxBlank13.Image = Properties.Resources.Green;
            }

            if (pictureBoxPink1.Image == null || pictureBoxPink2.Image == null || pictureBoxPink3.Image == null || pictureBoxPink4.Image == null
                || pictureBoxPink5.Image == null || pictureBoxPink6.Image == null || pictureBoxPink7.Image == null || pictureBoxPink8.Image == null || pictureBoxPink9.Image == null)
            {
                pictureBoxBlank13.Tag = tagType.Pink;
                pictureBoxBlank13.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank03 -> pictureBoxBlank13
            else if (pictureBoxBlank03.Image == null || (int)pictureBoxBlank03.Tag == 1)
            {
                pictureBoxBlank03.Tag = tagType.Blank;
                pictureBoxBlank13.Tag = tagType.Green;
                pictureBoxBlank13.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank03.Image == null || (int)pictureBoxBlank03.Tag == 2)
            {
                pictureBoxBlank03.Tag = tagType.Blank;
                pictureBoxBlank13.Tag = tagType.Pink;
                pictureBoxBlank13.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank12 -> pictureBoxBlank13
            else if (pictureBoxBlank12.Image == null || (int)pictureBoxBlank12.Tag == 1)
            {
                pictureBoxBlank12.Tag = tagType.Blank;
                pictureBoxBlank13.Tag = tagType.Green;
                pictureBoxBlank13.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank12.Image == null || (int)pictureBoxBlank12.Tag == 2)
            {
                pictureBoxBlank12.Tag = tagType.Blank;
                pictureBoxBlank13.Tag = tagType.Pink;
                pictureBoxBlank13.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank14 -> pictureBoxBlank13
            else if (pictureBoxBlank14.Image == null || (int)pictureBoxBlank14.Tag == 1)
            {
                pictureBoxBlank14.Tag = tagType.Blank;
                pictureBoxBlank13.Tag = tagType.Green;
                pictureBoxBlank13.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank14.Image == null || (int)pictureBoxBlank14.Tag == 2)
            {
                pictureBoxBlank14.Tag = tagType.Blank;
                pictureBoxBlank13.Tag = tagType.Pink;
                pictureBoxBlank13.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank23 -> pictureBoxBlank13
            else if (pictureBoxBlank23.Image == null || (int)pictureBoxBlank23.Tag == 1)
            {
                pictureBoxBlank23.Tag = tagType.Blank;
                pictureBoxBlank13.Tag = tagType.Green;
                pictureBoxBlank13.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank23.Image == null || (int)pictureBoxBlank23.Tag == 2)
            {
                pictureBoxBlank23.Tag = tagType.Blank;
                pictureBoxBlank13.Tag = tagType.Pink;
                pictureBoxBlank13.Image = Properties.Resources.Pink;
            }
        }

        private void pictureBoxBlank13_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank13.Image = null;
        }

        // pictureBoxBlank14
        private void pictureBoxBlank14_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pictureBoxGreen1.Image == null || pictureBoxGreen2.Image == null || pictureBoxGreen3.Image == null || pictureBoxGreen4.Image == null
                 || pictureBoxGreen5.Image == null || pictureBoxGreen6.Image == null || pictureBoxGreen7.Image == null || pictureBoxGreen8.Image == null || pictureBoxGreen9.Image == null)
            {
                pictureBoxBlank14.Tag = tagType.Green;
                pictureBoxBlank14.Image = Properties.Resources.Green;
            }

            if (pictureBoxPink1.Image == null || pictureBoxPink2.Image == null || pictureBoxPink3.Image == null || pictureBoxPink4.Image == null
                || pictureBoxPink5.Image == null || pictureBoxPink6.Image == null || pictureBoxPink7.Image == null || pictureBoxPink8.Image == null || pictureBoxPink9.Image == null)
            {
                pictureBoxBlank14.Tag = tagType.Pink;
                pictureBoxBlank14.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank13 -> pictureBoxBlank14
            else if (pictureBoxBlank13.Image == null || (int)pictureBoxBlank13.Tag == 1)
            {
                pictureBoxBlank13.Tag = tagType.Blank;
                pictureBoxBlank14.Tag = tagType.Green;
                pictureBoxBlank14.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank13.Image == null || (int)pictureBoxBlank13.Tag == 2)
            {
                pictureBoxBlank13.Tag = tagType.Blank;
                pictureBoxBlank14.Tag = tagType.Pink;
                pictureBoxBlank14.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank15 -> pictureBoxBlank14
            else if (pictureBoxBlank15.Image == null || (int)pictureBoxBlank15.Tag == 1)
            {
                pictureBoxBlank15.Tag = tagType.Blank;
                pictureBoxBlank14.Tag = tagType.Green;
                pictureBoxBlank14.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank15.Image == null || (int)pictureBoxBlank15.Tag == 2)
            {
                pictureBoxBlank15.Tag = tagType.Blank;
                pictureBoxBlank14.Tag = tagType.Pink;
                pictureBoxBlank14.Image = Properties.Resources.Pink;
            }
        }

        private void pictureBoxBlank14_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank14.Image = null;
        }

        // pictureBoxBlank15
        private void pictureBoxBlank15_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pictureBoxGreen1.Image == null || pictureBoxGreen2.Image == null || pictureBoxGreen3.Image == null || pictureBoxGreen4.Image == null
                 || pictureBoxGreen5.Image == null || pictureBoxGreen6.Image == null || pictureBoxGreen7.Image == null || pictureBoxGreen8.Image == null || pictureBoxGreen9.Image == null)
            {
                pictureBoxBlank15.Tag = tagType.Green;
                pictureBoxBlank15.Image = Properties.Resources.Green;
            }

            if (pictureBoxPink1.Image == null || pictureBoxPink2.Image == null || pictureBoxPink3.Image == null || pictureBoxPink4.Image == null
                || pictureBoxPink5.Image == null || pictureBoxPink6.Image == null || pictureBoxPink7.Image == null || pictureBoxPink8.Image == null || pictureBoxPink9.Image == null)
            {
                pictureBoxBlank15.Tag = tagType.Pink;
                pictureBoxBlank15.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank05 -> pictureBoxBlank15
            else if (pictureBoxBlank05.Image == null || (int)pictureBoxBlank05.Tag == 1)
            {
                pictureBoxBlank05.Tag = tagType.Blank;
                pictureBoxBlank15.Tag = tagType.Green;
                pictureBoxBlank15.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank05.Image == null || (int)pictureBoxBlank05.Tag == 2)
            {
                pictureBoxBlank05.Tag = tagType.Blank;
                pictureBoxBlank15.Tag = tagType.Pink;
                pictureBoxBlank15.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank14 -> pictureBoxBlank15
            else if (pictureBoxBlank14.Image == null || (int)pictureBoxBlank14.Tag == 1)
            {
                pictureBoxBlank14.Tag = tagType.Blank;
                pictureBoxBlank15.Tag = tagType.Green;
                pictureBoxBlank15.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank14.Image == null || (int)pictureBoxBlank14.Tag == 2)
            {
                pictureBoxBlank14.Tag = tagType.Blank;
                pictureBoxBlank15.Tag = tagType.Pink;
                pictureBoxBlank15.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank16 -> pictureBoxBlank15
            else if (pictureBoxBlank16.Image == null || (int)pictureBoxBlank16.Tag == 1)
            {
                pictureBoxBlank16.Tag = tagType.Blank;
                pictureBoxBlank15.Tag = tagType.Green;
                pictureBoxBlank15.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank16.Image == null || (int)pictureBoxBlank16.Tag == 2)
            {
                pictureBoxBlank16.Tag = tagType.Blank;
                pictureBoxBlank15.Tag = tagType.Pink;
                pictureBoxBlank15.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank25 -> pictureBoxBlank15
            else if (pictureBoxBlank25.Image == null || (int)pictureBoxBlank25.Tag == 1)
            {
                pictureBoxBlank25.Tag = tagType.Blank;
                pictureBoxBlank15.Tag = tagType.Green;
                pictureBoxBlank15.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank25.Image == null || (int)pictureBoxBlank25.Tag == 2)
            {
                pictureBoxBlank25.Tag = tagType.Blank;
                pictureBoxBlank15.Tag = tagType.Pink;
                pictureBoxBlank15.Image = Properties.Resources.Pink;
            }
        }

        private void pictureBoxBlank15_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank15.Image = null;
        }

        // pictureBoxBlank16
        private void pictureBoxBlank16_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pictureBoxGreen1.Image == null || pictureBoxGreen2.Image == null || pictureBoxGreen3.Image == null || pictureBoxGreen4.Image == null
                 || pictureBoxGreen5.Image == null || pictureBoxGreen6.Image == null || pictureBoxGreen7.Image == null || pictureBoxGreen8.Image == null || pictureBoxGreen9.Image == null)
            {
                pictureBoxBlank16.Tag = tagType.Green;
                pictureBoxBlank16.Image = Properties.Resources.Green;
            }

            if (pictureBoxPink1.Image == null || pictureBoxPink2.Image == null || pictureBoxPink3.Image == null || pictureBoxPink4.Image == null
                || pictureBoxPink5.Image == null || pictureBoxPink6.Image == null || pictureBoxPink7.Image == null || pictureBoxPink8.Image == null || pictureBoxPink9.Image == null)
            {
                pictureBoxBlank16.Tag = tagType.Pink;
                pictureBoxBlank16.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank15 -> pictureBoxBlank16
            else if (pictureBoxBlank15.Image == null || (int)pictureBoxBlank15.Tag == 1)
            {
                pictureBoxBlank15.Tag = tagType.Blank;
                pictureBoxBlank16.Tag = tagType.Green;
                pictureBoxBlank16.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank15.Image == null || (int)pictureBoxBlank15.Tag == 2)
            {
                pictureBoxBlank15.Tag = tagType.Blank;
                pictureBoxBlank15.Tag = tagType.Pink;
                pictureBoxBlank15.Image = Properties.Resources.Pink;
            }

            // pictureBoxBlank17 -> pictureBoxBlank16
            else if (pictureBoxBlank17.Image == null || (int)pictureBoxBlank17.Tag == 1)
            {
                pictureBoxBlank17.Tag = tagType.Blank;
                pictureBoxBlank16.Tag = tagType.Green;
                pictureBoxBlank16.Image = Properties.Resources.Green;
            }

            else if (pictureBoxBlank17.Image == null || (int)pictureBoxBlank17.Tag == 2)
            {
                pictureBoxBlank17.Tag = tagType.Blank;
                pictureBoxBlank16.Tag = tagType.Pink;
                pictureBoxBlank16.Image = Properties.Resources.Pink;
            }
        }

        private void pictureBoxBlank16_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank16.Image = null;
        }

        // pictureBoxBlank17
        private void pictureBoxBlank17_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank17.Image = null;
        }

        // pictureBoxBlank20
        private void pictureBoxBlank20_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank20.Image = null;
        }



        // pictureBoxBlank21
        private void pictureBoxBlank21_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank21.Image = null;
        }

        // pictureBoxBlank22
        private void pictureBoxBlank22_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank22.Image = null;
        }

        // pictureBoxBlank23
        private void pictureBoxBlank23_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank23.Image = null;
        }

        // pictureBoxBlank24
        private void pictureBoxBlank24_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank24.Image = null;
        }


        // pictureBoxBlank25
        private void pictureBoxBlank25_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank25.Image = null;
        }

        // pictureBoxBlank26
        private void pictureBoxBlank26_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank26.Image = null;
        }


        // pictureBoxBlank27
        private void pictureBoxBlank27_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank27.Image = null;
        }

    }
}
