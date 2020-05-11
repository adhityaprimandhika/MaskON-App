using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaskON_DB_Library;

namespace MaskON
{
    public partial class Register : Form
    {
        Account account;
        private string gender = "";
        private string tipeAkun = "";
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterAccount()
        {
            if (tb_Username.Text != "" && tb_Password.Text != "" && tb_Email.Text != "" && tb_Name.Text != "" && tb_Nik.Text != "" 
                && tb_Phone.Text != "" && tb_Location.Text != "")
            {
                if (dropdown_Gender.SelectedItem.ToString() == "Male")
                    gender = "Male";
                else if (dropdown_Gender.SelectedItem.ToString() == "Female")
                    gender = "Female";

                if (dropdown_Type.SelectedItem.ToString() == "Donator")
                    tipeAkun = "Donator";
                else if (dropdown_Type.SelectedItem.ToString() == "Receiver")
                    tipeAkun = "Receiver";

                using (var db = new DBModel())
                {
                    account = new Account
                    {
                        Username = tb_Username.Text,
                        Password = tb_Password.Text,
                        Email = tb_Email.Text,
                        Nama = tb_Name.Text,
                        NIK = tb_Nik.Text,
                        Lokasi = tb_Location.Text,
                        Gender = gender,
                        NoTelp = tb_Phone.Text,
                        Tipe = tipeAkun
                    };
                    db.Accounts.Add(account);
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Account Created");
                    }
                    catch (DbEntityValidationException ex)
                    {
                        foreach (var entityValidationErrors in ex.EntityValidationErrors)
                        {
                            foreach (var validationError in entityValidationErrors.ValidationErrors)
                            {
                                MessageBox.Show("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                            }
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Please fill your information correctly");
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            this.Hide();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            RegisterAccount();
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
