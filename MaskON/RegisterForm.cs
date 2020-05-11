using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskON
{
    public partial class boxRegister : Form
    {

        public boxRegister()
        {
            InitializeComponent();
        }

        //button Back
        private void buttonBack_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        //button Register
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textFullname.Text == "" || textPassword.Text == "" || textUsername.Text == "" || textEmail.Text == "" || textPhone.Text == "" || textGenderr.Text == "" || textNik.Text == "" || textLocation.Text == "" || textTypee.Text == "")
            {
                MessageBox.Show("All box required to be filled.");
            }
            else
            {
                // databasenya dimasukin kesini
                // sambungin database RegisterForm.cs ke Account.cs agar bisa dipakai Login.cs //
                MessageBox.Show("Registrasi berhasil!");
                new Login().Show();
                this.Hide();
            }
        }








































        // MOHON MAAF GA DIPAKAI TAPI JANGAN DI HAPUS //
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void boxUsername_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
