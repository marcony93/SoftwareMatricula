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
        //SE CREA UNA VARIABLE CON LA INSTANCIA DE ESTA VENTANA
        public static VentanaGeneralVistaSecretaria VentanaSecretaria = new VentanaGeneralVistaSecretaria();
        public VentanaGeneralVistaSecretaria()
        {
            InitializeComponent();
        }
        //EVENTO CLICK QUE ABRE DENTRO DEL CONTENEDOR LA VENTANA DE NUEVO MAESTRO
        private void crearCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ventana = new InsertarMaestro();
            //SE MUESTRA LA VANTANA DE NUEVO MAESTRO
            ventana.Show();
            //SE ASIGNA COMO FORMULARIO PARIENTE DE ESTE
            ventana.MdiParent = this;
            //SE MAXIMIZA LA VENTANA DENTRO DEL CONTENEDOR
            ventana.WindowState = FormWindowState.Maximized;
            //SE TRAE AL FRENTE LA VENTANA QUE SE MANDO A LLAMAR
            ventana.BringToFront();
        }
        //EVENTO CLICK QUE ABRE DENTRO DEL CONTENEDOR LA VENTANA DE NUEVO FICHA MATRICULA
        private void fichaMatriculaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form FichaMatricula = new FichaMatricula();
            //SE MUESTRA LA VANTANA DE NUEVO FICHA MATRICULA
            FichaMatricula.Show();
            //SE ASIGNA COMO FORMULARIO PARIENTE DE ESTE
            FichaMatricula.MdiParent = this;
            //SE MAXIMIZA LA VENTANA DENTRO DEL CONTENEDOR
            FichaMatricula.WindowState = FormWindowState.Maximized;
            //SE TRAE AL FRENTE LA VENTANA QUE SE MANDO A LLAMAR
            FichaMatricula.BringToFront();
        }
        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CREA UNA NUEVA INSTANCIA DE LA VENTANA REPORTE
            Form reporte = new ReporteAlumno();
            //SE MUESTRA LA VANTANA DE NUEVO REPORTE
            reporte.Show();
        }
        private void asignacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CREA UNA NUEVA INSTANCIA DE LA VENTANA ASIGNACIONCLASES
            Form prueba = new prueba();
            //SE MUESTRA LA VANTANA DE ASIGNACIONCLASES
            prueba.Show();
            //SE ASIGNA COMO FORMULARIO PARIENTE DE ESTE
            prueba.MdiParent = this;
            //SE MAXIMIZA LA VENTANA DENTRO DEL CONTENEDOR
            prueba.WindowState = FormWindowState.Maximized;
            //SE TRAE AL FRENTE LA VENTANA QUE SE MANDO A LLAMAR
            prueba.BringToFront();
        }
        private void notasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //CREA UNA NUEVA INSTANCIA DE LA VENTANA REPORTENOTAS
            Form vent = new ReporteNotas();
            //SE MUESTRA LA VANTANA DE REPORTENOTAS
            vent.Show();
        }
        private void verAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CREA UNA NUEVA INSTANCIA DE LA VENTANA FICHAMATRICULA
            Form FichaMatricula = new VerAlumno();
            //SE MUESTRA LA VANTANA DE FICHAMATRICULA
            FichaMatricula.Show();
            //SE ASIGNA COMO FORMULARIO PARIENTE DE ESTE
            FichaMatricula.MdiParent = this;
            //SE MAXIMIZA LA VENTANA DENTRO DEL CONTENEDOR
            FichaMatricula.WindowState = FormWindowState.Maximized;
            //SE TRAE AL FRENTE LA VENTANA QUE SE MANDO A LLAMAR
            FichaMatricula.BringToFront();
        }
        private void modificarCarnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CREA UNA NUEVA INSTANCIA DE LA VENTANA CARNET
            Form Carnet = new Carnet();
            //SE MUESTRA LA VANTANA DE CARNET
            Carnet.Show();
            //SE ASIGNA COMO FORMULARIO PARIENTE DE ESTE
            Carnet.MdiParent = this;
            //SE MAXIMIZA LA VENTANA DENTRO DEL CONTENEDOR
            Carnet.WindowState = FormWindowState.Maximized;
            //SE TRAE AL FRENTE LA VENTANA QUE SE MANDO A LLAMAR
            Carnet.BringToFront();
        }
        private void actualizarMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CREA UNA NUEVA INSTANCIA DE LA VENTANA MODIFICARMAESTRO
            Form modificarmaestro = new modificarmaestro();
            //SE MUESTRA LA VANTANA DE MODIFICARMAESTRO
            modificarmaestro.Show();
            //SE ASIGNA COMO FORMULARIO PARIENTE DE ESTE
            modificarmaestro.MdiParent = this;
            //SE MAXIMIZA LA VENTANA DENTRO DEL CONTENEDOR
            modificarmaestro.WindowState = FormWindowState.Maximized;
            //SE TRAE AL FRENTE LA VENTANA QUE SE MANDO A LLAMAR
            modificarmaestro.BringToFront();
        }
        private void reporteClasesPorCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SE MUESTRA LA VANTANA DE REPORTECLASEPORCURSO
            new ReporteClasesXCurso().Show();
        }
        private void comprobanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SE MUESTRA LA VANTANA DE REPORTECOMPROBANTE
            new ReporteComprobante().Show();
        }
    }
}
