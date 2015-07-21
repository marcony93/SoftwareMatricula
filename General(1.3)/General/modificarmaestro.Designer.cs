namespace General
{
    partial class modificarmaestro
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
            System.Windows.Forms.Label mstroIdLabel;
            System.Windows.Forms.Label mstroNombre1Label;
            System.Windows.Forms.Label mstroNombre2Label;
            System.Windows.Forms.Label mstroApellido2Label;
            System.Windows.Forms.Label mstroApellido1Label;
            System.Windows.Forms.Label mstroFechaNacLabel;
            System.Windows.Forms.Label mstroEmailLabel;
            System.Windows.Forms.Label mstroDireccionLabel;
            System.Windows.Forms.Label sexNombreLabel;
            System.Windows.Forms.Label mstroUsuLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modificarmaestro));
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.desarrolloDataSetmcha = new General.desarrolloDataSetmcha();
            this.tableAdapterManager = new General.desarrolloDataSetmchaTableAdapters.TableAdapterManager();
            this.selectProfesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectProfesorTableAdapter = new General.desarrolloDataSetmchaTableAdapters.SelectProfesorTableAdapter();
            this.mstroIdTextBox = new System.Windows.Forms.TextBox();
            this.sexo_SexIdComboBox = new System.Windows.Forms.ComboBox();
            this.mstroNombre1TextBox = new System.Windows.Forms.TextBox();
            this.mstroNombre11TextBox = new System.Windows.Forms.TextBox();
            this.mstroApellido1TextBox = new System.Windows.Forms.TextBox();
            this.mstroApellido2TextBox = new System.Windows.Forms.TextBox();
            this.mstroFechaNacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mstroEmailTextBox = new System.Windows.Forms.TextBox();
            this.mstroUsuTextBox = new System.Windows.Forms.TextBox();
            this.mstroDireccionTextBox = new System.Windows.Forms.TextBox();
            mstroIdLabel = new System.Windows.Forms.Label();
            mstroNombre1Label = new System.Windows.Forms.Label();
            mstroNombre2Label = new System.Windows.Forms.Label();
            mstroApellido2Label = new System.Windows.Forms.Label();
            mstroApellido1Label = new System.Windows.Forms.Label();
            mstroFechaNacLabel = new System.Windows.Forms.Label();
            mstroEmailLabel = new System.Windows.Forms.Label();
            mstroDireccionLabel = new System.Windows.Forms.Label();
            sexNombreLabel = new System.Windows.Forms.Label();
            mstroUsuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSetmcha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectProfesorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mstroIdLabel
            // 
            mstroIdLabel.AutoSize = true;
            mstroIdLabel.BackColor = System.Drawing.Color.White;
            mstroIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mstroIdLabel.Location = new System.Drawing.Point(575, 89);
            mstroIdLabel.Name = "mstroIdLabel";
            mstroIdLabel.Size = new System.Drawing.Size(123, 15);
            mstroIdLabel.TabIndex = 22;
            mstroIdLabel.Text = "Número de identidad";
            // 
            // mstroNombre1Label
            // 
            mstroNombre1Label.AutoSize = true;
            mstroNombre1Label.BackColor = System.Drawing.Color.White;
            mstroNombre1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mstroNombre1Label.Location = new System.Drawing.Point(47, 89);
            mstroNombre1Label.Name = "mstroNombre1Label";
            mstroNombre1Label.Size = new System.Drawing.Size(90, 15);
            mstroNombre1Label.TabIndex = 23;
            mstroNombre1Label.Text = "Primer nombre";
            // 
            // mstroNombre2Label
            // 
            mstroNombre2Label.AutoSize = true;
            mstroNombre2Label.BackColor = System.Drawing.Color.White;
            mstroNombre2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mstroNombre2Label.Location = new System.Drawing.Point(179, 89);
            mstroNombre2Label.Name = "mstroNombre2Label";
            mstroNombre2Label.Size = new System.Drawing.Size(103, 15);
            mstroNombre2Label.TabIndex = 24;
            mstroNombre2Label.Text = "Segundo nombre";
            // 
            // mstroApellido2Label
            // 
            mstroApellido2Label.AutoSize = true;
            mstroApellido2Label.BackColor = System.Drawing.Color.White;
            mstroApellido2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mstroApellido2Label.Location = new System.Drawing.Point(443, 89);
            mstroApellido2Label.Name = "mstroApellido2Label";
            mstroApellido2Label.Size = new System.Drawing.Size(104, 15);
            mstroApellido2Label.TabIndex = 25;
            mstroApellido2Label.Text = "Segundo apellido";
            // 
            // mstroApellido1Label
            // 
            mstroApellido1Label.AutoSize = true;
            mstroApellido1Label.BackColor = System.Drawing.Color.White;
            mstroApellido1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mstroApellido1Label.Location = new System.Drawing.Point(311, 89);
            mstroApellido1Label.Name = "mstroApellido1Label";
            mstroApellido1Label.Size = new System.Drawing.Size(91, 15);
            mstroApellido1Label.TabIndex = 26;
            mstroApellido1Label.Text = "Primer apellido";
            // 
            // mstroFechaNacLabel
            // 
            mstroFechaNacLabel.AutoSize = true;
            mstroFechaNacLabel.BackColor = System.Drawing.Color.White;
            mstroFechaNacLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mstroFechaNacLabel.Location = new System.Drawing.Point(311, 224);
            mstroFechaNacLabel.Name = "mstroFechaNacLabel";
            mstroFechaNacLabel.Size = new System.Drawing.Size(122, 15);
            mstroFechaNacLabel.TabIndex = 27;
            mstroFechaNacLabel.Text = "Fecha de nacimiento";
            // 
            // mstroEmailLabel
            // 
            mstroEmailLabel.AutoSize = true;
            mstroEmailLabel.BackColor = System.Drawing.Color.White;
            mstroEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mstroEmailLabel.Location = new System.Drawing.Point(47, 153);
            mstroEmailLabel.Name = "mstroEmailLabel";
            mstroEmailLabel.Size = new System.Drawing.Size(108, 15);
            mstroEmailLabel.TabIndex = 28;
            mstroEmailLabel.Text = "Correo Electrónico";
            // 
            // mstroDireccionLabel
            // 
            mstroDireccionLabel.AutoSize = true;
            mstroDireccionLabel.BackColor = System.Drawing.Color.White;
            mstroDireccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mstroDireccionLabel.Location = new System.Drawing.Point(47, 224);
            mstroDireccionLabel.Name = "mstroDireccionLabel";
            mstroDireccionLabel.Size = new System.Drawing.Size(59, 15);
            mstroDireccionLabel.TabIndex = 29;
            mstroDireccionLabel.Text = "Dirección";
            // 
            // sexNombreLabel
            // 
            sexNombreLabel.AutoSize = true;
            sexNombreLabel.BackColor = System.Drawing.Color.White;
            sexNombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexNombreLabel.Location = new System.Drawing.Point(311, 153);
            sexNombreLabel.Name = "sexNombreLabel";
            sexNombreLabel.Size = new System.Drawing.Size(35, 15);
            sexNombreLabel.TabIndex = 30;
            sexNombreLabel.Text = "Sexo";
            // 
            // mstroUsuLabel
            // 
            mstroUsuLabel.AutoSize = true;
            mstroUsuLabel.BackColor = System.Drawing.Color.White;
            mstroUsuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mstroUsuLabel.Location = new System.Drawing.Point(443, 153);
            mstroUsuLabel.Name = "mstroUsuLabel";
            mstroUsuLabel.Size = new System.Drawing.Size(50, 15);
            mstroUsuLabel.TabIndex = 31;
            mstroUsuLabel.Text = "Usuario";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(650, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 22;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(565, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 33;
            this.button2.Text = "Buscar maestro";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::General.Properties.Resources.Screenshot_2015_04_09_13_46_13;
            this.pictureBox3.Location = new System.Drawing.Point(663, 12);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 59;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 22);
            this.label5.TabIndex = 61;
            this.label5.Text = "Instituto Francisco Morazán";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(653, 50);
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.selectProfesorBindingSource, "MstroDireccion", true));
            this.pictureBox1.Location = new System.Drawing.Point(12, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(713, 298);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // desarrolloDataSetmcha
            // 
            this.desarrolloDataSetmcha.DataSetName = "desarrolloDataSetmcha";
            this.desarrolloDataSetmcha.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.UpdateOrder = General.desarrolloDataSetmchaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // selectProfesorBindingSource
            // 
            this.selectProfesorBindingSource.DataMember = "SelectProfesor";
            this.selectProfesorBindingSource.DataSource = this.desarrolloDataSetmcha;
            // 
            // selectProfesorTableAdapter
            // 
            this.selectProfesorTableAdapter.ClearBeforeFill = true;
            // 
            // mstroIdTextBox
            // 
            this.mstroIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectProfesorBindingSource, "MstroId", true));
            this.mstroIdTextBox.Enabled = false;
            this.mstroIdTextBox.Location = new System.Drawing.Point(575, 119);
            this.mstroIdTextBox.Name = "mstroIdTextBox";
            this.mstroIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.mstroIdTextBox.TabIndex = 68;
            // 
            // sexo_SexIdComboBox
            // 
            this.sexo_SexIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectProfesorBindingSource, "Sexo_SexId", true));
            this.sexo_SexIdComboBox.FormattingEnabled = true;
            this.sexo_SexIdComboBox.Location = new System.Drawing.Point(311, 172);
            this.sexo_SexIdComboBox.Name = "sexo_SexIdComboBox";
            this.sexo_SexIdComboBox.Size = new System.Drawing.Size(100, 21);
            this.sexo_SexIdComboBox.TabIndex = 66;
            // 
            // mstroNombre1TextBox
            // 
            this.mstroNombre1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectProfesorBindingSource, "MstroNombre1", true));
            this.mstroNombre1TextBox.Enabled = false;
            this.mstroNombre1TextBox.Location = new System.Drawing.Point(47, 119);
            this.mstroNombre1TextBox.Name = "mstroNombre1TextBox";
            this.mstroNombre1TextBox.Size = new System.Drawing.Size(100, 20);
            this.mstroNombre1TextBox.TabIndex = 68;
            // 
            // mstroNombre11TextBox
            // 
            this.mstroNombre11TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectProfesorBindingSource, "MstroNombre11", true));
            this.mstroNombre11TextBox.Enabled = false;
            this.mstroNombre11TextBox.Location = new System.Drawing.Point(179, 119);
            this.mstroNombre11TextBox.Name = "mstroNombre11TextBox";
            this.mstroNombre11TextBox.Size = new System.Drawing.Size(100, 20);
            this.mstroNombre11TextBox.TabIndex = 68;
            // 
            // mstroApellido1TextBox
            // 
            this.mstroApellido1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectProfesorBindingSource, "MstroApellido1", true));
            this.mstroApellido1TextBox.Enabled = false;
            this.mstroApellido1TextBox.Location = new System.Drawing.Point(311, 119);
            this.mstroApellido1TextBox.Name = "mstroApellido1TextBox";
            this.mstroApellido1TextBox.Size = new System.Drawing.Size(100, 20);
            this.mstroApellido1TextBox.TabIndex = 68;
            // 
            // mstroApellido2TextBox
            // 
            this.mstroApellido2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectProfesorBindingSource, "MstroApellido2", true));
            this.mstroApellido2TextBox.Enabled = false;
            this.mstroApellido2TextBox.Location = new System.Drawing.Point(443, 119);
            this.mstroApellido2TextBox.Name = "mstroApellido2TextBox";
            this.mstroApellido2TextBox.Size = new System.Drawing.Size(100, 20);
            this.mstroApellido2TextBox.TabIndex = 68;
            // 
            // mstroFechaNacDateTimePicker
            // 
            this.mstroFechaNacDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.selectProfesorBindingSource, "MstroFechaNac", true));
            this.mstroFechaNacDateTimePicker.Enabled = false;
            this.mstroFechaNacDateTimePicker.Location = new System.Drawing.Point(311, 242);
            this.mstroFechaNacDateTimePicker.Name = "mstroFechaNacDateTimePicker";
            this.mstroFechaNacDateTimePicker.Size = new System.Drawing.Size(232, 20);
            this.mstroFechaNacDateTimePicker.TabIndex = 71;
            // 
            // mstroEmailTextBox
            // 
            this.mstroEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectProfesorBindingSource, "MstroEmail", true));
            this.mstroEmailTextBox.Enabled = false;
            this.mstroEmailTextBox.Location = new System.Drawing.Point(47, 172);
            this.mstroEmailTextBox.Name = "mstroEmailTextBox";
            this.mstroEmailTextBox.Size = new System.Drawing.Size(226, 20);
            this.mstroEmailTextBox.TabIndex = 72;
            // 
            // mstroUsuTextBox
            // 
            this.mstroUsuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectProfesorBindingSource, "MstroUsu", true));
            this.mstroUsuTextBox.Enabled = false;
            this.mstroUsuTextBox.Location = new System.Drawing.Point(443, 172);
            this.mstroUsuTextBox.Name = "mstroUsuTextBox";
            this.mstroUsuTextBox.Size = new System.Drawing.Size(100, 20);
            this.mstroUsuTextBox.TabIndex = 73;
            // 
            // mstroDireccionTextBox
            // 
            this.mstroDireccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectProfesorBindingSource, "MstroDireccion", true));
            this.mstroDireccionTextBox.Enabled = false;
            this.mstroDireccionTextBox.Location = new System.Drawing.Point(47, 242);
            this.mstroDireccionTextBox.Multiline = true;
            this.mstroDireccionTextBox.Name = "mstroDireccionTextBox";
            this.mstroDireccionTextBox.Size = new System.Drawing.Size(226, 69);
            this.mstroDireccionTextBox.TabIndex = 74;
            // 
            // modificarmaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(745, 612);
            this.ControlBox = false;
            this.Controls.Add(this.mstroDireccionTextBox);
            this.Controls.Add(this.mstroUsuTextBox);
            this.Controls.Add(this.mstroEmailTextBox);
            this.Controls.Add(this.mstroFechaNacDateTimePicker);
            this.Controls.Add(this.mstroApellido2TextBox);
            this.Controls.Add(this.mstroApellido1TextBox);
            this.Controls.Add(this.mstroNombre11TextBox);
            this.Controls.Add(this.mstroNombre1TextBox);
            this.Controls.Add(this.sexo_SexIdComboBox);
            this.Controls.Add(this.mstroIdTextBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(mstroUsuLabel);
            this.Controls.Add(sexNombreLabel);
            this.Controls.Add(mstroDireccionLabel);
            this.Controls.Add(mstroEmailLabel);
            this.Controls.Add(mstroFechaNacLabel);
            this.Controls.Add(mstroApellido1Label);
            this.Controls.Add(mstroApellido2Label);
            this.Controls.Add(mstroNombre2Label);
            this.Controls.Add(mstroNombre1Label);
            this.Controls.Add(mstroIdLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modificarmaestro";
            this.Text = "Actualizar Maestro";
            this.Load += new System.EventHandler(this.modificarmaestro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSetmcha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectProfesorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private desarrolloDataSetmcha desarrolloDataSetmcha;
        private desarrolloDataSetmchaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource selectProfesorBindingSource;
        private desarrolloDataSetmchaTableAdapters.SelectProfesorTableAdapter selectProfesorTableAdapter;
        private System.Windows.Forms.TextBox mstroIdTextBox;
        private System.Windows.Forms.ComboBox sexo_SexIdComboBox;
        private System.Windows.Forms.TextBox mstroDireccionTextBox;
        private System.Windows.Forms.TextBox mstroUsuTextBox;
        private System.Windows.Forms.TextBox mstroEmailTextBox;
        private System.Windows.Forms.DateTimePicker mstroFechaNacDateTimePicker;
        private System.Windows.Forms.TextBox mstroApellido2TextBox;
        private System.Windows.Forms.TextBox mstroApellido1TextBox;
        private System.Windows.Forms.TextBox mstroNombre11TextBox;
        private System.Windows.Forms.TextBox mstroNombre1TextBox;
    }
}