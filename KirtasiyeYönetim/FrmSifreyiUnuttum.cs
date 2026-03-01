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
    public partial class FrmSifreyiUnuttum : Form
    {
        public FrmSifreyiUnuttum()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBoxkullaniciad.Text;
            string telefon = maskedTextBoxtelno.Text;
            string yeniSifre =MD5_Sifreleme.MD5_Olustur(textBoxsifre.Text);
            string sifreTekrar =MD5_Sifreleme.MD5_Olustur(textBoxsifretekrar.Text);

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(telefon) ||
                string.IsNullOrEmpty(yeniSifre) || string.IsNullOrEmpty(sifreTekrar))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            if (yeniSifre != sifreTekrar)
            {
                MessageBox.Show("Şifreler uyuşmuyor! Lütfen tekrar deneyiniz.");
                return;
            }

            SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS03;Initial Catalog=KIRTASIYE_YONETIM_DB;Integrated Security=True;TrustServerCertificate=True");
            try
            {
                sqlBaglanti.Open();


                string kontrolQuery = "SELECT COUNT(*) FROM KULLANICILAR WHERE KullaniciAdi = @KullaniciAdi AND TelNo = @Telefon";
                using (SqlCommand kontrolCommand = new SqlCommand(kontrolQuery, sqlBaglanti))
                {
                    kontrolCommand.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                    kontrolCommand.Parameters.AddWithValue("@Telefon", telefon);

                    int sonuc = Convert.ToInt32(kontrolCommand.ExecuteScalar());

                    if (sonuc == 0)
                    {
                        MessageBox.Show("Kullanıcı adı veya telefon numarası hatalı!");
                        return;
                    }
                }

                string guncelleQuery = "UPDATE KULLANICILAR SET Sifre = @YeniSifre WHERE KullaniciAdi = @KullaniciAdi AND TelNo = @Telefon";
                using (SqlCommand guncelleCommand = new SqlCommand(guncelleQuery, sqlBaglanti))
                {
                    guncelleCommand.Parameters.AddWithValue("@YeniSifre", yeniSifre);
                    guncelleCommand.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                    guncelleCommand.Parameters.AddWithValue("@Telefon", telefon);

                    int result = guncelleCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Şifre başarıyla güncellendi.");
                        this.Close();
                        FrmKullaniciGiris girisFormu = new FrmKullaniciGiris();
                        girisFormu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Şifre güncelleme başarısız!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                sqlBaglanti.Close();
            }
        }

        private void buttoniptalet_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmKullaniciGiris girisFormu = new FrmKullaniciGiris();
            girisFormu.Show();
        }
    }
}
