
namespace KirtasiyeYönetim
{
    partial class FrmKayitOl
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
            Button buttoniptalet;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKayitOl));
            pictureBox1 = new PictureBox();
            maskedTextBoxtelno = new MaskedTextBox();
            textBoxadi = new TextBox();
            label6 = new Label();
            label5 = new Label();
            buttonkayitol = new Button();
            textBoxsoyadi = new TextBox();
            label1 = new Label();
            textBoxkullaniciadi = new TextBox();
            label2 = new Label();
            textBoxsifre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBoxyetki = new ComboBox();
            buttoniptalet = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttoniptalet
            // 
            buttoniptalet.BackColor = Color.Transparent;
            buttoniptalet.FlatStyle = FlatStyle.Flat;
            buttoniptalet.Location = new Point(256, 474);
            buttoniptalet.Margin = new Padding(4);
            buttoniptalet.Name = "buttoniptalet";
            buttoniptalet.Size = new Size(157, 35);
            buttoniptalet.TabIndex = 44;
            buttoniptalet.Text = "İPTAL ET";
            buttoniptalet.UseVisualStyleBackColor = false;
            buttoniptalet.Click += buttoniptalet_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(183, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // maskedTextBoxtelno
            // 
            maskedTextBoxtelno.BackColor = Color.MistyRose;
            maskedTextBoxtelno.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxtelno.ForeColor = Color.IndianRed;
            maskedTextBoxtelno.Location = new Point(160, 418);
            maskedTextBoxtelno.Mask = "(999) 000-0000";
            maskedTextBoxtelno.Name = "maskedTextBoxtelno";
            maskedTextBoxtelno.Size = new Size(165, 29);
            maskedTextBoxtelno.TabIndex = 27;
            maskedTextBoxtelno.MaskInputRejected += maskedTextBoxtelno_MaskInputRejected;
            // 
            // textBoxadi
            // 
            textBoxadi.BackColor = Color.MistyRose;
            textBoxadi.BorderStyle = BorderStyle.FixedSingle;
            textBoxadi.Location = new Point(161, 175);
            textBoxadi.Margin = new Padding(4);
            textBoxadi.Name = "textBoxadi";
            textBoxadi.Size = new Size(164, 29);
            textBoxadi.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 423);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(66, 24);
            label6.TabIndex = 25;
            label6.Text = "TelNO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(99, 180);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(43, 24);
            label5.TabIndex = 24;
            label5.Text = "Adı:";
            // 
            // buttonkayitol
            // 
            buttonkayitol.BackColor = Color.Transparent;
            buttonkayitol.FlatStyle = FlatStyle.Flat;
            buttonkayitol.Location = new Point(40, 474);
            buttonkayitol.Margin = new Padding(4);
            buttonkayitol.Name = "buttonkayitol";
            buttonkayitol.Size = new Size(208, 35);
            buttonkayitol.TabIndex = 22;
            buttonkayitol.Text = "KAYIT OL";
            buttonkayitol.UseVisualStyleBackColor = false;
            buttonkayitol.Click += button2_Click;
            // 
            // textBoxsoyadi
            // 
            textBoxsoyadi.BackColor = Color.MistyRose;
            textBoxsoyadi.BorderStyle = BorderStyle.FixedSingle;
            textBoxsoyadi.Location = new Point(160, 223);
            textBoxsoyadi.Margin = new Padding(4);
            textBoxsoyadi.Name = "textBoxsoyadi";
            textBoxsoyadi.Size = new Size(165, 29);
            textBoxsoyadi.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(70, 228);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 24);
            label1.TabIndex = 28;
            label1.Text = "Soyadı:";
            // 
            // textBoxkullaniciadi
            // 
            textBoxkullaniciadi.BackColor = Color.MistyRose;
            textBoxkullaniciadi.BorderStyle = BorderStyle.FixedSingle;
            textBoxkullaniciadi.Location = new Point(161, 269);
            textBoxkullaniciadi.Margin = new Padding(4);
            textBoxkullaniciadi.Name = "textBoxkullaniciadi";
            textBoxkullaniciadi.Size = new Size(164, 29);
            textBoxkullaniciadi.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(18, 271);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 24);
            label2.TabIndex = 30;
            label2.Text = "Kullanıcı Adı:";
            // 
            // textBoxsifre
            // 
            textBoxsifre.BackColor = Color.MistyRose;
            textBoxsifre.BorderStyle = BorderStyle.FixedSingle;
            textBoxsifre.Location = new Point(161, 318);
            textBoxsifre.Margin = new Padding(4);
            textBoxsifre.Name = "textBoxsifre";
            textBoxsifre.PasswordChar = '*';
            textBoxsifre.Size = new Size(164, 29);
            textBoxsifre.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(86, 323);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 24);
            label3.TabIndex = 32;
            label3.Text = "Şifre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(84, 373);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 24);
            label4.TabIndex = 34;
            label4.Text = "Yetki:";
            // 
            // comboBoxyetki
            // 
            comboBoxyetki.BackColor = Color.MistyRose;
            comboBoxyetki.FlatStyle = FlatStyle.Flat;
            comboBoxyetki.ForeColor = Color.IndianRed;
            comboBoxyetki.FormattingEnabled = true;
            comboBoxyetki.Items.AddRange(new object[] { "Admin", "Personel" });
            comboBoxyetki.Location = new Point(161, 365);
            comboBoxyetki.Name = "comboBoxyetki";
            comboBoxyetki.Size = new Size(164, 32);
            comboBoxyetki.TabIndex = 35;
            // 
            // FrmKayitOl
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(451, 549);
            Controls.Add(buttoniptalet);
            Controls.Add(comboBoxyetki);
            Controls.Add(label4);
            Controls.Add(textBoxsifre);
            Controls.Add(label3);
            Controls.Add(textBoxkullaniciadi);
            Controls.Add(label2);
            Controls.Add(textBoxsoyadi);
            Controls.Add(label1);
            Controls.Add(maskedTextBoxtelno);
            Controls.Add(textBoxadi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(buttonkayitol);
            Controls.Add(pictureBox1);
            Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            ForeColor = Color.IndianRed;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "FrmKayitOl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıt Ol";
            Load += FrmKayitOl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void maskedTextBoxtelno_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Lütfen sadece rakam giriniz. Telefon numarası formatı: (xxx) xxx-xx-xx", "Geçersiz Karakter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        private PictureBox pictureBox1;
        private MaskedTextBox maskedTextBoxtelno;
        private TextBox textBoxadi;
        private Label label6;
        private Label label5;
        private Button buttonkayitol;
        private TextBox textBoxsoyadi;
        private Label label1;
        private TextBox textBoxkullaniciadi;
        private Label label2;
        private TextBox textBoxsifre;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxyetki;
        private Button buttoniptalet;
    }
}