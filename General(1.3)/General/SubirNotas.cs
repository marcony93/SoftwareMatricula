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
        QueriesTableAdapter var = new QueriesTableAdapter();
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
           // this.sPAlumnosXClaseBTableAdapter.Fill(this.desarrolloDataSetElia.SPAlumnosXClaseB, Convert.ToInt32(cursoIdTextBox.Text));
            
            //this.sPCursoBTableAdapter.Fill(this.desarrolloDataSetElia.SPCursoB);
            button1.Enabled = false;


        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            

        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
          

        }

        private void fillToolStripButton_Click_3(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in sPAlumnosXClaseBDataGridView.Rows)
            {
                double esNumero;
                if ((row.Cells[2].Value == null || row.Cells[3].Value == null) || (((Convert.ToInt32(row.Cells[2].Value)) + Convert.ToInt32(row.Cells[3].Value))>100))
                {
                    validar++;
                    row.Cells[2].Value=' ';
                    row.Cells[3].Value=' ';
                }
                else

                    if (!double.TryParse(row.Cells[2].Value.ToString(), out esNumero) || !double.TryParse(row.Cells[3].Value.ToString(), out esNumero))
                    {
                        validar++;
                    }


            }



            if (validar == 0)
            {
                foreach (DataGridViewRow row in sPAlumnosXClaseBDataGridView.Rows)
                {
                    var.IngresarNotasB(row.Cells[0].Value.ToString(), Convert.ToInt32(row.Cells[2].Value), Convert.ToInt32(row.Cells[3].Value), comboBox1.Text.ToString(), sPMateriaBComboBox.SelectedValue.ToString());
                }
                MessageBox.Show("Datos ingresados con exito");
            }
            else
            {
                MessageBox.Show("No se puede infresar las notas, Existen valores incorrectos");
                validar = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.sPAlumnosXClaseBTableAdapter.Fill(this.desarrolloDataSetElia.SPAlumnosXClaseB, Convert.ToInt32(sPCursoBComboBox.SelectedValue.ToString()));
            foreach (DataGridViewRow row in sPAlumnosXClaseBDataGridView.Rows)
            {
                row.Cells[2].Value = var.SPAcumulativoPorPArcialB(row.Cells[0].Value.ToString(), sPMateriaBComboBox.SelectedValue.ToString(), comboBox1.Text.ToString(), sPSeccionBComboBox.SelectedValue.ToString());
                row.Cells[3].Value = var.SPExamenPorPArcialB(row.Cells[0].Value.ToString(), sPMateriaBComboBox.SelectedValue.ToString(), comboBox1.Text.ToString(), sPSeccionBComboBox.SelectedValue.ToString());
            }
            button1.Enabled = false;

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void cursoIdTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void sPAlumnosXClaseBDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void sPAlumnosXClaseBDataGridView_Leave(object sender, EventArgs e)
        {
           
        }

        private void sPCursoBComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cursoIdTextBox_TextChanged_1(object sender, EventArgs e)
        {
            this.sPSeccionBTableAdapter.Fill(this.desarrolloDataSetElia.SPSeccionB, Convert.ToInt32(cursoIdTextBox.Text));
            this.sPMateriaBTableAdapter.Fill(this.desarrolloDataSetElia.SPMateriaB, Convert.ToInt32(cursoIdTextBox.Text));
            this.sPAlumnosXClaseBTableAdapter.Fill(this.desarrolloDataSetElia.SPAlumnosXClaseB, Convert.ToInt32(cursoIdTextBox.Text));

        }


    }
}
