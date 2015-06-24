namespace General
{
    partial class ReporteHorarioMaestro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteHorarioMaestro));
            this.sprephorariomaestroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desarrolloDataSetBaque = new General.desarrolloDataSetBaque();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new General.desarrolloDataSetBaqueTableAdapters.TableAdapterManager();
            this.spmodalidadxmaestro2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spmodalidadxmaestro2TableAdapter = new General.desarrolloDataSetBaqueTableAdapters.spmodalidadxmaestro2TableAdapter();
            this.spmodalidadxmaestro2ComboBox = new System.Windows.Forms.ComboBox();
            this.spcursoxmaestroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spcursoxmaestroTableAdapter = new General.desarrolloDataSetBaqueTableAdapters.spcursoxmaestroTableAdapter();
            this.spcursoxmaestroComboBox = new System.Windows.Forms.ComboBox();
            this.sprephorariomaestroTableAdapter = new General.desarrolloDataSetBaqueTableAdapters.sprephorariomaestroTableAdapter();
            this.spseccionxcursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spseccionxcursoTableAdapter = new General.desarrolloDataSetBaqueTableAdapters.spseccionxcursoTableAdapter();
            this.spseccionxcursoComboBox = new System.Windows.Forms.ComboBox();
            this.spMaestro1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spMaestro1TableAdapter = new General.desarrolloDataSetBaqueTableAdapters.spMaestro1TableAdapter();
            this.spMaestro1ComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sprephorariomaestroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSetBaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmodalidadxmaestro2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcursoxmaestroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spseccionxcursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMaestro1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sprephorariomaestroBindingSource
            // 
            this.sprephorariomaestroBindingSource.DataMember = "sprephorariomaestro";
            this.sprephorariomaestroBindingSource.DataSource = this.desarrolloDataSetBaque;
            // 
            // desarrolloDataSetBaque
            // 
            this.desarrolloDataSetBaque.DataSetName = "desarrolloDataSetBaque";
            this.desarrolloDataSetBaque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            reportDataSource1.Name = "desarrolloDataSetBaque";
            reportDataSource1.Value = this.sprephorariomaestroBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "General.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 167);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(602, 277);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maestro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modalidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Curso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Seccion:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(497, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tableAdapterManager.UpdateOrder = General.desarrolloDataSetBaqueTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // spmodalidadxmaestro2BindingSource
            // 
            this.spmodalidadxmaestro2BindingSource.DataMember = "spmodalidadxmaestro2";
            this.spmodalidadxmaestro2BindingSource.DataSource = this.desarrolloDataSetBaque;
            // 
            // spmodalidadxmaestro2TableAdapter
            // 
            this.spmodalidadxmaestro2TableAdapter.ClearBeforeFill = true;
            // 
            // spmodalidadxmaestro2ComboBox
            // 
            this.spmodalidadxmaestro2ComboBox.DataSource = this.spmodalidadxmaestro2BindingSource;
            this.spmodalidadxmaestro2ComboBox.DisplayMember = "Nombre_Modalidad";
            this.spmodalidadxmaestro2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spmodalidadxmaestro2ComboBox.FormattingEnabled = true;
            this.spmodalidadxmaestro2ComboBox.Location = new System.Drawing.Point(113, 119);
            this.spmodalidadxmaestro2ComboBox.Name = "spmodalidadxmaestro2ComboBox";
            this.spmodalidadxmaestro2ComboBox.Size = new System.Drawing.Size(202, 21);
            this.spmodalidadxmaestro2ComboBox.TabIndex = 9;
            this.spmodalidadxmaestro2ComboBox.ValueMember = "Modalidad_ModId";
            this.spmodalidadxmaestro2ComboBox.SelectedIndexChanged += new System.EventHandler(this.spmodalidadxmaestro2ComboBox_SelectedIndexChanged);
            // 
            // spcursoxmaestroBindingSource
            // 
            this.spcursoxmaestroBindingSource.DataMember = "spcursoxmaestro";
            this.spcursoxmaestroBindingSource.DataSource = this.desarrolloDataSetBaque;
            // 
            // spcursoxmaestroTableAdapter
            // 
            this.spcursoxmaestroTableAdapter.ClearBeforeFill = true;
            // 
            // spcursoxmaestroComboBox
            // 
            this.spcursoxmaestroComboBox.DataSource = this.spcursoxmaestroBindingSource;
            this.spcursoxmaestroComboBox.DisplayMember = "NombreCurso";
            this.spcursoxmaestroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spcursoxmaestroComboBox.FormattingEnabled = true;
            this.spcursoxmaestroComboBox.Location = new System.Drawing.Point(401, 83);
            this.spcursoxmaestroComboBox.Name = "spcursoxmaestroComboBox";
            this.spcursoxmaestroComboBox.Size = new System.Drawing.Size(49, 21);
            this.spcursoxmaestroComboBox.TabIndex = 11;
            this.spcursoxmaestroComboBox.ValueMember = "PlaCurso";
            this.spcursoxmaestroComboBox.SelectedIndexChanged += new System.EventHandler(this.spcursoxmaestroComboBox_SelectedIndexChanged);
            // 
            // sprephorariomaestroTableAdapter
            // 
            this.sprephorariomaestroTableAdapter.ClearBeforeFill = true;
            // 
            // spseccionxcursoBindingSource
            // 
            this.spseccionxcursoBindingSource.DataMember = "spseccionxcurso";
            this.spseccionxcursoBindingSource.DataSource = this.desarrolloDataSetBaque;
            // 
            // spseccionxcursoTableAdapter
            // 
            this.spseccionxcursoTableAdapter.ClearBeforeFill = true;
            // 
            // spseccionxcursoComboBox
            // 
            this.spseccionxcursoComboBox.DataSource = this.spseccionxcursoBindingSource;
            this.spseccionxcursoComboBox.DisplayMember = "Seccion";
            this.spseccionxcursoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spseccionxcursoComboBox.FormattingEnabled = true;
            this.spseccionxcursoComboBox.Location = new System.Drawing.Point(401, 122);
            this.spseccionxcursoComboBox.Name = "spseccionxcursoComboBox";
            this.spseccionxcursoComboBox.Size = new System.Drawing.Size(49, 21);
            this.spseccionxcursoComboBox.TabIndex = 12;
            this.spseccionxcursoComboBox.ValueMember = "Seccion";
            // 
            // spMaestro1BindingSource
            // 
            this.spMaestro1BindingSource.DataMember = "spMaestro1";
            this.spMaestro1BindingSource.DataSource = this.desarrolloDataSetBaque;
            // 
            // spMaestro1TableAdapter
            // 
            this.spMaestro1TableAdapter.ClearBeforeFill = true;
            // 
            // spMaestro1ComboBox
            // 
            this.spMaestro1ComboBox.DataSource = this.spMaestro1BindingSource;
            this.spMaestro1ComboBox.DisplayMember = "Nombre_Maestro";
            this.spMaestro1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spMaestro1ComboBox.FormattingEnabled = true;
            this.spMaestro1ComboBox.Location = new System.Drawing.Point(113, 83);
            this.spMaestro1ComboBox.Name = "spMaestro1ComboBox";
            this.spMaestro1ComboBox.Size = new System.Drawing.Size(202, 21);
            this.spMaestro1ComboBox.TabIndex = 12;
            this.spMaestro1ComboBox.ValueMember = "MstroId";
            this.spMaestro1ComboBox.SelectedIndexChanged += new System.EventHandler(this.spMaestro1ComboBox_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(12, 7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(602, 49);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(187, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "Instituto Francisco Morazan";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::General.Properties.Resources.Screenshot_2015_04_09_13_46_13;
            this.pictureBox4.Location = new System.Drawing.Point(554, 7);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 99);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // ReporteHorarioMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(628, 456);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.spMaestro1ComboBox);
            this.Controls.Add(this.spseccionxcursoComboBox);
            this.Controls.Add(this.spcursoxmaestroComboBox);
            this.Controls.Add(this.spmodalidadxmaestro2ComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReporteHorarioMaestro";
            this.Text = "ReporteHorarioMaestro";
            this.Load += new System.EventHandler(this.ReporteHorarioMaestro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sprephorariomaestroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSetBaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmodalidadxmaestro2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcursoxmaestroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spseccionxcursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMaestro1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private desarrolloDataSetBaque desarrolloDataSetBaque;
        private desarrolloDataSetBaqueTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource spmodalidadxmaestro2BindingSource;
        private desarrolloDataSetBaqueTableAdapters.spmodalidadxmaestro2TableAdapter spmodalidadxmaestro2TableAdapter;
        private System.Windows.Forms.ComboBox spmodalidadxmaestro2ComboBox;
        private System.Windows.Forms.BindingSource spcursoxmaestroBindingSource;
        private desarrolloDataSetBaqueTableAdapters.spcursoxmaestroTableAdapter spcursoxmaestroTableAdapter;
        private System.Windows.Forms.ComboBox spcursoxmaestroComboBox;
        private System.Windows.Forms.BindingSource sprephorariomaestroBindingSource;
        private desarrolloDataSetBaqueTableAdapters.sprephorariomaestroTableAdapter sprephorariomaestroTableAdapter;
        private System.Windows.Forms.BindingSource spseccionxcursoBindingSource;
        private desarrolloDataSetBaqueTableAdapters.spseccionxcursoTableAdapter spseccionxcursoTableAdapter;
        private System.Windows.Forms.ComboBox spseccionxcursoComboBox;
        private System.Windows.Forms.BindingSource spMaestro1BindingSource;
        private desarrolloDataSetBaqueTableAdapters.spMaestro1TableAdapter spMaestro1TableAdapter;
        private System.Windows.Forms.ComboBox spMaestro1ComboBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}