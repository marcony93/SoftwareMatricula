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

using General.desarrolloDataSetmchaTableAdapters;

namespace General
{
    public partial class InsertarMaestro : Form
    {

         QueriesTableAdapter QTA = new QueriesTableAdapter();
       
    
        public static InsertarMaestro VentanaNuevoMaestro = new InsertarMaestro();
        public InsertarMaestro()
        {
            InitializeComponent();
        }

        private void InsertarMaestro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.spSexo' Puede moverla o quitarla según sea necesario.
            this.spSexoTableAdapter.Fill(this.desarrolloDataSet.spSexo);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LogIn.NumerosConMensaje(textBox1,errorProvider1);
            LogIn.ValorMaximoDeCaja(textBox1, 13, errorProvider1);
             if((textBox2.Text=="" || textBox1.Text=="" || textBox4.Text==""))
                 button1.Enabled=false;
            else
                button1.Enabled=true;
             if (Convert.ToInt32(textBox1.Text.Length.ToString()) > 0)
                 label13.Text = textBox1.Text;
             else
                 label13.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            LogIn.SoloLetrasConMensaje(textBox2, errorProvider1);
            LogIn.ValorMaximoDeCaja(textBox2, 15, errorProvider1);
            if((textBox2.Text=="" || textBox1.Text=="" || textBox4.Text==""))button1.Enabled=false;
            else
                button1.Enabled=true;
            if (Convert.ToInt32(textBox2.Text.Length.ToString()) > 0)
            {
                if (textBox2.Text != "")
                    label12.Text = (textBox2.Text.Substring(0, 1) + textBox4.Text).ToString().ToLower();
            }
            
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            LogIn.SoloLetrasConMensaje(textBox3, errorProvider1);
            LogIn.ValorMaximoDeCaja(textBox3, 15, errorProvider1);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            LogIn.SoloLetrasConMensaje(textBox4, errorProvider1);
            LogIn.ValorMaximoDeCaja(textBox4, 15, errorProvider1);
             if((textBox2.Text=="" || textBox1.Text=="" || textBox4.Text==""))button1.Enabled=false;
            else
                button1.Enabled=true;
             if (Convert.ToInt32(textBox2.Text.Length.ToString()) > 0)
             {
                 if(textBox2.Text!="")
                     label12.Text = (textBox2.Text.Substring(0, 1) + textBox4.Text).ToString().ToLower();
             }
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            LogIn.SoloLetrasConMensaje(textBox5, errorProvider1);
            LogIn.ValorMaximoDeCaja(textBox5, 15, errorProvider1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                QTA.insertarnuevomaestro(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, dateTimePicker1.Value, textBox7.Text, textBox6.Text, spSexoComboBox.SelectedIndex + 1, label12.Text, label13.Text, 2, "0");
                MessageBox.Show("Se ha Guardado con Exito");
            }
            catch (SqlException)
            {

                MessageBox.Show("El Maestro no ha sido guardado");
            }
                  
	        
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int actual = 0;
            int ingresado = 0;

            ingresado=Convert.ToInt32(dateTimePicker1.Value.Year) + Convert.ToInt32(dateTimePicker1.Value.Month) + Convert.ToInt32(dateTimePicker1.Value.Day);
           actual= Convert.ToInt32(DateTime.Today.Year) + Convert.ToInt32(DateTime.Today.Month) + Convert.ToInt32(DateTime.Today.Day);
           if (ingresado > actual)
           {
               MessageBox.Show("Ingrese una fecha Valida");
               dateTimePicker1.Value = DateTime.Today;
           }

           int a;



           try
           {
               a = (DateTime.Today.AddTicks(-dateTimePicker1.Value.Ticks).Year - 1);


               if (a < 18)
               {
                   MessageBox.Show("es menor de edad");
                   dateTimePicker1.ResetText();
               }



           }
           catch (Exception)
           {

           }



        }

        private void spSexoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
