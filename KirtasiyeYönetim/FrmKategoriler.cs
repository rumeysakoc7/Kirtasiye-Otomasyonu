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
    public partial class FrmKategoriler : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS03;Initial Catalog=KIRTASIYE_YONETIM_DB;Integrated Security=True;TrustServerCertificate=True");
        public FrmKategoriler()
        {
            InitializeComponent();
        }

        private void buttonlistele_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridViewkategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        public void yukle(string filter = "Aktif")
        {
            try
            {
                string query = "SELECT * FROM KATEGORILER";

                
                if (filter == "Aktif")
                {
                    query += " WHERE Durum = 1"; 
                }
                else if (filter == "Pasif")
                {
                    query += " WHERE Durum = 0"; 
                }

                query += " ORDER BY Durum DESC, KategoriAdi ASC";  

                SqlDataAdapter adp = new SqlDataAdapter(query, baglanti);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);

                dataGridViewkategori.DataSource = tbl;
                dataGridViewkategori.Columns[0].Width = 150;  
                dataGridViewkategori.Columns[1].Width = 200;  
                dataGridViewkategori.Columns[2].Width = 650;
                dataGridViewkategori.Columns[3].Width = 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yükleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void FrmKategoriler_Load(object sender, EventArgs e)
        {
            dataGridViewkategori.CellFormatting += dataGridViewkategori_CellFormatting;
            dataGridViewkategori.AllowUserToAddRows = false;
            yukle("Aktif");
            checkBoxaktif.Checked = true;

        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxkategoriadi.Text) || string.IsNullOrEmpty(textBoxkategoriaciklama.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int kaysay;
                baglanti.Open();

                SqlCommand komut = new SqlCommand("INSERT INTO KATEGORILER (KategoriAdi,Aciklama) VALUES (@KategoriAdi,@Aciklama) ", baglanti);
                komut.Parameters.AddWithValue("@KategoriAdi", textBoxkategoriadi.Text);
                komut.Parameters.AddWithValue("@Aciklama", textBoxkategoriaciklama.Text);
                komut.Parameters.AddWithValue("@Durum", 1);
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
        public bool pasifyap(int kategoriid)
        {
            int sonuc = 0;
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE KATEGORILER SET Durum = 0  WHERE  KategoriID=@KategoriID", baglanti);
                komut.Parameters.AddWithValue("@KategoriID", kategoriid);

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

                if (dataGridViewkategori.CurrentRow != null)
                {
                    DataGridViewRow satir = dataGridViewkategori.CurrentRow;

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
            textBoxkategoriarama.Clear();
            textBoxkategoriadi.Clear();
            textBoxkategoriaciklama.Clear();

        }

        private void buttonarama_Click(object sender, EventArgs e)
        {
            try
            {
                string kategoriAdi = textBoxkategoriarama.Text.Trim();


                string query = "SELECT * FROM KATEGORILER WHERE KategoriAdi LIKE @KategoriAdi";

                baglanti.Open();

                SqlDataAdapter adp = new SqlDataAdapter(query, baglanti);
                adp.SelectCommand.Parameters.AddWithValue("@KategoriAdi", "%" + kategoriAdi + "%");

                DataTable tbl = new DataTable();
                adp.Fill(tbl);

                dataGridViewkategori.DataSource = tbl;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void dataGridViewkategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {

                    textBoxkategoriadi.Text = dataGridViewkategori.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? string.Empty;
                    textBoxkategoriaciklama.Text = dataGridViewkategori.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? string.Empty;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori bilgileri alınırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonguncelle_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrEmpty(textBoxkategoriadi.Text.Trim()) || string.IsNullOrEmpty(textBoxkategoriaciklama.Text.Trim()))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dataGridViewkategori.CurrentRow != null)
                {
                    int kategoriID = Convert.ToInt16(dataGridViewkategori.CurrentRow.Cells["KategoriID"].Value);


                    string kategoriAdi = textBoxkategoriadi.Text.Trim();
                    string kategoriAciklama = textBoxkategoriaciklama.Text.Trim();

                    int durum = 1;
                    string query = "UPDATE KATEGORILER SET KategoriAdi = @KategoriAdi, Aciklama = @Aciklama,Durum = @Durum WHERE KategoriID = @KategoriID";

                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@KategoriAdi", kategoriAdi);
                    komut.Parameters.AddWithValue("@Aciklama", kategoriAciklama);
                    komut.Parameters.AddWithValue("@KategoriID", kategoriID);
                    komut.Parameters.AddWithValue("@Durum", durum);



                    baglanti.Open();
                    int etkilenenSatirSayisi = komut.ExecuteNonQuery();
                    baglanti.Close();


                    if (etkilenenSatirSayisi > 0)
                    {
                        MessageBox.Show("Kategori başarıyla güncellendi.");
                        yukle();
                    }
                    else
                    {
                        MessageBox.Show("Kategori güncellenemedi.");
                    }
                }
                else
                {
                    MessageBox.Show("Güncellenecek bir kategori seçmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dataGridViewkategori_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dataGridViewkategori.Columns["Durum"] != null && e.ColumnIndex == dataGridViewkategori.Columns["Durum"].Index)
                {

                    int durum = Convert.ToInt32(dataGridViewkategori.Rows[e.RowIndex].Cells["Durum"].Value);

                    if (durum == 0)
                    {
                        dataGridViewkategori.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                        dataGridViewkategori.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGray;
                    }
                    else
                    {
                        dataGridViewkategori.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        dataGridViewkategori.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Renk ayarı sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
