namespace SimpleProcessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.formName = new System.Windows.Forms.Label();
            this.infoLabel1 = new System.Windows.Forms.Label();
            this.processorTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.extaddressTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hwidTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.macTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpunameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mainboardTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.formName);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 36);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.formName.ForeColor = System.Drawing.Color.White;
            this.formName.Location = new System.Drawing.Point(10, 9);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(149, 18);
            this.formName.TabIndex = 3;
            this.formName.Text = "SystemInformation";
            // 
            // infoLabel1
            // 
            this.infoLabel1.AutoSize = true;
            this.infoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.infoLabel1.Location = new System.Drawing.Point(11, 27);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(117, 24);
            this.infoLabel1.TabIndex = 1;
            this.infoLabel1.Text = "Processor ID";
            // 
            // processorTxt
            // 
            this.processorTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.processorTxt.Location = new System.Drawing.Point(12, 59);
            this.processorTxt.Name = "processorTxt";
            this.processorTxt.ReadOnly = true;
            this.processorTxt.Size = new System.Drawing.Size(143, 23);
            this.processorTxt.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.extaddressTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.hwidTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.macTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.gpunameTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mainboardTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.processorTxt);
            this.groupBox1.Controls.Add(this.infoLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(8, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 231);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // extaddressTxt
            // 
            this.extaddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.extaddressTxt.Location = new System.Drawing.Point(219, 196);
            this.extaddressTxt.Name = "extaddressTxt";
            this.extaddressTxt.ReadOnly = true;
            this.extaddressTxt.Size = new System.Drawing.Size(183, 23);
            this.extaddressTxt.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(10, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "External IP Address >>";
            // 
            // hwidTxt
            // 
            this.hwidTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hwidTxt.Location = new System.Drawing.Point(191, 158);
            this.hwidTxt.Name = "hwidTxt";
            this.hwidTxt.ReadOnly = true;
            this.hwidTxt.Size = new System.Drawing.Size(397, 23);
            this.hwidTxt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(187, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hardware ID";
            // 
            // macTxt
            // 
            this.macTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.macTxt.Location = new System.Drawing.Point(14, 158);
            this.macTxt.Name = "macTxt";
            this.macTxt.ReadOnly = true;
            this.macTxt.Size = new System.Drawing.Size(163, 23);
            this.macTxt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(11, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "MAC Address";
            // 
            // gpunameTxt
            // 
            this.gpunameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gpunameTxt.Location = new System.Drawing.Point(394, 59);
            this.gpunameTxt.Name = "gpunameTxt";
            this.gpunameTxt.ReadOnly = true;
            this.gpunameTxt.Size = new System.Drawing.Size(194, 23);
            this.gpunameTxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(390, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "GPU Name";
            // 
            // mainboardTxt
            // 
            this.mainboardTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mainboardTxt.Location = new System.Drawing.Point(191, 59);
            this.mainboardTxt.Name = "mainboardTxt";
            this.mainboardTxt.ReadOnly = true;
            this.mainboardTxt.Size = new System.Drawing.Size(181, 23);
            this.mainboardTxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(187, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mainboard Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SimpleProcessor.Properties.Resources.WhatsApp_Image_2018_02_09_at_23_06_49;
            this.pictureBox2.Location = new System.Drawing.Point(552, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.minimize);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(581, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 24);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.close);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeLeave);
            this.closeButton.MouseHover += new System.EventHandler(this.closeHover);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(611, 284);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Label infoLabel1;
        private System.Windows.Forms.TextBox processorTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mainboardTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gpunameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hwidTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox macTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox extaddressTxt;
        private System.Windows.Forms.Label label5;
    }
}