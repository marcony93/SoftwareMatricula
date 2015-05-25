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
    public partial class Instituto_Procedencia : Form
    {
        QueriesTableAdapter agregar = new QueriesTableAdapter();
        public Instituto_Procedencia()
        {
            InitializeComponent();
        }

        private void Instituto_Procedencia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet1.SpMostrarInstituto' Puede moverla o quitarla según sea necesario.
            this.spMostrarInstitutoTableAdapter.Fill(this.desarrolloDataSet1.SpMostrarInstituto);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(textBox1, 50, errorProvider1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(textBox1, 50, errorProvider1);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    agregar.spInstituo_agregar2(textBox1.Text, textBox2.Text);
                    this.spMostrarInstitutoTableAdapter.Fill(this.desarrolloDataSet1.SpMostrarInstituto);

                }
            }
            catch (SqlException)
            {


            }
        }
    }
}
