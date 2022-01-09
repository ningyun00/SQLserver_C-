
namespace 新睿学院学员管理
{
    partial class FrmEmpSysMain
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
            this.添加学员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询学员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考勤管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.宿舍管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班费管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加学员ToolStripMenuItem,
            this.查询学员ToolStripMenuItem,
            this.考勤管理ToolStripMenuItem,
            this.宿舍管理ToolStripMenuItem,
            this.班费管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加学员ToolStripMenuItem
            // 
            this.添加学员ToolStripMenuItem.Name = "添加学员ToolStripMenuItem";
            this.添加学员ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.添加学员ToolStripMenuItem.Text = "添加学员";
            this.添加学员ToolStripMenuItem.Click += new System.EventHandler(this.添加学员ToolStripMenuItem_Click);
            // 
            // 查询学员ToolStripMenuItem
            // 
            this.查询学员ToolStripMenuItem.Name = "查询学员ToolStripMenuItem";
            this.查询学员ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.查询学员ToolStripMenuItem.Text = "查询学员";
            this.查询学员ToolStripMenuItem.Click += new System.EventHandler(this.查询学员ToolStripMenuItem_Click);
            // 
            // 考勤管理ToolStripMenuItem
            // 
            this.考勤管理ToolStripMenuItem.Name = "考勤管理ToolStripMenuItem";
            this.考勤管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.考勤管理ToolStripMenuItem.Text = "考勤管理";
            // 
            // 宿舍管理ToolStripMenuItem
            // 
            this.宿舍管理ToolStripMenuItem.Name = "宿舍管理ToolStripMenuItem";
            this.宿舍管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.宿舍管理ToolStripMenuItem.Text = "宿舍管理";
            // 
            // 班费管理ToolStripMenuItem
            // 
            this.班费管理ToolStripMenuItem.Name = "班费管理ToolStripMenuItem";
            this.班费管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.班费管理ToolStripMenuItem.Text = "班费管理";
            // 
            // FrmEmpSysMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmEmpSysMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新睿学院学员管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEmpSysMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加学员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询学员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考勤管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 宿舍管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班费管理ToolStripMenuItem;
    }
}

