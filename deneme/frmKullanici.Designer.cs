namespace deneme
{
    partial class frmKullanici
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_lokasyon = new System.Windows.Forms.TextBox();
            this.btn_kcikis2 = new System.Windows.Forms.Button();
            this.txt_mno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_rezervasyonyap = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_rbitis = new System.Windows.Forms.DateTimePicker();
            this.dtp_rbaslangic = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_kcikis = new System.Windows.Forms.Button();
            this.btn_ulasimiptal = new System.Windows.Forms.Button();
            this.btn_konaklamaiptal = new System.Windows.Forms.Button();
            this.btn_rgöster = new System.Windows.Forms.Button();
            this.txt_mno2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1290, 540);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_lokasyon);
            this.tabPage1.Controls.Add(this.btn_kcikis2);
            this.tabPage1.Controls.Add(this.txt_mno);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btn_rezervasyonyap);
            this.tabPage1.Controls.Add(this.btn_listele);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dtp_rbitis);
            this.tabPage1.Controls.Add(this.dtp_rbaslangic);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1282, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rezervasyon Yap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Lokasyon ";
            // 
            // txt_lokasyon
            // 
            this.txt_lokasyon.Location = new System.Drawing.Point(12, 107);
            this.txt_lokasyon.Name = "txt_lokasyon";
            this.txt_lokasyon.Size = new System.Drawing.Size(176, 23);
            this.txt_lokasyon.TabIndex = 27;
            // 
            // btn_kcikis2
            // 
            this.btn_kcikis2.Location = new System.Drawing.Point(1147, 23);
            this.btn_kcikis2.Name = "btn_kcikis2";
            this.btn_kcikis2.Size = new System.Drawing.Size(111, 38);
            this.btn_kcikis2.TabIndex = 26;
            this.btn_kcikis2.Text = "Kullanıcı Çıkışı";
            this.btn_kcikis2.UseVisualStyleBackColor = true;
            this.btn_kcikis2.Click += new System.EventHandler(this.btn_kcikis2_Click);
            // 
            // txt_mno
            // 
            this.txt_mno.Location = new System.Drawing.Point(806, 222);
            this.txt_mno.Name = "txt_mno";
            this.txt_mno.Size = new System.Drawing.Size(176, 23);
            this.txt_mno.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(806, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Müşteri Numaranızı Giriniz";
            // 
            // btn_rezervasyonyap
            // 
            this.btn_rezervasyonyap.Location = new System.Drawing.Point(806, 303);
            this.btn_rezervasyonyap.Name = "btn_rezervasyonyap";
            this.btn_rezervasyonyap.Size = new System.Drawing.Size(183, 51);
            this.btn_rezervasyonyap.TabIndex = 17;
            this.btn_rezervasyonyap.Text = "Rezervasyon Yap";
            this.btn_rezervasyonyap.UseVisualStyleBackColor = true;
            this.btn_rezervasyonyap.Click += new System.EventHandler(this.btn_rezervasyonyap_Click_1);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(713, 104);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(75, 23);
            this.btn_listele.TabIndex = 16;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(229, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Başlangıç Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(467, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bitis Tarihi";
            // 
            // dtp_rbitis
            // 
            this.dtp_rbitis.Location = new System.Drawing.Point(467, 104);
            this.dtp_rbitis.Name = "dtp_rbitis";
            this.dtp_rbitis.Size = new System.Drawing.Size(200, 23);
            this.dtp_rbitis.TabIndex = 13;
            // 
            // dtp_rbaslangic
            // 
            this.dtp_rbaslangic.Location = new System.Drawing.Point(229, 107);
            this.dtp_rbaslangic.Name = "dtp_rbaslangic";
            this.dtp_rbaslangic.Size = new System.Drawing.Size(200, 23);
            this.dtp_rbaslangic.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 216);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Rezervasyon Yap";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.btn_kcikis);
            this.tabPage2.Controls.Add(this.btn_ulasimiptal);
            this.tabPage2.Controls.Add(this.btn_konaklamaiptal);
            this.tabPage2.Controls.Add(this.btn_rgöster);
            this.tabPage2.Controls.Add(this.txt_mno2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1282, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rezervasyon İptali";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btn_kcikis
            // 
            this.btn_kcikis.Location = new System.Drawing.Point(1137, 17);
            this.btn_kcikis.Name = "btn_kcikis";
            this.btn_kcikis.Size = new System.Drawing.Size(111, 38);
            this.btn_kcikis.TabIndex = 25;
            this.btn_kcikis.Text = "Kullanıcı Çıkışı";
            this.btn_kcikis.UseVisualStyleBackColor = true;
            this.btn_kcikis.Click += new System.EventHandler(this.btn_kcikis_Click);
            // 
            // btn_ulasimiptal
            // 
            this.btn_ulasimiptal.Location = new System.Drawing.Point(736, 146);
            this.btn_ulasimiptal.Name = "btn_ulasimiptal";
            this.btn_ulasimiptal.Size = new System.Drawing.Size(111, 38);
            this.btn_ulasimiptal.TabIndex = 24;
            this.btn_ulasimiptal.Text = "Ulaşım İptali";
            this.btn_ulasimiptal.UseVisualStyleBackColor = true;
            this.btn_ulasimiptal.Click += new System.EventHandler(this.btn_ulasimiptal_Click);
            // 
            // btn_konaklamaiptal
            // 
            this.btn_konaklamaiptal.Location = new System.Drawing.Point(736, 228);
            this.btn_konaklamaiptal.Name = "btn_konaklamaiptal";
            this.btn_konaklamaiptal.Size = new System.Drawing.Size(111, 38);
            this.btn_konaklamaiptal.TabIndex = 23;
            this.btn_konaklamaiptal.Text = "Konaklama İptali";
            this.btn_konaklamaiptal.UseVisualStyleBackColor = true;
            this.btn_konaklamaiptal.Click += new System.EventHandler(this.btn_konaklamaiptal_Click);
            // 
            // btn_rgöster
            // 
            this.btn_rgöster.Location = new System.Drawing.Point(253, 89);
            this.btn_rgöster.Name = "btn_rgöster";
            this.btn_rgöster.Size = new System.Drawing.Size(111, 38);
            this.btn_rgöster.TabIndex = 22;
            this.btn_rgöster.Text = "Rezervasyonlarımı Göster";
            this.btn_rgöster.UseVisualStyleBackColor = true;
            this.btn_rgöster.Click += new System.EventHandler(this.btn_rgöster_Click);
            // 
            // txt_mno2
            // 
            this.txt_mno2.Location = new System.Drawing.Point(19, 98);
            this.txt_mno2.Name = "txt_mno2";
            this.txt_mno2.Size = new System.Drawing.Size(176, 23);
            this.txt_mno2.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Müşteri Numaranızı Giriniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Rezervasyon İptali";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 136);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(707, 307);
            this.dataGridView2.TabIndex = 0;
            // 
            // frmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1274, 530);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmKullanici";
            this.Text = "frmKullanici";
            this.Load += new System.EventHandler(this.frmKullanici_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TextBox txt_mno;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_rezervasyonyap;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_rbitis;
        private System.Windows.Forms.DateTimePicker dtp_rbaslangic;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.TextBox txt_mno2;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_rgöster;
        private System.Windows.Forms.Button btn_ulasimiptal;
        private System.Windows.Forms.Button btn_konaklamaiptal;
        private System.Windows.Forms.Button btn_kcikis2;
        private System.Windows.Forms.Button btn_kcikis;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_lokasyon;
    }
}