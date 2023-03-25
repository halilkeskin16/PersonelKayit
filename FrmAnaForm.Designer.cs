namespace PersonelKayit
{
    partial class FrmAnaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.MskMaas = new System.Windows.Forms.MaskedTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.CmbSehir = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtMeslek = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnGrafikler = new System.Windows.Forms.Button();
            this.Btnİstatistik = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriDataSet = new PersonelKayit.PersonelVeriDataSet();
            this.tbl_PersonelTableAdapter = new PersonelKayit.PersonelVeriDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.MskMaas);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.CmbSehir);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.TxtMeslek);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txtid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 477);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Personel Kayıt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Maaş :";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(253, 317);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 32);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // MskMaas
            // 
            this.MskMaas.Location = new System.Drawing.Point(143, 411);
            this.MskMaas.Mask = "0000";
            this.MskMaas.Name = "MskMaas";
            this.MskMaas.Size = new System.Drawing.Size(201, 36);
            this.MskMaas.TabIndex = 6;
            this.MskMaas.ValidatingType = typeof(int);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(146, 315);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 32);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CmbSehir
            // 
            this.CmbSehir.FormattingEnabled = true;
            this.CmbSehir.Location = new System.Drawing.Point(146, 263);
            this.CmbSehir.Name = "CmbSehir";
            this.CmbSehir.Size = new System.Drawing.Size(198, 36);
            this.CmbSehir.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Meslek :";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(146, 205);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(198, 36);
            this.TxtSoyad.TabIndex = 3;
            // 
            // TxtMeslek
            // 
            this.TxtMeslek.Location = new System.Drawing.Point(143, 363);
            this.TxtMeslek.Name = "TxtMeslek";
            this.TxtMeslek.Size = new System.Drawing.Size(198, 36);
            this.TxtMeslek.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Durum :";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(143, 145);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(201, 36);
            this.TxtAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Ad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şehir :";
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(143, 91);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(201, 36);
            this.Txtid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personelid:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnGrafikler);
            this.groupBox2.Controls.Add(this.Btnİstatistik);
            this.groupBox2.Controls.Add(this.BtnTemizle);
            this.groupBox2.Controls.Add(this.BtnGuncelle);
            this.groupBox2.Controls.Add(this.BtnSil);
            this.groupBox2.Controls.Add(this.BtnKaydet);
            this.groupBox2.Controls.Add(this.BtnListele);
            this.groupBox2.Location = new System.Drawing.Point(415, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 464);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " İşlemler";
            // 
            // BtnGrafikler
            // 
            this.BtnGrafikler.Location = new System.Drawing.Point(51, 398);
            this.BtnGrafikler.Name = "BtnGrafikler";
            this.BtnGrafikler.Size = new System.Drawing.Size(191, 36);
            this.BtnGrafikler.TabIndex = 6;
            this.BtnGrafikler.Text = "Grafikler";
            this.BtnGrafikler.UseVisualStyleBackColor = true;
            this.BtnGrafikler.Click += new System.EventHandler(this.BtnGrafikler_Click);
            // 
            // Btnİstatistik
            // 
            this.Btnİstatistik.Location = new System.Drawing.Point(51, 339);
            this.Btnİstatistik.Name = "Btnİstatistik";
            this.Btnİstatistik.Size = new System.Drawing.Size(191, 36);
            this.Btnİstatistik.TabIndex = 5;
            this.Btnİstatistik.Text = "İstatistik";
            this.Btnİstatistik.UseVisualStyleBackColor = true;
            this.Btnİstatistik.Click += new System.EventHandler(this.Btnİstatistik_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(51, 282);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(191, 36);
            this.BtnTemizle.TabIndex = 4;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(51, 225);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(191, 36);
            this.BtnGuncelle.TabIndex = 3;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(51, 164);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(191, 36);
            this.BtnSil.TabIndex = 2;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(51, 99);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(191, 36);
            this.BtnKaydet.TabIndex = 1;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(51, 36);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(191, 36);
            this.BtnListele.TabIndex = 0;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(38, 495);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(933, 261);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(927, 226);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            this.peridDataGridViewTextBoxColumn.Width = 125;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            this.perSehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            this.perMaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            this.perDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            this.perMeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelVeriDataSet;
            // 
            // personelVeriDataSet
            // 
            this.personelVeriDataSet.DataSetName = "PersonelVeriDataSet";
            this.personelVeriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(816, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1004, 756);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAnaForm";
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAnaForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.MaskedTextBox MskMaas;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox CmbSehir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtMeslek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnGrafikler;
        private System.Windows.Forms.Button Btnİstatistik;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelVeriDataSet personelVeriDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelVeriDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
    }
}

