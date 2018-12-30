using System;
using MySQLDriverCS;
using System.Windows.Forms;
using System.Data;

namespace task2
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
      
            /**
            * 连接数据库
            */
            
            try
            {
                MySQLConnection DBConn;
                DBConn = new MySQLConnection(new MySQLConnectionString("127.0.0.1", "homework", "root", "yilisha", 3306).AsString);
                //DBConn = new MySQLConnection(new MySQLConnectionString("数据源","数据库名", "用户名", "密码", 端口号).AsString);
                DBConn.Open(); // 执行查询语句
                MessageBox.Show("注册成功！");
                string userName = textBox1.Text.ToString();  //取出用户名
                string userPassword = textBox2.Text.ToString();  //取出密码

                //因为userName为主键，所以要判断查询出的结果是否已经存在
                string sql = "select * from login where userName= '"+ userName+"'";
                MySQLDataAdapter mda = new MySQLDataAdapter(sql, DBConn);
                DataSet ds = new DataSet();
                mda.Fill(ds);
                //没有同样的用户名则进行插入操作
                if(ds.Tables.Count == 1 && ds.Tables[0].Rows.Count == 0)
                {
                    sql = "insert into login(userName,userPassword)values('" + userName + "','" + userPassword + "')";
                    MySQLCommand mycmd1 = new MySQLCommand(sql, DBConn);
                    mycmd1.ExecuteNonQuery();

                    //跳到用户信息登记页面，并且把用户名传入到另一窗口中，用以在用户信息表中userName那一栏填写
                    EditInfoForm editInfo = new EditInfoForm(this.textBox1.Text.ToString());
                    editInfo.Show();
                }
                else
                {
                    MessageBox.Show("该用户名已经被占用");
                }
                
                DBConn.Close();
                // MySQLDataAdapter mysql_adapter= new MySQLDataAdapter(sql, DBConn);
                // mysql_adapter.

                /*string sql = "select * from tb_user";
                MySQLDataAdapter mda = new MySQLDataAdapter(sql, DBConn);
                DataSet ds = new DataSet();
                mda.Fill(ds, "table1");
                this.dataGridView1.DataSource = ds.Tables["table1"];*/
               
                /*MySqlConnection con;
                string constr = "server=localhost;port=3306;user id=root;password=yilisha;Database=homework";
                con = new MySqlConnection(constr);
                con.Open();
                string userName = textBox1.Text;  //取出用户名
                string userPassword = textBox2.Text;  //取出密码
                MessageBox.Show("test:"+ userName + " " + userPassword);
                string sql = "insert into login(userName,userPassword)values('" + userName + "','"+ userPassword + "')";

                MySqlCommand mycmd1 = new MySqlCommand(sql, con);
                mycmd1.ExecuteNonQuery();
                con.Close();*/
            }
            catch
            {
                MessageBox.Show("连接数据库失败");
            }
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void registerForm_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbook1_leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

                MessageBox.Show("内容不能为空");//加载新窗口时显示信息框

            }
        }

        private void textBox2_leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {

                MessageBox.Show("内容不能为空");//加载新窗口时显示信息框

            }
        }

        private void textBox3_leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {

                MessageBox.Show("内容不能为空");//加载新窗口时显示信息框

            }else if (textBox2.Text!=textBox3.Text)
            {
                MessageBox.Show("两次密码要一致");//加载新窗口时显示信息框
            }
        }
    }
}
