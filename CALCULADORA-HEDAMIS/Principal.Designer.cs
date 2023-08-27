namespace CALCULADORA_HEDAMIS
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.opciones = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuinteressimple = new System.Windows.Forms.ToolStripMenuItem();
            this.interesTotalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeInteresesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitalInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitalFinalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuinterescompuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.opciones.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // opciones
            // 
            this.opciones.BackColor = System.Drawing.SystemColors.MenuBar;
            this.opciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.menuinteressimple,
            this.menuinterescompuesto});
            this.opciones.Location = new System.Drawing.Point(0, 0);
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(734, 24);
            this.opciones.TabIndex = 0;
            this.opciones.Text = "menu";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // menuinteressimple
            // 
            this.menuinteressimple.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interesTotalesToolStripMenuItem,
            this.tipoDeInteresesToolStripMenuItem,
            this.capitalInicialToolStripMenuItem,
            this.capitalFinalToolStripMenuItem});
            this.menuinteressimple.Name = "menuinteressimple";
            this.menuinteressimple.Size = new System.Drawing.Size(93, 20);
            this.menuinteressimple.Text = "Interés Simple";
            this.menuinteressimple.Click += new System.EventHandler(this.menuinteressimple_Click);
            // 
            // interesTotalesToolStripMenuItem
            // 
            this.interesTotalesToolStripMenuItem.Name = "interesTotalesToolStripMenuItem";
            this.interesTotalesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.interesTotalesToolStripMenuItem.Text = "Intereses totales";
            this.interesTotalesToolStripMenuItem.Click += new System.EventHandler(this.interesTotalesToolStripMenuItem_Click);
            // 
            // tipoDeInteresesToolStripMenuItem
            // 
            this.tipoDeInteresesToolStripMenuItem.Name = "tipoDeInteresesToolStripMenuItem";
            this.tipoDeInteresesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tipoDeInteresesToolStripMenuItem.Text = "Tasa de interés";
            this.tipoDeInteresesToolStripMenuItem.Click += new System.EventHandler(this.tipoDeInteresesToolStripMenuItem_Click);
            // 
            // capitalInicialToolStripMenuItem
            // 
            this.capitalInicialToolStripMenuItem.Name = "capitalInicialToolStripMenuItem";
            this.capitalInicialToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.capitalInicialToolStripMenuItem.Text = "Capital inicial";
            this.capitalInicialToolStripMenuItem.Click += new System.EventHandler(this.capitalInicialToolStripMenuItem_Click);
            // 
            // capitalFinalToolStripMenuItem
            // 
            this.capitalFinalToolStripMenuItem.Name = "capitalFinalToolStripMenuItem";
            this.capitalFinalToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.capitalFinalToolStripMenuItem.Text = "Capital final";
            this.capitalFinalToolStripMenuItem.Click += new System.EventHandler(this.capitalFinalToolStripMenuItem_Click);
            // 
            // menuinterescompuesto
            // 
            this.menuinterescompuesto.Name = "menuinterescompuesto";
            this.menuinterescompuesto.Size = new System.Drawing.Size(119, 20);
            this.menuinterescompuesto.Text = "Interés Compuesto";
            this.menuinterescompuesto.Click += new System.EventHandler(this.menuinterescompuesto_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel.Controls.Add(this.logo);
            this.panel.Location = new System.Drawing.Point(0, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(734, 424);
            this.panel.TabIndex = 1;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // logo
            // 
            this.logo.Image = global::CALCULADORA_HEDAMIS.Properties.Resources.logo;
            this.logo.InitialImage = null;
            this.logo.Location = new System.Drawing.Point(374, 80);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(264, 280);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.opciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.opciones;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de interés simple y compuesto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.opciones.ResumeLayout(false);
            this.opciones.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip opciones;
        private System.Windows.Forms.ToolStripMenuItem menuinteressimple;
        private System.Windows.Forms.ToolStripMenuItem menuinterescompuesto;
        private System.Windows.Forms.ToolStripMenuItem interesTotalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeInteresesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capitalInicialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capitalFinalToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.PictureBox logo;
    }
}

