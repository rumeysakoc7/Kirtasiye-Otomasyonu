namespace KirtasiyeYönetim
{
    partial class FrmSiparisİslem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSiparisİslem));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            panelsiparisislem = new Panel();
            button1 = new Button();
            pictureBoxurunresim = new PictureBox();
            labelurunaded = new Label();
            numericUpDownurunadet = new NumericUpDown();
            textBoxurunfiyat = new TextBox();
            labelurunfiyat = new Label();
            textBoxurunad = new TextBox();
            labelurunad = new Label();
            labelsiparisislemleri = new Label();
            comboBoxodemetur = new ComboBox();
            textBoxmusteribilgi = new TextBox();
            labelmusteribilgi = new Label();
            buttontemizle = new Button();
            labelodemetur = new Label();
            buttonsiparisekle = new Button();
            textBoxtoplamtutar = new TextBox();
            labeltoplamtutar = new Label();
            labelmusteriara = new Label();
            textBoxmusteriara = new TextBox();
            panelsepet = new Panel();
            buttonurunlistboxsil = new Button();
            labelurunsepet = new Label();
            listBoxurunsepet = new ListBox();
            dataGridViewmusteri = new DataGridView();
            dataGridViewurun = new DataGridView();
            textBoxurunara = new TextBox();
            labelurunadara = new Label();
            comboBoxkategorisec = new ComboBox();
            labelkategorisec = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelsiparisislem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxurunresim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownurunadet).BeginInit();
            panelsepet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewmusteri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewurun).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panelsiparisislem
            // 
            panelsiparisislem.BackColor = Color.Transparent;
            panelsiparisislem.BorderStyle = BorderStyle.FixedSingle;
            panelsiparisislem.Controls.Add(button1);
            panelsiparisislem.Controls.Add(pictureBoxurunresim);
            panelsiparisislem.Controls.Add(labelurunaded);
            panelsiparisislem.Controls.Add(numericUpDownurunadet);
            panelsiparisislem.Controls.Add(textBoxurunfiyat);
            panelsiparisislem.Controls.Add(labelurunfiyat);
            panelsiparisislem.Controls.Add(textBoxurunad);
            panelsiparisislem.Controls.Add(labelurunad);
            panelsiparisislem.Controls.Add(labelsiparisislemleri);
            panelsiparisislem.Controls.Add(comboBoxodemetur);
            panelsiparisislem.Controls.Add(textBoxmusteribilgi);
            panelsiparisislem.Controls.Add(labelmusteribilgi);
            panelsiparisislem.Controls.Add(buttontemizle);
            panelsiparisislem.Controls.Add(labelodemetur);
            panelsiparisislem.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            panelsiparisislem.ForeColor = Color.IndianRed;
            panelsiparisislem.Location = new Point(27, 297);
            panelsiparisislem.Margin = new Padding(4);
            panelsiparisislem.Name = "panelsiparisislem";
            panelsiparisislem.Size = new Size(471, 309);
            panelsiparisislem.TabIndex = 6;
            panelsiparisislem.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(328, 247);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(128, 34);
            button1.TabIndex = 31;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBoxurunresim
            // 
            pictureBoxurunresim.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxurunresim.Location = new Point(347, 40);
            pictureBoxurunresim.Name = "pictureBoxurunresim";
            pictureBoxurunresim.Size = new Size(109, 142);
            pictureBoxurunresim.TabIndex = 30;
            pictureBoxurunresim.TabStop = false;
            pictureBoxurunresim.Click += pictureBoxurunresim_Click;
            // 
            // labelurunaded
            // 
            labelurunaded.AutoSize = true;
            labelurunaded.Location = new Point(54, 197);
            labelurunaded.Margin = new Padding(4, 0, 4, 0);
            labelurunaded.Name = "labelurunaded";
            labelurunaded.Size = new Size(110, 24);
            labelurunaded.TabIndex = 29;
            labelurunaded.Text = "Ürün Adedi:";
            // 
            // numericUpDownurunadet
            // 
            numericUpDownurunadet.BackColor = Color.MistyRose;
            numericUpDownurunadet.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownurunadet.ForeColor = Color.IndianRed;
            numericUpDownurunadet.Location = new Point(182, 195);
            numericUpDownurunadet.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownurunadet.Name = "numericUpDownurunadet";
            numericUpDownurunadet.Size = new Size(144, 29);
            numericUpDownurunadet.TabIndex = 28;
            // 
            // textBoxurunfiyat
            // 
            textBoxurunfiyat.BackColor = Color.MistyRose;
            textBoxurunfiyat.BorderStyle = BorderStyle.FixedSingle;
            textBoxurunfiyat.Location = new Point(182, 114);
            textBoxurunfiyat.Margin = new Padding(4);
            textBoxurunfiyat.Name = "textBoxurunfiyat";
            textBoxurunfiyat.Size = new Size(144, 29);
            textBoxurunfiyat.TabIndex = 26;
            // 
            // labelurunfiyat
            // 
            labelurunfiyat.AutoSize = true;
            labelurunfiyat.Location = new Point(60, 116);
            labelurunfiyat.Margin = new Padding(4, 0, 4, 0);
            labelurunfiyat.Name = "labelurunfiyat";
            labelurunfiyat.Size = new Size(113, 24);
            labelurunfiyat.TabIndex = 27;
            labelurunfiyat.Text = "Ürün Fiyatı:\r\n";
            // 
            // textBoxurunad
            // 
            textBoxurunad.BackColor = Color.MistyRose;
            textBoxurunad.BorderStyle = BorderStyle.FixedSingle;
            textBoxurunad.Location = new Point(182, 77);
            textBoxurunad.Margin = new Padding(4);
            textBoxurunad.Name = "textBoxurunad";
            textBoxurunad.Size = new Size(144, 29);
            textBoxurunad.TabIndex = 24;
            // 
            // labelurunad
            // 
            labelurunad.AutoSize = true;
            labelurunad.Location = new Point(73, 79);
            labelurunad.Margin = new Padding(4, 0, 4, 0);
            labelurunad.Name = "labelurunad";
            labelurunad.Size = new Size(91, 24);
            labelurunad.TabIndex = 25;
            labelurunad.Text = "Ürün Adı:\r\n";
            // 
            // labelsiparisislemleri
            // 
            labelsiparisislemleri.AutoSize = true;
            labelsiparisislemleri.ForeColor = Color.IndianRed;
            labelsiparisislemleri.Location = new Point(-1, 0);
            labelsiparisislemleri.Margin = new Padding(4, 0, 4, 0);
            labelsiparisislemleri.Name = "labelsiparisislemleri";
            labelsiparisislemleri.Size = new Size(148, 24);
            labelsiparisislemleri.TabIndex = 4;
            labelsiparisislemleri.Text = "Sipariş İşlemleri";
            // 
            // comboBoxodemetur
            // 
            comboBoxodemetur.BackColor = Color.MistyRose;
            comboBoxodemetur.FlatStyle = FlatStyle.Flat;
            comboBoxodemetur.ForeColor = Color.IndianRed;
            comboBoxodemetur.FormattingEnabled = true;
            comboBoxodemetur.Items.AddRange(new object[] { "Nakit ", "Kredi Kartı" });
            comboBoxodemetur.Location = new Point(183, 149);
            comboBoxodemetur.Name = "comboBoxodemetur";
            comboBoxodemetur.Size = new Size(143, 32);
            comboBoxodemetur.TabIndex = 23;
            // 
            // textBoxmusteribilgi
            // 
            textBoxmusteribilgi.BackColor = Color.MistyRose;
            textBoxmusteribilgi.BorderStyle = BorderStyle.FixedSingle;
            textBoxmusteribilgi.Location = new Point(182, 40);
            textBoxmusteribilgi.Margin = new Padding(4);
            textBoxmusteribilgi.Name = "textBoxmusteribilgi";
            textBoxmusteribilgi.Size = new Size(144, 29);
            textBoxmusteribilgi.TabIndex = 1;
            // 
            // labelmusteribilgi
            // 
            labelmusteribilgi.AutoSize = true;
            labelmusteribilgi.Location = new Point(9, 45);
            labelmusteribilgi.Margin = new Padding(4, 0, 4, 0);
            labelmusteribilgi.Name = "labelmusteribilgi";
            labelmusteribilgi.Size = new Size(168, 24);
            labelmusteribilgi.TabIndex = 6;
            labelmusteribilgi.Text = "Müşteri  Ad-Soyad:";
            // 
            // buttontemizle
            // 
            buttontemizle.FlatStyle = FlatStyle.Flat;
            buttontemizle.Location = new Point(182, 247);
            buttontemizle.Margin = new Padding(4);
            buttontemizle.Name = "buttontemizle";
            buttontemizle.Size = new Size(138, 34);
            buttontemizle.TabIndex = 12;
            buttontemizle.Text = "TEMİZLE";
            buttontemizle.UseVisualStyleBackColor = true;
            buttontemizle.Click += buttontemizle_Click;
            // 
            // labelodemetur
            // 
            labelodemetur.AutoSize = true;
            labelodemetur.Location = new Point(46, 157);
            labelodemetur.Margin = new Padding(4, 0, 4, 0);
            labelodemetur.Name = "labelodemetur";
            labelodemetur.Size = new Size(118, 24);
            labelodemetur.TabIndex = 13;
            labelodemetur.Text = "Ödeme Türü:";
            // 
            // buttonsiparisekle
            // 
            buttonsiparisekle.FlatStyle = FlatStyle.Flat;
            buttonsiparisekle.Location = new Point(310, 241);
            buttonsiparisekle.Margin = new Padding(4);
            buttonsiparisekle.Name = "buttonsiparisekle";
            buttonsiparisekle.Size = new Size(143, 34);
            buttonsiparisekle.TabIndex = 9;
            buttonsiparisekle.Text = "SİPARİŞ EKLE";
            buttonsiparisekle.UseVisualStyleBackColor = true;
            buttonsiparisekle.Click += buttonsiparisekle_Click;
            // 
            // textBoxtoplamtutar
            // 
            textBoxtoplamtutar.BackColor = Color.MistyRose;
            textBoxtoplamtutar.BorderStyle = BorderStyle.FixedSingle;
            textBoxtoplamtutar.Location = new Point(214, 203);
            textBoxtoplamtutar.Margin = new Padding(4);
            textBoxtoplamtutar.Name = "textBoxtoplamtutar";
            textBoxtoplamtutar.Size = new Size(210, 29);
            textBoxtoplamtutar.TabIndex = 18;
            // 
            // labeltoplamtutar
            // 
            labeltoplamtutar.AutoSize = true;
            labeltoplamtutar.Location = new Point(69, 208);
            labeltoplamtutar.Margin = new Padding(4, 0, 4, 0);
            labeltoplamtutar.Name = "labeltoplamtutar";
            labeltoplamtutar.Size = new Size(130, 24);
            labeltoplamtutar.TabIndex = 17;
            labeltoplamtutar.Text = "Toplam Tutar:";
            // 
            // labelmusteriara
            // 
            labelmusteriara.AutoSize = true;
            labelmusteriara.BackColor = Color.Transparent;
            labelmusteriara.Location = new Point(1080, 225);
            labelmusteriara.Margin = new Padding(4, 0, 4, 0);
            labelmusteriara.Name = "labelmusteriara";
            labelmusteriara.Size = new Size(141, 24);
            labelmusteriara.TabIndex = 5;
            labelmusteriara.Text = "Müşteri Arama:";
            // 
            // textBoxmusteriara
            // 
            textBoxmusteriara.BackColor = Color.MistyRose;
            textBoxmusteriara.BorderStyle = BorderStyle.FixedSingle;
            textBoxmusteriara.Location = new Point(1243, 223);
            textBoxmusteriara.Margin = new Padding(4);
            textBoxmusteriara.Name = "textBoxmusteriara";
            textBoxmusteriara.Size = new Size(319, 29);
            textBoxmusteriara.TabIndex = 0;
            textBoxmusteriara.TextChanged += textBoxmusteriara_TextChanged;
            // 
            // panelsepet
            // 
            panelsepet.BackColor = Color.Transparent;
            panelsepet.BorderStyle = BorderStyle.FixedSingle;
            panelsepet.Controls.Add(buttonurunlistboxsil);
            panelsepet.Controls.Add(labelurunsepet);
            panelsepet.Controls.Add(listBoxurunsepet);
            panelsepet.Controls.Add(textBoxtoplamtutar);
            panelsepet.Controls.Add(labeltoplamtutar);
            panelsepet.Controls.Add(buttonsiparisekle);
            panelsepet.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            panelsepet.ForeColor = Color.IndianRed;
            panelsepet.Location = new Point(30, 645);
            panelsepet.Margin = new Padding(4);
            panelsepet.Name = "panelsepet";
            panelsepet.Size = new Size(468, 286);
            panelsepet.TabIndex = 25;
            // 
            // buttonurunlistboxsil
            // 
            buttonurunlistboxsil.FlatStyle = FlatStyle.Flat;
            buttonurunlistboxsil.Font = new Font("Sitka Text", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            buttonurunlistboxsil.Location = new Point(4, 241);
            buttonurunlistboxsil.Margin = new Padding(4);
            buttonurunlistboxsil.Name = "buttonurunlistboxsil";
            buttonurunlistboxsil.Size = new Size(298, 34);
            buttonurunlistboxsil.TabIndex = 35;
            buttonurunlistboxsil.Text = "ÇIKARTMAK İSTEDİĞİN ÜRÜNÜ SİL";
            buttonurunlistboxsil.UseVisualStyleBackColor = true;
            buttonurunlistboxsil.Click += buttonurunlistboxsil_Click;
            // 
            // labelurunsepet
            // 
            labelurunsepet.AutoSize = true;
            labelurunsepet.BackColor = Color.Transparent;
            labelurunsepet.Location = new Point(15, -1);
            labelurunsepet.Margin = new Padding(4, 0, 4, 0);
            labelurunsepet.Name = "labelurunsepet";
            labelurunsepet.Size = new Size(146, 24);
            labelurunsepet.TabIndex = 34;
            labelurunsepet.Text = "Seçilen Ürünler:";
            // 
            // listBoxurunsepet
            // 
            listBoxurunsepet.BackColor = Color.MistyRose;
            listBoxurunsepet.BorderStyle = BorderStyle.FixedSingle;
            listBoxurunsepet.ForeColor = Color.IndianRed;
            listBoxurunsepet.FormattingEnabled = true;
            listBoxurunsepet.ItemHeight = 24;
            listBoxurunsepet.Location = new Point(25, 26);
            listBoxurunsepet.Name = "listBoxurunsepet";
            listBoxurunsepet.Size = new Size(409, 170);
            listBoxurunsepet.TabIndex = 33;
            // 
            // dataGridViewmusteri
            // 
            dataGridViewmusteri.BackgroundColor = Color.MistyRose;
            dataGridViewmusteri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.MistyRose;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewmusteri.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewmusteri.Location = new Point(1078, 259);
            dataGridViewmusteri.Name = "dataGridViewmusteri";
            dataGridViewmusteri.RowHeadersWidth = 51;
            dataGridViewmusteri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewmusteri.Size = new Size(484, 345);
            dataGridViewmusteri.TabIndex = 26;
            dataGridViewmusteri.CellClick += dataGridViewmusteri_CellClick;
            // 
            // dataGridViewurun
            // 
            dataGridViewurun.BackgroundColor = Color.MistyRose;
            dataGridViewurun.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionBackColor = Color.MistyRose;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewurun.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewurun.GridColor = Color.DimGray;
            dataGridViewurun.Location = new Point(551, 297);
            dataGridViewurun.Name = "dataGridViewurun";
            dataGridViewurun.RowHeadersWidth = 51;
            dataGridViewurun.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewurun.Size = new Size(507, 307);
            dataGridViewurun.TabIndex = 27;
            dataGridViewurun.CellClick += dataGridViewurun_CellClick;
            dataGridViewurun.CellContentClick += dataGridViewurun_CellContentClick;
            // 
            // textBoxurunara
            // 
            textBoxurunara.BackColor = Color.MistyRose;
            textBoxurunara.BorderStyle = BorderStyle.FixedSingle;
            textBoxurunara.Location = new Point(735, 223);
            textBoxurunara.Margin = new Padding(4);
            textBoxurunara.Name = "textBoxurunara";
            textBoxurunara.Size = new Size(323, 29);
            textBoxurunara.TabIndex = 28;
            textBoxurunara.TextChanged += textBoxurunara_TextChanged;
            // 
            // labelurunadara
            // 
            labelurunadara.AutoSize = true;
            labelurunadara.BackColor = Color.Transparent;
            labelurunadara.Location = new Point(551, 225);
            labelurunadara.Margin = new Padding(4, 0, 4, 0);
            labelurunadara.Name = "labelurunadara";
            labelurunadara.Size = new Size(151, 24);
            labelurunadara.TabIndex = 29;
            labelurunadara.Text = "Ürün Adı Arama:";
            // 
            // comboBoxkategorisec
            // 
            comboBoxkategorisec.BackColor = Color.MistyRose;
            comboBoxkategorisec.FlatStyle = FlatStyle.Flat;
            comboBoxkategorisec.ForeColor = Color.IndianRed;
            comboBoxkategorisec.FormattingEnabled = true;
            comboBoxkategorisec.Items.AddRange(new object[] { "" });
            comboBoxkategorisec.Location = new Point(684, 259);
            comboBoxkategorisec.Name = "comboBoxkategorisec";
            comboBoxkategorisec.Size = new Size(374, 32);
            comboBoxkategorisec.TabIndex = 32;
            comboBoxkategorisec.SelectedIndexChanged += comboBoxkategorisec_SelectedIndexChanged;
            // 
            // labelkategorisec
            // 
            labelkategorisec.AutoSize = true;
            labelkategorisec.BackColor = Color.Transparent;
            labelkategorisec.Location = new Point(557, 262);
            labelkategorisec.Margin = new Padding(4, 0, 4, 0);
            labelkategorisec.Name = "labelkategorisec";
            labelkategorisec.Size = new Size(120, 24);
            labelkategorisec.TabIndex = 31;
            labelkategorisec.Text = "Kategori Seç:";
            // 
            // FrmSiparisİslem
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1614, 1042);
            Controls.Add(comboBoxkategorisec);
            Controls.Add(labelkategorisec);
            Controls.Add(textBoxurunara);
            Controls.Add(labelurunadara);
            Controls.Add(dataGridViewurun);
            Controls.Add(dataGridViewmusteri);
            Controls.Add(panelsepet);
            Controls.Add(panelsiparisislem);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxmusteriara);
            Controls.Add(labelmusteriara);
            Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            ForeColor = Color.IndianRed;
            Margin = new Padding(4);
            Name = "FrmSiparisİslem";
            Text = "Sipariş İşlemleri";
            Load += FrmSiparisİslem_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelsiparisislem.ResumeLayout(false);
            panelsiparisislem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxurunresim).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownurunadet).EndInit();
            panelsepet.ResumeLayout(false);
            panelsepet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewmusteri).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewurun).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panelsiparisislem;
        private TextBox textBoxtoplamtutar;
        private Label labeltoplamtutar;
        private Label labelodemetur;
        private Button buttontemizle;
        private Button buttonsiparisekle;
        private Label labelmusteribilgi;
        private Label labelmusteriara;
        private Label labelsiparisislemleri;
        private TextBox textBoxmusteribilgi;
        private TextBox textBoxmusteriara;
        private ComboBox comboBoxodemetur;
        private Panel panelsepet;
        private TextBox textBoxurunad;
        private Label labelurunad;
        private DataGridView dataGridViewmusteri;
        private TextBox textBoxurunfiyat;
        private Label labelurunfiyat;
        private Label labelurunaded;
        private NumericUpDown numericUpDownurunadet;
        private PictureBox pictureBoxurunresim;
        private DataGridView dataGridViewurun;
        private TextBox textBoxurunara;
        private Label labelurunadara;
        private ComboBox comboBoxkategorisec;
        private Label labelkategorisec;
        private ListBox listBoxurunsepet;
        private Label labelurunsepet;
        private Button button1;
        private Button buttonurunlistboxsil;
    }
}