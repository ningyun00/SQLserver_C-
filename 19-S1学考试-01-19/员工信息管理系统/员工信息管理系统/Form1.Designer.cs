
namespace 员工信息管理系统
{
    partial class frmEmploeeSySMain
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
            this.添加员工ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询员工ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考勤管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.业绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.津贴管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加员工ToolStripMenuItem,
            this.查询员工ToolStripMenuItem,
            this.考勤管理ToolStripMenuItem,
            this.业绩管理ToolStripMenuItem,
            this.津贴管理ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(483, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加员工ToolStripMenuItem
            // 
            this.添加员工ToolStripMenuItem.Name = "添加员工ToolStripMenuItem";
            this.添加员工ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.添加员工ToolStripMenuItem.Text = "添加员工";
            this.添加员工ToolStripMenuItem.Click += new System.EventHandler(this.添加员工ToolStripMenuItem_Click);
            // 
            // 查询员工ToolStripMenuItem
            // 
            this.查询员工ToolStripMenuItem.Name = "查询员工ToolStripMenuItem";
            this.查询员工ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.查询员工ToolStripMenuItem.Text = "查询员工";
            // 
            // 考勤管理ToolStripMenuItem
            // 
            this.考勤管理ToolStripMenuItem.Name = "考勤管理ToolStripMenuItem";
            this.考勤管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.考勤管理ToolStripMenuItem.Text = "考勤管理";
            // 
            // 业绩管理ToolStripMenuItem
            // 
            this.业绩管理ToolStripMenuItem.Name = "业绩管理ToolStripMenuItem";
            this.业绩管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.业绩管理ToolStripMenuItem.Text = "业绩管理";
            // 
            // 津贴管理ToolStripMenuItem
            // 
            this.津贴管理ToolStripMenuItem.Name = "津贴管理ToolStripMenuItem";
            this.津贴管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.津贴管理ToolStripMenuItem.Text = "津贴管理";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // frmEmploeeSySMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 316);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEmploeeSySMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工管理信息系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加员工ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询员工ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考勤管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 业绩管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 津贴管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}

