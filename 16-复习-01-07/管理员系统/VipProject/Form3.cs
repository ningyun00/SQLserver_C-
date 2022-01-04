using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;//引入数据源

namespace VipProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;uid=sa;pwd=123456;database =MembersInfo_DB");
        //连接数据库
        private void Form3_Load(object sender, EventArgs e)
        {//加载
            if (Form2.zhuangtai == "修改")
            {//修改还是添加
                button1.Text = Form2.zhuangtai;
                try
                {//异常处理
                    con.Open();
                    //打开数据库
                    if (con.State == ConnectionState.Open)
                    {//判断是否打开数据库
                        string sql = string.Format("select * from MembersInfo where M_Name='{0}'", Form1.name);
                        //数据库命令
                        SqlCommand com = new SqlCommand(sql, con);
                        //执行命令
                        IDataReader idr = com.ExecuteReader();
                        //阅读器
                        if (idr.Read())
                        {//拿取数据
                            textBox1.Text = idr[1].ToString();
                            textBox2.Text = idr[2].ToString();
                            textBox3.Text = idr[3].ToString();
                            textBox4.Text = idr[4].ToString();
                            textBox5.Text = idr[5].ToString();
                            textBox6.Text = idr[6].ToString();
                        }
                    }
                    else
                    {
                        con.Close();
                    }
                }
                catch (Exception ex)
                {//异常处理提示
                    MessageBox.Show(ex.Message, "来自系统提示");
                }
                finally
                {//关闭
                    con.Close();
                }
            }
            else if (Form2.zhuangtai == "添加")
            {
                button1.Text = Form2.zhuangtai;
                //添加按钮
                Text = "添加VIP用户 ";
                //当前窗体的名称
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//修改
            if (nun_null())
            {//非空判断
                if (Form2.zhuangtai == "修改")
                {//修改
                    DialogResult dr = MessageBox.Show("是否要修改?", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DialogResult.Yes == dr)
                    {
                        try
                        {//异常处理
                            con.Open();
                            //打开数据库
                            if (con.State == ConnectionState.Open)
                            {//判断是否打开
                                string sql = string.Format("update Membersinfo set M_Name = '{0}', M_Pwd = '{1}', M_Sex = '{2}', M_Age = {3}, M_arrdess = '{4}', M_Email = '{5}' where M_Name = '{6}'", textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim(), textBox5.Text.Trim(), textBox6.Text.Trim(), Form1.name);
                                //数据库命令
                                SqlCommand com = new SqlCommand(sql, con);
                                //执行命令
                                if (com.ExecuteNonQuery() > 0)
                                {//受影响的行数
                                    MessageBox.Show("修改成功", "系统提示");
                                }
                                else
                                {
                                    MessageBox.Show("修改失败", "系统提示");
                                }
                            }
                            else
                            {
                                con.Close();
                            }
                        }
                        catch (Exception ex)
                        {//异常处理提示
                            MessageBox.Show(ex.Message, "来自系统提示");
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("修改取消", "系统提示");
                        return;
                    }
                }
                else if (Form2.zhuangtai == "添加")
                {//添加
                    try
                    {//异常处理
                        con.Open();
                        //打开数据库
                        if (con.State == ConnectionState.Open)
                        {//判断是否打开
                            string sql = string.Format("insert into Membersinfo values('{0}','{1}','{2}',{3},'{4}','{5}')", textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim(), textBox5.Text.Trim(), textBox6.Text.Trim());
                            //数据库命令
                            SqlCommand com = new SqlCommand(sql, con);
                            //执行命令
                            if (com.ExecuteNonQuery() > 0)
                            {//受影响的行数
                                MessageBox.Show("添加成功", "系统提示");
                            }
                            else
                            {
                                MessageBox.Show("添加失败", "系统提示");
                            }
                        }
                        else
                        {
                            con.Close();
                        }
                    }
                    catch (Exception ex)
                    {//异常处理提示
                        MessageBox.Show(ex.Message, "来自系统提示");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private bool nun_null()
        {//非空判断
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
                MessageBox.Show("请输入性别", "系统提示");
                return false;
            }
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("请输入年龄", "系统提示");
                return false;
            }
            if (textBox5.Text == string.Empty)
            {
                MessageBox.Show("请输入地址", "系统提示");
                return false;
            }
            if (textBox6.Text == string.Empty)
            {
                MessageBox.Show("请输入邮箱", "系统提示");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {//取消
            Close();
        }
    }
}
