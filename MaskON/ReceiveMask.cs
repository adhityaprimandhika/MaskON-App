using MaskON_DB_Library;
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
    public partial class ReceiveMask : Form
    {
        public ReceiveMask()
        {
            InitializeComponent();
        }

        private void UploadData()
        {
            Datum datum;
            if (NUD_N95.Value != 0 && NUD_Surgery.Value != 0 && tb_Lokasi.Text != "")
            {
                int n95 = Convert.ToInt32(NUD_N95.Value);
                int surgery = Convert.ToInt32(NUD_Surgery.Value);
                using (var db = new DBModel())
                {
                    datum = new Datum
                    {
                        N95 = n95,
                        Surgery = surgery,
                        Lokasi = tb_Lokasi.Text
                    };
                    db.Data.Add(datum);
                    db.SaveChanges();
                    MessageBox.Show("Saved");
                }
            }
        }

        //button submit
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            UploadData();
            EndingReceive ending = new EndingReceive();
            ending.Show();
            this.Close();
        }

        //button back
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btn_Receive_Refresh_Click(object sender, EventArgs e)
        {
            DBModel db = new DBModel();
            db.openConnection();
            dtgView.DataSource = db.ReadData();
        }

        private void ReceiveMask_Load(object sender, EventArgs e)
        {
            DBModel db = new DBModel();
            db.openConnection();
            dtgView.DataSource = db.ReadData();
        }
    }
}
