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
    public partial class ReporteAlumno : Form
    {
        public ReporteAlumno()
        {
            InitializeComponent();
        }

        private void ReporteAlumno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetBaque.uspAlumnosxCurso' Puede moverla o quitarla según sea necesario.

            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetBaque.uspAlumnosxCurso' Puede moverla o quitarla según sea necesario.

            this.uspSelectModalidadTableAdapter.Fill(this.desarrolloDataSetBaque.uspSelectModalidad);
            this.uspModalidadTableAdapter.Fill(this.desarrolloDataSetBaque.uspModalidad, Convert.ToInt32(uspSelectModalidadComboBox.SelectedValue));
            this.uspSeccionxCursoTableAdapter.Fill(this.desarrolloDataSetBaque.uspSeccionxCurso, Convert.ToInt32(uspModalidadComboBox.SelectedValue), DateTime.Today.Year.ToString());
            this.reportViewer1.RefreshReport();
        }

        private void fillToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void uspSelectModalidadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.uspModalidadTableAdapter.Fill(this.desarrolloDataSetBaque.uspModalidad, Convert.ToInt32(uspSelectModalidadComboBox.SelectedValue));
        }


        private void uspModalidadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.uspSeccionxCursoTableAdapter.Fill(this.desarrolloDataSetBaque.uspSeccionxCurso, Convert.ToInt32(uspModalidadComboBox.SelectedValue),DateTime.Today.Year.ToString());
        }

        private void uspModalidadComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.uspSeccionxCursoTableAdapter.Fill(this.desarrolloDataSetBaque.uspSeccionxCurso, Convert.ToInt32(uspModalidadComboBox.SelectedValue), DateTime.Today.Year.ToString());
        }

        private void uspSeccionxCursoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ordenar=1;
            this.uspAlumnosxCursoTableAdapter.Fill(this.desarrolloDataSetBaque.uspAlumnosxCurso, Convert.ToInt32(uspModalidadComboBox.SelectedValue),secNombreTextBox.Text, ordenar);
            this.reportViewer1.RefreshReport();
 
      
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ordenar = 1;
            this.uspAlumnosxCursoTableAdapter.Fill(this.desarrolloDataSetBaque.uspAlumnosxCurso, Convert.ToInt32(uspModalidadComboBox.SelectedValue), secNombreTextBox.Text, ordenar);
            this.reportViewer1.RefreshReport();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ordenar = 2;
            this.uspAlumnosxCursoTableAdapter.Fill(this.desarrolloDataSetBaque.uspAlumnosxCurso, Convert.ToInt32(uspModalidadComboBox.SelectedValue), secNombreTextBox.Text, ordenar);
            this.reportViewer1.RefreshReport();
        }
    }
}
