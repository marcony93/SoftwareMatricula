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

      

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text.Trim() == String.Empty)
                errorProvider1.SetError(textBox2, "No se permiten campos vacíos");
            else
                errorProvider1.SetError(textBox2, "");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==32)
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.TextLength - 1);
                textBox2.SelectionStart = textBox2.TextLength;
                errorProvider1.SetError(textBox2, "No se acepta espacios");
            }
                
            
        }

        

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                textBox3.Text = textBox3.Text.Remove(textBox3.TextLength - 1);
                textBox3.SelectionStart = textBox3.TextLength;
                errorProvider1.SetError(textBox3, "No se acepta espacios");
            }
        }
    }
}
