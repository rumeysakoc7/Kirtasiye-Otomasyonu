namespace KirtasiyeYönetim
{
    partial class FrmKategoriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKategoriler));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            dataGridViewkategori = new DataGridView();
            panelkategoribilgi = new Panel();
            buttontemizle = new Button();
            buttonguncelle = new Button();
            buttonsil = new Button();
            buttonekle = new Button();
            buttonarama = new Button();
            labelaciklama = new Label();
            labelkategoriadi = new Label();
            labelkategoriarama = new Label();
            labelkategoribilgi = new Label();
            textBoxkategoriaciklama = new TextBox();
            textBoxkategoriadi = new TextBox();
            textBoxkategoriarama = new TextBox();
            checkBoxaktif = new CheckBox();
            checkBoxpasif = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewkategori).BeginInit();
            panelkategoribilgi.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 16);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewkategori
            // 
            dataGridViewkategori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Sitka Text", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.MistyRose;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewkategori.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewkategori.Location = new Point(13, 228);
            dataGridViewkategori.Margin = new Padding(4);
            dataGridViewkategori.Name = "dataGridViewkategori";
            dataGridViewkategori.RowHeadersWidth = 51;
            dataGridViewkategori.Size = new Size(1198, 666);
            dataGridViewkategori.TabIndex = 1;
            dataGridViewkategori.CellClick += dataGridViewkategori_CellClick;
            dataGridViewkategori.CellContentClick += dataGridViewkategori_CellContentClick;
            dataGridViewkategori.CellFormatting += dataGridViewkategori_CellFormatting;
            // 
            // panelkategoribilgi
            // 
            panelkategoribilgi.BackColor = Color.Transparent;
            panelkategoribilgi.BorderStyle = BorderStyle.FixedSingle;
            panelkategoribilgi.Controls.Add(buttontemizle);
            panelkategoribilgi.Controls.Add(buttonguncelle);
            panelkategoribilgi.Controls.Add(buttonsil);
            panelkategoribilgi.Controls.Add(buttonekle);
            panelkategoribilgi.Controls.Add(buttonarama);
            panelkategoribilgi.Controls.Add(labelaciklama);
            panelkategoribilgi.Controls.Add(labelkategoriadi);
            panelkategoribilgi.Controls.Add(labelkategoriarama);
            panelkategoribilgi.Controls.Add(labelkategoribilgi);
            panelkategoribilgi.Controls.Add(textBoxkategoriaciklama);
            panelkategoribilgi.Controls.Add(textBoxkategoriadi);
            panelkategoribilgi.Controls.Add(textBoxkategoriarama);
            panelkategoribilgi.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            panelkategoribilgi.ForeColor = Color.IndianRed;
            panelkategoribilgi.Location = new Point(1286, 255);
            panelkategoribilgi.Margin = new Padding(4);
            panelkategoribilgi.Name = "panelkategoribilgi";
            panelkategoribilgi.Size = new Size(368, 428);
            panelkategoribilgi.TabIndex = 2;
            // 
            // buttontemizle
            // 
            buttontemizle.FlatStyle = FlatStyle.Flat;
            buttontemizle.Location = new Point(204, 365);
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
            buttonguncelle.Location = new Point(50, 365);
            buttonguncelle.Margin = new Padding(4);
            buttonguncelle.Name = "buttonguncelle";
            buttonguncelle.Size = new Size(149, 39);
            buttonguncelle.TabIndex = 11;
            buttonguncelle.Text = "GÜNCELLE";
            buttonguncelle.UseVisualStyleBackColor = true;
            buttonguncelle.Click += buttonguncelle_Click;
            // 
            // buttonsil
            // 
            buttonsil.FlatStyle = FlatStyle.Flat;
            buttonsil.Location = new Point(204, 322);
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
            buttonekle.Location = new Point(50, 322);
            buttonekle.Margin = new Padding(4);
            buttonekle.Name = "buttonekle";
            buttonekle.Size = new Size(149, 35);
            buttonekle.TabIndex = 9;
            buttonekle.Text = "EKLE";
            buttonekle.UseVisualStyleBackColor = true;
            buttonekle.Click += buttonekle_Click;
            // 
            // buttonarama
            // 
            buttonarama.FlatStyle = FlatStyle.Flat;
            buttonarama.Location = new Point(50, 277);
            buttonarama.Margin = new Padding(4);
            buttonarama.Name = "buttonarama";
            buttonarama.Size = new Size(292, 37);
            buttonarama.TabIndex = 8;
            buttonarama.Text = "ARAMA YAP";
            buttonarama.UseVisualStyleBackColor = true;
            buttonarama.Click += buttonarama_Click;
            // 
            // labelaciklama
            // 
            labelaciklama.AutoSize = true;
            labelaciklama.Location = new Point(87, 189);
            labelaciklama.Margin = new Padding(4, 0, 4, 0);
            labelaciklama.Name = "labelaciklama";
            labelaciklama.Size = new Size(93, 24);
            labelaciklama.TabIndex = 7;
            labelaciklama.Text = "Açıklama:";
            // 
            // labelkategoriadi
            // 
            labelkategoriadi.AutoSize = true;
            labelkategoriadi.Location = new Point(60, 128);
            labelkategoriadi.Margin = new Padding(4, 0, 4, 0);
            labelkategoriadi.Name = "labelkategoriadi";
            labelkategoriadi.Size = new Size(120, 24);
            labelkategoriadi.TabIndex = 6;
            labelkategoriadi.Text = "Kategori Adı:";
            // 
            // labelkategoriarama
            // 
            labelkategoriarama.AutoSize = true;
            labelkategoriarama.Location = new Point(32, 64);
            labelkategoriarama.Margin = new Padding(4, 0, 4, 0);
            labelkategoriarama.Name = "labelkategoriarama";
            labelkategoriarama.Size = new Size(148, 24);
            labelkategoriarama.TabIndex = 5;
            labelkategoriarama.Text = "Kategori Arama:";
            // 
            // labelkategoribilgi
            // 
            labelkategoribilgi.AutoSize = true;
            labelkategoribilgi.ForeColor = Color.IndianRed;
            labelkategoribilgi.Location = new Point(5, 3);
            labelkategoribilgi.Margin = new Padding(4, 0, 4, 0);
            labelkategoribilgi.Name = "labelkategoribilgi";
            labelkategoribilgi.Size = new Size(155, 24);
            labelkategoribilgi.TabIndex = 4;
            labelkategoribilgi.Text = "Kategori Bilgileri";
            // 
            // textBoxkategoriaciklama
            // 
            textBoxkategoriaciklama.BackColor = Color.MistyRose;
            textBoxkategoriaciklama.BorderStyle = BorderStyle.FixedSingle;
            textBoxkategoriaciklama.Location = new Point(188, 184);
            textBoxkategoriaciklama.Margin = new Padding(4);
            textBoxkategoriaciklama.Name = "textBoxkategoriaciklama";
            textBoxkategoriaciklama.Size = new Size(144, 29);
            textBoxkategoriaciklama.TabIndex = 2;
            // 
            // textBoxkategoriadi
            // 
            textBoxkategoriadi.BackColor = Color.MistyRose;
            textBoxkategoriadi.BorderStyle = BorderStyle.FixedSingle;
            textBoxkategoriadi.Location = new Point(188, 123);
            textBoxkategoriadi.Margin = new Padding(4);
            textBoxkategoriadi.Name = "textBoxkategoriadi";
            textBoxkategoriadi.Size = new Size(144, 29);
            textBoxkategoriadi.TabIndex = 1;
            // 
            // textBoxkategoriarama
            // 
            textBoxkategoriarama.BackColor = Color.MistyRose;
            textBoxkategoriarama.BorderStyle = BorderStyle.FixedSingle;
            textBoxkategoriarama.Location = new Point(188, 59);
            textBoxkategoriarama.Margin = new Padding(4);
            textBoxkategoriarama.Name = "textBoxkategoriarama";
            textBoxkategoriarama.Size = new Size(144, 29);
            textBoxkategoriarama.TabIndex = 0;
            // 
            // checkBoxaktif
            // 
            checkBoxaktif.AutoSize = true;
            checkBoxaktif.BackColor = Color.Transparent;
            checkBoxaktif.ForeColor = Color.LightCoral;
            checkBoxaktif.Location = new Point(13, 139);
            checkBoxaktif.Name = "checkBoxaktif";
            checkBoxaktif.Size = new Size(89, 30);
            checkBoxaktif.TabIndex = 3;
            checkBoxaktif.Text = "AKTİF";
            checkBoxaktif.UseVisualStyleBackColor = false;
            checkBoxaktif.CheckedChanged += checkBoxaktif_CheckedChanged;
            // 
            // checkBoxpasif
            // 
            checkBoxpasif.AutoSize = true;
            checkBoxpasif.BackColor = Color.Transparent;
            checkBoxpasif.ForeColor = Color.LightCoral;
            checkBoxpasif.Location = new Point(120, 139);
            checkBoxpasif.Name = "checkBoxpasif";
            checkBoxpasif.Size = new Size(86, 30);
            checkBoxpasif.TabIndex = 4;
            checkBoxpasif.Text = "PASİF";
            checkBoxpasif.UseVisualStyleBackColor = false;
            checkBoxpasif.CheckedChanged += checkBoxpasif_CheckedChanged;
            // 
            // FrmKategoriler
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1839, 829);
            Controls.Add(checkBoxpasif);
            Controls.Add(checkBoxaktif);
            Controls.Add(panelkategoribilgi);
            Controls.Add(dataGridViewkategori);
            Controls.Add(pictureBox1);
            Font = new Font("Sitka Text", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmKategoriler";
            Text = "Kategoriler Sayfası";
            Load += FrmKategoriler_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewkategori).EndInit();
            panelkategoribilgi.ResumeLayout(false);
            panelkategoribilgi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridViewkategori;
        private Panel panelkategoribilgi;
        private Button buttontemizle;
        private Button buttonguncelle;
        private Button buttonsil;
        private Button buttonekle;
        private Button buttonarama;
        private Label labelaciklama;
        private Label labelkategoriadi;
        private Label labelkategoriarama;
        private Label labelkategoribilgi;
        private TextBox textBoxkategoriaciklama;
        private TextBox textBoxkategoriadi;
        private TextBox textBoxkategoriarama;
        private CheckBox checkBoxaktif;
        private CheckBox checkBoxpasif;
    }
}