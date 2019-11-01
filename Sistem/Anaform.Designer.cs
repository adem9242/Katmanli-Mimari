namespace Sistem
{
    partial class Anaform
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
            this.list_liste = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_anaform_kullaniciadi = new System.Windows.Forms.TextBox();
            this.txt_anaform_sifre = new System.Windows.Forms.TextBox();
            this.txt_anaform_yenisifre = new System.Windows.Forms.TextBox();
            this.txt_anaform_yenisifretekrar = new System.Windows.Forms.TextBox();
            this.btn_anaformsifredegistir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.list_liste);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Listesi";
            // 
            // list_liste
            // 
            this.list_liste.FormattingEnabled = true;
            this.list_liste.ItemHeight = 16;
            this.list_liste.Location = new System.Drawing.Point(6, 21);
            this.list_liste.Name = "list_liste";
            this.list_liste.Size = new System.Drawing.Size(764, 148);
            this.list_liste.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yeni Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yeni Şifre Tekrar";
            // 
            // txt_anaform_kullaniciadi
            // 
            this.txt_anaform_kullaniciadi.Location = new System.Drawing.Point(386, 226);
            this.txt_anaform_kullaniciadi.Name = "txt_anaform_kullaniciadi";
            this.txt_anaform_kullaniciadi.Size = new System.Drawing.Size(203, 22);
            this.txt_anaform_kullaniciadi.TabIndex = 5;
            // 
            // txt_anaform_sifre
            // 
            this.txt_anaform_sifre.Location = new System.Drawing.Point(386, 262);
            this.txt_anaform_sifre.Name = "txt_anaform_sifre";
            this.txt_anaform_sifre.Size = new System.Drawing.Size(203, 22);
            this.txt_anaform_sifre.TabIndex = 5;
            // 
            // txt_anaform_yenisifre
            // 
            this.txt_anaform_yenisifre.Location = new System.Drawing.Point(386, 303);
            this.txt_anaform_yenisifre.Name = "txt_anaform_yenisifre";
            this.txt_anaform_yenisifre.Size = new System.Drawing.Size(203, 22);
            this.txt_anaform_yenisifre.TabIndex = 5;
            // 
            // txt_anaform_yenisifretekrar
            // 
            this.txt_anaform_yenisifretekrar.Location = new System.Drawing.Point(386, 339);
            this.txt_anaform_yenisifretekrar.Name = "txt_anaform_yenisifretekrar";
            this.txt_anaform_yenisifretekrar.Size = new System.Drawing.Size(203, 22);
            this.txt_anaform_yenisifretekrar.TabIndex = 5;
            // 
            // btn_anaformsifredegistir
            // 
            this.btn_anaformsifredegistir.Location = new System.Drawing.Point(246, 391);
            this.btn_anaformsifredegistir.Name = "btn_anaformsifredegistir";
            this.btn_anaformsifredegistir.Size = new System.Drawing.Size(343, 30);
            this.btn_anaformsifredegistir.TabIndex = 6;
            this.btn_anaformsifredegistir.Text = "Şifre Değiştir";
            this.btn_anaformsifredegistir.UseVisualStyleBackColor = true;
            this.btn_anaformsifredegistir.Click += new System.EventHandler(this.btn_anaformsifredegistir_Click);
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_anaformsifredegistir);
            this.Controls.Add(this.txt_anaform_yenisifretekrar);
            this.Controls.Add(this.txt_anaform_yenisifre);
            this.Controls.Add(this.txt_anaform_sifre);
            this.Controls.Add(this.txt_anaform_kullaniciadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Anaform";
            this.Text = "Anaform";
            this.Load += new System.EventHandler(this.Anaform_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_anaform_kullaniciadi;
        private System.Windows.Forms.TextBox txt_anaform_sifre;
        private System.Windows.Forms.TextBox txt_anaform_yenisifre;
        private System.Windows.Forms.TextBox txt_anaform_yenisifretekrar;
        private System.Windows.Forms.Button btn_anaformsifredegistir;
        private System.Windows.Forms.ListBox list_liste;
    }
}