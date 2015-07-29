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
    public partial class ModificarAlumno : Form
    {
        QueriesTableAdapter agregar = new QueriesTableAdapter();
        string alumnonombre1;
        string alumnonombre2;
        string alumnonombre3;
        string alumnonombre4;
        public static string alumnoid;
        int alumnodepartamento;
        DateTime alumnofechanacimiento;
        int alumnosexo;
        int alumnoestadocivil;
        int alumnonacionalidad;
        int alumnotipodesangre;
        string alumnodireccion;
        string alumnoestadotrabajo;
        string alumnolugardetrabajo;
        string alumnohorariodetrabajo;
        string encargadonombre1;
        string encargadonombre2;
        string encargadonombre3;
        string encargadonombre4;
        string encargadoid;
        DateTime encargadofechanacimiento;
        int encargadoSexo;
        int encargadoOcupacion;
        int encargadorelacion;
        int alumnoestadomatricula;
        int alumnomodalidad;
        int alumnoinstituto;
        int alumnocurso;
        string alumnoseccion;
        public ModificarAlumno()
        {
            InitializeComponent();
        }
        private void ModificarAlumno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spModalidades' 
            this.spModalidadesTableAdapter.Fill(this.desarrolloDataSet1.spModalidades);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.SpMostrarInstituto2' 
            this.spMostrarInstituto2TableAdapter.Fill(this.desarrolloDataSet1.SpMostrarInstituto2);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.SpEstadoMatricula'
            this.spEstadoMatriculaTableAdapter.Fill(this.desarrolloDataSet1.SpEstadoMatricula);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spRelacion' 
            this.spRelacionTableAdapter.Fill(this.desarrolloDataSet1.spRelacion);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.SpOcupacion' 
            this.spOcupacionTableAdapter.Fill(this.desarrolloDataSet1.SpOcupacion);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spNacionalidad' 
            this.spNacionalidadTableAdapter.Fill(this.desarrolloDataSet1.spNacionalidad);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spEstadoCivil' 
            this.spEstadoCivilTableAdapter.Fill(this.desarrolloDataSet1.spEstadoCivil);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.TipoSangre' 
            this.tipoSangreTableAdapter.Fill(this.desarrolloDataSet1.TipoSangre);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spSexo'
            this.spSexoTableAdapter.Fill(this.desarrolloDataSet1.spSexo);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spDepartamentos' 
            this.spDepartamentosTableAdapter.Fill(this.desarrolloDataSet1.spDepartamentos);
            //campos que tienen que no tienen que esar visibles
            textbox1.Visible = false;
            comboBox2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            alumIdTextBox.Enabled = false;
            encdoIdTextBox.Enabled = false;
            label3.Text = VerAlumno.iddelalumno;
            try
            {
                //procedimiento almacenado que trae la informacion de datos encargado
                this.spModificar_DatosEncargadoTableAdapter.Fill(this.desarrolloDataSet1.spModificar_DatosEncargado, label3.Text);
                //procedimiento almacenado que trae la informacion de datos personales
                this.spModificar_DatosPersonalesTableAdapter.Fill(this.desarrolloDataSet1.SpModificar_DatosPersonales, label3.Text);
                //procedimiento almacenado que trae la informacion de datos academicos
                this.spModifica_DatosAcademicosTableAdapter.Fill(this.desarrolloDataSet1.SpModifica_DatosAcademicos, label3.Text);
                //procedimiento almacenado que trae la informacion de los datos del telefono
                this.spMostrarTelefonoAlumnosTableAdapter.Fill(this.desarrolloDataSet1.SpMostrarTelefonoAlumnos, label3.Text);
                 //procedimiento que muestra en un combobox los departamentos de nacimiento del alumno
                spDepartamentosComboBox.SelectedValue = departamento_DeptoIdLabel1.Text;
                //procedimiento que muestra en un combobox el tipo de sangre del alumno
                tipoSangreComboBox.SelectedValue = tipoSangre_TipSangreIdLabel1.Text;
                spSexoComboBox.SelectedValue = sexo_SexIdLabel2.Text;
                //procedimiento que muestra en un combobox el estado civil del del alumno
                spEstadoCivilComboBox.SelectedValue = estadoCivil_EdoCivilIdLabel1.Text;
                //procedimiento que muestra en un combobox la nacionalidad del alumno
                spNacionalidadComboBox.SelectedValue = nacionalidad_NacIdLabel2.Text;
                //procedimiento que muestra en un combobox el parentesco del encargado con del alumno
                spRelacionComboBox.SelectedValue = parentesco_ParenIdLabel1.Text;
                //procedimiento que muestra en un combobox la ocupacion  del alumno
                spOcupacionComboBox.SelectedValue = ocupacion_OcupIdLabel1.Text;
                //procedimiento que muestra en un combobox los el genero del alumno
                spSexoComboBox1.SelectedValue = sexo_SexIdLabel3.Text;

                spEstadoMatriculaComboBox.SelectedValue = estadoMatricula_EstdoMatriIdLabel1.Text;
                //procedimiento que muestra en un combobox el instituito de procedencia del alumno
                spMostrarInstituto2ComboBox.SelectedValue = instituto_InstoIdLabel1.Text;
                //procedimiento que muestra en un combobox la modalidad del alumno
                spModalidadesComboBox.SelectedValue = modalidad_ModIdLabel1.Text;
                //procedimiento que muestra en un combobox el curso del alumno
                spCursoModalidad2ComboBox.SelectedValue = cursoLabel1.Text;
                //procedimiento que muestra en un combobox la seccion del alumno
                comboBox1.Text = seccionLabel1.Text;
            }
            catch (Exception)
            { }
            //recore los controladores que se encuentran en el grupo 1
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Enabled = false;
                }
            }
            //recore los controladores que se encuentran en el grupo 2
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox text = ctrl as ComboBox;
                    text.Enabled = false;
                }
            }
            //recore los controladores que se encuentran en el grupo 3
            foreach (Control ctrl in groupBox2.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Enabled = false;
                }
            }
            //recore los controladores que se encuentran en el grupo 4
            foreach (Control ctrl in groupBox2.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox text = ctrl as ComboBox;
                    text.Enabled = false;
                }
            }
            //recore los controladores que se encuentran en el grupo 5
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is DateTimePicker)
                {
                    DateTimePicker text = ctrl as DateTimePicker;
                    text.Enabled = false;
                }
            }
            //recore los controladores que se encuentran en el grupo 6
            foreach (Control ctrl in groupBox2.Controls)
            {
                if (ctrl is DateTimePicker)
                {
                    DateTimePicker text = ctrl as DateTimePicker;
                    text.Enabled = false;
                }
            }
            foreach (Control ctrl in groupBox3.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox text = ctrl as ComboBox;
                    text.Enabled = false;
                }
            }
            //limpia todsos los campos de toda la pantalla
            errorProvider1.Clear();
            alumnonombre1 = alumNombre1TextBox.Text;
            alumnonombre2 = alumNombre2TextBox.Text;
            alumnonombre3 = alumApellido1TextBox.Text;
            alumnonombre4 = alumApellido2TextBox.Text;
            alumnoid = alumIdTextBox.Text;
            alumnodepartamento = Convert.ToInt32(spDepartamentosComboBox.SelectedValue);
            encargadoSexo = Convert.ToInt32(spSexoComboBox1.SelectedValue);
            encargadoOcupacion = Convert.ToInt32(spOcupacionComboBox.SelectedValue);
            encargadorelacion = Convert.ToInt32(spRelacionComboBox.SelectedValue);
            alumnosexo = Convert.ToInt32(spSexoComboBox.SelectedValue);
            alumnotipodesangre = Convert.ToInt32(tipoSangreComboBox.SelectedValue);
            alumnoestadocivil = Convert.ToInt32(spEstadoCivilComboBox.SelectedValue);
            alumnonacionalidad = Convert.ToInt32(spNacionalidadComboBox.SelectedValue);
            alumnodireccion = alumDireccionTextBox.Text;
            alumnoestadotrabajo = radioButton1.Text;
            alumnolugardetrabajo = textbox1.Text;
            alumnohorariodetrabajo = comboBox2.Text;
            encargadonombre1 = encdoNombre1TextBox.Text;
            encargadonombre2 = encdoNombre2TextBox.Text;
            encargadonombre3 = encdoApellido1TextBox.Text;
            encargadonombre4 = encdoApellido2TextBox.Text;
            encargadoid = encdoIdTextBox.Text;
            alumnoestadomatricula = Convert.ToInt32(spEstadoMatriculaComboBox.SelectedValue);
            alumnoinstituto = Convert.ToInt32(spMostrarInstituto2ComboBox.SelectedValue);
            this.spCursoModalidad2TableAdapter.Fill(this.desarrolloDataSet1.spCursoModalidad2, spModalidadesComboBox.Text);
            alumnomodalidad = Convert.ToInt32(spModalidadesComboBox.SelectedValue);
            alumnocurso = Convert.ToInt32(spCursoModalidad2ComboBox.SelectedValue);
            alumnoseccion = comboBox1.Text;
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(desarrolloDataSet1.spModificarAlumnoPrueba.DeptoNombreColumn.Expression.ToString());
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textbox1.Visible = false;
                comboBox2.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                alumnoestadotrabajo = radioButton1.Text;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textbox1.Visible = true;
                comboBox2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                alumnoestadotrabajo = radioButton1.Text;
            }
        }
        private void encdoIdTextBox_TextChanged(object sender, EventArgs e)
        {
            //linea de codigo que llama la funcion valormaximo de la caja
            LogIn.ValorMaximoDeCaja(alumIdTextBox, 13, errorProvider1);
            //linea de codigo que llama la funcion solonumeros
            LogIn.NumerosConMensaje(alumIdTextBox, errorProvider1);
            encargadoid = encdoIdTextBox.Text;
        }
        private void spModalidadesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //procedimiento almacenado que trae la informacion del dataset1 modalidades
            this.spCursoModalidad2TableAdapter.Fill(this.desarrolloDataSet1.spCursoModalidad2, spModalidadesComboBox.Text);
            alumnomodalidad = Convert.ToInt32(spModalidadesComboBox.SelectedValue);
        }
        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //procedimiento almacenado que trae la informacion de los cursos del dataset1
                this.spCursoModalidad2TableAdapter.Fill(this.desarrolloDataSet1.spCursoModalidad2, spModalidadesComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void spCursoModalidad2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alumnocurso = Convert.ToInt32(spCursoModalidad2ComboBox.SelectedValue);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            //habilita los controladores del grupbox 1
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Enabled = true;
                }
            }
            //habilita los controladores del grupbox 1
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox text = ctrl as ComboBox;
                    text.Enabled = true;
                }
            }
            //habilita los controladores del grupbox 2
            foreach (Control ctrl in groupBox2.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Enabled = true;
                }
            }
            //habilita los controladores del grupbox 2
            foreach (Control ctrl in groupBox2.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox text = ctrl as ComboBox;
                    text.Enabled = true;
                }
            }
            
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is DateTimePicker)
                {
                    DateTimePicker text = ctrl as DateTimePicker;
                    text.Enabled = true;
                }
            }
            foreach (Control ctrl in groupBox2.Controls)
            {
                if (ctrl is DateTimePicker)
                {
                    DateTimePicker text = ctrl as DateTimePicker;
                    text.Enabled = true;
                }
            }
            foreach (Control ctrl in groupBox3.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox text = ctrl as ComboBox;
                    text.Enabled = true;
                }
            }
            alumIdTextBox.Enabled = false;
            encdoIdTextBox.Enabled = false;
            spNacionalidadComboBox.Enabled = false;
            encargadorelacion = Convert.ToInt32(spRelacionComboBox.SelectedValue);
        }
        private void alumNombre1TextBox_TextChanged(object sender, EventArgs e)
        {
            //linea de codigo que llama la funcion valormaximo de la caja
            LogIn.ValorMaximoDeCaja(alumNombre1TextBox, 15, errorProvider1);
            //linea de codigo que llama la funcion solo letras
            LogIn.SoloLetrasConMensaje(alumNombre1TextBox, errorProvider1);
            alumnonombre1 = alumNombre1TextBox.Text;
        }
        private void alumNombre1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // muestra la primera letra en mayusclula 
            if (alumNombre1TextBox.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                // muestra la primera letra en minuscula
                if (alumNombre1TextBox.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void alumNombre2TextBox_TextChanged(object sender, EventArgs e)
        {
            //linea de codigo que llama la funcion valormaximo de la caja
            LogIn.ValorMaximoDeCaja(alumNombre2TextBox, 15, errorProvider1);
            //linea de codigo que llama la funcion solo letras
            LogIn.SoloLetrasConMensaje(alumNombre2TextBox, errorProvider1);
            alumnonombre2 = alumNombre2TextBox.Text;
        }
        private void alumNombre2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // muestra la primera letra en minuscula
            if (alumNombre2TextBox.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                // muestra la primera letra en mayusclula 
                if (alumNombre2TextBox.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void alumApellido1TextBox_TextChanged(object sender, EventArgs e)
        {
            //linea de codigo que llama la funcion valormaximo de la caja

            LogIn.ValorMaximoDeCaja(alumApellido1TextBox, 15, errorProvider1);
            //linea de codigo que llama la funcion solo letras
            LogIn.SoloLetrasConMensaje(alumApellido1TextBox, errorProvider1);
            alumnonombre3 = alumApellido1TextBox.Text;
        }
        private void alumApellido1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // muestra la primera letra en mayusclula 
            if (alumApellido1TextBox.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else 
                // muestra la primera letra en minuscula
                if (alumApellido1TextBox.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void alumApellido2TextBox_TextChanged(object sender, EventArgs e)
        {
            //linea de codigo que llama la funcion valormaximo de la caja
            LogIn.ValorMaximoDeCaja(alumApellido2TextBox, 15, errorProvider1);
            //linea de codigo que llama la funcion solo letras
            LogIn.SoloLetrasConMensaje(alumApellido2TextBox, errorProvider1);
            alumnonombre4 = alumApellido2TextBox.Text;
        }
        private void alumApellido2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // muestra la primera letra en mayusclula 
            if (alumApellido2TextBox.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                // muestra la primera letra en minuscula
                if (alumApellido2TextBox.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void alumIdTextBox_TextChanged(object sender, EventArgs e)
        {
            //linea de codigo que llama la funcion valormaximo de la caja
            LogIn.ValorMaximoDeCaja(alumIdTextBox, 13, errorProvider1);
            //linea de codigo que llama la funcion solo letras
            LogIn.NumerosConMensaje(alumIdTextBox, errorProvider1);
            alumnoid = alumIdTextBox.Text;
        }
        private void alumFechaNacDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            alumnofechanacimiento = alumFechaNacDateTimePicker.Value;
        }
        private void encdoNombre1TextBox_TextChanged(object sender, EventArgs e)
        {
            //linea de codigo que llama la funcion valor maximo de la caja
            LogIn.ValorMaximoDeCaja(encdoNombre1TextBox, 15, errorProvider1);
            //linea de codigo que llama la funcion solo letras
            LogIn.SoloLetrasConMensaje(encdoNombre1TextBox, errorProvider1);
            encargadonombre1 = encdoNombre1TextBox.Text;
        }
        private void encdoNombre2TextBox_TextChanged(object sender, EventArgs e)
        {
            //linea de codigo que llama la funcion valor maximo de la caja
            LogIn.ValorMaximoDeCaja(encdoNombre2TextBox, 15, errorProvider1);
            //linea de codigo que llama la funcion solo letras
            LogIn.SoloLetrasConMensaje(encdoNombre2TextBox, errorProvider1);
            encargadonombre2 = encdoNombre2TextBox.Text;
        }
        private void encdoApellido1TextBox_TextChanged(object sender, EventArgs e)
        {
            //linea de codigo que llama la funcion valor maximo de la caja
            LogIn.ValorMaximoDeCaja(encdoApellido1TextBox, 15, errorProvider1);
            //linea de codigo que llama la funcion solo letras
            LogIn.SoloLetrasConMensaje(encdoApellido1TextBox, errorProvider1);
            encargadonombre3 = encdoApellido1TextBox.Text;
        }
        private void encdoApellido2TextBox_TextChanged(object sender, EventArgs e)
        {
            //linea de codigo que llama la funcion valor maximo de la caja
            LogIn.ValorMaximoDeCaja(encdoApellido2TextBox, 15, errorProvider1);
            //linea de codigo que llama la funcion solo letras
            LogIn.SoloLetrasConMensaje(encdoApellido2TextBox, errorProvider1);
            encargadonombre4 = encdoApellido2TextBox.Text;
        }
        private void encdoNombre1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (encdoNombre1TextBox.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (encdoNombre1TextBox.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void encdoNombre2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // muestra la primera letra en mayusclula 
            if (encdoNombre2TextBox.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                // muestra la primera letra en mayuscula
                if (encdoNombre2TextBox.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void encdoApellido1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // muestra la primera letra en mayusclula 
            if (encdoApellido1TextBox.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                // muestra la primera letra en minuscula
                if (encdoApellido1TextBox.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void encdoApellido2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // muestra la primera letra en mayusclula 
            if (encdoApellido2TextBox.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                // muestra la primera letra en minuscula
                if (encdoApellido2TextBox.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void encdoFechaNacDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            encargadofechanacimiento = encdoFechaNacDateTimePicker.Value;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //funcion que calcula la edad del alumno
            int dias = DateTime.Now.Date.Subtract(encdoFechaNacDateTimePicker.Value.Date).Days;
            int dias2 = DateTime.Now.Date.Subtract(alumFechaNacDateTimePicker.Value.Date).Days;
            if (dias < 0 || dias2 < 0)
            {
                MessageBox.Show("la fecha seleccionada es igual o mayor al dia actual");
            }
            int años = dias / 365;
            int años2 = dias2 / 365;
            if (años < 18 || años2 < 18)
            {
                MessageBox.Show("debe ser mayor a 18 años");
            }
            else
            {
                try
                {
                    //procedimento que modifica los datos del alumno
                    agregar.spModificarAlumno2(alumnonombre1, alumnonombre2, alumnonombre3, alumnonombre4, alumnoid, alumnodepartamento, alumnofechanacimiento, alumnosexo, alumnotipodesangre, alumnoestadocivil,
                      alumnodireccion, alumnoestadotrabajo, alumnolugardetrabajo, alumnohorariodetrabajo, encargadonombre1, encargadonombre2, encargadonombre3, encargadonombre4, encargadoid, encargadofechanacimiento,
                        encargadoSexo, encargadoOcupacion, encargadorelacion, alumnoestadomatricula, alumnomodalidad, alumnoinstituto, alumnocurso.ToString(), alumnoseccion);
                    MessageBox.Show("Modificacion con exito");
                    this.Close();
                }
                catch (SqlException)
                { }
            }
        }
        //linea de codigo que muestra el departamento seleccionado
        private void spDepartamentosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alumnodepartamento = Convert.ToInt32(spDepartamentosComboBox.SelectedValue);
        }
        //linea de codigo que muestra el sexo seleccionado
        private void spSexoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alumnosexo = Convert.ToInt32(spSexoComboBox.SelectedValue);
        }
        //linea de codigo que muestra el tipo de sangre seleccionado
        private void tipoSangreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alumnotipodesangre = Convert.ToInt32(tipoSangreComboBox.SelectedValue);
        }
        //linea de codigo que muestra el estado civilseleccionado
        private void spEstadoCivilComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alumnoestadocivil = Convert.ToInt32(spEstadoCivilComboBox.SelectedValue);
        }
        //linea de codigo que muestra el nacionalidad seleccionado
        private void spNacionalidadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alumnonacionalidad = Convert.ToInt32(spNacionalidadComboBox.SelectedValue);
        }
        //linea de codigo que muestra la direecion seleccionado
        private void alumDireccionTextBox_TextChanged(object sender, EventArgs e)
        {
            alumnodireccion = alumDireccionTextBox.Text;
        }
        //linea de codigo que muestra el lugar de trabajo seleccionado
        private void textbox1_TextChanged(object sender, EventArgs e)
        {
            alumnolugardetrabajo = textbox1.Text;
        }
        //linea de codigo que muestra el horario de trabajo seleccionado
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            alumnohorariodetrabajo = comboBox2.Text;
        }
        //linea de codigo que muestra el encargadof seleccionado
        private void spSexoComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            encargadoSexo = Convert.ToInt32(spSexoComboBox1.SelectedValue);
        }
        //linea de codigo que muestra la ocupacion seleccionado
        private void spOcupacionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            encargadoOcupacion = Convert.ToInt32(spOcupacionComboBox.SelectedValue);
        }
        //linea de codigo que muestra la relacion dekl encargado seleccionado
        private void spRelacionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            encargadorelacion = Convert.ToInt32(spRelacionComboBox.SelectedValue);
        }
        //linea de codigo que muestra el estado de matricula seleccionado
        private void spEstadoMatriculaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alumnoestadomatricula = Convert.ToInt32(spEstadoMatriculaComboBox.SelectedValue);
        }
        //linea de codigo que muestra el instututo de procedencia seleccionado
        private void spMostrarInstituto2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alumnoinstituto = Convert.ToInt32(spMostrarInstituto2ComboBox.SelectedValue);
        }
        //linea de codigo que muestra el seccion seleccionado
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            alumnoseccion = comboBox1.Text;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form Telefono = new Telefono();
            Telefono.Show();
        }
        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                // muestra los telefonos almacenados en una tabla
                this.spMostrarTelefonoAlumnosTableAdapter.Fill(this.desarrolloDataSet1.SpMostrarTelefonoAlumnos, label3.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}

