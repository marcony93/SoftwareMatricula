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
<<<<<<< HEAD
        QueriesTableAdapter Insertar = new QueriesTableAdapter();
        public static InsertarMaestro VentanaNuevoMaestro = new InsertarMaestro();
=======
        //Variable para llamar los procedimientos que alteran la base de datos (modificar, eliminar, etc)
        QueriesTableAdapter QTA = new QueriesTableAdapter();
       public static InsertarMaestro VentanaNuevoMaestro = new InsertarMaestro();
>>>>>>> origin/master
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
<<<<<<< HEAD
            LogIn.NumerosConMensaje(textBox1, errorProvider1);
            LogIn.ValorMaximoDeCaja(textBox1, 13, errorProvider1);
            if ((textBox2.Text == "" || textBox1.Text == "" || textBox4.Text == ""))
                button1.Enabled = false;
            else
                button1.Enabled = true;
            if (Convert.ToInt32(textBox1.Text.Length.ToString()) > 0)
                label13.Text = textBox1.Text;
=======
            //Esta validacion permite solo ingresar numeros
            LogIn.NumerosConMensaje(textBox1,errorProvider1);
            //Esta validacion permite que la caja de texto tenga un maximo de caracteres, si se pasa muetra mensaje
            LogIn.ValorMaximoDeCaja(textBox1, 13, errorProvider1);
            // esta decicion nos permite validar que si la identidad, el nombre estan vacios no habilitar el boton
             if((textBox2.Text=="" || textBox1.Text=="" || textBox4.Text==""))
                 button1.Enabled=false;
>>>>>>> origin/master
            else
                label13.Text = "";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Esta validacion permite solo ingresar numeros
            LogIn.SoloLetrasConMensaje(textBox2, errorProvider1);
            //Esta validacion permite que la caja de texto tenga un maximo de caracteres, si se pasa muetra mensaje
            LogIn.ValorMaximoDeCaja(textBox2, 15, errorProvider1);
<<<<<<< HEAD
            if ((textBox2.Text == "" || textBox1.Text == "" || textBox4.Text == "")) button1.Enabled = false;
=======
            // esta decicion nos permite validar que si la identidad, el nombre estan vacios no habilitar el boton
            if((textBox2.Text=="" || textBox1.Text=="" || textBox4.Text==""))button1.Enabled=false;
>>>>>>> origin/master
            else
                button1.Enabled = true;
            if (Convert.ToInt32(textBox2.Text.Length.ToString()) > 0)
            {
                //validacion que permite agregar una mayuscula al inicio de la caja de texto
                if (textBox2.Text != "")
                    label12.Text = (textBox2.Text.Substring(0, 1) + textBox4.Text).ToString().ToLower();
<<<<<<< HEAD
            }
=======
            }        
>>>>>>> origin/master
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
<<<<<<< HEAD
                button1.Enabled = true;
            if (Convert.ToInt32(textBox2.Text.Length.ToString()) > 0)
            {
                if (textBox2.Text != "")
                    label12.Text = (textBox2.Text.Substring(0, 1) + textBox4.Text).ToString().ToLower();
            }

=======
                button1.Enabled=true;
             if (Convert.ToInt32(textBox2.Text.Length.ToString()) > 0)
             {
                 //validacion que permite agregar una mayuscula al inicio de la caja de texto
                 if(textBox2.Text!="")
                     label12.Text = (textBox2.Text.Substring(0, 1) + textBox4.Text).ToString().ToLower();
             }
>>>>>>> origin/master
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
<<<<<<< HEAD
            if (CorreoValido(textBox7.Text) == false)
=======
            //esta decicion me me permite saber si la caja de texto en valida
            if(CorreoValido(textBox7.Text)==false)
>>>>>>> origin/master
            {
                //muestra un mensaje para decirle al ususario que el correo no es valido
                MessageBox.Show("Ingrese un correo valido");
                errorProvider1.SetError(textBox7, "Ingrese un correo valido");
            }
            else
            {
                try
                {
<<<<<<< HEAD
                    Insertar.insertarnuevomaestro(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, dateTimePicker1.Value, textBox7.Text, textBox6.Text, spSexoComboBox.SelectedIndex + 1, label12.Text, label13.Text, 2, "0");
=======
                    //disparador de un prcedimiento almacenado que inserta un nuevo maestro
                    QTA.insertarnuevomaestro(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, dateTimePicker1.Value, textBox7.Text, textBox6.Text, spSexoComboBox.SelectedIndex + 1, label12.Text, label13.Text, 2, "0");
>>>>>>> origin/master
                    MessageBox.Show("Se ha Guardado con Exito");
                }
                catch (SqlException)
                {
                    MessageBox.Show("El Maestro no ha sido guardado");
                }
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //decicion de las fechas futuras
            int actual = 0;
            int ingresado = 0;
<<<<<<< HEAD
            ingresado = Convert.ToInt32(dateTimePicker1.Value.Year) + Convert.ToInt32(dateTimePicker1.Value.Month) + Convert.ToInt32(dateTimePicker1.Value.Day);
            actual = Convert.ToInt32(DateTime.Today.Year) + Convert.ToInt32(DateTime.Today.Month) + Convert.ToInt32(DateTime.Today.Day);
            if (ingresado > actual)
            {
                MessageBox.Show("Ingrese una fecha Valida");
                dateTimePicker1.Value = DateTime.Today;
            }
            int edad;
            try
            {
                edad = (DateTime.Today.AddTicks(-dateTimePicker1.Value.Ticks).Year - 1);
                if (edad< 18)
                {
                    MessageBox.Show("es menor de edad");
                    dateTimePicker1.ResetText();
                }
            }
            catch (Exception)
            {  }
        }
=======
            ingresado=Convert.ToInt32(dateTimePicker1.Value.Year) + Convert.ToInt32(dateTimePicker1.Value.Month) + Convert.ToInt32(dateTimePicker1.Value.Day);
           actual= Convert.ToInt32(DateTime.Today.Year) + Convert.ToInt32(DateTime.Today.Month) + Convert.ToInt32(DateTime.Today.Day);
           if (ingresado > actual)
           {
               MessageBox.Show("Ingrese una fecha Valida");
               dateTimePicker1.Value = DateTime.Today;
           }
           int a;
           try
           {
               a = (DateTime.Today.AddTicks(-dateTimePicker1.Value.Ticks).Year - 1);
               if (a < 18)
               {
                   MessageBox.Show("es menor de edad");
                   dateTimePicker1.ResetText();
               }
               }
           catch (Exception)
           {

           }
        }

>>>>>>> origin/master
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
<<<<<<< HEAD
        private Boolean CorreoValido(String correo)
=======
     private Boolean CorreoValido(String correo)
>>>>>>> origin/master
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
<<<<<<< HEAD
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            ValidarEspacios(textBox7, errorProvider1);
        }
=======

       private void textBox7_TextChanged(object sender, EventArgs e)
       {
           ValidarEspacios(textBox7, errorProvider1);
       }
>>>>>>> origin/master
    }
}

