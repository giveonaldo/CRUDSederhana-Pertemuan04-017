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
    public partial class PreviewData : Form
    {
        static string connectionString = "Server=127.0.0.1;Database=mahasiswa;Uid=root;Pwd=;";
        public PreviewData(DataTable data)
        {
            InitializeComponent();
            dgvPreview.DataSource = data;
        }

        private void PreviewData_Load(object sender, EventArgs e)
        {
            dgvPreview.AutoResizeColumns();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda ingin mengimpor data ini ke database?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ImportDataToDatabase();
            }
        }

        private bool ValidateRow(DataRow row)
        {
            string nim = row["NIM"].ToString();
            if (nim.Length != 11)
            {
                MessageBox.Show("NIM harus terdiri dari 11 karakter!", "Kesalahan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ImportDataToDatabase()
        {
            try
            {
                DataTable dt = (DataTable)dgvPreview.DataSource;

                foreach (DataRow row in dt.Rows)
                {
                    if (!ValidateRow(row))
                    {
                        continue;
                    }

                    string query = "INSERT INTO mahasiswa (NIM, Nama, Email, Telepon, Alamat) VALUES (@NIM, @Nama, @Email, @Telepon, @Alamat)";
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@NIM", row["NIM"]);
                            cmd.Parameters.AddWithValue("@Nama", row["Nama"]);
                            cmd.Parameters.AddWithValue("@Email", row["Email"]);
                            cmd.Parameters.AddWithValue("@Telepon", row["Telepon"]);
                            cmd.Parameters.AddWithValue("@Alamat", row["Alamat"]); 
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
