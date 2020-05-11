namespace MaskON
{
    partial class ReceiveMask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiveMask));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgView = new System.Windows.Forms.DataGridView();
            this.btn_Receive_Refresh = new System.Windows.Forms.Button();
            this.NUD_Surgery = new System.Windows.Forms.NumericUpDown();
            this.NUD_N95 = new System.Windows.Forms.NumericUpDown();
            this.lb_N95 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Surgery = new System.Windows.Forms.Label();
            this.tb_Lokasi = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Surgery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_N95)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_Receive_Refresh);
            this.panel1.Controls.Add(this.NUD_Surgery);
            this.panel1.Controls.Add(this.NUD_N95);
            this.panel1.Controls.Add(this.lb_N95);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_Surgery);
            this.panel1.Controls.Add(this.tb_Lokasi);
            this.panel1.Controls.Add(this.btn_Submit);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 756);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgView);
            this.panel2.Location = new System.Drawing.Point(457, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 164);
            this.panel2.TabIndex = 47;
            // 
            // dtgView
            // 
            this.dtgView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgView.Location = new System.Drawing.Point(0, -1);
            this.dtgView.Margin = new System.Windows.Forms.Padding(6);
            this.dtgView.Name = "dtgView";
            this.dtgView.RowHeadersWidth = 51;
            this.dtgView.Size = new System.Drawing.Size(320, 165);
            this.dtgView.TabIndex = 37;
            // 
            // btn_Receive_Refresh
            // 
            this.btn_Receive_Refresh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Receive_Refresh.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Receive_Refresh.Location = new System.Drawing.Point(570, 566);
            this.btn_Receive_Refresh.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Receive_Refresh.Name = "btn_Receive_Refresh";
            this.btn_Receive_Refresh.Size = new System.Drawing.Size(107, 37);
            this.btn_Receive_Refresh.TabIndex = 46;
            this.btn_Receive_Refresh.Text = "Refresh";
            this.btn_Receive_Refresh.UseVisualStyleBackColor = false;
            this.btn_Receive_Refresh.Click += new System.EventHandler(this.btn_Receive_Refresh_Click);
            // 
            // NUD_Surgery
            // 
            this.NUD_Surgery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.NUD_Surgery.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_Surgery.Location = new System.Drawing.Point(805, 436);
            this.NUD_Surgery.Margin = new System.Windows.Forms.Padding(6);
            this.NUD_Surgery.Name = "NUD_Surgery";
            this.NUD_Surgery.Size = new System.Drawing.Size(245, 24);
            this.NUD_Surgery.TabIndex = 45;
            // 
            // NUD_N95
            // 
            this.NUD_N95.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.NUD_N95.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_N95.Location = new System.Drawing.Point(805, 369);
            this.NUD_N95.Margin = new System.Windows.Forms.Padding(6);
            this.NUD_N95.Name = "NUD_N95";
            this.NUD_N95.Size = new System.Drawing.Size(245, 24);
            this.NUD_N95.TabIndex = 44;
            // 
            // lb_N95
            // 
            this.lb_N95.AutoSize = true;
            this.lb_N95.BackColor = System.Drawing.SystemColors.Control;
            this.lb_N95.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_N95.Location = new System.Drawing.Point(801, 339);
            this.lb_N95.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_N95.Name = "lb_N95";
            this.lb_N95.Size = new System.Drawing.Size(35, 16);
            this.lb_N95.TabIndex = 38;
            this.lb_N95.Text = "N95";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(801, 473);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Lokasi";
            // 
            // lb_Surgery
            // 
            this.lb_Surgery.AutoSize = true;
            this.lb_Surgery.BackColor = System.Drawing.SystemColors.Control;
            this.lb_Surgery.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Surgery.Location = new System.Drawing.Point(801, 406);
            this.lb_Surgery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Surgery.Name = "lb_Surgery";
            this.lb_Surgery.Size = new System.Drawing.Size(57, 16);
            this.lb_Surgery.TabIndex = 39;
            this.lb_Surgery.Text = "Surgery\r\n";
            // 
            // tb_Lokasi
            // 
            this.tb_Lokasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_Lokasi.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Lokasi.Location = new System.Drawing.Point(805, 503);
            this.tb_Lokasi.Margin = new System.Windows.Forms.Padding(6);
            this.tb_Lokasi.Name = "tb_Lokasi";
            this.tb_Lokasi.Size = new System.Drawing.Size(245, 24);
            this.tb_Lokasi.TabIndex = 42;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Submit.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(805, 566);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(105, 37);
            this.btn_Submit.TabIndex = 40;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Back.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(943, 566);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(107, 37);
            this.btn_Back.TabIndex = 41;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MaskON.Properties.Resources.Group_37;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1240, 756);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // ReceiveMask
            // 
            this.ClientSize = new System.Drawing.Size(1260, 749);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReceiveMask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Surgery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_N95)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Receive_Refresh;
        private System.Windows.Forms.NumericUpDown NUD_Surgery;
        private System.Windows.Forms.NumericUpDown NUD_N95;
        private System.Windows.Forms.Label lb_N95;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Surgery;
        private System.Windows.Forms.TextBox tb_Lokasi;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DataGridView dtgView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}