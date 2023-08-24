namespace CALCULADORA_HEDAMIS.Datos
{
    partial class UC_tasa_interes
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
            this.numericPeriodo = new System.Windows.Forms.NumericUpDown();
            this.labeltasa = new System.Windows.Forms.Label();
            this.comboPeriodo = new System.Windows.Forms.ComboBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.labelperiodo = new System.Windows.Forms.Label();
            this.tb_capital = new System.Windows.Forms.TextBox();
            this.labelcapialinicial = new System.Windows.Forms.Label();
            this.datos_simple = new System.Windows.Forms.Label();
            this.tb_cap_final = new System.Windows.Forms.TextBox();
            this.labelcapitalfinal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericPeriodo)).BeginInit();
            this.SuspendLayout();
            // 
            // numericPeriodo
            // 
            this.numericPeriodo.Location = new System.Drawing.Point(173, 98);
            this.numericPeriodo.Name = "numericPeriodo";
            this.numericPeriodo.Size = new System.Drawing.Size(93, 20);
            this.numericPeriodo.TabIndex = 23;
            // 
            // labeltasa
            // 
            this.labeltasa.AutoSize = true;
            this.labeltasa.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltasa.Location = new System.Drawing.Point(17, 238);
            this.labeltasa.Name = "labeltasa";
            this.labeltasa.Size = new System.Drawing.Size(127, 19);
            this.labeltasa.TabIndex = 21;
            this.labeltasa.Text = "Tasa de interés (%):";
            // 
            // comboPeriodo
            // 
            this.comboPeriodo.FormattingEnabled = true;
            this.comboPeriodo.Items.AddRange(new object[] {
            "dias",
            "meses",
            "años"});
            this.comboPeriodo.Location = new System.Drawing.Point(272, 97);
            this.comboPeriodo.Name = "comboPeriodo";
            this.comboPeriodo.Size = new System.Drawing.Size(93, 21);
            this.comboPeriodo.TabIndex = 20;
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncalcular.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(21, 178);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(344, 36);
            this.btncalcular.TabIndex = 19;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            // 
            // labelperiodo
            // 
            this.labelperiodo.AutoSize = true;
            this.labelperiodo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelperiodo.Location = new System.Drawing.Point(18, 99);
            this.labelperiodo.Name = "labelperiodo";
            this.labelperiodo.Size = new System.Drawing.Size(59, 19);
            this.labelperiodo.TabIndex = 18;
            this.labelperiodo.Text = "Periodo:";
            // 
            // tb_capital
            // 
            this.tb_capital.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_capital.Location = new System.Drawing.Point(172, 50);
            this.tb_capital.Name = "tb_capital";
            this.tb_capital.Size = new System.Drawing.Size(193, 25);
            this.tb_capital.TabIndex = 15;
            // 
            // labelcapialinicial
            // 
            this.labelcapialinicial.AutoSize = true;
            this.labelcapialinicial.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcapialinicial.Location = new System.Drawing.Point(17, 56);
            this.labelcapialinicial.Name = "labelcapialinicial";
            this.labelcapialinicial.Size = new System.Drawing.Size(92, 19);
            this.labelcapialinicial.TabIndex = 14;
            this.labelcapialinicial.Text = "Capital inicial:";
            // 
            // datos_simple
            // 
            this.datos_simple.AutoSize = true;
            this.datos_simple.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datos_simple.Location = new System.Drawing.Point(16, 10);
            this.datos_simple.Name = "datos_simple";
            this.datos_simple.Size = new System.Drawing.Size(297, 28);
            this.datos_simple.TabIndex = 13;
            this.datos_simple.Text = "Calcular tasa de interes (%)";
            // 
            // tb_cap_final
            // 
            this.tb_cap_final.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cap_final.Location = new System.Drawing.Point(173, 138);
            this.tb_cap_final.Name = "tb_cap_final";
            this.tb_cap_final.Size = new System.Drawing.Size(193, 25);
            this.tb_cap_final.TabIndex = 25;
            // 
            // labelcapitalfinal
            // 
            this.labelcapitalfinal.AutoSize = true;
            this.labelcapitalfinal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcapitalfinal.Location = new System.Drawing.Point(18, 144);
            this.labelcapitalfinal.Name = "labelcapitalfinal";
            this.labelcapitalfinal.Size = new System.Drawing.Size(84, 19);
            this.labelcapitalfinal.TabIndex = 24;
            this.labelcapitalfinal.Text = "Capital final:";
            // 
            // UC_tasa_interes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_cap_final);
            this.Controls.Add(this.labelcapitalfinal);
            this.Controls.Add(this.numericPeriodo);
            this.Controls.Add(this.labeltasa);
            this.Controls.Add(this.comboPeriodo);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.labelperiodo);
            this.Controls.Add(this.tb_capital);
            this.Controls.Add(this.labelcapialinicial);
            this.Controls.Add(this.datos_simple);
            this.Name = "UC_tasa_interes";
            this.Size = new System.Drawing.Size(734, 424);
            ((System.ComponentModel.ISupportInitialize)(this.numericPeriodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericPeriodo;
        private System.Windows.Forms.Label labeltasa;
        private System.Windows.Forms.ComboBox comboPeriodo;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label labelperiodo;
        private System.Windows.Forms.TextBox tb_capital;
        private System.Windows.Forms.Label labelcapialinicial;
        private System.Windows.Forms.Label datos_simple;
        private System.Windows.Forms.TextBox tb_cap_final;
        private System.Windows.Forms.Label labelcapitalfinal;
    }
}
