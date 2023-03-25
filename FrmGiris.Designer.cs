namespace PersonelKayit
{
    partial class FrmGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKullanici = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbsifre = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // TxtKullanici
            // 
            this.TxtKullanici.Location = new System.Drawing.Point(209, 67);
            this.TxtKullanici.Name = "TxtKullanici";
            this.TxtKullanici.Size = new System.Drawing.Size(155, 36);
            this.TxtKullanici.TabIndex = 2;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(209, 128);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(155, 36);
            this.TxtSifre.TabIndex = 3;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(501, 44);
            this.label3.TabIndex = 5;
            this.label3.Text = "Personel Takip Sistemi Giriş ";
            // 
            // cbsifre
            // 
            this.cbsifre.AutoSize = true;
            this.cbsifre.Location = new System.Drawing.Point(382, 130);
            this.cbsifre.Name = "cbsifre";
            this.cbsifre.Size = new System.Drawing.Size(145, 32);
            this.cbsifre.TabIndex = 6;
            this.cbsifre.Text = "Şifre Göster";
            this.cbsifre.UseVisualStyleBackColor = true;
            this.cbsifre.CheckedChanged += new System.EventHandler(this.cbsifre_CheckedChanged);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(539, 223);
            this.Controls.Add(this.cbsifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullanici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGiris";
            this.Text = "FrmGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKullanici;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbsifre;
    }
}