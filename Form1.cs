using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtFirstDigit.Text);
            int b = Convert.ToInt32(txtSecondDigit.Text);
            int c = 0;
            switch (cboOption.Text)
            {
                case "Add":
                    c = a + b;
                    break;
                case "Sub":
                    c = a - b;
                    break;
                case "Mul":
                    c = a * b;
                    break;
                case "Div":
                    c = a / b;
                    break;
                default:
                    break;
            }

            txtResult.Text = c.ToString();
                }

      
    }
}
