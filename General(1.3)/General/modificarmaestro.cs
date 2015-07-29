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
using General.desarrolloDataSetmchaTableAdapters;
namespace General
{

    public partial class modificarmaestro : Form
    {
        QueriesTableAdapter actualizar = new QueriesTableAdapter();
        public static int contador = 0;
        public modificarmaestro()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            contador++;
            if (contador == 1)
            {
                mstroEmailTextBox.Enabled = true;
                mstroDireccionTextBox.Enabled = true;
                mstroUsuTextBox.Enabled = true;
                button1.Text = "guardar";
            }
            else if (contador == 2)
            {
                    try
                    {
                        actualizar.psmodificarmaestro(mstroIdTextBox.Text, mstroEmailTextBox.Text, mstroDireccionTextBox.Text, mstroUsuTextBox.Text);
                        mstroEmailTextBox.Enabled = false;
                        mstroDireccionTextBox.Enabled = false;
                        mstroUsuTextBox.Enabled = false;
                        textBox1.Enabled = false;
                        mstroApellido2TextBox1.Enabled = false;
                        button1.Text = "modificar";
                        MessageBox.Show("se actualizo con exito");
                        contador = 0;
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Los Datos no fueron modificados , el usuario no existe ");
                    }
                }
            else if (contador == 0)
            { }
        }
        private void modificarmaestro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetmcha.Maestro' Puede moverla o quitarla según sea necesario.
            //this.maestroTableAdapter.Fill(this.desarrolloDataSetmcha.Maestro);
            // TODO: esta línea de código carga datos en la tabla 'dataSetmoises.Sexo' Puede moverla o quitarla según sea necesario.
            this.sexoTableAdapter.Fill(this.dataSetmoises.Sexo);
            this.selectProfesorTableAdapter.Fill(this.desarrolloDataSetmcha.SelectProfesor, buscarmaestro.Idmaestro.ToString());
            //muestra en la caja de texto del sexo que tipo de sexo es.
            if(sexo_SexIdLabel1.Text == "1")
            {
                textBox1.Text = "Masculino";
            }
            else
            {
                textBox1.Text = "Femenino";
            }

            textBox1.Enabled = false;
            mstroApellido2TextBox1.Enabled = false;
            
        }
        private void mstroUsuTextBox_TextChanged(object sender, EventArgs e)
        {
            LogIn.SoloLetrasConMensaje(mstroUsuTextBox, errorProvider1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form buscarmaestro = new buscarmaestro();
            buscarmaestro.Show();
            buscarmaestro.MdiParent = VentanaGeneralVistaSecretaria.VentanaSecretaria;
            buscarmaestro.WindowState = FormWindowState.Maximized;
            buscarmaestro.BringToFront();
        }
        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            { }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            { }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

     
    }
}
