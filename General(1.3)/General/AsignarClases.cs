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
    public partial class AsignarClases : Form
    {
        public AsignarClases()
        {
            InitializeComponent();
        }
        public int curso;

        private void AsignarClases_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetWilmer.SpDia' Puede moverla o quitarla según sea necesario.
            this.spDiaTableAdapter.Fill(this.desarrolloDataSetWilmer.SpDia);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetWilmer.spHora' Puede moverla o quitarla según sea necesario.
            this.spHoraTableAdapter.Fill(this.desarrolloDataSetWilmer.spHora);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetWilmer.spHora' Puede moverla o quitarla según sea necesario.
            this.spHoraTableAdapter.Fill(this.desarrolloDataSetWilmer.spHora);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetWilmer.spModalidad' Puede moverla o quitarla según sea necesario.
            this.spModalidadTableAdapter.Fill(this.desarrolloDataSetWilmer.spModalidad);
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSetWilmer.spMaestro' Puede moverla o quitarla según sea necesario.
            this.spMaestroTableAdapter.Fill(this.desarrolloDataSetWilmer.spMaestro);

            this.spCursoTableAdapter.Fill(this.desarrolloDataSetWilmer.spCurso, new System.Nullable<int>(((int)(System.Convert.ChangeType(spModalidadComboBox.SelectedValue, typeof(int))))));

           this.spSeccionesTableAdapter.Fill(this.desarrolloDataSetWilmer.spSecciones, new System.Nullable<int>(((int)(System.Convert.ChangeType(spCursoComboBox.SelectedValue, typeof(int))))), DateTime.Today.Year.ToString());

            this.spMateriaTableAdapter.Fill(this.desarrolloDataSetWilmer.spMateria, new System.Nullable<int>(((int)(System.Convert.ChangeType(spModalidadComboBox.SelectedValue.ToString(), typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(spCursoComboBox.SelectedValue.ToString(), typeof(int))))));
            this.spmostrarplanillaTableAdapter.Fill(this.desarrolloDataSetWilmer.spmostrarplanilla, spMaestroComboBox.SelectedValue.ToString());

        }

        private void spMaestroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.spmostrarplanillaTableAdapter.Fill(this.desarrolloDataSetWilmer.spmostrarplanilla, spMaestroComboBox.SelectedValue.ToString());

        }

        private void spModalidadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.spCursoTableAdapter.Fill(this.desarrolloDataSetWilmer.spCurso, new System.Nullable<int>(((int)(System.Convert.ChangeType(spModalidadComboBox.SelectedValue, typeof(int))))));
            this.spSeccionesTableAdapter.Fill(this.desarrolloDataSetWilmer.spSecciones, new System.Nullable<int>(((int)(System.Convert.ChangeType(spCursoComboBox.SelectedValue, typeof(int))))), DateTime.Today.Year.ToString());
            this.spMateriaTableAdapter.Fill(this.desarrolloDataSetWilmer.spMateria, new System.Nullable<int>(((int)(System.Convert.ChangeType(spModalidadComboBox.SelectedValue.ToString(), typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(spCursoComboBox.SelectedValue.ToString(), typeof(int))))));
            
        }

        private void spCursoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (spCursoComboBox.SelectedValue != null)
            {
                this.spSeccionesTableAdapter.Fill(this.desarrolloDataSetWilmer.spSecciones, new System.Nullable<int>(((int)(System.Convert.ChangeType(spCursoComboBox.SelectedValue, typeof(int))))), DateTime.Today.Year.ToString());
                this.spMateriaTableAdapter.Fill(this.desarrolloDataSetWilmer.spMateria, new System.Nullable<int>(((int)(System.Convert.ChangeType(spModalidadComboBox.SelectedValue.ToString(), typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(spCursoComboBox.SelectedValue.ToString(), typeof(int))))));
            }
            
        }

       
        }

              
     }
