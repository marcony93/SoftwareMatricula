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
    public partial class ReporteClasesXCurso : Form
    {
        public ReporteClasesXCurso()
        {
            InitializeComponent();
        }

        private void ReporteClasesXCurso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetBaque.uspSelectModalidad' Puede moverla o quitarla según sea necesario.
            this.uspSelectModalidadTableAdapter.Fill(this.desarrolloDataSetBaque.uspSelectModalidad);
            //// TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetWilmer.Modalidad' Puede moverla o quitarla según sea necesario.
            this.uspModalidadTableAdapter.Fill(this.desarrolloDataSetBaque.uspModalidad, Convert.ToInt16(uspSelectModalidadComboBox.SelectedValue));
            this.uspSeccionxCursoTableAdapter.Fill(this.desarrolloDataSetBaque.uspSeccionxCurso, Convert.ToInt16(uspModalidadComboBox.SelectedValue),DateTime.Today.Year.ToString());
            //// TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetWilmer.spreporteclasesporcurso' Puede moverla o quitarla según sea necesario.
          //  this.spreporteclasesporcursoTableAdapter.Fill(this.desarrolloDataSetBaque.spreporteclasesporcurso, Convert.ToInt16(uspSelectModalidadComboBox.SelectedValue), Convert.ToInt16(uspModalidadComboBox.SelectedValue), uspSeccionxCursoComboBox.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }

    
  
        private void uspSelectModalidadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.uspModalidadTableAdapter.Fill(this.desarrolloDataSetBaque.uspModalidad, Convert.ToInt16(uspSelectModalidadComboBox.SelectedValue));
            this.uspSeccionxCursoTableAdapter.Fill(this.desarrolloDataSetBaque.uspSeccionxCurso, Convert.ToInt16(uspModalidadComboBox.SelectedValue), DateTime.Today.Year.ToString());
           
        }

        private void uspModalidadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.uspSeccionxCursoTableAdapter.Fill(this.desarrolloDataSetBaque.uspSeccionxCurso, Convert.ToInt16(uspModalidadComboBox.SelectedValue), DateTime.Today.Year.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  this.spreporteclasesporcursoTableAdapter.Fill(this.desarrolloDataSetWilmer.spreporteclasesporcurso, Convert.ToInt16(uspSelectModalidadComboBox.SelectedValue), Convert.ToInt16(uspModalidadComboBox.SelectedValue), uspSeccionxCursoComboBox.SelectedValue.ToString());
            //this.reportViewer1.RefreshReport();
        }

       

    }
}
