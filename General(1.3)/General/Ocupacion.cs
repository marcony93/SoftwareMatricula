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
using General.desarrolloDataSet1TableAdapters;

namespace General
{
    public partial class Ocupacion : Form
    {
        QueriesTableAdapter Agregar = new QueriesTableAdapter();
        QueriesTableAdapter eliminar = new QueriesTableAdapter();
        public Ocupacion()
        {
            InitializeComponent();
        }

        private void ocupacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ocupacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.desarrolloDataSet);

        }

        private void Ocupacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.SpOcupacion' Puede moverla o quitarla según sea necesario.
            this.spOcupacionTableAdapter.Fill(this.desarrolloDataSet1.SpOcupacion);
            
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.Ocupacion' Puede moverla o quitarla según sea necesario.
            this.ocupacionTableAdapter.Fill(this.desarrolloDataSet.Ocupacion);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LogIn.SoloLetrasConMensaje(textBox1, errorProvider1);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox1.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    Agregar.spOcupacion_agregar(textBox1.Text);
                    this.spOcupacionTableAdapter.Fill(this.desarrolloDataSet1.SpOcupacion);
                    
                }
                else
                    MessageBox.Show("Tiene que Ingresar una Ocupacion");
            }
            catch (SqlException)
            {


            }
            this.spOcupacionTableAdapter.Fill(this.desarrolloDataSet1.SpOcupacion);
        }

  
        private void spOcupacionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nom;
            {
                if (spOcupacionDataGridView.Rows[e.RowIndex].Cells[2].Selected)
                {
                    try
                    {
                        nom = spOcupacionDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        if (MessageBox.Show("Estas seguro de eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            eliminar.spOcupacion_eliminar(nom);
                            MessageBox.Show("Registro eliminado");
                        }
                        this.spOcupacionTableAdapter.Fill(this.desarrolloDataSet1.SpOcupacion);

                    }
                    catch (SqlException)
                    {

                       
                    }
                }

            }
        }
    }
}
