using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using General.desarrolloDataSetWilmerTableAdapters;
using System.Data.SqlClient;
namespace General
{
    public partial class AsignarClases : Form
    {
        //CREA UNA INSTANCIA PARA UTILIZAR LOS PROCEDIMIENTOS ALMACENADOS QUE ESTAN EN EL DATASET
        QueriesTableAdapter asignar = new QueriesTableAdapter();
        public AsignarClases()
        {
            InitializeComponent();
        }
        public int curso;
        private void AsignarClases_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetWilmer.SpDia' Puede moverla o quitarla según sea necesario.
            this.spDiaTableAdapter.Fill(this.desarrolloDataSetWilmer.SpDia);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetWilmer.spHora' Puede moverla o quitarla según sea necesario.
            this.spHoraTableAdapter.Fill(this.desarrolloDataSetWilmer.spHora);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetWilmer.spHora' Puede moverla o quitarla según sea necesario.
            this.spHoraTableAdapter.Fill(this.desarrolloDataSetWilmer.spHora);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetWilmer.spModalidad' Puede moverla o quitarla según sea necesario.
            this.spModalidadTableAdapter.Fill(this.desarrolloDataSetWilmer.spModalidad);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetWilmer.spMaestro' Puede moverla o quitarla según sea necesario.
            this.spMaestroTableAdapter.Fill(this.desarrolloDataSetWilmer.spMaestro);
            this.spCursoTableAdapter.Fill(this.desarrolloDataSetWilmer.spCurso,Convert.ToInt32(spModalidadComboBox.SelectedValue));
            this.spSeccionesTableAdapter.Fill(this.desarrolloDataSetWilmer.spSecciones, Convert.ToInt32(spCursoComboBox.SelectedValue), DateTime.Today.Year.ToString());
            this.spMateriaTableAdapter.Fill(this.desarrolloDataSetWilmer.spMateria, Convert.ToInt32(spModalidadComboBox.SelectedValue.ToString()), Convert.ToInt32(spCursoComboBox.SelectedValue.ToString()));
            this.spmostrarplanillaTableAdapter.Fill(this.desarrolloDataSetWilmer.spmostrarplanilla, spMaestroComboBox.SelectedValue.ToString());
        }
        private void spMaestroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PROCEDIMEITNO QUE ACTUALIZA LA PLANILLA TOMANDO EL PARAMETRO MAESTRO
            this.spmostrarplanillaTableAdapter.Fill(this.desarrolloDataSetWilmer.spmostrarplanilla, spMaestroComboBox.SelectedValue.ToString());
        }
        private void spModalidadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PROCEDIMEITNO QUE ACTUALIZA EL CURSO TOMANDO EL PARAMETRO MODALIDAD   
            this.spCursoTableAdapter.Fill(this.desarrolloDataSetWilmer.spCurso, 
          Convert.ToInt32(spModalidadComboBox.SelectedValue));
            //PROCEDIMEITNO QUE ACTALIZA LA SECCION TOMANDO EL PARAMETRO CURSO
            this.spSeccionesTableAdapter.Fill(this.desarrolloDataSetWilmer.spSecciones, 
            Convert.ToInt32(spCursoComboBox.SelectedValue), DateTime.Today.Year.ToString());
            //PROCEDIMEITNO QUE ACTALIZA LA MATERIA TOMANDO EL PARAMETRO MODALIDAD
            this.spMateriaTableAdapter.Fill(this.desarrolloDataSetWilmer.spMateria, 
            Convert.ToInt32(spModalidadComboBox.SelectedValue.ToString()), Convert.ToInt32(spCursoComboBox.SelectedValue.ToString()));
        }
        private void spCursoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //VALIDACION QUE PERMITE SABER SI EL CURSO ESTA NULO
            if (spCursoComboBox.SelectedValue != null)
            {
                //PROCEDIMEITNO QUE ACTUALIZA LA SECCION TOMANDO EL PARAMETRO CURSO
                this.spSeccionesTableAdapter.Fill(this.desarrolloDataSetWilmer.spSecciones,
                Convert.ToInt32(spCursoComboBox.SelectedValue), DateTime.Today.Year.ToString());
                //PROCEDIMEITNO QUE ACTUALIZA LA MATERIA TOMANDO EL PARAMETRO MODALIDAD
                this.spMateriaTableAdapter.Fill(this.desarrolloDataSetWilmer.spMateria,
                Convert.ToInt32(spModalidadComboBox.SelectedValue.ToString()), Convert.ToInt32(spCursoComboBox.SelectedValue.ToString()));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //PROCEDIMIENTO QUE GUARDA LA PLANILLA DEL MAESTRO CON LOS PARAMETROS DE 
                //LOS COMBOBOX
                asignar.spinsertarplanilla2(spHoraComboBox.SelectedValue.ToString(), DateTime.Today.Year.ToString(), spMaestroComboBox.SelectedValue.ToString(), spCursoComboBox.SelectedValue.ToString(), Convert.ToInt32(spModalidadComboBox.SelectedValue.ToString()), spMateriaComboBox.SelectedValue.ToString(), spSeccionesComboBox.SelectedValue.ToString(), spDiaComboBox.SelectedValue.ToString());
                MessageBox.Show("Asignacion guardada con exito");
                this.spmostrarplanillaTableAdapter.Fill(this.desarrolloDataSetWilmer.spmostrarplanilla, spMaestroComboBox.SelectedValue.ToString());
            }
            catch (SqlException)
            {
                MessageBox.Show("Esta asignacion ya exite.... Por favor agregue otra");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


