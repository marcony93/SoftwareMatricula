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
using General.desarrolloDataSetTableAdapters;
namespace General
{
    public partial class Nacionalidad : Form
    {
        QueriesTableAdapter eliminar = new QueriesTableAdapter();
        QueriesTableAdapter agregar = new QueriesTableAdapter();
        public Nacionalidad()
        {
            InitializeComponent();
        }
        private void Nacionalidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spNacionalidad' Puede moverla o quitarla según sea necesario.
            this.spNacionalidadTableAdapter1.Fill(this.desarrolloDataSet1.spNacionalidad);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.spNacionalidad' Puede moverla o quitarla según sea necesario.
            this.spNacionalidadTableAdapter.Fill(this.desarrolloDataSet.spNacionalidad);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    agregar.spNacionalidad_agregar(textBox1.Text);
                    this.spNacionalidadTableAdapter1.Fill(this.desarrolloDataSet1.spNacionalidad);
                    this.spNacionalidadTableAdapter.Fill(this.desarrolloDataSet.spNacionalidad);
                }
                else
                    MessageBox.Show("Tiene que Ingresar una nacionalidad");
            }
            catch (SqlException)
            { }
            this.spNacionalidadTableAdapter1.Fill(this.desarrolloDataSet1.spNacionalidad);
            this.spNacionalidadTableAdapter.Fill(this.desarrolloDataSet.spNacionalidad);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LogIn.SoloLetrasConMensaje(textBox1, errorProvider1);
            LogIn.ValorMaximoDeCaja(textBox1, 15, errorProvider1);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox1.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void spNacionalidadDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string nombre;
            {
                if (spNacionalidadDataGridView.Rows[e.RowIndex].Cells[2].Selected)
                {
                    try
                    {
                        nombre = spNacionalidadDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        if (MessageBox.Show("Estas seguro de eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            eliminar.spNacionalidad_eliminar(nombre);
                            MessageBox.Show("Registro eliminado");
                        }
                        this.spNacionalidadTableAdapter1.Fill(this.desarrolloDataSet1.spNacionalidad);
                    }
                    catch (SqlException)
                    { }
                }
            }
        }
    }
}
