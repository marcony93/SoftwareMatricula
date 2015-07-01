namespace General
{
    partial class ReprobadosParcial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReprobadosParcial));
            this.ReprobadosPorParcialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desarrolloDataSetElia = new General.desarrolloDataSetElia();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReprobadosPorParcialTableAdapter = new General.desarrolloDataSetEliaTableAdapters.ReprobadosPorParcialTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sPCursoBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPCursoBTableAdapter = new General.desarrolloDataSetEliaTableAdapters.SPCursoBTableAdapter();
            this.tableAdapterManager = new General.desarrolloDataSetEliaTableAdapters.TableAdapterManager();
            this.sPCursoBComboBox = new System.Windows.Forms.ComboBox();
            this.sPMateriaBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPMateriaBTableAdapter = new General.desarrolloDataSetEliaTableAdapters.SPMateriaBTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.cursoIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.cursoIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sPMateriaBComboBox = new System.Windows.Forms.ComboBox();
            this.sPSeccionBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPSeccionBTableAdapter = new General.desarrolloDataSetEliaTableAdapters.SPSeccionBTableAdapter();
            this.fillToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cursoIDToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cursoIDToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.sPSeccionBComboBox = new System.Windows.Forms.ComboBox();
            this.cursoIdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReprobadosPorParcialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSetElia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCursoBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMateriaBBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPSeccionBBindingSource)).BeginInit();
            this.fillToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ReprobadosPorParcialBindingSource
            // 
            this.ReprobadosPorParcialBindingSource.DataMember = "ReprobadosPorParcial";
            this.ReprobadosPorParcialBindingSource.DataSource = this.desarrolloDataSetElia;
            // 
            // desarrolloDataSetElia
            // 
            this.desarrolloDataSetElia.DataSetName = "desarrolloDataSetElia";
            this.desarrolloDataSetElia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "desarrolloDataSetElia";
            reportDataSource1.Value = this.ReprobadosPorParcialBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "General.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 173);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowProgress = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(1135, 414);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReprobadosPorParcialTableAdapter
            // 
            this.ReprobadosPorParcialTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Curso";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1016, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 52);
            this.button1.TabIndex = 16;
            this.button1.Text = "Generar reporte";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(783, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Rango";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(783, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 13;
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
            this.sPCursoBComboBox.Location = new System.Drawing.Point(246, 111);
            this.sPCursoBComboBox.Name = "sPCursoBComboBox";
            this.sPCursoBComboBox.Size = new System.Drawing.Size(115, 21);
            this.sPCursoBComboBox.TabIndex = 16;
            this.sPCursoBComboBox.ValueMember = "CursoId";
            this.sPCursoBComboBox.SelectedIndexChanged += new System.EventHandler(this.sPCursoBComboBox_SelectedIndexChanged);
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
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursoIDToolStripLabel,
            this.cursoIDToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(768, 25);
            this.fillToolStrip.TabIndex = 17;
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
            // sPMateriaBComboBox
            // 
            this.sPMateriaBComboBox.DataSource = this.sPMateriaBBindingSource;
            this.sPMateriaBComboBox.DisplayMember = "NombreMateria";
            this.sPMateriaBComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sPMateriaBComboBox.FormattingEnabled = true;
            this.sPMateriaBComboBox.Location = new System.Drawing.Point(51, 111);
            this.sPMateriaBComboBox.Name = "sPMateriaBComboBox";
            this.sPMateriaBComboBox.Size = new System.Drawing.Size(131, 21);
            this.sPMateriaBComboBox.TabIndex = 17;
            this.sPMateriaBComboBox.ValueMember = "NombreMateria";
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
            // fillToolStrip1
            // 
            this.fillToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursoIDToolStripLabel1,
            this.cursoIDToolStripTextBox1,
            this.fillToolStripButton1});
            this.fillToolStrip1.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip1.Name = "fillToolStrip1";
            this.fillToolStrip1.Size = new System.Drawing.Size(768, 25);
            this.fillToolStrip1.TabIndex = 18;
            this.fillToolStrip1.Text = "fillToolStrip1";
            this.fillToolStrip1.Visible = false;
            this.fillToolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillToolStrip1_ItemClicked);
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
            // sPSeccionBComboBox
            // 
            this.sPSeccionBComboBox.DataSource = this.sPSeccionBBindingSource;
            this.sPSeccionBComboBox.DisplayMember = "SecNombre";
            this.sPSeccionBComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sPSeccionBComboBox.FormattingEnabled = true;
            this.sPSeccionBComboBox.Location = new System.Drawing.Point(425, 111);
            this.sPSeccionBComboBox.Name = "sPSeccionBComboBox";
            this.sPSeccionBComboBox.Size = new System.Drawing.Size(115, 21);
            this.sPSeccionBComboBox.TabIndex = 18;
            this.sPSeccionBComboBox.ValueMember = "SecNombre";
            // 
            // cursoIdTextBox
            // 
            this.cursoIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sPCursoBBindingSource, "CursoId", true));
            this.cursoIdTextBox.Location = new System.Drawing.Point(284, 112);
            this.cursoIdTextBox.Name = "cursoIdTextBox";
            this.cursoIdTextBox.Size = new System.Drawing.Size(32, 20);
            this.cursoIdTextBox.TabIndex = 19;
            this.cursoIdTextBox.TextChanged += new System.EventHandler(this.cursoIdTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(604, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Parcial";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV"});
            this.comboBox1.Location = new System.Drawing.Point(604, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1134, 94);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DodgerBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 22);
            this.label6.TabIndex = 27;
            this.label6.Text = "Instituto Francisco Morazán";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::General.Properties.Resources.Screenshot_2015_04_09_13_46_13;
            this.pictureBox3.Location = new System.Drawing.Point(1086, 12);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
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
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // ReprobadosParcial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1159, 599);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sPSeccionBComboBox);
            this.Controls.Add(this.fillToolStrip1);
            this.Controls.Add(this.sPMateriaBComboBox);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.sPCursoBComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
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
            this.Name = "ReprobadosParcial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reprobados por parcial";
            this.Load += new System.EventHandler(this.ReprobadosParcial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReprobadosPorParcialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSetElia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCursoBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMateriaBBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPSeccionBBindingSource)).EndInit();
            this.fillToolStrip1.ResumeLayout(false);
            this.fillToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReprobadosPorParcialBindingSource;
        private desarrolloDataSetElia desarrolloDataSetElia;
        private desarrolloDataSetEliaTableAdapters.ReprobadosPorParcialTableAdapter ReprobadosPorParcialTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource sPCursoBBindingSource;
        private desarrolloDataSetEliaTableAdapters.SPCursoBTableAdapter sPCursoBTableAdapter;
        private desarrolloDataSetEliaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox sPCursoBComboBox;
        private System.Windows.Forms.BindingSource sPMateriaBBindingSource;
        private desarrolloDataSetEliaTableAdapters.SPMateriaBTableAdapter sPMateriaBTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel cursoIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox cursoIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.ComboBox sPMateriaBComboBox;
        private System.Windows.Forms.BindingSource sPSeccionBBindingSource;
        private desarrolloDataSetEliaTableAdapters.SPSeccionBTableAdapter sPSeccionBTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip1;
        private System.Windows.Forms.ToolStripLabel cursoIDToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox cursoIDToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillToolStripButton1;
        private System.Windows.Forms.ComboBox sPSeccionBComboBox;
        private System.Windows.Forms.TextBox cursoIdTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}