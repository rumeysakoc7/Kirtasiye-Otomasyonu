namespace KirtasiyeYönetim
{
    partial class FrmMüsteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMüsteri));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            panelmusteribilgi = new Panel();
            labelmusteriara = new Label();
            textBoxmusteriara = new TextBox();
            maskedTextBoxtelno = new MaskedTextBox();
            labeltelno = new Label();
            buttontemizle = new Button();
            buttonguncelle = new Button();
            buttonsil = new Button();
            buttonekle = new Button();
            labeladres = new Label();
            labelmusterisoyadi = new Label();
            labelmusteriadi = new Label();
            labelmusteribilgi = new Label();
            textBoxadres = new TextBox();
            textBoxmusterisoyadi = new TextBox();
            textBoxmusteriadi = new TextBox();
            dataGridViewmusteriler = new DataGridView();
            checkBoxaktif = new CheckBox();
            checkBoxpasif = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelmusteribilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewmusteriler).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelmusteribilgi
            // 
            panelmusteribilgi.BackColor = Color.Transparent;
            panelmusteribilgi.BorderStyle = BorderStyle.FixedSingle;
            panelmusteribilgi.Controls.Add(labelmusteriara);
            panelmusteribilgi.Controls.Add(textBoxmusteriara);
            panelmusteribilgi.Controls.Add(maskedTextBoxtelno);
            panelmusteribilgi.Controls.Add(labeltelno);
            panelmusteribilgi.Controls.Add(buttontemizle);
            panelmusteribilgi.Controls.Add(buttonguncelle);
            panelmusteribilgi.Controls.Add(buttonsil);
            panelmusteribilgi.Controls.Add(buttonekle);
            panelmusteribilgi.Controls.Add(labeladres);
            panelmusteribilgi.Controls.Add(labelmusterisoyadi);
            panelmusteribilgi.Controls.Add(labelmusteriadi);
            panelmusteribilgi.Controls.Add(labelmusteribilgi);
            panelmusteribilgi.Controls.Add(textBoxadres);
            panelmusteribilgi.Controls.Add(textBoxmusterisoyadi);
            panelmusteribilgi.Controls.Add(textBoxmusteriadi);
            panelmusteribilgi.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            panelmusteribilgi.ForeColor = Color.IndianRed;
            panelmusteribilgi.Location = new Point(1267, 246);
            panelmusteribilgi.Margin = new Padding(4);
            panelmusteribilgi.Name = "panelmusteribilgi";
            panelmusteribilgi.Size = new Size(368, 551);
            panelmusteribilgi.TabIndex = 3;
            // 
            // labelmusteriara
            // 
            labelmusteriara.AutoSize = true;
            labelmusteriara.Location = new Point(49, 92);
            labelmusteriara.Margin = new Padding(4, 0, 4, 0);
            labelmusteriara.Name = "labelmusteriara";
            labelmusteriara.Size = new Size(115, 24);
            labelmusteriara.TabIndex = 18;
            labelmusteriara.Text = "Müşteri Ara:";
            labelmusteriara.Click += label6_Click;
            // 
            // textBoxmusteriara
            // 
            textBoxmusteriara.BackColor = Color.MistyRose;
            textBoxmusteriara.BorderStyle = BorderStyle.FixedSingle;
            textBoxmusteriara.ForeColor = Color.IndianRed;
            textBoxmusteriara.Location = new Point(180, 87);
            textBoxmusteriara.Name = "textBoxmusteriara";
            textBoxmusteriara.Size = new Size(144, 29);
            textBoxmusteriara.TabIndex = 17;
            textBoxmusteriara.TextChanged += textBoxmusteriara_TextChanged;
            // 
            // maskedTextBoxtelno
            // 
            maskedTextBoxtelno.BackColor = Color.MistyRose;
            maskedTextBoxtelno.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxtelno.ForeColor = Color.IndianRed;
            maskedTextBoxtelno.Location = new Point(180, 334);
            maskedTextBoxtelno.Mask = "(999) 000-0000";
            maskedTextBoxtelno.Name = "maskedTextBoxtelno";
            maskedTextBoxtelno.Size = new Size(144, 29);
            maskedTextBoxtelno.TabIndex = 16;
            // 
            // labeltelno
            // 
            labeltelno.AutoSize = true;
            labeltelno.Location = new Point(104, 336);
            labeltelno.Margin = new Padding(4, 0, 4, 0);
            labeltelno.Name = "labeltelno";
            labeltelno.Size = new Size(64, 24);
            labeltelno.TabIndex = 13;
            labeltelno.Text = "TelNo:";
            // 
            // buttontemizle
            // 
            buttontemizle.FlatStyle = FlatStyle.Flat;
            buttontemizle.Location = new Point(200, 470);
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
            buttonguncelle.Location = new Point(49, 470);
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
            buttonsil.Location = new Point(200, 415);
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
            buttonekle.Location = new Point(49, 415);
            buttonekle.Margin = new Padding(4);
            buttonekle.Name = "buttonekle";
            buttonekle.Size = new Size(143, 35);
            buttonekle.TabIndex = 9;
            buttonekle.Text = "EKLE";
            buttonekle.UseVisualStyleBackColor = true;
            buttonekle.Click += buttonekle_Click;
            // 
            // labeladres
            // 
            labeladres.AutoSize = true;
            labeladres.Location = new Point(104, 279);
            labeladres.Margin = new Padding(4, 0, 4, 0);
            labeladres.Name = "labeladres";
            labeladres.Size = new Size(62, 24);
            labeladres.TabIndex = 7;
            labeladres.Text = "Adres:";
            // 
            // labelmusterisoyadi
            // 
            labelmusterisoyadi.AutoSize = true;
            labelmusterisoyadi.Location = new Point(24, 219);
            labelmusterisoyadi.Margin = new Padding(4, 0, 4, 0);
            labelmusterisoyadi.Name = "labelmusterisoyadi";
            labelmusterisoyadi.Size = new Size(142, 24);
            labelmusterisoyadi.TabIndex = 6;
            labelmusterisoyadi.Text = "Müşteri Soyadı:";
            // 
            // labelmusteriadi
            // 
            labelmusteriadi.AutoSize = true;
            labelmusteriadi.Location = new Point(53, 159);
            labelmusteriadi.Margin = new Padding(4, 0, 4, 0);
            labelmusteriadi.Name = "labelmusteriadi";
            labelmusteriadi.Size = new Size(113, 24);
            labelmusteriadi.TabIndex = 5;
            labelmusteriadi.Text = "Müşteri Adı:";
            // 
            // labelmusteribilgi
            // 
            labelmusteribilgi.AutoSize = true;
            labelmusteribilgi.ForeColor = Color.IndianRed;
            labelmusteribilgi.Location = new Point(4, 10);
            labelmusteribilgi.Margin = new Padding(4, 0, 4, 0);
            labelmusteribilgi.Name = "labelmusteribilgi";
            labelmusteribilgi.Size = new Size(148, 24);
            labelmusteribilgi.TabIndex = 4;
            labelmusteribilgi.Text = "Müşteri Bilgileri";
            // 
            // textBoxadres
            // 
            textBoxadres.BackColor = Color.MistyRose;
            textBoxadres.BorderStyle = BorderStyle.FixedSingle;
            textBoxadres.Location = new Point(180, 274);
            textBoxadres.Margin = new Padding(4);
            textBoxadres.Name = "textBoxadres";
            textBoxadres.Size = new Size(144, 29);
            textBoxadres.TabIndex = 2;
            // 
            // textBoxmusterisoyadi
            // 
            textBoxmusterisoyadi.BackColor = Color.MistyRose;
            textBoxmusterisoyadi.BorderStyle = BorderStyle.FixedSingle;
            textBoxmusterisoyadi.Location = new Point(180, 214);
            textBoxmusterisoyadi.Margin = new Padding(4);
            textBoxmusterisoyadi.Name = "textBoxmusterisoyadi";
            textBoxmusterisoyadi.Size = new Size(144, 29);
            textBoxmusterisoyadi.TabIndex = 1;
            // 
            // textBoxmusteriadi
            // 
            textBoxmusteriadi.BackColor = Color.MistyRose;
            textBoxmusteriadi.BorderStyle = BorderStyle.FixedSingle;
            textBoxmusteriadi.Location = new Point(180, 154);
            textBoxmusteriadi.Margin = new Padding(4);
            textBoxmusteriadi.Name = "textBoxmusteriadi";
            textBoxmusteriadi.Size = new Size(144, 29);
            textBoxmusteriadi.TabIndex = 0;
            // 
            // dataGridViewmusteriler
            // 
            dataGridViewmusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.MistyRose;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewmusteriler.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewmusteriler.Location = new Point(12, 202);
            dataGridViewmusteriler.Name = "dataGridViewmusteriler";
            dataGridViewmusteriler.RowHeadersWidth = 51;
            dataGridViewmusteriler.Size = new Size(1126, 668);
            dataGridViewmusteriler.TabIndex = 4;
            dataGridViewmusteriler.CellClick += dataGridViewmusteriler_CellClick;
            dataGridViewmusteriler.CellContentClick += dataGridView1_CellContentClick;
            dataGridViewmusteriler.CellFormatting += dataGridViewmusteriler_CellFormatting;
            // 
            // checkBoxaktif
            // 
            checkBoxaktif.AutoSize = true;
            checkBoxaktif.Location = new Point(19, 168);
            checkBoxaktif.Name = "checkBoxaktif";
            checkBoxaktif.Size = new Size(83, 28);
            checkBoxaktif.TabIndex = 5;
            checkBoxaktif.Text = "AKTİF";
            checkBoxaktif.UseVisualStyleBackColor = true;
            checkBoxaktif.CheckedChanged += checkBoxaktif_CheckedChanged;
            // 
            // checkBoxpasif
            // 
            checkBoxpasif.AutoSize = true;
            checkBoxpasif.Location = new Point(108, 168);
            checkBoxpasif.Name = "checkBoxpasif";
            checkBoxpasif.Size = new Size(81, 28);
            checkBoxpasif.TabIndex = 6;
            checkBoxpasif.Text = "PASİF";
            checkBoxpasif.UseVisualStyleBackColor = true;
            checkBoxpasif.CheckedChanged += checkBoxpasif_CheckedChanged;
            // 
            // FrmMüsteri
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1730, 1055);
            Controls.Add(checkBoxpasif);
            Controls.Add(checkBoxaktif);
            Controls.Add(dataGridViewmusteriler);
            Controls.Add(panelmusteribilgi);
            Controls.Add(pictureBox1);
            Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            ForeColor = Color.IndianRed;
            Margin = new Padding(4);
            Name = "FrmMüsteri";
            Text = "Müşteri Sayfası";
            Load += FrmMüsteri_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelmusteribilgi.ResumeLayout(false);
            panelmusteribilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewmusteriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panelmusteribilgi;
        private Button buttontemizle;
        private Button buttonguncelle;
        private Button buttonsil;
        private Button buttonekle;
        private Label labeladres;
        private Label labelmusterisoyadi;
        private Label labelmusteriadi;
        private Label labelmusteribilgi;
        private TextBox textBoxadres;
        private TextBox textBoxmusterisoyadi;
        private TextBox textBoxmusteriadi;
        private DataGridView dataGridViewmusteriler;
        private Label labeltelno;
        private MaskedTextBox maskedTextBoxtelno;
        private Label labelmusteriara;
        private TextBox textBoxmusteriara;
        private CheckBox checkBoxaktif;
        private CheckBox checkBoxpasif;
    }
}