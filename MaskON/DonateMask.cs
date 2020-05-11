using MaskON_DB_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskON
{
    public partial class DonateMask : Form
    {
        private int n95;
        private int surgery;
        public DonateMask()
        {
            InitializeComponent();
        }

        //button Submit
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Lokasi.Text == "")
            {
                MessageBox.Show("Mohon isi lokasi dengan benar");
            }
            else
            {
                UpdateData();
            }
        }

        //button Back
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        //button refresh
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DBModel db = new DBModel();
            db.openConnection();
            dtgView.DataSource = db.ReadData();
        }

        private void DonateMask_Load(object sender, EventArgs e)
        {
            DBModel db = new DBModel();
            db.openConnection();
            dtgView.DataSource = db.ReadData();
        }

        private void UpdateData()
        {
            DBModel db = new DBModel();
            db.openConnection();
            n95 = Convert.ToInt32(NUD_N95.Value);
            surgery = Convert.ToInt32(NUD_Surgery.Value);
            db.UpdateN95(n95, tb_Lokasi.Text);
            db.UpdateSurgery(surgery, tb_Lokasi.Text);
            if (tb_Lokasi.Text != "")
            {
                EndingDonate ending = new EndingDonate();
                ending.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tolong isi data dengan benar");
            }
        }
    }
}
