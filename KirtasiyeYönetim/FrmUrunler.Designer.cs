namespace KirtasiyeYönetim
{
    partial class FrmUrunler
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
            dataGridViewurunler = new DataGridView();
            panelurungiris = new Panel();
            labelalisfiyat = new Label();
            textBoxalisfiyat = new TextBox();
            labelresimyolu = new Label();
            textBoxrsimyolu = new TextBox();
            labelfiyat = new Label();
            labelstokmiktari = new Label();
            labelfirmaisim = new Label();
            labelkategoriisim = new Label();
            labelurunadi = new Label();
            label1 = new Label();
            comboBoxfirmaisim = new ComboBox();
            comboBoxkategoriim = new ComboBox();
            numericUpDownstokmiktar = new NumericUpDown();
            textBoxfiyat = new TextBox();
            textBoxurunadi = new TextBox();
            textBoxAra = new TextBox();
            buttonguncelle = new Button();
            buttonekle = new Button();
            buttonsil = new Button();
            buttontemizle = new Button();
            pictureBox1 = new PictureBox();
            pictureBoxurunresim = new PictureBox();
            labelsectiginresim = new Label();
            checkBoxaktif = new CheckBox();
            checkBoxpasif = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewurunler).BeginInit();
            panelurungiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownstokmiktar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxurunresim).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewurunler
            // 
            dataGridViewurunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Sitka Text", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.MistyRose;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewurunler.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewurunler.Location = new Point(32, 205);
            dataGridViewurunler.Name = "dataGridViewurunler";
            dataGridViewurunler.RowHeadersWidth = 51;
            dataGridViewurunler.Size = new Size(950, 697);
            dataGridViewurunler.TabIndex = 0;
            dataGridViewurunler.CellClick += dataGridViewurunler_CellClick;
            dataGridViewurunler.CellContentClick += dataGridViewurunler_CellContentClick;
            dataGridViewurunler.CellFormatting += dataGridViewurunler_CellFormatting;
            // 
            // panelurungiris
            // 
            panelurungiris.BackColor = Color.Transparent;
            panelurungiris.BorderStyle = BorderStyle.FixedSingle;
            panelurungiris.Controls.Add(labelalisfiyat);
            panelurungiris.Controls.Add(textBoxalisfiyat);
            panelurungiris.Controls.Add(labelresimyolu);
            panelurungiris.Controls.Add(textBoxrsimyolu);
            panelurungiris.Controls.Add(labelfiyat);
            panelurungiris.Controls.Add(labelstokmiktari);
            panelurungiris.Controls.Add(labelfirmaisim);
            panelurungiris.Controls.Add(labelkategoriisim);
            panelurungiris.Controls.Add(labelurunadi);
            panelurungiris.Controls.Add(label1);
            panelurungiris.Controls.Add(comboBoxfirmaisim);
            panelurungiris.Controls.Add(comboBoxkategoriim);
            panelurungiris.Controls.Add(numericUpDownstokmiktar);
            panelurungiris.Controls.Add(textBoxfiyat);
            panelurungiris.Controls.Add(textBoxurunadi);
            panelurungiris.ForeColor = Color.IndianRed;
            panelurungiris.Location = new Point(1028, 236);
            panelurungiris.Name = "panelurungiris";
            panelurungiris.Size = new Size(387, 480);
            panelurungiris.TabIndex = 1;
            // 
            // labelalisfiyat
            // 
            labelalisfiyat.AutoSize = true;
            labelalisfiyat.ForeColor = Color.IndianRed;
            labelalisfiyat.Location = new Point(32, 382);
            labelalisfiyat.Name = "labelalisfiyat";
            labelalisfiyat.Size = new Size(109, 26);
            labelalisfiyat.TabIndex = 15;
            labelalisfiyat.Text = "Alış Fiyatı:";
            // 
            // textBoxalisfiyat
            // 
            textBoxalisfiyat.BackColor = Color.MistyRose;
            textBoxalisfiyat.BorderStyle = BorderStyle.FixedSingle;
            textBoxalisfiyat.Location = new Point(154, 378);
            textBoxalisfiyat.Name = "textBoxalisfiyat";
            textBoxalisfiyat.Size = new Size(219, 30);
            textBoxalisfiyat.TabIndex = 14;
            // 
            // labelresimyolu
            // 
            labelresimyolu.AutoSize = true;
            labelresimyolu.ForeColor = Color.IndianRed;
            labelresimyolu.Location = new Point(24, 439);
            labelresimyolu.Name = "labelresimyolu";
            labelresimyolu.Size = new Size(115, 26);
            labelresimyolu.TabIndex = 13;
            labelresimyolu.Text = "Resim Yolu:";
            // 
            // textBoxrsimyolu
            // 
            textBoxrsimyolu.BackColor = Color.MistyRose;
            textBoxrsimyolu.BorderStyle = BorderStyle.FixedSingle;
            textBoxrsimyolu.Location = new Point(154, 435);
            textBoxrsimyolu.Name = "textBoxrsimyolu";
            textBoxrsimyolu.Size = new Size(219, 30);
            textBoxrsimyolu.TabIndex = 12;
            // 
            // labelfiyat
            // 
            labelfiyat.AutoSize = true;
            labelfiyat.ForeColor = Color.IndianRed;
            labelfiyat.Location = new Point(24, 327);
            labelfiyat.Name = "labelfiyat";
            labelfiyat.Size = new Size(120, 26);
            labelfiyat.TabIndex = 11;
            labelfiyat.Text = "Satış Fiyatı:";
            // 
            // labelstokmiktari
            // 
            labelstokmiktari.AutoSize = true;
            labelstokmiktari.ForeColor = Color.IndianRed;
            labelstokmiktari.Location = new Point(21, 267);
            labelstokmiktari.Name = "labelstokmiktari";
            labelstokmiktari.Size = new Size(129, 26);
            labelstokmiktari.TabIndex = 10;
            labelstokmiktari.Text = "Stok Miktarı:";
            // 
            // labelfirmaisim
            // 
            labelfirmaisim.AutoSize = true;
            labelfirmaisim.ForeColor = Color.IndianRed;
            labelfirmaisim.Location = new Point(21, 191);
            labelfirmaisim.Name = "labelfirmaisim";
            labelfirmaisim.Size = new Size(114, 26);
            labelfirmaisim.TabIndex = 9;
            labelfirmaisim.Text = "Firma İsmi:";
            // 
            // labelkategoriisim
            // 
            labelkategoriisim.AutoSize = true;
            labelkategoriisim.ForeColor = Color.IndianRed;
            labelkategoriisim.Location = new Point(3, 117);
            labelkategoriisim.Name = "labelkategoriisim";
            labelkategoriisim.Size = new Size(138, 26);
            labelkategoriisim.TabIndex = 8;
            labelkategoriisim.Text = "Kategori İsmi:";
            // 
            // labelurunadi
            // 
            labelurunadi.AutoSize = true;
            labelurunadi.ForeColor = Color.IndianRed;
            labelurunadi.Location = new Point(43, 49);
            labelurunadi.Name = "labelurunadi";
            labelurunadi.Size = new Size(98, 26);
            labelurunadi.TabIndex = 7;
            labelurunadi.Text = "Ürün Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 26);
            label1.TabIndex = 6;
            label1.Text = "Ürün Giriş Bilgileri";
            // 
            // comboBoxfirmaisim
            // 
            comboBoxfirmaisim.BackColor = Color.MistyRose;
            comboBoxfirmaisim.FlatStyle = FlatStyle.Flat;
            comboBoxfirmaisim.FormattingEnabled = true;
            comboBoxfirmaisim.Location = new Point(156, 183);
            comboBoxfirmaisim.Name = "comboBoxfirmaisim";
            comboBoxfirmaisim.Size = new Size(217, 34);
            comboBoxfirmaisim.TabIndex = 5;
            // 
            // comboBoxkategoriim
            // 
            comboBoxkategoriim.BackColor = Color.MistyRose;
            comboBoxkategoriim.FlatStyle = FlatStyle.Flat;
            comboBoxkategoriim.FormattingEnabled = true;
            comboBoxkategoriim.Location = new Point(156, 109);
            comboBoxkategoriim.Name = "comboBoxkategoriim";
            comboBoxkategoriim.Size = new Size(217, 34);
            comboBoxkategoriim.TabIndex = 4;
            // 
            // numericUpDownstokmiktar
            // 
            numericUpDownstokmiktar.BackColor = Color.MistyRose;
            numericUpDownstokmiktar.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownstokmiktar.ForeColor = Color.IndianRed;
            numericUpDownstokmiktar.Location = new Point(156, 263);
            numericUpDownstokmiktar.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownstokmiktar.Name = "numericUpDownstokmiktar";
            numericUpDownstokmiktar.Size = new Size(217, 30);
            numericUpDownstokmiktar.TabIndex = 3;
            // 
            // textBoxfiyat
            // 
            textBoxfiyat.BackColor = Color.MistyRose;
            textBoxfiyat.BorderStyle = BorderStyle.FixedSingle;
            textBoxfiyat.Location = new Point(156, 323);
            textBoxfiyat.Name = "textBoxfiyat";
            textBoxfiyat.Size = new Size(219, 30);
            textBoxfiyat.TabIndex = 2;
            // 
            // textBoxurunadi
            // 
            textBoxurunadi.BackColor = Color.MistyRose;
            textBoxurunadi.BorderStyle = BorderStyle.FixedSingle;
            textBoxurunadi.Location = new Point(156, 45);
            textBoxurunadi.Name = "textBoxurunadi";
            textBoxurunadi.Size = new Size(217, 30);
            textBoxurunadi.TabIndex = 1;
            // 
            // textBoxAra
            // 
            textBoxAra.BackColor = Color.MistyRose;
            textBoxAra.BorderStyle = BorderStyle.FixedSingle;
            textBoxAra.ForeColor = Color.IndianRed;
            textBoxAra.Location = new Point(1028, 169);
            textBoxAra.Name = "textBoxAra";
            textBoxAra.Size = new Size(387, 30);
            textBoxAra.TabIndex = 0;
            textBoxAra.TextChanged += textBoxAra_TextChanged;
            // 
            // buttonguncelle
            // 
            buttonguncelle.BackColor = Color.Transparent;
            buttonguncelle.FlatStyle = FlatStyle.Flat;
            buttonguncelle.ForeColor = Color.IndianRed;
            buttonguncelle.Location = new Point(1027, 738);
            buttonguncelle.Name = "buttonguncelle";
            buttonguncelle.Size = new Size(192, 37);
            buttonguncelle.TabIndex = 3;
            buttonguncelle.Text = "GÜNCELLE";
            buttonguncelle.UseVisualStyleBackColor = false;
            buttonguncelle.Click += buttonguncelle_Click;
            // 
            // buttonekle
            // 
            buttonekle.BackColor = Color.Transparent;
            buttonekle.FlatStyle = FlatStyle.Flat;
            buttonekle.ForeColor = Color.IndianRed;
            buttonekle.Location = new Point(1238, 738);
            buttonekle.Name = "buttonekle";
            buttonekle.Size = new Size(177, 37);
            buttonekle.TabIndex = 4;
            buttonekle.Text = "EKLE";
            buttonekle.UseVisualStyleBackColor = false;
            buttonekle.Click += button3_Click;
            // 
            // buttonsil
            // 
            buttonsil.BackColor = Color.Transparent;
            buttonsil.FlatStyle = FlatStyle.Flat;
            buttonsil.ForeColor = Color.IndianRed;
            buttonsil.Location = new Point(1027, 781);
            buttonsil.Name = "buttonsil";
            buttonsil.Size = new Size(192, 37);
            buttonsil.TabIndex = 5;
            buttonsil.Text = "SİL";
            buttonsil.UseVisualStyleBackColor = false;
            buttonsil.Click += buttonsil_Click;
            // 
            // buttontemizle
            // 
            buttontemizle.BackColor = Color.Transparent;
            buttontemizle.FlatStyle = FlatStyle.Flat;
            buttontemizle.ForeColor = Color.IndianRed;
            buttontemizle.Location = new Point(1238, 781);
            buttontemizle.Name = "buttontemizle";
            buttontemizle.Size = new Size(177, 37);
            buttontemizle.TabIndex = 6;
            buttontemizle.Text = "TEMİZLE";
            buttontemizle.UseVisualStyleBackColor = false;
            buttontemizle.Click += buttontemizle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxurunresim
            // 
            pictureBoxurunresim.BackColor = Color.Transparent;
            pictureBoxurunresim.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxurunresim.Location = new Point(1480, 184);
            pictureBoxurunresim.Name = "pictureBoxurunresim";
            pictureBoxurunresim.Size = new Size(138, 153);
            pictureBoxurunresim.TabIndex = 8;
            pictureBoxurunresim.TabStop = false;
            // 
            // labelsectiginresim
            // 
            labelsectiginresim.AutoSize = true;
            labelsectiginresim.ForeColor = Color.IndianRed;
            labelsectiginresim.Location = new Point(1430, 139);
            labelsectiginresim.Name = "labelsectiginresim";
            labelsectiginresim.Size = new Size(228, 26);
            labelsectiginresim.TabIndex = 9;
            labelsectiginresim.Text = "Seçtiğiniz Ürünün Resmi";
            // 
            // checkBoxaktif
            // 
            checkBoxaktif.AutoSize = true;
            checkBoxaktif.ForeColor = Color.LightCoral;
            checkBoxaktif.Location = new Point(33, 169);
            checkBoxaktif.Name = "checkBoxaktif";
            checkBoxaktif.Size = new Size(77, 30);
            checkBoxaktif.TabIndex = 11;
            checkBoxaktif.Text = "Aktif";
            checkBoxaktif.UseVisualStyleBackColor = true;
            checkBoxaktif.CheckedChanged += checkBoxaktif_CheckedChanged;
            // 
            // checkBoxpasif
            // 
            checkBoxpasif.AutoSize = true;
            checkBoxpasif.BackColor = Color.Transparent;
            checkBoxpasif.ForeColor = Color.LightCoral;
            checkBoxpasif.Location = new Point(129, 169);
            checkBoxpasif.Name = "checkBoxpasif";
            checkBoxpasif.Size = new Size(77, 30);
            checkBoxpasif.TabIndex = 12;
            checkBoxpasif.Text = "Pasif";
            checkBoxpasif.UseVisualStyleBackColor = false;
            checkBoxpasif.CheckedChanged += checkBoxpasif_CheckedChanged;
            // 
            // FrmUrunler
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1678, 848);
            Controls.Add(checkBoxpasif);
            Controls.Add(checkBoxaktif);
            Controls.Add(labelsectiginresim);
            Controls.Add(pictureBoxurunresim);
            Controls.Add(pictureBox1);
            Controls.Add(buttontemizle);
            Controls.Add(buttonsil);
            Controls.Add(buttonekle);
            Controls.Add(buttonguncelle);
            Controls.Add(textBoxAra);
            Controls.Add(panelurungiris);
            Controls.Add(dataGridViewurunler);
            Font = new Font("Sitka Text", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmUrunler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürünler Sayfası";
            Load += FrmUrunler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewurunler).EndInit();
            panelurungiris.ResumeLayout(false);
            panelurungiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownstokmiktar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxurunresim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewurunler;
        private Panel panelurungiris;
        private Label label1;
        private ComboBox comboBoxfirmaisim;
        private ComboBox comboBoxkategoriim;
        private NumericUpDown numericUpDownstokmiktar;
        private TextBox textBoxfiyat;
        private TextBox textBoxurunadi;
        private TextBox textBoxAra;
        private Button buttonguncelle;
        private Button buttonekle;
        private Button buttonsil;
        private Button buttontemizle;
        private Label labelfiyat;
        private Label labelstokmiktari;
        private Label labelfirmaisim;
        private Label labelkategoriisim;
        private Label labelurunadi;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxurunresim;
        private Label labelsectiginresim;
        private Label labelresimyolu;
        private TextBox textBoxrsimyolu;
        private Label labelalisfiyat;
        private TextBox textBoxalisfiyat;
        private CheckBox checkBoxaktif;
        private CheckBox checkBoxpasif;
    }
}