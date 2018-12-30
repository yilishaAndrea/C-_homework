using System;
using System.Data;
using System.Windows.Forms;
using MySQLDriverCS;

namespace task3
{
    public partial class Form2 : Form
    {
        String[] t_title;
        String[] t_a;
        String[] t_b;
        String[] t_c;
        String[] t_d;
        String[] t_answer;
        public Form2()
        {
            InitializeComponent();
        }

        private void startanswer_Click(object sender, EventArgs e)
        {
            getDatabaseData();
        }
        private void getDatabaseData()
        {
            try
            {
                MySQLConnection DBConn;
                DBConn = new MySQLConnection(new MySQLConnectionString("127.0.0.1", "homework", "root", "yilisha", 3306).AsString);
                //DBConn = new MySQLConnection(new MySQLConnectionString("数据源","数据库名", "用户名", "密码", 端口号).AsString);
                DBConn.Open(); // 执行查询语句

                String sql = "select * from exam";
                MySQLCommand setformat = new MySQLCommand("set names gb2312", DBConn);
                setformat.ExecuteNonQuery();
                setformat.Dispose();
                MySQLDataAdapter mda = new MySQLDataAdapter(sql, DBConn);

                DataSet ds = new DataSet();
                mda.Fill(ds);
                DataTable dt = ds.Tables[0];
                t_title = new String[dt.Rows.Count];
                t_a = new String[dt.Rows.Count];
                t_b = new String[dt.Rows.Count];
                t_c = new String[dt.Rows.Count];
                t_d = new String[dt.Rows.Count];
                t_answer = new String[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    t_title[i] = dt.Rows[i]["t_title"].ToString();
                    t_a[i] = dt.Rows[i]["t_a"].ToString();
                    t_b[i] = dt.Rows[i]["t_b"].ToString();
                    t_c[i] = dt.Rows[i]["t_c"].ToString();
                    t_d[i] = dt.Rows[i]["t_d"].ToString();
                    t_answer[i] = dt.Rows[i]["t_answer"].ToString();
                }
                DBConn.Close();
            }
            catch
            {
                MessageBox.Show("连接数据库失败");
            }
            Exam exam = new Exam(t_title, t_a, t_b, t_c, t_d, t_answer);
            exam.Show();
            //this.Close();
        }
    }
}
