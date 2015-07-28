using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace General
{
    public partial class buscarmaestro : Form
    {
        public static string Idmaestro = "";
        public buscarmaestro()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SI EL COMBOBOX ES 0 BUSCARA POR IDENTIDAD
            //SE HABILITARA EL CUADRO DE TEXTO PARA
            //INGRESAR EL NUMERO DE IDENTIDAD
            if (comboBox1.SelectedIndex == 0)
            {
                textBox2.Enabled = true;
                textBox1.Enabled = false;
                textBox1.Text = "";
            }
            //SI EL COMBOBOX ES 1 BUSCARA POR NOMBRE
            //SE HABILITARA EL CUADRO DE TEXTO PARA
            //INGRESAR EL NOMBRE
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;
                textBox2.Text = "";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //VALIDA SI LA VARIABLE TIENE SOLO LETRAS
            LogIn.SoloLetrasConMensaje(textBox1, errorProvider1);
            //ACTUALIZA LA GRILLA PARA VER LOS MAESTROS
            this.buscarmaestroTableAdapter.Fill(this.desarrolloDataSetmcha.buscarmaestro, "1", textBox1.Text, "");
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //VALIDA SI LA VARIABLE TIENE SOLO LETRAS
            LogIn.NumerosConMensaje(textBox2, errorProvider1);
            //ACTUALIZA LA GRILLA PARA VER LOS MAESTROS
            this.buscarmaestroTableAdapter.Fill(this.desarrolloDataSetmcha.buscarmaestro, "0", "", textBox2.Text);
        }
        private void buscarmaestroDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //SELECCIONA EL PROFESOR CON EL EVENTO CLICK
            if (buscarmaestroDataGridView.Rows[e.RowIndex].Cells[0].Selected)
            {
                //SELECCIONA EL VALOR DE LA CELDA 0 (IDENTIFICACION DEL PROFESOR
                Idmaestro = buscarmaestroDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                //CREA UNA INSTANCIA DE Label VENTANA MODIFICARMAESTRO 
                //LUEGO LO MANDA COMO HIJO AllowDrop CONTENEDOR PRINCIPAL 
                //Y LO TRAE AllowDrop FRENTE
                Form modificarmaestro = new modificarmaestro();
                modificarmaestro.Show();
                modificarmaestro.MdiParent = VentanaGeneralVistaSecretaria.VentanaSecretaria;
                modificarmaestro.WindowState = FormWindowState.Maximized;
                modificarmaestro.BringToFront();
            }
        }
    }
}
