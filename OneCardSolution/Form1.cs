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


            string sql = "server =.; database = yikatong; uid = sa; pwd = 1234";
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            string id = textBox1.Text;
            string mima = textBox2.Text;
            string ID =String.Format("select * from ID where id='{0}'and mima='{1}'",id,mima);
            SqlCommand dd = new SqlCommand(ID, con);
            //string sql = "select id,mima from ID where AdminName='" + id + "' and mima= '" + mima + "'";
            if (dd.ExecuteScalar()!= null)
            {

                MessageBox.Show("登陆成功");
                consumption c = new consumption();
                c.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("请先注册");
            } 
           //con.Close();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
