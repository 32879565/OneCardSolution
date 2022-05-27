using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OneCardSolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("用户名或密码不能为空！");
                return;
            }
            string qqw = textBox1.Text;
            string qqe = textBox2.Text;
            string sql = $"select*from ID where id='{qqw}' and name='{qqe}'";
            SqlDataReader resd = DBHelper.Getable(sql);
            if (resd.HasRows)
            {

                MessageBox.Show("登陆成功！");
                consumption f= new consumption();
                f.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("请先注册！");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
