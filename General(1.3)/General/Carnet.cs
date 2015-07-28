using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using General.desarrolloDataSetRobertsonTableAdapters;
using System.Data.SqlClient;
namespace General
{
    public partial class Carnet : Form
    {
        public Carnet()
        {
            InitializeComponent();
        }
        private void Carnet_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetRobertson.spcarnet' Puede moverla o quitarla según sea necesario.
            this.spcarnetTableAdapter.Fill(this.desarrolloDataSetRobertson.spcarnet, textBox1.Text);
            //ACTUALIZA LA INFORMACION QUE EL REPORTE MOSTRARA
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //VALIDA SI EL CUANDRO DE TEXTO NO ESTA VACIO
            if (textBox1.Text != "")
            {
                try
                {
                    //PROCEDIMIENTO ALMACENADO QUE MUESTRA LA INFORMACION DEL ALUMNO
                    //MANDANDO COMO PARAMETRO EL  NUMERO DE IDENTIDAD
                    this.spcarnetTableAdapter.Fill(this.desarrolloDataSetRobertson.spcarnet, textBox1.Text);
                    //ACTUALIZA LA INFORMACION QUE EL REPORTE MOSTRARA
                    this.reportViewer1.RefreshReport();
                    this.reportViewer1.RefreshReport();
                }
                catch (SqlException)
                {
                    //MENSAJE EN CASO DE QUE EL ALUMNO NO EXISTA
                    MessageBox.Show("El Alumno No Existe");
                }
            }
            else
                //EN CASO CONTRARIO MOSTRARA UN MENSAJE QUE INGRESE EL NUMERO DE IDENTIDAD
                MessageBox.Show("Ingrese Un Número De Identidad");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //VALIDAR QUE LA CAJA DE TEXTO TENGA SOLO NUMEROS
            LogIn.NumerosConMensaje(textBox1, errorProvider1);
        }
    }
}

