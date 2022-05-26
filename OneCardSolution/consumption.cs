using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            if (textBox1.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
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
         


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
