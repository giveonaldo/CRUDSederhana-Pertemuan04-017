using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDSederhana
{
    public partial class Form1: Form
    {
        static string connectionString = "Server=127.0.0.1;Database=Mahasiswa;Uid=root;Pwd=;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ClearForm()
        {
            txtNIM.Clear();
            txtNama.Clear();
            txtEmail.Clear();
            txtTelepon.Clear();
            txtAlamat.Clear();

            // Fokus kembali ke field NIM
            txtNIM.Focus();
        }

        private void LoadData()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "Select NIM, Nama, Email, Telepon, Alamat " +
                    "from Mahasiswa";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMahasiswa.AutoGenerateColumns = true;
                dgvMahasiswa.DataSource = dt;

                // method ClearForm()
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " +
                    ex.Message, "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
    }
}
