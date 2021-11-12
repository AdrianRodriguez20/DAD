
namespace Clinica
{
    partial class ViewAdministrativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAdministrativo));
            this.menuAdministrativo = new System.Windows.Forms.MenuStrip();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacarEtiquetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centroDeDíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdministrativo.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAdministrativo
            // 
            this.menuAdministrativo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuAdministrativo.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuAdministrativo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.centroDeDíaToolStripMenuItem,
            this.citaToolStripMenuItem,
            this.guardarActividadToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuAdministrativo.Location = new System.Drawing.Point(0, 0);
            this.menuAdministrativo.Name = "menuAdministrativo";
            this.menuAdministrativo.Size = new System.Drawing.Size(800, 38);
            this.menuAdministrativo.TabIndex = 2;
            this.menuAdministrativo.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem,
            this.crearPacienteToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.fichaToolStripMenuItem,
            this.sacarEtiquetasToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(78, 34);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // crearPacienteToolStripMenuItem
            // 
            this.crearPacienteToolStripMenuItem.Name = "crearPacienteToolStripMenuItem";
            this.crearPacienteToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.crearPacienteToolStripMenuItem.Text = "Crear";
            this.crearPacienteToolStripMenuItem.Click += new System.EventHandler(this.crearPacienteToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // fichaToolStripMenuItem
            // 
            this.fichaToolStripMenuItem.Name = "fichaToolStripMenuItem";
            this.fichaToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.fichaToolStripMenuItem.Text = "Ficha";
            // 
            // sacarEtiquetasToolStripMenuItem
            // 
            this.sacarEtiquetasToolStripMenuItem.Name = "sacarEtiquetasToolStripMenuItem";
            this.sacarEtiquetasToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.sacarEtiquetasToolStripMenuItem.Text = "Sacar Etiquetas";
            // 
            // centroDeDíaToolStripMenuItem
            // 
            this.centroDeDíaToolStripMenuItem.Name = "centroDeDíaToolStripMenuItem";
            this.centroDeDíaToolStripMenuItem.Size = new System.Drawing.Size(104, 34);
            this.centroDeDíaToolStripMenuItem.Text = "Centro de día";
            this.centroDeDíaToolStripMenuItem.Click += new System.EventHandler(this.centroDeDíaToolStripMenuItem_Click);
            // 
            // citaToolStripMenuItem
            // 
            this.citaToolStripMenuItem.Name = "citaToolStripMenuItem";
            this.citaToolStripMenuItem.Size = new System.Drawing.Size(45, 34);
            this.citaToolStripMenuItem.Text = "Cita";
            this.citaToolStripMenuItem.Click += new System.EventHandler(this.citaToolStripMenuItem_Click);
            // 
            // guardarActividadToolStripMenuItem
            // 
            this.guardarActividadToolStripMenuItem.Name = "guardarActividadToolStripMenuItem";
            this.guardarActividadToolStripMenuItem.Size = new System.Drawing.Size(129, 34);
            this.guardarActividadToolStripMenuItem.Text = "Guardar actividad";
            this.guardarActividadToolStripMenuItem.Click += new System.EventHandler(this.guardarActividadToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(42, 34);
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.aToolStripMenuItem1,
            this.aToolStripMenuItem2,
            this.aToolStripMenuItem3,
            this.aToolStripMenuItem4});
            this.menuStrip2.Location = new System.Drawing.Point(0, 38);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 38);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aToolStripMenuItem.Image")));
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(42, 34);
            // 
            // aToolStripMenuItem1
            // 
            this.aToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("aToolStripMenuItem1.Image")));
            this.aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            this.aToolStripMenuItem1.Size = new System.Drawing.Size(42, 34);
            // 
            // aToolStripMenuItem2
            // 
            this.aToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("aToolStripMenuItem2.Image")));
            this.aToolStripMenuItem2.Name = "aToolStripMenuItem2";
            this.aToolStripMenuItem2.Size = new System.Drawing.Size(42, 34);
            // 
            // aToolStripMenuItem3
            // 
            this.aToolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("aToolStripMenuItem3.Image")));
            this.aToolStripMenuItem3.Name = "aToolStripMenuItem3";
            this.aToolStripMenuItem3.Size = new System.Drawing.Size(42, 34);
            // 
            // aToolStripMenuItem4
            // 
            this.aToolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("aToolStripMenuItem4.Image")));
            this.aToolStripMenuItem4.Name = "aToolStripMenuItem4";
            this.aToolStripMenuItem4.Size = new System.Drawing.Size(42, 34);
            // 
            // ViewAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuAdministrativo);
            this.Name = "ViewAdministrativo";
            this.Text = "Administrativo";
            this.menuAdministrativo.ResumeLayout(false);
            this.menuAdministrativo.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAdministrativo;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centroDeDíaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem crearPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sacarEtiquetasToolStripMenuItem;
    }
}