﻿namespace CALCULADORA_HEDAMIS.Datos
{
    partial class UC_interes_compuesto
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.datos_compuesto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datos_compuesto
            // 
            this.datos_compuesto.AutoSize = true;
            this.datos_compuesto.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datos_compuesto.Location = new System.Drawing.Point(257, 174);
            this.datos_compuesto.Name = "datos_compuesto";
            this.datos_compuesto.Size = new System.Drawing.Size(213, 28);
            this.datos_compuesto.TabIndex = 1;
            this.datos_compuesto.Text = "Interes Compuesto";
            // 
            // UC_interes_compuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datos_compuesto);
            this.Name = "UC_interes_compuesto";
            this.Size = new System.Drawing.Size(734, 424);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label datos_compuesto;
    }
}
