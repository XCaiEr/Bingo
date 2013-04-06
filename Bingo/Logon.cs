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

        private void AccentGotFocus(object sender, EventArgs e)
        {
            if (this.txbAccentName.Text == "请输入账户名" || this.txbAccentName.Text == "账户名不能为空！")
            {
                this.txbAccentName.Text = "";
                this.txbAccentName.BackColor = System.Drawing.Color.FromArgb(68, 68, 68);
            }
            else
            {
                this.txbAccentName.SelectAll();
            }
            this.txbAccentName.ForeColor = System.Drawing.Color.FromArgb(145, 145, 145);
        }

        private void AccentLostFocus(object sender, EventArgs e)
        {
            if (this.txbAccentName.Text.Length == 0)
            {
                this.txbAccentName.Text = "请输入账户名";
                this.txbAccentName.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void PasswordGotFocus(object sender, EventArgs e)
        {
            if (this.txbPassword.Text == "请输入密码" || this.txbPassword.Text == "密码不能为空！")
            {
                this.txbPassword.PasswordChar = '●';
                this.txbPassword.Text = "";
                this.txbPassword.BackColor = System.Drawing.Color.FromArgb(68, 68, 68);
            }
            this.txbPassword.ForeColor = System.Drawing.Color.FromArgb(145, 145, 145);
        }

        private void PasswordLostFocus(object sender, EventArgs e)
        {
            if (this.txbPassword.Text.Length == 0)
            {
                this.txbPassword.PasswordChar = '\0';
                this.txbPassword.Text = "请输入密码";
                this.txbPassword.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void OnButtonLogon(object sender, EventArgs e)
        {
            string sAccentName = this.txbAccentName.Text;
            if (sAccentName == "请输入账户名")
            {
                this.txbAccentName.BackColor = System.Drawing.Color.FromArgb(128, 28, 28);
                this.txbAccentName.Text = "账户名不能为空！";
                return;
            }
            if (this.txbPassword.Text == "请输入密码")
            {
                this.txbPassword.BackColor = System.Drawing.Color.FromArgb(128, 28, 28);
                this.txbPassword.Text = "密码不能为空！";
                return;
            }

            //this.Hide();
            //Friends wndFriends = new Friends();
            //wndFriends.ShowDialog();
        }

        private void OnSigh(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.baidu.com");
        }

        public void OnLogonFailed()
        {
            this.btLogon.Text = "登陆失败！";
        }
    }
}
