namespace ödev_menü
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aksiyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciSicilBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciHarçBilbileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romantikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maceraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.komediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciHarçBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.öğrenciTranskriptBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciKimlikBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.öğrenciAdresBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.öğrenciBölümBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.programHakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.programdanÇıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aksiyonToolStripMenuItem,
            this.romantikToolStripMenuItem,
            this.maceraToolStripMenuItem,
            this.komediToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aksiyonToolStripMenuItem
            // 
            this.aksiyonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ogrenciSicilBilgileriToolStripMenuItem,
            this.öğrenciHarçBilbileriToolStripMenuItem,
            this.öğrenciHarçBilgileriToolStripMenuItem,
            this.toolStripMenuItem1,
            this.öğrenciTranskriptBilgileriToolStripMenuItem});
            this.aksiyonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aksiyonToolStripMenuItem.Name = "aksiyonToolStripMenuItem";
            this.aksiyonToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.aksiyonToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.aksiyonToolStripMenuItem.ShowShortcutKeys = false;
            this.aksiyonToolStripMenuItem.Size = new System.Drawing.Size(144, 27);
            this.aksiyonToolStripMenuItem.Text = "Öğrenci Bilgileri";
            this.aksiyonToolStripMenuItem.Click += new System.EventHandler(this.aksiyonToolStripMenuItem_Click);
            // 
            // ogrenciSicilBilgileriToolStripMenuItem
            // 
            this.ogrenciSicilBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciKimlikBilgileriToolStripMenuItem,
            this.toolStripMenuItem2,
            this.öğrenciAdresBilgileriToolStripMenuItem,
            this.toolStripMenuItem3,
            this.öğrenciBölümBilgileriToolStripMenuItem,
            this.toolStripMenuItem4});
            this.ogrenciSicilBilgileriToolStripMenuItem.Name = "ogrenciSicilBilgileriToolStripMenuItem";
            this.ogrenciSicilBilgileriToolStripMenuItem.Size = new System.Drawing.Size(294, 28);
            this.ogrenciSicilBilgileriToolStripMenuItem.Text = "Öğrenci &Sicil Bilgileri";
            this.ogrenciSicilBilgileriToolStripMenuItem.Click += new System.EventHandler(this.ogrenciSicilBilgileriToolStripMenuItem_Click);
            // 
            // öğrenciHarçBilbileriToolStripMenuItem
            // 
            this.öğrenciHarçBilbileriToolStripMenuItem.Name = "öğrenciHarçBilbileriToolStripMenuItem";
            this.öğrenciHarçBilbileriToolStripMenuItem.Size = new System.Drawing.Size(294, 28);
            this.öğrenciHarçBilbileriToolStripMenuItem.Text = "Öğrenci &Not Bilgileri";
            // 
            // romantikToolStripMenuItem
            // 
            this.romantikToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.romantikToolStripMenuItem.Name = "romantikToolStripMenuItem";
            this.romantikToolStripMenuItem.Size = new System.Drawing.Size(89, 27);
            this.romantikToolStripMenuItem.Text = "Raporlar";
            // 
            // maceraToolStripMenuItem
            // 
            this.maceraToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maceraToolStripMenuItem.Name = "maceraToolStripMenuItem";
            this.maceraToolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.maceraToolStripMenuItem.Text = "Listeler";
            // 
            // komediToolStripMenuItem
            // 
            this.komediToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programHakkındaToolStripMenuItem,
            this.toolStripMenuItem5,
            this.yardımToolStripMenuItem,
            this.toolStripMenuItem6,
            this.programdanÇıkışToolStripMenuItem});
            this.komediToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.komediToolStripMenuItem.Name = "komediToolStripMenuItem";
            this.komediToolStripMenuItem.Size = new System.Drawing.Size(134, 27);
            this.komediToolStripMenuItem.Text = "Program Sonu";
            // 
            // öğrenciHarçBilgileriToolStripMenuItem
            // 
            this.öğrenciHarçBilgileriToolStripMenuItem.Name = "öğrenciHarçBilgileriToolStripMenuItem";
            this.öğrenciHarçBilgileriToolStripMenuItem.Size = new System.Drawing.Size(294, 28);
            this.öğrenciHarçBilgileriToolStripMenuItem.Text = "Öğrenci &Harç Bilgileri";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(291, 6);
            // 
            // öğrenciTranskriptBilgileriToolStripMenuItem
            // 
            this.öğrenciTranskriptBilgileriToolStripMenuItem.Name = "öğrenciTranskriptBilgileriToolStripMenuItem";
            this.öğrenciTranskriptBilgileriToolStripMenuItem.Size = new System.Drawing.Size(294, 28);
            this.öğrenciTranskriptBilgileriToolStripMenuItem.Text = "Öğrenci &Transkript Bilgileri";
            // 
            // öğrenciKimlikBilgileriToolStripMenuItem
            // 
            this.öğrenciKimlikBilgileriToolStripMenuItem.Name = "öğrenciKimlikBilgileriToolStripMenuItem";
            this.öğrenciKimlikBilgileriToolStripMenuItem.Size = new System.Drawing.Size(268, 28);
            this.öğrenciKimlikBilgileriToolStripMenuItem.Text = "Öğrenci Kimlik Bilgileri";
            this.öğrenciKimlikBilgileriToolStripMenuItem.Click += new System.EventHandler(this.öğrenciKimlikBilgileriToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(265, 6);
            // 
            // öğrenciAdresBilgileriToolStripMenuItem
            // 
            this.öğrenciAdresBilgileriToolStripMenuItem.Name = "öğrenciAdresBilgileriToolStripMenuItem";
            this.öğrenciAdresBilgileriToolStripMenuItem.Size = new System.Drawing.Size(268, 28);
            this.öğrenciAdresBilgileriToolStripMenuItem.Text = "Öğrenci Adres Bilgileri";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(265, 6);
            // 
            // öğrenciBölümBilgileriToolStripMenuItem
            // 
            this.öğrenciBölümBilgileriToolStripMenuItem.Name = "öğrenciBölümBilgileriToolStripMenuItem";
            this.öğrenciBölümBilgileriToolStripMenuItem.Size = new System.Drawing.Size(268, 28);
            this.öğrenciBölümBilgileriToolStripMenuItem.Text = "Öğrenci Bölüm Bilgileri";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(265, 6);
            // 
            // programHakkındaToolStripMenuItem
            // 
            this.programHakkındaToolStripMenuItem.Name = "programHakkındaToolStripMenuItem";
            this.programHakkındaToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.programHakkındaToolStripMenuItem.Text = "Program Hakkında";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(235, 6);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(235, 6);
            // 
            // programdanÇıkışToolStripMenuItem
            // 
            this.programdanÇıkışToolStripMenuItem.Name = "programdanÇıkışToolStripMenuItem";
            this.programdanÇıkışToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.programdanÇıkışToolStripMenuItem.Text = "Programdan Çıkış";
            this.programdanÇıkışToolStripMenuItem.Click += new System.EventHandler(this.programdanÇıkışToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(508, 301);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MenuStrip";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aksiyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogrenciSicilBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciHarçBilbileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romantikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maceraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem komediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciKimlikBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem öğrenciAdresBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem öğrenciBölümBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem öğrenciHarçBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciTranskriptBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programHakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem programdanÇıkışToolStripMenuItem;
    }
}

