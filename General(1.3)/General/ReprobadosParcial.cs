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
    public partial class ReprobadosParcial : Form
    {
        public ReprobadosParcial()
        {
            InitializeComponent();
        }

        private void ReprobadosParcial_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetElia.SPCursoB' Puede moverla o quitarla según sea necesario.
            this.sPCursoBTableAdapter.Fill(this.desarrolloDataSetElia.SPCursoB);
            this.sPSeccionBTableAdapter.Fill(this.desarrolloDataSetElia.SPSeccionB, Convert.ToInt32(cursoIdTextBox.Text));
            this.sPMateriaBTableAdapter.Fill(this.desarrolloDataSetElia.SPMateriaB, Convert.ToInt32(cursoIdTextBox.Text));
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetElia.ReprobadosPorParcial' Puede moverla o quitarla según sea necesario.
            textBox1.Text = "70";
            this.reportViewer1.RefreshReport();
            button1.Enabled = false;
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sPMateriaBTableAdapter.Fill(this.desarrolloDataSetElia.SPMateriaB, new System.Nullable<int>(((int)(System.Convert.ChangeType(cursoIDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.sPSeccionBTableAdapter.Fill(this.desarrolloDataSetElia.SPSeccionB, new System.Nullable<int>(((int)(System.Convert.ChangeType(cursoIDToolStripTextBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ReprobadosPorParcialTableAdapter.Fill(this.desarrolloDataSetElia.ReprobadosPorParcial, comboBox1.Text.ToString(), sPMateriaBComboBox.SelectedValue.ToString(), sPSeccionBComboBox.SelectedValue.ToString(), Convert.ToInt32(cursoIdTextBox.Text), Convert.ToInt32(textBox1.Text));
            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void cursoIdTextBox_TextChanged(object sender, EventArgs e)
        {
            this.sPSeccionBTableAdapter.Fill(this.desarrolloDataSetElia.SPSeccionB, Convert.ToInt32(cursoIdTextBox.Text));
            this.sPMateriaBTableAdapter.Fill(this.desarrolloDataSetElia.SPMateriaB, Convert.ToInt32(cursoIdTextBox.Text));
        }

        private void sPCursoBComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.sPSeccionBTableAdapter.Fill(this.desarrolloDataSetElia.SPSeccionB, Convert.ToInt32(cursoIdTextBox.Text));
            this.sPMateriaBTableAdapter.Fill(this.desarrolloDataSetElia.SPMateriaB, Convert.ToInt32(cursoIdTextBox.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(textBox1, 2, errorProvider1);
            LogIn.NumerosConMensaje(textBox1, errorProvider1);
        }
    }
}
