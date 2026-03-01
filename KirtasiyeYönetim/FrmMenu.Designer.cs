namespace KirtasiyeYönetim
{
    partial class FrmMenu
    {


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            menuStrip1 = new MenuStrip();
            ürünToolStripMenuItem = new ToolStripMenuItem();
            kategoriYönetimiToolStripMenuItem = new ToolStripMenuItem();
            kullanıcıYönetimiToolStripMenuItem = new ToolStripMenuItem();
            satislarToolStripMenuItem = new ToolStripMenuItem();
            siparişlerToolStripMenuItem1 = new ToolStripMenuItem();
            alışSayfasıToolStripMenuItem = new ToolStripMenuItem();
            siparişDetaylarıToolStripMenuItem = new ToolStripMenuItem();
            tedarikçiYönetimiToolStripMenuItem = new ToolStripMenuItem();
            müşterimiToolStripMenuItem = new ToolStripMenuItem();
            çalışanlarYönetimiToolStripMenuItem = new ToolStripMenuItem();
            raporToolStripMenuItem = new ToolStripMenuItem();
            labelkullanicibilgi = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Sitka Text", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.ImeMode = ImeMode.NoControl;
            menuStrip1.Items.AddRange(new ToolStripItem[] { ürünToolStripMenuItem, kategoriYönetimiToolStripMenuItem, kullanıcıYönetimiToolStripMenuItem, satislarToolStripMenuItem, tedarikçiYönetimiToolStripMenuItem, müşterimiToolStripMenuItem, çalışanlarYönetimiToolStripMenuItem, raporToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.Table;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Margin = new Padding(10, 0, 0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 2, 0, 0);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(202, 597);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // ürünToolStripMenuItem
            // 
            ürünToolStripMenuItem.ForeColor = Color.IndianRed;
            ürünToolStripMenuItem.Name = "ürünToolStripMenuItem";
            ürünToolStripMenuItem.Padding = new Padding(5, 0, 5, 80);
            ürünToolStripMenuItem.Size = new Size(153, 110);
            ürünToolStripMenuItem.Text = "Ürün Yönetimi";
            ürünToolStripMenuItem.Click += ürünToolStripMenuItem_Click;
            // 
            // kategoriYönetimiToolStripMenuItem
            // 
            kategoriYönetimiToolStripMenuItem.ForeColor = Color.IndianRed;
            kategoriYönetimiToolStripMenuItem.Name = "kategoriYönetimiToolStripMenuItem";
            kategoriYönetimiToolStripMenuItem.Padding = new Padding(5, 0, 5, 80);
            kategoriYönetimiToolStripMenuItem.Size = new Size(184, 110);
            kategoriYönetimiToolStripMenuItem.Text = "Kategori Yönetimi";
            kategoriYönetimiToolStripMenuItem.Click += kategoriYönetimiToolStripMenuItem_Click;
            // 
            // kullanıcıYönetimiToolStripMenuItem
            // 
            kullanıcıYönetimiToolStripMenuItem.ForeColor = Color.IndianRed;
            kullanıcıYönetimiToolStripMenuItem.Name = "kullanıcıYönetimiToolStripMenuItem";
            kullanıcıYönetimiToolStripMenuItem.Padding = new Padding(5, 0, 5, 80);
            kullanıcıYönetimiToolStripMenuItem.Size = new Size(186, 110);
            kullanıcıYönetimiToolStripMenuItem.Text = "Kullanıcı Yönetimi";
            kullanıcıYönetimiToolStripMenuItem.Click += kullanıcıYönetimiToolStripMenuItem_Click;
            // 
            // satislarToolStripMenuItem
            // 
            satislarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { siparişlerToolStripMenuItem1, alışSayfasıToolStripMenuItem, siparişDetaylarıToolStripMenuItem });
            satislarToolStripMenuItem.ForeColor = Color.IndianRed;
            satislarToolStripMenuItem.Name = "satislarToolStripMenuItem";
            satislarToolStripMenuItem.Padding = new Padding(5, 0, 5, 80);
            satislarToolStripMenuItem.Size = new Size(152, 110);
            satislarToolStripMenuItem.Text = "Satış İşlemleri";
            satislarToolStripMenuItem.Click += siparişlerToolStripMenuItem_Click;
            // 
            // siparişlerToolStripMenuItem1
            // 
            siparişlerToolStripMenuItem1.ForeColor = Color.IndianRed;
            siparişlerToolStripMenuItem1.Name = "siparişlerToolStripMenuItem1";
            siparişlerToolStripMenuItem1.Size = new Size(282, 30);
            siparişlerToolStripMenuItem1.Text = "Siparişler";
            siparişlerToolStripMenuItem1.Click += siparişlerToolStripMenuItem1_Click;
            // 
            // alışSayfasıToolStripMenuItem
            // 
            alışSayfasıToolStripMenuItem.ForeColor = Color.IndianRed;
            alışSayfasıToolStripMenuItem.Name = "alışSayfasıToolStripMenuItem";
            alışSayfasıToolStripMenuItem.Size = new Size(282, 30);
            alışSayfasıToolStripMenuItem.Text = "Alış Sayfası Yönetimi";
            alışSayfasıToolStripMenuItem.Click += alışSayfasıToolStripMenuItem_Click;
            // 
            // siparişDetaylarıToolStripMenuItem
            // 
            siparişDetaylarıToolStripMenuItem.ForeColor = Color.IndianRed;
            siparişDetaylarıToolStripMenuItem.Name = "siparişDetaylarıToolStripMenuItem";
            siparişDetaylarıToolStripMenuItem.Size = new Size(282, 30);
            siparişDetaylarıToolStripMenuItem.Text = "Sipariş Detayları";
            siparişDetaylarıToolStripMenuItem.Click += siparişDetaylarıToolStripMenuItem_Click;
            // 
            // tedarikçiYönetimiToolStripMenuItem
            // 
            tedarikçiYönetimiToolStripMenuItem.ForeColor = Color.IndianRed;
            tedarikçiYönetimiToolStripMenuItem.Name = "tedarikçiYönetimiToolStripMenuItem";
            tedarikçiYönetimiToolStripMenuItem.Padding = new Padding(5, 0, 5, 80);
            tedarikçiYönetimiToolStripMenuItem.Size = new Size(189, 110);
            tedarikçiYönetimiToolStripMenuItem.Text = "Tedarikçi Yönetimi";
            tedarikçiYönetimiToolStripMenuItem.Click += tedarikçiYönetimiToolStripMenuItem_Click;
            // 
            // müşterimiToolStripMenuItem
            // 
            müşterimiToolStripMenuItem.ForeColor = Color.IndianRed;
            müşterimiToolStripMenuItem.Name = "müşterimiToolStripMenuItem";
            müşterimiToolStripMenuItem.Padding = new Padding(5, 0, 5, 80);
            müşterimiToolStripMenuItem.Size = new Size(177, 110);
            müşterimiToolStripMenuItem.Text = "Müşteri Yönetimi";
            müşterimiToolStripMenuItem.Click += müşterimiToolStripMenuItem_Click;
            // 
            // çalışanlarYönetimiToolStripMenuItem
            // 
            çalışanlarYönetimiToolStripMenuItem.ForeColor = Color.IndianRed;
            çalışanlarYönetimiToolStripMenuItem.Name = "çalışanlarYönetimiToolStripMenuItem";
            çalışanlarYönetimiToolStripMenuItem.Padding = new Padding(5, 0, 5, 80);
            çalışanlarYönetimiToolStripMenuItem.Size = new Size(196, 110);
            çalışanlarYönetimiToolStripMenuItem.Text = "Çalışanlar Yönetimi";
            çalışanlarYönetimiToolStripMenuItem.Click += çalışanlarYönetimiToolStripMenuItem_Click;
            // 
            // raporToolStripMenuItem
            // 
            raporToolStripMenuItem.ForeColor = Color.IndianRed;
            raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            raporToolStripMenuItem.Padding = new Padding(5, 0, 5, 80);
            raporToolStripMenuItem.Size = new Size(79, 110);
            raporToolStripMenuItem.Text = "Rapor";
            raporToolStripMenuItem.Click += raporToolStripMenuItem_Click;
            // 
            // labelkullanicibilgi
            // 
            labelkullanicibilgi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelkullanicibilgi.AutoSize = true;
            labelkullanicibilgi.BackColor = Color.Transparent;
            labelkullanicibilgi.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            labelkullanicibilgi.ForeColor = Color.IndianRed;
            labelkullanicibilgi.Location = new Point(1339, 9);
            labelkullanicibilgi.Name = "labelkullanicibilgi";
            labelkullanicibilgi.Size = new Size(0, 24);
            labelkullanicibilgi.TabIndex = 4;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1360, 597);
            Controls.Add(labelkullanicibilgi);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Menü";
            WindowState = FormWindowState.Maximized;
            FormClosing += FrmMenu_FormClosing;
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ürünToolStripMenuItem;
        private ToolStripMenuItem kategoriYönetimiToolStripMenuItem;
        private ToolStripMenuItem kullanıcıYönetimiToolStripMenuItem;
        private ToolStripMenuItem satislarToolStripMenuItem;
        private ToolStripMenuItem tedarikçiYönetimiToolStripMenuItem;
        private ToolStripMenuItem siparişlerToolStripMenuItem1;
        private ToolStripMenuItem müşterimiToolStripMenuItem;
        private ToolStripMenuItem alışSayfasıToolStripMenuItem;
        private ToolStripMenuItem çalışanlarYönetimiToolStripMenuItem;
        private ToolStripMenuItem raporToolStripMenuItem;
        private ToolStripMenuItem siparişDetaylarıToolStripMenuItem;
        private Label labelkullanicibilgi;
    }
}