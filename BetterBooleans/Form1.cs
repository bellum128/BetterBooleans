using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterBooleans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine(!!!!!!!!!!!!!!!!!!!!!!!!!false);
        }

        private void DoTheThing()
        {
            StringBuilder str = new StringBuilder();


            int count = 0;

            try
            {
                count = Int32.Parse(textBox1.Text);
            }
            catch
            {
                // :D
            }

            String thingy;

            if (checkBox1.Checked)
            {
                thingy = (count % 2 == 0) ? "true" : "false";
            }
            else
            {
                thingy = !!!!!!!!!!!!!!!!!!!!!!!!!(count % 2 == 0) ? "true" : "false";
            }


            for (int i = 0; i < count; i++)
            {
                str.Append("!");
            }

            textBox2.Text = $"{str.ToString()}{thingy}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DoTheThing();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DoTheThing();
        }
    }
}
