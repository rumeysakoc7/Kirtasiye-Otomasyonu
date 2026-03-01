namespace KirtasiyeYönetim
{
    partial class FrmTedarikci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTedarikci));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            dataGridViewtedarikciler = new DataGridView();
            paneltedarikcibilgi = new Panel();
            buttonlistele = new Button();
            maskedTextBoxtelno = new MaskedTextBox();
            textBoxfirmaadi = new TextBox();
            textBoxadresi = new TextBox();
            labeltelno = new Label();
            labeladresi = new Label();
            buttontemizle = new Button();
            buttonguncelle = new Button();
            buttonsil = new Button();
            buttonekle = new Button();
            labelfirmaadi = new Label();
            labelsoyadi = new Label();
            labeladi = new Label();
            label1 = new Label();
            textBoxsoyadi = new TextBox();
            textBoxadi = new TextBox();
            checkBoxaktif = new CheckBox();
            checkBoxpasif = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewtedarikciler).BeginInit();
            paneltedarikcibilgi.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewtedarikciler
            // 
            dataGridViewtedarikciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.MistyRose;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewtedarikciler.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewtedarikciler.Location = new Point(12, 203);
            dataGridViewtedarikciler.Name = "dataGridViewtedarikciler";
            dataGridViewtedarikciler.RowHeadersWidth = 51;
            dataGridViewtedarikciler.Size = new Size(1046, 611);
            dataGridViewtedarikciler.TabIndex = 3;
            dataGridViewtedarikciler.CellClick += dataGridViewtedarikciler_CellClick;
            dataGridViewtedarikciler.CellContentClick += dataGridViewtedarikciler_CellContentClick;
            dataGridViewtedarikciler.CellFormatting += dataGridViewtedarikciler_CellFormatting;
            // 
            // paneltedarikcibilgi
            // 
            paneltedarikcibilgi.BackColor = Color.Transparent;
            paneltedarikcibilgi.BorderStyle = BorderStyle.FixedSingle;
            paneltedarikcibilgi.Controls.Add(buttonlistele);
            paneltedarikcibilgi.Controls.Add(maskedTextBoxtelno);
            paneltedarikcibilgi.Controls.Add(textBoxfirmaadi);
            paneltedarikcibilgi.Controls.Add(textBoxadresi);
            paneltedarikcibilgi.Controls.Add(labeltelno);
            paneltedarikcibilgi.Controls.Add(labeladresi);
            paneltedarikcibilgi.Controls.Add(buttontemizle);
            paneltedarikcibilgi.Controls.Add(buttonguncelle);
            paneltedarikcibilgi.Controls.Add(buttonsil);
            paneltedarikcibilgi.Controls.Add(buttonekle);
            paneltedarikcibilgi.Controls.Add(labelfirmaadi);
            paneltedarikcibilgi.Controls.Add(labelsoyadi);
            paneltedarikcibilgi.Controls.Add(labeladi);
            paneltedarikcibilgi.Controls.Add(label1);
            paneltedarikcibilgi.Controls.Add(textBoxsoyadi);
            paneltedarikcibilgi.Controls.Add(textBoxadi);
            paneltedarikcibilgi.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            paneltedarikcibilgi.ForeColor = Color.IndianRed;
            paneltedarikcibilgi.Location = new Point(1162, 203);
            paneltedarikcibilgi.Margin = new Padding(4);
            paneltedarikcibilgi.Name = "paneltedarikcibilgi";
            paneltedarikcibilgi.Size = new Size(368, 554);
            paneltedarikcibilgi.TabIndex = 5;
            paneltedarikcibilgi.Paint += paneltedarikcibilgi_Paint;
            // 
            // buttonlistele
            // 
            buttonlistele.BackColor = Color.Transparent;
            buttonlistele.FlatStyle = FlatStyle.Flat;
            buttonlistele.ForeColor = Color.IndianRed;
            buttonlistele.Location = new Point(30, 487);
            buttonlistele.Name = "buttonlistele";
            buttonlistele.Size = new Size(292, 35);
            buttonlistele.TabIndex = 22;
            buttonlistele.Text = "LİSTELE";
            buttonlistele.UseVisualStyleBackColor = false;
            buttonlistele.Click += buttonlistele_Click;
            // 
            // maskedTextBoxtelno
            // 
            maskedTextBoxtelno.BackColor = Color.MistyRose;
            maskedTextBoxtelno.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxtelno.ForeColor = Color.IndianRed;
            maskedTextBoxtelno.Location = new Point(178, 335);
            maskedTextBoxtelno.Mask = "(999) 000-0000";
            maskedTextBoxtelno.Name = "maskedTextBoxtelno";
            maskedTextBoxtelno.Size = new Size(144, 29);
            maskedTextBoxtelno.TabIndex = 21;
            // 
            // textBoxfirmaadi
            // 
            textBoxfirmaadi.BackColor = Color.MistyRose;
            textBoxfirmaadi.BorderStyle = BorderStyle.FixedSingle;
            textBoxfirmaadi.Location = new Point(178, 220);
            textBoxfirmaadi.Margin = new Padding(4);
            textBoxfirmaadi.Name = "textBoxfirmaadi";
            textBoxfirmaadi.Size = new Size(144, 29);
            textBoxfirmaadi.TabIndex = 20;
            // 
            // textBoxadresi
            // 
            textBoxadresi.BackColor = Color.MistyRose;
            textBoxadresi.BorderStyle = BorderStyle.FixedSingle;
            textBoxadresi.Location = new Point(178, 279);
            textBoxadresi.Margin = new Padding(4);
            textBoxadresi.Name = "textBoxadresi";
            textBoxadresi.Size = new Size(144, 29);
            textBoxadresi.TabIndex = 18;
            // 
            // labeltelno
            // 
            labeltelno.AutoSize = true;
            labeltelno.Location = new Point(104, 340);
            labeltelno.Margin = new Padding(4, 0, 4, 0);
            labeltelno.Name = "labeltelno";
            labeltelno.Size = new Size(66, 24);
            labeltelno.TabIndex = 17;
            labeltelno.Text = "TelNO:";
            // 
            // labeladresi
            // 
            labeladresi.AutoSize = true;
            labeladresi.Location = new Point(101, 284);
            labeladresi.Margin = new Padding(4, 0, 4, 0);
            labeladresi.Name = "labeladresi";
            labeladresi.Size = new Size(68, 24);
            labeladresi.TabIndex = 13;
            labeladresi.Text = "Adresi:";
            // 
            // buttontemizle
            // 
            buttontemizle.FlatStyle = FlatStyle.Flat;
            buttontemizle.Location = new Point(184, 441);
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
            buttonguncelle.Location = new Point(33, 441);
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
            buttonsil.Location = new Point(184, 398);
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
            buttonekle.Location = new Point(33, 398);
            buttonekle.Margin = new Padding(4);
            buttonekle.Name = "buttonekle";
            buttonekle.Size = new Size(143, 35);
            buttonekle.TabIndex = 9;
            buttonekle.Text = "EKLE";
            buttonekle.UseVisualStyleBackColor = true;
            buttonekle.Click += buttonekle_Click;
            // 
            // labelfirmaadi
            // 
            labelfirmaadi.AutoSize = true;
            labelfirmaadi.Location = new Point(78, 225);
            labelfirmaadi.Margin = new Padding(4, 0, 4, 0);
            labelfirmaadi.Name = "labelfirmaadi";
            labelfirmaadi.Size = new Size(98, 24);
            labelfirmaadi.TabIndex = 7;
            labelfirmaadi.Text = "Firma Adı:";
            // 
            // labelsoyadi
            // 
            labelsoyadi.AutoSize = true;
            labelsoyadi.Location = new Point(98, 160);
            labelsoyadi.Margin = new Padding(4, 0, 4, 0);
            labelsoyadi.Name = "labelsoyadi";
            labelsoyadi.Size = new Size(72, 24);
            labelsoyadi.TabIndex = 6;
            labelsoyadi.Text = "Soyadı:";
            // 
            // labeladi
            // 
            labeladi.AutoSize = true;
            labeladi.Location = new Point(122, 97);
            labeladi.Margin = new Padding(4, 0, 4, 0);
            labeladi.Name = "labeladi";
            labeladi.Size = new Size(48, 24);
            labeladi.TabIndex = 5;
            labeladi.Text = " Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(4, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(165, 24);
            label1.TabIndex = 4;
            label1.Text = "Tedarikçi  Bilgileri";
            // 
            // textBoxsoyadi
            // 
            textBoxsoyadi.BackColor = Color.MistyRose;
            textBoxsoyadi.BorderStyle = BorderStyle.FixedSingle;
            textBoxsoyadi.Location = new Point(178, 155);
            textBoxsoyadi.Margin = new Padding(4);
            textBoxsoyadi.Name = "textBoxsoyadi";
            textBoxsoyadi.Size = new Size(144, 29);
            textBoxsoyadi.TabIndex = 1;
            // 
            // textBoxadi
            // 
            textBoxadi.BackColor = Color.MistyRose;
            textBoxadi.BorderStyle = BorderStyle.FixedSingle;
            textBoxadi.Location = new Point(178, 92);
            textBoxadi.Margin = new Padding(4);
            textBoxadi.Name = "textBoxadi";
            textBoxadi.Size = new Size(144, 29);
            textBoxadi.TabIndex = 0;
            // 
            // checkBoxaktif
            // 
            checkBoxaktif.AutoSize = true;
            checkBoxaktif.Location = new Point(12, 169);
            checkBoxaktif.Name = "checkBoxaktif";
            checkBoxaktif.Size = new Size(83, 28);
            checkBoxaktif.TabIndex = 6;
            checkBoxaktif.Text = "AKTİF";
            checkBoxaktif.UseVisualStyleBackColor = true;
            checkBoxaktif.CheckedChanged += checkBoxaktif_CheckedChanged;
            // 
            // checkBoxpasif
            // 
            checkBoxpasif.AutoSize = true;
            checkBoxpasif.Location = new Point(101, 169);
            checkBoxpasif.Name = "checkBoxpasif";
            checkBoxpasif.Size = new Size(81, 28);
            checkBoxpasif.TabIndex = 7;
            checkBoxpasif.Text = "PASİF";
            checkBoxpasif.UseVisualStyleBackColor = true;
            checkBoxpasif.CheckedChanged += checkBoxpasif_CheckedChanged;
            // 
            // FrmTedarikci
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1637, 943);
            Controls.Add(checkBoxpasif);
            Controls.Add(checkBoxaktif);
            Controls.Add(paneltedarikcibilgi);
            Controls.Add(dataGridViewtedarikciler);
            Controls.Add(pictureBox1);
            Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            ForeColor = Color.IndianRed;
            Margin = new Padding(4);
            Name = "FrmTedarikci";
            Text = "Tedarikçi Bilgileri";
            Load += FrmTedarikci_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewtedarikciler).EndInit();
            paneltedarikcibilgi.ResumeLayout(false);
            paneltedarikcibilgi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridViewtedarikciler;
        private Panel paneltedarikcibilgi;
        private TextBox textBoxfirmaadi;
        private TextBox textBoxadresi;
        private Label labeltelno;
        private Label labeladresi;
        private Button buttontemizle;
        private Button buttonguncelle;
        private Button buttonsil;
        private Button buttonekle;
        private Label labelfirmaadi;
        private Label labelsoyadi;
        private Label labeladi;
        private Label label1;
        private TextBox textBoxsoyadi;
        private TextBox textBoxadi;
        private MaskedTextBox maskedTextBoxtelno;
        private Button buttonlistele;
        private CheckBox checkBoxaktif;
        private CheckBox checkBoxpasif;
    }
}