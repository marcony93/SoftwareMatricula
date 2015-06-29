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
    public partial class VentanaGeneralVistaSecretaria : Form
    {
        public static VentanaGeneralVistaSecretaria VentanaSecretaria = new VentanaGeneralVistaSecretaria();
        
        public VentanaGeneralVistaSecretaria()
        {
            InitializeComponent();
        }

        private void FormGeneral_Load(object sender, EventArgs e)
        {
            
        }

        private void crearCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarMaestro.VentanaNuevoMaestro.Show();
            InsertarMaestro.VentanaNuevoMaestro.MdiParent = this;
            InsertarMaestro.VentanaNuevoMaestro.WindowState = FormWindowState.Maximized;
            InsertarMaestro.VentanaNuevoMaestro.BringToFront();                
        }

        private void fichaMatriculaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form FichaMatricula = new FichaMatricula();
            FichaMatricula.Show();
            FichaMatricula.MdiParent = this;
            FichaMatricula.WindowState = FormWindowState.Maximized;
            FichaMatricula.BringToFront();
       
        }

        private void verNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void VentanaGeneralVistaSecretaria_Click(object sender, EventArgs e)
        {

                

        }

        private void horatrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form reporte = new ReporteAlumno();
           reporte.Show();
        }

        private void asignacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ventana = new AsignacionesClases();
            ventana.Show();
        }

        private void notasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form vent = new ReporteNotas();
            vent.Show();
        }

        private void verAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form vent = new VerAlumno();
           // vent.Show();
            Form FichaMatricula = new VerAlumno();
            FichaMatricula.Show();
            FichaMatricula.MdiParent = this;
            FichaMatricula.WindowState = FormWindowState.Maximized;
            FichaMatricula.BringToFront();
        }

        private void modificarCarnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vent = new Carnet();
            vent.Show();
        }

        private void actualizarMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form modificarmaestro = new modificarmaestro();
            modificarmaestro.Show();
            modificarmaestro.MdiParent = this;
            modificarmaestro.WindowState = FormWindowState.Maximized;
            modificarmaestro.BringToFront();
        }

        private void reporteClasesPorCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReporteClasesXCurso().Show();
        }

        private void comprobanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReporteComprobante().Show();
        }
    }
}
