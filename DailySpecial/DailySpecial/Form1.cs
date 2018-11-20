using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailySpecial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void outputLabel_Click(object sender, EventArgs e)
        {

        }
        enum Day
        {
            SUNDAY = 1, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY
        }
        private void specialButton_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(dayBox.Text);
            string special;
            
            switch ((Day)day)
            {
                case Day.SUNDAY:
                    special = "Fried Chicken";
                    break;
                case Day.MONDAY:
                    special = "Sorry - Closed";
                    break;
                case Day.TUESDAY:
                case Day.WEDNESDAY:
                case Day.THURSDAY:
                    special = "Meat Loaf";
                    break;
                case Day.FRIDAY:
                    special = "Fish Fry";
                    break;
                case Day.SATURDAY:
                    special = "Liver and Onions";
                    break;
                default:
                    special = "Invalid Day";
                    break;

                

            }
            result.Text = "Today's special is" + special;
        }

        private void result_Click(object sender, EventArgs e)
        {

        }
    }
}
