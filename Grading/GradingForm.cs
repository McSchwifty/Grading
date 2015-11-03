// by: Andrew Mackinnon
// Nov 3 2015
// ICS3UR
// Converts a letter mark to a percentage.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grading
{
    public partial class frmGrading : Form
    {
        public string PercentageMaker(string letter)
        {
            // Converts a mark to a percentage

            string mark = "That aint no mark";

            if (letter == "4+")
            {
                mark = "Your percentage is: 95%";
            }
            else if (letter == "4")
            {
                mark = "Your percentage is: 90%";
            }
            else if (letter == "4-")
            {
                mark = "Your percentage is: 85%";
            }
            else if (letter == "3+")
            {
                mark = "Your percentage is: 77%";
            }
            else if (letter == "3")
            {
                mark = "Your percentage is: 75%";
            }
            else if (letter == "3-")
            {
                mark = "Your percentage is: 72%";
            }
            else if (letter == "2+")
            {
                mark = "Your percentage is: 67%";
            }
            else if (letter == "2")
            {
                mark = "Your percentage is: 65%";
            }
            else if (letter == "2-")
            {
                mark = "Your percentage is: 62%";
            }
            else if (letter == "1+")
            {
                mark = "Your percentage is: 57%";
            }
            else if (letter == "1")
            {
                mark = "Your percentage is: 55%";
            }
            else if (letter == "1-")
            {
                mark = "Your percentage is: 52%";
            }
            else if (letter == "R")
            {
                mark = "Your percentage is: 30%";
            }
            else if (letter == "NE")
            {
                mark = "Your percentage is: 0%";
            }
            else if (letter == "cool bro")
            {
                mark = "Your percentage is: hell ya";
            }
            
            return mark;
        }


        public frmGrading()
        {
            InitializeComponent();
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            // Varribles

            string mark = this.txtMark.Text;
            string percentage;
            
            // Process

            percentage = PercentageMaker(mark);
            this.lblAnswer.Text = percentage;
        }
    }
}
