namespace deneme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_ulasim = new System.Windows.Forms.ComboBox();
            this.cmb_konaklama = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_baslangic = new System.Windows.Forms.DateTimePicker();
            this.dtp_bitis = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_lokasyon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ücret = new System.Windows.Forms.TextBox();
            this.btn_acikis = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(615, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rezervasyon Oluştur";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_ulasim
            // 
            this.cmb_ulasim.FormattingEnabled = true;
            this.cmb_ulasim.Items.AddRange(new object[] {
            "Ucak",
            "Otobus"});
            this.cmb_ulasim.Location = new System.Drawing.Point(167, 147);
            this.cmb_ulasim.Name = "cmb_ulasim";
            this.cmb_ulasim.Size = new System.Drawing.Size(121, 23);
            this.cmb_ulasim.TabIndex = 1;
            // 
            // cmb_konaklama
            // 
            this.cmb_konaklama.FormattingEnabled = true;
            this.cmb_konaklama.Items.AddRange(new object[] {
            "Otel",
            "Cadir"});
            this.cmb_konaklama.Location = new System.Drawing.Point(348, 147);
            this.cmb_konaklama.Name = "cmb_konaklama";
            this.cmb_konaklama.Size = new System.Drawing.Size(121, 23);
            this.cmb_konaklama.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(167, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ulaşım";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(348, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Konaklama";
            // 
            // txt_rNo
            // 
            this.txt_rNo.Location = new System.Drawing.Point(540, 147);
            this.txt_rNo.Name = "txt_rNo";
            this.txt_rNo.Size = new System.Drawing.Size(100, 23);
            this.txt_rNo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(540, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rezervasyon No";
            // 
            // dtp_baslangic
            // 
            this.dtp_baslangic.Location = new System.Drawing.Point(18, 258);
            this.dtp_baslangic.Name = "dtp_baslangic";
            this.dtp_baslangic.Size = new System.Drawing.Size(200, 23);
            this.dtp_baslangic.TabIndex = 7;
            // 
            // dtp_bitis
            // 
            this.dtp_bitis.Location = new System.Drawing.Point(321, 258);
            this.dtp_bitis.Name = "dtp_bitis";
            this.dtp_bitis.Size = new System.Drawing.Size(200, 23);
            this.dtp_bitis.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Baslangic Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bitis Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(17, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Lokasyon";
            // 
            // txt_lokasyon
            // 
            this.txt_lokasyon.Location = new System.Drawing.Point(17, 147);
            this.txt_lokasyon.Name = "txt_lokasyon";
            this.txt_lokasyon.Size = new System.Drawing.Size(100, 23);
            this.txt_lokasyon.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(712, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Rezervasyon Ücreti";
            // 
            // txt_ücret
            // 
            this.txt_ücret.Location = new System.Drawing.Point(712, 147);
            this.txt_ücret.Name = "txt_ücret";
            this.txt_ücret.Size = new System.Drawing.Size(100, 23);
            this.txt_ücret.TabIndex = 13;
            // 
            // btn_acikis
            // 
            this.btn_acikis.Location = new System.Drawing.Point(848, 24);
            this.btn_acikis.Name = "btn_acikis";
            this.btn_acikis.Size = new System.Drawing.Size(113, 40);
            this.btn_acikis.TabIndex = 15;
            this.btn_acikis.Text = "Admin Çıkışı";
            this.btn_acikis.UseVisualStyleBackColor = true;
            this.btn_acikis.Click += new System.EventHandler(this.btn_acikis_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(18, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Rezervasyon Oluştur";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 577);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_acikis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ücret);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_lokasyon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_bitis);
            this.Controls.Add(this.dtp_baslangic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_rNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_konaklama);
            this.Controls.Add(this.cmb_ulasim);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_ulasim;
        private System.Windows.Forms.ComboBox cmb_konaklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_rNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_baslangic;
        private System.Windows.Forms.DateTimePicker dtp_bitis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_lokasyon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ücret;
        private System.Windows.Forms.Button btn_acikis;
        private System.Windows.Forms.Label label8;
    }
}
