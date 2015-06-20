﻿using System;
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

        private void Ventana_General_Vista_Maestro_Load(object sender, EventArgs e)
        {
            
        }

        private void nuevoMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
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
            Form vent = new modificarcontrasena();
            vent.Show();
        }

        private void reprobadosPorParcialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Reprobados = new ReprobadosParcial();
            Reprobados.Show();
            Reprobados.MdiParent = this;
            Reprobados.WindowState = FormWindowState.Maximized;
            Reprobados.BringToFront();
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