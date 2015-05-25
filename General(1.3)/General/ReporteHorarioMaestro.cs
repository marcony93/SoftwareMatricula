using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace General
{
    public partial class ReporteHorarioMaestro : Form
    {
        public ReporteHorarioMaestro()
        {
            InitializeComponent();
        }

        private void ReporteHorarioMaestro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetBaque.spMaestro1' Puede moverla o quitarla según sea necesario.
            this.spMaestro1TableAdapter.Fill(this.desarrolloDataSetBaque.spMaestro1);

            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetBaque.sprephorariomaestro' Puede moverla o quitarla según sea necesario.
           // this.sprephorariomaestroTableAdapter.Fill(this.desarrolloDataSetBaque.sprephorariomaestro,spMaestro1ComboBox.SelectedValue.ToString(),Convert.ToInt32(spmodalidadxmaestro2ComboBox.SelectedValue.ToString()),spcursoxmaestroComboBox.SelectedValue.ToString(),spseccionxcursoComboBox.SelectedValue.ToString());
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetBaque.spMaestro1' Puede moverla o quitarla según sea necesario.
            

            this.reportViewer1.RefreshReport();
        }


  
        private void spmodalidadxmaestro2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.spcursoxmaestroTableAdapter.Fill(this.desarrolloDataSetBaque.spcursoxmaestro, spMaestro1ComboBox.SelectedValue.ToString(), new System.Nullable<int>(((int)(System.Convert.ChangeType(spmodalidadxmaestro2ComboBox.SelectedValue.ToString(), typeof(int))))));
        }

        private void spcursoxmaestroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.spseccionxcursoTableAdapter.Fill(this.desarrolloDataSetBaque.spseccionxcurso, spMaestro1ComboBox.SelectedValue.ToString(), spcursoxmaestroComboBox.SelectedValue.ToString());
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.sprephorariomaestroTableAdapter.Fill(this.desarrolloDataSetBaque.sprephorariomaestro, spMaestro1ComboBox.SelectedValue.ToString(), Convert.ToInt32(spmodalidadxmaestro2ComboBox.SelectedValue.ToString()), spcursoxmaestroComboBox.SelectedValue.ToString(), spseccionxcursoComboBox.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }

        private void spMaestro1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.spmodalidadxmaestro2TableAdapter.Fill(this.desarrolloDataSetBaque.spmodalidadxmaestro2, spMaestro1ComboBox.SelectedValue.ToString());
            }
            catch (SqlException)
            {
                MessageBox.Show("Este Maestro no tiene asignaciones...");
            }
        }

     
     
      
    }
}
