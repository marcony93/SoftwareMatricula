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
        //iniciamos la variable para acceder a los procedimientos almacenados
        QueriesTableAdapter actualizar = new QueriesTableAdapter();
        public static int contador = 0;
        public modificarmaestro()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //contador que sirve para validar el boton de guardar
            contador++;
            //si el contador es 1 habilita los campos que se pueden modificar
            if (contador == 1)
            {
                mstroEmailTextBox.Enabled = true;
                mstroDireccionTextBox.Enabled = true;
                mstroUsuTextBox.Enabled = true;
                button1.Text = "guardar";
            }
                //si el contador es 2 ejecuta el procedimiento almacenado
                //que guardara los cambios y deshabilita las cajas de texto
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
            //crea una instancia de la ventana buscar maestro
            //muestra la ventana para buscar un profesor
            Form buscarmaestro = new buscarmaestro();
            buscarmaestro.Show();
            buscarmaestro.MdiParent = VentanaGeneralVistaSecretaria.VentanaSecretaria;
            buscarmaestro.WindowState = FormWindowState.Maximized;
            buscarmaestro.BringToFront();
        }
    }
}
