namespace Paintology
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBox = new System.Windows.Forms.PictureBox();
            this.saveAsBox = new System.Windows.Forms.PictureBox();
            this.saveBox = new System.Windows.Forms.PictureBox();
            this.openFolder = new System.Windows.Forms.PictureBox();
            this.newBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorPin = new System.Windows.Forms.PictureBox();
            this.colorClose = new System.Windows.Forms.PictureBox();
            this.pinBox = new System.Windows.Forms.PictureBox();
            this.closeTool = new System.Windows.Forms.PictureBox();
            this.rightArrowBox = new System.Windows.Forms.PictureBox();
            this.leftArrowBox = new System.Windows.Forms.PictureBox();
            this.triangleBox = new System.Windows.Forms.PictureBox();
            this.ellipseBox = new System.Windows.Forms.PictureBox();
            this.rectangleBox = new System.Windows.Forms.PictureBox();
            this.lineBox = new System.Windows.Forms.PictureBox();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.colorPicker = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveAsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBox)).BeginInit();
            this.toolPanel.SuspendLayout();
            this.colorPicker.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.closeBox);
            this.panel1.Controls.Add(this.saveAsBox);
            this.panel1.Controls.Add(this.saveBox);
            this.panel1.Controls.Add(this.openFolder);
            this.panel1.Controls.Add(this.newBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 40);
            this.panel1.TabIndex = 1;
            // 
            // closeBox
            // 
            this.closeBox.BackColor = System.Drawing.Color.Transparent;
            this.closeBox.Image = global::Paintology.Properties.Resources.close_leave;
            this.closeBox.Location = new System.Drawing.Point(725, 4);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(30, 30);
            this.closeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBox.TabIndex = 4;
            this.closeBox.TabStop = false;
            this.toolTip1.SetToolTip(this.closeBox, "Kapat");
            this.closeBox.WaitOnLoad = true;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            this.closeBox.MouseLeave += new System.EventHandler(this.closeBox_MouseLeave);
            this.closeBox.MouseHover += new System.EventHandler(this.closeBox_MouseHover);
            // 
            // saveAsBox
            // 
            this.saveAsBox.BackColor = System.Drawing.Color.Transparent;
            this.saveAsBox.Image = global::Paintology.Properties.Resources.save_as;
            this.saveAsBox.Location = new System.Drawing.Point(123, 4);
            this.saveAsBox.Name = "saveAsBox";
            this.saveAsBox.Size = new System.Drawing.Size(32, 32);
            this.saveAsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saveAsBox.TabIndex = 3;
            this.saveAsBox.TabStop = false;
            this.toolTip1.SetToolTip(this.saveAsBox, "Farklı kaydet");
            this.saveAsBox.WaitOnLoad = true;
            // 
            // saveBox
            // 
            this.saveBox.BackColor = System.Drawing.Color.Transparent;
            this.saveBox.Image = global::Paintology.Properties.Resources.save;
            this.saveBox.Location = new System.Drawing.Point(85, 4);
            this.saveBox.Name = "saveBox";
            this.saveBox.Size = new System.Drawing.Size(32, 32);
            this.saveBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saveBox.TabIndex = 2;
            this.saveBox.TabStop = false;
            this.toolTip1.SetToolTip(this.saveBox, "Kaydet");
            this.saveBox.WaitOnLoad = true;
            // 
            // openFolder
            // 
            this.openFolder.BackColor = System.Drawing.Color.Transparent;
            this.openFolder.Image = ((System.Drawing.Image)(resources.GetObject("openFolder.Image")));
            this.openFolder.Location = new System.Drawing.Point(47, 4);
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(32, 32);
            this.openFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.openFolder.TabIndex = 1;
            this.openFolder.TabStop = false;
            this.toolTip1.SetToolTip(this.openFolder, "Open file");
            this.openFolder.WaitOnLoad = true;
            this.openFolder.Click += new System.EventHandler(this.openFolder_Click);
            // 
            // newBox
            // 
            this.newBox.BackColor = System.Drawing.Color.Transparent;
            this.newBox.Image = global::Paintology.Properties.Resources.new_page;
            this.newBox.Location = new System.Drawing.Point(9, 4);
            this.newBox.Name = "newBox";
            this.newBox.Size = new System.Drawing.Size(32, 32);
            this.newBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newBox.TabIndex = 0;
            this.newBox.TabStop = false;
            this.toolTip1.SetToolTip(this.newBox, "Yeni");
            this.newBox.WaitOnLoad = true;
            // 
            // colorPin
            // 
            this.colorPin.BackColor = System.Drawing.Color.Transparent;
            this.colorPin.Image = global::Paintology.Properties.Resources.push_pin;
            this.colorPin.Location = new System.Drawing.Point(189, 0);
            this.colorPin.Name = "colorPin";
            this.colorPin.Size = new System.Drawing.Size(20, 20);
            this.colorPin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorPin.TabIndex = 10;
            this.colorPin.TabStop = false;
            this.toolTip1.SetToolTip(this.colorPin, "Color Pin");
            this.colorPin.WaitOnLoad = true;
            this.colorPin.Click += new System.EventHandler(this.colorPin_Click);
            this.colorPin.MouseLeave += new System.EventHandler(this.colorPin_MouseLeave);
            this.colorPin.MouseHover += new System.EventHandler(this.colorPin_MouseHover);
            // 
            // colorClose
            // 
            this.colorClose.BackColor = System.Drawing.Color.Transparent;
            this.colorClose.Image = global::Paintology.Properties.Resources.close_leave;
            this.colorClose.Location = new System.Drawing.Point(209, 0);
            this.colorClose.Name = "colorClose";
            this.colorClose.Size = new System.Drawing.Size(20, 20);
            this.colorClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorClose.TabIndex = 10;
            this.colorClose.TabStop = false;
            this.toolTip1.SetToolTip(this.colorClose, "ColorPicker kapat");
            this.colorClose.WaitOnLoad = true;
            this.colorClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pinBox
            // 
            this.pinBox.BackColor = System.Drawing.Color.Transparent;
            this.pinBox.Image = global::Paintology.Properties.Resources.push_pin;
            this.pinBox.Location = new System.Drawing.Point(18, 0);
            this.pinBox.Name = "pinBox";
            this.pinBox.Size = new System.Drawing.Size(20, 20);
            this.pinBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pinBox.TabIndex = 9;
            this.pinBox.TabStop = false;
            this.toolTip1.SetToolTip(this.pinBox, "Pin");
            this.pinBox.WaitOnLoad = true;
            this.pinBox.Click += new System.EventHandler(this.pinBox_Click);
            this.pinBox.MouseLeave += new System.EventHandler(this.pinBox_MouseLeave);
            this.pinBox.MouseHover += new System.EventHandler(this.pinBox_MouseHover);
            // 
            // closeTool
            // 
            this.closeTool.BackColor = System.Drawing.Color.Transparent;
            this.closeTool.Image = global::Paintology.Properties.Resources.close_leave;
            this.closeTool.Location = new System.Drawing.Point(38, 0);
            this.closeTool.Name = "closeTool";
            this.closeTool.Size = new System.Drawing.Size(20, 20);
            this.closeTool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeTool.TabIndex = 5;
            this.closeTool.TabStop = false;
            this.toolTip1.SetToolTip(this.closeTool, "Toolbox kapat");
            this.closeTool.WaitOnLoad = true;
            this.closeTool.Click += new System.EventHandler(this.closeTool_Click);
            // 
            // rightArrowBox
            // 
            this.rightArrowBox.Image = global::Paintology.Properties.Resources.right_arrow;
            this.rightArrowBox.Location = new System.Drawing.Point(14, 222);
            this.rightArrowBox.Name = "rightArrowBox";
            this.rightArrowBox.Size = new System.Drawing.Size(32, 32);
            this.rightArrowBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rightArrowBox.TabIndex = 8;
            this.rightArrowBox.TabStop = false;
            this.toolTip1.SetToolTip(this.rightArrowBox, "Sağ ok");
            // 
            // leftArrowBox
            // 
            this.leftArrowBox.Image = global::Paintology.Properties.Resources.left_arrow;
            this.leftArrowBox.Location = new System.Drawing.Point(14, 184);
            this.leftArrowBox.Name = "leftArrowBox";
            this.leftArrowBox.Size = new System.Drawing.Size(32, 32);
            this.leftArrowBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftArrowBox.TabIndex = 7;
            this.leftArrowBox.TabStop = false;
            this.toolTip1.SetToolTip(this.leftArrowBox, "Sol ok");
            // 
            // triangleBox
            // 
            this.triangleBox.Image = global::Paintology.Properties.Resources.triangle;
            this.triangleBox.Location = new System.Drawing.Point(14, 146);
            this.triangleBox.Name = "triangleBox";
            this.triangleBox.Size = new System.Drawing.Size(32, 32);
            this.triangleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.triangleBox.TabIndex = 6;
            this.triangleBox.TabStop = false;
            this.toolTip1.SetToolTip(this.triangleBox, "Üçgen");
            // 
            // ellipseBox
            // 
            this.ellipseBox.Image = global::Paintology.Properties.Resources.oval;
            this.ellipseBox.Location = new System.Drawing.Point(14, 108);
            this.ellipseBox.Name = "ellipseBox";
            this.ellipseBox.Size = new System.Drawing.Size(32, 32);
            this.ellipseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ellipseBox.TabIndex = 5;
            this.ellipseBox.TabStop = false;
            this.toolTip1.SetToolTip(this.ellipseBox, "Elips");
            // 
            // rectangleBox
            // 
            this.rectangleBox.Image = global::Paintology.Properties.Resources.rectangle;
            this.rectangleBox.Location = new System.Drawing.Point(14, 70);
            this.rectangleBox.Name = "rectangleBox";
            this.rectangleBox.Size = new System.Drawing.Size(32, 32);
            this.rectangleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rectangleBox.TabIndex = 4;
            this.rectangleBox.TabStop = false;
            this.toolTip1.SetToolTip(this.rectangleBox, "Dikdörtgen");
            // 
            // lineBox
            // 
            this.lineBox.Image = global::Paintology.Properties.Resources.line;
            this.lineBox.Location = new System.Drawing.Point(14, 32);
            this.lineBox.Name = "lineBox";
            this.lineBox.Size = new System.Drawing.Size(32, 32);
            this.lineBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lineBox.TabIndex = 3;
            this.lineBox.TabStop = false;
            this.toolTip1.SetToolTip(this.lineBox, "Çizgi");
            // 
            // toolPanel
            // 
            this.toolPanel.BackColor = System.Drawing.Color.Gray;
            this.toolPanel.Controls.Add(this.pinBox);
            this.toolPanel.Controls.Add(this.closeTool);
            this.toolPanel.Controls.Add(this.rightArrowBox);
            this.toolPanel.Controls.Add(this.leftArrowBox);
            this.toolPanel.Controls.Add(this.triangleBox);
            this.toolPanel.Controls.Add(this.ellipseBox);
            this.toolPanel.Controls.Add(this.rectangleBox);
            this.toolPanel.Controls.Add(this.lineBox);
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolPanel.Location = new System.Drawing.Point(0, 40);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(58, 454);
            this.toolPanel.TabIndex = 2;
            this.toolPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolPanel_MouseDown);
            this.toolPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolPanel_MouseMove);
            // 
            // colorPicker
            // 
            this.colorPicker.BackColor = System.Drawing.Color.Gray;
            this.colorPicker.Controls.Add(this.colorPin);
            this.colorPicker.Controls.Add(this.colorClose);
            this.colorPicker.Location = new System.Drawing.Point(59, 280);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(229, 214);
            this.colorPicker.TabIndex = 3;
            this.colorPicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.colorPicker_MouseDown);
            this.colorPicker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.colorPicker_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 494);
            this.Controls.Add(this.colorPicker);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveAsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBox)).EndInit();
            this.toolPanel.ResumeLayout(false);
            this.toolPanel.PerformLayout();
            this.colorPicker.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox newBox;
        private System.Windows.Forms.PictureBox openFolder;
        private System.Windows.Forms.PictureBox saveAsBox;
        private System.Windows.Forms.PictureBox saveBox;
        private System.Windows.Forms.PictureBox closeBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.PictureBox lineBox;
        private System.Windows.Forms.PictureBox leftArrowBox;
        private System.Windows.Forms.PictureBox triangleBox;
        private System.Windows.Forms.PictureBox ellipseBox;
        private System.Windows.Forms.PictureBox rectangleBox;
        private System.Windows.Forms.PictureBox rightArrowBox;
        private System.Windows.Forms.PictureBox closeTool;
        private System.Windows.Forms.PictureBox pinBox;
        private System.Windows.Forms.Panel colorPicker;
        private System.Windows.Forms.PictureBox colorClose;
        private System.Windows.Forms.PictureBox colorPin;
    }
}

