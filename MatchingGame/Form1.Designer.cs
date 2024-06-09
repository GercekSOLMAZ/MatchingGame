namespace EslestirmeGercekSolmaz
{
    partial class Form1
    {
        private System.ComponentModel.IContainer bileşenler = null;
        private System.Windows.Forms.TableLayoutPanel tabloPaneli;
        private System.Windows.Forms.Timer oyunZamanlayici;
        private System.Windows.Forms.Timer zamanlayici;
        private System.Windows.Forms.Label sureLabel;
        private System.Windows.Forms.Button oyunuBaslatDugmesi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (bileşenler != null))
            {
                bileşenler.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Tasarımcısı tarafından oluşturulan kod

        private void InitializeComponent()
        {
            this.bileşenler = new System.ComponentModel.Container();
            this.tabloPaneli = new System.Windows.Forms.TableLayoutPanel();
            this.oyunZamanlayici = new System.Windows.Forms.Timer(this.bileşenler);
            this.zamanlayici = new System.Windows.Forms.Timer(this.bileşenler);
            this.sureLabel = new System.Windows.Forms.Label();

            // 
            // tabloPaneli
            // 
            this.tabloPaneli.ColumnCount = 4;
            this.tabloPaneli.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabloPaneli.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabloPaneli.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabloPaneli.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabloPaneli.RowCount = 4;
            this.tabloPaneli.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabloPaneli.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabloPaneli.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabloPaneli.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabloPaneli.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabloPaneli.Location = new System.Drawing.Point(10, 10); // Kenar boşluklarını ekledik
            this.tabloPaneli.Margin = new System.Windows.Forms.Padding(10); // Kenar boşlukları
            this.tabloPaneli.Name = "tabloPaneli";
            this.tabloPaneli.Size = new System.Drawing.Size(460, 422);
            this.tabloPaneli.TabIndex = 0;

            this.oyunuBaslatDugmesi = new System.Windows.Forms.Button();
            this.oyunuBaslatDugmesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.oyunuBaslatDugmesi.Location = new System.Drawing.Point(480, 392);
            this.oyunuBaslatDugmesi.Margin = new System.Windows.Forms.Padding(10);
            this.oyunuBaslatDugmesi.Name = "oyunuBaslatDugmesi";
            this.oyunuBaslatDugmesi.Size = new System.Drawing.Size(100, 40);
            this.oyunuBaslatDugmesi.TabIndex = 2;
            this.oyunuBaslatDugmesi.Text = "Oyunu Başlat";
            this.oyunuBaslatDugmesi.UseVisualStyleBackColor = true;
            this.oyunuBaslatDugmesi.Click += new System.EventHandler(this.oyunuBaslatDugmesi_Click);

            this.Controls.Add(this.oyunuBaslatDugmesi);
            // Etiketleri TableLayoutPanel'e ekleyin
            for (int i = 0; i < 16; i++)
            {
                var etiket = new System.Windows.Forms.Label
                {
                    AutoSize = false,
                    Dock = System.Windows.Forms.DockStyle.Fill,
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                    BackColor = System.Drawing.Color.LightGreen,
                    Margin = new System.Windows.Forms.Padding(10) // Her etikete kenar boşluğu ekledik
                };
                etiket.Click += new System.EventHandler(this.Etiket_Click);
                this.tabloPaneli.Controls.Add(etiket);
            }

            // 
            // oyunZamanlayici
            // 
            this.oyunZamanlayici.Interval = 1000; // Her saniye
            this.oyunZamanlayici.Tick += new System.EventHandler(this.oyunZamanlayici_Tick);

            // 
            // zamanlayici
            // 
            this.zamanlayici.Interval = 750;
            this.zamanlayici.Tick += new System.EventHandler(this.zamanlayici_Tick);

            // 
            // sureLabel
            // 
            this.sureLabel.AutoSize = false;
            this.sureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sureLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sureLabel.Location = new System.Drawing.Point(480, 10);
            this.sureLabel.Margin = new System.Windows.Forms.Padding(10);
            this.sureLabel.Name = "sureLabel";
            this.sureLabel.Size = new System.Drawing.Size(100, 50);
            this.sureLabel.TabIndex = 1;
            this.sureLabel.Text = "60";
            this.sureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 442);
            this.Controls.Add(this.sureLabel);
            this.Controls.Add(this.tabloPaneli);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10); // Forma kenar boşluğu ekledik
            this.Text = "Eşleştirme Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
