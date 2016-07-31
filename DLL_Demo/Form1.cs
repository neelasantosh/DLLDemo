using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLL_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(number1.Text);
            int num2 = Convert.ToInt32(number2.Text);

            sun_dll.Sum s = new sun_dll.Sum();
            double ans = s.getSum(num1, num2);
            resultTextBox.Text = ans + "";
        }
    }
}
