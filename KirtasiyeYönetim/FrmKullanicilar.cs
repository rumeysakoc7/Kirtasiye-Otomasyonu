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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KirtasiyeYönetim
{
    public partial class FrmKullanicilar : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS03;Initial Catalog=KIRTASIYE_YONETIM_DB;Integrated Security=True;TrustServerCertificate=True");
        public FrmKullanicilar()
        {
            InitializeComponent();
        }
        public void yukle(string filter = "Aktif")
        {
            try
            {
                string query = "SELECT * FROM KULLANICILAR";
                if (filter == "Aktif")
                    query += " WHERE Durum = 1";
                else if (filter == "Pasif")
                    query += " WHERE Durum = 0";

                SqlDataAdapter adp = new SqlDataAdapter(query, baglanti);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dataGridViewkullanicilar.DataSource = tbl;
                dataGridViewkullanicilar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yükleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonlistele_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxkullaniciadi.Text.Trim()) || string.IsNullOrEmpty(textBoxsifre.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxadi.Text.Trim()) || string.IsNullOrEmpty(textBoxsoyadi.Text.Trim()) ||
                    string.IsNullOrEmpty(comboBoxkullaniciyetki.Text.Trim()) || string.IsNullOrEmpty(maskedTextBoxtelno.Text.Trim()))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                int kaysay;
                baglanti.Open();

                SqlCommand komut = new SqlCommand(@"INSERT INTO KULLANICILAR 
                        (KullaniciAdi, Sifre, KullaniciAD, KullaniciSoyad, Kullanici_Yetkisi, TelNo) 
                        VALUES (@KullaniciAdi, @Sifre, @KullaniciAD, @KullaniciSoyad, @Kullanici_Yetkisi, @TelNo)", baglanti);
                komut.Parameters.AddWithValue("@KullaniciAD", textBoxadi.Text);
                komut.Parameters.AddWithValue("@KullaniciSoyad", textBoxsoyadi.Text);
                komut.Parameters.AddWithValue("@Kullanici_Yetkisi", comboBoxkullaniciyetki.Text);
                komut.Parameters.AddWithValue("@KullaniciAdi", textBoxkullaniciadi.Text);
                komut.Parameters.AddWithValue("@Sifre", textBoxsifre.Text);
                komut.Parameters.AddWithValue("@TelNo", maskedTextBoxtelno.Text);
               
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

        public bool Pasif(int kullaniciid)
        {
            int sonuc = 0;
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE KULLANICILAR SET Durum = 0  WHERE  KullaniciID = @KullaniciID", baglanti);
                komut.Parameters.AddWithValue("@KullaniciID", kullaniciid);

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
                MessageBox.Show("Silme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                if (dataGridViewkullanicilar.CurrentRow != null)
                {
                    DataGridViewRow satir = dataGridViewkullanicilar.CurrentRow;

                    int secid = Convert.ToInt16(satir.Cells[0].Value);

                    bool pasifyapildi = Pasif(secid);

                    if (pasifyapildi)
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

        private void buttonguncelle_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(textBoxkullaniciadi.Text.Trim()) || string.IsNullOrEmpty(textBoxsifre.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxadi.Text.Trim()) || string.IsNullOrEmpty(textBoxsoyadi.Text.Trim()) ||
                    string.IsNullOrEmpty(comboBoxkullaniciyetki.Text.Trim()) || string.IsNullOrEmpty(maskedTextBoxtelno.Text.Trim()))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                if (dataGridViewkullanicilar.CurrentRow != null)
                {

                    int kullaniciID = Convert.ToInt32(dataGridViewkullanicilar.CurrentRow.Cells["KullaniciID"].Value);


                    string kullaniciAdi = textBoxkullaniciadi.Text.Trim();
                    string sifre = textBoxsifre.Text.Trim();
                    string kullaniciAD = textBoxadi.Text.Trim();
                    string kullaniciSoyad = textBoxsoyadi.Text.Trim();
                    string kullaniciYetkisi = comboBoxkullaniciyetki.Text.Trim();
                    string telNo = maskedTextBoxtelno.Text.Trim();

                    int durum = 1;
                    string query = "UPDATE KULLANICILAR SET KullaniciAdi = @KullaniciAdi, Sifre = @Sifre, KullaniciAD = @KullaniciAD, KullaniciSoyad = @KullaniciSoyad, Kullanici_Yetkisi = @Kullanici_Yetkisi, TelNo = @TelNo, Durum = @Durum WHERE KullaniciID = @KullaniciID";

                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                    komut.Parameters.AddWithValue("@Sifre", sifre);
                    komut.Parameters.AddWithValue("@KullaniciAD", kullaniciAD);
                    komut.Parameters.AddWithValue("@KullaniciSoyad", kullaniciSoyad);
                    komut.Parameters.AddWithValue("@Kullanici_Yetkisi", kullaniciYetkisi);
                    komut.Parameters.AddWithValue("@TelNo", telNo);
                    komut.Parameters.AddWithValue("@KullaniciID", kullaniciID);
                    komut.Parameters.AddWithValue("@Durum", durum);


                    baglanti.Open();
                    int etkilenenSatirSayisi = komut.ExecuteNonQuery();
                    baglanti.Close();

                    if (etkilenenSatirSayisi > 0)
                    {
                        MessageBox.Show("Kullanıcı başarıyla güncellendi.");
                        yukle();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı güncellenemedi.");
                    }
                }
                else
                {
                    MessageBox.Show("Güncellenecek bir kullanıcı seçmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            textBoxadi.Clear();
            textBoxsoyadi.Clear();
            textBoxsifre.Clear();
            textBoxkullaniciadi.Clear();
            comboBoxkullaniciyetki.SelectedIndex = -1;
            maskedTextBoxtelno.Clear();

        }

        private void dataGridViewkullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    textBoxadi.Text = dataGridViewkullanicilar.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? string.Empty;
                    textBoxsoyadi.Text = dataGridViewkullanicilar.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? string.Empty;
                    comboBoxkullaniciyetki.Text = dataGridViewkullanicilar.Rows[e.RowIndex].Cells[5].Value?.ToString() ?? string.Empty;
                    textBoxkullaniciadi.Text = dataGridViewkullanicilar.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? string.Empty;
                    textBoxsifre.Text = dataGridViewkullanicilar.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? string.Empty;
                    maskedTextBoxtelno.Text = dataGridViewkullanicilar.Rows[e.RowIndex].Cells[6].Value?.ToString() ?? string.Empty;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri bilgileri alınırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmKullanicilar_Load(object sender, EventArgs e)
        {
            
            dataGridViewkullanicilar.AllowUserToAddRows = false;
            dataGridViewkullanicilar.CellFormatting += dataGridViewkullanicilar_CellFormatting;
            yukle("Aktif");

            checkBoxaktif.Checked = true;
        }

        private void dataGridViewkullanicilar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            try
            {
                if (dataGridViewkullanicilar.Columns["Durum"] != null && e.ColumnIndex == dataGridViewkullanicilar.Columns["Durum"].Index)
                {

                    int durum = Convert.ToInt32(dataGridViewkullanicilar.Rows[e.RowIndex].Cells["Durum"].Value);

                    if (durum == 0)
                    {
                        dataGridViewkullanicilar.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                        dataGridViewkullanicilar.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGray;
                    }
                    else
                    {
                        dataGridViewkullanicilar.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        dataGridViewkullanicilar.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Renk ayarı sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
