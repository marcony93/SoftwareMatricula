namespace General
{
    partial class LogIn
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.desarrolloDataSet = new General.desarrolloDataSet();
            this.autentificacionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.autentificacionTableAdapter = new General.desarrolloDataSetTableAdapters.autentificacionTableAdapter();
            this.tableAdapterManager = new General.desarrolloDataSetTableAdapters.TableAdapterManager();
            this.mstroTipoLabel1 = new System.Windows.Forms.Label();
            this.usuarioBloqueadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBloqueadoTableAdapter = new General.desarrolloDataSetTableAdapters.UsuarioBloqueadoTableAdapter();
            this.mstroBlocLabel1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.autentificacionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.autentificacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autentificacionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBloqueadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autentificacionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autentificacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(69, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(72, 100);
            this.textBox1.MaxLength = 5000;
            this.textBox1.Name = "textBox1";
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox2.Location = new System.Drawing.Point(72, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(154, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(255, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // desarrolloDataSet
            // 
            this.desarrolloDataSet.DataSetName = "desarrolloDataSet";
            this.desarrolloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autentificacionBindingSource2
            // 
            this.autentificacionBindingSource2.DataMember = "autentificacion";
            this.autentificacionBindingSource2.DataSource = this.desarrolloDataSet;
            // 
            // autentificacionTableAdapter
            // 
            this.autentificacionTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.UpdateOrder = General.desarrolloDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mstroTipoLabel1
            // 
            this.mstroTipoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autentificacionBindingSource2, "MstroTipo", true));
            this.mstroTipoLabel1.Location = new System.Drawing.Point(266, 219);
            this.mstroTipoLabel1.Name = "mstroTipoLabel1";
            this.mstroTipoLabel1.Size = new System.Drawing.Size(50, 23);
            this.mstroTipoLabel1.TabIndex = 10;
            this.mstroTipoLabel1.Text = "label4";
            // 
            // usuarioBloqueadoBindingSource
            // 
            this.usuarioBloqueadoBindingSource.DataMember = "UsuarioBloqueado";
            this.usuarioBloqueadoBindingSource.DataSource = this.desarrolloDataSet;
            // 
            // usuarioBloqueadoTableAdapter
            // 
            this.usuarioBloqueadoTableAdapter.ClearBeforeFill = true;
            // 
            // mstroBlocLabel1
            // 
            this.mstroBlocLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBloqueadoBindingSource, "MstroBloc", true));
            this.mstroBlocLabel1.Location = new System.Drawing.Point(266, 219);
            this.mstroBlocLabel1.Name = "mstroBlocLabel1";
            this.mstroBlocLabel1.Size = new System.Drawing.Size(64, 23);
            this.mstroBlocLabel1.TabIndex = 12;
            this.mstroBlocLabel1.Text = "label4";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::General.Properties.Resources.Screenshot_2015_04_09_13_46_13;
            this.pictureBox3.Location = new System.Drawing.Point(287, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(12, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(284, 42);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 124);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // autentificacionBindingSource1
            // 
            this.autentificacionBindingSource1.DataMember = "autentificacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Instituto Francisco Morazán";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(345, 264);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mstroTipoLabel1);
            this.Controls.Add(this.mstroBlocLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autentificacionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBloqueadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autentificacionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autentificacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource autentificacionBindingSource;

        private System.Windows.Forms.BindingSource autentificacionBindingSource1;
        private desarrolloDataSet desarrolloDataSet;
        private System.Windows.Forms.BindingSource autentificacionBindingSource2;
        private desarrolloDataSetTableAdapters.autentificacionTableAdapter autentificacionTableAdapter;
        private desarrolloDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label mstroTipoLabel1;
        private System.Windows.Forms.BindingSource usuarioBloqueadoBindingSource;
        private desarrolloDataSetTableAdapters.UsuarioBloqueadoTableAdapter usuarioBloqueadoTableAdapter;
        private System.Windows.Forms.Label mstroBlocLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
    }
}

