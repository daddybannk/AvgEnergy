using System;
using System.Windows.Forms;

namespace AvgEnergy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(button1.Text);
        }

        private void Calculate()
        {
            double afterComsumption = 0;
            double beforeComsumption = 0;
            int hour = 1;
            try
            {
                afterComsumption = double.Parse(textBox1.Text);
                beforeComsumption = double.Parse(textBox2.Text);
                hour = int.Parse(textBox3.Text);
            }
            catch
            {

            }
            button1.Text = Math.Round(((afterComsumption - beforeComsumption) / hour), 4).ToString();
        }
    }
}
