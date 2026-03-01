namespace KirtasiyeYönetim
{
    partial class FrmCalisan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalisan));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            dataGridViewCalisanlar = new DataGridView();
            panelcalisanbilgi = new Panel();
            labeltelno = new Label();
            comboBoxunvan = new ComboBox();
            maskedTextBoxtelno = new MaskedTextBox();
            buttontemizle = new Button();
            buttonguncelle = new Button();
            buttonsil = new Button();
            buttonekle = new Button();
            labelunvan = new Label();
            labelcalisansoyadi = new Label();
            labelcalisanadi = new Label();
            labelcalisanbilgi = new Label();
            textBoxcalisansoyadi = new TextBox();
            textBoxcalisanadi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalisanlar).BeginInit();
            panelcalisanbilgi.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewCalisanlar
            // 
            dataGridViewCalisanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.MistyRose;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewCalisanlar.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCalisanlar.Location = new Point(12, 155);
            dataGridViewCalisanlar.Name = "dataGridViewCalisanlar";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = Color.LightCoral;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewCalisanlar.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCalisanlar.RowHeadersWidth = 51;
            dataGridViewCalisanlar.Size = new Size(1069, 703);
            dataGridViewCalisanlar.TabIndex = 1;
            dataGridViewCalisanlar.CellClick += dataGridViewCalisanlar_CellClick;
            // 
            // panelcalisanbilgi
            // 
            panelcalisanbilgi.BackColor = Color.Transparent;
            panelcalisanbilgi.BorderStyle = BorderStyle.FixedSingle;
            panelcalisanbilgi.Controls.Add(labeltelno);
            panelcalisanbilgi.Controls.Add(comboBoxunvan);
            panelcalisanbilgi.Controls.Add(maskedTextBoxtelno);
            panelcalisanbilgi.Controls.Add(buttontemizle);
            panelcalisanbilgi.Controls.Add(buttonguncelle);
            panelcalisanbilgi.Controls.Add(buttonsil);
            panelcalisanbilgi.Controls.Add(buttonekle);
            panelcalisanbilgi.Controls.Add(labelunvan);
            panelcalisanbilgi.Controls.Add(labelcalisansoyadi);
            panelcalisanbilgi.Controls.Add(labelcalisanadi);
            panelcalisanbilgi.Controls.Add(labelcalisanbilgi);
            panelcalisanbilgi.Controls.Add(textBoxcalisansoyadi);
            panelcalisanbilgi.Controls.Add(textBoxcalisanadi);
            panelcalisanbilgi.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            panelcalisanbilgi.ForeColor = Color.IndianRed;
            panelcalisanbilgi.Location = new Point(1158, 237);
            panelcalisanbilgi.Margin = new Padding(4);
            panelcalisanbilgi.Name = "panelcalisanbilgi";
            panelcalisanbilgi.Size = new Size(368, 474);
            panelcalisanbilgi.TabIndex = 3;
            // 
            // labeltelno
            // 
            labeltelno.AutoSize = true;
            labeltelno.Location = new Point(101, 271);
            labeltelno.Margin = new Padding(4, 0, 4, 0);
            labeltelno.Name = "labeltelno";
            labeltelno.Size = new Size(66, 24);
            labeltelno.TabIndex = 17;
            labeltelno.Text = "TelNO:";
            // 
            // comboBoxunvan
            // 
            comboBoxunvan.BackColor = Color.MistyRose;
            comboBoxunvan.FlatStyle = FlatStyle.Flat;
            comboBoxunvan.ForeColor = Color.IndianRed;
            comboBoxunvan.FormattingEnabled = true;
            comboBoxunvan.Items.AddRange(new object[] { "Sayım Sorumlusu", "Müdür", "Depo Sorumlusu", "Satış Elemanı", "Kasiyer", "Düzen Görevlisi" });
            comboBoxunvan.Location = new Point(181, 203);
            comboBoxunvan.Name = "comboBoxunvan";
            comboBoxunvan.Size = new Size(143, 32);
            comboBoxunvan.TabIndex = 16;
            comboBoxunvan.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // maskedTextBoxtelno
            // 
            maskedTextBoxtelno.BackColor = Color.MistyRose;
            maskedTextBoxtelno.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxtelno.ForeColor = Color.IndianRed;
            maskedTextBoxtelno.Location = new Point(178, 266);
            maskedTextBoxtelno.Mask = "(999) 000-0000";
            maskedTextBoxtelno.Name = "maskedTextBoxtelno";
            maskedTextBoxtelno.Size = new Size(144, 29);
            maskedTextBoxtelno.TabIndex = 15;
            // 
            // buttontemizle
            // 
            buttontemizle.FlatStyle = FlatStyle.Flat;
            buttontemizle.Location = new Point(183, 395);
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
            buttonguncelle.Location = new Point(30, 395);
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
            buttonsil.Location = new Point(183, 343);
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
            buttonekle.Location = new Point(30, 343);
            buttonekle.Margin = new Padding(4);
            buttonekle.Name = "buttonekle";
            buttonekle.Size = new Size(143, 35);
            buttonekle.TabIndex = 9;
            buttonekle.Text = "EKLE";
            buttonekle.UseVisualStyleBackColor = true;
            buttonekle.Click += buttonekle_Click;
            // 
            // labelunvan
            // 
            labelunvan.AutoSize = true;
            labelunvan.Location = new Point(103, 211);
            labelunvan.Margin = new Padding(4, 0, 4, 0);
            labelunvan.Name = "labelunvan";
            labelunvan.Size = new Size(70, 24);
            labelunvan.TabIndex = 7;
            labelunvan.Text = "Unvan:";
            // 
            // labelcalisansoyadi
            // 
            labelcalisansoyadi.AutoSize = true;
            labelcalisansoyadi.Location = new Point(33, 158);
            labelcalisansoyadi.Margin = new Padding(4, 0, 4, 0);
            labelcalisansoyadi.Name = "labelcalisansoyadi";
            labelcalisansoyadi.Size = new Size(139, 24);
            labelcalisansoyadi.TabIndex = 6;
            labelcalisansoyadi.Text = "Çalışan Soyadı:";
            // 
            // labelcalisanadi
            // 
            labelcalisanadi.AutoSize = true;
            labelcalisanadi.Location = new Point(63, 100);
            labelcalisanadi.Margin = new Padding(4, 0, 4, 0);
            labelcalisanadi.Name = "labelcalisanadi";
            labelcalisanadi.Size = new Size(110, 24);
            labelcalisanadi.TabIndex = 5;
            labelcalisanadi.Text = "Çalışan Adı:";
            // 
            // labelcalisanbilgi
            // 
            labelcalisanbilgi.AutoSize = true;
            labelcalisanbilgi.ForeColor = Color.IndianRed;
            labelcalisanbilgi.Location = new Point(4, 14);
            labelcalisanbilgi.Margin = new Padding(4, 0, 4, 0);
            labelcalisanbilgi.Name = "labelcalisanbilgi";
            labelcalisanbilgi.Size = new Size(195, 24);
            labelcalisanbilgi.TabIndex = 4;
            labelcalisanbilgi.Text = "Çalışan Kayıt Bilgileri";
            // 
            // textBoxcalisansoyadi
            // 
            textBoxcalisansoyadi.BackColor = Color.MistyRose;
            textBoxcalisansoyadi.BorderStyle = BorderStyle.FixedSingle;
            textBoxcalisansoyadi.Location = new Point(180, 153);
            textBoxcalisansoyadi.Margin = new Padding(4);
            textBoxcalisansoyadi.Name = "textBoxcalisansoyadi";
            textBoxcalisansoyadi.Size = new Size(144, 29);
            textBoxcalisansoyadi.TabIndex = 1;
            // 
            // textBoxcalisanadi
            // 
            textBoxcalisanadi.BackColor = Color.MistyRose;
            textBoxcalisanadi.BorderStyle = BorderStyle.FixedSingle;
            textBoxcalisanadi.Location = new Point(181, 98);
            textBoxcalisanadi.Margin = new Padding(4);
            textBoxcalisanadi.Name = "textBoxcalisanadi";
            textBoxcalisanadi.Size = new Size(144, 29);
            textBoxcalisanadi.TabIndex = 0;
            // 
            // FrmCalisan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1591, 884);
            Controls.Add(panelcalisanbilgi);
            Controls.Add(dataGridViewCalisanlar);
            Controls.Add(pictureBox1);
            Name = "FrmCalisan";
            Text = "Çalışan Bilgileri";
            Load += FrmCalisan_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalisanlar).EndInit();
            panelcalisanbilgi.ResumeLayout(false);
            panelcalisanbilgi.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridViewCalisanlar;
        private Panel panelcalisanbilgi;
        private Button buttontemizle;
        private Button buttonguncelle;
        private Button buttonsil;
        private Button buttonekle;
        private Label labelunvan;
        private Label labelcalisansoyadi;
        private Label labelcalisanadi;
        private Label labelcalisanbilgi;
        private TextBox textBoxcalisansoyadi;
        private TextBox textBoxcalisanadi;
        private Label labeltelno;
        private ComboBox comboBoxunvan;
        private MaskedTextBox maskedTextBoxtelno;
    }
}