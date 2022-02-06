using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 点餐系统
{
    public partial class Login_07 : Form
    {
        public Login_07()
        {
            InitializeComponent();
        }
        NET net = new NET();
        string sql;
        private void Login_07_Load(object sender, EventArgs e)
        {
            radioButton2.Visible = false;
            if (Register_00.start == "管理员")
            {
                radioButton2.Visible = true;
            }
            else
            {
                radioButton2.Visible = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (not_null())
            {
                if (Register_00.start == "普通员")
                {
                    if (textBox2.Text.Trim() == textBox3.Text.Trim())
                    {
                        if (radioButton1.Checked == true)
                        {
                            sql = string.Format("insert into User_06 values('{0}','{1}')", textBox1.Text.Trim(), textBox3.Text.Trim());
                            if (net.Execute(sql) > 0)
                            {
                                MessageBox.Show("添加成功", "系统提示");
                                if (Register_00.start == "普通员")
                                {
                                    if (MessageBox.Show("要返回登录界面吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                    {
                                        Register_00 register = new Register_00();
                                        register.ShowDialog();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("添加失败", "系统提示");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("两次输入密码错误", "系统提示");
                    }
                }
                else if (Register_00.start == "管理员")
                {
                    if (radioButton2.Checked == true)
                    {
                        sql = string.Format("insert into Adm_07 values('{0}', '{1}')", textBox1.Text.Trim(), textBox3.Text.Trim());
                        if (net.Execute(sql) > 0)
                        {
                            MessageBox.Show("添加成功", "系统提示");
                        }
                        else
                        {
                            MessageBox.Show("添加失败", "系统提示");
                        }
                    }
                }
            }
        }

        private bool not_null()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请输入用户名", "系统提示");
                return false;
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("请输入密码", "系统提示");
                return false;
            }
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("请再次输入密码", "系统提示");
                return false;
            }
            return true;
        }
    }
}
