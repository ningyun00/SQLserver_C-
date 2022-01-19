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
    public partial class LoginPage_01 : Form
    {
        public LoginPage_01()
        {
            InitializeComponent();
        }

        /// <summary>
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
        /// 最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要关闭？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {//判断是否关闭
                Application.Exit();
                //关闭
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nun_null())
                {
                    if (radioButton1.Checked == true)
                    {
                        sql = string.Format("select ID,Name,Password from CommonUser_01 where Name = '{0}'  and Password = '{1}'", textBox1.Text.Trim(), textBox2.Text.Trim());
                        IDataReader idr = net.Sdr(sql);
                        if (idr.Read())
                        {
                            MessageBox.Show("登陆成功", "系统提示");
                            Class1.state = "普通用户";
                            Class1.name = textBox1.Text.Trim();
                            MainInterface_03 mainInterface_03 = new MainInterface_03();
                            mainInterface_03.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("登陆失败", "系统提示");
                        }
                    }
                    else if (radioButton2.Checked == true)
                    {
                        sql = string.Format("select ID,Name,Password from Administrator_02 where Name = '{0}'  and Password = '{1}'", textBox1.Text.Trim(), textBox2.Text.Trim());
                        IDataReader idr = net.Sdr(sql);
                        if (idr.Read())
                        {
                            MessageBox.Show("登陆成功", "系统提示");
                            Class1.state = "管理员";
                            Class1.name = textBox1.Text.Trim();
                            MainInterface_03 mainInterface_03 = new MainInterface_03();
                            mainInterface_03.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("登陆失败", "系统提示");
                        }
                    }
                    else
                    {
                        MessageBox.Show("请选则管理权限", "系统提示");
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

        private bool nun_null()
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入用户名", "系统提示");
                return false;
            }
            if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入密码", "系统提示");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否清除", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrdinaryUserRegister_02 ordinaryUserRegister_02 = new OrdinaryUserRegister_02();
            ordinaryUserRegister_02.Show();
            this.Hide();
        }

        #region 窗体移动
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.SizeAll;
            mouseAtX = e.X;
            mouseAtY = e.Y;
            imd = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (imd)
            {
                Left = MousePosition.X - mouseAtX;
                Top = MousePosition.Y - mouseAtY;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
            imd = false;
        }
        #endregion

        private void radioButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nun_null())
                {
                    if (radioButton1.Checked == true)
                    {
                        sql = string.Format("select ID,Name,Password from CommonUser_01 where Name = '{0}'", textBox1.Text.Trim());
                        IDataReader idr = net.Sdr(sql);
                        if (idr.Read())
                        {//找到该用户
                        }
                        else
                        {
                            MessageBox.Show("未找到该用户", "系统提示");
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

        private void radioButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (nun_null())
                {
                    if (radioButton2.Checked == true)
                    {
                        sql = string.Format("select ID,Name,Password from Administrator_02 where Name = '{0}'", textBox1.Text.Trim());
                        IDataReader idr = net.Sdr(sql);
                        if (idr.Read())
                        {//找到该用户
                        }
                        else
                        {
                            MessageBox.Show("未找到该用户", "系统提示");
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (MessageBox.Show("是否要关闭？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {//判断是否关闭
                    Application.Exit();
                    //关闭
                }
                else
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "来自系统提示");
            }
        }
    }
}