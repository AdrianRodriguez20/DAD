
namespace Clinica
{
    partial class ViewSanitario
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacarEtiquetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actasClinicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarNotaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarActivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarTodasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizaciónEnCascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEnVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXTRAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.notesToolStripMenuItem,
            this.ventanasToolStripMenuItem,
            this.eXTRAToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.mDIToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarPacienteToolStripMenuItem,
            this.verFichaToolStripMenuItem,
            this.sacarEtiquetasToolStripMenuItem,
            this.actasClinicasToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // buscarPacienteToolStripMenuItem
            // 
            this.buscarPacienteToolStripMenuItem.Name = "buscarPacienteToolStripMenuItem";
            this.buscarPacienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.buscarPacienteToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.buscarPacienteToolStripMenuItem.Text = "Buscar";
            this.buscarPacienteToolStripMenuItem.Click += new System.EventHandler(this.buscarPacienteToolStripMenuItem_Click);
            // 
            // verFichaToolStripMenuItem
            // 
            this.verFichaToolStripMenuItem.Name = "verFichaToolStripMenuItem";
            this.verFichaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.verFichaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.verFichaToolStripMenuItem.Text = "Ver ficha";
            this.verFichaToolStripMenuItem.Click += new System.EventHandler(this.verFichaToolStripMenuItem_Click);
            // 
            // sacarEtiquetasToolStripMenuItem
            // 
            this.sacarEtiquetasToolStripMenuItem.Name = "sacarEtiquetasToolStripMenuItem";
            this.sacarEtiquetasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.sacarEtiquetasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.sacarEtiquetasToolStripMenuItem.Text = "Sacar etiquetas";
            // 
            // actasClinicasToolStripMenuItem
            // 
            this.actasClinicasToolStripMenuItem.Name = "actasClinicasToolStripMenuItem";
            this.actasClinicasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.actasClinicasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.actasClinicasToolStripMenuItem.Text = "Actas clínicas";
            this.actasClinicasToolStripMenuItem.Click += new System.EventHandler(this.actasClínicosToolStripMenuItem_Click);
            // 
            // notesToolStripMenuItem
            // 
            this.notesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarNotaToolStripMenuItem1,
            this.crearToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            this.notesToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notesToolStripMenuItem.Text = "Notas";
            // 
            // buscarNotaToolStripMenuItem1
            // 
            this.buscarNotaToolStripMenuItem1.Name = "buscarNotaToolStripMenuItem1";
            this.buscarNotaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.buscarNotaToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.buscarNotaToolStripMenuItem1.Text = "Buscar";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // ventanasToolStripMenuItem
            // 
            this.ventanasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizarToolStripMenuItem,
            this.maximizarToolStripMenuItem,
            this.cerrarActivaToolStripMenuItem,
            this.cerrarTodasToolStripMenuItem,
            this.visualizaciónEnCascadaToolStripMenuItem,
            this.verEnVerticalToolStripMenuItem});
            this.ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            this.ventanasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ventanasToolStripMenuItem.Text = "Ventanas";
            // 
            // minimizarToolStripMenuItem
            // 
            this.minimizarToolStripMenuItem.Name = "minimizarToolStripMenuItem";
            this.minimizarToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.minimizarToolStripMenuItem.Text = "Minimizar Todas";
            this.minimizarToolStripMenuItem.Click += new System.EventHandler(this.minimizarToolStripMenuItem_Click);
            // 
            // maximizarToolStripMenuItem
            // 
            this.maximizarToolStripMenuItem.Name = "maximizarToolStripMenuItem";
            this.maximizarToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.maximizarToolStripMenuItem.Text = "Maximizar Todas";
            this.maximizarToolStripMenuItem.Click += new System.EventHandler(this.maximizarToolStripMenuItem_Click);
            // 
            // cerrarActivaToolStripMenuItem
            // 
            this.cerrarActivaToolStripMenuItem.Name = "cerrarActivaToolStripMenuItem";
            this.cerrarActivaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cerrarActivaToolStripMenuItem.Text = "Cerrar Activa";
            this.cerrarActivaToolStripMenuItem.Click += new System.EventHandler(this.cerrarActivaToolStripMenuItem_Click);
            // 
            // cerrarTodasToolStripMenuItem
            // 
            this.cerrarTodasToolStripMenuItem.Name = "cerrarTodasToolStripMenuItem";
            this.cerrarTodasToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cerrarTodasToolStripMenuItem.Text = "Cerrar Todas";
            this.cerrarTodasToolStripMenuItem.Click += new System.EventHandler(this.cerrarTodasToolStripMenuItem_Click);
            // 
            // visualizaciónEnCascadaToolStripMenuItem
            // 
            this.visualizaciónEnCascadaToolStripMenuItem.Name = "visualizaciónEnCascadaToolStripMenuItem";
            this.visualizaciónEnCascadaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.visualizaciónEnCascadaToolStripMenuItem.Text = "Ver en Cascada";
            this.visualizaciónEnCascadaToolStripMenuItem.Click += new System.EventHandler(this.visualizaciónEnCascadaToolStripMenuItem_Click);
            // 
            // verEnVerticalToolStripMenuItem
            // 
            this.verEnVerticalToolStripMenuItem.Name = "verEnVerticalToolStripMenuItem";
            this.verEnVerticalToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.verEnVerticalToolStripMenuItem.Text = "Ver en Vertical";
            this.verEnVerticalToolStripMenuItem.Click += new System.EventHandler(this.verEnVerticalToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mDIToolStripMenuItem
            // 
            this.mDIToolStripMenuItem.Name = "mDIToolStripMenuItem";
            this.mDIToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // eXTRAToolStripMenuItem
            // 
            this.eXTRAToolStripMenuItem.Name = "eXTRAToolStripMenuItem";
            this.eXTRAToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.eXTRAToolStripMenuItem.Text = "EXTRA";
            this.eXTRAToolStripMenuItem.Click += new System.EventHandler(this.eXTRAToolStripMenuItem_Click);
            // 
            // ViewSanitario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewSanitario";
            this.Text = "Personal Sanitario";
            this.Load += new System.EventHandler(this.App_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem verFichaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem sacarEtiquetasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem actasClinicasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem buscarNotaToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarActivaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarTodasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizaciónEnCascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEnVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mDIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXTRAToolStripMenuItem;
    }
}