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
            this.desarrolloDataSetmcha = new General.desarrolloDataSetmcha();
            this.selectProfesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectProfesorTableAdapter = new General.desarrolloDataSetmchaTableAdapters.SelectProfesorTableAdapter();
            this.tableAdapterManager = new General.desarrolloDataSetmchaTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.mstroIdTextBox = new System.Windows.Forms.TextBox();
            this.mstroNombre1TextBox = new System.Windows.Forms.TextBox();
            this.mstroNombre2TextBox = new System.Windows.Forms.TextBox();
            this.mstroApellido2TextBox = new System.Windows.Forms.TextBox();
            this.mstroApellido1TextBox = new System.Windows.Forms.TextBox();
            this.mstroFechaNacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mstroEmailTextBox = new System.Windows.Forms.TextBox();
            this.mstroDireccionTextBox = new System.Windows.Forms.TextBox();
            this.sexNombreComboBox = new System.Windows.Forms.ComboBox();
            this.mstroUsuTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSetmcha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectProfesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mstroIdLabel
            // 
            mstroIdLabel.AutoSize = true;
            mstroIdLabel.BackColor = System.Drawing.Color.White;
            mstroIdLabel.Location = new System.Drawing.Point(98, 89);
            mstroIdLabel.Name = "mstroIdLabel";
            mstroIdLabel.Size = new System.Drawing.Size(57, 13);
            mstroIdLabel.TabIndex = 22;
            mstroIdLabel.Text = "Maestro Id";
            // 
            // mstroNombre1Label
            // 
            mstroNombre1Label.AutoSize = true;
            mstroNombre1Label.BackColor = System.Drawing.Color.White;
            mstroNombre1Label.Location = new System.Drawing.Point(84, 146);
            mstroNombre1Label.Name = "mstroNombre1Label";
            mstroNombre1Label.Size = new System.Drawing.Size(76, 13);
            mstroNombre1Label.TabIndex = 23;
            mstroNombre1Label.Text = "Primer Nombre";
            // 
            // mstroNombre2Label
            // 
            mstroNombre2Label.AutoSize = true;
            mstroNombre2Label.BackColor = System.Drawing.Color.White;
            mstroNombre2Label.Location = new System.Drawing.Point(74, 196);
            mstroNombre2Label.Name = "mstroNombre2Label";
            mstroNombre2Label.Size = new System.Drawing.Size(90, 13);
            mstroNombre2Label.TabIndex = 24;
            mstroNombre2Label.Text = "Segundo Nombre";
            // 
            // mstroApellido2Label
            // 
            mstroApellido2Label.AutoSize = true;
            mstroApellido2Label.BackColor = System.Drawing.Color.White;
            mstroApellido2Label.Location = new System.Drawing.Point(76, 324);
            mstroApellido2Label.Name = "mstroApellido2Label";
            mstroApellido2Label.Size = new System.Drawing.Size(90, 13);
            mstroApellido2Label.TabIndex = 25;
            mstroApellido2Label.Text = "Segundo Apellido";
            // 
            // mstroApellido1Label
            // 
            mstroApellido1Label.AutoSize = true;
            mstroApellido1Label.BackColor = System.Drawing.Color.White;
            mstroApellido1Label.Location = new System.Drawing.Point(84, 263);
            mstroApellido1Label.Name = "mstroApellido1Label";
            mstroApellido1Label.Size = new System.Drawing.Size(76, 13);
            mstroApellido1Label.TabIndex = 26;
            mstroApellido1Label.Text = "Primer Apellido";
            // 
            // mstroFechaNacLabel
            // 
            mstroFechaNacLabel.AutoSize = true;
            mstroFechaNacLabel.BackColor = System.Drawing.Color.White;
            mstroFechaNacLabel.Location = new System.Drawing.Point(74, 390);
            mstroFechaNacLabel.Name = "mstroFechaNacLabel";
            mstroFechaNacLabel.Size = new System.Drawing.Size(93, 13);
            mstroFechaNacLabel.TabIndex = 27;
            mstroFechaNacLabel.Text = "Fecha Nacimiento";
            // 
            // mstroEmailLabel
            // 
            mstroEmailLabel.AutoSize = true;
            mstroEmailLabel.BackColor = System.Drawing.Color.White;
            mstroEmailLabel.Location = new System.Drawing.Point(360, 92);
            mstroEmailLabel.Name = "mstroEmailLabel";
            mstroEmailLabel.Size = new System.Drawing.Size(32, 13);
            mstroEmailLabel.TabIndex = 28;
            mstroEmailLabel.Text = "Email";
            // 
            // mstroDireccionLabel
            // 
            mstroDireccionLabel.AutoSize = true;
            mstroDireccionLabel.BackColor = System.Drawing.Color.White;
            mstroDireccionLabel.Location = new System.Drawing.Point(340, 161);
            mstroDireccionLabel.Name = "mstroDireccionLabel";
            mstroDireccionLabel.Size = new System.Drawing.Size(52, 13);
            mstroDireccionLabel.TabIndex = 29;
            mstroDireccionLabel.Text = "Direccion";
            // 
            // sexNombreLabel
            // 
            sexNombreLabel.AutoSize = true;
            sexNombreLabel.BackColor = System.Drawing.Color.White;
            sexNombreLabel.Location = new System.Drawing.Point(356, 214);
            sexNombreLabel.Name = "sexNombreLabel";
            sexNombreLabel.Size = new System.Drawing.Size(31, 13);
            sexNombreLabel.TabIndex = 30;
            sexNombreLabel.Text = "Sexo";
            // 
            // mstroUsuLabel
            // 
            mstroUsuLabel.AutoSize = true;
            mstroUsuLabel.BackColor = System.Drawing.Color.White;
            mstroUsuLabel.Location = new System.Drawing.Point(349, 293);
            mstroUsuLabel.Name = "mstroUsuLabel";
            mstroUsuLabel.Size = new System.Drawing.Size(43, 13);
            mstroUsuLabel.TabIndex = 31;
            mstroUsuLabel.Text = "Usuario";
            // 
            // desarrolloDataSetmcha
            // 
            this.desarrolloDataSetmcha.DataSetName = "desarrolloDataSetmcha";
            this.desarrolloDataSetmcha.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(563, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mstroIdTextBox
            // 
            this.mstroIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mstroIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectProfesorBindingSource, "MstroId", true));
            this.mstroIdTextBox.Enabled = false;
            this.mstroIdTextBox.Location = new System.Drawing.Point(172, 86);
            this.mstroIdTextBox.Name = "mstroIdTextBox";
            this.mstroIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.mstroIdTextBox.TabIndex = 23;
            // 
            // mstroNombre1TextBox
            // 
            this.mstroNombre1TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mstroNombre1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectProfesorBindingSource, "MstroNombre1", true));
            this.mstroNombre1TextBox.Enabled = false;
            this.mstroNombre1TextBox.Location = new System.Drawing.Point(172, 143);
            this.mstroNombre1TextBox.Name = "mstroNombre1TextBox";
            this.mstroNombre1TextBox.Size = new System.Drawing.Size(100, 20);
            this.mstroNombre1TextBox.TabIndex = 24;
            // 
            // mstroNombre2TextBox
            // 
            this.mstroNombre2TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mstroNombre2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectProfesorBindingSource, "MstroNombre2", true));
            this.mstroNombre2TextBox.Enabled = false;
            this.mstroNombre2TextBox.Location = new System.Drawing.Point(172, 196);
            this.mstroNombre2TextBox.Name = "mstroNombre2TextBox";
            this.mstroNombre2TextBox.Size = new System.Drawing.Size(100, 20);
            this.mstroNombre2TextBox.TabIndex = 25;
            // 
            // mstroApellido2TextBox
            // 
            this.mstroApellido2TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mstroApellido2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectProfesorBindingSource, "MstroApellido2", true));
            this.mstroApellido2TextBox.Enabled = false;
            this.mstroApellido2TextBox.Location = new System.Drawing.Point(172, 321);
            this.mstroApellido2TextBox.Name = "mstroApellido2TextBox";
            this.mstroApellido2TextBox.Size = new System.Drawing.Size(100, 20);
            this.mstroApellido2TextBox.TabIndex = 26;
            // 
            // mstroApellido1TextBox
            // 
            this.mstroApellido1TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mstroApellido1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectProfesorBindingSource, "MstroApellido1", true));
            this.mstroApellido1TextBox.Enabled = false;
            this.mstroApellido1TextBox.Location = new System.Drawing.Point(172, 263);
            this.mstroApellido1TextBox.Name = "mstroApellido1TextBox";
            this.mstroApellido1TextBox.Size = new System.Drawing.Size(100, 20);
            this.mstroApellido1TextBox.TabIndex = 27;
            // 
            // mstroFechaNacDateTimePicker
            // 
            this.mstroFechaNacDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.selectProfesorBindingSource, "MstroFechaNac", true));
            this.mstroFechaNacDateTimePicker.Enabled = false;
            this.mstroFechaNacDateTimePicker.Location = new System.Drawing.Point(172, 386);
            this.mstroFechaNacDateTimePicker.Name = "mstroFechaNacDateTimePicker";
            this.mstroFechaNacDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.mstroFechaNacDateTimePicker.TabIndex = 28;
            // 
            // mstroEmailTextBox
            // 
            this.mstroEmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mstroEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectProfesorBindingSource, "MstroEmail", true));
            this.mstroEmailTextBox.Enabled = false;
            this.mstroEmailTextBox.Location = new System.Drawing.Point(430, 89);
            this.mstroEmailTextBox.MaxLength = 50;
            this.mstroEmailTextBox.Name = "mstroEmailTextBox";
            this.mstroEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.mstroEmailTextBox.TabIndex = 29;
            // 
            // mstroDireccionTextBox
            // 
            this.mstroDireccionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mstroDireccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectProfesorBindingSource, "MstroDireccion", true));
            this.mstroDireccionTextBox.Enabled = false;
            this.mstroDireccionTextBox.Location = new System.Drawing.Point(430, 154);
            this.mstroDireccionTextBox.MaxLength = 200;
            this.mstroDireccionTextBox.Name = "mstroDireccionTextBox";
            this.mstroDireccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.mstroDireccionTextBox.TabIndex = 30;
            // 
            // sexNombreComboBox
            // 
            this.sexNombreComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sexNombreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectProfesorBindingSource, "SexNombre", true));
            this.sexNombreComboBox.Enabled = false;
            this.sexNombreComboBox.FormattingEnabled = true;
            this.sexNombreComboBox.Location = new System.Drawing.Point(430, 214);
            this.sexNombreComboBox.Name = "sexNombreComboBox";
            this.sexNombreComboBox.Size = new System.Drawing.Size(100, 21);
            this.sexNombreComboBox.TabIndex = 31;
            // 
            // mstroUsuTextBox
            // 
            this.mstroUsuTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mstroUsuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectProfesorBindingSource, "MstroUsu", true));
            this.mstroUsuTextBox.Enabled = false;
            this.mstroUsuTextBox.Location = new System.Drawing.Point(430, 290);
            this.mstroUsuTextBox.MaxLength = 25;
            this.mstroUsuTextBox.Name = "mstroUsuTextBox";
            this.mstroUsuTextBox.Size = new System.Drawing.Size(100, 20);
            this.mstroUsuTextBox.TabIndex = 32;
            this.mstroUsuTextBox.TextChanged += new System.EventHandler(this.mstroUsuTextBox_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(443, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 40);
            this.button2.TabIndex = 33;
            this.button2.Text = "Buscar Maestro";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::General.Properties.Resources.Screenshot_2015_04_09_13_46_13;
            this.pictureBox3.Location = new System.Drawing.Point(652, 6);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 59;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 22);
            this.label5.TabIndex = 61;
            this.label5.Text = "Instituto Francisco Morazan";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(9, 7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(691, 49);
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(21, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 360);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // modificarmaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(703, 474);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(mstroUsuLabel);
            this.Controls.Add(this.mstroUsuTextBox);
            this.Controls.Add(sexNombreLabel);
            this.Controls.Add(this.sexNombreComboBox);
            this.Controls.Add(mstroDireccionLabel);
            this.Controls.Add(this.mstroDireccionTextBox);
            this.Controls.Add(mstroEmailLabel);
            this.Controls.Add(this.mstroEmailTextBox);
            this.Controls.Add(mstroFechaNacLabel);
            this.Controls.Add(this.mstroFechaNacDateTimePicker);
            this.Controls.Add(mstroApellido1Label);
            this.Controls.Add(this.mstroApellido1TextBox);
            this.Controls.Add(mstroApellido2Label);
            this.Controls.Add(this.mstroApellido2TextBox);
            this.Controls.Add(mstroNombre2Label);
            this.Controls.Add(this.mstroNombre2TextBox);
            this.Controls.Add(mstroNombre1Label);
            this.Controls.Add(this.mstroNombre1TextBox);
            this.Controls.Add(mstroIdLabel);
            this.Controls.Add(this.mstroIdTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "modificarmaestro";
            this.Text = "Actualizar Maestro";
            this.Load += new System.EventHandler(this.modificarmaestro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSetmcha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectProfesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private desarrolloDataSetmcha desarrolloDataSetmcha;
        private System.Windows.Forms.BindingSource selectProfesorBindingSource;
        private desarrolloDataSetmchaTableAdapters.SelectProfesorTableAdapter selectProfesorTableAdapter;
        private desarrolloDataSetmchaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mstroIdTextBox;
        private System.Windows.Forms.TextBox mstroNombre1TextBox;
        private System.Windows.Forms.TextBox mstroNombre2TextBox;
        private System.Windows.Forms.TextBox mstroApellido2TextBox;
        private System.Windows.Forms.TextBox mstroApellido1TextBox;
        private System.Windows.Forms.DateTimePicker mstroFechaNacDateTimePicker;
        private System.Windows.Forms.TextBox mstroEmailTextBox;
        private System.Windows.Forms.TextBox mstroDireccionTextBox;
        private System.Windows.Forms.ComboBox sexNombreComboBox;
        private System.Windows.Forms.TextBox mstroUsuTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}