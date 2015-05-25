namespace General
{
    partial class Reportes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.uspAlumnosxCursoxSeccion1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desarrolloDataSet = new General.desarrolloDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uspCursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspCursosTableAdapter = new General.desarrolloDataSetTableAdapters.uspCursosTableAdapter();
            this.tableAdapterManager = new General.desarrolloDataSetTableAdapters.TableAdapterManager();
            this.uspCursosComboBox = new System.Windows.Forms.ComboBox();
            this.uspSeccionesXcursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspSeccionesXcursoTableAdapter = new General.desarrolloDataSetTableAdapters.uspSeccionesXcursoTableAdapter();
            this.uspSeccionesXcursoComboBox = new System.Windows.Forms.ComboBox();
            this.seccion = new System.Windows.Forms.TextBox();
            this.uspAlumnosxCursoxSeccion1TableAdapter = new General.desarrolloDataSetTableAdapters.uspAlumnosxCursoxSeccion1TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uspAlumnosxCursoxSeccion1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspCursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSeccionesXcursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uspAlumnosxCursoxSeccion1BindingSource
            // 
            this.uspAlumnosxCursoxSeccion1BindingSource.DataMember = "uspAlumnosxCursoxSeccion1";
            this.uspAlumnosxCursoxSeccion1BindingSource.DataSource = this.desarrolloDataSet;
            // 
            // desarrolloDataSet
            // 
            this.desarrolloDataSet.DataSetName = "desarrolloDataSet";
            this.desarrolloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.uspAlumnosxCursoxSeccion1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "General.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-5, 101);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(887, 381);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // uspCursosBindingSource
            // 
            this.uspCursosBindingSource.DataMember = "uspCursos";
            this.uspCursosBindingSource.DataSource = this.desarrolloDataSet;
            // 
            // uspCursosTableAdapter
            // 
            this.uspCursosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CalendarioTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CursoTableAdapter = null;
            this.tableAdapterManager.DepartamentoTableAdapter = null;
            this.tableAdapterManager.DocumentoMatriculaTableAdapter = null;
            this.tableAdapterManager.DocumentosTableAdapter = null;
            this.tableAdapterManager.EncargadoTableAdapter = null;
            this.tableAdapterManager.EstadoCivilTableAdapter = null;
            this.tableAdapterManager.EstadoDocumentosTableAdapter = null;
            this.tableAdapterManager.EstadoMatriculaTableAdapter = null;
            this.tableAdapterManager.FichaMatriculaTableAdapter = null;
            this.tableAdapterManager.HorarioTableAdapter = null;
            this.tableAdapterManager.InstitutoTableAdapter = null;
            this.tableAdapterManager.MaestroTableAdapter = null;
            this.tableAdapterManager.MateriaPorCursoTableAdapter = null;
            this.tableAdapterManager.MateriaTableAdapter = null;
            this.tableAdapterManager.ModalidadTableAdapter = null;
            this.tableAdapterManager.MunicipioTableAdapter = null;
            this.tableAdapterManager.NacionalidadTableAdapter = null;
            this.tableAdapterManager.NotasTableAdapter = null;
            this.tableAdapterManager.OcupacionTableAdapter = null;
            this.tableAdapterManager.ParentescoTableAdapter = null;
            this.tableAdapterManager.PlantillaClaseTableAdapter = null;
            this.tableAdapterManager.SeccionCursoTableAdapter = null;
            this.tableAdapterManager.SeccionTableAdapter = null;
            this.tableAdapterManager.SexoTableAdapter = null;
            this.tableAdapterManager.TelefonoAlumnoTableAdapter = null;
            this.tableAdapterManager.TipoSangreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = General.desarrolloDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uspCursosComboBox
            // 
            this.uspCursosComboBox.DataSource = this.uspCursosBindingSource;
            this.uspCursosComboBox.DisplayMember = "CursoNombre";
            this.uspCursosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uspCursosComboBox.FormattingEnabled = true;
            this.uspCursosComboBox.Location = new System.Drawing.Point(150, 23);
            this.uspCursosComboBox.Name = "uspCursosComboBox";
            this.uspCursosComboBox.Size = new System.Drawing.Size(117, 21);
            this.uspCursosComboBox.TabIndex = 2;
            this.uspCursosComboBox.ValueMember = "CursoId";
            this.uspCursosComboBox.SelectedIndexChanged += new System.EventHandler(this.uspCursosComboBox_SelectedIndexChanged);
            // 
            // uspSeccionesXcursoBindingSource
            // 
            this.uspSeccionesXcursoBindingSource.DataMember = "uspSeccionesXcurso";
            this.uspSeccionesXcursoBindingSource.DataSource = this.desarrolloDataSet;
            // 
            // uspSeccionesXcursoTableAdapter
            // 
            this.uspSeccionesXcursoTableAdapter.ClearBeforeFill = true;
            // 
            // uspSeccionesXcursoComboBox
            // 
            this.uspSeccionesXcursoComboBox.DataSource = this.uspSeccionesXcursoBindingSource;
            this.uspSeccionesXcursoComboBox.DisplayMember = "SeccionNombre";
            this.uspSeccionesXcursoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uspSeccionesXcursoComboBox.FormattingEnabled = true;
            this.uspSeccionesXcursoComboBox.Location = new System.Drawing.Point(150, 60);
            this.uspSeccionesXcursoComboBox.Name = "uspSeccionesXcursoComboBox";
            this.uspSeccionesXcursoComboBox.Size = new System.Drawing.Size(117, 21);
            this.uspSeccionesXcursoComboBox.TabIndex = 3;
            this.uspSeccionesXcursoComboBox.ValueMember = "SeccionId";
            // 
            // seccion
            // 
            this.seccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSeccionesXcursoBindingSource, "SeccionId", true));
            this.seccion.Location = new System.Drawing.Point(187, 61);
            this.seccion.Name = "seccion";
            this.seccion.Size = new System.Drawing.Size(19, 20);
            this.seccion.TabIndex = 4;
            // 
            // uspAlumnosxCursoxSeccion1TableAdapter
            // 
            this.uspAlumnosxCursoxSeccion1TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seccion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Curso:";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 502);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uspSeccionesXcursoComboBox);
            this.Controls.Add(this.uspCursosComboBox);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.seccion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspAlumnosxCursoxSeccion1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspCursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSeccionesXcursoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private desarrolloDataSet desarrolloDataSet;
        private System.Windows.Forms.BindingSource uspCursosBindingSource;
        private desarrolloDataSetTableAdapters.uspCursosTableAdapter uspCursosTableAdapter;
        private desarrolloDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox uspCursosComboBox;
        private System.Windows.Forms.BindingSource uspSeccionesXcursoBindingSource;
        private desarrolloDataSetTableAdapters.uspSeccionesXcursoTableAdapter uspSeccionesXcursoTableAdapter;
        private System.Windows.Forms.ComboBox uspSeccionesXcursoComboBox;
        private System.Windows.Forms.TextBox seccion;
        private System.Windows.Forms.BindingSource uspAlumnosxCursoxSeccion1BindingSource;
        private desarrolloDataSetTableAdapters.uspAlumnosxCursoxSeccion1TableAdapter uspAlumnosxCursoxSeccion1TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}