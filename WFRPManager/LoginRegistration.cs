using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFRPManager
{
    public partial class LoginRegistration : Form
    {
        public LoginRegistration()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Login.Text) && !string.IsNullOrEmpty(Password.Text) && Regex.IsMatch(Login.Text, @"^(?!.*\.\.)(?!.*\.$)[^\W][\w.]{0,29}$"))
                MessageBox.Show(":)");
            else
                MessageBox.Show(":(");
        }
    }
}
