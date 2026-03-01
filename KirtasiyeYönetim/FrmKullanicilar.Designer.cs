namespace KirtasiyeYönetim
{
    partial class FrmKullanicilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullanicilar));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            maskedTextBoxtelno = new MaskedTextBox();
            labeltelno = new Label();
            textBoxsifre = new TextBox();
            textBoxkullaniciadi = new TextBox();
            labelsifre = new Label();
            comboBoxkullaniciyetki = new ComboBox();
            labelkullaniciadi = new Label();
            buttontemizle = new Button();
            buttonguncelle = new Button();
            buttonsil = new Button();
            buttonekle = new Button();
            labelyetki = new Label();
            labelsoyadi = new Label();
            labeladi = new Label();
            labelkullanicikayit = new Label();
            textBoxsoyadi = new TextBox();
            textBoxadi = new TextBox();
            dataGridViewkullanicilar = new DataGridView();
            checkBoxaktif = new CheckBox();
            checkBoxpasif = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewkullanicilar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(maskedTextBoxtelno);
            panel1.Controls.Add(labeltelno);
            panel1.Controls.Add(textBoxsifre);
            panel1.Controls.Add(textBoxkullaniciadi);
            panel1.Controls.Add(labelsifre);
            panel1.Controls.Add(comboBoxkullaniciyetki);
            panel1.Controls.Add(labelkullaniciadi);
            panel1.Controls.Add(buttontemizle);
            panel1.Controls.Add(buttonguncelle);
            panel1.Controls.Add(buttonsil);
            panel1.Controls.Add(buttonekle);
            panel1.Controls.Add(labelyetki);
            panel1.Controls.Add(labelsoyadi);
            panel1.Controls.Add(labeladi);
            panel1.Controls.Add(labelkullanicikayit);
            panel1.Controls.Add(textBoxsoyadi);
            panel1.Controls.Add(textBoxadi);
            panel1.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            panel1.ForeColor = Color.IndianRed;
            panel1.Location = new Point(1145, 244);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 604);
            panel1.TabIndex = 4;
            // 
            // maskedTextBoxtelno
            // 
            maskedTextBoxtelno.BackColor = Color.MistyRose;
            maskedTextBoxtelno.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxtelno.ForeColor = Color.IndianRed;
            maskedTextBoxtelno.Location = new Point(177, 387);
            maskedTextBoxtelno.Mask = "(999) 000-0000";
            maskedTextBoxtelno.Name = "maskedTextBoxtelno";
            maskedTextBoxtelno.Size = new Size(144, 29);
            maskedTextBoxtelno.TabIndex = 22;
            // 
            // labeltelno
            // 
            labeltelno.AutoSize = true;
            labeltelno.Location = new Point(101, 389);
            labeltelno.Margin = new Padding(4, 0, 4, 0);
            labeltelno.Name = "labeltelno";
            labeltelno.Size = new Size(64, 24);
            labeltelno.TabIndex = 21;
            labeltelno.Text = "TelNo:";
            // 
            // textBoxsifre
            // 
            textBoxsifre.BackColor = Color.MistyRose;
            textBoxsifre.BorderStyle = BorderStyle.FixedSingle;
            textBoxsifre.Location = new Point(178, 340);
            textBoxsifre.Margin = new Padding(4);
            textBoxsifre.Name = "textBoxsifre";
            textBoxsifre.PasswordChar = '*';
            textBoxsifre.Size = new Size(144, 29);
            textBoxsifre.TabIndex = 19;
            // 
            // textBoxkullaniciadi
            // 
            textBoxkullaniciadi.BackColor = Color.MistyRose;
            textBoxkullaniciadi.BorderStyle = BorderStyle.FixedSingle;
            textBoxkullaniciadi.Location = new Point(178, 281);
            textBoxkullaniciadi.Margin = new Padding(4);
            textBoxkullaniciadi.Name = "textBoxkullaniciadi";
            textBoxkullaniciadi.Size = new Size(144, 29);
            textBoxkullaniciadi.TabIndex = 18;
            // 
            // labelsifre
            // 
            labelsifre.AutoSize = true;
            labelsifre.Location = new Point(112, 345);
            labelsifre.Margin = new Padding(4, 0, 4, 0);
            labelsifre.Name = "labelsifre";
            labelsifre.Size = new Size(56, 24);
            labelsifre.TabIndex = 17;
            labelsifre.Text = "Şifre:";
            // 
            // comboBoxkullaniciyetki
            // 
            comboBoxkullaniciyetki.BackColor = Color.MistyRose;
            comboBoxkullaniciyetki.FlatStyle = FlatStyle.Flat;
            comboBoxkullaniciyetki.ForeColor = Color.IndianRed;
            comboBoxkullaniciyetki.FormattingEnabled = true;
            comboBoxkullaniciyetki.Items.AddRange(new object[] { "Admin", "Personel" });
            comboBoxkullaniciyetki.Location = new Point(178, 228);
            comboBoxkullaniciyetki.Name = "comboBoxkullaniciyetki";
            comboBoxkullaniciyetki.Size = new Size(143, 32);
            comboBoxkullaniciyetki.TabIndex = 16;
            // 
            // labelkullaniciadi
            // 
            labelkullaniciadi.AutoSize = true;
            labelkullaniciadi.Location = new Point(48, 286);
            labelkullaniciadi.Margin = new Padding(4, 0, 4, 0);
            labelkullaniciadi.Name = "labelkullaniciadi";
            labelkullaniciadi.Size = new Size(122, 24);
            labelkullaniciadi.TabIndex = 13;
            labelkullaniciadi.Text = "KullanıcıADI:";
            // 
            // buttontemizle
            // 
            buttontemizle.FlatStyle = FlatStyle.Flat;
            buttontemizle.Location = new Point(184, 540);
            buttontemizle.Margin = new Padding(4);
            buttontemizle.Name = "buttontemizle";
            buttontemizle.Size = new Size(138, 39);
            buttontemizle.TabIndex = 12;
            buttontemizle.Text = "TEMİZLE";
            buttontemizle.UseVisualStyleBackColor = true;
            buttontemizle.Click += buttontemizle_Click;
            // 
            // buttonguncelle
            // 
            buttonguncelle.FlatStyle = FlatStyle.Flat;
            buttonguncelle.Location = new Point(33, 540);
            buttonguncelle.Margin = new Padding(4);
            buttonguncelle.Name = "buttonguncelle";
            buttonguncelle.Size = new Size(143, 39);
            buttonguncelle.TabIndex = 11;
            buttonguncelle.Text = "GÜNCELLE";
            buttonguncelle.UseVisualStyleBackColor = true;
            buttonguncelle.Click += buttonguncelle_Click;
            // 
            // buttonsil
            // 
            buttonsil.FlatStyle = FlatStyle.Flat;
            buttonsil.Location = new Point(184, 482);
            buttonsil.Margin = new Padding(4);
            buttonsil.Name = "buttonsil";
            buttonsil.Size = new Size(138, 35);
            buttonsil.TabIndex = 10;
            buttonsil.Text = "SİL";
            buttonsil.UseVisualStyleBackColor = true;
            buttonsil.Click += buttonsil_Click;
            // 
            // buttonekle
            // 
            buttonekle.FlatStyle = FlatStyle.Flat;
            buttonekle.Location = new Point(30, 482);
            buttonekle.Margin = new Padding(4);
            buttonekle.Name = "buttonekle";
            buttonekle.Size = new Size(143, 35);
            buttonekle.TabIndex = 9;
            buttonekle.Text = "EKLE";
            buttonekle.UseVisualStyleBackColor = true;
            buttonekle.Click += buttonekle_Click;
            // 
            // labelyetki
            // 
            labelyetki.AutoSize = true;
            labelyetki.Location = new Point(112, 236);
            labelyetki.Margin = new Padding(4, 0, 4, 0);
            labelyetki.Name = "labelyetki";
            labelyetki.Size = new Size(58, 24);
            labelyetki.TabIndex = 7;
            labelyetki.Text = "Yetki:";
            // 
            // labelsoyadi
            // 
            labelsoyadi.AutoSize = true;
            labelsoyadi.Location = new Point(98, 172);
            labelsoyadi.Margin = new Padding(4, 0, 4, 0);
            labelsoyadi.Name = "labelsoyadi";
            labelsoyadi.Size = new Size(72, 24);
            labelsoyadi.TabIndex = 6;
            labelsoyadi.Text = "Soyadı:";
            // 
            // labeladi
            // 
            labeladi.AutoSize = true;
            labeladi.Location = new Point(122, 112);
            labeladi.Margin = new Padding(4, 0, 4, 0);
            labeladi.Name = "labeladi";
            labeladi.Size = new Size(48, 24);
            labeladi.TabIndex = 5;
            labeladi.Text = " Adı:";
            // 
            // labelkullanicikayit
            // 
            labelkullanicikayit.AutoSize = true;
            labelkullanicikayit.ForeColor = Color.IndianRed;
            labelkullanicikayit.Location = new Point(4, 14);
            labelkullanicikayit.Margin = new Padding(4, 0, 4, 0);
            labelkullanicikayit.Name = "labelkullanicikayit";
            labelkullanicikayit.Size = new Size(209, 24);
            labelkullanicikayit.TabIndex = 4;
            labelkullanicikayit.Text = "Kullanıcı Kayıt Bilgileri";
            // 
            // textBoxsoyadi
            // 
            textBoxsoyadi.BackColor = Color.MistyRose;
            textBoxsoyadi.BorderStyle = BorderStyle.FixedSingle;
            textBoxsoyadi.Location = new Point(178, 167);
            textBoxsoyadi.Margin = new Padding(4);
            textBoxsoyadi.Name = "textBoxsoyadi";
            textBoxsoyadi.Size = new Size(144, 29);
            textBoxsoyadi.TabIndex = 1;
            // 
            // textBoxadi
            // 
            textBoxadi.BackColor = Color.MistyRose;
            textBoxadi.BorderStyle = BorderStyle.FixedSingle;
            textBoxadi.Location = new Point(178, 107);
            textBoxadi.Margin = new Padding(4);
            textBoxadi.Name = "textBoxadi";
            textBoxadi.Size = new Size(144, 29);
            textBoxadi.TabIndex = 0;
            // 
            // dataGridViewkullanicilar
            // 
            dataGridViewkullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionBackColor = Color.MistyRose;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewkullanicilar.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewkullanicilar.Location = new Point(34, 222);
            dataGridViewkullanicilar.Name = "dataGridViewkullanicilar";
            dataGridViewkullanicilar.RowHeadersWidth = 51;
            dataGridViewkullanicilar.Size = new Size(1071, 672);
            dataGridViewkullanicilar.TabIndex = 5;
            dataGridViewkullanicilar.CellClick += dataGridViewkullanicilar_CellClick;
            dataGridViewkullanicilar.CellFormatting += dataGridViewkullanicilar_CellFormatting;
            // 
            // checkBoxaktif
            // 
            checkBoxaktif.AutoSize = true;
            checkBoxaktif.Location = new Point(42, 188);
            checkBoxaktif.Name = "checkBoxaktif";
            checkBoxaktif.Size = new Size(88, 28);
            checkBoxaktif.TabIndex = 6;
            checkBoxaktif.Text = "AKTİF ";
            checkBoxaktif.UseVisualStyleBackColor = true;
            checkBoxaktif.CheckedChanged += checkBoxaktif_CheckedChanged;
            // 
            // checkBoxpasif
            // 
            checkBoxpasif.AutoSize = true;
            checkBoxpasif.Location = new Point(125, 188);
            checkBoxpasif.Name = "checkBoxpasif";
            checkBoxpasif.Size = new Size(81, 28);
            checkBoxpasif.TabIndex = 7;
            checkBoxpasif.Text = "PASİF";
            checkBoxpasif.UseVisualStyleBackColor = true;
            checkBoxpasif.CheckedChanged += checkBoxpasif_CheckedChanged;
            // 
            // FrmKullanicilar
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1556, 976);
            Controls.Add(checkBoxpasif);
            Controls.Add(checkBoxaktif);
            Controls.Add(dataGridViewkullanicilar);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            ForeColor = Color.IndianRed;
            Margin = new Padding(4);
            Name = "FrmKullanicilar";
            Text = "Kullanıcılar Sayfası";
            Load += FrmKullanicilar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewkullanicilar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox textBoxsifre;
        private TextBox textBoxkullaniciadi;
        private Label labelsifre;
        private ComboBox comboBoxkullaniciyetki;
        private Label labelkullaniciadi;
        private Button buttontemizle;
        private Button buttonguncelle;
        private Button buttonsil;
        private Button buttonekle;
        private Label labelyetki;
        private Label labelsoyadi;
        private Label labeladi;
        private Label labelkullanicikayit;
        private TextBox textBoxsoyadi;
        private TextBox textBoxadi;
        private DataGridView dataGridViewkullanicilar;
        private MaskedTextBox maskedTextBoxtelno;
        private Label labeltelno;
        private CheckBox checkBoxaktif;
        private CheckBox checkBoxpasif;
    }
}