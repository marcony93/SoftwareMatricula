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
    public partial class ReporteClases : Form
    {
        public ReporteClases()
        {
            InitializeComponent();
        }

        private void ReporteClases_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetWilmer.spModalidad' Puede moverla o quitarla según sea necesario.
            this.spModalidadTableAdapter.Fill(this.desarrolloDataSetWilmer.spModalidad);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetWilmer.spreporteclasesporcurso' Puede moverla o quitarla según sea necesario.
            this.spreporteclasesporcursoTableAdapter.Fill(this.desarrolloDataSetWilmer.spreporteclasesporcurso);

        }


    }
}
