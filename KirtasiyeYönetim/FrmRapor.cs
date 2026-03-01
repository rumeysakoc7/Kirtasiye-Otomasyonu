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
    public partial class FrmRapor : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS03;Initial Catalog=KIRTASIYE_YONETIM_DB;Integrated Security=True;TrustServerCertificate=True");
        public FrmRapor()
        {
            InitializeComponent();
        }

        private void FrmRapor_Load(object sender, EventArgs e)
        {
            RaporlariListele();
            dataGridViewrapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewrapor.AllowUserToAddRows = false;

        }

        private void RaporlariListele()
        {
            try
            {
                if (baglanti.State != ConnectionState.Open) 
                {
                    baglanti.Open();
                }

                string query = "SELECT * FROM RAPOR";
                SqlDataAdapter da = new SqlDataAdapter(query, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewrapor.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {  //FİLTRELE
            try
            {
                if (baglanti.State != ConnectionState.Open) 
                {
                    baglanti.Open();
                }

                string query = "SELECT * FROM RAPOR WHERE CAST(Rapor_Tarihi AS DATE) >= @Baslangic AND CAST(Rapor_Tarihi AS DATE) <= @Bitis";

                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.Parameters.AddWithValue("@Baslangic", dateTimePickerbaslangic.Value.Date);
                komut.Parameters.AddWithValue("@Bitis", dateTimePickerbitis.Value.Date);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewrapor.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }
        private void dateTimePickerbaslangic_ValueChanged(object sender, EventArgs e)
        {}
        private void dateTimePickerbitis_ValueChanged(object sender, EventArgs e)
        {}
        private void button1_Click(object sender, EventArgs e)
        {
            //HESAPLA
            try
            {
                if (baglanti.State != ConnectionState.Open) 
                {
                    baglanti.Open();
                }

                string query = @"
            INSERT INTO RAPOR (Toplam_Satis, Toplam_Maliyet, Kar_Orani, Satilan_Toplam_Urun, En_Cok_Satan_UrunID)
            SELECT 
                SUM(SD.Birim_Fiyat * SD.Miktar) AS Toplam_Satis,
                SUM(U.Alis_Fiyat * SD.Miktar) AS Toplam_Maliyet,
                (SUM(SD.Birim_Fiyat * SD.Miktar) - SUM(U.Alis_Fiyat * SD.Miktar)) * 100 / NULLIF(SUM(SD.Birim_Fiyat * SD.Miktar), 0) AS Kar_Orani,
                SUM(SD.Miktar) AS Satilan_Toplam_Urun,
                (SELECT TOP 1 SD.UrunID
                 FROM SIPARIS_DETAYLARI SD
                 GROUP BY SD.UrunID
                 ORDER BY SUM(SD.Miktar) DESC) AS En_Cok_Satan_UrunID
            FROM SIPARIS_DETAYLARI SD
            JOIN URUNLER U ON SD.UrunID = U.UrunID";

                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.ExecuteNonQuery();

                MessageBox.Show("Rapor başarıyla oluşturuldu ve eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RaporlariListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }

        }
    }
}
