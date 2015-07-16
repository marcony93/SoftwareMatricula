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

        QueriesTableAdapter QTA = new QueriesTableAdapter();
        public static int a = 0;
        public modificarmaestro()
        {

            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void column1Label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a++;
            if (a == 1)
            {

                mstroEmailTextBox.Enabled = true;
                mstroDireccionTextBox.Enabled = true;
                mstroUsuTextBox.Enabled = true;
                button1.Text = "guardar";
            }
            else if (a == 2)
            {
                try
                {
                    QTA.psmodificarmaestro(mstroIdTextBox.Text, mstroEmailTextBox.Text, mstroDireccionTextBox.Text, mstroUsuTextBox.Text);
                    mstroEmailTextBox.Enabled = false;
                    mstroDireccionTextBox.Enabled = false;
                    mstroUsuTextBox.Enabled = false;
                    MessageBox.Show("se actualizo con exito");
                }
                catch (SqlException)
                {

                    MessageBox.Show("Los Datos no fueron modificados , el usuario no existe ");
                }


            }
            else if (a == 0)
            {

            }
        }

        private void column2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void modificarmaestro_Load(object sender, EventArgs e)
        {
            this.selectProfesorTableAdapter.Fill(this.desarrolloDataSetmcha.SelectProfesor, buscarmaestro.Idmaestro.ToString());
        }

        private void mstroUsuTextBox_TextChanged(object sender, EventArgs e)
        {
            LogIn.SoloLetrasConMensaje(mstroUsuTextBox, errorProvider1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form general = new VentanaGeneralVistaSecretaria();
            //new buscarmaestro().Show();
            //this.Hide();
            Form buscarmaestro = new buscarmaestro();
            buscarmaestro.Show();
            buscarmaestro.MdiParent = VentanaGeneralVistaSecretaria.VentanaSecretaria;
            buscarmaestro.WindowState = FormWindowState.Maximized;
            buscarmaestro.BringToFront();
        }

        private void mstroEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            InsertarMaestro.ValidarEspacios(mstroEmailTextBox, errorProvider1);
        }

    }
}
