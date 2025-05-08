namespace CRUDSederhana
{
    partial class Form1
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
            this.NIM = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Telepon = new System.Windows.Forms.Label();
            this.Alamat = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvMahasiswa = new System.Windows.Forms.DataGridView();
            this.btnImportData = new System.Windows.Forms.Button();
            this.btnAnalisis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // NIM
            // 
            this.NIM.AutoSize = true;
            this.NIM.Location = new System.Drawing.Point(29, 32);
            this.NIM.Name = "NIM";
            this.NIM.Size = new System.Drawing.Size(27, 13);
            this.NIM.TabIndex = 0;
            this.NIM.Text = "NIM";
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(29, 68);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(35, 13);
            this.Nama.TabIndex = 1;
            this.Nama.Text = "Nama";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(29, 114);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email";
            // 
            // Telepon
            // 
            this.Telepon.AutoSize = true;
            this.Telepon.Location = new System.Drawing.Point(29, 161);
            this.Telepon.Name = "Telepon";
            this.Telepon.Size = new System.Drawing.Size(46, 13);
            this.Telepon.TabIndex = 3;
            this.Telepon.Text = "Telepon";
            // 
            // Alamat
            // 
            this.Alamat.AutoSize = true;
            this.Alamat.Location = new System.Drawing.Point(29, 199);
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(39, 13);
            this.Alamat.TabIndex = 4;
            this.Alamat.Text = "Alamat";
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(93, 34);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(224, 20);
            this.txtNIM.TabIndex = 5;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(93, 70);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(224, 20);
            this.txtNama.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(93, 116);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtTelepon
            // 
            this.txtTelepon.Location = new System.Drawing.Point(93, 163);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(224, 20);
            this.txtTelepon.TabIndex = 8;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(93, 201);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(224, 20);
            this.txtAlamat.TabIndex = 9;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(32, 269);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 10;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(137, 269);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(242, 269);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 23);
            this.btnUbah.TabIndex = 12;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(32, 314);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvMahasiswa
            // 
            this.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMahasiswa.Location = new System.Drawing.Point(343, 34);
            this.dgvMahasiswa.Name = "dgvMahasiswa";
            this.dgvMahasiswa.Size = new System.Drawing.Size(433, 389);
            this.dgvMahasiswa.TabIndex = 14;
            this.dgvMahasiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMahasiswa_CellContentClick);
            // 
            // btnImportData
            // 
            this.btnImportData.Location = new System.Drawing.Point(137, 314);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(180, 23);
            this.btnImportData.TabIndex = 15;
            this.btnImportData.Text = "Import Data";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.Location = new System.Drawing.Point(32, 354);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(285, 23);
            this.btnAnalisis.TabIndex = 16;
            this.btnAnalisis.Text = "Analisis";
            this.btnAnalisis.UseVisualStyleBackColor = true;
            this.btnAnalisis.Click += new System.EventHandler(this.btnAnalisis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnalisis);
            this.Controls.Add(this.btnImportData);
            this.Controls.Add(this.dgvMahasiswa);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.Alamat);
            this.Controls.Add(this.Telepon);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.NIM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NIM;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Telepon;
        private System.Windows.Forms.Label Alamat;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvMahasiswa;
        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.Button btnAnalisis;
    }
}

