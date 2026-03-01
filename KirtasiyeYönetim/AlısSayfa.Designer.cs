namespace KirtasiyeYönetim
{
    partial class FrmAlisSayfa
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlisSayfa));
            dataGridViewalis = new DataGridView();
            pictureBox1 = new PictureBox();
            panelalisbilgi = new Panel();
            textBoxtedarikci = new TextBox();
            numericUpDownmiktar = new NumericUpDown();
            labeltedarikci = new Label();
            labelmiktar = new Label();
            buttontemizle = new Button();
            buttonekle = new Button();
            labelalisfiyat = new Label();
            labelurunadi = new Label();
            label1 = new Label();
            textBoxalisfiyati = new TextBox();
            textBoxurunadi = new TextBox();
            labelurunara = new Label();
            textBoxarama = new TextBox();
            pictureBoxalis = new PictureBox();
            panel2 = new Panel();
            buttonlistboxsil = new Button();
            buttontedarikcidenal = new Button();
            label12 = new Label();
            listBoxalissepet = new ListBox();
            textBoxsepettutarı = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewalis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelalisbilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownmiktar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxalis).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewalis
            // 
            dataGridViewalis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.MistyRose;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewalis.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewalis.Location = new Point(80, 224);
            dataGridViewalis.Name = "dataGridViewalis";
            dataGridViewalis.RowHeadersWidth = 51;
            dataGridViewalis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewalis.Size = new Size(1517, 405);
            dataGridViewalis.TabIndex = 7;
            dataGridViewalis.CellClick += dataGridViewalis_CellClick;
            dataGridViewalis.CellFormatting += dataGridViewalis_CellFormatting;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panelalisbilgi
            // 
            panelalisbilgi.BackColor = Color.Transparent;
            panelalisbilgi.BorderStyle = BorderStyle.FixedSingle;
            panelalisbilgi.Controls.Add(textBoxtedarikci);
            panelalisbilgi.Controls.Add(numericUpDownmiktar);
            panelalisbilgi.Controls.Add(labeltedarikci);
            panelalisbilgi.Controls.Add(labelmiktar);
            panelalisbilgi.Controls.Add(buttontemizle);
            panelalisbilgi.Controls.Add(buttonekle);
            panelalisbilgi.Controls.Add(labelalisfiyat);
            panelalisbilgi.Controls.Add(labelurunadi);
            panelalisbilgi.Controls.Add(label1);
            panelalisbilgi.Controls.Add(textBoxalisfiyati);
            panelalisbilgi.Controls.Add(textBoxurunadi);
            panelalisbilgi.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            panelalisbilgi.ForeColor = Color.IndianRed;
            panelalisbilgi.Location = new Point(176, 651);
            panelalisbilgi.Margin = new Padding(4);
            panelalisbilgi.Name = "panelalisbilgi";
            panelalisbilgi.Size = new Size(376, 324);
            panelalisbilgi.TabIndex = 8;
            // 
            // textBoxtedarikci
            // 
            textBoxtedarikci.BackColor = Color.MistyRose;
            textBoxtedarikci.BorderStyle = BorderStyle.FixedSingle;
            textBoxtedarikci.Location = new Point(180, 181);
            textBoxtedarikci.Margin = new Padding(4);
            textBoxtedarikci.Name = "textBoxtedarikci";
            textBoxtedarikci.Size = new Size(144, 29);
            textBoxtedarikci.TabIndex = 22;
            // 
            // numericUpDownmiktar
            // 
            numericUpDownmiktar.BackColor = Color.MistyRose;
            numericUpDownmiktar.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownmiktar.ForeColor = Color.IndianRed;
            numericUpDownmiktar.Location = new Point(180, 91);
            numericUpDownmiktar.Name = "numericUpDownmiktar";
            numericUpDownmiktar.Size = new Size(144, 29);
            numericUpDownmiktar.TabIndex = 21;
            // 
            // labeltedarikci
            // 
            labeltedarikci.AutoSize = true;
            labeltedarikci.Location = new Point(74, 186);
            labeltedarikci.Margin = new Padding(4, 0, 4, 0);
            labeltedarikci.Name = "labeltedarikci";
            labeltedarikci.Size = new Size(93, 24);
            labeltedarikci.TabIndex = 20;
            labeltedarikci.Text = "Tedarikçi:";
            // 
            // labelmiktar
            // 
            labelmiktar.AutoSize = true;
            labelmiktar.Location = new Point(93, 93);
            labelmiktar.Margin = new Padding(4, 0, 4, 0);
            labelmiktar.Name = "labelmiktar";
            labelmiktar.Size = new Size(73, 24);
            labelmiktar.TabIndex = 19;
            labelmiktar.Text = "Miktar:";
            // 
            // buttontemizle
            // 
            buttontemizle.FlatStyle = FlatStyle.Flat;
            buttontemizle.Location = new Point(123, 266);
            buttontemizle.Margin = new Padding(4);
            buttontemizle.Name = "buttontemizle";
            buttontemizle.Size = new Size(138, 39);
            buttontemizle.TabIndex = 12;
            buttontemizle.Text = "TEMİZLE";
            buttontemizle.UseVisualStyleBackColor = true;
            buttontemizle.Click += buttontemizle_Click;
            // 
            // buttonekle
            // 
            buttonekle.FlatStyle = FlatStyle.Flat;
            buttonekle.Location = new Point(42, 223);
            buttonekle.Margin = new Padding(4);
            buttonekle.Name = "buttonekle";
            buttonekle.Size = new Size(310, 35);
            buttonekle.TabIndex = 9;
            buttonekle.Text = "ALMAK İSTEDİĞİN ÜRÜNÜ EKLE";
            buttonekle.UseVisualStyleBackColor = true;
            buttonekle.Click += buttonekle_Click;
            // 
            // labelalisfiyat
            // 
            labelalisfiyat.AutoSize = true;
            labelalisfiyat.Location = new Point(65, 136);
            labelalisfiyat.Margin = new Padding(4, 0, 4, 0);
            labelalisfiyat.Name = "labelalisfiyat";
            labelalisfiyat.Size = new Size(101, 24);
            labelalisfiyat.TabIndex = 6;
            labelalisfiyat.Text = "Alış Fiyatı:";
            // 
            // labelurunadi
            // 
            labelurunadi.AutoSize = true;
            labelurunadi.Location = new Point(76, 51);
            labelurunadi.Margin = new Padding(4, 0, 4, 0);
            labelurunadi.Name = "labelurunadi";
            labelurunadi.Size = new Size(91, 24);
            labelurunadi.TabIndex = 5;
            labelurunadi.Text = "Ürün Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 24);
            label1.TabIndex = 4;
            label1.Text = "Alış Bilgileri";
            // 
            // textBoxalisfiyati
            // 
            textBoxalisfiyati.BackColor = Color.MistyRose;
            textBoxalisfiyati.BorderStyle = BorderStyle.FixedSingle;
            textBoxalisfiyati.Location = new Point(180, 136);
            textBoxalisfiyati.Margin = new Padding(4);
            textBoxalisfiyati.Name = "textBoxalisfiyati";
            textBoxalisfiyati.Size = new Size(144, 29);
            textBoxalisfiyati.TabIndex = 1;
            // 
            // textBoxurunadi
            // 
            textBoxurunadi.BackColor = Color.MistyRose;
            textBoxurunadi.BorderStyle = BorderStyle.FixedSingle;
            textBoxurunadi.Location = new Point(180, 46);
            textBoxurunadi.Margin = new Padding(4);
            textBoxurunadi.Name = "textBoxurunadi";
            textBoxurunadi.Size = new Size(144, 29);
            textBoxurunadi.TabIndex = 0;
            // 
            // labelurunara
            // 
            labelurunara.AutoSize = true;
            labelurunara.BackColor = Color.Transparent;
            labelurunara.ForeColor = Color.IndianRed;
            labelurunara.Location = new Point(55, 179);
            labelurunara.Margin = new Padding(4, 0, 4, 0);
            labelurunara.Name = "labelurunara";
            labelurunara.Size = new Size(93, 24);
            labelurunara.TabIndex = 18;
            labelurunara.Text = "Ürün Ara:";
            // 
            // textBoxarama
            // 
            textBoxarama.BackColor = Color.MistyRose;
            textBoxarama.BorderStyle = BorderStyle.FixedSingle;
            textBoxarama.ForeColor = Color.IndianRed;
            textBoxarama.Location = new Point(152, 174);
            textBoxarama.Name = "textBoxarama";
            textBoxarama.Size = new Size(468, 29);
            textBoxarama.TabIndex = 17;
            textBoxarama.TextChanged += textBoxarama_TextChanged;
            // 
            // pictureBoxalis
            // 
            pictureBoxalis.BackColor = Color.Transparent;
            pictureBoxalis.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxalis.Location = new Point(706, 660);
            pictureBoxalis.Name = "pictureBoxalis";
            pictureBoxalis.Size = new Size(168, 188);
            pictureBoxalis.TabIndex = 26;
            pictureBoxalis.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(buttonlistboxsil);
            panel2.Controls.Add(buttontedarikcidenal);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(listBoxalissepet);
            panel2.Controls.Add(textBoxsepettutarı);
            panel2.Controls.Add(label6);
            panel2.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            panel2.ForeColor = Color.IndianRed;
            panel2.Location = new Point(1024, 652);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(458, 306);
            panel2.TabIndex = 27;
            // 
            // buttonlistboxsil
            // 
            buttonlistboxsil.FlatStyle = FlatStyle.Flat;
            buttonlistboxsil.Font = new Font("Sitka Text", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            buttonlistboxsil.Location = new Point(15, 256);
            buttonlistboxsil.Margin = new Padding(4);
            buttonlistboxsil.Name = "buttonlistboxsil";
            buttonlistboxsil.Size = new Size(307, 35);
            buttonlistboxsil.TabIndex = 23;
            buttonlistboxsil.Text = "ÇIKARTMAK İSTEDİĞİN ÜRÜNÜ SİL";
            buttonlistboxsil.UseVisualStyleBackColor = true;
            buttonlistboxsil.Click += buttonlistboxsil_Click;
            // 
            // buttontedarikcidenal
            // 
            buttontedarikcidenal.FlatStyle = FlatStyle.Flat;
            buttontedarikcidenal.Font = new Font("Sitka Text", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            buttontedarikcidenal.Location = new Point(330, 256);
            buttontedarikcidenal.Margin = new Padding(4);
            buttontedarikcidenal.Name = "buttontedarikcidenal";
            buttontedarikcidenal.Size = new Size(104, 35);
            buttontedarikcidenal.TabIndex = 35;
            buttontedarikcidenal.Text = "SATIN AL";
            buttontedarikcidenal.UseVisualStyleBackColor = true;
            buttontedarikcidenal.Click += buttontedarikcidenal_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(15, -1);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(146, 24);
            label12.TabIndex = 34;
            label12.Text = "Seçilen Ürünler:";
            // 
            // listBoxalissepet
            // 
            listBoxalissepet.BackColor = Color.MistyRose;
            listBoxalissepet.BorderStyle = BorderStyle.FixedSingle;
            listBoxalissepet.ForeColor = Color.IndianRed;
            listBoxalissepet.FormattingEnabled = true;
            listBoxalissepet.ItemHeight = 24;
            listBoxalissepet.Location = new Point(15, 26);
            listBoxalissepet.Name = "listBoxalissepet";
            listBoxalissepet.Size = new Size(409, 170);
            listBoxalissepet.TabIndex = 33;
            // 
            // textBoxsepettutarı
            // 
            textBoxsepettutarı.BackColor = Color.MistyRose;
            textBoxsepettutarı.BorderStyle = BorderStyle.FixedSingle;
            textBoxsepettutarı.Location = new Point(150, 203);
            textBoxsepettutarı.Margin = new Padding(4);
            textBoxsepettutarı.Name = "textBoxsepettutarı";
            textBoxsepettutarı.Size = new Size(141, 29);
            textBoxsepettutarı.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 208);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 24);
            label6.TabIndex = 17;
            label6.Text = "Sepet Tutarı:";
            // 
            // FrmAlisSayfa
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1816, 1055);
            Controls.Add(panel2);
            Controls.Add(pictureBoxalis);
            Controls.Add(panelalisbilgi);
            Controls.Add(dataGridViewalis);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxarama);
            Controls.Add(labelurunara);
            Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmAlisSayfa";
            Text = "Alış Sayfası";
            Load += FrmAlisSayfa_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewalis).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelalisbilgi.ResumeLayout(false);
            panelalisbilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownmiktar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxalis).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewalis;
        private PictureBox pictureBox1;
        private Panel panelalisbilgi;
        private Label labelurunara;
        private TextBox textBoxarama;
        private Button buttontemizle;
        private Button buttonekle;
        private Label labelalisfiyat;
        private Label labelurunadi;
        private Label label1;
        private TextBox textBoxalisfiyati;
        private TextBox textBoxurunadi;
        private Label labeltedarikci;
        private Label labelmiktar;
        private NumericUpDown numericUpDownmiktar;
        private PictureBox pictureBoxalis;
        private Panel panel2;
        private Label label12;
        private ListBox listBoxalissepet;
        private TextBox textBoxsepettutarı;
        private Label label6;
        private Button buttontedarikcidenal;
        private TextBox textBoxtedarikci;
        private Button buttonlistboxsil;
    }
}