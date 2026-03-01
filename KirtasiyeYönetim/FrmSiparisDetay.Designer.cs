namespace KirtasiyeYönetim
{
    partial class FrmSiparisDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSiparisDetay));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            dataGridViewsiparisdetay = new DataGridView();
            label5 = new Label();
            buttontemizle = new Button();
            label2 = new Label();
            label1 = new Label();
            textBoxurunadiara = new TextBox();
            textBoxmusteriara = new TextBox();
            dateTimePickerTarih = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewsiparisdetay).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewsiparisdetay
            // 
            dataGridViewsiparisdetay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.MistyRose;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewsiparisdetay.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewsiparisdetay.Location = new Point(65, 276);
            dataGridViewsiparisdetay.Name = "dataGridViewsiparisdetay";
            dataGridViewsiparisdetay.RowHeadersWidth = 51;
            dataGridViewsiparisdetay.Size = new Size(1388, 689);
            dataGridViewsiparisdetay.TabIndex = 5;
            dataGridViewsiparisdetay.CellClick += dataGridView1_CellClick;
            dataGridViewsiparisdetay.CellContentClick += dataGridViewsiparisdetay_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 240);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(151, 24);
            label5.TabIndex = 13;
            label5.Text = "Ürün Adı Arama:";
            // 
            // buttontemizle
            // 
            buttontemizle.FlatStyle = FlatStyle.Flat;
            buttontemizle.Location = new Point(1216, 227);
            buttontemizle.Margin = new Padding(4);
            buttontemizle.Name = "buttontemizle";
            buttontemizle.Size = new Size(138, 29);
            buttontemizle.TabIndex = 12;
            buttontemizle.Text = "TEMİZLE";
            buttontemizle.UseVisualStyleBackColor = true;
            buttontemizle.Click += buttontemizle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(486, 232);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 24);
            label2.TabIndex = 5;
            label2.Text = "Müşteri Arama:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(66, 195);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 24);
            label1.TabIndex = 4;
            label1.Text = "Sipariş Detayları";
            // 
            // textBoxurunadiara
            // 
            textBoxurunadiara.BackColor = Color.MistyRose;
            textBoxurunadiara.BorderStyle = BorderStyle.FixedSingle;
            textBoxurunadiara.Location = new Point(230, 235);
            textBoxurunadiara.Margin = new Padding(4);
            textBoxurunadiara.Name = "textBoxurunadiara";
            textBoxurunadiara.Size = new Size(229, 29);
            textBoxurunadiara.TabIndex = 1;
            textBoxurunadiara.TextChanged += textBoxurunadiara_TextChanged;
            // 
            // textBoxmusteriara
            // 
            textBoxmusteriara.BackColor = Color.MistyRose;
            textBoxmusteriara.BorderStyle = BorderStyle.FixedSingle;
            textBoxmusteriara.Location = new Point(631, 230);
            textBoxmusteriara.Margin = new Padding(4);
            textBoxmusteriara.Name = "textBoxmusteriara";
            textBoxmusteriara.Size = new Size(231, 29);
            textBoxmusteriara.TabIndex = 0;
            textBoxmusteriara.TextChanged += textBoxmusteriara_TextChanged;
            // 
            // dateTimePickerTarih
            // 
            dateTimePickerTarih.CalendarForeColor = Color.IndianRed;
            dateTimePickerTarih.CalendarTitleForeColor = Color.IndianRed;
            dateTimePickerTarih.Location = new Point(914, 227);
            dateTimePickerTarih.Name = "dateTimePickerTarih";
            dateTimePickerTarih.Size = new Size(282, 29);
            dateTimePickerTarih.TabIndex = 33;
            dateTimePickerTarih.ValueChanged += dateTimePickerTarih_ValueChanged;
            // 
            // FrmSiparisDetay
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1609, 1055);
            Controls.Add(dateTimePickerTarih);
            Controls.Add(label2);
            Controls.Add(buttontemizle);
            Controls.Add(textBoxmusteriara);
            Controls.Add(dataGridViewsiparisdetay);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(textBoxurunadiara);
            Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            ForeColor = Color.IndianRed;
            Margin = new Padding(4);
            Name = "FrmSiparisDetay";
            Text = "Sipariş Detayları";
            Load += FrmSiparisDetay_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewsiparisdetay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridViewsiparisdetay;
        private Label label5;
        private Button buttontemizle;
        private Label label2;
        private Label label1;
        private TextBox textBoxurunadiara;
        private TextBox textBoxmusteriara;
        private DateTimePicker dateTimePickerTarih;
    }
}