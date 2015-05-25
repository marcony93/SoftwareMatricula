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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.uspCursos' Puede moverla o quitarla según sea necesario.
            this.uspCursosTableAdapter.Fill(this.desarrolloDataSet.uspCursos);
            this.uspSeccionesXcursoTableAdapter.Fill(desarrolloDataSet.uspSeccionesXcurso, Convert.ToInt32(uspCursosComboBox.SelectedValue));

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

      

        private void uspCursosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.uspSeccionesXcursoTableAdapter.Fill(desarrolloDataSet.uspSeccionesXcurso, Convert.ToInt32(uspCursosComboBox.SelectedValue));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.uspAlumnosxCursoxSeccion1TableAdapter.Fill(this.desarrolloDataSet.uspAlumnosxCursoxSeccion1, Convert.ToInt32(uspCursosComboBox.SelectedValue), Convert.ToInt32(seccion.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
