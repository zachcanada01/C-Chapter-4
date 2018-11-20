using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace FahrenheitToCelsiusForm
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

        private void calculate_Click(object sender, EventArgs e)
        {
            int temp1;
            int temp2;
            int temp3;
            double conversion1;
            double conversion2;
            double conversion3;

            temp1 = Convert.ToDouble(temptxt1.Text);
            temp2 = Convert.ToDouble(temptxt2.Text);
            temp3 = Convert.ToDouble(temptxt3.Text);

            conversion1 = (temp1 - 32) * 5 / 9;
            conversion2 = (temp2 - 32) * 5 / 9;
            conversion3 = (temp3 - 32) * 5 / 9;

            tempOutput1.Text = "Fahrenheit for 8:00 am = " + temp1 + ". Celsius for 8:00 am = " + conversion1;
            tempOutput2.Text = "Fahrenheit for 12:00 pm = " + temp2 + ". Celsius for 12:00 pm = " + conversion2;
            tempOutput3.Text = "Fahrenheit for 5:00 pm = " + temp3 + ". Celsius for 5:00 pm = " + conversion3;

            if (temp1 < 32 | temp2 < 32 | temp3 < 32)
            {
                hotOrCold.Text = "It will be freezing today.";
            }
            else if (temp1 > 100 | temp1 > 100 | temp3 > 100)
            {
                hotOrCold.Text = "It will be hot today.";
            }
        }
    }
}
