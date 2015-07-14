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
        string lugartrabajo;
        string horariotrabajo;
        int sexo;
        int estadocivil;
        int nacionalidad;
        int tiposangre;
        string encargado;
        string encaNombre1;
        string encaNombre2;
        string encaNombre3;
        string encaNombre4;
        string encaId;
        DateTime encaFechaNacimiento;
        int Encasexo;
        int EncaOcupacion;
        int relacion;
        int estatadoMatricula;
        int instituto;
        
        int modaliad;
        int curso;
        string seccion;
      
        string TelefonoEnca;
        
        public FichaMatricula()
        {
            InitializeComponent();
        }
        public static string idtelefono;
        private void FichaMatricula_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.Documentos' Puede moverla o quitarla según sea necesario.
            this.documentosTableAdapter.Fill(this.desarrolloDataSet1.Documentos);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spModalidades' Puede moverla o quitarla según sea necesario.
            this.spModalidadesTableAdapter.Fill(this.desarrolloDataSet1.spModalidades);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.SpEstadoMatricula' Puede moverla o quitarla según sea necesario.
            this.spEstadoMatriculaTableAdapter.Fill(this.desarrolloDataSet1.SpEstadoMatricula);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.TipoSangre' Puede moverla o quitarla según sea necesario.
            this.tipoSangreTableAdapter.Fill(this.desarrolloDataSet1.TipoSangre);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spDepartamentos' Puede moverla o quitarla según sea necesario.
            this.spDepartamentosTableAdapter1.Fill(this.desarrolloDataSet1.spDepartamentos);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spModalidad' Puede moverla o quitarla según sea necesario.
          //  this.spModalidadTableAdapter.Fill(this.desarrolloDataSet1.spModalidad);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spDocumentos' Puede moverla o quitarla según sea necesario.
            this.spDocumentosTableAdapter.Fill(this.desarrolloDataSet1.spDocumentos);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.spLugarInstituto' Puede moverla o quitarla según sea necesario.
            this.spLugarInstitutoTableAdapter.Fill(this.desarrolloDataSet1.spLugarInstituto);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.SpMostrarInstituto' Puede moverla o quitarla según sea necesario.
            this.spMostrarInstitutoTableAdapter.Fill(this.desarrolloDataSet1.SpMostrarInstituto);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.spSexo' Puede moverla o quitarla según sea necesario.
            this.spSexoTableAdapter.Fill(this.desarrolloDataSet.spSexo);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.spRelacion' Puede moverla o quitarla según sea necesario.
            this.spRelacionTableAdapter.Fill(this.desarrolloDataSet.spRelacion);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.SpOcupacion' Puede moverla o quitarla según sea necesario.
            this.spOcupacionTableAdapter.Fill(this.desarrolloDataSet.SpOcupacion);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.spNacionalidad' Puede moverla o quitarla según sea necesario.
            this.spNacionalidadTableAdapter.Fill(this.desarrolloDataSet.spNacionalidad);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.spEstadoCivil' Puede moverla o quitarla según sea necesario.
            this.spEstadoCivilTableAdapter.Fill(this.desarrolloDataSet.spEstadoCivil);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.Sexo' Puede moverla o quitarla según sea necesario.
            this.sexoTableAdapter.Fill(this.desarrolloDataSet.Sexo);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.spDepartamentos' Puede moverla o quitarla según sea necesario.
            this.spDepartamentosTableAdapter.Fill(this.desarrolloDataSet.spDepartamentos);
            label29.Visible = false;
            label30.Visible = false;
            textBox14.Visible = false;
            comboBox1.Visible = false;
            tabControl1.TabPages[0].Text = "Datos Personales";
            tabControl1.TabPages[1].Text = "Datos Encargado";
            tabControl1.TabPages[2].Text = "Datos Académicos";
            tabControl1.TabPages[3].Text = "Documentos";
            button4.Enabled = true;

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
            
            LogIn.ValorMaximoDeCaja(textBox1, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(textBox1, errorProvider1);

            Nombre1 = textBox1.Text;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(textBox2, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(textBox2, errorProvider1);
            label19.Text = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text;
            Nombre2 = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
            LogIn.ValorMaximoDeCaja(textBox3, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(textBox3, errorProvider1);
            label19.Text = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text;
            Nombre3 = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(textBox4, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(textBox4, errorProvider1);
            label19.Text = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text;
            Nombre4 = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
            LogIn.ValorMaximoDeCaja(textBox5, 13, errorProvider1);
            LogIn.NumerosConMensaje(textBox5, errorProvider1);
            idtelefono = textBox5.Text;
            alumnoid = textBox5.Text;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox1.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox2.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox2.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox3.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox3.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox4.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox4.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Nacionalidad = new Nacionalidad();
            Nacionalidad.Show();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            

            //label12.Text = (Convert.ToInt32(DateTime.Today.Year) - Convert.ToInt32(dateTimePicker1.Value.Year)).ToString();
            FechaNacimiento = dateTimePicker1.Value;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label29.Visible = true;
                label30.Visible = true;
                textBox14.Visible = true;
                comboBox1.Visible = true;
                estadotrabajo = radioButton1.Text;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label29.Visible = false;
            label30.Visible = false;
            textBox14.Visible = false;
            comboBox1.Visible = false;
            estadotrabajo = radioButton2.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
           
            LogIn.ValorMaximoDeCaja(textBox8, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(textBox8, errorProvider1);
            encaNombre1 = textBox8.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(textBox9, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(textBox9, errorProvider1);
            encaNombre2 = textBox9.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
           
            LogIn.ValorMaximoDeCaja(textBox10, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(textBox10, errorProvider1);
            encaNombre3 = textBox10.Text;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(textBox11, 15, errorProvider1);
            LogIn.SoloLetrasConMensaje(textBox11, errorProvider1);
            encaNombre4 = textBox11.Text;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
           
            LogIn.ValorMaximoDeCaja(textBox12, 13, errorProvider1);
            LogIn.NumerosConMensaje(textBox12, errorProvider1);
            encargado = textBox12.Text;
            encaId = textBox12.Text;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Ocupacion = new Ocupacion();
            Ocupacion.Show();
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox8.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox8.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox9.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox9.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox10.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox10.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox11.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox11.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
           Form Telefono = new Telefono();
           Telefono.Show();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.sCursoxModalidadTableAdapter.Fill(this.desarrolloDataSet1.SCursoxModalidad, parametroToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void spModalidadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           // this.sCursoxModalidadTableAdapter.Fill(desarrolloDataSet1.SCursoxModalidad, spModalidadComboBox.Text);
        }

        private void spNacionalidadComboBox_Click(object sender, EventArgs e)
        {
            this.spNacionalidadTableAdapter.Fill(this.desarrolloDataSet.spNacionalidad);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form Parentesco = new Parentesco();
            Parentesco.Show();
        }

        private void spOcupacionComboBox_Click(object sender, EventArgs e)
        {
            this.spOcupacionTableAdapter.Fill(this.desarrolloDataSet.SpOcupacion);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form Instituto_Prodencia = new Instituto_Procedencia();
            Instituto_Prodencia.Show();
        }

        private void spRelacionComboBox_Click(object sender, EventArgs e)
        {
            this.spRelacionTableAdapter.Fill(this.desarrolloDataSet.spRelacion);
        }

        private void spMostrarInstitutoComboBox_Click(object sender, EventArgs e)
        {
            this.spMostrarInstitutoTableAdapter.Fill(this.desarrolloDataSet1.SpMostrarInstituto);
        }

        private void button7_Click(object sender, EventArgs e)
        {
             try
            {
                if (!string.IsNullOrWhiteSpace(textBox15.Text))
                {
                    Agregar.spDocumento_agregar(textBox15.Text);
                    this.spDocumentosTableAdapter.Fill(this.desarrolloDataSet1.spDocumentos);
                    
                }
            }
            catch (SqlException)
            {
                
               
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
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


            if (años2 < 18)
            {
                MessageBox.Show("El Encargado debe ser mayor a 18 años");
            }
            else
            {

                try
                {
                    Agregar.SpInsertarEncargado(encaId, encaNombre1, encaNombre2, encaNombre3, encaNombre4, encaFechaNacimiento, EncaOcupacion, Encasexo);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Datos de Encargado incompletos");
                    a++;

                }
            }
                int dias = DateTime.Now.Date.Subtract(dateTimePicker1.Value.Date).Days;

            
            if (dias < 0)
            {
                MessageBox.Show("la fecha seleccionada es igual o mayor al dia actual");
            }
            else
            {
                try
                {
                    Agregar.SpInsertarAlumnoSinValidar(alumnoid, Nombre1, Nombre2, Nombre3, Nombre4, FechaNacimiento, direccion, estadotrabajo,
                                   lugarTrabajo, horariotrabajo, sexo, estadocivil, nacionalidad, tiposangre, encargado, relacion, departamento);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Datos de Alumno incompletos");

                    a++;
                }
          
            }


              
            try
            {
                Agregar.spInsertartelefonoAlumno(textBox7.Text, textBox5.Text);
            }
            catch (Exception)
            {

            }
           
            try
            {
                Agregar.spDatosAcademicos2(alumnoid, estatadoMatricula, instituto, modaliad, curso.ToString(), seccion);
                MessageBox.Show("Se inserto el Alumno con exito");
            }
            catch (SqlException)
            {

                MessageBox.Show("Datos Academicos incompletos");
                a++;
            }


            if (a== 0)
            {
                foreach (Control ctrl in groupBox1.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        TextBox text = ctrl as TextBox;
                        text.Clear();
                    }
                }
                foreach (Control ctrl in groupBox2.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        TextBox text = ctrl as TextBox;
                        text.Clear();
                    }
                }
                foreach (Control ctrl in groupBox4.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        TextBox text = ctrl as TextBox;
                        text.Clear();
                    }
                }
              
            }
            //int i=0;
            //for (i = 0; i < documentosDataGridView.Rows.Count; i++)
            //    {

            //        z = documentosDataGridView.Rows[i].Cells[0].Value.ToString();
            //        y = Convert.ToInt32(comboBox1.SelectedValue);
            //        if (this.documentosDataGridView.Rows[i].Cells[2].Value ==  check.TrueValue)
            //        {
            //            QTA.actporalum(y, z);
            //            x = 1;
            //        }

           // foreach (DataGridViewRow row in documentosDataGridView.Rows)
           // {
                //this.voluntariosDataGridView.Rows[i].Cells[8].Value ==  check.TrueValue
               // if(row.Cells[2].se == check )
               // Agregar.IngresarDocumentos(DateTime.Today.Year.ToString(),alumnoid.ToString(), row.Cells[1]));
           // }
           
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            lugarTrabajo = textBox14.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            horariotrabajo=comboBox1.Text;
            
        }

        private void sexoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sexo = Convert.ToInt32(sexoComboBox.SelectedValue);
        }

        private void spEstadoCivilComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            estadocivil = Convert.ToInt32(spEstadoCivilComboBox.SelectedValue);
        }

        private void spNacionalidadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nacionalidad = Convert.ToInt32(spNacionalidadComboBox.SelectedValue);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            direccion = textBox6.Text;
        }

        private void tipoSangreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tiposangre = Convert.ToInt32(tipoSangreComboBox.SelectedValue);
        }

        private void spRelacionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           relacion = Convert.ToInt32(spRelacionComboBox.SelectedValue);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
         

            encaFechaNacimiento = dateTimePicker2.Value;
        }



        private void spRelacionComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            relacion = Convert.ToInt32(spRelacionComboBox.SelectedValue);
        }

        private void spSexoComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Encasexo = Convert.ToInt32(spSexoComboBox.SelectedValue);
        }

        private void spOcupacionComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            EncaOcupacion = Convert.ToInt32(spOcupacionComboBox.SelectedValue);
        }

        private void spOcupacionComboBox_Click_1(object sender, EventArgs e)
        {
            this.spOcupacionTableAdapter.Fill(this.desarrolloDataSet.SpOcupacion);
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(textBox13, 8, errorProvider1);
            LogIn.NumerosConMensaje(textBox13, errorProvider1);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(textBox7, 8, errorProvider1);
            LogIn.NumerosConMensaje(textBox7, errorProvider1);
            
        }

        private void spDocumentosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void spRelacionComboBox_Click_1(object sender, EventArgs e)
        {
            this.spRelacionTableAdapter.Fill(this.desarrolloDataSet.spRelacion);
        }

       
        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.spCursoModalidad2TableAdapter.Fill(this.desarrolloDataSet1.spCursoModalidad2, spModalidadesComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void spModalidadesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.spCursoModalidad2TableAdapter.Fill(this.desarrolloDataSet1.spCursoModalidad2, spModalidadesComboBox.Text);
            modaliad = Convert.ToInt32(spModalidadesComboBox.SelectedValue);
        }

        private void spCursoModalidad2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            curso = Convert.ToInt32(spCursoModalidad2ComboBox.SelectedValue);
        }

        private void spCursoModalidad2ComboBox_Click(object sender, EventArgs e)
        {
       
        }

        private void spEstadoMatriculaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            estatadoMatricula = Convert.ToInt32(spEstadoMatriculaComboBox.SelectedValue);
        }

        private void spMostrarInstitutoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            instituto = Convert.ToInt32(spMostrarInstitutoComboBox.SelectedValue);
        }

        private void spLugarInstitutoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            seccion = comboBox2.Text;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void spDepartamentosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            departamento = Convert.ToInt32(spDepartamentosComboBox.SelectedValue);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void documentosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (documentosDataGridView.Rows[e.RowIndex].Cells[0].Selected)
                documentosDataGridView.ReadOnly = true;
            else
                if (documentosDataGridView.Rows[e.RowIndex].Cells[1].Selected)
                    documentosDataGridView.ReadOnly = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lax_Click(object sender, EventArgs e)
        {

        }

       

      
      

      
    }
}
