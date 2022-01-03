namespace StoreSystem
{
    partial class MainFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.商品管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品类型管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.添加商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品价格管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加商品价格ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品价格信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客服账单管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.账单信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品结算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 商品管理ToolStripMenuItem
            // 
            this.商品管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.商品类型管理ToolStripMenuItem,
            this.商品管理ToolStripMenuItem1});
            this.商品管理ToolStripMenuItem.Image = global::StoreSystem.Properties.Resources.arrow_down1;
            this.商品管理ToolStripMenuItem.Name = "商品管理ToolStripMenuItem";
            this.商品管理ToolStripMenuItem.Size = new System.Drawing.Size(123, 25);
            this.商品管理ToolStripMenuItem.Text = "商品管理(&A)";
            // 
            // 商品类型管理ToolStripMenuItem
            // 
            this.商品类型管理ToolStripMenuItem.Image = global::StoreSystem.Properties.Resources.eraser;
            this.商品类型管理ToolStripMenuItem.Name = "商品类型管理ToolStripMenuItem";
            this.商品类型管理ToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.商品类型管理ToolStripMenuItem.Text = "商品类型管理(&G)";
            this.商品类型管理ToolStripMenuItem.Click += new System.EventHandler(this.商品类型管理ToolStripMenuItem_Click);
            // 
            // 商品管理ToolStripMenuItem1
            // 
            this.商品管理ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加商品ToolStripMenuItem,
            this.商品信息维护ToolStripMenuItem});
            this.商品管理ToolStripMenuItem1.Image = global::StoreSystem.Properties.Resources.forward;
            this.商品管理ToolStripMenuItem1.Name = "商品管理ToolStripMenuItem1";
            this.商品管理ToolStripMenuItem1.Size = new System.Drawing.Size(198, 26);
            this.商品管理ToolStripMenuItem1.Text = "商品管理(&H)";
            // 
            // 添加商品ToolStripMenuItem
            // 
            this.添加商品ToolStripMenuItem.Image = global::StoreSystem.Properties.Resources.tag_white;
            this.添加商品ToolStripMenuItem.Name = "添加商品ToolStripMenuItem";
            this.添加商品ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.添加商品ToolStripMenuItem.Text = "添加商品(&I)";
            this.添加商品ToolStripMenuItem.Click += new System.EventHandler(this.添加商品ToolStripMenuItem_Click);
            // 
            // 商品信息维护ToolStripMenuItem
            // 
            this.商品信息维护ToolStripMenuItem.Image = global::StoreSystem.Properties.Resources.wizard;
            this.商品信息维护ToolStripMenuItem.Name = "商品信息维护ToolStripMenuItem";
            this.商品信息维护ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.商品信息维护ToolStripMenuItem.Text = "商品信息维护(&J)";
            this.商品信息维护ToolStripMenuItem.Click += new System.EventHandler(this.商品信息维护ToolStripMenuItem_Click);
            // 
            // 商品价格管理ToolStripMenuItem
            // 
            this.商品价格管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加商品价格ToolStripMenuItem,
            this.商品价格信息维护ToolStripMenuItem});
            this.商品价格管理ToolStripMenuItem.Image = global::StoreSystem.Properties.Resources.trash_box_21;
            this.商品价格管理ToolStripMenuItem.Name = "商品价格管理ToolStripMenuItem";
            this.商品价格管理ToolStripMenuItem.Size = new System.Drawing.Size(154, 25);
            this.商品价格管理ToolStripMenuItem.Text = "商品价格管理(&B)";
            // 
            // 添加商品价格ToolStripMenuItem
            // 
            this.添加商品价格ToolStripMenuItem.Image = global::StoreSystem.Properties.Resources.shopping_cart1;
            this.添加商品价格ToolStripMenuItem.Name = "添加商品价格ToolStripMenuItem";
            this.添加商品价格ToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.添加商品价格ToolStripMenuItem.Text = "添加商品价格(&K)";
            this.添加商品价格ToolStripMenuItem.Click += new System.EventHandler(this.添加商品价格ToolStripMenuItem_Click);
            // 
            // 商品价格信息维护ToolStripMenuItem
            // 
            this.商品价格信息维护ToolStripMenuItem.Image = global::StoreSystem.Properties.Resources.smartphone_2;
            this.商品价格信息维护ToolStripMenuItem.Name = "商品价格信息维护ToolStripMenuItem";
            this.商品价格信息维护ToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.商品价格信息维护ToolStripMenuItem.Text = "商品价格信息维护(&L)";
            this.商品价格信息维护ToolStripMenuItem.Click += new System.EventHandler(this.商品价格信息维护ToolStripMenuItem_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加用户ToolStripMenuItem,
            this.用户信息维护ToolStripMenuItem});
            this.用户管理ToolStripMenuItem.Image = global::StoreSystem.Properties.Resources.flag_mark_blue;
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(123, 25);
            this.用户管理ToolStripMenuItem.Text = "用户管理(&C)";
            // 
            // 添加用户ToolStripMenuItem
            // 
            this.添加用户ToolStripMenuItem.Image = global::StoreSystem.Properties.Resources.user_friend1;
            this.添加用户ToolStripMenuItem.Name = "添加用户ToolStripMenuItem";
            this.添加用户ToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.添加用户ToolStripMenuItem.Text = "添加用户(&M)";
            this.添加用户ToolStripMenuItem.Click += new System.EventHandler(this.添加用户ToolStripMenuItem_Click);
            // 
            // 用户信息维护ToolStripMenuItem
            // 
            this.用户信息维护ToolStripMenuItem.Image = global::StoreSystem.Properties.Resources.computer_monitor;
            this.用户信息维护ToolStripMenuItem.Name = "用户信息维护ToolStripMenuItem";
            this.用户信息维护ToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.用户信息维护ToolStripMenuItem.Text = "用户信息维护(&N)";
            this.用户信息维护ToolStripMenuItem.Click += new System.EventHandler(this.用户信息维护ToolStripMenuItem_Click);
            // 
            // 客服账单管理ToolStripMenuItem
            // 
            this.客服账单管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.账单信息维护ToolStripMenuItem,
            this.商品结算ToolStripMenuItem});
            this.客服账单管理ToolStripMenuItem.Image = global::StoreSystem.Properties.Resources.credit_card;
            this.客服账单管理ToolStripMenuItem.Name = "客服账单管理ToolStripMenuItem";
            this.客服账单管理ToolStripMenuItem.Size = new System.Drawing.Size(156, 25);
            this.客服账单管理ToolStripMenuItem.Text = "客服账单管理(&D)";
            // 
            // 账单信息维护ToolStripMenuItem
            // 
            this.账单信息维护ToolStripMenuItem.Image = global::StoreSystem.Properties.Resources.opened1;
            this.账单信息维护ToolStripMenuItem.Name = "账单信息维护ToolStripMenuItem";
            this.账单信息维护ToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.账单信息维护ToolStripMenuItem.Text = "账单信息维护(&O)";
            this.账单信息维护ToolStripMenuItem.Click += new System.EventHandler(this.账单信息维护ToolStripMenuItem_Click);
            // 
            // 商品结算ToolStripMenuItem
            // 
            this.商品结算ToolStripMenuItem.Image = global::StoreSystem.Properties.Resources.bag1;
            this.商品结算ToolStripMenuItem.Name = "商品结算ToolStripMenuItem";
            this.商品结算ToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.商品结算ToolStripMenuItem.Text = "商品结算(&P)";
            this.商品结算ToolStripMenuItem.Click += new System.EventHandler(this.商品结算ToolStripMenuItem_Click);
            // 
            // 帮助文档ToolStripMenuItem
            // 
            this.帮助文档ToolStripMenuItem.Image = global::StoreSystem.Properties.Resources.help;
            this.帮助文档ToolStripMenuItem.Name = "帮助文档ToolStripMenuItem";
            this.帮助文档ToolStripMenuItem.Size = new System.Drawing.Size(121, 25);
            this.帮助文档ToolStripMenuItem.Text = "帮助文档(&E)";
            this.帮助文档ToolStripMenuItem.Click += new System.EventHandler(this.帮助文档ToolStripMenuItem_Click);
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出系统XToolStripMenuItem});
            this.系统设置ToolStripMenuItem.Image = global::StoreSystem.Properties.Resources.options;
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(121, 25);
            this.系统设置ToolStripMenuItem.Text = "系统设置(&F)";
            // 
            // 退出系统XToolStripMenuItem
            // 
            this.退出系统XToolStripMenuItem.Image = global::StoreSystem.Properties.Resources.options_21;
            this.退出系统XToolStripMenuItem.Name = "退出系统XToolStripMenuItem";
            this.退出系统XToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.退出系统XToolStripMenuItem.Text = "退出系统(&X)";
            this.退出系统XToolStripMenuItem.Click += new System.EventHandler(this.退出系统XToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.商品管理ToolStripMenuItem,
            this.商品价格管理ToolStripMenuItem,
            this.用户管理ToolStripMenuItem,
            this.客服账单管理ToolStripMenuItem,
            this.系统设置ToolStripMenuItem,
            this.帮助文档ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 437);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(906, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "当前用户：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel3.Text = "当前时间：";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(906, 459);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrame";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrame_FormClosing);
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem 商品管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品类型管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 添加商品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品价格管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加商品价格ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品价格信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客服账单管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 账单信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品结算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助文档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripMenuItem 退出系统XToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

