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
    public partial class Ventana_General_Vista_Maestro : Form
    {
        public static Ventana_General_Vista_Maestro VentanaMaestro = new Ventana_General_Vista_Maestro();
        public Ventana_General_Vista_Maestro()
        {
            InitializeComponent();
        }
        private void subirNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SubirNotas = new SubirNotas();
            SubirNotas.Show();
            SubirNotas.MdiParent = this;
            SubirNotas.WindowState = FormWindowState.Maximized;
            SubirNotas.BringToFront();
        }
        private void cambiarMiContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form modificarcontrasena = new modificarcontrasena();
            modificarcontrasena.Show();
            modificarcontrasena.MdiParent = this;
            modificarcontrasena.WindowState = FormWindowState.Maximized;
            modificarcontrasena.BringToFront();
        }
        private void reprobadosPorParcialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReprobadosParcial().Show();
        }
        private void reprobadosGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReporteReprobados().Show();
        }
        private void reporteHorarioMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReporteHorarioMaestro().Show();
        }
    }
}
