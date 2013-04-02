using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class Logon : Form
    {
        public Logon()
        {
            InitializeComponent();
        }

        private void Bingo_Load(object sender, EventArgs e)
        {

        }

        private Point ptOffset;
        private void Bingo_MouseDown(object sender, MouseEventArgs  e)
        {
            if (MouseButtons.Left != e.Button && MouseButtons.Right != e.Button) return;

            Point ptCur = this.PointToScreen(e.Location);
            ptOffset = new Point(ptCur.X - this.Left, ptCur.Y - this.Top);
        }

        private void Bingo_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button && MouseButtons.Right != e.Button) return;

            Point ptCur = MousePosition;
            this.Location = new Point(ptCur.X - ptOffset.X, ptCur.Y - ptOffset.Y);
        }

        private void Bingo_KeyPress(object sender, KeyEventArgs e)
        {
            if (Keys.Escape != e.KeyCode) return;
            else Application.Exit();
        }

        private void OnButtonExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnButtonLogon(object sender, EventArgs e)
        {
            string sAccentName = this.txbAccentName.Text;
            if (sAccentName.Length == 0)
            {
                this.txbAccentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
                return;
            }

            this.Hide();
            Friends wndFriends = new Friends();
            wndFriends.ShowDialog();
        }

        private void OnSigh(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.baidu.com");
        }
    }
}
