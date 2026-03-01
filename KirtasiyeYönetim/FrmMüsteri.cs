using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KirtasiyeYönetim
{
    public partial class FrmMüsteri : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS03;Initial Catalog=KIRTASIYE_YONETIM_DB;Integrated Security=True;TrustServerCertificate=True");
        public FrmMüsteri()
        {
            InitializeComponent();
        }

        public void yukle(string filter = "Aktif")
        {
            try
            {
                string query = "SELECT * FROM MUSTERILER";
                if (filter == "Aktif")
                {
                    query += " WHERE Durum = 1"; 
                }
                else if (filter == "Pasif")
                {
                    query += " WHERE Durum = 0";
                }
                query += " ORDER BY Durum DESC, M_Ad ASC"; 

                SqlDataAdapter adp = new SqlDataAdapter(query, baglanti);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);

                dataGridViewmusteriler.DataSource = tbl;
                dataGridViewmusteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yükleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonlistele_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxmusteriadi.Text.Trim()) || string.IsNullOrEmpty(textBoxmusterisoyadi.Text.Trim()) ||
                 string.IsNullOrEmpty(maskedTextBoxtelno.Text.Trim()) || string.IsNullOrEmpty(textBoxadres.Text.Trim()))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                int kaysay;
                baglanti.Open();

                SqlCommand komut = new SqlCommand("INSERT INTO MUSTERILER (M_ad, M_Soyad, Telefon, Adres) VALUES (@M_ad, @M_Soyad, @Telefon, @Adres)",baglanti);

                komut.Parameters.AddWithValue("@M_ad", textBoxmusteriadi.Text);
                komut.Parameters.AddWithValue("@M_Soyad", textBoxmusterisoyadi.Text);
                komut.Parameters.AddWithValue("@Telefon", maskedTextBoxtelno.Text);
                komut.Parameters.AddWithValue("@Adres", textBoxadres.Text);
                komut.Parameters.AddWithValue("@Durum", 1);
                kaysay = komut.ExecuteNonQuery();

                if (kaysay > 0)
                {
                    MessageBox.Show("Kayıt eklendi");
                }
                else
                {
                    MessageBox.Show("Hatalı kayıt ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
            yukle();
        }

        public bool pasifYap(int musteriid)
        {
            int sonuc = 0;
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE MUSTERILER SET Durum = 0  WHERE  MusteriID=@MusteriID", baglanti);
                komut.Parameters.AddWithValue("@MusteriID", musteriid);

                sonuc = komut.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {

            try
            {

                if (dataGridViewmusteriler.CurrentRow != null)
                {
                    DataGridViewRow satir = dataGridViewmusteriler.CurrentRow;

                    int secid = Convert.ToInt16(satir.Cells[0].Value);

                    bool pasifYapildi = pasifYap(secid);

                    if (pasifYapildi)
                    {
                        MessageBox.Show("Kayıt başarıyla silindi.");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt silinemedi.");
                    }

                    yukle();
                }
                else
                {
                    MessageBox.Show("Silmek için bir satır seçmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            textBoxadres.Clear();
            textBoxmusteriadi.Clear();
            textBoxmusteriadi.Clear();
            textBoxmusterisoyadi.Clear();
            maskedTextBoxtelno.Clear();

        }

        private void buttonguncelle_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(textBoxmusteriadi.Text.Trim()) || string.IsNullOrEmpty(textBoxmusterisoyadi.Text.Trim()) ||
            string.IsNullOrEmpty(maskedTextBoxtelno.Text.Trim()) || string.IsNullOrEmpty(textBoxadres.Text.Trim()))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
                if (dataGridViewmusteriler.CurrentRow != null)
                {

                    int musteriID = Convert.ToInt16(dataGridViewmusteriler.CurrentRow.Cells["MusteriID"].Value);

                    string musteriAdi = textBoxmusteriadi.Text.Trim();
                    string musteriSoyadi = textBoxmusterisoyadi.Text.Trim();
                    string telefon = maskedTextBoxtelno.Text.Trim();
                    string adres = textBoxadres.Text.Trim();

                    int durum = 1;
                    string query = "UPDATE MUSTERILER SET M_Ad = @M_Ad, M_Soyad = @M_Soyad, Telefon = @Telefon, Adres = @Adres, Durum = @Durum WHERE MusteriID = @MusteriID";

                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@M_Ad", musteriAdi);
                    komut.Parameters.AddWithValue("@M_Soyad", musteriSoyadi);
                    komut.Parameters.AddWithValue("@Telefon", telefon);
                    komut.Parameters.AddWithValue("@Adres", adres);
                    komut.Parameters.AddWithValue("@MusteriID", musteriID);
                    komut.Parameters.AddWithValue("@Durum", durum);

                    baglanti.Open();
                    int etkilenenSatirSayisi = komut.ExecuteNonQuery();
                    baglanti.Close();


                    if (etkilenenSatirSayisi > 0)
                    {
                        MessageBox.Show("Müşteri başarıyla güncellendi.");
                        yukle();
                    }
                    else
                    {
                        MessageBox.Show("Müşteri güncellenemedi.");
                    }
                }
                else
                {
                    MessageBox.Show("Güncellenecek bir müşteri seçmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridViewmusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    textBoxmusteriadi.Text = dataGridViewmusteriler.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? string.Empty;
                    textBoxmusterisoyadi.Text = dataGridViewmusteriler.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? string.Empty;
                    textBoxadres.Text = dataGridViewmusteriler.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? string.Empty;
                    maskedTextBoxtelno.Text = dataGridViewmusteriler.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? string.Empty;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri bilgileri alınırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewmusteriler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dataGridViewmusteriler.Columns["Durum"] != null && e.ColumnIndex == dataGridViewmusteriler.Columns["Durum"].Index)
                {

                    int durum = Convert.ToInt32(dataGridViewmusteriler.Rows[e.RowIndex].Cells["Durum"].Value);

                    if (durum == 0)
                    {
                        dataGridViewmusteriler.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                        dataGridViewmusteriler.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGray;
                    }
                    else
                    {
                        dataGridViewmusteriler.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        dataGridViewmusteriler.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Renk ayarı sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMüsteri_Load(object sender, EventArgs e)
        {
            
            dataGridViewmusteriler.CellFormatting += dataGridViewmusteriler_CellFormatting;
            dataGridViewmusteriler.AllowUserToAddRows = false;
            yukle("Aktif"); 
            checkBoxaktif.Checked = true;
        }

        private void textBoxmusteriara_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string musteriAdi = textBoxmusteriara.Text.Trim();


                string query = "SELECT * FROM MUSTERILER WHERE M_Ad LIKE @M_Ad";

                baglanti.Open();

                SqlDataAdapter adp = new SqlDataAdapter(query, baglanti);
                adp.SelectCommand.Parameters.AddWithValue("@M_Ad", "%" + musteriAdi + "%");

                DataTable tbl = new DataTable();
                adp.Fill(tbl);

                dataGridViewmusteriler.DataSource = tbl;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void checkBoxaktif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxaktif.Checked)
            {
                checkBoxpasif.Checked = false; 
                yukle("Aktif");
            }
        }

        private void checkBoxpasif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpasif.Checked)
            {
                checkBoxaktif.Checked = false; 
                yukle("Pasif");
            }
        }
    }
}
