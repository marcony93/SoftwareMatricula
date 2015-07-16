namespace General
{
    partial class ReporteAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteAlumno));
            this.uspAlumnosxCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desarrolloDataSetBaque = new General.desarrolloDataSetBaque();
            this.uspSelectModalidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspSelectModalidadTableAdapter = new General.desarrolloDataSetBaqueTableAdapters.uspSelectModalidadTableAdapter();
            this.tableAdapterManager = new General.desarrolloDataSetBaqueTableAdapters.TableAdapterManager();
            this.uspSelectModalidadComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uspModalidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspModalidadTableAdapter = new General.desarrolloDataSetBaqueTableAdapters.uspModalidadTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.uspSeccionxCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspSeccionxCursoTableAdapter = new General.desarrolloDataSetBaqueTableAdapters.uspSeccionxCursoTableAdapter();
            this.uspSeccionxCursoComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uspModalidadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uspModalidadComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uspAlumnosxCursoTableAdapter = new General.desarrolloDataSetBaqueTableAdapters.uspAlumnosxCursoTableAdapter();
            this.secNombreTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.uspAlumnosxCursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSetBaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSelectModalidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspModalidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSeccionxCursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspModalidadBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // uspAlumnosxCursoBindingSource
            // 
            this.uspAlumnosxCursoBindingSource.DataMember = "uspAlumnosxCurso";
            this.uspAlumnosxCursoBindingSource.DataSource = this.desarrolloDataSetBaque;
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
            // uspSelectModalidadComboBox
            // 
            this.uspSelectModalidadComboBox.DataSource = this.uspSelectModalidadBindingSource;
            this.uspSelectModalidadComboBox.DisplayMember = "Modalidad Nombre";
            this.uspSelectModalidadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uspSelectModalidadComboBox.FormattingEnabled = true;
            this.uspSelectModalidadComboBox.Location = new System.Drawing.Point(266, 110);
            this.uspSelectModalidadComboBox.Name = "uspSelectModalidadComboBox";
            this.uspSelectModalidadComboBox.Size = new System.Drawing.Size(115, 21);
            this.uspSelectModalidadComboBox.TabIndex = 1;
            this.uspSelectModalidadComboBox.ValueMember = "ModId";
            this.uspSelectModalidadComboBox.SelectedIndexChanged += new System.EventHandler(this.uspSelectModalidadComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modalidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(535, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Curso";
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
            this.uspSeccionxCursoComboBox.Location = new System.Drawing.Point(805, 110);
            this.uspSeccionxCursoComboBox.Name = "uspSeccionxCursoComboBox";
            this.uspSeccionxCursoComboBox.Size = new System.Drawing.Size(115, 21);
            this.uspSeccionxCursoComboBox.TabIndex = 6;
            this.uspSeccionxCursoComboBox.ValueMember = "SecNombre";
            this.uspSeccionxCursoComboBox.SelectedIndexChanged += new System.EventHandler(this.uspSeccionxCursoComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(804, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sección";
            // 
            // uspModalidadBindingSource1
            // 
            this.uspModalidadBindingSource1.DataMember = "uspModalidad";
            this.uspModalidadBindingSource1.DataSource = this.desarrolloDataSetBaque;
            // 
            // uspModalidadComboBox
            // 
            this.uspModalidadComboBox.DataSource = this.uspModalidadBindingSource1;
            this.uspModalidadComboBox.DisplayMember = "Curso Nombre";
            this.uspModalidadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uspModalidadComboBox.FormattingEnabled = true;
            this.uspModalidadComboBox.Location = new System.Drawing.Point(535, 110);
            this.uspModalidadComboBox.Name = "uspModalidadComboBox";
            this.uspModalidadComboBox.Size = new System.Drawing.Size(115, 21);
            this.uspModalidadComboBox.TabIndex = 7;
            this.uspModalidadComboBox.ValueMember = "CursoId";
            this.uspModalidadComboBox.SelectedIndexChanged += new System.EventHandler(this.uspModalidadComboBox_SelectedIndexChanged_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(860, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "Generar reporte";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uspAlumnosxCursoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "General.Report9.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 173);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1135, 346);
            this.reportViewer1.TabIndex = 10;
            // 
            // uspAlumnosxCursoTableAdapter
            // 
            this.uspAlumnosxCursoTableAdapter.ClearBeforeFill = true;
            // 
            // secNombreTextBox
            // 
            this.secNombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSeccionxCursoBindingSource, "SecNombre", true));
            this.secNombreTextBox.Location = new System.Drawing.Point(895, 112);
            this.secNombreTextBox.Name = "secNombreTextBox";
            this.secNombreTextBox.Size = new System.Drawing.Size(25, 20);
            this.secNombreTextBox.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(962, 525);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 52);
            this.button2.TabIndex = 12;
            this.button2.Text = "Ordenar por cuenta";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Azure;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1062, 525);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 52);
            this.button3.TabIndex = 13;
            this.button3.Text = "Ordenar por nombre";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1075, 50);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1134, 94);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(435, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 22);
            this.label5.TabIndex = 31;
            this.label5.Text = "Instituto Francisco Morazan";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::General.Properties.Resources.Screenshot_2015_04_09_13_46_13;
            this.pictureBox3.Location = new System.Drawing.Point(1086, 12);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // ReporteAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1159, 599);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uspModalidadComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uspSeccionxCursoComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uspSelectModalidadComboBox);
            this.Controls.Add(this.secNombreTextBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReporteAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte del Alumno";
            this.Load += new System.EventHandler(this.ReporteAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspAlumnosxCursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSetBaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSelectModalidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspModalidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSeccionxCursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspModalidadBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private desarrolloDataSetBaque desarrolloDataSetBaque;
        private System.Windows.Forms.BindingSource uspSelectModalidadBindingSource;
        private desarrolloDataSetBaqueTableAdapters.uspSelectModalidadTableAdapter uspSelectModalidadTableAdapter;
        private desarrolloDataSetBaqueTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox uspSelectModalidadComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource uspModalidadBindingSource;
        private desarrolloDataSetBaqueTableAdapters.uspModalidadTableAdapter uspModalidadTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource uspSeccionxCursoBindingSource;
        private desarrolloDataSetBaqueTableAdapters.uspSeccionxCursoTableAdapter uspSeccionxCursoTableAdapter;
        private System.Windows.Forms.ComboBox uspSeccionxCursoComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource uspModalidadBindingSource1;
        private System.Windows.Forms.ComboBox uspModalidadComboBox;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uspAlumnosxCursoBindingSource;
        private desarrolloDataSetBaqueTableAdapters.uspAlumnosxCursoTableAdapter uspAlumnosxCursoTableAdapter;
        private System.Windows.Forms.TextBox secNombreTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}