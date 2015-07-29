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
using General.desarrolloDataSetEliaTableAdapters;
namespace General
{
    public partial class SubirNotas : Form
    {
        public static int validar = 0;
        QueriesTableAdapter ingresar = new QueriesTableAdapter();
        public SubirNotas()
        {
            InitializeComponent();
        }
        private void SubirNotas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetElia.SPCursoB' Puede moverla o quitarla según sea necesario.
            this.sPCursoBTableAdapter.Fill(this.desarrolloDataSetElia.SPCursoB);
            cursoIdTextBox.Text = "1";
            //TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetElia.SPCursoB' Puede moverla o quitarla según sea necesario.
            this.sPSeccionBTableAdapter.Fill(this.desarrolloDataSetElia.SPSeccionB, Convert.ToInt32(cursoIdTextBox.Text));
            this.sPMateriaBTableAdapter.Fill(this.desarrolloDataSetElia.SPMateriaB, Convert.ToInt32(cursoIdTextBox.Text));
            button1.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem== null)
            {
                //muestra mensaje de verificacion
                MessageBox.Show("Debe seleccionar todos los datos, verifique sección");
            }
            else
            {
                //recorre la grilla en busca de datos
                foreach (DataGridViewRow row in sPAlumnosXClaseBDataGridView.Rows)
                {
                    // validacion que permite saber si los datos ingresados son validos
                    double esNumero;
                    if ((row.Cells[2].Value == null || row.Cells[3].Value == null))
                    {
                        validar++;
                    }
                    else
                    {
                        // validacion que permite saber si los datos ingresados no son numeros
                        if ((!double.TryParse(row.Cells[2].Value.ToString(), out esNumero) || !double.TryParse(row.Cells[3].Value.ToString(), out esNumero)))
                        {
                            validar++;
                            row.Cells[2].Value = ' ';
                            row.Cells[3].Value = ' ';
                        }
                        // validacion que permite saber si los datos ingresados son mayores a 0 y menores a 100
                        if ((((Convert.ToInt32(row.Cells[2].Value)) + Convert.ToInt32(row.Cells[3].Value)) > 100))
                        {
                            validar++;
                        }
                    }
                }
                if (validar == 0)
                {
                    // procedimeinto almacenado que se ejecutara en todas las filas de la grilla
                    foreach (DataGridViewRow row in sPAlumnosXClaseBDataGridView.Rows)
                    {
                        ingresar.IngresarNotasB(row.Cells[0].Value.ToString(), Convert.ToInt32(row.Cells[2].Value), Convert.ToInt32(row.Cells[3].Value), comboBox1.Text.ToString(), sPMateriaBComboBox.SelectedValue.ToString());
                    }
                    MessageBox.Show("Datos ingresados con exito");
                }
                else
                {
                    MessageBox.Show("No se puede ingresar las notas, Existen valores incorrectos");
                    validar = 0;
                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.sPAlumnosXClaseBTableAdapter.Fill(this.desarrolloDataSetElia.SPAlumnosXClaseB, Convert.ToInt32(sPCursoBComboBox.SelectedValue.ToString()));
            foreach (DataGridViewRow row in sPAlumnosXClaseBDataGridView.Rows)
            {
                //ingresa el valor del procedimiento almacenado en la variable
                row.Cells[2].Value = ingresar.SPAcumulativoPorPArcialB(row.Cells[0].Value.ToString(), sPMateriaBComboBox.SelectedValue.ToString(), comboBox1.Text.ToString(), sPSeccionBComboBox.SelectedValue.ToString());
                row.Cells[3].Value = ingresar.SPExamenPorPArcialB(row.Cells[0].Value.ToString(), sPMateriaBComboBox.SelectedValue.ToString(), comboBox1.Text.ToString(), sPSeccionBComboBox.SelectedValue.ToString());
            }
            button1.Enabled = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //el boton guardar pasa a habilitado
            button1.Enabled = true;
           
        }
        private void cursoIdTextBox_TextChanged_1(object sender, EventArgs e)
        {
            //procedimientos que muestran la seccion, materia,alumnos
            this.sPSeccionBTableAdapter.Fill(this.desarrolloDataSetElia.SPSeccionB, Convert.ToInt32(cursoIdTextBox.Text));
            this.sPMateriaBTableAdapter.Fill(this.desarrolloDataSetElia.SPMateriaB, Convert.ToInt32(cursoIdTextBox.Text));
            this.sPAlumnosXClaseBTableAdapter.Fill(this.desarrolloDataSetElia.SPAlumnosXClaseB, Convert.ToInt32(cursoIdTextBox.Text));
        }

    }
}
