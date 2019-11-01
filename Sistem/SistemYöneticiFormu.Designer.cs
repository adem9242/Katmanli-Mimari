namespace Sistem
{
    partial class SistemYöneticiFormu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemYöneticiFormu));
            this.grupbox = new System.Windows.Forms.GroupBox();
            this.y_lst_kullanicilar = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.y_lst_yoneticiler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_skullaniciadi = new System.Windows.Forms.TextBox();
            this.txt_ssifre = new System.Windows.Forms.TextBox();
            this.txt_sadi = new System.Windows.Forms.TextBox();
            this.txt_ssoyadi = new System.Windows.Forms.TextBox();
            this.txt_seposta = new System.Windows.Forms.TextBox();
            this.btn_sguncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_skullaniciekle = new System.Windows.Forms.Button();
            this.btn_skullanicisil = new System.Windows.Forms.Button();
            this.btn_syetkiver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grupbox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupbox
            // 
            this.grupbox.Controls.Add(this.y_lst_kullanicilar);
            this.grupbox.Location = new System.Drawing.Point(12, 12);
            this.grupbox.Name = "grupbox";
            this.grupbox.Size = new System.Drawing.Size(305, 426);
            this.grupbox.TabIndex = 0;
            this.grupbox.TabStop = false;
            this.grupbox.Text = "Kullanıcılar";
            // 
            // y_lst_kullanicilar
            // 
            this.y_lst_kullanicilar.FormattingEnabled = true;
            this.y_lst_kullanicilar.ItemHeight = 16;
            this.y_lst_kullanicilar.Location = new System.Drawing.Point(0, 16);
            this.y_lst_kullanicilar.Name = "y_lst_kullanicilar";
            this.y_lst_kullanicilar.Size = new System.Drawing.Size(305, 404);
            this.y_lst_kullanicilar.TabIndex = 0;
            this.y_lst_kullanicilar.DoubleClick += new System.EventHandler(this.y_lst_kullanicilar_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.y_lst_yoneticiler);
            this.groupBox2.Location = new System.Drawing.Point(971, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yöneticiler";
            // 
            // y_lst_yoneticiler
            // 
            this.y_lst_yoneticiler.FormattingEnabled = true;
            this.y_lst_yoneticiler.ItemHeight = 16;
            this.y_lst_yoneticiler.Location = new System.Drawing.Point(0, 21);
            this.y_lst_yoneticiler.Name = "y_lst_yoneticiler";
            this.y_lst_yoneticiler.Size = new System.Drawing.Size(299, 404);
            this.y_lst_yoneticiler.TabIndex = 0;
            this.y_lst_yoneticiler.DoubleClick += new System.EventHandler(this.y_lst_yoneticiler_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Soyadı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "E-posta";
            // 
            // txt_skullaniciadi
            // 
            this.txt_skullaniciadi.Location = new System.Drawing.Point(532, 115);
            this.txt_skullaniciadi.Name = "txt_skullaniciadi";
            this.txt_skullaniciadi.Size = new System.Drawing.Size(269, 22);
            this.txt_skullaniciadi.TabIndex = 7;
            // 
            // txt_ssifre
            // 
            this.txt_ssifre.Location = new System.Drawing.Point(532, 157);
            this.txt_ssifre.Name = "txt_ssifre";
            this.txt_ssifre.Size = new System.Drawing.Size(269, 22);
            this.txt_ssifre.TabIndex = 7;
            // 
            // txt_sadi
            // 
            this.txt_sadi.Location = new System.Drawing.Point(532, 191);
            this.txt_sadi.Name = "txt_sadi";
            this.txt_sadi.Size = new System.Drawing.Size(269, 22);
            this.txt_sadi.TabIndex = 7;
            // 
            // txt_ssoyadi
            // 
            this.txt_ssoyadi.Location = new System.Drawing.Point(532, 234);
            this.txt_ssoyadi.Name = "txt_ssoyadi";
            this.txt_ssoyadi.Size = new System.Drawing.Size(269, 22);
            this.txt_ssoyadi.TabIndex = 7;
            // 
            // txt_seposta
            // 
            this.txt_seposta.Location = new System.Drawing.Point(532, 272);
            this.txt_seposta.Name = "txt_seposta";
            this.txt_seposta.Size = new System.Drawing.Size(269, 22);
            this.txt_seposta.TabIndex = 7;
            // 
            // btn_sguncelle
            // 
            this.btn_sguncelle.BackColor = System.Drawing.SystemColors.Control;
            this.btn_sguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sguncelle.ImageIndex = 3;
            this.btn_sguncelle.ImageList = this.ımageList1;
            this.btn_sguncelle.Location = new System.Drawing.Point(741, 348);
            this.btn_sguncelle.Name = "btn_sguncelle";
            this.btn_sguncelle.Size = new System.Drawing.Size(169, 50);
            this.btn_sguncelle.TabIndex = 8;
            this.btn_sguncelle.Text = "  Güncelle";
            this.btn_sguncelle.UseVisualStyleBackColor = false;
            this.btn_sguncelle.Click += new System.EventHandler(this.btn_sguncelle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "images (3).jpg");
            this.ımageList1.Images.SetKeyName(1, "images (4).jpg");
            this.ımageList1.Images.SetKeyName(2, "indir (3).jpg");
            this.ımageList1.Images.SetKeyName(3, "indir (4).jpg");
            this.ımageList1.Images.SetKeyName(4, "indir (5).jpg");
            this.ımageList1.Images.SetKeyName(5, "Adsız.jpg");
            // 
            // btn_skullaniciekle
            // 
            this.btn_skullaniciekle.BackColor = System.Drawing.SystemColors.Control;
            this.btn_skullaniciekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_skullaniciekle.ImageIndex = 0;
            this.btn_skullaniciekle.ImageList = this.ımageList1;
            this.btn_skullaniciekle.Location = new System.Drawing.Point(390, 348);
            this.btn_skullaniciekle.Name = "btn_skullaniciekle";
            this.btn_skullaniciekle.Size = new System.Drawing.Size(169, 50);
            this.btn_skullaniciekle.TabIndex = 8;
            this.btn_skullaniciekle.Text = "      Kullanıcı Ekle";
            this.btn_skullaniciekle.UseVisualStyleBackColor = false;
            this.btn_skullaniciekle.Click += new System.EventHandler(this.btn_skullaniciekle_Click);
            // 
            // btn_skullanicisil
            // 
            this.btn_skullanicisil.BackColor = System.Drawing.SystemColors.Control;
            this.btn_skullanicisil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_skullanicisil.ImageIndex = 2;
            this.btn_skullanicisil.ImageList = this.ımageList1;
            this.btn_skullanicisil.Location = new System.Drawing.Point(565, 348);
            this.btn_skullanicisil.Name = "btn_skullanicisil";
            this.btn_skullanicisil.Size = new System.Drawing.Size(169, 50);
            this.btn_skullanicisil.TabIndex = 8;
            this.btn_skullanicisil.Text = "  Kullanıcı Sil";
            this.btn_skullanicisil.UseVisualStyleBackColor = false;
            this.btn_skullanicisil.Click += new System.EventHandler(this.btn_skullanicisil_Click);
            // 
            // btn_syetkiver
            // 
            this.btn_syetkiver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_syetkiver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_syetkiver.ImageIndex = 4;
            this.btn_syetkiver.ImageList = this.ımageList1;
            this.btn_syetkiver.Location = new System.Drawing.Point(828, 33);
            this.btn_syetkiver.Name = "btn_syetkiver";
            this.btn_syetkiver.Size = new System.Drawing.Size(137, 55);
            this.btn_syetkiver.TabIndex = 8;
            this.btn_syetkiver.Text = "       Yetki Ver";
            this.btn_syetkiver.UseVisualStyleBackColor = false;
            this.btn_syetkiver.Click += new System.EventHandler(this.btn_syetkiver_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 1;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(1147, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "            ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(527, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sistem Yönetici Formu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "laaaaa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(-3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Lütfen Yetkiyi Kaldırmak için çift tıklayın";
            // 
            // SistemYöneticiFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1343, 533);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_skullaniciekle);
            this.Controls.Add(this.btn_skullanicisil);
            this.Controls.Add(this.btn_syetkiver);
            this.Controls.Add(this.btn_sguncelle);
            this.Controls.Add(this.txt_seposta);
            this.Controls.Add(this.txt_ssoyadi);
            this.Controls.Add(this.txt_sadi);
            this.Controls.Add(this.txt_ssifre);
            this.Controls.Add(this.txt_skullaniciadi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grupbox);
            this.Name = "SistemYöneticiFormu";
            this.Text = "SistemYöneticiFormu";
            this.Load += new System.EventHandler(this.SistemYöneticiFormu_Load);
            this.grupbox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grupbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_skullaniciadi;
        private System.Windows.Forms.TextBox txt_ssifre;
        private System.Windows.Forms.TextBox txt_sadi;
        private System.Windows.Forms.TextBox txt_ssoyadi;
        private System.Windows.Forms.TextBox txt_seposta;
        private System.Windows.Forms.Button btn_sguncelle;
        private System.Windows.Forms.Button btn_skullaniciekle;
        private System.Windows.Forms.Button btn_skullanicisil;
        private System.Windows.Forms.Button btn_syetkiver;
        private System.Windows.Forms.ListBox y_lst_kullanicilar;
        private System.Windows.Forms.ListBox y_lst_yoneticiler;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}