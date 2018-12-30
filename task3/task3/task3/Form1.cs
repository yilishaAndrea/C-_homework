using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySQLDriverCS;

namespace task3
{
    public partial class Exam : Form
    {
        int score = 0;
        int count = 1;
        String answer = "";
        String[] t_title;
        String[] t_a;
        String[] t_b;
        String[] t_c;
        String[] t_d;
        String[] t_answer;
        public Exam()
        {
            InitializeComponent();

        }
        public Exam(String[] t_title,String[] t_a, String[] t_b, String[] t_c, String[] t_d, String[] t_answer)
        {
            InitializeComponent();
            this.t_title = t_title;
            this.t_a = t_a;
            this.t_b = t_b;
            this.t_c = t_c;
            this.t_d = t_d;
            this.t_answer = t_answer;
            radioButtonA.Text = t_a[0];
            radioButtonB.Text = t_b[0];
            radioButtonC.Text = t_c[0];
            radioButtonD.Text = t_d[0];
            problemTitle.Text = t_title[0];
            number.Text = "第"+1+"题";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButtonA.Checked)
            {
                answer = "A";
            }
            else if (radioButtonB.Checked)
            {
                answer = "B";
            }
            else if (radioButtonC.Checked)
            {
                answer = "C";
            }
            else if (radioButtonD.Checked)
            {
                answer = "D";
            }
            else
            {
                answer = "";
            }
            if (answer.Equals(t_answer[count - 1]))
            {
                score++;
            }
            radioButtonA.Text = t_a[count];
            radioButtonB.Text = t_b[count];
            radioButtonC.Text = t_c[count];
            radioButtonD.Text = t_d[count];
            problemTitle.Text = t_title[count];

            count++;
            number.Text = "第" + (count + 1) + "题";

            if (count == 9)
            {
                buttonNext.Text = "答题结束";
            }
        }
        
        private void problemTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这次答题得分为：" + score);
        }

        private void radioButtonB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonC_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButtonD_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void number_Enter(object sender, EventArgs e)
        {

        }
    }
}
