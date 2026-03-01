namespace KirtasiyeYönetim
{
    partial class FrmSifreyiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSifreyiUnuttum));
            pictureBox1 = new PictureBox();
            textBoxsifretekrar = new TextBox();
            labelsifretekrar = new Label();
            textBoxkullaniciad = new TextBox();
            labelkullaniciad = new Label();
            maskedTextBoxtelno = new MaskedTextBox();
            labeltelno = new Label();
            buttonsifreguncelle = new Button();
            textBoxsifre = new TextBox();
            labelsifre = new Label();
            buttoniptalet = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(172, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // textBoxsifretekrar
            // 
            textBoxsifretekrar.BackColor = Color.MistyRose;
            textBoxsifretekrar.BorderStyle = BorderStyle.FixedSingle;
            textBoxsifretekrar.Location = new Point(187, 363);
            textBoxsifretekrar.Margin = new Padding(4);
            textBoxsifretekrar.Name = "textBoxsifretekrar";
            textBoxsifretekrar.PasswordChar = '*';
            textBoxsifretekrar.Size = new Size(164, 29);
            textBoxsifretekrar.TabIndex = 37;
            // 
            // labelsifretekrar
            // 
            labelsifretekrar.AutoSize = true;
            labelsifretekrar.BackColor = Color.Transparent;
            labelsifretekrar.Location = new Point(44, 368);
            labelsifretekrar.Margin = new Padding(4, 0, 4, 0);
            labelsifretekrar.Name = "labelsifretekrar";
            labelsifretekrar.Size = new Size(127, 24);
            labelsifretekrar.TabIndex = 36;
            labelsifretekrar.Text = "Şifre(Tekrar):";
            // 
            // textBoxkullaniciad
            // 
            textBoxkullaniciad.BackColor = Color.MistyRose;
            textBoxkullaniciad.BorderStyle = BorderStyle.FixedSingle;
            textBoxkullaniciad.Location = new Point(187, 201);
            textBoxkullaniciad.Margin = new Padding(4);
            textBoxkullaniciad.Name = "textBoxkullaniciad";
            textBoxkullaniciad.Size = new Size(164, 29);
            textBoxkullaniciad.TabIndex = 35;
            // 
            // labelkullaniciad
            // 
            labelkullaniciad.AutoSize = true;
            labelkullaniciad.BackColor = Color.Transparent;
            labelkullaniciad.Location = new Point(44, 203);
            labelkullaniciad.Margin = new Padding(4, 0, 4, 0);
            labelkullaniciad.Name = "labelkullaniciad";
            labelkullaniciad.Size = new Size(124, 24);
            labelkullaniciad.TabIndex = 34;
            labelkullaniciad.Text = "Kullanıcı Adı:";
            // 
            // maskedTextBoxtelno
            // 
            maskedTextBoxtelno.BackColor = Color.MistyRose;
            maskedTextBoxtelno.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxtelno.ForeColor = Color.IndianRed;
            maskedTextBoxtelno.Location = new Point(187, 249);
            maskedTextBoxtelno.Mask = "(999) 000-0000";
            maskedTextBoxtelno.Name = "maskedTextBoxtelno";
            maskedTextBoxtelno.Size = new Size(165, 29);
            maskedTextBoxtelno.TabIndex = 40;
            // 
            // labeltelno
            // 
            labeltelno.AutoSize = true;
            labeltelno.Location = new Point(106, 254);
            labeltelno.Margin = new Padding(4, 0, 4, 0);
            labeltelno.Name = "labeltelno";
            labeltelno.Size = new Size(66, 24);
            labeltelno.TabIndex = 39;
            labeltelno.Text = "TelNO:";
            // 
            // buttonsifreguncelle
            // 
            buttonsifreguncelle.BackColor = Color.Transparent;
            buttonsifreguncelle.FlatStyle = FlatStyle.Flat;
            buttonsifreguncelle.Location = new Point(53, 427);
            buttonsifreguncelle.Margin = new Padding(4);
            buttonsifreguncelle.Name = "buttonsifreguncelle";
            buttonsifreguncelle.Size = new Size(198, 35);
            buttonsifreguncelle.TabIndex = 38;
            buttonsifreguncelle.Text = "ŞİFREYİ GÜNCELLE";
            buttonsifreguncelle.UseVisualStyleBackColor = false;
            buttonsifreguncelle.Click += button2_Click;
            // 
            // textBoxsifre
            // 
            textBoxsifre.BackColor = Color.MistyRose;
            textBoxsifre.BorderStyle = BorderStyle.FixedSingle;
            textBoxsifre.Location = new Point(187, 304);
            textBoxsifre.Margin = new Padding(4);
            textBoxsifre.Name = "textBoxsifre";
            textBoxsifre.PasswordChar = '*';
            textBoxsifre.Size = new Size(164, 29);
            textBoxsifre.TabIndex = 42;
            // 
            // labelsifre
            // 
            labelsifre.AutoSize = true;
            labelsifre.BackColor = Color.Transparent;
            labelsifre.Location = new Point(112, 309);
            labelsifre.Margin = new Padding(4, 0, 4, 0);
            labelsifre.Name = "labelsifre";
            labelsifre.Size = new Size(56, 24);
            labelsifre.TabIndex = 41;
            labelsifre.Text = "Şifre:";
            // 
            // buttoniptalet
            // 
            buttoniptalet.BackColor = Color.Transparent;
            buttoniptalet.FlatStyle = FlatStyle.Flat;
            buttoniptalet.Location = new Point(271, 427);
            buttoniptalet.Margin = new Padding(4);
            buttoniptalet.Name = "buttoniptalet";
            buttoniptalet.Size = new Size(157, 35);
            buttoniptalet.TabIndex = 43;
            buttoniptalet.Text = "İPTAL ET";
            buttoniptalet.UseVisualStyleBackColor = false;
            buttoniptalet.Click += buttoniptalet_Click;
            // 
            // FrmSifreyiUnuttum
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(479, 517);
            Controls.Add(buttoniptalet);
            Controls.Add(textBoxsifre);
            Controls.Add(labelsifre);
            Controls.Add(maskedTextBoxtelno);
            Controls.Add(labeltelno);
            Controls.Add(buttonsifreguncelle);
            Controls.Add(textBoxsifretekrar);
            Controls.Add(labelsifretekrar);
            Controls.Add(textBoxkullaniciad);
            Controls.Add(labelkullaniciad);
            Controls.Add(pictureBox1);
            Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            ForeColor = Color.IndianRed;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "FrmSifreyiUnuttum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifreyi Unuttum";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBoxsifretekrar;
        private Label labelsifretekrar;
        private TextBox textBoxkullaniciad;
        private Label labelkullaniciad;
        private MaskedTextBox maskedTextBoxtelno;
        private Label labeltelno;
        private Button buttonsifreguncelle;
        private TextBox textBoxsifre;
        private Label labelsifre;
        private Button buttoniptalet;
    }
}