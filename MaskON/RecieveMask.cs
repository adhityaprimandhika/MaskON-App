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
    public partial class RecieveMask : Form
    {
        public RecieveMask()
        {
            InitializeComponent();
        }

        //button submit
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (boxRequiredn95.Text == "" || boxRequiredsurgery.Text == "" || boxDropoff.Text == "")
            {
                MessageBox.Show("Please fill all the boxes.");
            }
            else
            {
                //database reciever
                new Ending().Show();
                this.Hide();
            }
        }

        //button back
        private void btnBack_Click(object sender, EventArgs e)
        {
            new Tipe().Show();
            this.Hide();
        }

        //menampilkan jumlah masker N95 yg ada di database
        private void boxN95_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //menampilkan jumlah masker Surgery Mask yg ada di database
        private void boxSurgery_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // bagian bawah ini ga perlu diisi sepertinya, tapi gabisa dihapus //

        //bahan database untuk jumlah masker N95 yang dibutuhkan
        private void boxRequiredn95_TextChanged(object sender, EventArgs e)
        {

        }

        //bahan database untuk jumlah masker Surgery yang dibutuhkan
        private void boxRequiredsurgery_TextChanged(object sender, EventArgs e)
        {

        }

        //bahan database untuk lokasi pengambilan donasi
        private void boxDropoff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
