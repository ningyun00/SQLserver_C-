using System.Data.SqlClient;

namespace 图书管理系统
{
    class Dao
    {
        SqlConnection con;
        public SqlConnection Con()
        {//数据库连接
            con = new SqlConnection("server=.;uid=sa;pwd=123456;database=Book");//连接字符串
            con.Open();
            return con;//返回数据库对象
        }
        public SqlCommand Com(string sql)
        {//操作对象
            SqlCommand com = new SqlCommand(sql, Con());
            return com;
        }
        public int Execute(string sql)
        {//更新操作
            return Com(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql)
        {//读取操作
            return Com(sql).ExecuteReader();
        }
        public void DaoClose()
        {//关闭数据库
            con.Close();
        }
    }
}
