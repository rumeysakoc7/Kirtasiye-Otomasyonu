namespace KirtasiyeYönetim
{
    public partial class FrmMenu : Form
    {
        private string yetki;
        public FrmMenu(string Kullanici_Yetkisi)
        {
            InitializeComponent();

            yetki = Kullanici_Yetkisi;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            labelkullanicibilgi.Text = $"Oturum: ({Kullanicierisim.KullaniciYetkisi})";
            //Kullanıcı yetkilendirmesi için buton ayarları
            if (yetki == "Admin")
            {
                ürünToolStripMenuItem.Enabled = true;
                kategoriYönetimiToolStripMenuItem.Enabled = true;
                kullanıcıYönetimiToolStripMenuItem.Enabled = true;
                satislarToolStripMenuItem.Enabled = true;
                tedarikçiYönetimiToolStripMenuItem.Enabled = true;
                müşterimiToolStripMenuItem.Enabled = true;
                raporToolStripMenuItem.Enabled = true;
                çalışanlarYönetimiToolStripMenuItem.Enabled = true;
            }
            else if (yetki == "Personel")
            {
                ürünToolStripMenuItem.Enabled = true;
                kategoriYönetimiToolStripMenuItem.Enabled = true;
                kullanıcıYönetimiToolStripMenuItem.Enabled = false;
                satislarToolStripMenuItem.Enabled = true;
                tedarikçiYönetimiToolStripMenuItem.Enabled = false;
                müşterimiToolStripMenuItem.Enabled = true;
                raporToolStripMenuItem.Enabled = false;
                çalışanlarYönetimiToolStripMenuItem.Enabled = false;

            }

        }

        private void CloseAllChildForms()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }


        private void ürünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            FrmUrunler urunlerForm = new FrmUrunler();
            urunlerForm.MdiParent = this;
            urunlerForm.WindowState = FormWindowState.Maximized;
            urunlerForm.Show();

        }

        private void kategoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            FrmKategoriler kategoriForm = new FrmKategoriler();
            kategoriForm.MdiParent = this;
            kategoriForm.WindowState = FormWindowState.Maximized;
            kategoriForm.Show();
        }

        private void kullanıcıYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            FrmKullanicilar kullaniciForm = new FrmKullanicilar();
            kullaniciForm.MdiParent = this;
            kullaniciForm.WindowState = FormWindowState.Maximized;
            kullaniciForm.Show();
        }

        private void siparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void siparişlerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            FrmSiparisİslem siparisForm = new FrmSiparisİslem();
            siparisForm.MdiParent = this;
            siparisForm.WindowState = FormWindowState.Maximized;
            siparisForm.Show();

        }

        private void siparişDetaylarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            FrmSiparisDetay siparisDetayForm = new FrmSiparisDetay();
            siparisDetayForm.MdiParent = this;
            siparisDetayForm.WindowState = FormWindowState.Maximized;
            siparisDetayForm.Show();

        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            FrmRapor raporForm = new FrmRapor();
            raporForm.MdiParent = this;
            raporForm.WindowState = FormWindowState.Maximized;
            raporForm.Show();
        }

        private void müşterimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            FrmMüsteri musteriForm = new FrmMüsteri();
            musteriForm.MdiParent = this;
            musteriForm.WindowState = FormWindowState.Maximized;
            musteriForm.Show();
        }

        private void alışSayfasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            FrmAlisSayfa formalis = new FrmAlisSayfa();
            formalis.MdiParent = this;
            formalis.WindowState = FormWindowState.Maximized;
            formalis.Show();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void çalışanlarYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            FrmCalisan formcalisan = new FrmCalisan();
            formcalisan.MdiParent = this;
            formcalisan.WindowState = FormWindowState.Maximized;
            formcalisan.Show();
        }

        private void tedarikçiYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            FrmTedarikci formTedarikci = new FrmTedarikci();
            formTedarikci.MdiParent = this;
            formTedarikci.WindowState = FormWindowState.Maximized;
            formTedarikci.Show();
        }
    }
}
