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
    public partial class ReporteNotas : Form
    {
        public ReporteNotas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.uspRNTableAdapter.Fill(this.desarrolloDataSet4.uspRN, textBox1.Text);
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.uspRNTableAdapter.Fill(this.desarrolloDataSet4.uspRN, textBox1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
