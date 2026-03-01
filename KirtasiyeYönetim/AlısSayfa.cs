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
    public partial class FrmAlisSayfa : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS03;Initial Catalog=KIRTASIYE_YONETIM_DB;Integrated Security=True;TrustServerCertificate=True");
        private DataTable urunlerTable = new DataTable();
        private decimal toplamTutar = 0;
        public FrmAlisSayfa()
        {
            InitializeComponent();
            YukleVeri();

        }


        private void YukleVeri()
        {

            try
            {
                string query = @"
            SELECT  
                T.TedarikciID, 
                (T.TedarikciAdi + ' ' + T.TedarikciSoyadi) AS TedarikciAdSoyad,
                T.FirmaAdi,
                U.UrunID,
                U.UrunAdi,
                U.StokMiktari,
                U.Fiyat,
                U.Alis_Fiyat
            FROM URUNLER U
            LEFT JOIN TEDARIKCILER T ON T.TedarikciID = U.TedarikciID
            WHERE T.Durum = 1";  

                SqlDataAdapter adp = new SqlDataAdapter(query, baglanti);
                DataTable urunler = new DataTable();
                adp.Fill(urunler);

                dataGridViewalis.DataSource = urunler;

                dataGridViewalis.Columns["TedarikciID"].HeaderText = "Tedarikçi ID";
                dataGridViewalis.Columns["TedarikciAdSoyad"].HeaderText = "Tedarikçi Ad Soyad";
                dataGridViewalis.Columns["FirmaAdi"].HeaderText = "Firma Adı";
                dataGridViewalis.Columns["UrunID"].HeaderText = "Ürün ID";
                dataGridViewalis.Columns["UrunAdi"].HeaderText = "Ürün Adı";
                dataGridViewalis.Columns["StokMiktari"].HeaderText = "Stok Miktarı";
                dataGridViewalis.Columns["Fiyat"].HeaderText = "Ürün Satış Fiyatı (₺)";
                dataGridViewalis.Columns["Alis_Fiyat"].HeaderText = "Ürün Alış Fiyatı (₺)";

                dataGridViewalis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yükleme hatası: " + ex.Message);
            }


        }


        private void buttonekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxurunadi.Text) ||
        string.IsNullOrEmpty(textBoxalisfiyati.Text) ||
        numericUpDownmiktar.Value <= 0)
                {
                    MessageBox.Show("Tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var urunAdi = textBoxurunadi.Text;
                var fiyat = decimal.Parse(textBoxalisfiyati.Text);
                var adet = (int)numericUpDownmiktar.Value;

                var toplam = fiyat * adet;
                toplamTutar += toplam;


                listBoxalissepet.Items.Add($"{urunAdi} - {adet} Adet - {toplam:C}");
                textBoxsepettutarı.Text = toplamTutar.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            textBoxurunadi.Clear();
            textBoxtedarikci.Clear();
            textBoxalisfiyati.Clear();
            numericUpDownmiktar.Value = 0;
        }

        private void dataGridViewalis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var selectedRow = dataGridViewalis.Rows[e.RowIndex];

                    textBoxurunadi.Text = selectedRow.Cells["UrunAdi"]?.Value?.ToString() ?? string.Empty;

                    textBoxtedarikci.Text = selectedRow.Cells["FirmaAdi"]?.Value?.ToString() ?? string.Empty;

                    textBoxalisfiyati.Text = dataGridViewalis.Rows[e.RowIndex].Cells["Alis_Fiyat"]?.Value?.ToString() ?? string.Empty;


                    int urunID = Convert.ToInt16(selectedRow.Cells["UrunID"]?.Value ?? 0);

                    string resimYolu = GetResimYoluFromDatabase(urunID);

                    if (!string.IsNullOrEmpty(resimYolu))
                    {
                        pictureBoxalis.Image = Image.FromFile(resimYolu);
                        pictureBoxalis.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        pictureBoxalis.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string GetResimYoluFromDatabase(int urunID)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string query = "SELECT Urun_Resim FROM URUNLER WHERE UrunID = @UrunID";
                using (SqlCommand cmd = new SqlCommand(query, baglanti))
                {
                    cmd.Parameters.AddWithValue("@UrunID", urunID);

                    object result = cmd.ExecuteScalar();

                    if (result != null && !string.IsNullOrWhiteSpace(result.ToString()))
                    {
                        string resimYolu = result.ToString()?.Replace("\"", "").Trim() ?? string.Empty; ;

                        if (File.Exists(resimYolu))
                        {
                            return resimYolu;
                        }
                        else
                        {
                            MessageBox.Show($"Resim dosyası bulunamadı: {resimYolu}",
                                            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veritabanında resim bilgisi bulunamadı.",
                                        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }
        private void buttontedarikcidenal_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxalissepet.Items.Count == 0)
                {
                    MessageBox.Show("Sepetiniz boş. Lütfen ürün ekleyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(textBoxtedarikci.Text))
                {
                    MessageBox.Show("Lütfen geçerli bir tedarikçi adı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string tedarikciAdi = textBoxtedarikci.Text.Trim();
                int tedarikciID = GetTedarikciIDFromDatabase(tedarikciAdi);
                if (tedarikciID == 0)
                {
                    MessageBox.Show("Girilen tedarikçi adı bulunamadı. Lütfen doğru bir tedarikçi adı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                baglanti.Open();

                foreach (var item in listBoxalissepet.Items)
                {
                    string[] itemDetails = item.ToString().Split('-');
                    string urunAdi = itemDetails[0].Trim();
                    int miktar = int.Parse(itemDetails[1].Replace("Adet", "").Trim());
                    

                    int urunID = GetUrunIDByName(urunAdi);
                    var alisFiyat = GetUrunAlisFiyatByID(urunID);
                   

                    
                    string updateQuery = @"
                UPDATE URUNLER 
                SET Alis_Fiyat = @AlisFiyati 
                WHERE UrunID = @UrunID";

                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, baglanti))
                    {
                        updateCmd.Parameters.AddWithValue("@AlisFiyati", alisFiyat);
                        updateCmd.Parameters.AddWithValue("@UrunID", urunID);
                        updateCmd.ExecuteNonQuery();
                    }

                    string query = @"
                INSERT INTO ALIS_FIYAT (UrunID, Alis_Fiyati, Miktar, Alis_Tarihİ, TedarikciID, Toplam_Tutar)
                VALUES (@UrunID, @AlisFiyati, @Miktar, GETDATE(), @TedarikciID, @ToplamTutar)";

                    using (SqlCommand cmd = new SqlCommand(query, baglanti))
                    {
                        cmd.Parameters.AddWithValue("@UrunID", urunID);
                        cmd.Parameters.AddWithValue("@AlisFiyati", alisFiyat);
                        cmd.Parameters.AddWithValue("@Miktar", miktar);
                        cmd.Parameters.AddWithValue("@TedarikciID", tedarikciID);
                        cmd.Parameters.AddWithValue("@ToplamTutar", toplamTutar);
                        cmd.ExecuteNonQuery();
                    }

                    StokArttir(urunID, miktar);
                }

                baglanti.Close();

                listBoxalissepet.Items.Clear();
                textBoxsepettutarı.Clear();
                dataGridViewalis.DataSource = null;
                textBoxalisfiyati.Clear();
                textBoxtedarikci.Clear();
                textBoxurunadi.Clear();
                numericUpDownmiktar.Value = 0;
                pictureBoxalis.Image = null;

                toplamTutar = 0;

                
                YukleVeri();

                MessageBox.Show("Tüm ürünler başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }


        }

        private int GetUrunIDByName(string urunAdi)
        {
            var query = "SELECT UrunID FROM URUNLER WHERE UrunAdi = @UrunAdi";
            var command = new SqlCommand(query, baglanti);
            command.Parameters.AddWithValue("@UrunAdi", urunAdi);

            var result = command.ExecuteScalar();
            if (result == null || result == DBNull.Value)
            {
                throw new Exception($"Ürün adı '{urunAdi}' bulunamadı.");
            }
            return Convert.ToInt32(result);
        }

        private decimal GetUrunAlisFiyatByID(int urunID)
        {
            var query = "SELECT Alis_Fiyat FROM URUNLER WHERE UrunID = @UrunID";
            var command = new SqlCommand(query, baglanti);
            command.Parameters.AddWithValue("@UrunID", urunID);

            var result = command.ExecuteScalar();
            if (result == null || result == DBNull.Value)
            {
                throw new Exception($"Ürün ID {urunID} için fiyat bulunamadı.");
            }
            return Convert.ToDecimal(result);
        }

        private int GetTedarikciIDFromDatabase(string tedarikciAdi)
        {
            string query = "SELECT TedarikciID FROM TEDARIKCILER WHERE FirmaAdi = @FirmaAdi";
            using (SqlCommand cmd = new SqlCommand(query, baglanti))
            {
                cmd.Parameters.AddWithValue("@FirmaAdi", tedarikciAdi);
                baglanti.Open();
                object result = cmd.ExecuteScalar();
                baglanti.Close();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private void StokArttir(int urunID, int miktar)
        {
            using (var stokCommand = new SqlCommand("UPDATE URUNLER SET StokMiktari = StokMiktari + @Miktar WHERE UrunID = @UrunID", baglanti))
            {
                stokCommand.Parameters.AddWithValue("@Miktar", miktar);
                stokCommand.Parameters.AddWithValue("@UrunID", urunID);
                stokCommand.ExecuteNonQuery();
            }
        }

        private void FrmAlisSayfa_Load(object sender, EventArgs e)
        {
            dataGridViewalis.AllowUserToAddRows = false;
        }

        private void buttonlistboxsil_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxalissepet.SelectedItem != null)
                {
                    listBoxalissepet.Items.Remove(listBoxalissepet.SelectedItem);

                    toplamTutar = 0;
                    foreach (var item in listBoxalissepet.Items)
                    {
                        var itemDetails = item.ToString().Split('-');
                        var total = decimal.Parse(itemDetails[2].Replace(" Adet", "").Trim().Replace("₺", "").Trim());
                        toplamTutar += total;
                    }

                    textBoxsepettutarı.Text = toplamTutar.ToString("C");
                }
                else
                {
                    MessageBox.Show("Lütfen silmek için bir öğe seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void dataGridViewalis_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void textBoxarama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string aramaText = textBoxarama.Text.Trim();

                string sorgu;
                SqlDataAdapter adapter;

                if (string.IsNullOrEmpty(aramaText))
                {
                    sorgu = @"
        SELECT  
            T.TedarikciID, 
            (T.TedarikciAdi + ' ' + T.TedarikciSoyadi) AS TedarikciAdSoyad,
            T.FirmaAdi,
            U.UrunID,
            U.UrunAdi,
            U.StokMiktari,
            U.Fiyat,
            U.Alis_Fiyat
        FROM URUNLER U
        LEFT JOIN TEDARIKCILER T ON T.TedarikciID = U.TedarikciID
        WHERE T.Durum = 1"; 

                    adapter = new SqlDataAdapter(sorgu, baglanti);
                }
                else
                {
                    
                    sorgu = @"
        SELECT  
            T.TedarikciID, 
            (T.TedarikciAdi + ' ' + T.TedarikciSoyadi) AS TedarikciAdSoyad,
            T.FirmaAdi,
            U.UrunID,
            U.UrunAdi,
            U.StokMiktari,
            U.Fiyat,
            U.Alis_Fiyat
        FROM URUNLER U
        LEFT JOIN TEDARIKCILER T ON T.TedarikciID = U.TedarikciID
        WHERE T.Durum = 1 AND U.UrunAdi LIKE @aramaText";  

                    adapter = new SqlDataAdapter(sorgu, baglanti);
                    adapter.SelectCommand.Parameters.AddWithValue("@aramaText", "%" + aramaText + "%");
                }

                DataTable tbl = new DataTable();

                baglanti.Open();
                adapter.Fill(tbl);
                baglanti.Close();

                if (tbl.Rows.Count == 0)
                {
                    tbl = new DataTable();
                    tbl.Columns.Add("Tedarikçi ID");
                    tbl.Columns.Add("Tedarikçi Ad Soyad");
                    tbl.Columns.Add("Firma Adı");
                    tbl.Columns.Add("Ürün ID");
                    tbl.Columns.Add("Ürün Adı");
                    tbl.Columns.Add("Stok Miktarı");
                    tbl.Columns.Add("Ürün Satış Fiyatı (₺)");
                    tbl.Columns.Add("Ürün Alış Fiyatı (₺)");

                    dataGridViewalis.DataSource = tbl;

                    dataGridViewalis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    dataGridViewalis.DataSource = tbl;

                    dataGridViewalis.Columns["TedarikciID"].HeaderText = "Tedarikçi ID";
                    dataGridViewalis.Columns["TedarikciAdSoyad"].HeaderText = "Tedarikçi Ad Soyad";
                    dataGridViewalis.Columns["FirmaAdi"].HeaderText = "Firma Adı";
                    dataGridViewalis.Columns["UrunID"].HeaderText = "Ürün ID";
                    dataGridViewalis.Columns["UrunAdi"].HeaderText = "Ürün Adı";
                    dataGridViewalis.Columns["StokMiktari"].HeaderText = "Stok Miktarı";
                    dataGridViewalis.Columns["Fiyat"].HeaderText = "Ürün Satış Fiyatı (₺)";
                    dataGridViewalis.Columns["Alis_Fiyat"].HeaderText = "Ürün Alış Fiyatı (₺)";

                    dataGridViewalis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
