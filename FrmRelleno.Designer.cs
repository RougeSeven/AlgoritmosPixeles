﻿namespace AlgoritmosPixeles
{
    partial class FrmRelleno
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grbControl = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcbSpeed = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.Control;
            this.picCanvas.Location = new System.Drawing.Point(349, 12);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(859, 609);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.picCanvas_Click);
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.Location = new System.Drawing.Point(72, 25);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(186, 54);
            this.btnDrawLine.TabIndex = 1;
            this.btnDrawLine.Text = "Dibujar Lineas";
            this.btnDrawLine.UseVisualStyleBackColor = true;
            this.btnDrawLine.Click += new System.EventHandler(this.btnDrawLine_Click);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(72, 95);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(186, 45);
            this.btnFill.TabIndex = 2;
            this.btnFill.Text = "Rellenar";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(72, 157);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(186, 49);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // grbControl
            // 
            this.grbControl.Controls.Add(this.btnDrawLine);
            this.grbControl.Controls.Add(this.btnClear);
            this.grbControl.Controls.Add(this.btnFill);
            this.grbControl.Location = new System.Drawing.Point(12, 12);
            this.grbControl.Name = "grbControl";
            this.grbControl.Size = new System.Drawing.Size(331, 233);
            this.grbControl.TabIndex = 4;
            this.grbControl.TabStop = false;
            this.grbControl.Text = "Control";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tcbSpeed);
            this.groupBox1.Location = new System.Drawing.Point(12, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 84);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Velocidad de la animacion";
            // 
            // tcbSpeed
            // 
            this.tcbSpeed.LargeChange = 1;
            this.tcbSpeed.Location = new System.Drawing.Point(16, 25);
            this.tcbSpeed.Name = "tcbSpeed";
            this.tcbSpeed.Size = new System.Drawing.Size(296, 69);
            this.tcbSpeed.TabIndex = 0;
            // 
            // FrmRelleno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1220, 633);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbControl);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmRelleno";
            this.Text = "FrmRelleno";
            this.Load += new System.EventHandler(this.FrmRelleno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbControl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcbSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnDrawLine;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grbControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar tcbSpeed;
    }
}