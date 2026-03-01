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
    public partial class FrmTedarikci : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS03;Initial Catalog=KIRTASIYE_YONETIM_DB;Integrated Security=True;TrustServerCertificate=True");
        public FrmTedarikci()
        {
            InitializeComponent();
        }

        private void FrmTedarikci_Load(object sender, EventArgs e)
        {
            
            dataGridViewtedarikciler.CellFormatting += dataGridViewtedarikciler_CellFormatting;
            dataGridViewtedarikciler.AllowUserToAddRows = false;
            yukle("Aktif"); 
            checkBoxaktif.Checked = true;
        }

        private void paneltedarikcibilgi_Paint(object sender, PaintEventArgs e)
        {

        }

        public void yukle(string filter = "Aktif")
        {
            try
            {
                string query = "SELECT * FROM TEDARIKCILER";
                if (filter == "Aktif")
                {
                    query += " WHERE Durum = 1"; 
                }
                else if (filter == "Pasif")
                {
                    query += " WHERE Durum = 0"; 
                }
                query += " ORDER BY Durum DESC, FirmaAdi ASC";

                SqlDataAdapter adp = new SqlDataAdapter(query, baglanti);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);

                dataGridViewtedarikciler.DataSource = tbl;
                dataGridViewtedarikciler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yükleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonlistele_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                yukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri listeleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxadi.Text.Trim()) || string.IsNullOrEmpty(textBoxsoyadi.Text.Trim()) ||
           string.IsNullOrEmpty(textBoxfirmaadi.Text.Trim()) || string.IsNullOrEmpty(maskedTextBoxtelno.Text.Trim()) ||
           string.IsNullOrEmpty(textBoxadresi.Text.Trim()))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int kaysay;
                baglanti.Open();

                SqlCommand komut = new SqlCommand("INSERT INTO TEDARIKCILER (TedarikciAdi,TedarikciSoyadi,FirmaAdi,TelefonNo,Adres) VALUES (@TedarikciAdi,@TedarikciSoyadi,@FirmaAdi,@TelefonNo,@Adres) ", baglanti);
                komut.Parameters.AddWithValue("@TedarikciAdi", textBoxadi.Text);
                komut.Parameters.AddWithValue("@TedarikciSoyadi", textBoxsoyadi.Text);
                komut.Parameters.AddWithValue("@FirmaAdi", textBoxfirmaadi.Text);
                komut.Parameters.AddWithValue("@TelefonNo", maskedTextBoxtelno.Text);
                komut.Parameters.AddWithValue("@Adres", textBoxadresi.Text);
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




        public bool pasifyap(int tedarikciid)
        {
            int sonuc = 0;
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE TEDARIKCILER SET Durum = 0  where TedarikciID=@TedarikciID", baglanti);
                komut.Parameters.AddWithValue("@TedarikciID", tedarikciid);

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

                if (dataGridViewtedarikciler.CurrentRow != null)
                {
                    DataGridViewRow satir = dataGridViewtedarikciler.CurrentRow;

                    int secid = Convert.ToInt16(satir.Cells[0].Value);

                    bool pasifyapildi = pasifyap(secid);

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

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            textBoxadi.Clear();
            textBoxsoyadi.Clear();
            textBoxfirmaadi.Clear();
            textBoxadresi.Clear();
            maskedTextBoxtelno.Clear();
        }

        private void dataGridViewtedarikciler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewtedarikciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {

                    textBoxadi.Text = dataGridViewtedarikciler.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? string.Empty;
                    textBoxsoyadi.Text = dataGridViewtedarikciler.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? string.Empty;
                    textBoxfirmaadi.Text = dataGridViewtedarikciler.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? string.Empty;
                    textBoxadresi.Text = dataGridViewtedarikciler.Rows[e.RowIndex].Cells[5].Value?.ToString() ?? string.Empty;
                    maskedTextBoxtelno.Text = dataGridViewtedarikciler.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? string.Empty;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tedarikçi bilgileri alınırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxadi.Text.Trim()) || string.IsNullOrEmpty(textBoxsoyadi.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxfirmaadi.Text.Trim()) || string.IsNullOrEmpty(maskedTextBoxtelno.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxadresi.Text.Trim()))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
                if (dataGridViewtedarikciler.CurrentRow != null)
                {

                    int tedarikciID = Convert.ToInt16(dataGridViewtedarikciler.CurrentRow.Cells["TedarikciID"].Value);

                    string tedarikciAdi = textBoxadi.Text.Trim();
                    string tedarikciSoyadi = textBoxsoyadi.Text.Trim();
                    string firmaAdi = textBoxfirmaadi.Text.Trim();
                    string telefonNo = maskedTextBoxtelno.Text.Trim();
                    string adres = textBoxadresi.Text.Trim();

                    int durum = 1;
                    string query = "UPDATE TEDARIKCILER SET TedarikciAdi = @TedarikciAdi, TedarikciSoyadi = @TedarikciSoyadi, FirmaAdi = @FirmaAdi, TelefonNo = @TelefonNo, Adres = @Adres, Durum = @Durum WHERE TedarikciID = @TedarikciID";

                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@TedarikciAdi", tedarikciAdi);
                    komut.Parameters.AddWithValue("@TedarikciSoyadi", tedarikciSoyadi);
                    komut.Parameters.AddWithValue("@FirmaAdi", firmaAdi);
                    komut.Parameters.AddWithValue("@TelefonNo", telefonNo);
                    komut.Parameters.AddWithValue("@Adres", adres);
                    komut.Parameters.AddWithValue("@TedarikciID", tedarikciID);
                    komut.Parameters.AddWithValue("@Durum", durum);


                    baglanti.Open();
                    int etkilenenSatirSayisi = komut.ExecuteNonQuery();
                    baglanti.Close();

                    if (etkilenenSatirSayisi > 0)
                    {
                        MessageBox.Show("Tedarikçi başarıyla güncellendi.");
                        yukle();
                    }
                    else
                    {
                        MessageBox.Show("Tedarikçi güncellenemedi.");
                    }
                }
                else
                {
                    MessageBox.Show("Güncellenecek bir tedarikçi seçmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewtedarikciler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dataGridViewtedarikciler.Columns["Durum"] != null && e.ColumnIndex == dataGridViewtedarikciler.Columns["Durum"].Index)
                {

                    int durum = Convert.ToInt32(dataGridViewtedarikciler.Rows[e.RowIndex].Cells["Durum"].Value);

                    if (durum == 0)
                    {
                        dataGridViewtedarikciler.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                        dataGridViewtedarikciler.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGray;
                    }
                    else
                    {
                        dataGridViewtedarikciler.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        dataGridViewtedarikciler.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
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
