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

        enum tagType {Blank=0, Green=1, Pink=2};

        public Form1()
        {
            InitializeComponent();
        }

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

        private void pictureBoxBlank00_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(pictureBoxGreen1.Image == null)
            {
                pictureBoxBlank00.Tag = tagType.Green;
                pictureBoxBlank00.Image = Properties.Resources.Green;
            }

            if (pictureBoxPink1.Image == null)
            {
                pictureBoxBlank00.Tag = tagType.Pink;
                pictureBoxBlank00.Image = Properties.Resources.Pink;
            }

            if (pictureBoxGreen2.Image == null)
            {
                pictureBoxBlank00.Tag = tagType.Green;
                pictureBoxBlank00.Image = Properties.Resources.Green;
            }

            if (pictureBoxPink2.Image == null)
            {
                pictureBoxBlank00.Tag = tagType.Pink;
                pictureBoxBlank00.Image = Properties.Resources.Pink;
            }
        }

        private void pictureBoxBlank00_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank00.Image = null;
        }

        private void pictureBoxBlank01_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pictureBoxBlank00.Image == null && (int)pictureBoxBlank00.Tag== 1)
            {
                pictureBoxBlank01.Tag = tagType.Green;
                pictureBoxBlank01.Image = Properties.Resources.Green;
            }

            if (pictureBoxBlank00.Image == null && (int)pictureBoxBlank00.Tag == 2)
            {
                pictureBoxBlank01.Tag = tagType.Pink;
                pictureBoxBlank01.Image = Properties.Resources.Pink;
            }
        }

        private void pictureBoxBlank01_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBlank01.Image = null;
        }

        private void pictureBoxBlank02_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pictureBoxBlank01.Image == null && (int)pictureBoxBlank01.Tag == 1)
            {
                pictureBoxBlank02.Image = Properties.Resources.Green;
            }

            if (pictureBoxBlank01.Image == null && (int)pictureBoxBlank01.Tag == 2)
            {
                pictureBoxBlank02.Image = Properties.Resources.Pink;
            }
        }

        private void pictureBoxBlank07_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pictureBoxBlank00.Image == null)
            {
                pictureBoxBlank07.Image = Properties.Resources.Green;
            }
        }
    }
}
