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
    public partial class consumption : Form
    {
        public consumption()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.Text == "" || comboBox2.Text == ""||textBox2.Text=="")
            {
                MessageBox.Show("不能为空！");
                return;
            }
            string jin = this.comboBox1.Text;
            string chu = this.comboBox2.Text;
            string[] zhandian = { "石埠", "南职院", "鹏飞路", "西乡塘客运站",
                "民族大学", "清川", "动物园", "鲁班路", "广西大学", "白苍岭", "火车站", "朝阳广场"};
            int jz = 0;
            int i = 0;
            for (; i < zhandian.Length; i++)
            {
                if (jin == zhandian[i])
                {
                    jz = i + 1;
                    break;
                }
            }
            int cz = 0;
            int j = 0;
            for (; j < zhandian.Length; j++)
            {
                if (chu == zhandian[j])
                {
                    cz = j + 1;
                    break;
                }
            }
            int money = (cz - jz) * 2;
            string id = this.textBox1.Text;
            string sql = string.Format("update yikatong set balance-={0} where card='{1}'", money, id);
            string sql4 = string.Format("select * from yhUser where card='{0}'", id);
            SqlCommand fu = new SqlCommand(sql);
            int fuqian=0;
            if (fuqian <= 0)
            {
                MessageBox.Show("您的余额不足！");
                return;
            }
            if (DBHelper.ExecuteNonQuery(sql))
            {
                string sql2 = string.Format("select * from yhUser where card='{0}'", id);
                SqlCommand cmd = new SqlCommand(sql2);
                MessageBox.Show("卡号：" + id + "\r\n" + "您消费了" + money + "元" + "\r\n" + "您的余额为" + cmd.ToString());

                string name = cmd.ToString();

                string sql3 = string.Format("insert into licheng(name,PitStop,OutboundStation,consumption) values ('{0}','{1}','{2}',{3})", name, jin, chu, money);
                DBHelper.ExecuteNonQuery(sql3);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void consumption_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
