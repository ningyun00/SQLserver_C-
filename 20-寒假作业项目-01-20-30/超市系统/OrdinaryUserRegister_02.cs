using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 超市系统
{
    public partial class OrdinaryUserRegister_02 : Form
    {
        public OrdinaryUserRegister_02()
        {
            InitializeComponent();
        }  /// <summary>
           /// 鼠标按下时的x坐标
           /// </summary>
        private int mouseAtX;

        /// <summary>
        /// 鼠标按下时的Y坐标
        /// </summary>
        private int mouseAtY;

        /// <summary>
        /// 判断鼠标是否在里面
        /// </summary>
        private bool imd = false;

        /// <summary>
        /// 引入类
        /// </summary>
        NET net = new NET();

        /// <summary>
        /// 数据库执行语句
        /// </summary>
        string sql = null;

        /// <summary>
        /// 实例化登录窗体
        /// </summary>
        LoginPage_01 loginPage = new LoginPage_01();

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要关闭？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {//判断是否关闭
                Application.Exit();
                //关闭
            }
        }

        private void OrdinaryUserRegister_02_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.SizeAll;
            mouseAtX = e.X;
            mouseAtY = e.Y;
            imd = true;
        }

        private void OrdinaryUserRegister_02_MouseMove(object sender, MouseEventArgs e)
        {
            if (imd)
            {
                Left = MousePosition.X - mouseAtX;
                Top = MousePosition.Y - mouseAtY;
            }
        }

        private void OrdinaryUserRegister_02_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
            imd = false;
        }
        string name;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                selectName();
                if (nun_null())
                {
                    if (name == textBox1.Text.Trim())
                    {
                        MessageBox.Show("已存在改用户名");
                    }
                    else
                    {
                        if (textBox2.Text.Trim() == textBox3.Text.Trim())
                        {
                            sql = string.Format("insert into CommonUser_01 values('{0}','{1}')", textBox1.Text.Trim(), textBox3.Text.Trim());
                            if (net.Execute(sql) > 0)
                            {
                                MessageBox.Show("注册成功", "系统提示");
                                if (MessageBox.Show("是否返回登录界面", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                {
                                    loginPage.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("注册失败", "系统提示");
                            }
                        }
                        else
                        {
                            MessageBox.Show("两次输入密码不同");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "来自系统提示");
            }
            finally
            {
                net.NETClose();
            }
        }

        private void selectName()
        {
            try
            {
                sql = string.Format("select ID,Name,Password from CommonUser_01 where Name = '{0}'", textBox1.Text.Trim());
                IDataReader idr = net.Sdr(sql);
                if (idr.Read())
                {
                    name = idr["Name"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "来自系统提示");
            }
            finally
            {
                net.NETClose();
            }
        }

        private bool nun_null()
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入昵称", "系统提示");
                return false;
            }
            if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入第一次密码", "系统提示");
                return false;
            }
            if (textBox3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入验证次密码", "系统提示");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("\t是(退出系统)\n\t否(返回登录)\n\t取消", "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (dr == DialogResult.No)
                {
                    loginPage.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "来自系统提示");
            }
        }
    }
}