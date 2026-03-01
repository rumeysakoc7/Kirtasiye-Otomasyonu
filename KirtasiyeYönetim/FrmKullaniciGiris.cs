using Microsoft.Data.SqlClient;

namespace KirtasiyeYönetim
{
    public partial class FrmKullaniciGiris : Form
    {
        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS03;Initial Catalog=KIRTASIYE_YONETIM_DB;Integrated Security=True;TrustServerCertificate=True");
        public FrmKullaniciGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string kullanici = textBoxkullaniciad.Text;
                string sifre =MD5_Sifreleme.MD5_Olustur(textBoxsifre.Text);

                if (string.IsNullOrEmpty(kullanici) || string.IsNullOrEmpty(sifre))
                {
                    MessageBox.Show("Lütfen Kullanıcı Adı ve Şifre alanlarını doldurunuz.");
                    return;
                }

                try
                {
                    sqlBaglanti.Open();
                    string sqlSorgu = "SELECT KullaniciID, Kullanici_Yetkisi, Durum FROM KULLANICILAR WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre";

                    using (SqlCommand command = new SqlCommand(sqlSorgu, sqlBaglanti))
                    {
                        command.Parameters.AddWithValue("@KullaniciAdi", kullanici);
                        command.Parameters.AddWithValue("@Sifre", sifre);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) 
                            {
                                int kullaniciID;
                                if (!int.TryParse(reader["KullaniciID"].ToString(), out kullaniciID))
                                {
                                    MessageBox.Show("Veritabanında Kullanıcı ID geçersiz. Lütfen kontrol edin.");
                                    return;
                                }

                                string yetki = reader["Kullanici_Yetkisi"]?.ToString();
                                int durum = Convert.ToInt32(reader["Durum"]);

                                if (durum == 0) 
                                {
                                    MessageBox.Show("Bu kullanıcı şu anda pasif durumda. Lütfen yöneticiyle iletişime geçin.");
                                    return;
                                }

                                if (string.IsNullOrEmpty(yetki))
                                {
                                    MessageBox.Show("Veritabanında Kullanıcı Yetkisi boş.");
                                    return;
                                }

                                Kullanicierisim.KullaniciID = kullaniciID;
                                Kullanicierisim.KullaniciYetkisi = yetki;

                                MessageBox.Show("Giriş başarılı!");
                                FrmMenu gecis = new FrmMenu(yetki);
                                gecis.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı Adı veya Şifre yanlış.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri tabanı bağlantısında bir hata oluştu, lütfen biraz sonra tekrar deneyiniz.\n" + ex.Message);
                }
                finally
                {
                    if (sqlBaglanti.State == System.Data.ConnectionState.Open)
                    {
                        sqlBaglanti.Close();
                    }
                }
            

        }

        private void linkLabeloturumac_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKayitOl oturumAcForm = new FrmKayitOl();
            oturumAcForm.Show();
            this.Hide();
        }

        private void linkLabelsifremiunuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifreyiUnuttum sifremiunuttumForm = new FrmSifreyiUnuttum();
            sifremiunuttumForm.Show();
            this.Hide();
        }
    }
}
