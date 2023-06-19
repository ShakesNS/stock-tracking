namespace StokTakip
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbKategoriListele = new System.Windows.Forms.ComboBox();
            this.lwListeleme = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUrunAdi = new System.Windows.Forms.TextBox();
            this.tbBirimFiyat = new System.Windows.Forms.TextBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.cbMarketAdi = new System.Windows.Forms.ComboBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMarketListeleme = new System.Windows.Forms.ComboBox();
            this.contextBtn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbKategoriListele
            // 
            this.cbKategoriListele.FormattingEnabled = true;
            this.cbKategoriListele.Location = new System.Drawing.Point(115, 46);
            this.cbKategoriListele.Name = "cbKategoriListele";
            this.cbKategoriListele.Size = new System.Drawing.Size(182, 21);
            this.cbKategoriListele.TabIndex = 0;
            this.cbKategoriListele.Text = "Bİr Değer Seçiniz";
            this.cbKategoriListele.SelectionChangeCommitted += new System.EventHandler(this.cbKategoriListele_SelectionChangeCommitted);
            // 
            // lwListeleme
            // 
            this.lwListeleme.ContextMenuStrip = this.contextBtn;
            this.lwListeleme.FullRowSelect = true;
            this.lwListeleme.GridLines = true;
            this.lwListeleme.HideSelection = false;
            this.lwListeleme.Location = new System.Drawing.Point(13, 79);
            this.lwListeleme.Name = "lwListeleme";
            this.lwListeleme.Size = new System.Drawing.Size(594, 439);
            this.lwListeleme.TabIndex = 1;
            this.lwListeleme.UseCompatibleStateImageBehavior = false;
            this.lwListeleme.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategoriler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(630, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(630, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(613, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Birim Fiyatı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(654, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tarih:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(613, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Market Adı:";
            // 
            // tbUrunAdi
            // 
            this.tbUrunAdi.Location = new System.Drawing.Point(711, 115);
            this.tbUrunAdi.Name = "tbUrunAdi";
            this.tbUrunAdi.Size = new System.Drawing.Size(153, 20);
            this.tbUrunAdi.TabIndex = 9;
            // 
            // tbBirimFiyat
            // 
            this.tbBirimFiyat.Location = new System.Drawing.Point(711, 155);
            this.tbBirimFiyat.Name = "tbBirimFiyat";
            this.tbBirimFiyat.Size = new System.Drawing.Size(153, 20);
            this.tbBirimFiyat.TabIndex = 10;
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(711, 75);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(153, 21);
            this.cbKategori.TabIndex = 11;
            this.cbKategori.Text = "Bİr Değer Seçiniz";
            // 
            // cbMarketAdi
            // 
            this.cbMarketAdi.FormattingEnabled = true;
            this.cbMarketAdi.Location = new System.Drawing.Point(711, 235);
            this.cbMarketAdi.Name = "cbMarketAdi";
            this.cbMarketAdi.Size = new System.Drawing.Size(153, 21);
            this.cbMarketAdi.TabIndex = 12;
            this.cbMarketAdi.Text = "Bİr Değer Seçiniz";
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(711, 195);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(153, 20);
            this.dtTarih.TabIndex = 13;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(637, 302);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(88, 60);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(776, 302);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(88, 60);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(312, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Marketler";
            // 
            // cbMarketListeleme
            // 
            this.cbMarketListeleme.FormattingEnabled = true;
            this.cbMarketListeleme.Location = new System.Drawing.Point(418, 48);
            this.cbMarketListeleme.Name = "cbMarketListeleme";
            this.cbMarketListeleme.Size = new System.Drawing.Size(182, 21);
            this.cbMarketListeleme.TabIndex = 16;
            this.cbMarketListeleme.Text = "Bİr Değer Seçiniz";
            this.cbMarketListeleme.SelectionChangeCommitted += new System.EventHandler(this.cbMarketListeleme_SelectionChangeCommitted);
            // 
            // contextBtn
            // 
            this.contextBtn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.contextBtn.Name = "contextBtn";
            this.contextBtn.Size = new System.Drawing.Size(121, 48);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 553);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbMarketListeleme);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.cbMarketAdi);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.tbBirimFiyat);
            this.Controls.Add(this.tbUrunAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lwListeleme);
            this.Controls.Add(this.cbKategoriListele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextBtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKategoriListele;
        private System.Windows.Forms.ListView lwListeleme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUrunAdi;
        private System.Windows.Forms.TextBox tbBirimFiyat;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.ComboBox cbMarketAdi;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMarketListeleme;
        private System.Windows.Forms.ContextMenuStrip contextBtn;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
    }
}

