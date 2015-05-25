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
    public partial class Carnet : Form
    {
        public Carnet()
        {
            InitializeComponent();
        }

        private void Carnet_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetRobertson.spcarnet' Puede moverla o quitarla según sea necesario.
            this.spcarnetTableAdapter.Fill(this.desarrolloDataSetRobertson.spcarnet,textBox1.Text);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.spcarnetTableAdapter.Fill(this.desarrolloDataSetRobertson.spcarnet, textBox1.Text);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

      
    }
}
