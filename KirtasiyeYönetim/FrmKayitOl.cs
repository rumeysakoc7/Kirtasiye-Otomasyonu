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
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
               string ad = textBoxadi.Text;
                string soyad = textBoxsoyadi.Text;
                string kullaniciAdi = textBoxkullaniciadi.Text;
                string sifre = MD5_Sifreleme.MD5_Olustur(textBoxsifre.Text);
                string yetki = comboBoxyetki.Text;
                string telefon = maskedTextBoxtelno.Text;

                if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(kullaniciAdi) ||
                    string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(yetki) || string.IsNullOrEmpty(telefon))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                    return;
                }

            SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS03;Initial Catalog=KIRTASIYE_YONETIM_DB;Integrated Security=True;TrustServerCertificate=True");
            try
                {
                    sqlBaglanti.Open();

                    string kontrolQuery = "SELECT COUNT(*) FROM KULLANICILAR WHERE KullaniciAdi = @KullaniciAdi";
                    using (SqlCommand kontrolCommand = new SqlCommand(kontrolQuery, sqlBaglanti))
                    {
                        kontrolCommand.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                        int count = (int)kontrolCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Bu kullanıcı adı zaten mevcut. Lütfen farklı bir kullanıcı adı seçin.");
                            return;
                        }
                    }

                    string kontrolTelQuery = "SELECT COUNT(*) FROM KULLANICILAR WHERE TelNo = @TelNo AND Durum = 1";
                    using (SqlCommand kontrolTelCommand = new SqlCommand(kontrolTelQuery, sqlBaglanti))
                    {
                        kontrolTelCommand.Parameters.AddWithValue("@TelNo", telefon);
                        int countTel = (int)kontrolTelCommand.ExecuteScalar();

                        if (countTel > 0)
                        {
                            MessageBox.Show("Bu telefon numarasıyla kayıtlı aktif bir kullanıcı zaten mevcut.");
                            return;
                        }
                    }

                    string kontrolPasifTelQuery = "SELECT COUNT(*) FROM KULLANICILAR WHERE TelNo = @TelNo AND Durum = 0";
                    using (SqlCommand kontrolPasifTelCommand = new SqlCommand(kontrolPasifTelQuery, sqlBaglanti))
                    {
                        kontrolPasifTelCommand.Parameters.AddWithValue("@TelNo", telefon);
                        int countPasifTel = (int)kontrolPasifTelCommand.ExecuteScalar();

                        if (countPasifTel > 0)
                        {
                            MessageBox.Show("Bu telefon numarasıyla kayıtlı bir pasif kullanıcı mevcut. Lütfen yöneticiyle iletişime geçin.");
                            return;
                        }
                    }

                    string sqlEkle = "INSERT INTO KULLANICILAR (KullaniciAD, KullaniciSoyad, KullaniciAdi, Sifre, Kullanici_Yetkisi, TelNo, Durum) " +
                                     "VALUES (@KullaniciAD, @KullaniciSoyad, @KullaniciAdi, @Sifre, @Kullanici_Yetkisi, @TelNo, 1)"; // Durum aktif olarak ekleniyor
                    using (SqlCommand command = new SqlCommand(sqlEkle, sqlBaglanti))
                    {
                        command.Parameters.AddWithValue("@KullaniciAD", ad);
                        command.Parameters.AddWithValue("@KullaniciSoyad", soyad);
                        command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                        command.Parameters.AddWithValue("@Sifre", sifre);
                        command.Parameters.AddWithValue("@Kullanici_Yetkisi", yetki);
                        command.Parameters.AddWithValue("@TelNo", telefon);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Kullanıcı başarı ile kaydedildi.");
                            this.Close();
                            FrmKullaniciGiris geriDon = new FrmKullaniciGiris();
                            geriDon.Show();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı kaydı başarısız!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu:" + ex.Message);
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

        private void FrmKayitOl_Load(object sender, EventArgs e)
        {
          
            comboBoxyetki.DropDownStyle = ComboBoxStyle.DropDownList;

        }
    }
}
