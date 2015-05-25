namespace General
{
    partial class Ocupacion
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.desarrolloDataSet = new General.desarrolloDataSet();
            this.ocupacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ocupacionTableAdapter = new General.desarrolloDataSetTableAdapters.OcupacionTableAdapter();
            this.tableAdapterManager = new General.desarrolloDataSetTableAdapters.TableAdapterManager();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.spOcupacionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminars = new System.Windows.Forms.DataGridViewButtonColumn();
            this.spOcupacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desarrolloDataSet1 = new General.desarrolloDataSet1();
            this.spOcupacionTableAdapter = new General.desarrolloDataSet1TableAdapters.SpOcupacionTableAdapter();
            this.tableAdapterManager1 = new General.desarrolloDataSet1TableAdapters.TableAdapterManager();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocupacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spOcupacionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spOcupacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(327, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(121, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ocupacion";
            // 
            // desarrolloDataSet
            // 
            this.desarrolloDataSet.DataSetName = "desarrolloDataSet";
            this.desarrolloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ocupacionBindingSource
            // 
            this.ocupacionBindingSource.DataMember = "Ocupacion";
            this.ocupacionBindingSource.DataSource = this.desarrolloDataSet;
            // 
            // ocupacionTableAdapter
            // 
            this.ocupacionTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ModalidadTableAdapter = null;
            this.tableAdapterManager.NacionalidadTableAdapter = null;
            this.tableAdapterManager.NotasTableAdapter = null;
            this.tableAdapterManager.OcupacionTableAdapter = this.ocupacionTableAdapter;
            this.tableAdapterManager.ParentescoTableAdapter = null;
            this.tableAdapterManager.Planilla_ClaseTableAdapter = null;
            this.tableAdapterManager.SeccionTableAdapter = null;
            this.tableAdapterManager.SexoTableAdapter = null;
            this.tableAdapterManager.TelefonoAlumnoTableAdapter = null;
            this.tableAdapterManager.TipoSangreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = General.desarrolloDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // spOcupacionDataGridView
            // 
            this.spOcupacionDataGridView.AllowUserToAddRows = false;
            this.spOcupacionDataGridView.AutoGenerateColumns = false;
            this.spOcupacionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spOcupacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spOcupacionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.eliminars});
            this.spOcupacionDataGridView.DataSource = this.spOcupacionBindingSource;
            this.spOcupacionDataGridView.Location = new System.Drawing.Point(15, 153);
            this.spOcupacionDataGridView.Name = "spOcupacionDataGridView";
            this.spOcupacionDataGridView.ReadOnly = true;
            this.spOcupacionDataGridView.Size = new System.Drawing.Size(387, 191);
            this.spOcupacionDataGridView.TabIndex = 7;
            this.spOcupacionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.spOcupacionDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OcupId";
            this.dataGridViewTextBoxColumn1.HeaderText = "OcupId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OcupNombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ocupacion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // eliminars
            // 
            this.eliminars.HeaderText = "Eliminar";
            this.eliminars.Name = "eliminars";
            this.eliminars.ReadOnly = true;
            this.eliminars.Text = "Eliminar";
            // 
            // spOcupacionBindingSource
            // 
            this.spOcupacionBindingSource.DataMember = "SpOcupacion";
            this.spOcupacionBindingSource.DataSource = this.desarrolloDataSet1;
            // 
            // desarrolloDataSet1
            // 
            this.desarrolloDataSet1.DataSetName = "desarrolloDataSet1";
            this.desarrolloDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spOcupacionTableAdapter
            // 
            this.spOcupacionTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager1.UpdateOrder = General.desarrolloDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Instituto Francisco Morazan";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::General.Properties.Resources.Screenshot_2015_04_09_13_46_13;
            this.pictureBox4.Location = new System.Drawing.Point(347, 12);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(5, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(402, 50);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(4, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 65);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(5, 139);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(403, 215);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // Ocupacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(420, 366);
            this.Controls.Add(this.spOcupacionDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ocupacion";
            this.Text = "Ocupacion";
            this.Load += new System.EventHandler(this.Ocupacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocupacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spOcupacionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spOcupacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private desarrolloDataSet desarrolloDataSet;
        private System.Windows.Forms.BindingSource ocupacionBindingSource;
        private desarrolloDataSetTableAdapters.OcupacionTableAdapter ocupacionTableAdapter;
        private desarrolloDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private desarrolloDataSet1 desarrolloDataSet1;
        private System.Windows.Forms.BindingSource spOcupacionBindingSource;
        private desarrolloDataSet1TableAdapters.SpOcupacionTableAdapter spOcupacionTableAdapter;
        private desarrolloDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView spOcupacionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn eliminars;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}