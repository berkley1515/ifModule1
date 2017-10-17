using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifModule1
{
    public partial class Form1 : Form
    {
        //globals
        int integer;
        double remainder;

        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            //holding values
            integer = Convert.ToInt16(inputBox.Text);


            if (integer < 0)
            {
                //output
                outputLabel1.Text = integer + " is a negative number";
            }
            else
            {
                //output
                outputLabel1.Text = integer + " is a positve number";//

            }

            //math
            remainder = (integer) % 7;

           if (remainder == 0)
            {
                //output
                outputLabel2.Text = integer + " is divisble by 7";
            }
           else
            {
                //output
                outputLabel2.Text = integer + " is not divisble by 7";
            }

        }
    }
}
