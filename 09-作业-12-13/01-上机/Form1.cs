using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;//1.引入数据库

namespace _01_上机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region 备注
        /*
         * Add--添加
         * Amend--修改
         * Delete-删除
         * lbl_Add_Stu_Id--学员编号
         * lbl_Add_Stu_Name--学员姓名
         * lbl_Add_Stu_Sex--学员性别
         * lbl_Add_Stu_Age--学员年龄
         */
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            int A = 0;
            for (int i = 1; i <= 120; i++)
            {
                A = cmb_Add_Stu_Age.Items.Add(i);
                A = cmb_Amend_Stu_Age.Items.Add(i);
            }
            cmb_Add_Stu_Age.SelectedIndex = 17;
            cmb_Amend_Stu_Age.SelectedIndex = 17;
        }
        /// <summary>
        /// 添加学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submit_Click(object sender, EventArgs e)
        {
            //string ning = "server=.;uid=sa;pwd=123456;database=student";//s数据库连接字符串
            SqlConnection sqlConnection = new SqlConnection("server =.; uid = sa; pwd = 123456; database = student");
            //2~3.创建数据库对象,并连接
            sqlConnection.Open();//打开数据库
            string StuId = txtb_Add_Stu_Id.Text.Trim();//学员编号
            string StuName = txtb_Add_Stu_Name.Text.Trim();//学员姓名
            string StuSex = string.Empty.Trim();//学员性别
            int StuAge;//学员年龄
            if (rbt_Add_Stu_Sex_Man.Checked == true)
            {
                StuSex = "男";
            }
            else if (rbt_Add_Stu_Sex_Woman.Checked == true)
            {
                StuSex = "女";
            }
            StuAge = int.Parse(cmb_Add_Stu_Age.Text);//选择年龄
            string sql = string.Format("insert into StuInfo values('{0}','{1}','{2}',{3})", StuId, StuName, StuSex, StuAge);//添加语句
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);//创建命令对象
            int CENQ = sqlCommand.ExecuteNonQuery();//返回受影响的行数
            if (CENQ > 0)
            {
                MessageBox.Show("添加成功", "提示");
            }
            else
            {
                MessageBox.Show("添加失败", "提示");
            }
            sqlConnection.Close();//关闭数据库
        }
        /// <summary>
        /// 修改学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Amend_Submit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server =.; uid = sa; pwd = 123456; database = student");
            //2~3.创建数据库对象,并连接
            sqlConnection.Open();//打开数据库
            string StuId = txtb_Amend_Stu_Id.Text.Trim();//学员编号
            string StuSex = string.Empty;//学员性别
            int StuAge;//学员年龄
            if (rbt_Amend_Stu_Sex_Man.Checked == true)
            {
                StuSex = "男";
            }
            else if (rbt_Amend_Stu_Sex_Woman.Checked == true)
            {
                StuSex = "女";
            }
            StuAge = int.Parse(cmb_Amend_Stu_Age.Text.Trim());//选择年龄
            string sql = string.Format("update stuInfo set stuSex='{0}',stuAge = '{1}' where stuNo='{2}'", StuSex, StuAge, StuId);//添加语句
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);//创建数据库对象
            int CENQ = sqlCommand.ExecuteNonQuery();//受影响的行数
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
        /// <summary>
        /// 删除学员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_Id_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server =.; uid = sa; pwd = 123456; database = student");
            //2~3.创建数据库对象,并连接
            sqlConnection.Open();//4.打开数据库
            string stuId = txtb_Delete_Stu_Id.Text.Trim();
            string sql = string.Format("delete from stuInfo where stuNo = '{0}'", stuId);//5.删除语句
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);//6.创建命令对象
            int CENQ = sqlCommand.ExecuteNonQuery();//7.返回行数
            if (CENQ > 0)
            {
                MessageBox.Show("删除成功", "提示");
            }
            else
            {
                MessageBox.Show("删除失败", "提示");
            }
            sqlConnection.Close();//8.关闭数据库
        }
    }
}

