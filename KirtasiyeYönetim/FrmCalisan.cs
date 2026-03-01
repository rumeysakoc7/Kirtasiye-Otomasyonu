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
    public partial class FrmCalisan : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS03;Initial Catalog=KIRTASIYE_YONETIM_DB;Integrated Security=True;TrustServerCertificate=True");
        public FrmCalisan()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void yukle()
        {
            try
            {
                string query = @"
                SELECT C.CalisanID, C.CalisanAdi, C.CalisanSoyadi, C.Unvan, C.Tel_No, 
                       CASE 
                           WHEN C.KullaniciID IS NOT NULL THEN 'Aktif Kullanıcı'
                           ELSE 'Kullanıcı Yok'
                       END AS KullaniciDurumu,
                       C.KullaniciID
                FROM CALISANLAR C;"; 

                SqlDataAdapter adp = new SqlDataAdapter(query, baglanti);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);

                dataGridViewCalisanlar.DataSource = tbl;
                dataGridViewCalisanlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridViewCalisanlar.Columns["KullaniciDurumu"].ReadOnly = true;
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

            if (string.IsNullOrEmpty(textBoxcalisanadi.Text) ||
                  string.IsNullOrEmpty(textBoxcalisansoyadi.Text) ||
               string.IsNullOrEmpty(comboBoxunvan.Text) ||
               !maskedTextBoxtelno.MaskCompleted)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int kaysay;
                baglanti.Open();

                SqlCommand kullaniciKontrolKomut = new SqlCommand(
                "SELECT KullaniciID FROM KULLANICILAR WHERE KullaniciAD = @KullaniciAD AND KullaniciSoyad = @KullaniciSoyad AND TelNo=@TelNo", baglanti);
                kullaniciKontrolKomut.Parameters.AddWithValue("@KullaniciAD", textBoxcalisanadi.Text);
                kullaniciKontrolKomut.Parameters.AddWithValue("@KullaniciSoyad", textBoxcalisansoyadi.Text);
                kullaniciKontrolKomut.Parameters.AddWithValue("@TelNo", maskedTextBoxtelno.Text);

                object kullaniciIdObj = kullaniciKontrolKomut.ExecuteScalar();

                int? kullaniciID = (kullaniciIdObj != null) ? Convert.ToInt16(kullaniciIdObj) : (int?)null;

                SqlCommand komut = new SqlCommand(
                    "INSERT INTO CALISANLAR (CalisanAdi, CalisanSoyadi, Unvan, Ise_Alim_Tarih, Tel_No, KullaniciID) " +
                    "VALUES (@CalisanAdi, @CalisanSoyadi, @Unvan, @IseAlimTarihi, @TelNo, @KullaniciID);", baglanti);

                komut.Parameters.AddWithValue("@CalisanAdi", textBoxcalisanadi.Text);
                komut.Parameters.AddWithValue("@CalisanSoyadi", textBoxcalisansoyadi.Text);
                komut.Parameters.AddWithValue("@Unvan", comboBoxunvan.Text);
                komut.Parameters.AddWithValue("@IseAlimTarihi", DateTime.Now);
                komut.Parameters.AddWithValue("@TelNo", maskedTextBoxtelno.Text);

                if (kullaniciID.HasValue)
                    komut.Parameters.AddWithValue("@KullaniciID", kullaniciID.Value);
                else
                    komut.Parameters.AddWithValue("@KullaniciID", DBNull.Value);

                kaysay = komut.ExecuteNonQuery();

                if (kaysay > 0)
                {
                    MessageBox.Show("Çalışan başarıyla eklendi.");
                    yukle();
                }
                else
                {
                    MessageBox.Show("Kayıt eklenemedi.");
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


        }


        private void buttonsil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCalisanlar.CurrentRow == null)
                {
                    MessageBox.Show("Silmek için bir çalışan seçmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow satir = dataGridViewCalisanlar.CurrentRow;
                string kullaniciDurumu = satir.Cells["KullaniciDurumu"].Value?.ToString();

                if (kullaniciDurumu == "Aktif Kullanıcı")
                {
                    MessageBox.Show("Bu çalışan bir kullanıcıya bağlı olduğu için silinemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int calisanID = Convert.ToInt32(satir.Cells["CalisanID"].Value);
                baglanti.Open();

                SqlCommand komut = new SqlCommand("DELETE FROM CALISANLAR WHERE CalisanID = @CalisanID", baglanti);
                komut.Parameters.AddWithValue("@CalisanID", calisanID);

                int sonuc = komut.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    MessageBox.Show("Çalışan başarıyla silindi.");
                    yukle();
                }
                else
                {
                    MessageBox.Show("Çalışan silinemedi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }


        }

        private void buttonguncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxcalisanadi.Text) || string.IsNullOrEmpty(textBoxcalisansoyadi.Text) ||
             string.IsNullOrEmpty(comboBoxunvan.Text) || string.IsNullOrEmpty(maskedTextBoxtelno.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (dataGridViewCalisanlar.CurrentRow != null)
                {
                    DataGridViewRow satir = dataGridViewCalisanlar.CurrentRow;
                    string kullaniciDurumu = satir.Cells["KullaniciDurumu"].Value?.ToString();

                    if (kullaniciDurumu == "Aktif Kullanıcı")
                    {
                        MessageBox.Show("Bu çalışan bir kullanıcıya bağlı olduğu için güncellenemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(
                        "UPDATE CALISANLAR SET CalisanAdi = @CalisanAdi, CalisanSoyadi = @CalisanSoyadi, Unvan = @Unvan, Tel_No = @TelNo WHERE CalisanID = @CalisanID",
                        baglanti);

                    komut.Parameters.AddWithValue("@CalisanAdi", textBoxcalisanadi.Text);
                    komut.Parameters.AddWithValue("@CalisanSoyadi", textBoxcalisansoyadi.Text);
                    komut.Parameters.AddWithValue("@Unvan", comboBoxunvan.Text);
                    komut.Parameters.AddWithValue("@TelNo", maskedTextBoxtelno.Text);
                    komut.Parameters.AddWithValue("@CalisanID", Convert.ToInt32(satir.Cells["CalisanID"].Value));

                    int sonuc = komut.ExecuteNonQuery();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Çalışan bilgileri başarıyla güncellendi.");
                        yukle();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme başarısız oldu.");
                    }
                }
                else
                {
                    MessageBox.Show("Güncellenecek bir çalışan seçmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            textBoxcalisanadi.Clear();
            textBoxcalisansoyadi.Clear();
            maskedTextBoxtelno.Clear();
            comboBoxunvan.SelectedIndex = -1;
        }

        private void dataGridViewCalisanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {
                    textBoxcalisanadi.Text = dataGridViewCalisanlar.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? string.Empty;
                    textBoxcalisansoyadi.Text = dataGridViewCalisanlar.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? string.Empty;
                    comboBoxunvan.Text = dataGridViewCalisanlar.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? string.Empty;
                    maskedTextBoxtelno.Text = dataGridViewCalisanlar.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? string.Empty;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Çalışan bilgileri alınırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCalisan_Load(object sender, EventArgs e)
        {
            yukle();
            dataGridViewCalisanlar.AllowUserToAddRows = false;
        }
    }
}
