namespace CALCULADORA_HEDAMIS.Datos
{
    partial class UC_interes_simple_total
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
            this.datos_simple = new System.Windows.Forms.Label();
            this.labelcapialinicial = new System.Windows.Forms.Label();
            this.tb_capital = new System.Windows.Forms.TextBox();
            this.labeltasainteres = new System.Windows.Forms.Label();
            this.tb_tasa_interes = new System.Windows.Forms.TextBox();
            this.labelperiodo = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.comboPeriodo = new System.Windows.Forms.ComboBox();
            this.labelinteresobtenido = new System.Windows.Forms.Label();
            this.labelcapitalcompuesto = new System.Windows.Forms.Label();
            this.numericPeriodo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericPeriodo)).BeginInit();
            this.SuspendLayout();
            // 
            // datos_simple
            // 
            this.datos_simple.AutoSize = true;
            this.datos_simple.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datos_simple.Location = new System.Drawing.Point(16, 12);
            this.datos_simple.Name = "datos_simple";
            this.datos_simple.Size = new System.Drawing.Size(274, 28);
            this.datos_simple.TabIndex = 0;
            this.datos_simple.Text = "Calcular intereses totales";
            this.datos_simple.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelcapialinicial
            // 
            this.labelcapialinicial.AutoSize = true;
            this.labelcapialinicial.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcapialinicial.Location = new System.Drawing.Point(17, 58);
            this.labelcapialinicial.Name = "labelcapialinicial";
            this.labelcapialinicial.Size = new System.Drawing.Size(92, 19);
            this.labelcapialinicial.TabIndex = 1;
            this.labelcapialinicial.Text = "Capital inicial:";
            this.labelcapialinicial.Click += new System.EventHandler(this.labelcapialinicial_Click);
            // 
            // tb_capital
            // 
            this.tb_capital.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_capital.Location = new System.Drawing.Point(172, 52);
            this.tb_capital.Name = "tb_capital";
            this.tb_capital.Size = new System.Drawing.Size(193, 25);
            this.tb_capital.TabIndex = 2;
            this.tb_capital.TextChanged += new System.EventHandler(this.tb_capital_TextChanged);
            // 
            // labeltasainteres
            // 
            this.labeltasainteres.AutoSize = true;
            this.labeltasainteres.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltasainteres.Location = new System.Drawing.Point(17, 101);
            this.labeltasainteres.Name = "labeltasainteres";
            this.labeltasainteres.Size = new System.Drawing.Size(127, 19);
            this.labeltasainteres.TabIndex = 3;
            this.labeltasainteres.Text = "Tasa de interés (%):";
            this.labeltasainteres.Click += new System.EventHandler(this.labeltasainteres_Click);
            // 
            // tb_tasa_interes
            // 
            this.tb_tasa_interes.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tasa_interes.Location = new System.Drawing.Point(172, 95);
            this.tb_tasa_interes.Name = "tb_tasa_interes";
            this.tb_tasa_interes.Size = new System.Drawing.Size(193, 25);
            this.tb_tasa_interes.TabIndex = 4;
            this.tb_tasa_interes.TextChanged += new System.EventHandler(this.tb_tasa_interes_TextChanged);
            // 
            // labelperiodo
            // 
            this.labelperiodo.AutoSize = true;
            this.labelperiodo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelperiodo.Location = new System.Drawing.Point(17, 143);
            this.labelperiodo.Name = "labelperiodo";
            this.labelperiodo.Size = new System.Drawing.Size(59, 19);
            this.labelperiodo.TabIndex = 5;
            this.labelperiodo.Text = "Periodo:";
            this.labelperiodo.Click += new System.EventHandler(this.labelperiodo_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncalcular.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(21, 180);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(344, 36);
            this.btncalcular.TabIndex = 7;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // comboPeriodo
            // 
            this.comboPeriodo.FormattingEnabled = true;
            this.comboPeriodo.Items.AddRange(new object[] {
            "dias",
            "meses",
            "años"});
            this.comboPeriodo.Location = new System.Drawing.Point(271, 141);
            this.comboPeriodo.Name = "comboPeriodo";
            this.comboPeriodo.Size = new System.Drawing.Size(93, 21);
            this.comboPeriodo.TabIndex = 8;
            this.comboPeriodo.SelectedIndexChanged += new System.EventHandler(this.comboPeriodo_SelectedIndexChanged);
            // 
            // labelinteresobtenido
            // 
            this.labelinteresobtenido.AutoSize = true;
            this.labelinteresobtenido.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinteresobtenido.Location = new System.Drawing.Point(17, 240);
            this.labelinteresobtenido.Name = "labelinteresobtenido";
            this.labelinteresobtenido.Size = new System.Drawing.Size(113, 19);
            this.labelinteresobtenido.TabIndex = 10;
            this.labelinteresobtenido.Text = "Interés obtenido:";
            this.labelinteresobtenido.Click += new System.EventHandler(this.labelinteresobtenido_Click);
            // 
            // labelcapitalcompuesto
            // 
            this.labelcapitalcompuesto.AutoSize = true;
            this.labelcapitalcompuesto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcapitalcompuesto.Location = new System.Drawing.Point(17, 278);
            this.labelcapitalcompuesto.Name = "labelcapitalcompuesto";
            this.labelcapitalcompuesto.Size = new System.Drawing.Size(127, 19);
            this.labelcapitalcompuesto.TabIndex = 11;
            this.labelcapitalcompuesto.Text = "Capital compuesto:";
            this.labelcapitalcompuesto.Click += new System.EventHandler(this.labelcapitalcompuesto_Click);
            // 
            // numericPeriodo
            // 
            this.numericPeriodo.Location = new System.Drawing.Point(172, 142);
            this.numericPeriodo.Name = "numericPeriodo";
            this.numericPeriodo.Size = new System.Drawing.Size(93, 20);
            this.numericPeriodo.TabIndex = 12;
            this.numericPeriodo.ValueChanged += new System.EventHandler(this.numericPeriodo_ValueChanged);
            // 
            // UC_interes_simple_total
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericPeriodo);
            this.Controls.Add(this.labelcapitalcompuesto);
            this.Controls.Add(this.labelinteresobtenido);
            this.Controls.Add(this.comboPeriodo);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.labelperiodo);
            this.Controls.Add(this.tb_tasa_interes);
            this.Controls.Add(this.labeltasainteres);
            this.Controls.Add(this.tb_capital);
            this.Controls.Add(this.labelcapialinicial);
            this.Controls.Add(this.datos_simple);
            this.Name = "UC_interes_simple_total";
            this.Size = new System.Drawing.Size(734, 424);
            ((System.ComponentModel.ISupportInitialize)(this.numericPeriodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label datos_simple;
        private System.Windows.Forms.Label labelcapialinicial;
        private System.Windows.Forms.TextBox tb_capital;
        private System.Windows.Forms.Label labeltasainteres;
        private System.Windows.Forms.TextBox tb_tasa_interes;
        private System.Windows.Forms.Label labelperiodo;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.ComboBox comboPeriodo;
        private System.Windows.Forms.Label labelinteresobtenido;
        private System.Windows.Forms.Label labelcapitalcompuesto;
        private System.Windows.Forms.NumericUpDown numericPeriodo;
    }
}
