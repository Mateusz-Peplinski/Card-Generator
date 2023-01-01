using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Generator
{
    public partial class main : Form
    {
        private Random RandomNumberGen;
        public main()
        {
            InitializeComponent();
            RandomNumberGen = new Random();
            cardNumberTextbox.Text = "";
            expDatTextBox.Text = "";
            securityNumberTextBox.Text = "";
        }


        private String generateCardNumber()
        {
            string cardNumber = "";
            
            
            int length = RandomNumberGen.Next(16,19);

            for (int i=0; i < length; i++)
            {
                int nextNumber = RandomNumberGen.Next(0,9);
                if(i == 4 || i == 8 || i == 12)
                {
                    cardNumber += " ";
                }
                cardNumber += nextNumber.ToString();
            }

            return cardNumber;
        }

        private String generateExpireDate()
        {
            string expDate = "";

            int month = RandomNumberGen.Next(1, 12);
            expDate += month.ToString();
            expDate += "/";
            int year = RandomNumberGen.Next(22, 30);
            expDate += year.ToString();
            
            return expDate;
        }

        private String generateSecurityNumber()
        {
            string securityNumber = "";

            for (int i = 0; i < 3; i++) {
                int num = RandomNumberGen.Next(0,9);
                securityNumber += num.ToString();
            }

            return securityNumber;
        }

        private void genButton_Click(object sender, EventArgs e)
        {
            cardNumberTextbox.Text = "";
            expDatTextBox.Text = "";
            securityNumberTextBox.Text = "";
            string cardNumber = generateCardNumber();
            string expireDate = generateExpireDate();
            string securityNumber  = generateSecurityNumber();
            expDatTextBox.Text += expireDate;
            securityNumberTextBox.Text += securityNumber;
            cardNumberTextbox.Text += cardNumber;
        }
    }
}
