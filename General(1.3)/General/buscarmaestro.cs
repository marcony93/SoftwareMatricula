﻿using System;
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

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.selectProfesorTableAdapter.Fill(this.desarrolloDataSetmcha.SelectProfesor, ncontraToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox2.Enabled = true;
                textBox1.Enabled = false;
                textBox1.Text = "";
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;
                textBox2.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.buscarmaestroTableAdapter.Fill(this.desarrolloDataSetmcha.buscarmaestro, "1", textBox1.Text,"");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.buscarmaestroTableAdapter.Fill(this.desarrolloDataSetmcha.buscarmaestro, "0", "", textBox2.Text);
        }

        private void buscarmaestroDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (buscarmaestroDataGridView.Rows[e.RowIndex].Cells[0].Selected)
            {
                
                Idmaestro = buscarmaestroDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                Form modificarmaestro = new modificarmaestro();
                modificarmaestro.Show();
                this.Hide();
            }
        }
    }
}