namespace AlgoritmosPixeles
{
    partial class FrmLineas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPx1 = new System.Windows.Forms.TextBox();
            this.txtPy1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPy2 = new System.Windows.Forms.TextBox();
            this.txtPx2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDibujarD = new System.Windows.Forms.Button();
            this.grbControles = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBresenham = new System.Windows.Forms.Button();
            this.grbPoints = new System.Windows.Forms.GroupBox();
            this.tablePoints = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbControles.SuspendLayout();
            this.grbPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePoints)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.Control;
            this.picCanvas.Location = new System.Drawing.Point(292, 12);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(960, 532);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Punto inicial:";
            // 
            // txtPx1
            // 
            this.txtPx1.Location = new System.Drawing.Point(61, 79);
            this.txtPx1.Name = "txtPx1";
            this.txtPx1.Size = new System.Drawing.Size(100, 26);
            this.txtPx1.TabIndex = 2;
            // 
            // txtPy1
            // 
            this.txtPy1.Location = new System.Drawing.Point(61, 129);
            this.txtPy1.Name = "txtPy1";
            this.txtPy1.Size = new System.Drawing.Size(100, 26);
            this.txtPy1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "X:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "X:";
            // 
            // txtPy2
            // 
            this.txtPy2.Location = new System.Drawing.Point(61, 261);
            this.txtPy2.Name = "txtPy2";
            this.txtPy2.Size = new System.Drawing.Size(100, 26);
            this.txtPy2.TabIndex = 8;
            // 
            // txtPx2
            // 
            this.txtPx2.Location = new System.Drawing.Point(61, 215);
            this.txtPx2.Name = "txtPx2";
            this.txtPx2.Size = new System.Drawing.Size(100, 26);
            this.txtPx2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Punto final:";
            // 
            // btnDibujarD
            // 
            this.btnDibujarD.Location = new System.Drawing.Point(19, 38);
            this.btnDibujarD.Name = "btnDibujarD";
            this.btnDibujarD.Size = new System.Drawing.Size(187, 37);
            this.btnDibujarD.TabIndex = 11;
            this.btnDibujarD.Text = "Dibujar Discretas";
            this.btnDibujarD.UseVisualStyleBackColor = true;
            this.btnDibujarD.Click += new System.EventHandler(this.DiscreteLinePlot);
            // 
            // grbControles
            // 
            this.grbControles.Controls.Add(this.btnBorrar);
            this.grbControles.Controls.Add(this.btnBresenham);
            this.grbControles.Controls.Add(this.btnDibujarD);
            this.grbControles.Location = new System.Drawing.Point(32, 310);
            this.grbControles.Name = "grbControles";
            this.grbControles.Size = new System.Drawing.Size(233, 234);
            this.grbControles.TabIndex = 12;
            this.grbControles.TabStop = false;
            this.grbControles.Text = "Controles";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(24, 161);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(182, 37);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Limpiar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.reset);
            // 
            // btnBresenham
            // 
            this.btnBresenham.Location = new System.Drawing.Point(24, 99);
            this.btnBresenham.Name = "btnBresenham";
            this.btnBresenham.Size = new System.Drawing.Size(182, 37);
            this.btnBresenham.TabIndex = 12;
            this.btnBresenham.Text = "Dibujar Bresehnam";
            this.btnBresenham.UseVisualStyleBackColor = true;
            this.btnBresenham.Click += new System.EventHandler(this.BresenhamLinePlot);
            // 
            // grbPoints
            // 
            this.grbPoints.Controls.Add(this.tablePoints);
            this.grbPoints.Location = new System.Drawing.Point(1260, 14);
            this.grbPoints.Name = "grbPoints";
            this.grbPoints.Size = new System.Drawing.Size(405, 530);
            this.grbPoints.TabIndex = 13;
            this.grbPoints.TabStop = false;
            this.grbPoints.Text = "Pixeles";
            // 
            // tablePoints
            // 
            this.tablePoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePoints.Location = new System.Drawing.Point(6, 28);
            this.tablePoints.Name = "tablePoints";
            this.tablePoints.RowHeadersWidth = 12;
            this.tablePoints.RowTemplate.Height = 28;
            this.tablePoints.Size = new System.Drawing.Size(393, 496);
            this.tablePoints.TabIndex = 0;
            // 
            // FrmLineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1677, 554);
            this.Controls.Add(this.grbPoints);
            this.Controls.Add(this.grbControles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPy2);
            this.Controls.Add(this.txtPx2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPy1);
            this.Controls.Add(this.txtPx1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmLineas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLineas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbControles.ResumeLayout(false);
            this.grbPoints.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPx1;
        private System.Windows.Forms.TextBox txtPy1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPy2;
        private System.Windows.Forms.TextBox txtPx2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDibujarD;
        private System.Windows.Forms.GroupBox grbControles;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBresenham;
        private System.Windows.Forms.GroupBox grbPoints;
        private System.Windows.Forms.DataGridView tablePoints;
    }
}

