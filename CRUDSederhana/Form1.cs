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

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvMahasiswa.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show(
                    "Yakin ingin menghapus data ini?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    );

                if (confirm == DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection(connectionString);

                    try
                    {
                        string nim = dgvMahasiswa.SelectedRows[0].Cells["NIM"].Value.ToString();
                        conn.Open();
                        string query = "DELETE FROM mahasiswa " +
                            "WHERE NIM = @NIM";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@NIM", nim);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "Data berhasil dihapus!", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadData();
                            ClearForm();
                        } else
                        {
                            MessageBox.Show(
                                "Data tidak ditentukan atau gagal dihapus!", "Kesalahan",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    } catch(Exception ex)
                    {
                        MessageBox.Show(
                            "Error : " +
                            ex.Message, "Kesalahan",
                            MessageBoxButtons.OK, MessageBoxIcon.Error
                            );
                    }
                }
            } else
            {
                MessageBox.Show(
                    "Pilih data yang akan dihapus!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();

            MessageBox.Show(
                $"Jumlah Kolom: {dgvMahasiswa.ColumnCount}\n" +
                $"Jumlah Baris: {dgvMahasiswa.RowCount}",
                "Debugging DataDridView",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
        }

        private void dgvMahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMahasiswa.Rows[e.RowIndex];

                txtNIM.Text = row.Cells[0].Value.ToString();
                txtNama.Text = row.Cells[1].Value.ToString();
                txtEmail.Text = row.Cells[2].Value.ToString();
                txtTelepon.Text = row.Cells[3].Value.ToString();
                txtAlamat.Text = row.Cells[4].Value.ToString();
            }
        }

        // Method update
        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvMahasiswa.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Pilih data yang akan diubah!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
                return;
            }

            string nim = dgvMahasiswa.SelectedRows[0].Cells["NIM"].Value.ToString();

            if (txtNama.Text == "" && txtEmail.Text == "" && txtTelepon.Text == "" && txtAlamat.Text == "")
            {
                MessageBox.Show(
                    "Tidak ada data yang diubah!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
                return;
            }

            StringBuilder queryBuilder = new StringBuilder("UPDATE mahasiswa SET ");
            List<MySqlParameter> parameters = new List<MySqlParameter>();

            if (!string.IsNullOrEmpty(txtNama.Text))
            {
                queryBuilder.Append("Nama = @Nama, ");
                parameters.Add(new MySqlParameter("@Nama", txtNama.Text));
            }

            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                queryBuilder.Append("Email = @Email, ");
                parameters.Add(new MySqlParameter("@Email", txtEmail.Text));
            }

            if (!string.IsNullOrEmpty(txtTelepon.Text))
            {
                queryBuilder.Append("Telepon = @Telepon, ");
                parameters.Add(new MySqlParameter("@Telepon", txtTelepon.Text));
            }
            
            if (!string.IsNullOrEmpty(txtAlamat.Text))
            {
                queryBuilder.Append("Alamat = @Alamat, ");
                parameters.Add(new MySqlParameter("@Alamat", txtAlamat.Text));
            }

            queryBuilder.Remove(queryBuilder.Length - 2, 2);

            queryBuilder.Append(" WHERE NIM = @NIM");
            parameters.Add(new MySqlParameter("@NIM", nim));

            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(queryBuilder.ToString(), conn);

                foreach (var param in parameters)
                {
                    cmd.Parameters.Add(param);
                }

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show(
                        "Data berhasil diubah", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                        );
                    LoadData();
                    ClearForm();
                } else
                {
                    MessageBox.Show(
                        "Data tidak ditemukan atau gagal diubah!", "Kesalahan",
                        MessageBoxButtons.OK, MessageBoxIcon.Error
                        );
                }

            } catch (Exception ex)
            {
                MessageBox.Show(
                   "Error: " + ex.Message, "Kesalahan",
                   MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
            }
        }
    }
}
