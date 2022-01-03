using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;//1.引入数据库

namespace _03_附加题
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SizeConter();
        }
        #region 窗体字体居中
        private void SizeConter()
        {
            Graphics g = this.CreateGraphics();
            Double startingPoint = (this.Width / 2) - (g.MeasureString(this.Text.Trim(), this.Font).Width / 2);
            Double ws = g.MeasureString("*", this.Font).Width;
            String tmp = " ";
            Double tw = 0;

            while ((tw + ws) < startingPoint)
            {
                tmp += "3 ";
                tw += ws;
            }
            this.Text = tmp.Replace("3", " ") + this.Text.Trim();
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=MyqqPirate");//2~3创建数据库对象，连接字符串
            sqlConnection.Open();//4.打开数据库
            string pwd = txtb_QQpwd.Text.Trim();
            int ID = int.Parse(cmb_QQID.Text.Trim());
            string sql = string.Format("insert into QQAccount values('{0}','{1}')", ID, pwd);
            SqlCommand sqlCommand = new SqlCommand(sql/*添加或删除或修改内容*/, sqlConnection/*连接对象*/);//创建命令对象
            int CENQ = sqlCommand.ExecuteNonQuery();//提示影响行数
            if (CENQ > 0)
            {
                System.Threading.Thread.Sleep(1000);
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败", "提示");
            }
            sqlConnection.Close();//关闭数据库        
        }
    }
}
