﻿namespace Bingo
{
    partial class Logon
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logon));
            this.labAccName = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.cbRemenber = new System.Windows.Forms.CheckBox();
            this.txbAccentName = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btLogon = new System.Windows.Forms.Button();
            this.labSign = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.labTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labAccName
            // 
            this.labAccName.AutoSize = true;
            this.labAccName.ForeColor = System.Drawing.Color.Gray;
            this.labAccName.Location = new System.Drawing.Point(12, 34);
            this.labAccName.Name = "labAccName";
            this.labAccName.Size = new System.Drawing.Size(42, 21);
            this.labAccName.TabIndex = 0;
            this.labAccName.Text = "账户";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.ForeColor = System.Drawing.Color.Gray;
            this.labPassword.Location = new System.Drawing.Point(12, 69);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(42, 21);
            this.labPassword.TabIndex = 1;
            this.labPassword.Text = "密码";
            // 
            // cbRemenber
            // 
            this.cbRemenber.AutoSize = true;
            this.cbRemenber.ForeColor = System.Drawing.Color.Gray;
            this.cbRemenber.Location = new System.Drawing.Point(60, 96);
            this.cbRemenber.Name = "cbRemenber";
            this.cbRemenber.Size = new System.Drawing.Size(93, 25);
            this.cbRemenber.TabIndex = 2;
            this.cbRemenber.Text = "记住密码";
            this.cbRemenber.UseVisualStyleBackColor = true;
            // 
            // txbAccentName
            // 
            this.txbAccentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txbAccentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbAccentName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbAccentName.ForeColor = System.Drawing.Color.Gray;
            this.txbAccentName.Location = new System.Drawing.Point(60, 38);
            this.txbAccentName.MaxLength = 100;
            this.txbAccentName.Name = "txbAccentName";
            this.txbAccentName.Size = new System.Drawing.Size(155, 16);
            this.txbAccentName.TabIndex = 3;
            this.txbAccentName.Text = "请输入账户名";
            this.txbAccentName.GotFocus += new System.EventHandler(this.AccentGotFocus);
            this.txbAccentName.LostFocus += new System.EventHandler(this.AccentLostFocus);
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbPassword.ForeColor = System.Drawing.Color.Gray;
            this.txbPassword.Location = new System.Drawing.Point(60, 73);
            this.txbPassword.MaxLength = 16;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(155, 16);
            this.txbPassword.TabIndex = 4;
            this.txbPassword.Text = "请输入密码";
            this.txbPassword.GotFocus += new System.EventHandler(this.PasswordGotFocus);
            this.txbPassword.LostFocus += new System.EventHandler(this.PasswordLostFocus);
            // 
            // btLogon
            // 
            this.btLogon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btLogon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btLogon.FlatAppearance.BorderSize = 0;
            this.btLogon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btLogon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btLogon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogon.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btLogon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btLogon.Location = new System.Drawing.Point(0, 120);
            this.btLogon.Name = "btLogon";
            this.btLogon.Size = new System.Drawing.Size(250, 40);
            this.btLogon.TabIndex = 5;
            this.btLogon.Text = "登陆";
            this.btLogon.UseVisualStyleBackColor = false;
            this.btLogon.Click += new System.EventHandler(this.OnButtonLogon);
            // 
            // labSign
            // 
            this.labSign.AutoSize = true;
            this.labSign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labSign.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSign.ForeColor = System.Drawing.Color.Gray;
            this.labSign.Location = new System.Drawing.Point(173, 97);
            this.labSign.Name = "labSign";
            this.labSign.Size = new System.Drawing.Size(42, 21);
            this.labSign.TabIndex = 6;
            this.labSign.Text = "注册";
            this.labSign.Click += new System.EventHandler(this.OnSigh);
            // 
            // btExit
            // 
            this.btExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExit.ForeColor = System.Drawing.Color.Silver;
            this.btExit.Location = new System.Drawing.Point(220, -2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(30, 30);
            this.btExit.TabIndex = 8;
            this.btExit.Text = "X";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.OnButtonExit);
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.labTitle.Location = new System.Drawing.Point(-13, -12);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(123, 46);
            this.labTitle.TabIndex = 9;
            this.labTitle.Text = "Bingo";
            this.labTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bingo_MouseDown);
            this.labTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bingo_MouseMove);
            // 
            // Logon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(250, 160);
            this.ControlBox = false;
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.labSign);
            this.Controls.Add(this.btLogon);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbAccentName);
            this.Controls.Add(this.cbRemenber);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.labAccName);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Logon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logon";
            this.Load += new System.EventHandler(this.Bingo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bingo_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bingo_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bingo_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAccName;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.CheckBox cbRemenber;
        private System.Windows.Forms.TextBox txbAccentName;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btLogon;
        private System.Windows.Forms.Label labSign;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label labTitle;
    }
}

