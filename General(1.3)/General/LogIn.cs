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
        //FUNCION QUE PERMITE AGREGAR SOLO 13 NUMEROS 
        public static int solo13Numeros(TextBox parametro)
        {
            //INICIA LA VARIABLE QUE IDENTIFICARA QUE TIPO DE VALIDACION SERA
            int valor = 0;
            double esNumero;
            if (!string.IsNullOrEmpty(parametro.Text))
            {
                //VERIFICA SI EL PARAMETRO ES NULLO
                if (!double.TryParse(parametro.Text, out esNumero))
                {
                    valor = 1;
                    parametro.Text = parametro.Text.Remove(parametro.TextLength - 1);
                    parametro.SelectionStart = parametro.TextLength;
                }
                //VERIFICA SI EL PARAMETRO ES MAYOR A 13 DIGITOS
                else if (Convert.ToInt32(parametro.TextLength) > 13)
                {
                    valor = 4;
                    parametro.Text = parametro.Text.Remove(parametro.TextLength - 1);
                    parametro.SelectionStart = parametro.TextLength;
                }
                //VERIFICA SI EL PARAMETRO ES ALFANUMERICO
                else if (!IsAlphaNumeric(parametro.Text))
                {
                    valor = 3;
                    parametro.Text = parametro.Text.Remove(parametro.TextLength - 1);
                    parametro.SelectionStart = parametro.TextLength;
                }
                //VERIFICA SI EL VALOR ES MENOR O IGUAL A 13 DIGITOS
                else if (Convert.ToInt32(parametro.TextLength) == 13)
                    parametro.BackColor = Color.White;
                else if (Convert.ToInt32(parametro.TextLength) < 13)
                    valor = 2;
            }
            else
                valor = 0;
            //RETORNA EL VALOR DEL ERROR,  EN CASO CONTRARIO RETORNA 0
            return valor;
        }
        //FUNCION QUE PERMITIRA IDENTIFICAR QUE TIPO DE ERROR SE DIO EN LA FUNCION SOLO13NUMEROS 
        //IDENTIFICANDO EL PROBLEMA SE MESTRA UN ERROR EN UN ERRORPROVIDER
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
        //FUNCION QUE  PERMITE SABER SI ES ALFANUMERICO LA VARIABLE QUE SE LE ESTA MANDANDO
        public static bool IsAlphaNumeric(String strToCheck)
        {
            Regex objAlphaNumericPattern = new Regex("[^a-zA-Z0-9]");
            return !objAlphaNumericPattern.IsMatch(strToCheck);
        }
        //FUNCION QUE  PERMITE IDENTIFICAR SI LA VARIABLE USA SOLO LETRAS
        public static bool Identificarsololetra(String strToCheck)
        {
            Regex objAlphaNumericPattern = new Regex("[^a-zA-Z]");
            return !objAlphaNumericPattern.IsMatch(strToCheck);
        }
        //VARIABLE QUE  PERMITE IDENTIFICAR SI LA VARIABLE USA SOLO LETRAS, EN CASO CONTRARIO
        //DISPARA UN ERROR PROVIDER PARA MOSTRARLE AL USUARIO
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
        //FUNCION QUE  PERMITE IDENTIFICAR SI LA VARIABLE QUE SE LE MANDA SOLO SON NUMEROS
        //Y LETRAS, EN CASO CONTRARIO DISPARA UN ERRORPROVIDER
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
        //FUNCION QUE SIRVE PARA IDENTIFICAR SI EL USUARIO INGRESO TODOS LOS VALORES
        //EN CASO CONTRARIO SE LE MUESTRA UN MENSAJE DE ERROR 
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
            //RETORNA 1 SI LOS CAMPOS SON DIFERENTES DE VACIO
            if (t1.Text != "" && t2.Text != "")
                retorno = 1;

            return retorno;
        }
        //FUNCION QUE SIRVE PARA VALIDAR EL VALOR MAXIMO DE UNA CAJA DE TEXTO
        //SI SE PASA DEL VALOR SE LE MANDA UN ERRORPROVIDER INDICANDOLE QUE NO PUEDE EXCEDER 
        //LOS CARACTERES MAXIMOS DE LA CAJA
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
        //EVENTO DE LA CAJA QUE VALIDA QUE SOLO SEAN LETRAS Y SU VALOR MAXIMO
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SoloLetrasConMensaje(textBox1, errorProvider1);
            ValorMaximoDeCaja(textBox1, 25, errorProvider1);
        }
        //EVENTO DE LA CAJA QUE VALIDA QUE SOLO SEAN LETRAS Y SU VALOR MAXIMO
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SololetrasyNumerosConMensaje(textBox2, errorProvider1);
            ValorMaximoDeCaja(textBox2, 25, errorProvider1);
        }
        //EVENTO DEL BOTON QUE MANDARA LOS PARAMETROS INGRESADOS EN LAS CAJAS DE TEXTO
        private void button1_Click_1(object sender, EventArgs e)
        {
            //GUARDA EN LA VARIABLE EL USUARIO DEL PROFESOR
            usuarioprofesor = textBox1.Text;
            //PROCEDIMEITO ALMACENADO QUE ME RETORNARA SI EL PROFESOR TIENE BLOQUEADA LA CUENTA
            this.usuarioBloqueadoTableAdapter.Fill(this.desarrolloDataSet.UsuarioBloqueado, textBox1.Text);
            //SI RETORNA UN 1 ESO QUIERE DECIR QUE EL MAESTRO ESTA BLOQUEADO
            if (mstroBlocLabel1.Text == "1")
            {
                //NOS MANDA A LA VENTANA DE USUSARIO BLOQUEADO
                LogIn_Bloqueado ventana = new LogIn_Bloqueado();
                ventana.Show();

                this.Hide();
            }
            //SI NO ESTA BLOQUEADO VALIDA QUE LOS CAMPOS VENGAN LLENOS
            else if (validarboton(textBox1, textBox2, errorProvider1) == 1)
            {
                try
                {
                    //PROCEDIMIENTO ALMACENADO QUE AUTENTIFICA EL USUARIO Y LA CONTRASEñA
                    this.autentificacionTableAdapter.Fill(this.desarrolloDataSet.autentificacion, textBox1.Text, textBox2.Text);
                    //SWITCH QUE DECIDE SI EL USUARIO ES EL ADMINISTRADOR O UN PROFESOR
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
                //DECICION QUE IDENTIFICA SI SE HA EQUIVOCADO 5 VECES 
                //BLQUEARA EL USUARIO
                if (intentos == 5)
                {
                    //PROCEDIMIENTO QUE BLOQUEA EL USUARIO
                    cambio.cambiarbloqueopositivo(usuarioprofesor);
                }
            }
        }
        private void LogIn_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.Alumno' Puede moverla o quitarla según sea necesario.
            intentos = 0;
        }
    }
}
