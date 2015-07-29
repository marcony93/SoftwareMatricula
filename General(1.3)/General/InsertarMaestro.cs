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
using System.Text.RegularExpressions;

using General.desarrolloDataSetmchaTableAdapters;

namespace General
{
    public partial class InsertarMaestro : Form
    {
        //Variable para llamar los procedimientos que alteran la Base de datos (modificar, eliminar, etc)
        QueriesTableAdapter QTA = new QueriesTableAdapter();
        public static InsertarMaestro VentanaNuevoMaestro = new InsertarMaestro();
        public InsertarMaestro()
        {
            InitializeComponent();
        }

        private void InsertarMaestro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.spSexo' Puede moverla o quitarla según sea necesario.
            this.spSexoTableAdapter.Fill(this.desarrolloDataSet.spSexo);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Esta validacion permite solo ingresar numeros
            LogIn.NumerosConMensaje(textBox1, errorProvider1);
            //Esta validacion permite que la caja de texto tenga un maximo de caracteres, si se pasa muetra mensaje
            LogIn.ValorMaximoDeCaja(textBox1, 13, errorProvider1);
            // esta decicion nos permite validar que si la identidad, el nombre estan vacios no habilitar el boton
            if ((textBox2.Text == "" || textBox1.Text == "" || textBox4.Text == ""))
                button1.Enabled = false;
            else
                button1.Enabled = true;
            if (Convert.ToInt32(textBox1.Text.Length.ToString()) > 0)
                label13.Text = textBox1.Text;
            else
                label13.Text = "";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Esta validacion permite solo ingresar numeros
            LogIn.SoloLetrasConMensaje(textBox2, errorProvider1);
            //Esta validacion permite que la caja de texto tenga un maximo de caracteres, si se pasa muetra mensaje
            LogIn.ValorMaximoDeCaja(textBox2, 15, errorProvider1);
            // esta decicion nos permite validar que si la identidad, el nombre estan vacios no habilitar el boton
            if ((textBox2.Text == "" || textBox1.Text == "" || textBox4.Text == "")) button1.Enabled = false;
            else
                button1.Enabled = true;
            if (Convert.ToInt32(textBox2.Text.Length.ToString()) > 0)
            {
                //validacion que permite agregar una mayuscula al inicio de la caja de texto
                if (textBox2.Text != "")
                    label12.Text = (textBox2.Text.Substring(0, 1) + textBox4.Text).ToString().ToLower();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Esta validacion permite solo ingresar numeros
            LogIn.SoloLetrasConMensaje(textBox3, errorProvider1);
            //Esta validacion permite que la caja de texto tenga un maximo de caracteres, si se pasa muetra mensaje
            LogIn.ValorMaximoDeCaja(textBox3, 15, errorProvider1);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Esta validacion permite solo ingresar numeros
            LogIn.SoloLetrasConMensaje(textBox4, errorProvider1);
            //Esta validacion permite que la caja de texto tenga un maximo de caracteres, si se pasa muetra mensaje
            LogIn.ValorMaximoDeCaja(textBox4, 15, errorProvider1);
            if ((textBox2.Text == "" || textBox1.Text == "" || textBox4.Text == "")) button1.Enabled = false;
            else
                button1.Enabled = true;
            if (Convert.ToInt32(textBox2.Text.Length.ToString()) > 0)
            {
                //validacion que permite agregar una mayuscula al inicio de la caja de texto
                if (textBox2.Text != "")
                    label12.Text = (textBox2.Text.Substring(0, 1) + textBox4.Text).ToString().ToLower();
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //Esta validacion permite solo ingresar numeros
            LogIn.SoloLetrasConMensaje(textBox5, errorProvider1);
            //Esta validacion permite que la caja de texto tenga un maximo de caracteres, si se pasa muetra mensaje
            LogIn.ValorMaximoDeCaja(textBox5, 15, errorProvider1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //esta desicion me me permite saber si la caja de texto en valida
            if (CorreoValido(textBox7.Text) == false)
            {
                //muestra un mensaje para decirle al ususario que el correo no es valido
                MessageBox.Show("Ingrese un correo valido");
                errorProvider1.SetError(textBox7, "Ingrese un correo valido");
            }
            else
            {
                int dias = DateTime.Now.Date.Subtract(dateTimePicker1.Value.Date).Days;
                if (dias < 0)
                {
                    MessageBox.Show("la fecha seleccionada es igual o mayor al dia actual");
                }
                int años = dias / 365;
                if (años < 18)
                {
                    MessageBox.Show("debe ser mayor a 18 años");
                }
                else
                {
                    try
                    {
                        //disparador de un prcedimiento almacenado que inserta un nuevo maestro
                        QTA.insertarnuevomaestro(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, dateTimePicker1.Value, textBox7.Text, textBox6.Text, spSexoComboBox.SelectedIndex + 1, label12.Text, label13.Text, 2, "0");
                        MessageBox.Show("Se ha Guardado con Exito");
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("El Maestro no ha sido guardado");
                    }
                }
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esto es para que la primera letra sea mayuscula
            if (textBox2.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                //esto es para que la primera letra sea mayuscula
                if (textBox2.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esto es para que la primera letra sea mayuscula
            if (textBox3.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                //esto es para que la primera letra sea mayuscula
                if (textBox3.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esto es para que la primera letra sea mayuscula
            if (textBox4.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                //esto es para que la primera letra sea mayuscula
                if (textBox4.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esto es para que la primera letra sea mayuscula
            if (textBox5.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                //esto es para que la primera letra sea mayuscula
                if (textBox5.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private Boolean CorreoValido(String correo)
        {
            //funcion para correo valido
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, expresion))
            {
                if (Regex.Replace(correo, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static void ValidarEspacios(TextBox Cajatexto, ErrorProvider error)
        {
            //funcion que permitira que no se agreguen espacios
            if (Cajatexto.Text.Trim() != Cajatexto.Text)
            {
                error.SetError(Cajatexto, "No se aceptan espacios");
                Cajatexto.Text = Cajatexto.Text.Remove(Cajatexto.TextLength - 1);
                Cajatexto.SelectionStart = Cajatexto.TextLength;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            ValidarEspacios(textBox7, errorProvider1);
        }
    }
}
