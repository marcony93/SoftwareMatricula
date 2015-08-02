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
    public partial class ReporteComprobante : Form
    {
        public ReporteComprobante()
        {
            InitializeComponent();
        }

        private void ReporteComprobante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetBaque.uspComprobanteMatricula' Puede moverla o quitarla según sea necesario.

            this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LogIn.NumerosConMensaje(textBox1, errorProvider1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.uspComprobanteMatriculaTableAdapter.Fill(this.desarrolloDataSetBaque.uspComprobanteMatricula,textBox1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
