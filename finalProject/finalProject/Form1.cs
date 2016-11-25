using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace finalProject
{
    public partial class formLogin : Form
    {
       public struct Account
        {
            String username;
            String password;
        }

        List<Account> accounts = new List<Account>();
        public formLogin()
        {
            InitializeComponent();
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
        private int NumberUpperCase(string str)
        {
            int upperCase = 0;  // The number of uppercase letters

            // Count the uppercase characters in str.
            foreach (char ch in str)
            {
                if (char.IsUpper(ch))
                {
                    upperCase++;
                }
            }

            // Return the number of uppercase characters.
            return upperCase;
        }

        private int NumberLowerCase(string str)
        {
            int lowerCase = 0;  // The number of lowercase letters

            // Count the lowercase characters in str.
            foreach (char ch in str)
            {
                if (char.IsLower(ch))
                {
                    lowerCase++;
                }
            }

            // Return the number of lowercase characters.
            return lowerCase;
        }

        private int NumberDigits(string str)
        {
            int digits = 0;  // The number of digits

            // Count the digits in str.
            foreach (char ch in str)
            {
                if (char.IsDigit(ch))
                {
                    digits++;
                }
            }

            // Return the number of digits.
            return digits;
        }

        private int NumberPunctuation(string str)
        {
            int pun = 0;
            foreach (char ch in str)
            {
                if (char.IsPunctuation(ch))
                {
                    pun++;
                }
            }

            // Return the number of digits.
            return pun;

        }

        private void logBtn_Click(object sender, EventArgs e)
        {
           //hello parker
            if (txtBoxUser.Text == "")
            {
                statLbl2.Text = "no username entered";
            }
            else if (txtBoxPass.Text == "")
            {
                statLbl2.Text = "no password entered";
            }
            for (int i = 0; i < accounts.Count; i++)
            {
                if (txtBoxUser.Text == accounts[i].username && logPassTxtBox.Text == accounts[i].Password)
                {
                    statLbl2.Text = "Welcome to the system: " + logUserTxtBox.Text;
                    break;
                }

                if (!(txtBoxUser.Text == accounts[i].name && logPassTxtBox.Text == accounts[i].Password))
                {
                    statLbl2.Text = "Wrong Log in username or password";
                }

            }

        }
    }
}
