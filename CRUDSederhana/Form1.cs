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
        static string connectionString = "Server=127.0.0.1;Database=mahasiswa;Uid=root;Pwd=;";
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
                string query = "SELECT NIM, Nama, Email, Telepon, Alamat " +
                    "FROM mahasiswa";
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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                if (txtNIM.Text == "" || txtNama.Text == "" || txtEmail.Text == "" || txtTelepon.Text == "")
                {
                    MessageBox.Show(
                        "Harap isi semua terlebih dahulu", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning
                        );
                    return;
                }

                conn.Open();
                string query = "INSERT INTO mahasiswa (NIM, Nama, Email, Telepon, Alamat) " +
                       "VALUES (@NIM, @Nama, @Email, @Telepon, @Alamat)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NIM", txtNIM.Text);
                cmd.Parameters.AddWithValue("@Nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Telepon", txtTelepon.Text);
                cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show(
                        "Data berhasil ditambahkan", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                        );
                    LoadData();
                    ClearForm();
                } else
                {
                    MessageBox.Show(
                        "Data tidak berhasil ditambahkan", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error
                        );
                }
            } catch (Exception ex)
            {
                MessageBox.Show(
                        "Error : " + ex.Message, "Kesalahan",
                        MessageBoxButtons.OK, MessageBoxIcon.Error
                        );
            }
        }
    }
}
