
namespace 图书信息管理系统
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书类别管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加图书ToolStripMenuItem,
            this.图书类别管理ToolStripMenuItem,
            this.图书查询ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加图书ToolStripMenuItem
            // 
            this.添加图书ToolStripMenuItem.Name = "添加图书ToolStripMenuItem";
            this.添加图书ToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.添加图书ToolStripMenuItem.Text = " 添加图书";
            this.添加图书ToolStripMenuItem.Click += new System.EventHandler(this.添加图书ToolStripMenuItem_Click);
            // 
            // 图书类别管理ToolStripMenuItem
            // 
            this.图书类别管理ToolStripMenuItem.Name = "图书类别管理ToolStripMenuItem";
            this.图书类别管理ToolStripMenuItem.Size = new System.Drawing.Size(96, 21);
            this.图书类别管理ToolStripMenuItem.Text = " 图书类别管理";
            this.图书类别管理ToolStripMenuItem.Click += new System.EventHandler(this.图书类别管理ToolStripMenuItem_Click);
            // 
            // 图书查询ToolStripMenuItem
            // 
            this.图书查询ToolStripMenuItem.Name = "图书查询ToolStripMenuItem";
            this.图书查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.图书查询ToolStripMenuItem.Text = "图书查询";
            this.图书查询ToolStripMenuItem.Click += new System.EventHandler(this.图书查询ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(544, 407);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书信息管理系统";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书类别管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
    }
}

