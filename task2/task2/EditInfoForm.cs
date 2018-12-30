using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySQLDriverCS;
using System.Data;

namespace task2
{
    public partial class EditInfoForm : Form
    {
        public EditInfoForm()
        {
            InitializeComponent();
        }
        String userNameTmp = "";
        public EditInfoForm(String str)
        {
            InitializeComponent();
            userNameTmp = str;
            //MessageBox.Show(str);
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_2(object sender, EventArgs e)
        {

        }

        

        private void major_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_3(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void editInforForm_load(object sender, EventArgs e)
        {
            InitComboBox(comboBox1);
        }
        private void InitComboBox(ComboBox combobox)
        {
            List<String> apartments = new List<String>();
            apartments.Add("计算机科学与技术学院");
            apartments.Add("数理学院");
            apartments.Add("电子与信息工程学院");
            apartments.Add("艺术学院");
            apartments.Add("软件学院");

            //ComboBox控件实现  (与ListBox的实现类似)
            comboBox1.DataSource = apartments;
            comboBox1.DisplayMember = "apartments";
        }

        private void textBox1_leave(object sender, EventArgs e)
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

            }
        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleRadioButton.Checked)
            {
                femaleRadioButton.Checked = false;
            }
            else {
                maleRadioButton.Checked = true;
            }
           
        }
        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (maleRadioButton.Checked)
            {
                maleRadioButton.Checked = false;
            }
            else
            {
                femaleRadioButton.Checked = true;
            }
            
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            femaleRadioButton.Checked = false;
            maleRadioButton.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //String str = comboBox1.GetItemText;
            
            if (textBox1.Text==""||textBox2.Text == ""|| textBox3.Text == "")
            {
                MessageBox.Show("还有必填项未填写");
            }
            String userRealName = textBox1.Text.ToString();

            String userNumber = textBox2.Text.ToString();
            String userDepartment = comboBox1.SelectedItem.ToString();
            String userMajor = textBox3.Text.ToString();
            String userGrander = "";
            if (femaleRadioButton.Checked)
            {
                userGrander = "男";
            }else if (maleRadioButton.Checked)
            {
                userGrander = "女";
            }

            String userHobbies = "";
            if (checkBox1.Checked)
            {
                userHobbies = userHobbies + checkBox1.Text.ToString() + " ";
            }
            if (checkBox2.Checked)
            {
                userHobbies = userHobbies + checkBox2.Text.ToString() + " ";
            }
            if (checkBox3.Checked)
            {
                userHobbies = userHobbies + checkBox3.Text.ToString() + " ";
            }
            if (checkBox4.Checked)
            {
                userHobbies = userHobbies + checkBox4.Text.ToString() + " ";
            }
            if (checkBox5.Checked)
            {
                userHobbies = userHobbies + checkBox5.Text.ToString() + " ";
            }
            String userName = userNameTmp;




            /**
           * 连接数据库
           */

            try
            {
                MySQLConnection DBConn;
                DBConn = new MySQLConnection(new MySQLConnectionString("127.0.0.1", "homework", "root", "yilisha", 3306).AsString);
                //DBConn = new MySQLConnection(new MySQLConnectionString("数据源","数据库名", "用户名", "密码", 端口号).AsString);
                DBConn.Open(); // 执行查询语句

                String sql = "insert into userinfo(userRealName,userNumber,userDepartment,userMajor,userGrander,userHobbies,userName)values('" + userRealName + "','" + userNumber + "','" + userDepartment + "','" + userMajor + "','" + userGrander + "','" + userHobbies + "','" + userName + "')";
                MySQLCommand mycmd1 = new MySQLCommand(sql, DBConn);
                mycmd1.ExecuteNonQuery();

                DBConn.Close();
            }
            catch
            {
                MessageBox.Show("连接数据库失败");
            }
        }

        private void personInfoGroup_Enter(object sender, EventArgs e)
        {

        }
    }
}
