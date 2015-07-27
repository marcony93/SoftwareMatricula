using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using General.desarrolloDataSetTableAdapters;
namespace General
{
    public partial class LogIn : Form
    {
        public static string usuarioprofesor = "";
        QueriesTableAdapter cambio = new QueriesTableAdapter();
        public static int intentos;

        public LogIn()
        {
            InitializeComponent();
        }
        //FUNCIONES NECESARIAS
        public static int solo13Numeros(TextBox parametro)
        {
            int valor = 0;
            double esNumero;
            if (!string.IsNullOrEmpty(parametro.Text))
            {
                if (!double.TryParse(parametro.Text, out esNumero))
                {
                    valor = 1;
                    parametro.Text = parametro.Text.Remove(parametro.TextLength - 1);
                    parametro.SelectionStart = parametro.TextLength;
                }
                else if (Convert.ToInt32(parametro.TextLength) > 13)
                {
                    valor = 4;
                    parametro.Text = parametro.Text.Remove(parametro.TextLength - 1);
                    parametro.SelectionStart = parametro.TextLength;
                }
                else if (!IsAlphaNumeric(parametro.Text))
                {
                    valor = 3;
                    parametro.Text = parametro.Text.Remove(parametro.TextLength - 1);
                    parametro.SelectionStart = parametro.TextLength;
                }
                else if (Convert.ToInt32(parametro.TextLength) == 13)
                    parametro.BackColor = Color.White;
                else if (Convert.ToInt32(parametro.TextLength) < 13)
                    valor = 2;
            }
            else
                valor = 0;
            return valor;
        }
        public static void NumerosConMensaje(TextBox para, ErrorProvider error)
        {
            switch (solo13Numeros(para))
            {
                case 1:
                    error.SetError(para, "Solo acepta valores numericos");
                    break;
                case 3:
                    error.SetError(para, "No se aceptan caracteres especiales en este campo ");
                    break;
                case 4:
                    error.SetError(para, "Solo se aceptan 13 valores");
                    break;
                default:
                    error.SetError(para, "");
                    break;
            }
        }
        public static bool IsAlphaNumeric(String strToCheck)
        {
            Regex objAlphaNumericPattern = new Regex("[^a-zA-Z0-9]");
            return !objAlphaNumericPattern.IsMatch(strToCheck);
        }
        public static bool Identificarsololetra(String strToCheck)
        {
            Regex objAlphaNumericPattern = new Regex("[^a-zA-Z]");
            return !objAlphaNumericPattern.IsMatch(strToCheck);
        }
        public static void SoloLetrasConMensaje(TextBox valor, ErrorProvider error)
        {
            int x = 0;
            if (!Identificarsololetra(valor.Text))
            {
                valor.Text = valor.Text.Remove(valor.TextLength - 1);
                valor.SelectionStart = valor.TextLength;
                while (x == 0)
                {
                    error.SetError(valor, "Solo se aceptan letras");
                    break;
                }
            }
            else
                error.SetError(valor, "");
        }
        public static void SololetrasyNumerosConMensaje(TextBox valor, ErrorProvider error)
        {
            int caracter = 0;
            if (!IsAlphaNumeric(valor.Text))
            {
                while (caracter == 0)
                {
                    valor.Text = valor.Text.Remove(valor.TextLength - 1);
                    valor.SelectionStart = valor.TextLength;
                    error.SetError(valor, "No se aceptan caracteres especiales en este campo ");
                    break;
                }
            }
            else
                error.SetError(valor, "");
        }
        public static int validarboton(TextBox t1, TextBox t2, ErrorProvider error)
        {
            int retorno = 0;
            if (t1.Text != "" && t2.Text == "")
                error.SetError(t2, "Ingrese la Contraseña");
            if (t1.Text == "" && t2.Text != "")
                error.SetError(t1, "Ingrese el Usuario");
            if (t1.Text == "" && t2.Text == "")
            {
                error.SetError(t1, "Ingrese el Usuario");
                error.SetError(t2, "Ingrese la Contraseña");
            }
            if (t1.Text != "" && t2.Text != "")
                retorno = 1;

            return retorno;
        }
        public static void ValorMaximoDeCaja(TextBox caja, int maximo, ErrorProvider mensaje)
        {
            if (caja.TextLength > maximo)
            {
                caja.Text = caja.Text.Remove(caja.TextLength - 1);
                caja.SelectionStart = caja.TextLength;
                mensaje.SetError(caja, "Acepta un maximo de " + maximo + " valores");
            }
        }
        //FINALIZACION DE FUNCIONES
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SoloLetrasConMensaje(textBox1, errorProvider1);
            ValorMaximoDeCaja(textBox1, 25, errorProvider1);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SololetrasyNumerosConMensaje(textBox2, errorProvider1);
            ValorMaximoDeCaja(textBox2, 25, errorProvider1);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            usuarioprofesor = textBox1.Text;
            this.usuarioBloqueadoTableAdapter.Fill(this.desarrolloDataSet.UsuarioBloqueado, textBox1.Text);
            if (mstroBlocLabel1.Text == "1")
            {
                LogIn_Bloqueado ventana = new LogIn_Bloqueado();
                ventana.Show();

                this.Hide();
            }
            else if (validarboton(textBox1, textBox2, errorProvider1) == 1)
            {
                try
                {
                    this.autentificacionTableAdapter.Fill(this.desarrolloDataSet.autentificacion, textBox1.Text, textBox2.Text);
                    switch (mstroTipoLabel1.Text)
                    {
                        case "2":
                            Ventana_General_Vista_Maestro.VentanaMaestro.Show();
                            this.Hide();
                            break;
                        case "1":
                            VentanaGeneralVistaSecretaria.VentanaSecretaria.Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("No existe el Usuario o contraseña");
                            intentos++;
                            break;
                    }
                }
                catch (SqlException)
                { }
                if (intentos == 5)
                {
                    cambio.cambiarbloqueopositivo(usuarioprofesor);
                }
            }
        }
        private void LogIn_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.Alumno' Puede moverla o quitarla según sea necesario.
            intentos = 0;
        }
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            { }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
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
    }
}
