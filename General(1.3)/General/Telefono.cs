﻿using System;
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
    public partial class Telefono : Form
    {
        QueriesTableAdapter insertar = new QueriesTableAdapter();
        QueriesTableAdapter eliminar = new QueriesTableAdapter();
        public Telefono()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.spTelefonosTableAdapter.Fill(this.desarrolloDataSet1.spTelefonos,label2.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(textBox1, 8, errorProvider1);
            LogIn.NumerosConMensaje(textBox1, errorProvider1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                insertar.spInsertartelefonoAlumno(textBox1.Text, label2.Text);
                this.spTelefonosTableAdapter.Fill(this.desarrolloDataSet1.spTelefonos, label2.Text);
            }
            catch (SqlException)
            {
                MessageBox.Show("No puede ingresar el mismo numero");

                
            }

        }

        private void Telefono_Load(object sender, EventArgs e)
        {
            label2.Text = ModificarAlumno.alid;
            this.spTelefonosTableAdapter.Fill(this.desarrolloDataSet1.spTelefonos, label2.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void spTelefonosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              string nom;
            {
                if (spTelefonosDataGridView.Rows[e.RowIndex].Cells[2].Selected)
                {
                    try
                    {
                        nom = spTelefonosDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        eliminar.spTelefono_eliminar(nom);
                        this.spTelefonosTableAdapter.Fill(this.desarrolloDataSet1.spTelefonos, label2.Text);
                    }
                    catch (SqlException)
                    {
                        
                        throw;
                    }
                }

            }
        }
    }
}