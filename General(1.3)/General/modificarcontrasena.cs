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
using General.DataSetmoisesTableAdapters;

namespace General
{   
    public partial class modificarcontrasena : Form
       
    {
        QueriesTableAdapter QTA = new QueriesTableAdapter();
        public modificarcontrasena()
        {
            InitializeComponent();
        }

        private void modificarcontrasena_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                QTA.PScontra(textBox1.Text, textBox2.Text, textBox3.Text);
                MessageBox.Show("se modifico con exito");
            }
            catch (SqlException)
            {

                MessageBox.Show("No se pudo modificar la contraseña");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LogIn.SoloLetrasConMensaje(textBox1, errorProvider1);
        }
    }
}
