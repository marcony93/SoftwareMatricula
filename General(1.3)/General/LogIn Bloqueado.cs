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
        QueriesTableAdapter QTA = new QueriesTableAdapter();
        public LogIn_Bloqueado()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="sa" && textBox2.Text=="root" )
            {
                LogIn Ventana = new LogIn();
                QTA.cambiarbloqueo(LogIn.usuarioprofesor);
                Ventana.Show();
                this.Close();
            }
            else if (LogIn.validarboton(textBox1, textBox2, errorProvider1) == 1)
            {
                try
                {
                    this.autentificacionTableAdapter.Fill(this.desarrolloDataSet.autentificacion, textBox1.Text, textBox2.Text);
                    switch (mstroTipoLabel1.Text)
                    {
                        case "1":
                            LogIn Ventana = new LogIn(); 
                            QTA.cambiarbloqueo(LogIn.usuarioprofesor);
                            Ventana.Show();
                            this.Close();
                            break;
                        default:
                            MessageBox.Show("Ingrese una cuenta correcta");
                           break;
                    }
                 }
                catch (SqlException)
                {}
        }
    }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LogIn.SoloLetrasConMensaje(textBox1, errorProvider1);
            LogIn.ValorMaximoDeCaja(textBox1, 25, errorProvider1);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            LogIn.SololetrasyNumerosConMensaje(textBox2, errorProvider1);
            LogIn.ValorMaximoDeCaja(textBox2, 25, errorProvider1);
        }
    }
}
