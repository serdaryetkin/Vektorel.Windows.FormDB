namespace Vektorel.Windows.FormDB
{
    partial class Form2
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
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblDtar = new System.Windows.Forms.Label();
            this.lblOlumTarih = new System.Windows.Forms.Label();
            this.lblYazarBilgi = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dtOlumTar = new System.Windows.Forms.DateTimePicker();
            this.dtDogumTar = new System.Windows.Forms.DateTimePicker();
            this.chYasiyor = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(249, 65);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(52, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Yazar Adı";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(249, 95);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(69, 13);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Yazar Soyadı";
            // 
            // lblDtar
            // 
            this.lblDtar.AutoSize = true;
            this.lblDtar.Location = new System.Drawing.Point(249, 128);
            this.lblDtar.Name = "lblDtar";
            this.lblDtar.Size = new System.Drawing.Size(70, 13);
            this.lblDtar.TabIndex = 2;
            this.lblDtar.Text = "Doğum Tarihi";
            // 
            // lblOlumTarih
            // 
            this.lblOlumTarih.AutoSize = true;
            this.lblOlumTarih.Location = new System.Drawing.Point(249, 161);
            this.lblOlumTarih.Name = "lblOlumTarih";
            this.lblOlumTarih.Size = new System.Drawing.Size(60, 13);
            this.lblOlumTarih.TabIndex = 3;
            this.lblOlumTarih.Text = "Ölüm Tarihi";
            // 
            // lblYazarBilgi
            // 
            this.lblYazarBilgi.AutoSize = true;
            this.lblYazarBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazarBilgi.Location = new System.Drawing.Point(329, 23);
            this.lblYazarBilgi.Name = "lblYazarBilgi";
            this.lblYazarBilgi.Size = new System.Drawing.Size(111, 18);
            this.lblYazarBilgi.TabIndex = 4;
            this.lblYazarBilgi.Text = "Yazar Bilgileri";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(332, 62);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(332, 92);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(332, 185);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Yazar Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // dtOlumTar
            // 
            this.dtOlumTar.Location = new System.Drawing.Point(332, 155);
            this.dtOlumTar.Name = "dtOlumTar";
            this.dtOlumTar.Size = new System.Drawing.Size(200, 20);
            this.dtOlumTar.TabIndex = 10;
            // 
            // dtDogumTar
            // 
            this.dtDogumTar.Location = new System.Drawing.Point(332, 122);
            this.dtDogumTar.Name = "dtDogumTar";
            this.dtDogumTar.Size = new System.Drawing.Size(200, 20);
            this.dtDogumTar.TabIndex = 11;
            // 
            // chYasiyor
            // 
            this.chYasiyor.AutoSize = true;
            this.chYasiyor.Location = new System.Drawing.Point(553, 158);
            this.chYasiyor.Name = "chYasiyor";
            this.chYasiyor.Size = new System.Drawing.Size(60, 17);
            this.chYasiyor.TabIndex = 12;
            this.chYasiyor.Text = "Yaşıyor";
            this.chYasiyor.UseVisualStyleBackColor = true;
            this.chYasiyor.CheckedChanged += new System.EventHandler(this.ChYasiyor_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chYasiyor);
            this.Controls.Add(this.dtDogumTar);
            this.Controls.Add(this.dtOlumTar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblYazarBilgi);
            this.Controls.Add(this.lblOlumTarih);
            this.Controls.Add(this.lblDtar);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblDtar;
        private System.Windows.Forms.Label lblOlumTarih;
        private System.Windows.Forms.Label lblYazarBilgi;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DateTimePicker dtOlumTar;
        private System.Windows.Forms.DateTimePicker dtDogumTar;
        private System.Windows.Forms.CheckBox chYasiyor;
    }
}