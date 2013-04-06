using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bingo
{
    public partial class Friends : Form
    {
        public Friends()
        {
            InitializeComponent();
        }

        private void Friends_Load(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader(@"../friends.txt", Encoding.Default);
            //Label labFriends = new Label();
        }

        private Point ptOffset;
        private void Friends_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button && MouseButtons.Right != e.Button) return;

            Point ptCur = PointToScreen(e.Location);
            ptOffset = new Point(ptCur.X - this.Left, ptCur.Y - this.Top);
        }

        private void Friends_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button && MouseButtons.Right != e.Button) return;

            Point ptCur = MousePosition;
            this.Location = new Point(ptCur.X - ptOffset.X, ptCur.Y - ptOffset.Y);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            notifyBingo.Visible = false;
            Application.Exit();
        }

        private void btMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Friends_SizeChanged(object sender, EventArgs e)
        {
            this.Hide();
            this.notifyBingo.Visible = true; 
        }

        private void Friends_NotifyIcon_Click(object sender, EventArgs e)
        {
            if (MouseButtons.Left != ((MouseEventArgs)e).Button) return;
            if (this.Visible == false)
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.Show();
            }
            else
            {
                this.Hide();
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void Friends_About(object sender, EventArgs e)
        {
            About wndAbout = new About();
            wndAbout.Show();
        }

        private bool bMore = false;
        private void btMore_Click(object sender, EventArgs e)
        {
            if (bMore == false)
            {
                bMore = true;
                this.Height = 250;
                this.Visible = true;
                Point ptOffset = new Point(this.btMore.Location.X, this.btMore.Location.Y + 130);
                this.btMore.Location = ptOffset;
            }
            else
            {
                bMore = false;
                this.Height = 120;
                this.Visible = true;
                Point ptOffset = new Point(this.btMore.Location.X, this.btMore.Location.Y - 130);
                this.btMore.Location = ptOffset;
            }
        }

        private void labTitle_Click(object sender, EventArgs e)
        {
            this.Height += 80;
            this.Visible = true;
        }
    }
}
