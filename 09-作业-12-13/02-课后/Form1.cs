using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;//1.引入数据库

namespace _02_课后
{
    public partial class Stu : Form
    {
        public Stu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=StudentManager"); //2~3创建数据库对象，连接字符串
            sqlConnection.Open();//4.打开数据库
            int id = int.Parse(txtb_Stu_Id.Text);
            string name = txtb_Stu_Name.Text.Trim();
            float height = float.Parse(txtb_Stu_Height.Text.Trim());
            string sex = string.Empty.Trim();
            if (rbt_Sex_Man.Checked == true)
            {
                sex = "男";
            }
            else if (rbt_Sex_Woman.Checked == true)
            {
                sex = "女";
            }
            string tream = txtb_Stu_Tream.Text;//5.添加数据
            string sql = string.Format("insert into Student values('{0}','{1}','{2}','{3}')", name, height, sex, tream);//6.增加数据
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);//创建命令对象
            int getBack = sqlCommand.ExecuteNonQuery();
            if (getBack > 0)
            {
                MessageBox.Show("添加成功", "错误");
            }
            else
            {
                MessageBox.Show("添加失败", "错误");
            }
            sqlConnection.Close();
        }

        private void btn_Id_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=StudentManager");//2~3连接到数据库，实例化数据库对象，创建连接字符串
            sqlConnection.Open();//4.打开数据库
            int id = int.Parse(txtb_Stu_Id.Text.Trim());
            string sql = string.Format("delete from student where id = '{0}'", id);//增加数据
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);//创建命令对象
            int CENQ = sqlCommand.ExecuteNonQuery();//提示影响行数
            if (CENQ > 0)
            {
                MessageBox.Show("删除成功", "提示");
            }
            else
            {
                MessageBox.Show("删除失败", "提示");
            }
            sqlConnection.Close();//关闭数据库
        }

        private void btn_Id_Amend_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server = .;uid = sa;pwd = 123456;database = StudentManager");//建立连接
            sqlConnection.Open();//打开数据库
            int id = int.Parse(txtb_Stu_Id.Text.Trim());
            string name = txtb_Stu_Name.Text.Trim();
            float height = float.Parse(txtb_Stu_Height.Text.Trim());
            string sex = string.Empty.Trim();
            string tream = txtb_Stu_Tream.Text.Trim();
            if (rbt_Sex_Man.Checked == true)
            {
                sex = "男";
            }
            else if (rbt_Sex_Woman.Checked == true)
            {
                sex = "女";
            }
            string sql = string.Format("update Student set name='{0}',height={1},sex='{2}',tream='{3}' where id={4}",name,height,sex,tream,id);
            SqlCommand sqlCommand = new SqlCommand(sql,sqlConnection);
            int CENQ = sqlCommand.ExecuteNonQuery();//提示影响行数
            if (CENQ > 0)
            {
                MessageBox.Show("修改成功", "提示");
            }
            else
            {
                MessageBox.Show("修改失败", "提示");
            }
            sqlConnection.Close();//关闭数据库
        }
}
    }
