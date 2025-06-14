namespace AlgoritmosPixeles
{
    partial class FrmHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuLineas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCircunferencia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelleno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLineas,
            this.menuCircunferencia,
            this.menuRelleno});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuLineas
            // 
            this.menuLineas.Name = "menuLineas";
            this.menuLineas.Size = new System.Drawing.Size(76, 29);
            this.menuLineas.Text = "Líneas";
            this.menuLineas.Click += new System.EventHandler(this.menuLineas_Click);
            // 
            // menuCircunferencia
            // 
            this.menuCircunferencia.Name = "menuCircunferencia";
            this.menuCircunferencia.Size = new System.Drawing.Size(138, 29);
            this.menuCircunferencia.Text = "Circunferencia";
            this.menuCircunferencia.Click += new System.EventHandler(this.menuCircunferencia_Click);
            // 
            // menuRelleno
            // 
            this.menuRelleno.Name = "menuRelleno";
            this.menuRelleno.Size = new System.Drawing.Size(85, 29);
            this.menuRelleno.Text = "Relleno";
            this.menuRelleno.Click += new System.EventHandler(this.menuRelleno_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuLineas;
        private System.Windows.Forms.ToolStripMenuItem menuCircunferencia;
        private System.Windows.Forms.ToolStripMenuItem menuRelleno;
    }
}