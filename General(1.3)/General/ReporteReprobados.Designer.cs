namespace General
{
    partial class ReporteReprobados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteReprobados));
            this.ReprobadosPorClaseGeneralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desarrolloDataSetElia = new General.desarrolloDataSetElia();
            this.SPExamenPorPArcialBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SPExamenPorPArcialBTableAdapter = new General.desarrolloDataSetEliaTableAdapters.SPExamenPorPArcialBTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReprobadosPorClaseGeneralTableAdapter = new General.desarrolloDataSetEliaTableAdapters.ReprobadosPorClaseGeneralTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sPCursoBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPCursoBTableAdapter = new General.desarrolloDataSetEliaTableAdapters.SPCursoBTableAdapter();
            this.tableAdapterManager = new General.desarrolloDataSetEliaTableAdapters.TableAdapterManager();
            this.sPCursoBComboBox = new System.Windows.Forms.ComboBox();
            this.cursoIdTextBox = new System.Windows.Forms.TextBox();
            this.sPSeccionBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPSeccionBTableAdapter = new General.desarrolloDataSetEliaTableAdapters.SPSeccionBTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.cursoIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.cursoIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sPSeccionBComboBox = new System.Windows.Forms.ComboBox();
            this.sPMateriaBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPMateriaBTableAdapter = new General.desarrolloDataSetEliaTableAdapters.SPMateriaBTableAdapter();
            this.fillToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cursoIDToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cursoIDToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.sPMateriaBComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReprobadosPorClaseGeneralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSetElia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPExamenPorPArcialBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCursoBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSeccionBBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPMateriaBBindingSource)).BeginInit();
            this.fillToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReprobadosPorClaseGeneralBindingSource
            // 
            this.ReprobadosPorClaseGeneralBindingSource.DataMember = "ReprobadosPorClaseGeneral";
            this.ReprobadosPorClaseGeneralBindingSource.DataSource = this.desarrolloDataSetElia;
            // 
            // desarrolloDataSetElia
            // 
            this.desarrolloDataSetElia.DataSetName = "desarrolloDataSetElia";
            this.desarrolloDataSetElia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SPExamenPorPArcialBBindingSource
            // 
            this.SPExamenPorPArcialBBindingSource.DataMember = "SPExamenPorPArcialB";
            this.SPExamenPorPArcialBBindingSource.DataSource = this.desarrolloDataSetElia;
            // 
            // SPExamenPorPArcialBTableAdapter
            // 
            this.SPExamenPorPArcialBTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "desarrolloDataSetElia";
            reportDataSource1.Value = this.ReprobadosPorClaseGeneralBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "General.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 173);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1135, 347);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ReprobadosPorClaseGeneralTableAdapter
            // 
            this.ReprobadosPorClaseGeneralTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(671, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Materia";
            // 
            // sPCursoBBindingSource
            // 
            this.sPCursoBBindingSource.DataMember = "SPCursoB";
            this.sPCursoBBindingSource.DataSource = this.desarrolloDataSetElia;
            // 
            // sPCursoBTableAdapter
            // 
            this.sPCursoBTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.UpdateOrder = General.desarrolloDataSetEliaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sPCursoBComboBox
            // 
            this.sPCursoBComboBox.DataSource = this.sPCursoBBindingSource;
            this.sPCursoBComboBox.DisplayMember = "Curso Nombre";
            this.sPCursoBComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sPCursoBComboBox.FormattingEnabled = true;
            this.sPCursoBComboBox.Location = new System.Drawing.Point(313, 110);
            this.sPCursoBComboBox.Name = "sPCursoBComboBox";
            this.sPCursoBComboBox.Size = new System.Drawing.Size(115, 21);
            this.sPCursoBComboBox.TabIndex = 4;
            this.sPCursoBComboBox.ValueMember = "CursoId";
            this.sPCursoBComboBox.SelectedIndexChanged += new System.EventHandler(this.sPCursoBComboBox_SelectedIndexChanged);
            // 
            // cursoIdTextBox
            // 
            this.cursoIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sPCursoBBindingSource, "CursoId", true));
            this.cursoIdTextBox.Location = new System.Drawing.Point(316, 112);
            this.cursoIdTextBox.Name = "cursoIdTextBox";
            this.cursoIdTextBox.Size = new System.Drawing.Size(36, 20);
            this.cursoIdTextBox.TabIndex = 6;
            this.cursoIdTextBox.TextChanged += new System.EventHandler(this.cursoIdTextBox_TextChanged);
            // 
            // sPSeccionBBindingSource
            // 
            this.sPSeccionBBindingSource.DataMember = "SPSeccionB";
            this.sPSeccionBBindingSource.DataSource = this.desarrolloDataSetElia;
            // 
            // sPSeccionBTableAdapter
            // 
            this.sPSeccionBTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursoIDToolStripLabel,
            this.cursoIDToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(775, 25);
            this.fillToolStrip.TabIndex = 7;
            this.fillToolStrip.Text = "fillToolStrip";
            this.fillToolStrip.Visible = false;
            // 
            // cursoIDToolStripLabel
            // 
            this.cursoIDToolStripLabel.Name = "cursoIDToolStripLabel";
            this.cursoIDToolStripLabel.Size = new System.Drawing.Size(50, 22);
            this.cursoIDToolStripLabel.Text = "cursoID:";
            // 
            // cursoIDToolStripTextBox
            // 
            this.cursoIDToolStripTextBox.Name = "cursoIDToolStripTextBox";
            this.cursoIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // sPSeccionBComboBox
            // 
            this.sPSeccionBComboBox.DataSource = this.sPSeccionBBindingSource;
            this.sPSeccionBComboBox.DisplayMember = "SecNombre";
            this.sPSeccionBComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sPSeccionBComboBox.FormattingEnabled = true;
            this.sPSeccionBComboBox.Location = new System.Drawing.Point(492, 110);
            this.sPSeccionBComboBox.Name = "sPSeccionBComboBox";
            this.sPSeccionBComboBox.Size = new System.Drawing.Size(115, 21);
            this.sPSeccionBComboBox.TabIndex = 7;
            this.sPSeccionBComboBox.ValueMember = "SecNombre";
            // 
            // sPMateriaBBindingSource
            // 
            this.sPMateriaBBindingSource.DataMember = "SPMateriaB";
            this.sPMateriaBBindingSource.DataSource = this.desarrolloDataSetElia;
            // 
            // sPMateriaBTableAdapter
            // 
            this.sPMateriaBTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip1
            // 
            this.fillToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursoIDToolStripLabel1,
            this.cursoIDToolStripTextBox1,
            this.fillToolStripButton1});
            this.fillToolStrip1.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip1.Name = "fillToolStrip1";
            this.fillToolStrip1.Size = new System.Drawing.Size(775, 25);
            this.fillToolStrip1.TabIndex = 8;
            this.fillToolStrip1.Text = "fillToolStrip1";
            this.fillToolStrip1.Visible = false;
            // 
            // cursoIDToolStripLabel1
            // 
            this.cursoIDToolStripLabel1.Name = "cursoIDToolStripLabel1";
            this.cursoIDToolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.cursoIDToolStripLabel1.Text = "cursoID:";
            // 
            // cursoIDToolStripTextBox1
            // 
            this.cursoIDToolStripTextBox1.Name = "cursoIDToolStripTextBox1";
            this.cursoIDToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton1
            // 
            this.fillToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton1.Name = "fillToolStripButton1";
            this.fillToolStripButton1.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton1.Text = "Fill";
            this.fillToolStripButton1.Click += new System.EventHandler(this.fillToolStripButton1_Click);
            // 
            // sPMateriaBComboBox
            // 
            this.sPMateriaBComboBox.DataSource = this.sPMateriaBBindingSource;
            this.sPMateriaBComboBox.DisplayMember = "NombreMateria";
            this.sPMateriaBComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sPMateriaBComboBox.FormattingEnabled = true;
            this.sPMateriaBComboBox.Location = new System.Drawing.Point(671, 110);
            this.sPMateriaBComboBox.Name = "sPMateriaBComboBox";
            this.sPMateriaBComboBox.Size = new System.Drawing.Size(115, 21);
            this.sPMateriaBComboBox.TabIndex = 9;
            this.sPMateriaBComboBox.ValueMember = "NombreMateria";
            this.sPMateriaBComboBox.SelectedIndexChanged += new System.EventHandler(this.sPMateriaBComboBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(849, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(849, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rango";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1062, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 52);
            this.button1.TabIndex = 12;
            this.button1.Text = "Generar reporte";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.label5.TabIndex = 22;
            this.label5.Text = "Instituto Francisco Morazán";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::General.Properties.Resources.Screenshot_2015_04_09_13_46_13;
            this.pictureBox3.Location = new System.Drawing.Point(1086, 12);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1075, 50);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1134, 94);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // ReporteReprobados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1159, 599);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sPMateriaBComboBox);
            this.Controls.Add(this.fillToolStrip1);
            this.Controls.Add(this.sPSeccionBComboBox);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.sPCursoBComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cursoIdTextBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReporteReprobados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de reprobados";
            this.Load += new System.EventHandler(this.ReporteReprobados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReprobadosPorClaseGeneralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSetElia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPExamenPorPArcialBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCursoBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSeccionBBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPMateriaBBindingSource)).EndInit();
            this.fillToolStrip1.ResumeLayout(false);
            this.fillToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource SPExamenPorPArcialBBindingSource;
        private desarrolloDataSetElia desarrolloDataSetElia;
        private desarrolloDataSetEliaTableAdapters.SPExamenPorPArcialBTableAdapter SPExamenPorPArcialBTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReprobadosPorClaseGeneralBindingSource;
        private desarrolloDataSetEliaTableAdapters.ReprobadosPorClaseGeneralTableAdapter ReprobadosPorClaseGeneralTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource sPCursoBBindingSource;
        private desarrolloDataSetEliaTableAdapters.SPCursoBTableAdapter sPCursoBTableAdapter;
        private desarrolloDataSetEliaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox sPCursoBComboBox;
        private System.Windows.Forms.TextBox cursoIdTextBox;
        private System.Windows.Forms.BindingSource sPSeccionBBindingSource;
        private desarrolloDataSetEliaTableAdapters.SPSeccionBTableAdapter sPSeccionBTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel cursoIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox cursoIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.ComboBox sPSeccionBComboBox;
        private System.Windows.Forms.BindingSource sPMateriaBBindingSource;
        private desarrolloDataSetEliaTableAdapters.SPMateriaBTableAdapter sPMateriaBTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip1;
        private System.Windows.Forms.ToolStripLabel cursoIDToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox cursoIDToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillToolStripButton1;
        private System.Windows.Forms.ComboBox sPMateriaBComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}