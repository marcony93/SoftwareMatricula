namespace General
{
    partial class ReporteClasesXCurso
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spreporteclasesporcursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desarrolloDataSetWilmer = new General.desarrolloDataSetWilmer();
            //this.spreporteclasesporcursoTableAdapter = new General.desarrolloDataSetBaqueTableAdapters.spreporteclasesporcursoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.modalidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modalidadTableAdapter = new General.desarrolloDataSetWilmerTableAdapters.ModalidadTableAdapter();
            this.tableAdapterManager = new General.desarrolloDataSetWilmerTableAdapters.TableAdapterManager();
            this.desarrolloDataSetBaque = new General.desarrolloDataSetBaque();
            this.uspSelectModalidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspSelectModalidadTableAdapter = new General.desarrolloDataSetBaqueTableAdapters.uspSelectModalidadTableAdapter();
            this.tableAdapterManager1 = new General.desarrolloDataSetBaqueTableAdapters.TableAdapterManager();
            this.uspSelectModalidadComboBox = new System.Windows.Forms.ComboBox();
            this.uspSeccionxCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspSeccionxCursoTableAdapter = new General.desarrolloDataSetBaqueTableAdapters.uspSeccionxCursoTableAdapter();
            this.uspSeccionxCursoComboBox = new System.Windows.Forms.ComboBox();
            this.uspModalidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspModalidadTableAdapter = new General.desarrolloDataSetBaqueTableAdapters.uspModalidadTableAdapter();
            this.uspModalidadComboBox = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.spreporteclasesporcursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSetWilmer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSetBaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSelectModalidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSeccionxCursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspModalidadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spreporteclasesporcursoBindingSource
            // 
            this.spreporteclasesporcursoBindingSource.DataMember = "spreporteclasesporcurso";
            this.spreporteclasesporcursoBindingSource.DataSource = this.desarrolloDataSetWilmer;
            // 
            // desarrolloDataSetWilmer
            // 
            this.desarrolloDataSetWilmer.DataSetName = "desarrolloDataSetWilmer";
            this.desarrolloDataSetWilmer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spreporteclasesporcursoTableAdapter
            // 
//            this.spreporteclasesporcursoTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(813, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modalidadBindingSource
            // 
            this.modalidadBindingSource.DataMember = "Modalidad";
            this.modalidadBindingSource.DataSource = this.desarrolloDataSetWilmer;
            // 
            // modalidadTableAdapter
            // 
            this.modalidadTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
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
            this.tableAdapterManager.ModalidadTableAdapter = this.modalidadTableAdapter;
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
            // desarrolloDataSetBaque
            // 
            this.desarrolloDataSetBaque.DataSetName = "desarrolloDataSetBaque";
            this.desarrolloDataSetBaque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspSelectModalidadBindingSource
            // 
            this.uspSelectModalidadBindingSource.DataMember = "uspSelectModalidad";
            this.uspSelectModalidadBindingSource.DataSource = this.desarrolloDataSetBaque;
            // 
            // uspSelectModalidadTableAdapter
            // 
            this.uspSelectModalidadTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AlumnoTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.CursoTableAdapter = null;
            this.tableAdapterManager1.DepartamentoTableAdapter = null;
            this.tableAdapterManager1.DiaTableAdapter = null;
            this.tableAdapterManager1.DocumentoMatriculaTableAdapter = null;
            this.tableAdapterManager1.DocumentosTableAdapter = null;
            this.tableAdapterManager1.EncargadoTableAdapter = null;
            this.tableAdapterManager1.EstadoCivilTableAdapter = null;
            this.tableAdapterManager1.EstadoMatriculaTableAdapter = null;
            this.tableAdapterManager1.FichaMatriculaTableAdapter = null;
            this.tableAdapterManager1.HoraTableAdapter = null;
            this.tableAdapterManager1.InstitutoTableAdapter = null;
            this.tableAdapterManager1.MaestroTableAdapter = null;
            this.tableAdapterManager1.MateriaTableAdapter = null;
            this.tableAdapterManager1.ModalidadTableAdapter = null;
            this.tableAdapterManager1.NacionalidadTableAdapter = null;
            this.tableAdapterManager1.NotasTableAdapter = null;
            this.tableAdapterManager1.OcupacionTableAdapter = null;
            this.tableAdapterManager1.ParentescoTableAdapter = null;
            this.tableAdapterManager1.Planilla_ClaseTableAdapter = null;
            this.tableAdapterManager1.SeccionTableAdapter = null;
            this.tableAdapterManager1.SexoTableAdapter = null;
            this.tableAdapterManager1.TelefonoAlumnoTableAdapter = null;
            this.tableAdapterManager1.TipoSangreTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = General.desarrolloDataSetBaqueTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uspSelectModalidadComboBox
            // 
            this.uspSelectModalidadComboBox.DataSource = this.uspSelectModalidadBindingSource;
            this.uspSelectModalidadComboBox.DisplayMember = "Modalidad Nombre";
            this.uspSelectModalidadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uspSelectModalidadComboBox.FormattingEnabled = true;
            this.uspSelectModalidadComboBox.Location = new System.Drawing.Point(24, 12);
            this.uspSelectModalidadComboBox.Name = "uspSelectModalidadComboBox";
            this.uspSelectModalidadComboBox.Size = new System.Drawing.Size(122, 21);
            this.uspSelectModalidadComboBox.TabIndex = 12;
            this.uspSelectModalidadComboBox.ValueMember = "ModId";
            this.uspSelectModalidadComboBox.SelectedIndexChanged += new System.EventHandler(this.uspSelectModalidadComboBox_SelectedIndexChanged);
            // 
            // uspSeccionxCursoBindingSource
            // 
            this.uspSeccionxCursoBindingSource.DataMember = "uspSeccionxCurso";
            this.uspSeccionxCursoBindingSource.DataSource = this.desarrolloDataSetBaque;
            // 
            // uspSeccionxCursoTableAdapter
            // 
            this.uspSeccionxCursoTableAdapter.ClearBeforeFill = true;
            // 
            // uspSeccionxCursoComboBox
            // 
            this.uspSeccionxCursoComboBox.DataSource = this.uspSeccionxCursoBindingSource;
            this.uspSeccionxCursoComboBox.DisplayMember = "SecNombre";
            this.uspSeccionxCursoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uspSeccionxCursoComboBox.FormattingEnabled = true;
            this.uspSeccionxCursoComboBox.Location = new System.Drawing.Point(317, 12);
            this.uspSeccionxCursoComboBox.Name = "uspSeccionxCursoComboBox";
            this.uspSeccionxCursoComboBox.Size = new System.Drawing.Size(154, 21);
            this.uspSeccionxCursoComboBox.TabIndex = 13;
            this.uspSeccionxCursoComboBox.ValueMember = "SecNombre";
            // 
            // uspModalidadBindingSource
            // 
            this.uspModalidadBindingSource.DataMember = "uspModalidad";
            this.uspModalidadBindingSource.DataSource = this.desarrolloDataSetBaque;
            // 
            // uspModalidadTableAdapter
            // 
            this.uspModalidadTableAdapter.ClearBeforeFill = true;
            // 
            // uspModalidadComboBox
            // 
            this.uspModalidadComboBox.DataSource = this.uspModalidadBindingSource;
            this.uspModalidadComboBox.DisplayMember = "Curso Nombre";
            this.uspModalidadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uspModalidadComboBox.FormattingEnabled = true;
            this.uspModalidadComboBox.Location = new System.Drawing.Point(170, 12);
            this.uspModalidadComboBox.Name = "uspModalidadComboBox";
            this.uspModalidadComboBox.Size = new System.Drawing.Size(127, 21);
            this.uspModalidadComboBox.TabIndex = 14;
            this.uspModalidadComboBox.ValueMember = "CursoId";
            this.uspModalidadComboBox.SelectedIndexChanged += new System.EventHandler(this.uspModalidadComboBox_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spreporteclasesporcursoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "General.Report8.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 59);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(893, 265);
            this.reportViewer1.TabIndex = 15;
            // 
            // ReporteClasesXCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 365);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.uspModalidadComboBox);
            this.Controls.Add(this.uspSeccionxCursoComboBox);
            this.Controls.Add(this.uspSelectModalidadComboBox);
            this.Controls.Add(this.button1);
            this.Name = "ReporteClasesXCurso";
            this.Text = "ReporteClasesXCurso";
            this.Load += new System.EventHandler(this.ReporteClasesXCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spreporteclasesporcursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSetWilmer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSetBaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSelectModalidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSeccionxCursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspModalidadBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       // private desarrolloDataSetWilmerTableAdapters.spreporteclasesporcursoTableAdapter spreporteclasesporcursoTableAdapter;
        private System.Windows.Forms.Button button1;
        private desarrolloDataSetWilmer desarrolloDataSetWilmer;
        private System.Windows.Forms.BindingSource modalidadBindingSource;
        private desarrolloDataSetWilmerTableAdapters.ModalidadTableAdapter modalidadTableAdapter;
        private desarrolloDataSetWilmerTableAdapters.TableAdapterManager tableAdapterManager;
        private desarrolloDataSetBaque desarrolloDataSetBaque;
        private System.Windows.Forms.BindingSource uspSelectModalidadBindingSource;
        private desarrolloDataSetBaqueTableAdapters.uspSelectModalidadTableAdapter uspSelectModalidadTableAdapter;
        private desarrolloDataSetBaqueTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox uspSelectModalidadComboBox;
        private System.Windows.Forms.BindingSource uspSeccionxCursoBindingSource;
        private desarrolloDataSetBaqueTableAdapters.uspSeccionxCursoTableAdapter uspSeccionxCursoTableAdapter;
        private System.Windows.Forms.ComboBox uspSeccionxCursoComboBox;
        private System.Windows.Forms.BindingSource uspModalidadBindingSource;
        private desarrolloDataSetBaqueTableAdapters.uspModalidadTableAdapter uspModalidadTableAdapter;
        private System.Windows.Forms.ComboBox uspModalidadComboBox;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spreporteclasesporcursoBindingSource;
    }
}