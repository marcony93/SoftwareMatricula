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
    public partial class ReporteReprobados : Form
    {
        public ReporteReprobados()
        {
            InitializeComponent();
        }

        private void ReporteReprobados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetElia.ReprobadosPorClaseGeneral' Puede moverla o quitarla según sea necesario.
            button1.Enabled = false;
            textBox1.Text = "70";
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetElia.SPCursoB' Puede moverla o quitarla según sea necesario.
            this.sPCursoBTableAdapter.Fill(this.desarrolloDataSetElia.SPCursoB);
            this.sPSeccionBTableAdapter.Fill(this.desarrolloDataSetElia.SPSeccionB, Convert.ToInt32(cursoIdTextBox.Text));
            this.sPMateriaBTableAdapter.Fill(this.desarrolloDataSetElia.SPMateriaB, Convert.ToInt32(cursoIdTextBox.Text));
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetElia.SPExamenPorPArcialB' Puede moverla o quitarla según sea necesario.
            

            this.reportViewer1.RefreshReport();
            
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sPSeccionBTableAdapter.Fill(this.desarrolloDataSetElia.SPSeccionB, new System.Nullable<int>(((int)(System.Convert.ChangeType(cursoIDToolStripTextBox.Text, typeof(int))))));
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
                this.sPMateriaBTableAdapter.Fill(this.desarrolloDataSetElia.SPMateriaB, new System.Nullable<int>(((int)(System.Convert.ChangeType(cursoIDToolStripTextBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.ReprobadosPorClaseGeneralTableAdapter.Fill(this.desarrolloDataSetElia.ReprobadosPorClaseGeneral, sPMateriaBComboBox.SelectedValue.ToString(), sPSeccionBComboBox.SelectedValue.ToString(), Convert.ToInt32(cursoIdTextBox.Text), Convert.ToInt32(textBox1.Text));
            this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(textBox1, 2, errorProvider1);
            LogIn.NumerosConMensaje(textBox1, errorProvider1);
        }

        private void sPMateriaBComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void sPCursoBComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.sPSeccionBTableAdapter.Fill(this.desarrolloDataSetElia.SPSeccionB, Convert.ToInt32(cursoIdTextBox.Text));
            this.sPMateriaBTableAdapter.Fill(this.desarrolloDataSetElia.SPMateriaB, Convert.ToInt32(cursoIdTextBox.Text));
        }

        private void cursoIdTextBox_TextChanged(object sender, EventArgs e)
        {
            this.sPSeccionBTableAdapter.Fill(this.desarrolloDataSetElia.SPSeccionB, Convert.ToInt32(cursoIdTextBox.Text));
            this.sPMateriaBTableAdapter.Fill(this.desarrolloDataSetElia.SPMateriaB, Convert.ToInt32(cursoIdTextBox.Text));
        }
    }
}
