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
    public partial class FichaMatricula : Form
    {
        public static int actual = 0;
        public static int ingresado = 0;
        public static int a = 0;
        QueriesTableAdapter Agregar = new QueriesTableAdapter();
        QueriesTableAdapter eliminar = new QueriesTableAdapter();
        string alumnoid;
        string Nombre1;
        string Nombre2;
        string Nombre3;
        string Nombre4;
        DateTime FechaNacimiento;
        int departamento;
        string direccion;
        string lugarTrabajo;
        string estadotrabajo;
        string horariotrabajo;
        int sexo;
        int estadocivil;
        int nacionalidad;
        int tiposangre;
        string encargado;
        string encargadoNombre1;
        string encargadoNombre2;
        string encargadoNombre3;
        string encargadoNombre4;
        string encargadoId;
        DateTime encargadoFechaNacimiento;
        int Encargadosexo;
        int EncargadoOcupacion;
        int relacion;
        int estatadoMatricula;
        int instituto;
        int modaliad;
        int curso;
        string seccion;
        public FichaMatricula()
        {
            InitializeComponent();
        }
        public static string idtelefono;
        private void FichaMatricula_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.Documentos'.
            this.documentosTableAdapter.Fill(this.desarrolloDataSet1.Documentos);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spModalidades'.
            this.spModalidadesTableAdapter.Fill(this.desarrolloDataSet1.spModalidades);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.SpEstadoMatricula'.
            this.spEstadoMatriculaTableAdapter.Fill(this.desarrolloDataSet1.SpEstadoMatricula);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.TipoSangre'.
            this.tipoSangreTableAdapter.Fill(this.desarrolloDataSet1.TipoSangre);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spDepartamentos'.
            this.spDepartamentosTableAdapter1.Fill(this.desarrolloDataSet1.spDepartamentos);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spModalidad'.
            //  this.spModalidadTableAdapter.Fill(this.desarrolloDataSet1.spModalidad);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spDocumentos'.
            this.spDocumentosTableAdapter.Fill(this.desarrolloDataSet1.spDocumentos);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spLugarInstituto'.
            this.spLugarInstitutoTableAdapter.Fill(this.desarrolloDataSet1.spLugarInstituto);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.SpMostrarInstituto'.
            this.spMostrarInstitutoTableAdapter.Fill(this.desarrolloDataSet1.SpMostrarInstituto);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.spSexo'.
            this.spSexoTableAdapter.Fill(this.desarrolloDataSet.spSexo);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.spRelacion'.
            this.spRelacionTableAdapter.Fill(this.desarrolloDataSet.spRelacion);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.SpOcupacion'.
            this.spOcupacionTableAdapter.Fill(this.desarrolloDataSet.SpOcupacion);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.spNacionalidad'.
            this.spNacionalidadTableAdapter.Fill(this.desarrolloDataSet.spNacionalidad);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.spEstadoCivil'.
            this.spEstadoCivilTableAdapter.Fill(this.desarrolloDataSet.spEstadoCivil);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.Sexo'.
            this.sexoTableAdapter.Fill(this.desarrolloDataSet.Sexo);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.spDepartamentos'.
            this.spDepartamentosTableAdapter.Fill(this.desarrolloDataSet.spDepartamentos);
            label29.Visible = false;
            label30.Visible = false;
            textBox14.Visible = false;
            comboBox1.Visible = false;
            //Se nombran las pestañas de la ventana
            tabControl1.TabPages[0].Text = "Datos Personales";
            tabControl1.TabPages[1].Text = "Datos Encargado";
            tabControl1.TabPages[2].Text = "Datos Académicos";
            button4.Enabled = true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //valida que la caja de texto tenga el valor maximo de caracteres
            //valida que solo acepten letras
            LogIn.ValorMaximoDeCaja(textBox1, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(textBox1, errorProvider1);
            //guarda en la variable el valor de la caja de texto
            Nombre1 = textBox1.Text;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //valida que la caja de texto tenga el valor maximo de caracteres
            //valida que solo acepten letras
            LogIn.ValorMaximoDeCaja(textBox2, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(textBox2, errorProvider1);
            //Asigna a el label el nombre completo del alumno
            label19.Text = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text;
            //guarda en la variable el valor de la caja de texto
            Nombre2 = textBox2.Text;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //valida que la caja de texto tenga el valor maximo de caracteres
            //valida que solo acepten letras
            LogIn.ValorMaximoDeCaja(textBox3, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(textBox3, errorProvider1);
            //Asigna a el label el nombre completo del alumno
            label19.Text = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text;
            //guarda en la variable el valor de la caja de texto
            Nombre3 = textBox3.Text;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //valida que la caja de texto tenga el valor maximo de caracteres
            //valida que solo acepten letras
            LogIn.ValorMaximoDeCaja(textBox4, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(textBox4, errorProvider1);
            //Asigna a el label el nombre completo del alumno
            label19.Text = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text;
            //guarda en la variable el valor de la caja de texto
            Nombre4 = textBox4.Text;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //valida que la caja de texto tenga el valor maximo de caracteres
            //valida que solo acepten letras
            LogIn.ValorMaximoDeCaja(textBox5, 13, errorProvider1);
            LogIn.NumerosConMensaje(textBox5, errorProvider1);
            //guarda en la variable el valor de la caja de texto
            idtelefono = textBox5.Text;
            //guarda en la variable el valor de la caja de texto
            alumnoid = textBox5.Text;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DESICION QUE SIRVE PARA PONER LA PRIMERA LETRA EN MAYUSCULA
            if (textBox1.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox1.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DESICION QUE SIRVE PARA PONER LA PRIMERA LETRA EN MAYUSCULA
            //SI ES IGUAL A 0 LA PRIMERA ES MAYUSCULA
            //SI ES IGUAL MAYOR A 1 LAS DEMAS SON MINUSCULAS
            if (textBox2.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox2.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DESICION QUE SIRVE PARA PONER LA PRIMERA LETRA EN MAYUSCULA
            //SI ES IGUAL A 0 LA PRIMERA ES MAYUSCULA
            //SI ES IGUAL MAYOR A 1 LAS DEMAS SON MINUSCULAS
            if (textBox3.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox3.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DESICION QUE SIRVE PARA PONER LA PRIMERA LETRA EN MAYUSCULA
            //SI ES IGUAL A 0 LA PRIMERA ES MAYUSCULA
            //SI ES IGUAL MAYOR A 1 LAS DEMAS SON MINUSCULAS
            if (textBox4.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox4.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //CREA UNA INSTANCIA DE LA VENTANA NACIONALIDAD
            Form Nacionalidad = new Nacionalidad();
            //MUESTRA LA VENTANA NACIONALIDAD
            Nacionalidad.Show();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //SE LE ASIGNA A LA VARIABLE LA FECHA SELECCIONADA POR EL TIMEPICKER
            FechaNacimiento = dateTimePicker1.Value;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //DESICION QUE MUESTRA LOS CONTROLES DEPENDIENDO SI TRABAJA O NO
            //SI TRABAJA
            if (radioButton1.Checked)
            {
                //MUESTRA LOS CONTROLES
                label29.Visible = true;
                label30.Visible = true;
                textBox14.Visible = true;
                comboBox1.Visible = true;
                estadotrabajo = radioButton1.Text;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //SI SE SELECCIONA ESTE CHEKBOX SE OCULTAN LOS CONTROLES
            label29.Visible = false;
            label30.Visible = false;
            textBox14.Visible = false;
            comboBox1.Visible = false;
            estadotrabajo = radioButton2.Text;
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //valida que la caja de texto tenga el valor maximo de caracteres
            //valida que solo acepten letras
            LogIn.ValorMaximoDeCaja(textBox8, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(textBox8, errorProvider1);
            encargadoNombre1 = textBox8.Text;
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(textBox9, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(textBox9, errorProvider1);
            //guarda en la variable el valor de la caja de texto
            encargadoNombre2 = textBox9.Text;
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            //valida que la caja de texto tenga el valor maximo de caracteres
            //valida que solo acepten letras
            LogIn.ValorMaximoDeCaja(textBox10, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(textBox10, errorProvider1);
            //guarda en la variable el valor de la caja de texto
            encargadoNombre3 = textBox10.Text;
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            //valida que la caja de texto tenga el valor maximo de caracteres
            //valida que solo acepten letras
            LogIn.ValorMaximoDeCaja(textBox11, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(textBox11, errorProvider1);
            //guarda en la variable el valor de la caja de texto
            encargadoNombre4 = textBox11.Text;
        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            //valida que la caja de texto tenga el valor maximo de caracteres
            //valida que solo acepten letras
            LogIn.ValorMaximoDeCaja(textBox12, 13, errorProvider1);
            LogIn.NumerosConMensaje(textBox12, errorProvider1);
            encargado = textBox12.Text;
            //guarda en la variable el valor de la caja de texto
            encargadoId = textBox12.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //CREA UNA INSTANCIA DE LA VENTANA OCUPACION
            Form Ocupacion = new Ocupacion();
            //MUESTRA LA VENTANA OCUPACION
            Ocupacion.Show();
        }
        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DESICION QUE SIRVE PARA PONER LA PRIMERA LETRA EN MAYUSCULA
            //SI ES IGUAL A 0 LA PRIMERA ES MAYUSCULA
            //SI ES IGUAL MAYOR A 1 LAS DEMAS SON MINUSCULAS
            if (textBox8.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox8.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DESICION QUE SIRVE PARA PONER LA PRIMERA LETRA EN MAYUSCULA
            //SI ES IGUAL A 0 LA PRIMERA ES MAYUSCULA
            //SI ES IGUAL MAYOR A 1 LAS DEMAS SON MINUSCULAS
            if (textBox9.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox9.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DESICION QUE SIRVE PARA PONER LA PRIMERA LETRA EN MAYUSCULA
            //SI ES IGUAL A 0 LA PRIMERA ES MAYUSCULA
            //SI ES IGUAL MAYOR A 1 LAS DEMAS SON MINUSCULAS
            if (textBox10.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox10.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DESICION QUE SIRVE PARA PONER LA PRIMERA LETRA EN MAYUSCULA
            //SI ES IGUAL A 0 LA PRIMERA ES MAYUSCULA
            //SI ES IGUAL MAYOR A 1 LAS DEMAS SON MINUSCULAS
            if (textBox11.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox11.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //CREA UNA INSTANCIA DE LA VENTANA TELEFONO
            Form Telefono = new Telefono();
            //MUESTRA LA VENTANA TELEFONO
            Telefono.Show();
        }
        private void spNacionalidadComboBox_Click(object sender, EventArgs e)
        {
            //PROCEDIMIENTO QUE MANDA A TRAER LA DATA DE NACIONALIDAD
            this.spNacionalidadTableAdapter.Fill(this.desarrolloDataSet.spNacionalidad);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            //CREA UNA INSTANCIA DE LA VENTANA PARENTESCO
            Form Parentesco = new Parentesco();
            //MUESTRA LA VENTANA PARENTESCO
            Parentesco.Show();
        }
        private void spOcupacionComboBox_Click(object sender, EventArgs e)
        {
            //PROCEDIMIENTO QUE MANDA A TRAER LA DATA DE OCUPACION
            this.spOcupacionTableAdapter.Fill(this.desarrolloDataSet.SpOcupacion);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //CREA UNA INSTANCIA DE LA VENTANA INSTITUTOPROCEDENCIA
            Form Instituto_Prodencia = new Instituto_Procedencia();
            //MUESTRA LA VENTANA INSTITUTOPROCEDENCIA
            Instituto_Prodencia.Show();
        }
        private void spRelacionComboBox_Click(object sender, EventArgs e)
        {
            //PROCEDIMIENTO QUE MANDA A TRAER LA DATA DE RELACION
            this.spRelacionTableAdapter.Fill(this.desarrolloDataSet.spRelacion);
        }
        private void spMostrarInstitutoComboBox_Click(object sender, EventArgs e)
        {
            //PROCEDIMIENTO QUE MANDA A TRAER LA DATA DE INSTITUTO
            this.spMostrarInstitutoTableAdapter.Fill(this.desarrolloDataSet1.SpMostrarInstituto);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                //VALIDA QUE SI NO ESTA VACIO QUE HAGA LA ACCION
                if (!string.IsNullOrWhiteSpace(textBox15.Text))
                {
                    //PROCEDIMIENTO QUE MANDA LA DATA DE DOCUMENTOS DE LOS ALUMNOS A LA BD
                    Agregar.spDocumento_agregar(textBox15.Text);
                    this.spDocumentosTableAdapter.Fill(this.desarrolloDataSet1.spDocumentos);
                 }
            }
            catch (SqlException)
            {  }
        }
        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DESICION QUE SIRVE PARA PONER LA PRIMERA LETRA EN MAYUSCULA
            //SI ES IGUAL A 0 LA PRIMERA ES MAYUSCULA
            //SI ES IGUAL MAYOR A 1 LAS DEMAS SON MINUSCULAS
            if (textBox15.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox15.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int dias2 = DateTime.Now.Date.Subtract(dateTimePicker2.Value.Date).Days;
            if (dias2 < 0)
            {
                MessageBox.Show("la fecha seleccionada es igual o mayor al dia actual");
            }
            int años2 = dias2 / 365;
            //VALIDACION QUE VERIFICA SI ES MAYOR A 18 AñOS
            if (años2 < 18)
            {
                MessageBox.Show("El Encargado debe ser mayor a 18 años");
            }
            else
            {
                try
                {
                    //PROCEDIMIENTO QUE GUARDA LOS DATOS DEL ENCARGADO
                    Agregar.SpInsertarEncargado(encargadoId, encargadoNombre1, encargadoNombre2, 
                    encargadoNombre3, encargadoNombre4, encargadoFechaNacimiento, EncargadoOcupacion, Encargadosexo);
                }
                catch (SqlException)
                {
                    //MENSAJE DE CONFIRMACION
                    MessageBox.Show("Datos de Encargado incompletos");
                    //VARIABLE QUE AYUDA A COMPLETAR TODOS LOS INGRESOS DE LOS DATOS
                    a++;
                }
            }
            //SE LE ASIGNA A LA VARIABLE DIAS EL DIA DE HOY CON UNA FUNCNION
            int dias = DateTime.Now.Date.Subtract(dateTimePicker1.Value.Date).Days;

            //VALIDA QUE SI DIAS ES MENOR QUE 0
            if (dias < 0)
            {
                //MUESTRA EL MENSAJE DE ERROR
                MessageBox.Show("la fecha seleccionada es igual o mayor al dia actual");
            }
            else
            {
                try
                {
                    //PROCEDIMEIENTO QUE INSERTA LA INFORMACION DE LOS ALUMNOS
                    Agregar.SpInsertarAlumnoSinValidar(alumnoid, Nombre1, Nombre2, Nombre3, Nombre4, FechaNacimiento, direccion, estadotrabajo,
                                   lugarTrabajo, horariotrabajo, sexo, estadocivil, nacionalidad, tiposangre, encargado, relacion, departamento);
                }
                catch (SqlException)
                {
                    //SI NO SE HA GUARADADO LA INFORMACION SE DISPARA EL CATCH Y MUETRA MENSAJE DE ERROR
                    MessageBox.Show("Datos de Alumno incompletos");
                    //VARIABLE QUE AYUDA A COMPLETAR TODOS LOS INGRESOS DE LOS DATOS
                 a++;
                }

            }
            try
            {
                //PROCEDIMIENTO QUE AGREGA EL TELEFONO DEL ALUMNO
                Agregar.spInsertartelefonoAlumno(textBox7.Text, textBox5.Text);
            }
            catch (Exception)
            {  }
            try
            {
                //PROCEDIMIENTO QUE AGREGA LA INFORMACION DE LOS DATOS ACADEMICOS
                Agregar.spDatosAcademicos2(alumnoid, estatadoMatricula, instituto, modaliad, curso.ToString(), seccion);
                MessageBox.Show("Se inserto el Alumno con exito");
            }
            catch (SqlException)
            {
                //SI NO SE HA GUARADADO LA INFORMACION SE DISPARA EL CATCH Y MUETRA MENSAJE DE ERROR
                MessageBox.Show("Datos Academicos incompletos");
                //VARIABLE QUE AYUDA A COMPLETAR TODOS LOS INGRESOS DE LOS DATOS
                a++;
            }
            try
            {
                //PROCEDIMIENTO QUE AGREGA EL TELEFONO DEL ALUMNO
                Agregar.SpInsertarTelefonoEncargado(textBox13.Text, textBox12.Text);
            }
            catch (SqlException)
            { }
            //SI NO SE DISPARO NINGUN ERROR ANTERIRO LA VARIABLE A QUEDA EN 0
            if (a == 0)
            {
                //RECORRIDO QUE LIMPIA TODOS LOS CONTROLES DE LOS GRUPBOX
                foreach (Control ctrl in groupBox1.Controls)
                {
                    //VERIFICA SI ES UNA CAJA DE TEXTO
                    if (ctrl is TextBox)
                    {
                        TextBox text = ctrl as TextBox;
                        text.Clear();
                    }
                }
                //RECORRIDO QUE LIMPIA TODOS LOS CONTROLES DE LOS GRUPBOX
                foreach (Control ctrl in groupBox2.Controls)
                {
                    //VERIFICA SI ES UNA CAJA DE TEXTO
                    if (ctrl is TextBox)
                    {
                        TextBox text = ctrl as TextBox;
                        text.Clear();
                    }
                }
                //RECORRIDO QUE LIMPIA TODOS LOS CONTROLES DE LOS GRUPBOX
                foreach (Control ctrl in groupBox4.Controls)
                {
                    //VERIFICA SI ES UNA CAJA DE TEXTO
                    if (ctrl is TextBox)
                    {
                        TextBox text = ctrl as TextBox;
                        text.Clear();
                    }
                }
            }
        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            //GUARDA EN LA VARIABLE EL VALOR DE LA CAJA DE TEXTO
            lugarTrabajo = textBox14.Text;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GUARDA EN LA VARIABLE EL VALOR DE LA CAJA DE TEXTO
            horariotrabajo = comboBox1.Text;

        }
        private void sexoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GUARDA EN LA VARIABLE EL VALOR DE LA CAJA DE TEXTO
            sexo = Convert.ToInt32(sexoComboBox.SelectedValue);
        }
        private void spEstadoCivilComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GUARDA EN LA VARIABLE EL VALOR DE LA CAJA DE TEXTO
            estadocivil = Convert.ToInt32(spEstadoCivilComboBox.SelectedValue);
        }
        private void spNacionalidadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GUARDA EN LA VARIABLE EL VALOR DE LA CAJA DE TEXTO
            nacionalidad = Convert.ToInt32(spNacionalidadComboBox.SelectedValue);
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //GUARDA EN LA VARIABLE EL VALOR DE LA CAJA DE TEXTO
            direccion = textBox6.Text;
        }
        private void tipoSangreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GUARDA EN LA VARIABLE EL VALOR DE LA CAJA DE TEXTO
            tiposangre = Convert.ToInt32(tipoSangreComboBox.SelectedValue);
        }
        private void spRelacionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GUARDA EN LA VARIABLE EL VALOR DE LA CAJA DE TEXTO
            relacion = Convert.ToInt32(spRelacionComboBox.SelectedValue);
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //GUARDA EN LA VARIABLE EL VALOR DE LA CAJA DE TEXTO
            encargadoFechaNacimiento = dateTimePicker2.Value;
        }
        private void spRelacionComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //GUARDA EN LA VARIABLE EL VALOR DE LA CAJA DE TEXTO
            relacion = Convert.ToInt32(spRelacionComboBox.SelectedValue);
        }
        private void spSexoComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //GUARDA EN LA VARIABLE EL VALOR DE LA CAJA DE TEXTO
            Encargadosexo = Convert.ToInt32(spSexoComboBox.SelectedValue);
        }
        private void spOcupacionComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //GUARDA EN LA VARIABLE EL VALOR DE LA CAJA DE TEXTO
            EncargadoOcupacion = Convert.ToInt32(spOcupacionComboBox.SelectedValue);
        }
        private void spOcupacionComboBox_Click_1(object sender, EventArgs e)
        {
            //PROCEDIMIENTO QUE MANDA A TRAER LA DATA DE OCUPACION
            this.spOcupacionTableAdapter.Fill(this.desarrolloDataSet.SpOcupacion);
        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            //valida que la caja de texto tenga el valor maximo de caracteres
            //valida que solo acepten letras
            LogIn.ValorMaximoDeCaja(textBox13, 8, errorProvider1);
            LogIn.NumerosConMensaje(textBox13, errorProvider1);
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //valida que la caja de texto tenga el valor maximo de caracteres
            //valida que solo acepten letras
            LogIn.ValorMaximoDeCaja(textBox7, 8, errorProvider1);
            LogIn.NumerosConMensaje(textBox7, errorProvider1);
        }
        private void spRelacionComboBox_Click_1(object sender, EventArgs e)
        {
            //PROCEDIMIENTO QUE MANDA A TRAER LA DATA DE RELACION
            this.spRelacionTableAdapter.Fill(this.desarrolloDataSet.spRelacion);
        }
        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //PROCEDIMIENTO QUE GUARDA LA MODALIDAD EN LA BASE DE DATOS
                this.spCursoModalidad2TableAdapter.Fill(this.desarrolloDataSet1.spCursoModalidad2, spModalidadesComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void spModalidadesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PROCEDIMIENTO QUE GUARDA LA MODALIDAD EN LA BASE DE DATOS
            this.spCursoModalidad2TableAdapter.Fill(this.desarrolloDataSet1.spCursoModalidad2, spModalidadesComboBox.Text);
            modaliad = Convert.ToInt32(spModalidadesComboBox.SelectedValue);
        }
        private void spCursoModalidad2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GUARDA EN LA VARIABLE EL VALOR DE LA CAJA DE TEXTO
            curso = Convert.ToInt32(spCursoModalidad2ComboBox.SelectedValue);
        }
        private void spEstadoMatriculaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GUARDA EN LA VARIABLE EL VALOR DE LA CAJA DE TEXTO
            estatadoMatricula = Convert.ToInt32(spEstadoMatriculaComboBox.SelectedValue);
        }
        private void spMostrarInstitutoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GUARDA EN LA VARIABLE EL VALOR DE LA CAJA DE TEXTO
            instituto = Convert.ToInt32(spMostrarInstitutoComboBox.SelectedValue);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GUARDA EN LA VARIABLE EL VALOR DE LA CAJA DE TEXTO
            seccion = comboBox2.Text;
        }

        private void spDepartamentosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GUARDA EN LA VARIABLE EL VALOR DE LA CAJA DE TEXTO
            departamento = Convert.ToInt32(spDepartamentosComboBox.SelectedValue);
        }
        private void documentosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (documentosDataGridView.Rows[e.RowIndex].Cells[0].Selected)
                documentosDataGridView.ReadOnly = true;
            else
                if (documentosDataGridView.Rows[e.RowIndex].Cells[1].Selected)
                    documentosDataGridView.ReadOnly = false;
        }
    }
}

