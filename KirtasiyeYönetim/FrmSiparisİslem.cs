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
    public partial class FrmSiparisİslem : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS03;Initial Catalog=KIRTASIYE_YONETIM_DB;Integrated Security=True;TrustServerCertificate=True");
        private DataTable urunlerTable = new DataTable();
        private decimal toplamTutar = 0;

        public FrmSiparisİslem()
        {
            InitializeComponent();
            KategorileriGetir();
            MusterileriGetir();
            UrunleriGetir();

        }

        private void KategorileriGetir()
        {
            try
            {
                string query = "SELECT KategoriID, KategoriAdi FROM KATEGORILER";
                SqlDataAdapter adp = new SqlDataAdapter(query, baglanti);
                DataTable kategoriler = new DataTable();
                adp.Fill(kategoriler);

                DataRow emptyRow = kategoriler.NewRow();
                emptyRow["KategoriID"] = -1;
                emptyRow["KategoriAdi"] = "Tümü";
                kategoriler.Rows.InsertAt(emptyRow, 0);

                comboBoxkategorisec.DataSource = kategoriler;
                comboBoxkategorisec.DisplayMember = "KategoriAdi";
                comboBoxkategorisec.ValueMember = "KategoriID";

                comboBoxkategorisec.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MusterileriGetir()
        {
            try
            {
                string query = "SELECT MusteriID, M_Ad, M_Soyad FROM MUSTERILER WHERE Durum = 1";

                SqlDataAdapter adp = new SqlDataAdapter(query, baglanti);
                DataTable musteriler = new DataTable();
                adp.Fill(musteriler);

                dataGridViewmusteri.DataSource = musteriler;
                dataGridViewmusteri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteriler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UrunleriGetir()
        {
            try
            {
                string query = "SELECT UrunID, UrunAdi, KategoriID, Fiyat FROM URUNLER WHERE Durum = 1";


                SqlDataAdapter adp = new SqlDataAdapter(query, baglanti);
                DataTable urunler = new DataTable();
                adp.Fill(urunler);

                dataGridViewurun.DataSource = urunler;
                dataGridViewurun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürünler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonsiparisekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetSelectedMusteriID() == 0)
                {
                    MessageBox.Show("Lütfen bir müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(comboBoxodemetur.Text))
                {
                    MessageBox.Show("Lütfen ödeme türünü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (listBoxurunsepet.Items.Count == 0)
                {
                    MessageBox.Show("Sepetinizde ürün bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                baglanti.Open();

                var siparisCommand = new SqlCommand(
                    "INSERT INTO SIPARISLER (MusteriID, Siparis_Tarih, Toplam_Tutar, Odeme_Turu,Kullanici_ID ) VALUES (@MusteriID, GETDATE(), @ToplamTutar, @OdemeTuru, @Kullanici_ID); SELECT SCOPE_IDENTITY();",
                    baglanti);
                siparisCommand.Parameters.AddWithValue("@MusteriID", GetSelectedMusteriID());
                siparisCommand.Parameters.AddWithValue("@ToplamTutar", toplamTutar);
                siparisCommand.Parameters.AddWithValue("@OdemeTuru", comboBoxodemetur.Text);
                siparisCommand.Parameters.AddWithValue("@Kullanici_ID", Kullanicierisim.KullaniciID);

                var siparisID = Convert.ToInt32(siparisCommand.ExecuteScalar());

                foreach (var item in listBoxurunsepet.Items)
                {
                    var urunBilgi = item.ToString().Split('-');
                    var urunAdi = urunBilgi[0].Trim();
                    var adet = int.Parse(urunBilgi[1].Replace("Adet", "").Trim());

                    var urunID = GetUrunIDByName(urunAdi);
                    var birimFiyat = GetUrunFiyatByID(urunID);

                    if (!StokGuncelle(urunID, adet))
                    {
                        throw new Exception($"{urunAdi} için yeterli stok bulunmamaktadır.");
                    }

                    var detayCommand = new SqlCommand(
                        "INSERT INTO SIPARIS_DETAYLARI (SiparisID, UrunID, Miktar, Birim_Fiyat) VALUES (@SiparisID, @UrunID, @Miktar, @BirimFiyat)",
                        baglanti);
                    detayCommand.Parameters.AddWithValue("@SiparisID", siparisID);
                    detayCommand.Parameters.AddWithValue("@UrunID", urunID);
                    detayCommand.Parameters.AddWithValue("@Miktar", adet);
                    detayCommand.Parameters.AddWithValue("@BirimFiyat", birimFiyat);

                    detayCommand.ExecuteNonQuery();
                }
                listBoxurunsepet.Items.Clear();
                textBoxtoplamtutar.Clear();
                dataGridViewmusteri.DataSource = null;
                dataGridViewurun.DataSource = null;
                comboBoxkategorisec.SelectedIndex = -1;
                textBoxmusteribilgi.Clear();
                textBoxurunad.Clear();
                textBoxurunfiyat.Clear();
                comboBoxodemetur.SelectedIndex = -1;
                numericUpDownurunadet.Value = 0;
                pictureBoxurunresim.Image = null;

                MusterileriGetir();
                UrunleriGetir();

                MessageBox.Show("Sipariş başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
            finally
            {
                baglanti.Close();
            }
        }
        private int GetSelectedMusteriID()
        {
            if (dataGridViewmusteri.SelectedRows.Count == 0)
            {
                throw new Exception("Lütfen bir müşteri seçiniz.");
            }
            return int.Parse(dataGridViewmusteri.SelectedRows[0].Cells["MusteriID"].Value.ToString());
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

        private decimal GetUrunFiyatByID(int urunID)
        {
            var query = "SELECT Fiyat FROM URUNLER WHERE UrunID = @UrunID";
            var command = new SqlCommand(query, baglanti);
            command.Parameters.AddWithValue("@UrunID", urunID);

            var result = command.ExecuteScalar();
            if (result == null || result == DBNull.Value)
            {
                throw new Exception($"Ürün ID {urunID} için fiyat bulunamadı.");
            }
            return Convert.ToDecimal(result);
        }

        private bool StokGuncelle(int urunID, int miktar)
        {
            using (var stokCommand = new SqlCommand("SELECT StokMiktari FROM URUNLER WHERE UrunID = @UrunID", baglanti))
            {
                stokCommand.Parameters.AddWithValue("@UrunID", urunID);
                var mevcutStok = Convert.ToInt32(stokCommand.ExecuteScalar());

                if (mevcutStok < miktar)
                {
                    return false;
                }

                using (var updateCommand = new SqlCommand("UPDATE URUNLER SET StokMiktari = StokMiktari - @Miktar WHERE UrunID = @UrunID", baglanti))
                {
                    updateCommand.Parameters.AddWithValue("@Miktar", miktar);
                    updateCommand.Parameters.AddWithValue("@UrunID", urunID);
                    updateCommand.ExecuteNonQuery();
                }
            }
            return true;
        }
        private void buttontemizle_Click(object sender, EventArgs e)
        {
            textBoxmusteribilgi.Clear();
            textBoxurunad.Clear();
            textBoxurunfiyat.Clear();
            comboBoxodemetur.SelectedIndex = -1;
            numericUpDownurunadet.Value = 0;
        }

        private void FrmSiparisİslem_Load(object sender, EventArgs e)
        {
            try
            {
               
                KategorileriGetir();
                MusterileriGetir();
                UrunleriGetir();
                dataGridViewmusteri.AllowUserToAddRows = false;
                dataGridViewurun.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Form yüklenirken hata oluştu: {ex.Message}");
            }
        }

        private void comboBoxkategorisec_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (comboBoxkategorisec.SelectedValue is int selectedCategoryID)
                {
                    string query;
                    if (selectedCategoryID == -1)
                    {
                        query = "SELECT UrunID, UrunAdi, KategoriID, Fiyat FROM URUNLER WHERE Durum = 1";
                    }
                    else
                    {
                        query = "SELECT UrunID, UrunAdi, KategoriID, Fiyat FROM URUNLER WHERE Durum = 1 AND KategoriID = @KategoriID";
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);

                    if (selectedCategoryID != -1)
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@KategoriID", selectedCategoryID);
                    }

                    DataTable tbl = new DataTable();
                    baglanti.Open();
                    adapter.Fill(tbl);
                    baglanti.Close();

                    if (tbl.Rows.Count > 0)
                    {
                        dataGridViewurun.DataSource = tbl; 
                    }
                    else
                    {
                        MessageBox.Show("Seçilen kategoriye ait ürün bulunamadı.");
                    }
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

        private void dataGridViewmusteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var selectedRow = dataGridViewmusteri.Rows[e.RowIndex];
                    var ad = selectedRow.Cells["M_Ad"].Value?.ToString();
                    var soyad = selectedRow.Cells["M_Soyad"].Value?.ToString();

                    if (!string.IsNullOrEmpty(ad) && !string.IsNullOrEmpty(soyad))
                    {
                        textBoxmusteribilgi.Text = $"{ad} {soyad}";
                    }
                    else
                    {
                        textBoxmusteribilgi.Text = "Bilinmeyen müşteri.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void dataGridViewurun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var selectedRow = dataGridViewurun.Rows[e.RowIndex];

                    textBoxurunad.Text = selectedRow.Cells["UrunAdi"]?.Value?.ToString() ?? string.Empty;
                    textBoxurunfiyat.Text = selectedRow.Cells["Fiyat"]?.Value?.ToString() ?? string.Empty;

                    int urunID = Convert.ToInt16(selectedRow.Cells["UrunID"]?.Value ?? 0);

                    string resimYolu = GetResimYoluFromDatabase(urunID);

                    if (!string.IsNullOrEmpty(resimYolu))
                    {
                        pictureBoxurunresim.Image = Image.FromFile(resimYolu);
                        pictureBoxurunresim.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        pictureBoxurunresim.Image = null;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxurunad.Text.Trim()) ||
        string.IsNullOrEmpty(textBoxurunfiyat.Text.Trim()) ||
        numericUpDownurunadet.Value <= 0)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
                var urunAdi = textBoxurunad.Text;
                var fiyat = decimal.Parse(textBoxurunfiyat.Text);
                var adet = (int)numericUpDownurunadet.Value;

                var toplam = fiyat * adet;
                toplamTutar += toplam;


                listBoxurunsepet.Items.Add($"{urunAdi} - {adet} Adet - {toplam:C}");
                textBoxtoplamtutar.Text = toplamTutar.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void buttonurunlistboxsil_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxurunsepet.SelectedItem != null)
                {
                    listBoxurunsepet.Items.Remove(listBoxurunsepet.SelectedItem);

                    toplamTutar = 0;
                    foreach (var item in listBoxurunsepet.Items)
                    {
                        var itemDetails = item.ToString().Split('-');
                        var total = decimal.Parse(itemDetails[2].Replace(" Adet", "").Trim().Replace("₺", "").Trim());
                        toplamTutar += total;
                    }

                    textBoxtoplamtutar.Text = toplamTutar.ToString("C");
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

        private void pictureBoxurunresim_Click(object sender, EventArgs e)
        {
        }
        private void dataGridViewurun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void textBoxurunara_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string aramaText = textBoxurunara.Text.Trim();

                if (string.IsNullOrEmpty(aramaText))
                {
                    string sorgu = "SELECT UrunID, UrunAdi, KategoriID, Fiyat FROM URUNLER WHERE Durum = 1";
                    SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti);

                    DataTable tbl = new DataTable();
                    baglanti.Open();
                    adapter.Fill(tbl);
                    baglanti.Close();

                    dataGridViewurun.DataSource = tbl;  
                }
                else
                {
                    string sorgu = "SELECT UrunID, UrunAdi, KategoriID, Fiyat FROM URUNLER WHERE Durum = 1 AND UrunAdi LIKE @aramaText";

                    SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti);
                    adapter.SelectCommand.Parameters.AddWithValue("@aramaText", "%" + aramaText + "%");

                    DataTable filteredTable = new DataTable();
                    baglanti.Open();
                    adapter.Fill(filteredTable);
                    baglanti.Close();

                    if (filteredTable.Rows.Count > 0)
                    {
                        dataGridViewurun.DataSource = filteredTable;
                    }
                    else
                    {
                        dataGridViewurun.DataSource = filteredTable;  
                    }
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

        private void textBoxmusteriara_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string MaramaText = textBoxmusteriara.Text.Trim();

                string query = "SELECT MusteriID, M_Ad, M_Soyad FROM MUSTERILER WHERE Durum = 1";

                if (!string.IsNullOrEmpty(MaramaText))
                {
                    query += " AND (M_Ad LIKE @MaramaText OR M_Soyad LIKE @MaramaText)";
                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);

                if (!string.IsNullOrEmpty(MaramaText))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@MaramaText", "%" + MaramaText + "%");
                }

                DataTable tbl = new DataTable();
                baglanti.Open();
                adapter.Fill(tbl);
                baglanti.Close();

                if (tbl.Rows.Count > 0)
                {
                    dataGridViewmusteri.DataSource = tbl;
                }
                else
                {
                    dataGridViewmusteri.DataSource = tbl; 
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
