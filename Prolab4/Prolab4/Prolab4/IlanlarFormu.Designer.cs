namespace Prolab4
{
    partial class IlanlarFormu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView_liste = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_fiyat_min = new System.Windows.Forms.TextBox();
            this.textBox_fiyat_max = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox_sehir = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox_araba = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox_vitesTuru = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.comboBox_yakitTuru = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_tarih_sonra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_tarih_once = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.comboBox_renk = new System.Windows.Forms.ComboBox();
            this.button_filtrele = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_filtrele);
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTRELER";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView_liste);
            this.groupBox2.Location = new System.Drawing.Point(12, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(692, 323);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FILTRE SONUCLARI";
            // 
            // listView_liste
            // 
            this.listView_liste.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView_liste.Location = new System.Drawing.Point(6, 19);
            this.listView_liste.Name = "listView_liste";
            this.listView_liste.Size = new System.Drawing.Size(680, 298);
            this.listView_liste.TabIndex = 0;
            this.listView_liste.UseCompatibleStateImageBehavior = false;
            this.listView_liste.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ADI";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "FIYAT";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "KM";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TARIH";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ARABA";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "SEHIR";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox_fiyat_max);
            this.groupBox3.Controls.Add(this.textBox_fiyat_min);
            this.groupBox3.Location = new System.Drawing.Point(10, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 64);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fiyat";
            // 
            // textBox_fiyat_min
            // 
            this.textBox_fiyat_min.Location = new System.Drawing.Point(39, 23);
            this.textBox_fiyat_min.Name = "textBox_fiyat_min";
            this.textBox_fiyat_min.Size = new System.Drawing.Size(100, 20);
            this.textBox_fiyat_min.TabIndex = 3;
            // 
            // textBox_fiyat_max
            // 
            this.textBox_fiyat_max.Location = new System.Drawing.Point(188, 23);
            this.textBox_fiyat_max.Name = "textBox_fiyat_max";
            this.textBox_fiyat_max.Size = new System.Drawing.Size(100, 20);
            this.textBox_fiyat_max.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "max";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox_sehir);
            this.groupBox4.Location = new System.Drawing.Point(170, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(128, 61);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SEHIR";
            // 
            // comboBox_sehir
            // 
            this.comboBox_sehir.FormattingEnabled = true;
            this.comboBox_sehir.Location = new System.Drawing.Point(15, 22);
            this.comboBox_sehir.Name = "comboBox_sehir";
            this.comboBox_sehir.Size = new System.Drawing.Size(97, 21);
            this.comboBox_sehir.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox_araba);
            this.groupBox5.Location = new System.Drawing.Point(10, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(141, 61);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ARABA";
            // 
            // comboBox_araba
            // 
            this.comboBox_araba.FormattingEnabled = true;
            this.comboBox_araba.Location = new System.Drawing.Point(15, 22);
            this.comboBox_araba.Name = "comboBox_araba";
            this.comboBox_araba.Size = new System.Drawing.Size(113, 21);
            this.comboBox_araba.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBox_vitesTuru);
            this.groupBox6.Location = new System.Drawing.Point(304, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(123, 61);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "VİTES TURU";
            // 
            // comboBox_vitesTuru
            // 
            this.comboBox_vitesTuru.FormattingEnabled = true;
            this.comboBox_vitesTuru.Location = new System.Drawing.Point(15, 22);
            this.comboBox_vitesTuru.Name = "comboBox_vitesTuru";
            this.comboBox_vitesTuru.Size = new System.Drawing.Size(94, 21);
            this.comboBox_vitesTuru.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.comboBox_yakitTuru);
            this.groupBox7.Location = new System.Drawing.Point(433, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(128, 61);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "YAKIT TURU";
            // 
            // comboBox_yakitTuru
            // 
            this.comboBox_yakitTuru.FormattingEnabled = true;
            this.comboBox_yakitTuru.Location = new System.Drawing.Point(15, 22);
            this.comboBox_yakitTuru.Name = "comboBox_yakitTuru";
            this.comboBox_yakitTuru.Size = new System.Drawing.Size(105, 21);
            this.comboBox_yakitTuru.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.textBox_tarih_sonra);
            this.groupBox8.Controls.Add(this.textBox_tarih_once);
            this.groupBox8.Location = new System.Drawing.Point(319, 95);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(362, 64);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sonra";
            // 
            // textBox_tarih_sonra
            // 
            this.textBox_tarih_sonra.Location = new System.Drawing.Point(45, 23);
            this.textBox_tarih_sonra.Name = "textBox_tarih_sonra";
            this.textBox_tarih_sonra.Size = new System.Drawing.Size(78, 20);
            this.textBox_tarih_sonra.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Önce";
            // 
            // textBox_tarih_once
            // 
            this.textBox_tarih_once.Location = new System.Drawing.Point(193, 23);
            this.textBox_tarih_once.Name = "textBox_tarih_once";
            this.textBox_tarih_once.Size = new System.Drawing.Size(84, 20);
            this.textBox_tarih_once.TabIndex = 5;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.comboBox_renk);
            this.groupBox9.Location = new System.Drawing.Point(567, 19);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(114, 61);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "RENK";
            // 
            // comboBox_renk
            // 
            this.comboBox_renk.FormattingEnabled = true;
            this.comboBox_renk.Location = new System.Drawing.Point(15, 22);
            this.comboBox_renk.Name = "comboBox_renk";
            this.comboBox_renk.Size = new System.Drawing.Size(87, 21);
            this.comboBox_renk.TabIndex = 0;
            // 
            // button_filtrele
            // 
            this.button_filtrele.Location = new System.Drawing.Point(10, 181);
            this.button_filtrele.Name = "button_filtrele";
            this.button_filtrele.Size = new System.Drawing.Size(671, 23);
            this.button_filtrele.TabIndex = 11;
            this.button_filtrele.Text = "FILTRELE";
            this.button_filtrele.UseVisualStyleBackColor = true;
            // 
            // IlanlarFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 529);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "IlanlarFormu";
            this.Text = "Ilanlar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IlanlarFormu_FormClosed);
            this.Load += new System.EventHandler(this.IlanlarFormu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_tarih_sonra;
        private System.Windows.Forms.TextBox textBox_tarih_once;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox comboBox_yakitTuru;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBox_vitesTuru;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox_araba;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox_sehir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_fiyat_max;
        private System.Windows.Forms.TextBox textBox_fiyat_min;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView_liste;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button button_filtrele;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox comboBox_renk;
    }
}