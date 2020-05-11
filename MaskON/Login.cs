using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;
using MaskON_DB_Library;

namespace MaskON
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        //untuk check apakah akun telah terdaftar
        private bool ValidateUser(string username, string password)
        {
            DBModel db = new DBModel();
            var query = from Account in db.Accounts where Account.Username == username && Account.Password == password select Account;
            if (query.Any())
            {
                return true;
            }
            else
            {
                MessageBox.Show("Your account not register yet");
                return false;
            }
        }

        private bool CheckDonate(string username)
        {
            DBModel db = new DBModel();
            var query = from Account in db.Accounts where Account.Username == username && Account.Tipe == "Donator" select Account;
            if (query.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckReceive(string username)
        {
            DBModel db = new DBModel();
            var query = from Account in db.Accounts where Account.Username == username && Account.Tipe == "Receiver" select Account;
            if (query.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //button register
        private void btn_Login_Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        //button login
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (tb_Login_Username.Text != "" && tb_Login_Password.Text != "")
            {
                if (ValidateUser(tb_Login_Username.Text, tb_Login_Password.Text))
                {
                    if (CheckDonate(tb_Login_Username.Text))
                    {
                        DonateMask donate = new DonateMask();
                        donate.Show();
                        this.Close();
                    }
                    else if (!CheckDonate(tb_Login_Username.Text))
                    {
                        if (CheckReceive(tb_Login_Username.Text))
                        {
                            ReceiveMask receive = new ReceiveMask();
                            receive.Show();
                            this.Close();
                        }
                        else if (!CheckReceive(tb_Login_Username.Text))
                        {
                            MessageBox.Show("Incorrect Login");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
            else
            {
                MessageBox.Show("Please fill your information correctly");
            }
        }
    }
}