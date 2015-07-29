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
        //crea variable para usar procedimientos almacenados
        public static Ventana_General_Vista_Maestro VentanaMaestro = new Ventana_General_Vista_Maestro();
        public Ventana_General_Vista_Maestro()
        {
            InitializeComponent();
        }
        private void subirNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //nueva ventana subir notas
            Form SubirNotas = new SubirNotas();
            //muestra la ventana 
            SubirNotas.Show();
            //crea la ventana de modo hijo
            SubirNotas.MdiParent = this;
            //maximiza la ventana creada
            SubirNotas.WindowState = FormWindowState.Maximized;
            //trae al frente la ventana creada
            SubirNotas.BringToFront();
        }
        private void cambiarMiContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //nueva ventana subir notas
            Form modificarcontrasena = new modificarcontrasena();
            //muestra la ventana 
            modificarcontrasena.Show();
            //crea la ventana de modo hijo
            modificarcontrasena.MdiParent = this;
            //maximiza la ventana creada
            modificarcontrasena.WindowState = FormWindowState.Maximized;
            //trae al frente la ventana creada
            modificarcontrasena.BringToFront();
        }
        private void reprobadosPorParcialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //muestra la ventana de reprobados por parcial
            new ReprobadosParcial().Show();
        }
        private void reprobadosGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //muestra la ventana de reprobados por parcial
            new ReporteReprobados().Show();
        }
        private void reporteHorarioMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //muestra la ventana de reprobados por parcial
            new ReporteHorarioMaestro().Show();
        }
    }
}