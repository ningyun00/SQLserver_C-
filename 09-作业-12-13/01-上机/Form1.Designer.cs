
namespace _01_上机
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
            this.gub_Add = new System.Windows.Forms.GroupBox();
            this.cmb_Add_Stu_Age = new System.Windows.Forms.ComboBox();
            this.rbt_Add_Stu_Sex_Woman = new System.Windows.Forms.RadioButton();
            this.rbt_Add_Stu_Sex_Man = new System.Windows.Forms.RadioButton();
            this.Add_Submit = new System.Windows.Forms.Button();
            this.txtb_Add_Stu_Name = new System.Windows.Forms.TextBox();
            this.txtb_Add_Stu_Id = new System.Windows.Forms.TextBox();
            this.lbl_Add_Stu_Age = new System.Windows.Forms.Label();
            this.lbl_Add_Stu_Sex = new System.Windows.Forms.Label();
            this.lbl_Add_Stu_Name = new System.Windows.Forms.Label();
            this.lbl_Add_Stu_Id = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Amend_Amend = new System.Windows.Forms.Label();
            this.lbl_Amend_Reason = new System.Windows.Forms.Label();
            this.cmb_Amend_Stu_Age = new System.Windows.Forms.ComboBox();
            this.rbt_Amend_Stu_Sex_Woman = new System.Windows.Forms.RadioButton();
            this.rbt_Amend_Stu_Sex_Man = new System.Windows.Forms.RadioButton();
            this.Amend_Submit = new System.Windows.Forms.Button();
            this.txtb_Amend_Stu_Id = new System.Windows.Forms.TextBox();
            this.lbl_Amend_Stu_Age = new System.Windows.Forms.Label();
            this.lbl_Amend_Stu_Sex = new System.Windows.Forms.Label();
            this.lbl_Amend_Stu_Id = new System.Windows.Forms.Label();
            this.gub_Delete = new System.Windows.Forms.GroupBox();
            this.btn_Delete_Name = new System.Windows.Forms.Button();
            this.btn_Delete_Id = new System.Windows.Forms.Button();
            this.txtb_Delete_Stu_Id = new System.Windows.Forms.TextBox();
            this.txtb_Delete_Stu_Name = new System.Windows.Forms.TextBox();
            this.lbl_Delete_Stu_Id = new System.Windows.Forms.Label();
            this.lbl_Delete_Stu_Name = new System.Windows.Forms.Label();
            this.gub_Add.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gub_Delete.SuspendLayout();
            this.SuspendLayout();
            // 
            // gub_Add
            // 
            this.gub_Add.Controls.Add(this.cmb_Add_Stu_Age);
            this.gub_Add.Controls.Add(this.rbt_Add_Stu_Sex_Woman);
            this.gub_Add.Controls.Add(this.rbt_Add_Stu_Sex_Man);
            this.gub_Add.Controls.Add(this.Add_Submit);
            this.gub_Add.Controls.Add(this.txtb_Add_Stu_Name);
            this.gub_Add.Controls.Add(this.txtb_Add_Stu_Id);
            this.gub_Add.Controls.Add(this.lbl_Add_Stu_Age);
            this.gub_Add.Controls.Add(this.lbl_Add_Stu_Sex);
            this.gub_Add.Controls.Add(this.lbl_Add_Stu_Name);
            this.gub_Add.Controls.Add(this.lbl_Add_Stu_Id);
            this.gub_Add.ForeColor = System.Drawing.Color.Salmon;
            this.gub_Add.Location = new System.Drawing.Point(12, 12);
            this.gub_Add.Name = "gub_Add";
            this.gub_Add.Size = new System.Drawing.Size(229, 386);
            this.gub_Add.TabIndex = 0;
            this.gub_Add.TabStop = false;
            this.gub_Add.Text = "添加学员信息";
            // 
            // cmb_Add_Stu_Age
            // 
            this.cmb_Add_Stu_Age.FormattingEnabled = true;
            this.cmb_Add_Stu_Age.Location = new System.Drawing.Point(115, 258);
            this.cmb_Add_Stu_Age.Name = "cmb_Add_Stu_Age";
            this.cmb_Add_Stu_Age.Size = new System.Drawing.Size(100, 20);
            this.cmb_Add_Stu_Age.TabIndex = 3;
            // 
            // rbt_Add_Stu_Sex_Woman
            // 
            this.rbt_Add_Stu_Sex_Woman.AutoSize = true;
            this.rbt_Add_Stu_Sex_Woman.Location = new System.Drawing.Point(180, 182);
            this.rbt_Add_Stu_Sex_Woman.Name = "rbt_Add_Stu_Sex_Woman";
            this.rbt_Add_Stu_Sex_Woman.Size = new System.Drawing.Size(35, 16);
            this.rbt_Add_Stu_Sex_Woman.TabIndex = 1;
            this.rbt_Add_Stu_Sex_Woman.Text = "女";
            this.rbt_Add_Stu_Sex_Woman.UseVisualStyleBackColor = true;
            // 
            // rbt_Add_Stu_Sex_Man
            // 
            this.rbt_Add_Stu_Sex_Man.AutoSize = true;
            this.rbt_Add_Stu_Sex_Man.Checked = true;
            this.rbt_Add_Stu_Sex_Man.Location = new System.Drawing.Point(115, 183);
            this.rbt_Add_Stu_Sex_Man.Name = "rbt_Add_Stu_Sex_Man";
            this.rbt_Add_Stu_Sex_Man.Size = new System.Drawing.Size(35, 16);
            this.rbt_Add_Stu_Sex_Man.TabIndex = 1;
            this.rbt_Add_Stu_Sex_Man.TabStop = true;
            this.rbt_Add_Stu_Sex_Man.Text = "男";
            this.rbt_Add_Stu_Sex_Man.UseVisualStyleBackColor = true;
            // 
            // Add_Submit
            // 
            this.Add_Submit.Location = new System.Drawing.Point(50, 326);
            this.Add_Submit.Name = "Add_Submit";
            this.Add_Submit.Size = new System.Drawing.Size(100, 30);
            this.Add_Submit.TabIndex = 2;
            this.Add_Submit.Text = "提交";
            this.Add_Submit.UseVisualStyleBackColor = true;
            this.Add_Submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // txtb_Add_Stu_Name
            // 
            this.txtb_Add_Stu_Name.Location = new System.Drawing.Point(115, 114);
            this.txtb_Add_Stu_Name.Name = "txtb_Add_Stu_Name";
            this.txtb_Add_Stu_Name.Size = new System.Drawing.Size(100, 21);
            this.txtb_Add_Stu_Name.TabIndex = 1;
            // 
            // txtb_Add_Stu_Id
            // 
            this.txtb_Add_Stu_Id.Location = new System.Drawing.Point(115, 52);
            this.txtb_Add_Stu_Id.Name = "txtb_Add_Stu_Id";
            this.txtb_Add_Stu_Id.Size = new System.Drawing.Size(100, 21);
            this.txtb_Add_Stu_Id.TabIndex = 1;
            // 
            // lbl_Add_Stu_Age
            // 
            this.lbl_Add_Stu_Age.AutoSize = true;
            this.lbl_Add_Stu_Age.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_Add_Stu_Age.ForeColor = System.Drawing.Color.Red;
            this.lbl_Add_Stu_Age.Location = new System.Drawing.Point(20, 258);
            this.lbl_Add_Stu_Age.Name = "lbl_Add_Stu_Age";
            this.lbl_Add_Stu_Age.Size = new System.Drawing.Size(77, 14);
            this.lbl_Add_Stu_Age.TabIndex = 0;
            this.lbl_Add_Stu_Age.Text = "学员年龄：";
            // 
            // lbl_Add_Stu_Sex
            // 
            this.lbl_Add_Stu_Sex.AutoSize = true;
            this.lbl_Add_Stu_Sex.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_Add_Stu_Sex.ForeColor = System.Drawing.Color.Red;
            this.lbl_Add_Stu_Sex.Location = new System.Drawing.Point(20, 184);
            this.lbl_Add_Stu_Sex.Name = "lbl_Add_Stu_Sex";
            this.lbl_Add_Stu_Sex.Size = new System.Drawing.Size(77, 14);
            this.lbl_Add_Stu_Sex.TabIndex = 0;
            this.lbl_Add_Stu_Sex.Text = "学员性别：";
            // 
            // lbl_Add_Stu_Name
            // 
            this.lbl_Add_Stu_Name.AutoSize = true;
            this.lbl_Add_Stu_Name.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_Add_Stu_Name.ForeColor = System.Drawing.Color.Red;
            this.lbl_Add_Stu_Name.Location = new System.Drawing.Point(20, 116);
            this.lbl_Add_Stu_Name.Name = "lbl_Add_Stu_Name";
            this.lbl_Add_Stu_Name.Size = new System.Drawing.Size(77, 14);
            this.lbl_Add_Stu_Name.TabIndex = 0;
            this.lbl_Add_Stu_Name.Text = "学员姓名：";
            // 
            // lbl_Add_Stu_Id
            // 
            this.lbl_Add_Stu_Id.AutoSize = true;
            this.lbl_Add_Stu_Id.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_Add_Stu_Id.ForeColor = System.Drawing.Color.Red;
            this.lbl_Add_Stu_Id.Location = new System.Drawing.Point(20, 54);
            this.lbl_Add_Stu_Id.Name = "lbl_Add_Stu_Id";
            this.lbl_Add_Stu_Id.Size = new System.Drawing.Size(77, 14);
            this.lbl_Add_Stu_Id.TabIndex = 0;
            this.lbl_Add_Stu_Id.Text = "学员编号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Amend_Amend);
            this.groupBox2.Controls.Add(this.lbl_Amend_Reason);
            this.groupBox2.Controls.Add(this.cmb_Amend_Stu_Age);
            this.groupBox2.Controls.Add(this.rbt_Amend_Stu_Sex_Woman);
            this.groupBox2.Controls.Add(this.rbt_Amend_Stu_Sex_Man);
            this.groupBox2.Controls.Add(this.Amend_Submit);
            this.groupBox2.Controls.Add(this.txtb_Amend_Stu_Id);
            this.groupBox2.Controls.Add(this.lbl_Amend_Stu_Age);
            this.groupBox2.Controls.Add(this.lbl_Amend_Stu_Sex);
            this.groupBox2.Controls.Add(this.lbl_Amend_Stu_Id);
            this.groupBox2.ForeColor = System.Drawing.Color.Salmon;
            this.groupBox2.Location = new System.Drawing.Point(271, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 231);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "修改学员信息";
            // 
            // lbl_Amend_Amend
            // 
            this.lbl_Amend_Amend.AutoSize = true;
            this.lbl_Amend_Amend.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_Amend_Amend.ForeColor = System.Drawing.Color.Red;
            this.lbl_Amend_Amend.Location = new System.Drawing.Point(24, 86);
            this.lbl_Amend_Amend.Name = "lbl_Amend_Amend";
            this.lbl_Amend_Amend.Size = new System.Drawing.Size(35, 14);
            this.lbl_Amend_Amend.TabIndex = 4;
            this.lbl_Amend_Amend.Text = "修改";
            // 
            // lbl_Amend_Reason
            // 
            this.lbl_Amend_Reason.AutoSize = true;
            this.lbl_Amend_Reason.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_Amend_Reason.ForeColor = System.Drawing.Color.Red;
            this.lbl_Amend_Reason.Location = new System.Drawing.Point(24, 36);
            this.lbl_Amend_Reason.Name = "lbl_Amend_Reason";
            this.lbl_Amend_Reason.Size = new System.Drawing.Size(35, 14);
            this.lbl_Amend_Reason.TabIndex = 4;
            this.lbl_Amend_Reason.Text = "根据";
            // 
            // cmb_Amend_Stu_Age
            // 
            this.cmb_Amend_Stu_Age.FormattingEnabled = true;
            this.cmb_Amend_Stu_Age.Location = new System.Drawing.Point(170, 136);
            this.cmb_Amend_Stu_Age.Name = "cmb_Amend_Stu_Age";
            this.cmb_Amend_Stu_Age.Size = new System.Drawing.Size(100, 20);
            this.cmb_Amend_Stu_Age.TabIndex = 3;
            // 
            // rbt_Amend_Stu_Sex_Woman
            // 
            this.rbt_Amend_Stu_Sex_Woman.AutoSize = true;
            this.rbt_Amend_Stu_Sex_Woman.Location = new System.Drawing.Point(235, 86);
            this.rbt_Amend_Stu_Sex_Woman.Name = "rbt_Amend_Stu_Sex_Woman";
            this.rbt_Amend_Stu_Sex_Woman.Size = new System.Drawing.Size(35, 16);
            this.rbt_Amend_Stu_Sex_Woman.TabIndex = 1;
            this.rbt_Amend_Stu_Sex_Woman.Text = "女";
            this.rbt_Amend_Stu_Sex_Woman.UseVisualStyleBackColor = true;
            // 
            // rbt_Amend_Stu_Sex_Man
            // 
            this.rbt_Amend_Stu_Sex_Man.AutoSize = true;
            this.rbt_Amend_Stu_Sex_Man.Checked = true;
            this.rbt_Amend_Stu_Sex_Man.Location = new System.Drawing.Point(170, 86);
            this.rbt_Amend_Stu_Sex_Man.Name = "rbt_Amend_Stu_Sex_Man";
            this.rbt_Amend_Stu_Sex_Man.Size = new System.Drawing.Size(35, 16);
            this.rbt_Amend_Stu_Sex_Man.TabIndex = 1;
            this.rbt_Amend_Stu_Sex_Man.TabStop = true;
            this.rbt_Amend_Stu_Sex_Man.Text = "男";
            this.rbt_Amend_Stu_Sex_Man.UseVisualStyleBackColor = true;
            // 
            // Amend_Submit
            // 
            this.Amend_Submit.Location = new System.Drawing.Point(122, 176);
            this.Amend_Submit.Name = "Amend_Submit";
            this.Amend_Submit.Size = new System.Drawing.Size(100, 30);
            this.Amend_Submit.TabIndex = 2;
            this.Amend_Submit.Text = "修改";
            this.Amend_Submit.UseVisualStyleBackColor = true;
            this.Amend_Submit.Click += new System.EventHandler(this.Amend_Submit_Click);
            // 
            // txtb_Amend_Stu_Id
            // 
            this.txtb_Amend_Stu_Id.Location = new System.Drawing.Point(170, 36);
            this.txtb_Amend_Stu_Id.Name = "txtb_Amend_Stu_Id";
            this.txtb_Amend_Stu_Id.Size = new System.Drawing.Size(100, 21);
            this.txtb_Amend_Stu_Id.TabIndex = 1;
            // 
            // lbl_Amend_Stu_Age
            // 
            this.lbl_Amend_Stu_Age.AutoSize = true;
            this.lbl_Amend_Stu_Age.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_Amend_Stu_Age.ForeColor = System.Drawing.Color.Red;
            this.lbl_Amend_Stu_Age.Location = new System.Drawing.Point(71, 136);
            this.lbl_Amend_Stu_Age.Name = "lbl_Amend_Stu_Age";
            this.lbl_Amend_Stu_Age.Size = new System.Drawing.Size(77, 14);
            this.lbl_Amend_Stu_Age.TabIndex = 0;
            this.lbl_Amend_Stu_Age.Text = "学员年龄：";
            // 
            // lbl_Amend_Stu_Sex
            // 
            this.lbl_Amend_Stu_Sex.AutoSize = true;
            this.lbl_Amend_Stu_Sex.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_Amend_Stu_Sex.ForeColor = System.Drawing.Color.Red;
            this.lbl_Amend_Stu_Sex.Location = new System.Drawing.Point(71, 86);
            this.lbl_Amend_Stu_Sex.Name = "lbl_Amend_Stu_Sex";
            this.lbl_Amend_Stu_Sex.Size = new System.Drawing.Size(77, 14);
            this.lbl_Amend_Stu_Sex.TabIndex = 0;
            this.lbl_Amend_Stu_Sex.Text = "学员性别：";
            // 
            // lbl_Amend_Stu_Id
            // 
            this.lbl_Amend_Stu_Id.AutoSize = true;
            this.lbl_Amend_Stu_Id.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_Amend_Stu_Id.ForeColor = System.Drawing.Color.Red;
            this.lbl_Amend_Stu_Id.Location = new System.Drawing.Point(71, 36);
            this.lbl_Amend_Stu_Id.Name = "lbl_Amend_Stu_Id";
            this.lbl_Amend_Stu_Id.Size = new System.Drawing.Size(77, 14);
            this.lbl_Amend_Stu_Id.TabIndex = 0;
            this.lbl_Amend_Stu_Id.Text = "学员编号：";
            // 
            // gub_Delete
            // 
            this.gub_Delete.Controls.Add(this.btn_Delete_Name);
            this.gub_Delete.Controls.Add(this.btn_Delete_Id);
            this.gub_Delete.Controls.Add(this.txtb_Delete_Stu_Id);
            this.gub_Delete.Controls.Add(this.txtb_Delete_Stu_Name);
            this.gub_Delete.Controls.Add(this.lbl_Delete_Stu_Id);
            this.gub_Delete.Controls.Add(this.lbl_Delete_Stu_Name);
            this.gub_Delete.ForeColor = System.Drawing.Color.Salmon;
            this.gub_Delete.Location = new System.Drawing.Point(271, 270);
            this.gub_Delete.Name = "gub_Delete";
            this.gub_Delete.Size = new System.Drawing.Size(289, 128);
            this.gub_Delete.TabIndex = 0;
            this.gub_Delete.TabStop = false;
            this.gub_Delete.Text = "删除学员信息";
            // 
            // btn_Delete_Name
            // 
            this.btn_Delete_Name.Location = new System.Drawing.Point(211, 81);
            this.btn_Delete_Name.Name = "btn_Delete_Name";
            this.btn_Delete_Name.Size = new System.Drawing.Size(59, 21);
            this.btn_Delete_Name.TabIndex = 2;
            this.btn_Delete_Name.Text = "删除";
            this.btn_Delete_Name.UseVisualStyleBackColor = true;
            // 
            // btn_Delete_Id
            // 
            this.btn_Delete_Id.Location = new System.Drawing.Point(211, 34);
            this.btn_Delete_Id.Name = "btn_Delete_Id";
            this.btn_Delete_Id.Size = new System.Drawing.Size(59, 21);
            this.btn_Delete_Id.TabIndex = 2;
            this.btn_Delete_Id.Text = "删除";
            this.btn_Delete_Id.UseVisualStyleBackColor = true;
            this.btn_Delete_Id.Click += new System.EventHandler(this.btn_Delete_Id_Click);
            // 
            // txtb_Delete_Stu_Id
            // 
            this.txtb_Delete_Stu_Id.Location = new System.Drawing.Point(105, 35);
            this.txtb_Delete_Stu_Id.Name = "txtb_Delete_Stu_Id";
            this.txtb_Delete_Stu_Id.Size = new System.Drawing.Size(100, 21);
            this.txtb_Delete_Stu_Id.TabIndex = 1;
            // 
            // txtb_Delete_Stu_Name
            // 
            this.txtb_Delete_Stu_Name.Location = new System.Drawing.Point(105, 82);
            this.txtb_Delete_Stu_Name.Name = "txtb_Delete_Stu_Name";
            this.txtb_Delete_Stu_Name.Size = new System.Drawing.Size(100, 21);
            this.txtb_Delete_Stu_Name.TabIndex = 1;
            // 
            // lbl_Delete_Stu_Id
            // 
            this.lbl_Delete_Stu_Id.AutoSize = true;
            this.lbl_Delete_Stu_Id.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_Delete_Stu_Id.ForeColor = System.Drawing.Color.Red;
            this.lbl_Delete_Stu_Id.Location = new System.Drawing.Point(24, 37);
            this.lbl_Delete_Stu_Id.Name = "lbl_Delete_Stu_Id";
            this.lbl_Delete_Stu_Id.Size = new System.Drawing.Size(77, 14);
            this.lbl_Delete_Stu_Id.TabIndex = 0;
            this.lbl_Delete_Stu_Id.Text = "学员编号：";
            // 
            // lbl_Delete_Stu_Name
            // 
            this.lbl_Delete_Stu_Name.AutoSize = true;
            this.lbl_Delete_Stu_Name.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_Delete_Stu_Name.ForeColor = System.Drawing.Color.Red;
            this.lbl_Delete_Stu_Name.Location = new System.Drawing.Point(24, 84);
            this.lbl_Delete_Stu_Name.Name = "lbl_Delete_Stu_Name";
            this.lbl_Delete_Stu_Name.Size = new System.Drawing.Size(77, 14);
            this.lbl_Delete_Stu_Name.TabIndex = 0;
            this.lbl_Delete_Stu_Name.Text = "学员姓名：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 411);
            this.Controls.Add(this.gub_Delete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gub_Add);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gub_Add.ResumeLayout(false);
            this.gub_Add.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gub_Delete.ResumeLayout(false);
            this.gub_Delete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gub_Add;
        private System.Windows.Forms.Label lbl_Add_Stu_Id;
        private System.Windows.Forms.TextBox txtb_Add_Stu_Name;
        private System.Windows.Forms.TextBox txtb_Add_Stu_Id;
        private System.Windows.Forms.Label lbl_Add_Stu_Age;
        private System.Windows.Forms.Label lbl_Add_Stu_Sex;
        private System.Windows.Forms.Label lbl_Add_Stu_Name;
        private System.Windows.Forms.RadioButton rbt_Add_Stu_Sex_Woman;
        private System.Windows.Forms.RadioButton rbt_Add_Stu_Sex_Man;
        private System.Windows.Forms.Button Add_Submit;
        private System.Windows.Forms.ComboBox cmb_Add_Stu_Age;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Amend_Amend;
        private System.Windows.Forms.Label lbl_Amend_Reason;
        private System.Windows.Forms.ComboBox cmb_Amend_Stu_Age;
        private System.Windows.Forms.RadioButton rbt_Amend_Stu_Sex_Woman;
        private System.Windows.Forms.RadioButton rbt_Amend_Stu_Sex_Man;
        private System.Windows.Forms.Button Amend_Submit;
        private System.Windows.Forms.TextBox txtb_Amend_Stu_Id;
        private System.Windows.Forms.Label lbl_Amend_Stu_Age;
        private System.Windows.Forms.Label lbl_Amend_Stu_Sex;
        private System.Windows.Forms.Label lbl_Amend_Stu_Id;
        private System.Windows.Forms.GroupBox gub_Delete;
        private System.Windows.Forms.Button btn_Delete_Id;
        private System.Windows.Forms.TextBox txtb_Delete_Stu_Id;
        private System.Windows.Forms.TextBox txtb_Delete_Stu_Name;
        private System.Windows.Forms.Label lbl_Delete_Stu_Id;
        private System.Windows.Forms.Label lbl_Delete_Stu_Name;
        private System.Windows.Forms.Button btn_Delete_Name;
    }
}

