namespace KirtasiyeYönetim
{
    partial class FrmKullaniciGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciGiris));
            pictureBox1 = new PictureBox();
            labelkullaniciad = new Label();
            textBoxkullaniciad = new TextBox();
            buttongiris = new Button();
            linkLabeloturumac = new LinkLabel();
            textBoxsifre = new TextBox();
            labelsifre = new Label();
            linkLabelsifremiunuttum = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(147, 26);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelkullaniciad
            // 
            labelkullaniciad.AutoSize = true;
            labelkullaniciad.ForeColor = Color.IndianRed;
            labelkullaniciad.Location = new Point(10, 242);
            labelkullaniciad.Name = "labelkullaniciad";
            labelkullaniciad.Size = new Size(131, 26);
            labelkullaniciad.TabIndex = 1;
            labelkullaniciad.Text = "Kullanıcı Adı:";
            // 
            // textBoxkullaniciad
            // 
            textBoxkullaniciad.BackColor = Color.MistyRose;
            textBoxkullaniciad.BorderStyle = BorderStyle.FixedSingle;
            textBoxkullaniciad.ForeColor = Color.IndianRed;
            textBoxkullaniciad.Location = new Point(147, 238);
            textBoxkullaniciad.Name = "textBoxkullaniciad";
            textBoxkullaniciad.Size = new Size(174, 30);
            textBoxkullaniciad.TabIndex = 2;
            // 
            // buttongiris
            // 
            buttongiris.BackColor = Color.Transparent;
            buttongiris.FlatStyle = FlatStyle.Flat;
            buttongiris.ForeColor = Color.IndianRed;
            buttongiris.Location = new Point(147, 351);
            buttongiris.Name = "buttongiris";
            buttongiris.Size = new Size(174, 38);
            buttongiris.TabIndex = 3;
            buttongiris.Text = "Giriş Yap";
            buttongiris.UseVisualStyleBackColor = false;
            buttongiris.Click += button1_Click;
            // 
            // linkLabeloturumac
            // 
            linkLabeloturumac.ActiveLinkColor = Color.Salmon;
            linkLabeloturumac.AutoSize = true;
            linkLabeloturumac.LinkColor = Color.IndianRed;
            linkLabeloturumac.Location = new Point(91, 409);
            linkLabeloturumac.Name = "linkLabeloturumac";
            linkLabeloturumac.Size = new Size(106, 26);
            linkLabeloturumac.TabIndex = 4;
            linkLabeloturumac.TabStop = true;
            linkLabeloturumac.Text = "Oturum Aç";
            linkLabeloturumac.LinkClicked += linkLabeloturumac_LinkClicked;
            // 
            // textBoxsifre
            // 
            textBoxsifre.BackColor = Color.MistyRose;
            textBoxsifre.BorderStyle = BorderStyle.FixedSingle;
            textBoxsifre.ForeColor = Color.IndianRed;
            textBoxsifre.Location = new Point(147, 300);
            textBoxsifre.Name = "textBoxsifre";
            textBoxsifre.PasswordChar = '*';
            textBoxsifre.Size = new Size(174, 30);
            textBoxsifre.TabIndex = 6;
            // 
            // labelsifre
            // 
            labelsifre.AutoSize = true;
            labelsifre.ForeColor = Color.IndianRed;
            labelsifre.Location = new Point(80, 304);
            labelsifre.Name = "labelsifre";
            labelsifre.Size = new Size(61, 26);
            labelsifre.TabIndex = 5;
            labelsifre.Text = "Şifre:";
            // 
            // linkLabelsifremiunuttum
            // 
            linkLabelsifremiunuttum.ActiveLinkColor = Color.Salmon;
            linkLabelsifremiunuttum.AutoSize = true;
            linkLabelsifremiunuttum.LinkColor = Color.IndianRed;
            linkLabelsifremiunuttum.Location = new Point(203, 409);
            linkLabelsifremiunuttum.Name = "linkLabelsifremiunuttum";
            linkLabelsifremiunuttum.Size = new Size(160, 26);
            linkLabelsifremiunuttum.TabIndex = 7;
            linkLabelsifremiunuttum.TabStop = true;
            linkLabelsifremiunuttum.Text = "Şifremi Unuttum";
            linkLabelsifremiunuttum.LinkClicked += linkLabelsifremiunuttum_LinkClicked;
            // 
            // FrmKullaniciGiris
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(427, 523);
            Controls.Add(linkLabelsifremiunuttum);
            Controls.Add(textBoxsifre);
            Controls.Add(labelsifre);
            Controls.Add(linkLabeloturumac);
            Controls.Add(buttongiris);
            Controls.Add(textBoxkullaniciad);
            Controls.Add(labelkullaniciad);
            Controls.Add(pictureBox1);
            Font = new Font("Sitka Text", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "FrmKullaniciGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Giriş";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelkullaniciad;
        private TextBox textBoxkullaniciad;
        private Button buttongiris;
        private LinkLabel linkLabeloturumac;
        private TextBox textBoxsifre;
        private Label labelsifre;
        private LinkLabel linkLabelsifremiunuttum;
    }
}
