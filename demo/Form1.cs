using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dzm = 0, xzm = 0, sz = 0, qt = 0;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (char.IsUpper(textBox1.Text[i]))//判断是不是大写
                    ++dzm;
                else if (char.IsLower(textBox1.Text[i]))//判断是不是小写
                    ++xzm;
                else if (char.IsNumber(textBox1.Text[i]))//判断是不是数字
                    ++sz;
                else           //计算其他字符的个数
                    ++qt;

            }


            label2.Text = "大写字母有" + dzm + "个，小写字母有" + xzm + "个,数字" + sz + "个，其他有" + qt + "个"; //把结果显示在窗体上
        }
    }
}
