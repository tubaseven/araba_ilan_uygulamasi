namespace Prolab4
{
    partial class SecimFormu
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
            this.button_Ilanlar = new System.Windows.Forms.Button();
            this.button_sistem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Ilanlar
            // 
            this.button_Ilanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Ilanlar.Location = new System.Drawing.Point(101, 163);
            this.button_Ilanlar.Name = "button_Ilanlar";
            this.button_Ilanlar.Size = new System.Drawing.Size(243, 57);
            this.button_Ilanlar.TabIndex = 0;
            this.button_Ilanlar.Text = "İLANLAR";
            this.button_Ilanlar.UseVisualStyleBackColor = true;
            this.button_Ilanlar.Click += new System.EventHandler(this.button_Ilanlar_Click);
            // 
            // button_sistem
            // 
            this.button_sistem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sistem.Location = new System.Drawing.Point(101, 74);
            this.button_sistem.Name = "button_sistem";
            this.button_sistem.Size = new System.Drawing.Size(243, 57);
            this.button_sistem.TabIndex = 1;
            this.button_sistem.Text = "SİSTEM";
            this.button_sistem.UseVisualStyleBackColor = true;
            this.button_sistem.Click += new System.EventHandler(this.button_sistem_Click);
            // 
            // Secim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 279);
            this.Controls.Add(this.button_sistem);
            this.Controls.Add(this.button_Ilanlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Secim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secim";
            this.Load += new System.EventHandler(this.Secim_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Ilanlar;
        private System.Windows.Forms.Button button_sistem;
    }
}