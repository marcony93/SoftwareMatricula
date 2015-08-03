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
    public partial class VerAlumno : Form
    {
        public static string iddelalumno;
        public VerAlumno()
        {
            InitializeComponent();
        }
        //
        private void VerAlumno_Load(object sender, EventArgs e)
        {
            // habilita y deshabilita los textbox segun lo seleccionado
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            comboBox1.SelectedIndex = 0;
            this.spVerAlumnoTableAdapter.Fill(this.desarrolloDataSet1.SpVerAlumno, textBox1.Text, textBox2.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBox1.SelectedIndex, typeof(int))))));
        }
        // muuestra el listado de alumnos segun el textbox seleccionado ya sea por nombre o nuero de identidad
        private void button1_Click(object sender, EventArgs e)
        {
            // muestra todos los alumnos
            this.spVerAlumnoTableAdapter.Fill(this.desarrolloDataSet1.SpVerAlumno, textBox1.Text, textBox2.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBox1.SelectedIndex, typeof(int))))));
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cuandi el indice del combobox es 0 los dos textbox estan deshabilitados
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
            // cuandi el indice del combobox es 1 un textbox esta habilitado y el otro deshabilitado (nombre y numero de identidad)
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;
            }
            // cuandi el indice del combobox es 2 un textbox esta habilitado y el otro deshabilitado (numero de identidad y nombre)
            else
                if (comboBox1.SelectedIndex == 2)
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = true;
                }
            // limpia los valores de los textbox
            textBox1.Clear();
            textBox2.Clear();
        }
        private void spVerAlumnoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow grilla in spVerAlumnoDataGridView.Rows)
            { 
                if (grilla.Cells[0].Selected)
                {
                    iddelalumno = grilla.Cells[0].Value.ToString();
                    Form ModificarAlumno = new ModificarAlumno();
                    ModificarAlumno.Show();
                }
            }  
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
            // linea que llama la funcion solo letras
            LogIn.SoloLetrasConMensaje(textBox1, errorProvider1);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // linea que llama la funcion solo numeros
            LogIn.solo13Numeros(textBox2);
        }
    }
}