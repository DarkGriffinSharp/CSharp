namespace Kutuphane
{
    partial class FormYazarEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYazarEkle));
            this._txtYazarSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtYazarAd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._btnYazarTemizle = new System.Windows.Forms.Button();
            this._btnYazarEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _txtYazarSoyad
            // 
            this._txtYazarSoyad.Location = new System.Drawing.Point(97, 57);
            this._txtYazarSoyad.Name = "_txtYazarSoyad";
            this._txtYazarSoyad.Size = new System.Drawing.Size(119, 20);
            this._txtYazarSoyad.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yazar Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazar soyad";
            // 
            // _txtYazarAd
            // 
            this._txtYazarAd.Location = new System.Drawing.Point(97, 23);
            this._txtYazarAd.Name = "_txtYazarAd";
            this._txtYazarAd.Size = new System.Drawing.Size(119, 20);
            this._txtYazarAd.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._txtYazarSoyad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._txtYazarAd);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 101);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yazar Bilgileri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._btnYazarTemizle);
            this.groupBox3.Controls.Add(this._btnYazarEkle);
            this.groupBox3.Location = new System.Drawing.Point(12, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 69);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // _btnYazarTemizle
            // 
            this._btnYazarTemizle.Image = global::Kutuphane.Properties.Resources.delete;
            this._btnYazarTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnYazarTemizle.Location = new System.Drawing.Point(6, 19);
            this._btnYazarTemizle.Name = "_btnYazarTemizle";
            this._btnYazarTemizle.Size = new System.Drawing.Size(113, 40);
            this._btnYazarTemizle.TabIndex = 1;
            this._btnYazarTemizle.Text = "Temizle";
            this._btnYazarTemizle.UseVisualStyleBackColor = true;
            // 
            // _btnYazarEkle
            // 
            this._btnYazarEkle.Image = global::Kutuphane.Properties.Resources.add;
            this._btnYazarEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnYazarEkle.Location = new System.Drawing.Point(125, 19);
            this._btnYazarEkle.Name = "_btnYazarEkle";
            this._btnYazarEkle.Size = new System.Drawing.Size(127, 40);
            this._btnYazarEkle.TabIndex = 0;
            this._btnYazarEkle.Text = "Kaydet";
            this._btnYazarEkle.UseVisualStyleBackColor = true;
            this._btnYazarEkle.Click += new System.EventHandler(this._btnYazarEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Image = global::Kutuphane.Properties.Resources.users;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 13, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "     Yazar Ekle";
            // 
            // FormYazarEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 249);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormYazarEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yazar Ekle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox _txtYazarSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtYazarAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _btnYazarTemizle;
        private System.Windows.Forms.Button _btnYazarEkle;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}