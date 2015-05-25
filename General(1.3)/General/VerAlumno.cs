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
    public partial class VerAlumno : Form
    {
        public static string iddelalumno;
        public VerAlumno()
        {
            InitializeComponent();
        }

       

        private void VerAlumno_Load(object sender, EventArgs e)
        {
            
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            comboBox1.SelectedIndex = 0;
            this.spVerAlumnoTableAdapter.Fill(this.desarrolloDataSet1.SpVerAlumno, textBox1.Text, textBox2.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBox1.SelectedIndex, typeof(int))))));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.spVerAlumnoTableAdapter.Fill(this.desarrolloDataSet1.SpVerAlumno, textBox1.Text, textBox2.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBox1.SelectedIndex, typeof(int))))));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;

            }
            else
                if (comboBox1.SelectedIndex == 2)
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = true;
                }
        }

        private void spVerAlumnoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            
        }

        private void spVerAlumnoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (spVerAlumnoDataGridView.Rows[e.RowIndex].Cells[0].Selected)
            {
                iddelalumno = spVerAlumnoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                Form ModificarAlumno = new ModificarAlumno();
                ModificarAlumno.Show();
            }
        }
    }
}
