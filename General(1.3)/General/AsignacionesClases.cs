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
using General.desarrolloDataSetWilmerTableAdapters;

namespace General
{
    public partial class AsignacionesClases : Form
    {
        QueriesTableAdapter asignar = new QueriesTableAdapter();
        public AsignacionesClases()
        {
            InitializeComponent();
        }

        private void AsignacionesClases_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetWilmer.spmostrarplanilla' Puede moverla o quitarla según sea necesario.
            this.spmostrarplanillaTableAdapter.Fill(this.desarrolloDataSetWilmer.spmostrarplanilla);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetWilmer.SpDia' Puede moverla o quitarla según sea necesario.
            this.spDiaTableAdapter.Fill(this.desarrolloDataSetWilmer.SpDia);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetWilmer.spHora' Puede moverla o quitarla según sea necesario.
            this.spHoraTableAdapter.Fill(this.desarrolloDataSetWilmer.spHora);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetWilmer.spModalidad' Puede moverla o quitarla según sea necesario.
            this.spModalidadTableAdapter.Fill(this.desarrolloDataSetWilmer.spModalidad);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetWilmer.spMaestro' Puede moverla o quitarla según sea necesario.
            this.spMaestroTableAdapter.Fill(this.desarrolloDataSetWilmer.spMaestro);

            this.spCursoTableAdapter.Fill(this.desarrolloDataSetWilmer.spCurso, new System.Nullable<int>(((int)(System.Convert.ChangeType(spModalidadComboBox.SelectedValue.ToString(), typeof(int))))));
            //this.spSeccionesTableAdapter.Fill(this.desarrolloDataSetWilmer.spSecciones, new System.Nullable<int>(((int)(System.Convert.ChangeType(spCursoComboBox.SelectedValue.ToString(), typeof(int))))), DateTime.Today.Year.ToString());
            this.spMateriaTableAdapter.Fill(this.desarrolloDataSetWilmer.spMateria, new System.Nullable<int>(((int)(System.Convert.ChangeType(spModalidadComboBox.SelectedValue.ToString(), typeof(int))))), spCursoComboBox.SelectedValue.ToString());

            lblanio.Text = DateTime.Today.Year.ToString();
        }

 
       private void spModalidadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.spCursoTableAdapter.Fill(this.desarrolloDataSetWilmer.spCurso, new System.Nullable<int>(((int)(System.Convert.ChangeType(spModalidadComboBox.SelectedValue.ToString(), typeof(int))))));
        }

        private void spCursoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.spSeccionesTableAdapter.Fill(this.desarrolloDataSetWilmer.spSecciones, new System.Nullable<int>(((int)(System.Convert.ChangeType(spCursoComboBox.SelectedValue.ToString(), typeof(int))))), DateTime.Today.Year.ToString());
            this.spMateriaTableAdapter.Fill(this.desarrolloDataSetWilmer.spMateria, new System.Nullable<int>(((int)(System.Convert.ChangeType(spModalidadComboBox.SelectedValue.ToString(), typeof(int))))), spCursoComboBox.SelectedValue.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                asignar.spinsertarplanilla2(spHoraComboBox.SelectedValue.ToString(), DateTime.Today.Year.ToString(), spMaestroComboBox.SelectedValue.ToString(), spCursoComboBox.SelectedValue.ToString(), Convert.ToInt32(spModalidadComboBox.SelectedValue.ToString()), spMateriaComboBox.SelectedValue.ToString(), spSeccionesComboBox.SelectedValue.ToString(), spDiaComboBox.SelectedValue.ToString());
                this.spmostrarplanillaTableAdapter.Fill(this.desarrolloDataSetWilmer.spmostrarplanilla);
                MessageBox.Show("Asignacion Guardada con exito");
            }
            catch (SqlException)
            {

                MessageBox.Show("Esta asignacion ya exite.... Por favor agregue otra");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ReporteHorarioMaestro rep = new ReporteHorarioMaestro();
            //rep.Show();
        }
    }
}
