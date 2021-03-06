﻿namespace General
{
    partial class Ventana_General_Vista_Maestro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_General_Vista_Maestro));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subirNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarMiContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reprobadosPorParcialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reprobadosGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteHorarioMaestroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notasToolStripMenuItem,
            this.cambiarMiContraseñaToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
          
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subirNotasToolStripMenuItem});
            this.notasToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // subirNotasToolStripMenuItem
            // 
            this.subirNotasToolStripMenuItem.Name = "subirNotasToolStripMenuItem";
            this.subirNotasToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.subirNotasToolStripMenuItem.Text = "Subir Notas";
            this.subirNotasToolStripMenuItem.Click += new System.EventHandler(this.subirNotasToolStripMenuItem_Click);
            // 
            // cambiarMiContraseñaToolStripMenuItem
            // 
            this.cambiarMiContraseñaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambiarMiContraseñaToolStripMenuItem.Name = "cambiarMiContraseñaToolStripMenuItem";
            this.cambiarMiContraseñaToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.cambiarMiContraseñaToolStripMenuItem.Text = "Cambiar mi contraseña";
            this.cambiarMiContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarMiContraseñaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reprobadosPorParcialToolStripMenuItem,
            this.reprobadosGeneralToolStripMenuItem,
            this.reporteHorarioMaestroToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reprobadosPorParcialToolStripMenuItem
            // 
            this.reprobadosPorParcialToolStripMenuItem.Name = "reprobadosPorParcialToolStripMenuItem";
            this.reprobadosPorParcialToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.reprobadosPorParcialToolStripMenuItem.Text = "Reprobados por parcial";
            this.reprobadosPorParcialToolStripMenuItem.Click += new System.EventHandler(this.reprobadosPorParcialToolStripMenuItem_Click);
            // 
            // reprobadosGeneralToolStripMenuItem
            // 
            this.reprobadosGeneralToolStripMenuItem.Name = "reprobadosGeneralToolStripMenuItem";
            this.reprobadosGeneralToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.reprobadosGeneralToolStripMenuItem.Text = "Reprobados en general";
            this.reprobadosGeneralToolStripMenuItem.Click += new System.EventHandler(this.reprobadosGeneralToolStripMenuItem_Click);
            // 
            // reporteHorarioMaestroToolStripMenuItem
            // 
            this.reporteHorarioMaestroToolStripMenuItem.Name = "reporteHorarioMaestroToolStripMenuItem";
            this.reporteHorarioMaestroToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.reporteHorarioMaestroToolStripMenuItem.Text = "Reporte de horario del maestro";
            this.reporteHorarioMaestroToolStripMenuItem.Click += new System.EventHandler(this.reporteHorarioMaestroToolStripMenuItem_Click);
            // 
            // Ventana_General_Vista_Maestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(856, 705);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Ventana_General_Vista_Maestro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana general del maestro";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subirNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarMiContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reprobadosPorParcialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reprobadosGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteHorarioMaestroToolStripMenuItem;
    }
}