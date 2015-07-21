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
        string alnombre1;
        string alnombre2;
        string alnombre3;
        string alnombre4;
       public static string alid;
        int aldepartamento;
        DateTime alfechanacimiento;
        int alsexo;
        int alestadocivil;
        int alnacionalidad;
        int altipodesangre;
        string alldireccion;
        string alestadotrabajo;
        string allugardetrabajo;
        string alhorariodetrabajo;
        string encanombre1;
        string encanombre2;
        string encanombre3;
        string encanombre4;
        string encaid;
        DateTime encafechanacimiento;
        int encaSexo;
        int encaOcupacion;
        int encarelacion;
        int alestadomatricula;
        int almodalidad;
        int alinstituto;
        int alcurso;
        string alseccion;
        public ModificarAlumno()
        {
            InitializeComponent();
        }

      

        private void ModificarAlumno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spModalidades' Puede moverla o quitarla según sea necesario.
            this.spModalidadesTableAdapter.Fill(this.desarrolloDataSet1.spModalidades);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.SpMostrarInstituto2' Puede moverla o quitarla según sea necesario.
            this.spMostrarInstituto2TableAdapter.Fill(this.desarrolloDataSet1.SpMostrarInstituto2);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.SpEstadoMatricula' Puede moverla o quitarla según sea necesario.
            this.spEstadoMatriculaTableAdapter.Fill(this.desarrolloDataSet1.SpEstadoMatricula);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spRelacion' Puede moverla o quitarla según sea necesario.
            this.spRelacionTableAdapter.Fill(this.desarrolloDataSet1.spRelacion);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.SpOcupacion' Puede moverla o quitarla según sea necesario.
            this.spOcupacionTableAdapter.Fill(this.desarrolloDataSet1.SpOcupacion);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spNacionalidad' Puede moverla o quitarla según sea necesario.
            this.spNacionalidadTableAdapter.Fill(this.desarrolloDataSet1.spNacionalidad);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spEstadoCivil' Puede moverla o quitarla según sea necesario.
            this.spEstadoCivilTableAdapter.Fill(this.desarrolloDataSet1.spEstadoCivil);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.TipoSangre' Puede moverla o quitarla según sea necesario.
            this.tipoSangreTableAdapter.Fill(this.desarrolloDataSet1.TipoSangre);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spSexo' Puede moverla o quitarla según sea necesario.
            this.spSexoTableAdapter.Fill(this.desarrolloDataSet1.spSexo);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spDepartamentos' Puede moverla o quitarla según sea necesario.
            this.spDepartamentosTableAdapter.Fill(this.desarrolloDataSet1.spDepartamentos);
            textbox1.Visible = false;
            comboBox2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            alumIdTextBox.Enabled = false;
            encdoIdTextBox.Enabled = false;
            label3.Text = VerAlumno.iddelalumno;
            try
            {
                this.spModificar_DatosEncargadoTableAdapter.Fill(this.desarrolloDataSet1.spModificar_DatosEncargado, label3.Text);
                this.spModificar_DatosPersonalesTableAdapter.Fill(this.desarrolloDataSet1.SpModificar_DatosPersonales, label3.Text);
                this.spModifica_DatosAcademicosTableAdapter.Fill(this.desarrolloDataSet1.SpModifica_DatosAcademicos, label3.Text);
                this.spMostrarTelefonoAlumnosTableAdapter.Fill(this.desarrolloDataSet1.SpMostrarTelefonoAlumnos, label3.Text);
                spDepartamentosComboBox.SelectedValue = departamento_DeptoIdLabel1.Text;
                tipoSangreComboBox.SelectedValue = tipoSangre_TipSangreIdLabel1.Text;
                spSexoComboBox.SelectedValue = sexo_SexIdLabel2.Text;
                spEstadoCivilComboBox.SelectedValue = estadoCivil_EdoCivilIdLabel1.Text;
                spNacionalidadComboBox.SelectedValue = nacionalidad_NacIdLabel2.Text;
                spRelacionComboBox.SelectedValue = parentesco_ParenIdLabel1.Text;
                spOcupacionComboBox.SelectedValue = ocupacion_OcupIdLabel1.Text;
                spSexoComboBox1.SelectedValue = sexo_SexIdLabel3.Text;
                spEstadoMatriculaComboBox.SelectedValue = estadoMatricula_EstdoMatriIdLabel1.Text;
                spMostrarInstituto2ComboBox.SelectedValue = instituto_InstoIdLabel1.Text;
                spModalidadesComboBox.SelectedValue = modalidad_ModIdLabel1.Text;
                spCursoModalidad2ComboBox.SelectedValue = cursoLabel1.Text;
                comboBox1.Text = seccionLabel1.Text;
            }
            catch (Exception)
            {


            }

            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Enabled = false;
                }
            }
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox text = ctrl as ComboBox;
                    text.Enabled = false;
                }
            }

            foreach (Control ctrl in groupBox2.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Enabled = false;
                }
            }
            foreach (Control ctrl in groupBox2.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox text = ctrl as ComboBox;
                    text.Enabled = false;
                }
            }
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is DateTimePicker)
                {
                    DateTimePicker text = ctrl as DateTimePicker;
                    text.Enabled = false;
                }
            }
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
            errorProvider1.Clear();
            alnombre1 = alumNombre1TextBox.Text;
            alnombre2 = alumNombre2TextBox.Text;
            alnombre3 = alumApellido1TextBox.Text;
            alnombre4 = alumApellido2TextBox.Text;
            alid = alumIdTextBox.Text;
            aldepartamento = Convert.ToInt32(spDepartamentosComboBox.SelectedValue);
            //alfechanacimiento = encdoFechaNacDateTimePicker.Value;
            encaSexo = Convert.ToInt32(spSexoComboBox1.SelectedValue);
            encaOcupacion = Convert.ToInt32(spOcupacionComboBox.SelectedValue);
            encarelacion = Convert.ToInt32(spRelacionComboBox.SelectedValue);
            alsexo = Convert.ToInt32(spSexoComboBox.SelectedValue);
            altipodesangre = Convert.ToInt32(tipoSangreComboBox.SelectedValue);
            alestadocivil = Convert.ToInt32(spEstadoCivilComboBox.SelectedValue);
            alnacionalidad = Convert.ToInt32(spNacionalidadComboBox.SelectedValue);
            alldireccion = alumDireccionTextBox.Text;
            alestadotrabajo = radioButton1.Text;
            allugardetrabajo = textbox1.Text;
            alhorariodetrabajo = comboBox2.Text;
            encanombre1 = encdoNombre1TextBox.Text;
            encanombre2 = encdoNombre2TextBox.Text;
            encanombre3 = encdoApellido1TextBox.Text;
            encanombre4 = encdoApellido2TextBox.Text;
            encaid = encdoIdTextBox.Text;
           // encafechanacimiento = encdoFechaNacDateTimePicker.Value;
            alestadomatricula = Convert.ToInt32(spEstadoMatriculaComboBox.SelectedValue);
            alinstituto = Convert.ToInt32(spMostrarInstituto2ComboBox.SelectedValue);
            this.spCursoModalidad2TableAdapter.Fill(this.desarrolloDataSet1.spCursoModalidad2, spModalidadesComboBox.Text);
            almodalidad = Convert.ToInt32(spModalidadesComboBox.SelectedValue);
            alcurso = Convert.ToInt32(spCursoModalidad2ComboBox.SelectedValue);
            alseccion = comboBox1.Text;
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
                alestadotrabajo = radioButton1.Text;
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
                alestadotrabajo = radioButton1.Text;
            }
        }

        private void encdoIdTextBox_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(alumIdTextBox, 13, errorProvider1);
            LogIn.NumerosConMensaje(alumIdTextBox, errorProvider1);
            encaid = encdoIdTextBox.Text;
        }

        

        private void spModalidadesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.spCursoModalidad2TableAdapter.Fill(this.desarrolloDataSet1.spCursoModalidad2, spModalidadesComboBox.Text);
            almodalidad = Convert.ToInt32(spModalidadesComboBox.SelectedValue);
        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.spCursoModalidad2TableAdapter.Fill(this.desarrolloDataSet1.spCursoModalidad2,spModalidadesComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

             
          
        

        private void spCursoModalidad2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alcurso = Convert.ToInt32(spCursoModalidad2ComboBox.SelectedValue);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Enabled = true;
                }
            }
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox text = ctrl as ComboBox;
                    text.Enabled = true;
                }
            }

            foreach (Control ctrl in groupBox2.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Enabled = true;
                }
            }
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
            encarelacion = Convert.ToInt32(spRelacionComboBox.SelectedValue);
        }

        private void alumNombre1TextBox_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(alumNombre1TextBox, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(alumNombre1TextBox, errorProvider1);
            alnombre1 = alumNombre1TextBox.Text;
        }

        private void alumNombre1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (alumNombre1TextBox.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (alumNombre1TextBox.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void alumNombre2TextBox_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(alumNombre2TextBox, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(alumNombre2TextBox, errorProvider1);
            alnombre2 = alumNombre2TextBox.Text;
        }

        private void alumNombre2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (alumNombre2TextBox.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (alumNombre2TextBox.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void alumApellido1TextBox_TextChanged(object sender, EventArgs e)
        {

            LogIn.ValorMaximoDeCaja(alumApellido1TextBox, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(alumApellido1TextBox, errorProvider1);
            alnombre3 = alumApellido1TextBox.Text;
        }

        private void alumApellido1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (alumApellido1TextBox.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (alumApellido1TextBox.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void alumApellido2TextBox_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(alumApellido2TextBox, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(alumApellido2TextBox, errorProvider1);
            alnombre4 = alumApellido2TextBox.Text;
        }

        private void alumApellido2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (alumApellido2TextBox.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (alumApellido2TextBox.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void alumIdTextBox_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(alumIdTextBox, 13, errorProvider1);
            LogIn.NumerosConMensaje(alumIdTextBox, errorProvider1);
            alid = alumIdTextBox.Text;
        }

        private void alumFechaNacDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            alfechanacimiento = alumFechaNacDateTimePicker.Value;
        }

        private void encdoNombre1TextBox_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(encdoNombre1TextBox, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(encdoNombre1TextBox, errorProvider1);
            encanombre1 = encdoNombre1TextBox.Text;
        }

        private void encdoNombre2TextBox_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(encdoNombre2TextBox, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(encdoNombre2TextBox, errorProvider1);
            encanombre2 = encdoNombre2TextBox.Text;
        }

        private void encdoApellido1TextBox_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(encdoApellido1TextBox, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(encdoApellido1TextBox, errorProvider1);
            encanombre3 = encdoApellido1TextBox.Text;
        }

        private void encdoApellido2TextBox_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(encdoApellido2TextBox, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(encdoApellido2TextBox, errorProvider1);
            encanombre4 = encdoApellido2TextBox.Text;
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
            if (encdoNombre2TextBox.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (encdoNombre2TextBox.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void encdoApellido1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (encdoApellido1TextBox.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (encdoApellido1TextBox.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void encdoApellido2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (encdoApellido2TextBox.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (encdoApellido2TextBox.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void encdoFechaNacDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            encafechanacimiento = encdoFechaNacDateTimePicker.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
                   
                    agregar.spModificarAlumno2(alnombre1, alnombre2, alnombre3, alnombre4, alid, aldepartamento, alfechanacimiento, alsexo, altipodesangre, alestadocivil,
                      alldireccion, alestadotrabajo, allugardetrabajo, alhorariodetrabajo, encanombre1, encanombre2, encanombre3, encanombre4, encaid, encafechanacimiento,
                        encaSexo, encaOcupacion, encarelacion, alestadomatricula, almodalidad, alinstituto, alcurso.ToString(), alseccion);
                    MessageBox.Show("Modificacion con exito");
                }
                catch (SqlException)
                {


                }
            }
        }

        private void spDepartamentosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            aldepartamento = Convert.ToInt32(spDepartamentosComboBox.SelectedValue);
        }

        private void spSexoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alsexo = Convert.ToInt32(spSexoComboBox.SelectedValue);
        }

        private void tipoSangreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            altipodesangre = Convert.ToInt32(tipoSangreComboBox.SelectedValue);
        }

        private void spEstadoCivilComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alestadocivil = Convert.ToInt32(spEstadoCivilComboBox.SelectedValue);
        }

        private void spNacionalidadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alnacionalidad = Convert.ToInt32(spNacionalidadComboBox.SelectedValue);
        }

        private void alumDireccionTextBox_TextChanged(object sender, EventArgs e)
        {
            alldireccion = alumDireccionTextBox.Text;
        }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {
            allugardetrabajo = textbox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            alhorariodetrabajo = comboBox2.Text;
        }

        private void spSexoComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            encaSexo = Convert.ToInt32(spSexoComboBox1.SelectedValue);
        }

        private void spOcupacionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            encaOcupacion = Convert.ToInt32(spOcupacionComboBox.SelectedValue);
        }

        private void spRelacionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            encarelacion = Convert.ToInt32(spRelacionComboBox.SelectedValue);
        }

        private void spEstadoMatriculaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alestadomatricula = Convert.ToInt32(spEstadoMatriculaComboBox.SelectedValue);
        }

        private void spMostrarInstituto2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alinstituto = Convert.ToInt32(spMostrarInstituto2ComboBox.SelectedValue);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            alseccion = comboBox1.Text;
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
                this.spMostrarTelefonoAlumnosTableAdapter.Fill(this.desarrolloDataSet1.SpMostrarTelefonoAlumnos, label3.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
      
       
        
    }
}
