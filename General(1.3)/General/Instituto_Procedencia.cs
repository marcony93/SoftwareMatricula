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
    public partial class Instituto_Procedencia : Form
    {
        QueriesTableAdapter agregar = new QueriesTableAdapter();
        public Instituto_Procedencia()
        {
            InitializeComponent();
        }
        private void Instituto_Procedencia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.SpMostrarInstituto.
            this.spMostrarInstitutoTableAdapter.Fill(this.desarrolloDataSet1.SpMostrarInstituto);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //funcion que  permite validar el valor maximo de la caja de texto
            LogIn.ValorMaximoDeCaja(textBox1, 50, errorProvider1);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //funcion que  permite validar el valor maximo de la caja de texto
            LogIn.ValorMaximoDeCaja(textBox1, 50, errorProvider1);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion que  permite poner la primera letra en mayuscula 
            //las demas en minuscula
            if (textBox1.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox1.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion que  permite poner la primera letra en mayuscula 
            //las demas en minuscula
            if (textBox2.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox2.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //validacion que verifica si la caja de texto es nula o vacia
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    //procedimiento almacenado que inserta el instituto
                    agregar.spInstituo_agregar2(textBox1.Text, textBox2.Text);
                    this.spMostrarInstitutoTableAdapter.Fill(this.desarrolloDataSet1.SpMostrarInstituto);
                }
                else
                {
                    //mensa de error si ingresa un instituto equivocado
                    MessageBox.Show("Tiene que Ingresar un instituto de procedencia");
                }
            }
            catch (SqlException)
            { }
        }
    }
}

