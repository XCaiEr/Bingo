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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private Point ptOffset;
        private void About_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button && MouseButtons.Right != e.Button) return;

            Point ptCur = PointToScreen(e.Location);
            ptOffset = new Point(ptCur.X - this.Left, ptCur.Y - this.Top);
        }

        private void About_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button && MouseButtons.Right != e.Button) return;

            Point ptCur = MousePosition;
            this.Location = new Point(ptCur.X - ptOffset.X, ptCur.Y - ptOffset.Y);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
            //this.Hide();
        }
    }
}
