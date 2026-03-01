namespace KirtasiyeYönetim
{
    partial class FrmRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRapor));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            dataGridViewrapor = new DataGridView();
            dateTimePickerbaslangic = new DateTimePicker();
            dateTimePickerbitis = new DateTimePicker();
            buttonfiltrele = new Button();
            buttonhesapla = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewrapor).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewrapor
            // 
            dataGridViewrapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.MistyRose;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewrapor.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewrapor.Location = new Point(215, 172);
            dataGridViewrapor.Name = "dataGridViewrapor";
            dataGridViewrapor.RowHeadersWidth = 51;
            dataGridViewrapor.Size = new Size(1474, 653);
            dataGridViewrapor.TabIndex = 8;
            // 
            // dateTimePickerbaslangic
            // 
            dateTimePickerbaslangic.CalendarForeColor = Color.IndianRed;
            dateTimePickerbaslangic.CalendarTitleForeColor = Color.IndianRed;
            dateTimePickerbaslangic.Location = new Point(215, 118);
            dateTimePickerbaslangic.Name = "dateTimePickerbaslangic";
            dateTimePickerbaslangic.Size = new Size(282, 29);
            dateTimePickerbaslangic.TabIndex = 29;
            dateTimePickerbaslangic.ValueChanged += dateTimePickerbaslangic_ValueChanged;
            // 
            // dateTimePickerbitis
            // 
            dateTimePickerbitis.CalendarForeColor = Color.IndianRed;
            dateTimePickerbitis.CalendarTitleForeColor = Color.IndianRed;
            dateTimePickerbitis.Location = new Point(524, 118);
            dateTimePickerbitis.Name = "dateTimePickerbitis";
            dateTimePickerbitis.Size = new Size(282, 29);
            dateTimePickerbitis.TabIndex = 30;
            dateTimePickerbitis.ValueChanged += dateTimePickerbitis_ValueChanged;
            // 
            // buttonfiltrele
            // 
            buttonfiltrele.FlatStyle = FlatStyle.Flat;
            buttonfiltrele.Location = new Point(843, 118);
            buttonfiltrele.Margin = new Padding(4);
            buttonfiltrele.Name = "buttonfiltrele";
            buttonfiltrele.Size = new Size(127, 29);
            buttonfiltrele.TabIndex = 32;
            buttonfiltrele.Text = "FİLTRELE";
            buttonfiltrele.UseVisualStyleBackColor = true;
            buttonfiltrele.Click += button2_Click;
            // 
            // buttonhesapla
            // 
            buttonhesapla.FlatStyle = FlatStyle.Flat;
            buttonhesapla.Location = new Point(999, 118);
            buttonhesapla.Margin = new Padding(4);
            buttonhesapla.Name = "buttonhesapla";
            buttonhesapla.Size = new Size(127, 29);
            buttonhesapla.TabIndex = 33;
            buttonhesapla.Text = "HESAPLA";
            buttonhesapla.UseVisualStyleBackColor = true;
            buttonhesapla.Click += button1_Click;
            // 
            // FrmRapor
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1839, 886);
            Controls.Add(buttonhesapla);
            Controls.Add(buttonfiltrele);
            Controls.Add(dateTimePickerbitis);
            Controls.Add(dateTimePickerbaslangic);
            Controls.Add(dataGridViewrapor);
            Controls.Add(pictureBox1);
            Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            ForeColor = Color.IndianRed;
            Margin = new Padding(4);
            Name = "FrmRapor";
            Text = "Raporlar";
            Load += FrmRapor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewrapor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridViewrapor;
        private DateTimePicker dateTimePickerbaslangic;
        private DateTimePicker dateTimePickerbitis;
        private Button buttonfiltrele;
        private Button buttonhesapla;
    }
}