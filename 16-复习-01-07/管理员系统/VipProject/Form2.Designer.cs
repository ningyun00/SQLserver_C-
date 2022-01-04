
namespace VipProject
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.修改当前用户信息IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册VIP用户LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改当前用户信息IToolStripMenuItem,
            this.注册VIP用户LToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 修改当前用户信息IToolStripMenuItem
            // 
            this.修改当前用户信息IToolStripMenuItem.Name = "修改当前用户信息IToolStripMenuItem";
            this.修改当前用户信息IToolStripMenuItem.Size = new System.Drawing.Size(128, 21);
            this.修改当前用户信息IToolStripMenuItem.Text = "修改当前用户信息(&I)";
            this.修改当前用户信息IToolStripMenuItem.Click += new System.EventHandler(this.修改当前用户信息IToolStripMenuItem_Click);
            // 
            // 注册VIP用户LToolStripMenuItem
            // 
            this.注册VIP用户LToolStripMenuItem.Name = "注册VIP用户LToolStripMenuItem";
            this.注册VIP用户LToolStripMenuItem.Size = new System.Drawing.Size(101, 21);
            this.注册VIP用户LToolStripMenuItem.Text = "注册VIP用户(&L)";
            this.注册VIP用户LToolStripMenuItem.Click += new System.EventHandler(this.注册VIP用户LToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 397);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 修改当前用户信息IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注册VIP用户LToolStripMenuItem;
    }
}