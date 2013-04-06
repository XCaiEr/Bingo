namespace Bingo
{
    partial class Friends
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Friends));
            this.labTitle = new System.Windows.Forms.Label();
            this.labState = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btMin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.notifyBingo = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NotifyMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifyMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btMore = new System.Windows.Forms.Button();
            this.NotifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labTitle.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.labTitle.Location = new System.Drawing.Point(4, -2);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(71, 27);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "Bingo";
            this.labTitle.Click += new System.EventHandler(this.labTitle_Click);
            // 
            // labState
            // 
            this.labState.AutoSize = true;
            this.labState.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labState.ForeColor = System.Drawing.Color.LimeGreen;
            this.labState.Location = new System.Drawing.Point(-13, 3);
            this.labState.Name = "labState";
            this.labState.Size = new System.Drawing.Size(25, 16);
            this.labState.TabIndex = 1;
            this.labState.Text = "■";
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
            this.btExit.Location = new System.Drawing.Point(370, -1);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(25, 25);
            this.btExit.TabIndex = 9;
            this.btExit.Text = "X";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btMin
            // 
            this.btMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btMin.FlatAppearance.BorderSize = 0;
            this.btMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btMin.ForeColor = System.Drawing.Color.Silver;
            this.btMin.Location = new System.Drawing.Point(355, -3);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(23, 25);
            this.btMin.TabIndex = 10;
            this.btMin.Text = "__";
            this.btMin.UseVisualStyleBackColor = false;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(250, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 16);
            this.textBox1.TabIndex = 11;
            // 
            // notifyBingo
            // 
            this.notifyBingo.BalloonTipText = "Bingo";
            this.notifyBingo.BalloonTipTitle = "Bingo";
            this.notifyBingo.ContextMenuStrip = this.NotifyMenu;
            this.notifyBingo.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyBingo.Icon")));
            this.notifyBingo.Text = "Bingo";
            this.notifyBingo.Visible = true;
            this.notifyBingo.Click += new System.EventHandler(this.Friends_NotifyIcon_Click);
            // 
            // NotifyMenu
            // 
            this.NotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NotifyMenuAbout,
            this.NotifyMenuExit});
            this.NotifyMenu.Name = "NotifyMenu";
            this.NotifyMenu.Size = new System.Drawing.Size(99, 48);
            // 
            // NotifyMenuAbout
            // 
            this.NotifyMenuAbout.Name = "NotifyMenuAbout";
            this.NotifyMenuAbout.Size = new System.Drawing.Size(98, 22);
            this.NotifyMenuAbout.Text = "关于";
            this.NotifyMenuAbout.Click += new System.EventHandler(this.Friends_About);
            // 
            // NotifyMenuExit
            // 
            this.NotifyMenuExit.Name = "NotifyMenuExit";
            this.NotifyMenuExit.Size = new System.Drawing.Size(98, 22);
            this.NotifyMenuExit.Text = "退出";
            this.NotifyMenuExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btMore
            // 
            this.btMore.FlatAppearance.BorderSize = 0;
            this.btMore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btMore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMore.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btMore.ForeColor = System.Drawing.Color.Silver;
            this.btMore.Location = new System.Drawing.Point(0, 105);
            this.btMore.Name = "btMore";
            this.btMore.Size = new System.Drawing.Size(400, 15);
            this.btMore.TabIndex = 12;
            this.btMore.Text = "•••";
            this.btMore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMore.UseVisualStyleBackColor = true;
            this.btMore.Click += new System.EventHandler(this.btMore_Click);
            // 
            // Friends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(400, 120);
            this.Controls.Add(this.btMore);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.labState);
            this.Controls.Add(this.labTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Friends";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Friends";
            this.Load += new System.EventHandler(this.Friends_Load);
            this.SizeChanged += new System.EventHandler(this.Friends_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Friends_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Friends_MouseMove);
            this.NotifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labState;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NotifyIcon notifyBingo;
        private System.Windows.Forms.ContextMenuStrip NotifyMenu;
        private System.Windows.Forms.ToolStripMenuItem NotifyMenuExit;
        private System.Windows.Forms.ToolStripMenuItem NotifyMenuAbout;
        private System.Windows.Forms.Button btMore;
    }
}