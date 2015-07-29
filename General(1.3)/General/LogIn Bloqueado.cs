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
    public partial class LogIn_Bloqueado : Form
    {
        //variable que se utilizara para acceder a los procedimientos almacenados
        QueriesTableAdapter ejecutar = new QueriesTableAdapter();
        public LogIn_Bloqueado()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //validacion que permite desbloquear a cualquier usuario con el super administrador
            if (textBox1.Text == "sa" && textBox2.Text == "root")
            {
                //crea una instancia de la ventana login
                LogIn Ventana = new LogIn();
                //ejecuta el procedimeinto que cambia el estado del profesor
                ejecutar.cambiarbloqueo(LogIn.usuarioprofesor);
                Ventana.Show();
                this.Close();
            }
                //si el procedimiento devuelve un 1 ejecuta el procedimiento
            else if (LogIn.validarboton(textBox1, textBox2, errorProvider1) == 1)
            {
                try
                {
                    //procedimietno de autentificacion
                    this.autentificacionTableAdapter.Fill(this.desarrolloDataSet.autentificacion, textBox1.Text, textBox2.Text);
                    switch (mstroTipoLabel1.Text)
                    {
                            //si la opcion es 1 cambia el bloqueo del profesor
                        case "1":
                            LogIn Ventana = new LogIn();
                            ejecutar.cambiarbloqueo(LogIn.usuarioprofesor);
                            Ventana.Show();
                            this.Close();
                            break;
                        default:
                            MessageBox.Show("Ingrese una cuenta correcta");
                            break;
                    }
                }
                catch (SqlException)
                { }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //validaciones de solo letras y valor maximo
            LogIn.SoloLetrasConMensaje(textBox1, errorProvider1);
            LogIn.ValorMaximoDeCaja(textBox1, 25, errorProvider1);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //validaciones de solo letras y valor maximo
            LogIn.SololetrasyNumerosConMensaje(textBox2, errorProvider1);
            LogIn.ValorMaximoDeCaja(textBox2, 25, errorProvider1);
        }
    }
}

