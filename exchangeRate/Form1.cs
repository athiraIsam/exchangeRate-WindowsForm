using exchange_rate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exchangeRate
{
    public partial class Form1 : Form
    {
        int menuChoice = 0;
        double americanDollars = 0.0;
        double conversionRate = 0.0;
        double convertedCurrency = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void caculateBtn_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(usdDollarInput.Text, out americanDollars))
            {
                errorLabel.Text = "Invalid Input Number";
            }

            if (rbBritishRate.Checked)
                menuChoice = 1;
            else if (rbMexicanRate.Checked)
                menuChoice = 2;
            else if(rbJapanaseRate.Checked)
                menuChoice = 3;
            else
            {
                errorLabel.Text = "Invalid Rate Choice.";
            }

            ConversionHelper.assignRate(menuChoice, out conversionRate);

            ConversionHelper.convertDollars(americanDollars, conversionRate, out convertedCurrency);

            outputRate.Text = convertedCurrency.ToString();
        }

    }
}
