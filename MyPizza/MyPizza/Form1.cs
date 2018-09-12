using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPizza
{
    

    public partial class Form1 : Form
    {
        private const double BASE_PRICE = 12.00;
        private const double TOPPING_PRICE = 1.25;
        private double price = BASE_PRICE;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void SausagecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            if (SausagecheckBox.Checked)
            {
                price += TOPPING_PRICE;

            }

            else
            {
                price -= TOPPING_PRICE;
            }

            outputlabel.Text = "Total is " + price.ToString("c");
        }

        private void onioncheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (onioncheckBox.Checked)
            {
                price += TOPPING_PRICE;

            }
            else
            {
                price -= TOPPING_PRICE;
            }
            outputlabel.Text = "Total is " + price.ToString("c");
        }

        private void peppercheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (peppercheckBox.Checked)
            {
                price += TOPPING_PRICE;

            }
            else
            {
                price -= TOPPING_PRICE;
            }
            outputlabel.Text = "Total is " + price.ToString("c");
        }

        private void pepperonicheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (pepperonicheckBox.Checked)
            {
                price += TOPPING_PRICE;

            }

            else
            {
                price -= TOPPING_PRICE;
            }
            outputlabel.Text = "Total is " + price.ToString("c");
        }

        private void deliverRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            const double DELIVERY_CHARGE = 2.00;
            if (deliverRadioButton.Checked)
                price += DELIVERY_CHARGE;
            else
                price -= DELIVERY_CHARGE;

            outputlabel.Text = "Total is " + price.ToString("c");
        }

        


        
    }
}
