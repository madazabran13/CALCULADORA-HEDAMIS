using CALCULADORA_HEDAMIS.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA_HEDAMIS
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
       private void addUserControl(UserControl userControl)
        {
            userControl.Dock  = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void menuinteressimple_Click(object sender, EventArgs e)
        {
            
        }

        private void menuinterescompuesto_Click(object sender, EventArgs e)
        {
            UC_interes_compuesto uccompuesto = new UC_interes_compuesto();
            addUserControl(uccompuesto);

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void interesTotalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_interes_simple_total ucsimple = new UC_interes_simple_total();
            addUserControl(ucsimple);
        }

        private void tipoDeInteresesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_tasa_interes uctasa = new UC_tasa_interes();
            addUserControl(uctasa);
        }

        private void capitalInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_capital_inicial ucinicial= new UC_capital_inicial();
            addUserControl(ucinicial);
        }

        private void capitalFinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_capital_final ucfinal = new UC_capital_final();
            addUserControl(ucfinal);
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_inicio ucinicio = new UC_inicio();
            addUserControl(ucinicio);
        }
    }
}
