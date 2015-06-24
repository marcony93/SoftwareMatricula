namespace General
{
    partial class SubirNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubirNotas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.desarrolloDataSetElia = new General.desarrolloDataSetElia();
            this.tableAdapterManager = new General.desarrolloDataSetEliaTableAdapters.TableAdapterManager();
            this.sPSeccionBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPSeccionBTableAdapter = new General.desarrolloDataSetEliaTableAdapters.SPSeccionBTableAdapter();
            this.sPSeccionBComboBox = new System.Windows.Forms.ComboBox();
            this.sPMateriaBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPMateriaBTableAdapter = new General.desarrolloDataSetEliaTableAdapters.SPMateriaBTableAdapter();
            this.sPMateriaBComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sPAlumnosXClaseBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPAlumnosXClaseBTableAdapter = new General.desarrolloDataSetEliaTableAdapters.SPAlumnosXClaseBTableAdapter();
            this.sPAlumnosXClaseBDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.sPCursoBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPCursoBTableAdapter = new General.desarrolloDataSetEliaTableAdapters.SPCursoBTableAdapter();
            this.sPCursoBComboBox = new System.Windows.Forms.ComboBox();
            this.cursoIdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSetElia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSeccionBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMateriaBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPAlumnosXClaseBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPAlumnosXClaseBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCursoBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Materia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parcial";
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
            this.comboBox1.Location = new System.Drawing.Point(322, 96);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(63, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // desarrolloDataSetElia
            // 
            this.desarrolloDataSetElia.DataSetName = "desarrolloDataSetElia";
            this.desarrolloDataSetElia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sPSeccionBBindingSource
            // 
            this.sPSeccionBBindingSource.DataMember = "SPSeccionB";
            this.sPSeccionBBindingSource.DataSource = this.desarrolloDataSetElia;
            // 
            // sPSeccionBTableAdapter
            // 
            this.sPSeccionBTableAdapter.ClearBeforeFill = true;
            // 
            // sPSeccionBComboBox
            // 
            this.sPSeccionBComboBox.DataSource = this.sPSeccionBBindingSource;
            this.sPSeccionBComboBox.DisplayMember = "SecNombre";
            this.sPSeccionBComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sPSeccionBComboBox.FormattingEnabled = true;
            this.sPSeccionBComboBox.Location = new System.Drawing.Point(93, 102);
            this.sPSeccionBComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sPSeccionBComboBox.Name = "sPSeccionBComboBox";
            this.sPSeccionBComboBox.Size = new System.Drawing.Size(101, 23);
            this.sPSeccionBComboBox.TabIndex = 8;
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
            // sPMateriaBComboBox
            // 
            this.sPMateriaBComboBox.DataSource = this.sPMateriaBBindingSource;
            this.sPMateriaBComboBox.DisplayMember = "NombreMateria";
            this.sPMateriaBComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sPMateriaBComboBox.FormattingEnabled = true;
            this.sPMateriaBComboBox.Location = new System.Drawing.Point(322, 69);
            this.sPMateriaBComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sPMateriaBComboBox.Name = "sPMateriaBComboBox";
            this.sPMateriaBComboBox.Size = new System.Drawing.Size(152, 23);
            this.sPMateriaBComboBox.TabIndex = 9;
            this.sPMateriaBComboBox.ValueMember = "NombreMateria";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(469, 98);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sPAlumnosXClaseBBindingSource
            // 
            this.sPAlumnosXClaseBBindingSource.DataMember = "SPAlumnosXClaseB";
            this.sPAlumnosXClaseBBindingSource.DataSource = this.desarrolloDataSetElia;
            // 
            // sPAlumnosXClaseBTableAdapter
            // 
            this.sPAlumnosXClaseBTableAdapter.ClearBeforeFill = true;
            // 
            // sPAlumnosXClaseBDataGridView
            // 
            this.sPAlumnosXClaseBDataGridView.AllowUserToAddRows = false;
            this.sPAlumnosXClaseBDataGridView.AutoGenerateColumns = false;
            this.sPAlumnosXClaseBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sPAlumnosXClaseBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.NA,
            this.NE});
            this.sPAlumnosXClaseBDataGridView.DataSource = this.sPAlumnosXClaseBBindingSource;
            this.sPAlumnosXClaseBDataGridView.Location = new System.Drawing.Point(29, 160);
            this.sPAlumnosXClaseBDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sPAlumnosXClaseBDataGridView.Name = "sPAlumnosXClaseBDataGridView";
            this.sPAlumnosXClaseBDataGridView.Size = new System.Drawing.Size(526, 269);
            this.sPAlumnosXClaseBDataGridView.TabIndex = 11;
            this.sPAlumnosXClaseBDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sPAlumnosXClaseBDataGridView_CellContentClick);
            this.sPAlumnosXClaseBDataGridView.Leave += new System.EventHandler(this.sPAlumnosXClaseBDataGridView_Leave);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Alumno_AlumId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Identidad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Column1";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre del Alumno";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // NA
            // 
            this.NA.HeaderText = "NA";
            this.NA.MaxInputLength = 2;
            this.NA.Name = "NA";
            this.NA.Width = 30;
            // 
            // NE
            // 
            this.NE.HeaderText = "NE";
            this.NE.MaxInputLength = 2;
            this.NE.Name = "NE";
            this.NE.Width = 30;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(469, 435);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 27);
            this.button2.TabIndex = 12;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // sPCursoBComboBox
            // 
            this.sPCursoBComboBox.DataSource = this.sPCursoBBindingSource;
            this.sPCursoBComboBox.DisplayMember = "Curso Nombre";
            this.sPCursoBComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sPCursoBComboBox.FormattingEnabled = true;
            this.sPCursoBComboBox.Location = new System.Drawing.Point(93, 71);
            this.sPCursoBComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sPCursoBComboBox.Name = "sPCursoBComboBox";
            this.sPCursoBComboBox.Size = new System.Drawing.Size(143, 23);
            this.sPCursoBComboBox.TabIndex = 13;
            this.sPCursoBComboBox.ValueMember = "CursoId";
            this.sPCursoBComboBox.SelectedIndexChanged += new System.EventHandler(this.sPCursoBComboBox_SelectedIndexChanged);
            // 
            // cursoIdTextBox
            // 
            this.cursoIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sPCursoBBindingSource, "CursoId", true));
            this.cursoIdTextBox.Location = new System.Drawing.Point(93, 71);
            this.cursoIdTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cursoIdTextBox.Name = "cursoIdTextBox";
            this.cursoIdTextBox.Size = new System.Drawing.Size(132, 21);
            this.cursoIdTextBox.TabIndex = 14;
            this.cursoIdTextBox.TextChanged += new System.EventHandler(this.cursoIdTextBox_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Instituto Francisco Morazán";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::General.Properties.Resources.Screenshot_2015_04_09_13_46_13;
            this.pictureBox3.Location = new System.Drawing.Point(521, 5);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(7, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(574, 49);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(7, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 77);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(7, 143);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(574, 324);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // SubirNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(587, 474);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sPCursoBComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sPAlumnosXClaseBDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sPMateriaBComboBox);
            this.Controls.Add(this.sPSeccionBComboBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cursoIdTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SubirNotas";
            this.Text = "Subir Notas";
            this.Load += new System.EventHandler(this.SubirNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSetElia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSeccionBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMateriaBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPAlumnosXClaseBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPAlumnosXClaseBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCursoBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private desarrolloDataSetElia desarrolloDataSetElia;
        private desarrolloDataSetEliaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sPSeccionBBindingSource;
        private desarrolloDataSetEliaTableAdapters.SPSeccionBTableAdapter sPSeccionBTableAdapter;
        private System.Windows.Forms.ComboBox sPSeccionBComboBox;
        private System.Windows.Forms.BindingSource sPMateriaBBindingSource;
        private desarrolloDataSetEliaTableAdapters.SPMateriaBTableAdapter sPMateriaBTableAdapter;
        private System.Windows.Forms.ComboBox sPMateriaBComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource sPAlumnosXClaseBBindingSource;
        private desarrolloDataSetEliaTableAdapters.SPAlumnosXClaseBTableAdapter sPAlumnosXClaseBTableAdapter;
        private System.Windows.Forms.DataGridView sPAlumnosXClaseBDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NE;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource sPCursoBBindingSource;
        private desarrolloDataSetEliaTableAdapters.SPCursoBTableAdapter sPCursoBTableAdapter;
        private System.Windows.Forms.ComboBox sPCursoBComboBox;
        private System.Windows.Forms.TextBox cursoIdTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}