
namespace 员工管理系统
{
    partial class frmStaffHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffHomepage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统设置SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工管理MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加员工ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部门管理AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部门列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加部门ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我们ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统设置SToolStripMenuItem,
            this.员工管理MToolStripMenuItem,
            this.部门管理AToolStripMenuItem,
            this.帮助SToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统设置SToolStripMenuItem
            // 
            this.系统设置SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.系统设置SToolStripMenuItem.Image = global::员工管理系统.Properties.Resources.home;
            this.系统设置SToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.系统设置SToolStripMenuItem.Name = "系统设置SToolStripMenuItem";
            this.系统设置SToolStripMenuItem.Size = new System.Drawing.Size(99, 21);
            this.系统设置SToolStripMenuItem.Text = "系统设置(&S)";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // 员工管理MToolStripMenuItem
            // 
            this.员工管理MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工列表ToolStripMenuItem,
            this.添加员工ToolStripMenuItem});
            this.员工管理MToolStripMenuItem.Image = global::员工管理系统.Properties.Resources.user_friend;
            this.员工管理MToolStripMenuItem.Name = "员工管理MToolStripMenuItem";
            this.员工管理MToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.员工管理MToolStripMenuItem.Text = "员工管理(&M)";
            this.员工管理MToolStripMenuItem.Click += new System.EventHandler(this.员工管理MToolStripMenuItem_Click);
            // 
            // 员工列表ToolStripMenuItem
            // 
            this.员工列表ToolStripMenuItem.Name = "员工列表ToolStripMenuItem";
            this.员工列表ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.员工列表ToolStripMenuItem.Text = "员工列表";
            this.员工列表ToolStripMenuItem.Click += new System.EventHandler(this.员工列表ToolStripMenuItem_Click);
            // 
            // 添加员工ToolStripMenuItem
            // 
            this.添加员工ToolStripMenuItem.Name = "添加员工ToolStripMenuItem";
            this.添加员工ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加员工ToolStripMenuItem.Text = "添加员工";
            this.添加员工ToolStripMenuItem.Click += new System.EventHandler(this.添加员工ToolStripMenuItem_Click);
            // 
            // 部门管理AToolStripMenuItem
            // 
            this.部门管理AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.部门列表ToolStripMenuItem,
            this.添加部门ToolStripMenuItem});
            this.部门管理AToolStripMenuItem.Image = global::员工管理系统.Properties.Resources.trash_box_2;
            this.部门管理AToolStripMenuItem.Name = "部门管理AToolStripMenuItem";
            this.部门管理AToolStripMenuItem.Size = new System.Drawing.Size(101, 21);
            this.部门管理AToolStripMenuItem.Text = "部门管理(&D)";
            // 
            // 部门列表ToolStripMenuItem
            // 
            this.部门列表ToolStripMenuItem.Name = "部门列表ToolStripMenuItem";
            this.部门列表ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.部门列表ToolStripMenuItem.Text = "部门列表";
            this.部门列表ToolStripMenuItem.Click += new System.EventHandler(this.部门列表ToolStripMenuItem_Click);
            // 
            // 添加部门ToolStripMenuItem
            // 
            this.添加部门ToolStripMenuItem.Name = "添加部门ToolStripMenuItem";
            this.添加部门ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加部门ToolStripMenuItem.Text = "添加部门";
            this.添加部门ToolStripMenuItem.Click += new System.EventHandler(this.添加部门ToolStripMenuItem_Click);
            // 
            // 帮助SToolStripMenuItem
            // 
            this.帮助SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于我们ToolStripMenuItem});
            this.帮助SToolStripMenuItem.Image = global::员工管理系统.Properties.Resources.lamp_active;
            this.帮助SToolStripMenuItem.Name = "帮助SToolStripMenuItem";
            this.帮助SToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.帮助SToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于我们ToolStripMenuItem
            // 
            this.关于我们ToolStripMenuItem.Name = "关于我们ToolStripMenuItem";
            this.关于我们ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.关于我们ToolStripMenuItem.Text = "关于我们(&U)";
            this.关于我们ToolStripMenuItem.Click += new System.EventHandler(this.关于我们ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::员工管理系统.Properties.Resources.friends_group;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton1.Text = "员工查询";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = global::员工管理系统.Properties.Resources.computer_monitor;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(72, 22);
            this.toolStripLabel1.Text = "部门查询";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Image = global::员工管理系统.Properties.Resources.close_delete;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(72, 22);
            this.toolStripLabel2.Text = "退出系统";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Image = global::员工管理系统.Properties.Resources.close_delete_2;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(108, 22);
            this.toolStripLabel3.Text = "关闭所有子窗体";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // frmStaffHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStaffHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工管理主界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStaffHomepage_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统设置SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工管理MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部门管理AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助SToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加员工ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部门列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加部门ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于我们ToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
    }
}