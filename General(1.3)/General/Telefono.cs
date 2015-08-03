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
    public partial class Telefono : Form
    {
        // lineas para insertar o eliminar un nuevo telefono
        QueriesTableAdapter insertar = new QueriesTableAdapter();
        QueriesTableAdapter eliminar = new QueriesTableAdapter();
        public Telefono()
        {
            InitializeComponent();
        }
        // muestra los telefonos ingresados en una grilla
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.spTelefonosTableAdapter.Fill(this.desarrolloDataSet1.spTelefonos, label2.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // linea de codigo que llama la funcion valor maximo de la caja
            LogIn.ValorMaximoDeCaja(textBox1, 8, errorProvider1);
            // linea de codigo qe llama la funcion solo letras
            LogIn.NumerosConMensaje(textBox1, errorProvider1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //procedimiento almacenado que inserta un nuevo telefono
                insertar.spInsertartelefonoAlumno(textBox1.Text, label2.Text);
                this.spTelefonosTableAdapter.Fill(this.desarrolloDataSet1.spTelefonos, label2.Text);
            }
            catch (SqlException)
            {
                MessageBox.Show("No puede ingresar el mismo numero");
            }
        }
        private void Telefono_Load(object sender, EventArgs e)
        {
            label2.Text = ModificarAlumno.alumnoid;
            this.spTelefonosTableAdapter.Fill(this.desarrolloDataSet1.spTelefonos, label2.Text);
        }
        private void spTelefonosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow grilla in spTelefonosDataGridView.Rows)
            { 
            string nombre;

            if (grilla.Cells[2].Selected)
                {
                    try
                    {
                        // procedimetos que elimina un telefono ya existente en el sistema
                        nombre = spTelefonosDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        eliminar.spTelefono_eliminar(nombre);
                        this.spTelefonosTableAdapter.Fill(this.desarrolloDataSet1.spTelefonos, label2.Text);
                    }
                    catch (SqlException)
                    { }
                
            }
            }
        }
    }
}
