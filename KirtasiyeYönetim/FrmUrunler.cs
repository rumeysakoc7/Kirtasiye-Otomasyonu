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
    public partial class FrmUrunler : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS03;Initial Catalog=KIRTASIYE_YONETIM_DB;Integrated Security=True;TrustServerCertificate=True");
        public FrmUrunler()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxurunadi.Text.Trim()) ||
           comboBoxkategoriim.SelectedIndex == -1 ||
           comboBoxfirmaisim.SelectedIndex == -1 ||
           numericUpDownstokmiktar.Value < 0 ||
           string.IsNullOrEmpty(textBoxfiyat.Text.Trim()) ||
           string.IsNullOrEmpty(textBoxrsimyolu.Text.Trim()) ||
           string.IsNullOrEmpty(textBoxalisfiyat.Text.Trim()))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int kaysay;
                baglanti.Open();
                String query = "INSERT INTO URUNLER (UrunAdi, KategoriID, TedarikciID, StokMiktari, Fiyat, Urun_Resim, Alis_Fiyat) " +
               "VALUES (@UrunAdi, @KategoriID, @TedarikciID, @StokMiktari, @Fiyat, @Urun_Resim, @Alis_Fiyat)";
                SqlCommand komut = new SqlCommand(query, baglanti);


                komut.Parameters.AddWithValue("@UrunAdi", textBoxurunadi.Text);
                komut.Parameters.AddWithValue("@KategoriID", comboBoxkategoriim.SelectedValue);
                komut.Parameters.AddWithValue("@TedarikciID", comboBoxfirmaisim.SelectedValue);
                komut.Parameters.AddWithValue("@StokMiktari", numericUpDownstokmiktar.Value);
                komut.Parameters.AddWithValue("@Fiyat", decimal.Parse(textBoxfiyat.Text));
                komut.Parameters.AddWithValue("@Urun_Resim", textBoxrsimyolu.Text);
                komut.Parameters.AddWithValue("@Alis_Fiyat", decimal.Parse(textBoxalisfiyat.Text));
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

        public void yukle(string filter = "Aktif")
        {
            try
            {
                string query = "SELECT U.UrunID, U.UrunAdi, U.KategoriID, U.TedarikciID, K.KategoriAdi, T.FirmaAdi, U.StokMiktari, U.Fiyat, U.Alis_Fiyat, U.Urun_Resim, U.Durum " +
                               "FROM URUNLER U " +
                               "LEFT JOIN KATEGORILER K ON U.KategoriID = K.KategoriID " +
                               "LEFT JOIN TEDARIKCILER T ON U.TedarikciID = T.TedarikciID";

                if (filter == "Aktif")
                {
                    query += " WHERE U.Durum = 1";
                }
                else if (filter == "Pasif")
                {
                    query += " WHERE U.Durum = 0";
                }

                SqlDataAdapter adp = new SqlDataAdapter(query, baglanti);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);

                dataGridViewurunler.DataSource = tbl;
                dataGridViewurunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yükleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonlistele_Click(object sender, EventArgs e)
        {
        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            textBoxurunadi.Clear();
            comboBoxkategoriim.SelectedIndex = -1;
            comboBoxfirmaisim.SelectedIndex = -1;
            numericUpDownstokmiktar.Value = 0;
            textBoxfiyat.Clear();
            textBoxAra.Clear();
            textBoxrsimyolu.Clear();
            textBoxalisfiyat.Clear();
            textBoxAra.Clear();
        }

        public bool pasifYap(int urunid)
        {
            int sonuc = 0;
            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("UPDATE URUNLER SET Durum = 0, StokMiktari = 0 WHERE UrunID = @UrunID", baglanti);
                komut.Parameters.AddWithValue("@UrunID", urunid);

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
                if (dataGridViewurunler.CurrentRow != null)
                {
                    DataGridViewRow satir = dataGridViewurunler.CurrentRow;
                    int secid = Convert.ToInt16(satir.Cells[0].Value);

                    bool pasifYapildi = pasifYap(secid);

                    if (pasifYapildi)
                    {
                        MessageBox.Show("Ürün kaldırıldı.");
                    }
                    else
                    {
                        MessageBox.Show("Ürün kaldırıldı.");
                    }

                    yukle();
                }
                else
                {
                    MessageBox.Show("Bir satır seçmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxurunadi.Text.Trim()) ||
           comboBoxkategoriim.SelectedIndex == -1 ||
           comboBoxfirmaisim.SelectedIndex == -1 ||
           numericUpDownstokmiktar.Value < 0 ||
           string.IsNullOrEmpty(textBoxfiyat.Text.Trim()) ||
           string.IsNullOrEmpty(textBoxrsimyolu.Text.Trim()) ||
           string.IsNullOrEmpty(textBoxalisfiyat.Text.Trim()))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dataGridViewurunler.CurrentRow != null)
                {

                    int urunID = Convert.ToInt16(dataGridViewurunler.CurrentRow.Cells["UrunID"].Value);

                    string urunAdi = textBoxurunadi.Text;
                    int kategoriID = Convert.ToInt16(comboBoxkategoriim.SelectedValue);
                    int tedarikciID = Convert.ToInt16(comboBoxfirmaisim.SelectedValue);
                    decimal stokMiktari = numericUpDownstokmiktar.Value;
                    decimal fiyat = decimal.Parse(textBoxfiyat.Text);
                    decimal alisfiyat = decimal.Parse(textBoxalisfiyat.Text);
                    string urunResim = textBoxrsimyolu.Text;


                    int durum = 1;

                    string query = "UPDATE URUNLER SET UrunAdi = @UrunAdi, KategoriID = @KategoriID, " +
                       "TedarikciID = @TedarikciID, StokMiktari = @StokMiktari, Fiyat = @Fiyat, " +
                       "Alis_Fiyat = @Alis_Fiyat, Urun_Resim = @UrunResim, Durum = @Durum " +
                       "WHERE UrunID = @UrunID";

                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@UrunAdi", urunAdi);
                    komut.Parameters.AddWithValue("@KategoriID", kategoriID);
                    komut.Parameters.AddWithValue("@TedarikciID", tedarikciID);
                    komut.Parameters.AddWithValue("@StokMiktari", stokMiktari);
                    komut.Parameters.AddWithValue("@Fiyat", fiyat);
                    komut.Parameters.AddWithValue("@UrunResim", urunResim);
                    komut.Parameters.AddWithValue("@UrunID", urunID);
                    komut.Parameters.AddWithValue("@Alis_Fiyat", alisfiyat);
                    komut.Parameters.AddWithValue("@Durum", durum);


                    baglanti.Open();
                    int etkilenenSatirSayisi = komut.ExecuteNonQuery();
                    baglanti.Close();

                    if (etkilenenSatirSayisi > 0)
                    {
                        MessageBox.Show("Ürün kaydı başarıyla güncellendi.");
                        yukle();
                    }
                    else
                    {
                        MessageBox.Show("Ürün kaydı güncellenemedi.");
                    }
                }
                else
                {
                    MessageBox.Show("Güncellenecek bir ürün seçmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void KategorileriYukle()
        {
            try
            {
                string query = "SELECT KategoriID, KategoriAdi FROM KATEGORILER";
                SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboBoxkategoriim.DataSource = dt;
                comboBoxkategoriim.DisplayMember = "KategoriAdi";
                comboBoxkategoriim.ValueMember = "KategoriID";

                comboBoxkategoriim.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategoriler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }
        private void TedarikcileriYukle()
        {
            try
            {
                string query = "SELECT TedarikciID, FirmaAdi FROM TEDARIKCILER";
                SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboBoxfirmaisim.DataSource = dt;
                comboBoxfirmaisim.DisplayMember = "FirmaAdi";
                comboBoxfirmaisim.ValueMember = "TedarikciID";
                comboBoxfirmaisim.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tedarikçiler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            
            comboBoxkategoriim.SelectedIndex = -1;
            comboBoxfirmaisim.SelectedIndex = -1;
            KategorileriYukle();
            TedarikcileriYukle();
            dataGridViewurunler.CellFormatting += dataGridViewurunler_CellFormatting;
            dataGridViewurunler.AllowUserToAddRows = false;
            yukle("Aktif");
            checkBoxaktif.Checked = true;
            DüşükStokKontrolü();

        }

        private void DüşükStokKontrolü()
        {
            try
            {
                bool düşükStokVar = false;

                foreach (DataGridViewRow satır in dataGridViewurunler.Rows)
                {
                    if (satır.Cells["Durum"].Value != null && satır.Cells["StokMiktari"].Value != null)
                    {
                        int durum = Convert.ToInt32(satır.Cells["Durum"].Value);
                        decimal stokMiktari = Convert.ToDecimal(satır.Cells["StokMiktari"].Value);

                        if (durum == 1 && stokMiktari < 30)
                        {
                            düşükStokVar = true;
                            break;
                        }
                    }
                }

                if (düşükStokVar)
                {
                    MessageBox.Show("Tedarik etmeniz gereken ürünler var!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Stok kontrolü sırasında bir hata oluştu: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewurunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    textBoxurunadi.Text = dataGridViewurunler.Rows[e.RowIndex].Cells["UrunAdi"]?.Value?.ToString() ?? string.Empty;

                    numericUpDownstokmiktar.Value = Convert.ToDecimal(dataGridViewurunler.Rows[e.RowIndex].Cells["StokMiktari"]?.Value ?? 0);

                    textBoxfiyat.Text = dataGridViewurunler.Rows[e.RowIndex].Cells["Fiyat"]?.Value?.ToString() ?? string.Empty;

                    textBoxalisfiyat.Text = dataGridViewurunler.Rows[e.RowIndex].Cells["Alis_Fiyat"]?.Value?.ToString() ?? string.Empty;

                    string resimYolu = dataGridViewurunler.Rows[e.RowIndex].Cells["Urun_resim"]?.Value?.ToString()?.Replace("\"", "").Trim() ?? string.Empty;
                    textBoxrsimyolu.Text = resimYolu;

                    comboBoxkategoriim.SelectedValue = dataGridViewurunler.Rows[e.RowIndex].Cells["KategoriID"]?.Value;
                    comboBoxfirmaisim.SelectedValue = dataGridViewurunler.Rows[e.RowIndex].Cells["TedarikciID"]?.Value;

                    if (!string.IsNullOrEmpty(resimYolu) && File.Exists(resimYolu))
                    {
                        pictureBoxurunresim.Image = Image.FromFile(resimYolu);
                        pictureBoxurunresim.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        pictureBoxurunresim.Image = null;
                        MessageBox.Show("Resim dosyası bulunamadı: " + resimYolu,
                                        "Hata",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün bilgileri alınırken bir hata oluştu:\n" + ex.Message,
                                "Hata",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void textBoxAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string kategoriAdi = textBoxAra.Text.Trim();

                string query = "SELECT U.UrunID, U.UrunAdi, U.KategoriID, U.TedarikciID, K.KategoriAdi, T.FirmaAdi, U.StokMiktari, U.Fiyat, U.Alis_Fiyat, U.Urun_Resim, U.Durum " +
                               "FROM URUNLER U " +
                               "LEFT JOIN KATEGORILER K ON U.KategoriID = K.KategoriID " +
                               "LEFT JOIN TEDARIKCILER T ON U.TedarikciID = T.TedarikciID " +
                               "WHERE U.Durum = 1"; 

                if (!string.IsNullOrEmpty(kategoriAdi))
                {
                    query += " AND U.UrunAdi LIKE @UrunAdi";
                }

                baglanti.Open();

                SqlDataAdapter adp = new SqlDataAdapter(query, baglanti);

                if (!string.IsNullOrEmpty(kategoriAdi))
                {
                    adp.SelectCommand.Parameters.AddWithValue("@UrunAdi", "%" + kategoriAdi + "%");
                }

                DataTable tbl = new DataTable();
                adp.Fill(tbl);

                dataGridViewurunler.DataSource = tbl;

                foreach (DataGridViewRow satir in dataGridViewurunler.Rows)
                {
                    if (satir.Cells["Durum"].Value != null && satir.Cells["StokMiktari"].Value != null)
                    {
                        int durum = Convert.ToInt32(satir.Cells["Durum"].Value);
                        decimal stokMiktari = Convert.ToDecimal(satir.Cells["StokMiktari"].Value);

                        if (durum == 1 && stokMiktari < 30)
                        {
                            satir.DefaultCellStyle.BackColor = Color.Red;
                            satir.DefaultCellStyle.ForeColor = Color.White; 
                        }
                        else
                        {
                            satir.DefaultCellStyle.BackColor = dataGridViewurunler.DefaultCellStyle.BackColor;
                            satir.DefaultCellStyle.ForeColor = dataGridViewurunler.DefaultCellStyle.ForeColor;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        
        }
        private void dataGridViewurunler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {

                if (dataGridViewurunler.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                    return;

                if (dataGridViewurunler.Columns["Durum"] != null && e.ColumnIndex == dataGridViewurunler.Columns["Durum"].Index)
                {
                    int durum = Convert.ToInt32(dataGridViewurunler.Rows[e.RowIndex].Cells["Durum"].Value);

                    if (durum == 0)
                    {
                        dataGridViewurunler.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                        dataGridViewurunler.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGray;
                    }
                    else
                    {
                        if (dataGridViewurunler.Columns["StokMiktari"] != null)
                        {
                            decimal stokMiktari = Convert.ToDecimal(dataGridViewurunler.Rows[e.RowIndex].Cells["StokMiktari"].Value);

                            if (stokMiktari < 30)
                            {
                                dataGridViewurunler.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                                dataGridViewurunler.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                            }
                            else
                            {
                                dataGridViewurunler.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                                dataGridViewurunler.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                            }
                        }
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

        private void dataGridViewurunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
