namespace CALCULADORA_HEDAMIS.Datos
{
    partial class UC_capital_final
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
            this.labelcapfinal = new System.Windows.Forms.Label();
            this.comboPeriodo = new System.Windows.Forms.ComboBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.labelperiodo = new System.Windows.Forms.Label();
            this.tb_tasa_interes = new System.Windows.Forms.TextBox();
            this.labeltasainteres = new System.Windows.Forms.Label();
            this.tb_capital = new System.Windows.Forms.TextBox();
            this.labelcapialinicial = new System.Windows.Forms.Label();
            this.datos_simple = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericPeriodo)).BeginInit();
            this.SuspendLayout();
            // 
            // numericPeriodo
            // 
            this.numericPeriodo.Location = new System.Drawing.Point(173, 144);
            this.numericPeriodo.Name = "numericPeriodo";
            this.numericPeriodo.Size = new System.Drawing.Size(93, 20);
            this.numericPeriodo.TabIndex = 23;
            // 
            // labelcapfinal
            // 
            this.labelcapfinal.AutoSize = true;
            this.labelcapfinal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcapfinal.Location = new System.Drawing.Point(18, 242);
            this.labelcapfinal.Name = "labelcapfinal";
            this.labelcapfinal.Size = new System.Drawing.Size(84, 19);
            this.labelcapfinal.TabIndex = 21;
            this.labelcapfinal.Text = "Capital final:";
            // 
            // comboPeriodo
            // 
            this.comboPeriodo.FormattingEnabled = true;
            this.comboPeriodo.Items.AddRange(new object[] {
            "dias",
            "meses",
            "años"});
            this.comboPeriodo.Location = new System.Drawing.Point(272, 143);
            this.comboPeriodo.Name = "comboPeriodo";
            this.comboPeriodo.Size = new System.Drawing.Size(93, 21);
            this.comboPeriodo.TabIndex = 20;
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncalcular.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(22, 182);
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
            this.labelperiodo.Location = new System.Drawing.Point(18, 145);
            this.labelperiodo.Name = "labelperiodo";
            this.labelperiodo.Size = new System.Drawing.Size(59, 19);
            this.labelperiodo.TabIndex = 18;
            this.labelperiodo.Text = "Periodo:";
            // 
            // tb_tasa_interes
            // 
            this.tb_tasa_interes.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tasa_interes.Location = new System.Drawing.Point(173, 97);
            this.tb_tasa_interes.Name = "tb_tasa_interes";
            this.tb_tasa_interes.Size = new System.Drawing.Size(193, 25);
            this.tb_tasa_interes.TabIndex = 17;
            // 
            // labeltasainteres
            // 
            this.labeltasainteres.AutoSize = true;
            this.labeltasainteres.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltasainteres.Location = new System.Drawing.Point(18, 103);
            this.labeltasainteres.Name = "labeltasainteres";
            this.labeltasainteres.Size = new System.Drawing.Size(127, 19);
            this.labeltasainteres.TabIndex = 16;
            this.labeltasainteres.Text = "Tasa de interés (%):";
            // 
            // tb_capital
            // 
            this.tb_capital.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_capital.Location = new System.Drawing.Point(173, 54);
            this.tb_capital.Name = "tb_capital";
            this.tb_capital.Size = new System.Drawing.Size(193, 25);
            this.tb_capital.TabIndex = 15;
            // 
            // labelcapialinicial
            // 
            this.labelcapialinicial.AutoSize = true;
            this.labelcapialinicial.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcapialinicial.Location = new System.Drawing.Point(18, 60);
            this.labelcapialinicial.Name = "labelcapialinicial";
            this.labelcapialinicial.Size = new System.Drawing.Size(92, 19);
            this.labelcapialinicial.TabIndex = 14;
            this.labelcapialinicial.Text = "Capital inicial:";
            // 
            // datos_simple
            // 
            this.datos_simple.AutoSize = true;
            this.datos_simple.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datos_simple.Location = new System.Drawing.Point(17, 14);
            this.datos_simple.Name = "datos_simple";
            this.datos_simple.Size = new System.Drawing.Size(225, 28);
            this.datos_simple.TabIndex = 13;
            this.datos_simple.Text = "Calcular capital final";
            // 
            // UC_capital_final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericPeriodo);
            this.Controls.Add(this.labelcapfinal);
            this.Controls.Add(this.comboPeriodo);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.labelperiodo);
            this.Controls.Add(this.tb_tasa_interes);
            this.Controls.Add(this.labeltasainteres);
            this.Controls.Add(this.tb_capital);
            this.Controls.Add(this.labelcapialinicial);
            this.Controls.Add(this.datos_simple);
            this.Name = "UC_capital_final";
            this.Size = new System.Drawing.Size(734, 424);
            ((System.ComponentModel.ISupportInitialize)(this.numericPeriodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericPeriodo;
        private System.Windows.Forms.Label labelcapfinal;
        private System.Windows.Forms.ComboBox comboPeriodo;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label labelperiodo;
        private System.Windows.Forms.TextBox tb_tasa_interes;
        private System.Windows.Forms.Label labeltasainteres;
        private System.Windows.Forms.TextBox tb_capital;
        private System.Windows.Forms.Label labelcapialinicial;
        private System.Windows.Forms.Label datos_simple;
    }
}
