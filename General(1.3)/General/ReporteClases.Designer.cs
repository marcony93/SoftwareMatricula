namespace General
{
    partial class ReporteClases
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.Label modalidad_NombreLabel;
            System.Windows.Forms.Label curso_NombreLabel;
            System.Windows.Forms.Label label1;
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.desarrolloDataSetWilmer = new General.desarrolloDataSetWilmer();
            this.spreporteclasesporcursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spreporteclasesporcursoTableAdapter = new General.desarrolloDataSetWilmerTableAdapters.spreporteclasesporcursoTableAdapter();
            this.spSeccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spSeccionesTableAdapter = new General.desarrolloDataSetWilmerTableAdapters.spSeccionesTableAdapter();
            this.tableAdapterManager = new General.desarrolloDataSetWilmerTableAdapters.TableAdapterManager();
            this.spSeccionesComboBox = new System.Windows.Forms.ComboBox();
            this.spModalidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spModalidadTableAdapter = new General.desarrolloDataSetWilmerTableAdapters.spModalidadTableAdapter();
            this.modalidad_NombreComboBox = new System.Windows.Forms.ComboBox();
            this.modIdTextBox = new System.Windows.Forms.TextBox();
            this.spCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCursoTableAdapter = new General.desarrolloDataSetWilmerTableAdapters.spCursoTableAdapter();
            this.curso_NombreComboBox = new System.Windows.Forms.ComboBox();
            this.cursoIdTextBox = new System.Windows.Forms.TextBox();
            modalidad_NombreLabel = new System.Windows.Forms.Label();
            curso_NombreLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSetWilmer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreporteclasesporcursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSeccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spModalidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.spreporteclasesporcursoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "General.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 76);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(920, 295);
            this.reportViewer1.TabIndex = 11;
            // 
            // desarrolloDataSetWilmer
            // 
            this.desarrolloDataSetWilmer.DataSetName = "desarrolloDataSetWilmer";
            this.desarrolloDataSetWilmer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spreporteclasesporcursoBindingSource
            // 
            this.spreporteclasesporcursoBindingSource.DataMember = "spreporteclasesporcurso";
            this.spreporteclasesporcursoBindingSource.DataSource = this.desarrolloDataSetWilmer;
            // 
            // spreporteclasesporcursoTableAdapter
            // 
            this.spreporteclasesporcursoTableAdapter.ClearBeforeFill = true;
            // 
            // spSeccionesBindingSource
            // 
            this.spSeccionesBindingSource.DataMember = "spSecciones";
            this.spSeccionesBindingSource.DataSource = this.desarrolloDataSetWilmer;
            // 
            // spSeccionesTableAdapter
            // 
            this.spSeccionesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CursoTableAdapter = null;
            this.tableAdapterManager.DepartamentoTableAdapter = null;
            this.tableAdapterManager.DiaTableAdapter = null;
            this.tableAdapterManager.DocumentoMatriculaTableAdapter = null;
            this.tableAdapterManager.DocumentosTableAdapter = null;
            this.tableAdapterManager.EncargadoTableAdapter = null;
            this.tableAdapterManager.EstadoCivilTableAdapter = null;
            this.tableAdapterManager.EstadoMatriculaTableAdapter = null;
            this.tableAdapterManager.FichaMatriculaTableAdapter = null;
            this.tableAdapterManager.HoraTableAdapter = null;
            this.tableAdapterManager.InstitutoTableAdapter = null;
            this.tableAdapterManager.MaestroTableAdapter = null;
            this.tableAdapterManager.MateriaTableAdapter = null;
            this.tableAdapterManager.ModalidadTableAdapter = null;
            this.tableAdapterManager.NacionalidadTableAdapter = null;
            this.tableAdapterManager.NotasTableAdapter = null;
            this.tableAdapterManager.OcupacionTableAdapter = null;
            this.tableAdapterManager.ParentescoTableAdapter = null;
            this.tableAdapterManager.Planilla_ClaseTableAdapter = null;
            this.tableAdapterManager.SeccionTableAdapter = null;
            this.tableAdapterManager.SexoTableAdapter = null;
            this.tableAdapterManager.TelefonoAlumnoTableAdapter = null;
            this.tableAdapterManager.TipoSangreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = General.desarrolloDataSetWilmerTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // spSeccionesComboBox
            // 
            this.spSeccionesComboBox.DataSource = this.spSeccionesBindingSource;
            this.spSeccionesComboBox.DisplayMember = "SecNombre";
            this.spSeccionesComboBox.FormattingEnabled = true;
            this.spSeccionesComboBox.Location = new System.Drawing.Point(488, 12);
            this.spSeccionesComboBox.Name = "spSeccionesComboBox";
            this.spSeccionesComboBox.Size = new System.Drawing.Size(90, 21);
            this.spSeccionesComboBox.TabIndex = 12;
            this.spSeccionesComboBox.ValueMember = "SecNombre";
            // 
            // spModalidadBindingSource
            // 
            this.spModalidadBindingSource.DataMember = "spModalidad";
            this.spModalidadBindingSource.DataSource = this.desarrolloDataSetWilmer;
            // 
            // spModalidadTableAdapter
            // 
            this.spModalidadTableAdapter.ClearBeforeFill = true;
            // 
            // modalidad_NombreLabel
            // 
            modalidad_NombreLabel.AutoSize = true;
            modalidad_NombreLabel.Location = new System.Drawing.Point(19, 15);
            modalidad_NombreLabel.Name = "modalidad_NombreLabel";
            modalidad_NombreLabel.Size = new System.Drawing.Size(59, 13);
            modalidad_NombreLabel.TabIndex = 12;
            modalidad_NombreLabel.Text = "Modalidad:";
            // 
            // modalidad_NombreComboBox
            // 
            this.modalidad_NombreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spModalidadBindingSource, "Modalidad Nombre", true));
            this.modalidad_NombreComboBox.FormattingEnabled = true;
            this.modalidad_NombreComboBox.Location = new System.Drawing.Point(84, 12);
            this.modalidad_NombreComboBox.Name = "modalidad_NombreComboBox";
            this.modalidad_NombreComboBox.Size = new System.Drawing.Size(161, 21);
            this.modalidad_NombreComboBox.TabIndex = 13;
            // 
            // modIdTextBox
            // 
            this.modIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spModalidadBindingSource, "ModId", true));
            this.modIdTextBox.Location = new System.Drawing.Point(145, 39);
            this.modIdTextBox.Name = "modIdTextBox";
            this.modIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.modIdTextBox.TabIndex = 14;
            // 
            // spCursoBindingSource
            // 
            this.spCursoBindingSource.DataMember = "spCurso";
            this.spCursoBindingSource.DataSource = this.desarrolloDataSetWilmer;
            // 
            // spCursoTableAdapter
            // 
            this.spCursoTableAdapter.ClearBeforeFill = true;
            // 
            // curso_NombreLabel
            // 
            curso_NombreLabel.AutoSize = true;
            curso_NombreLabel.Location = new System.Drawing.Point(251, 15);
            curso_NombreLabel.Name = "curso_NombreLabel";
            curso_NombreLabel.Size = new System.Drawing.Size(37, 13);
            curso_NombreLabel.TabIndex = 15;
            curso_NombreLabel.Text = "Curso:";
            // 
            // curso_NombreComboBox
            // 
            this.curso_NombreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spCursoBindingSource, "Curso Nombre", true));
            this.curso_NombreComboBox.FormattingEnabled = true;
            this.curso_NombreComboBox.Location = new System.Drawing.Point(294, 12);
            this.curso_NombreComboBox.Name = "curso_NombreComboBox";
            this.curso_NombreComboBox.Size = new System.Drawing.Size(121, 21);
            this.curso_NombreComboBox.TabIndex = 16;
            // 
            // cursoIdTextBox
            // 
            this.cursoIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spCursoBindingSource, "CursoId", true));
            this.cursoIdTextBox.Location = new System.Drawing.Point(315, 39);
            this.cursoIdTextBox.Name = "cursoIdTextBox";
            this.cursoIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.cursoIdTextBox.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(433, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 13);
            label1.TabIndex = 18;
            label1.Text = "Seccion:";
            // 
            // ReporteClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 391);
            this.Controls.Add(label1);
            this.Controls.Add(this.cursoIdTextBox);
            this.Controls.Add(curso_NombreLabel);
            this.Controls.Add(this.curso_NombreComboBox);
            this.Controls.Add(this.modIdTextBox);
            this.Controls.Add(modalidad_NombreLabel);
            this.Controls.Add(this.modalidad_NombreComboBox);
            this.Controls.Add(this.spSeccionesComboBox);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteClases";
            this.Text = "ReporteClases";
            this.Load += new System.EventHandler(this.ReporteClases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSetWilmer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreporteclasesporcursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSeccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spModalidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCursoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spreporteclasesporcursoBindingSource;
        private desarrolloDataSetWilmer desarrolloDataSetWilmer;
        private desarrolloDataSetWilmerTableAdapters.spreporteclasesporcursoTableAdapter spreporteclasesporcursoTableAdapter;
        private System.Windows.Forms.BindingSource spSeccionesBindingSource;
        private desarrolloDataSetWilmerTableAdapters.spSeccionesTableAdapter spSeccionesTableAdapter;
        private desarrolloDataSetWilmerTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox spSeccionesComboBox;
        private System.Windows.Forms.BindingSource spModalidadBindingSource;
        private desarrolloDataSetWilmerTableAdapters.spModalidadTableAdapter spModalidadTableAdapter;
        private System.Windows.Forms.ComboBox modalidad_NombreComboBox;
        private System.Windows.Forms.TextBox modIdTextBox;
        private System.Windows.Forms.BindingSource spCursoBindingSource;
        private desarrolloDataSetWilmerTableAdapters.spCursoTableAdapter spCursoTableAdapter;
        private System.Windows.Forms.ComboBox curso_NombreComboBox;
        private System.Windows.Forms.TextBox cursoIdTextBox;
    }
}