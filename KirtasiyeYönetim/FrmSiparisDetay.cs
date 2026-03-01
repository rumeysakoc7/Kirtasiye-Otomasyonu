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
    public partial class FrmSiparisDetay : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS03;Initial Catalog=KIRTASIYE_YONETIM_DB;Integrated Security=True;TrustServerCertificate=True");
        public FrmSiparisDetay()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmSiparisDetay_Load(object sender, EventArgs e)
        {

            string query = @"SELECT 
                                S.SiparisID,
                                M.M_Ad + ' ' + M.M_Soyad AS MusteriAdiSoyadi,
                                S.Siparis_Tarih,
                                S.Toplam_Tutar,
                                S.Odeme_Turu,
                                U.UrunAdi,
                                SD.Miktar,
                                SD.Birim_Fiyat
                             FROM SIPARISLER AS S
                             INNER JOIN MUSTERILER AS M ON S.MusteriID = M.MusteriID
                             INNER JOIN SIPARIS_DETAYLARI AS SD ON S.SiparisID = SD.SiparisID
                             INNER JOIN URUNLER AS U ON SD.UrunID = U.UrunID;";

            // Try-Catch bloğu
            try
            {
                baglanti.Open(); // baglanti nesnesini açın
                SqlDataAdapter da = new SqlDataAdapter(query, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewsiparisdetay.DataSource = dt;

                // DataGridView sütun başlıkları düzenlemesi
                dataGridViewsiparisdetay.Columns["SiparisID"].HeaderText = "Sipariş ID";
                dataGridViewsiparisdetay.Columns["MusteriAdiSoyadi"].HeaderText = "Müşteri Adı Soyadı";
                dataGridViewsiparisdetay.Columns["Siparis_Tarih"].HeaderText = "Sipariş Tarihi";
                dataGridViewsiparisdetay.Columns["Toplam_Tutar"].HeaderText = "Toplam Tutar";
                dataGridViewsiparisdetay.Columns["Odeme_Turu"].HeaderText = "Ödeme Türü";
                dataGridViewsiparisdetay.Columns["UrunAdi"].HeaderText = "Ürün Adı";
                dataGridViewsiparisdetay.Columns["Miktar"].HeaderText = "Miktar";
                dataGridViewsiparisdetay.Columns["Birim_Fiyat"].HeaderText = "Birim Fiyat";
                dataGridViewsiparisdetay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yüklenirken bir hata oluştu: " + ex.Message,
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close(); // Bağlantıyı kapatmayı unutmayın
            }

        }

        private void dateTimePickerTarih_ValueChanged(object sender, EventArgs e)
        {

            // SQL sorgusunu tarihe göre filtrele
            string query = @"SELECT 
                        S.SiparisID,
                        M.M_Ad + ' ' + M.M_Soyad AS MusteriAdiSoyadi,
                        S.Siparis_Tarih,
                        S.Toplam_Tutar,
                        S.Odeme_Turu,
                        U.UrunAdi,
                        SD.Miktar,
                        SD.Birim_Fiyat
                     FROM SIPARISLER AS S
                     INNER JOIN MUSTERILER AS M ON S.MusteriID = M.MusteriID
                     INNER JOIN SIPARIS_DETAYLARI AS SD ON S.SiparisID = SD.SiparisID
                     INNER JOIN URUNLER AS U ON SD.UrunID = U.UrunID
                     WHERE CAST(S.Siparis_Tarih AS DATE) = @SecilenTarih";

            try
            {
                using (SqlConnection conn = new SqlConnection(baglanti.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    // DateTimePicker'dan seçilen tarihi parametre olarak ekle
                    da.SelectCommand.Parameters.AddWithValue("@SecilenTarih", dateTimePickerTarih.Value.Date);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // DatagridView'e yeni veriyi yükle
                    dataGridViewsiparisdetay.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarihe göre filtreleme yapılırken bir hata oluştu: " + ex.Message,
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void textBoxmusteriara_TextChanged(object sender, EventArgs e)
        {

            // SQL sorgusunu müşteri adına göre filtrele
            string query = @"SELECT 
                        S.SiparisID,
                        M.M_Ad + ' ' + M.M_Soyad AS MusteriAdiSoyadi,
                        S.Siparis_Tarih,
                        S.Toplam_Tutar,
                        S.Odeme_Turu,
                        U.UrunAdi,
                        SD.Miktar,
                        SD.Birim_Fiyat
                     FROM SIPARISLER AS S
                     INNER JOIN MUSTERILER AS M ON S.MusteriID = M.MusteriID
                     INNER JOIN SIPARIS_DETAYLARI AS SD ON S.SiparisID = SD.SiparisID
                     INNER JOIN URUNLER AS U ON SD.UrunID = U.UrunID
                     WHERE M.M_Ad + ' ' + M.M_Soyad LIKE @MusteriAdi";

            try
            {
                using (SqlConnection conn = new SqlConnection(baglanti.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    // TextBox'tan girilen değeri SQL parametresi olarak ekle
                    da.SelectCommand.Parameters.AddWithValue("@MusteriAdi", "%" + textBoxmusteriara.Text + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // DatagridView'e yeni veriyi yükle
                    dataGridViewsiparisdetay.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri adına göre filtreleme yapılırken bir hata oluştu: " + ex.Message,
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void textBoxurunadiara_TextChanged(object sender, EventArgs e)
        {
            // SQL sorgusunu ürün adına göre filtrele
            string query = @"SELECT 
                        S.SiparisID,
                        M.M_Ad + ' ' + M.M_Soyad AS MusteriAdiSoyadi,
                        S.Siparis_Tarih,
                        S.Toplam_Tutar,
                        S.Odeme_Turu,
                        U.UrunAdi,
                        SD.Miktar,
                        SD.Birim_Fiyat
                     FROM SIPARISLER AS S
                     INNER JOIN MUSTERILER AS M ON S.MusteriID = M.MusteriID
                     INNER JOIN SIPARIS_DETAYLARI AS SD ON S.SiparisID = SD.SiparisID
                     INNER JOIN URUNLER AS U ON SD.UrunID = U.UrunID
                     WHERE U.UrunAdi LIKE @UrunAdi";

            try
            {
                using (SqlConnection conn = new SqlConnection(baglanti.ConnectionString))
                {
                    // Veri adaptörü kullanarak sorguyu çalıştır
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    // Parametreye TextBox'tan alınan değeri atıyoruz
                    da.SelectCommand.Parameters.AddWithValue("@UrunAdi", "%" + textBoxurunadiara.Text + "%");

                    // Veriyi DataTable'a doldur ve DataGridView'e yansıt
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewsiparisdetay.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün adına göre filtreleme yapılırken bir hata oluştu: " + ex.Message,
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewsiparisdetay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            textBoxmusteriara.Clear();
            textBoxurunadiara.Clear(); 
        }
    }


}
    

