//File Name: Chap12

//Written By: Brandon Truong

//Date: 08/02/2015
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap12
{
    public partial class Form1 : Form
    {

        private double price;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Garlicbread_CheckedChanged(object sender, EventArgs e)
        {
            if (Garlicbread.Checked)
                price += 4;
            else
                price -= 4;

            label1.Text = "Total is " + price.ToString("c");
        }

        private void Shrimpcocktail_CheckedChanged(object sender, EventArgs e)
        {
            if (Shrimpcocktail.Checked)
                price += 5;
            else
                price -= 5;

            label1.Text = "Total is " + price.ToString("c");
        }

        private void Stuffedmushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (Stuffedmushrooms.Checked)
                price += 6;
            else
                price -= 6;

            label1.Text = "Total is " + price.ToString("c");
        }

        private void Lasagna_CheckedChanged(object sender, EventArgs e)
        {
            if (Lasagna.Checked)
                price += 24;
            else
                price -= 24;

            label1.Text = "Total is " + price.ToString("c");
        }

        private void Linguini_CheckedChanged(object sender, EventArgs e)
        {
            if (Linguini.Checked)
                price += 25;
            else
                price -= 25;

            label1.Text = "Total is " + price.ToString("c");
        }

        private void Spaghetti_CheckedChanged(object sender, EventArgs e)
        {
            if (Spaghetti.Checked)
                price += 26;
            else
                price -= 26;

            label1.Text = "Total is " + price.ToString("c");
        }

        private void Canoli_CheckedChanged(object sender, EventArgs e)
        {
            if (Canoli.Checked)
                price += 7;
            else
                price -= 7;

            label1.Text = "Total is " + price.ToString("c");
        }

        private void Chocolatetruffle_CheckedChanged(object sender, EventArgs e)
        {
            if (Chocolatetruffle.Checked)
                price += 8;
            else
                price -= 8;

            label1.Text = "Total is " + price.ToString("c");
        }

        private void Tiramisu_CheckedChanged(object sender, EventArgs e)
        {
            if (Tiramisu.Checked)
                price += 9;
            else
                price -= 9;

            label1.Text = "Total is " + price.ToString("c");
        }
    }
}
