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
    public partial class Parentesco : Form
    {
        QueriesTableAdapter Agregar = new QueriesTableAdapter();
        QueriesTableAdapter eliminar = new QueriesTableAdapter();
        public Parentesco()
        {
            InitializeComponent();
        }
        private void Parentesco_Load(object sender, EventArgs e)
        {
            //  esta línea de código carga datos en la tabla 'desarrolloDataSet1.spRelacion'
            this.spRelacionTableAdapter.Fill(this.desarrolloDataSet1.spRelacion);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    // esta linea de codigo agrega el nombre del parentesco
                    Agregar.spParentesco_agregar(textBox1.Text);
                    this.spRelacionTableAdapter.Fill(this.desarrolloDataSet1.spRelacion);
                }
                else
                    MessageBox.Show("Tiene que ingresar un parentesco");
            }
            catch (SqlException)
            { }
            this.spRelacionTableAdapter.Fill(this.desarrolloDataSet1.spRelacion);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LogIn.ValorMaximoDeCaja(textBox1, 15, errorProvider1);

            //esta linea de codigo llama la funcion sololetras para validar el textbox
            LogIn.SoloLetrasConMensaje(textBox1, errorProvider1);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (textBox1.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else
                if (textBox1.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void spRelacionDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string nombre;
            {
                if (spRelacionDataGridView.Rows[e.RowIndex].Cells[2].Selected)
                {
                    try
                    {
                        nombre = spRelacionDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        if (MessageBox.Show("Estas seguro de eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            // en esta linea de codigo se elimina un parentesco ya registrado
                            eliminar.spRelacion_eliminar(nombre);
                            MessageBox.Show("Registro eliminado");
                        }
                        this.spRelacionTableAdapter.Fill(this.desarrolloDataSet1.spRelacion);
                    }
                    catch (SqlException)
                    { }
                } } } }}