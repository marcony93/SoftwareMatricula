using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General
{
    public partial class ReporteNotas : Form
    {
        public ReporteNotas()
        {
            InitializeComponent();
        }

        private void ReporteNotas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetBaque.uspReporteNotas' Puede moverla o quitarla según sea necesario.
         
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetBaque.uspReporteNotas' Puede moverla o quitarla según sea necesario.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.uspReporteNotasTableAdapter.Fill(this.desarrolloDataSetBaque.uspReporteNotas,textBox1.Text);
            this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LogIn.solo13Numeros(textBox1);
        }
    }
}
