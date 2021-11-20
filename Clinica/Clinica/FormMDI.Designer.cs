
namespace Clinica
{
    partial class FormMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.elPadreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearHijoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarHijoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elPadreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // elPadreToolStripMenuItem
            // 
            this.elPadreToolStripMenuItem.Checked = true;
            this.elPadreToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.elPadreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearHijoToolStripMenuItem,
            this.cerrarHijoToolStripMenuItem});
            this.elPadreToolStripMenuItem.Name = "elPadreToolStripMenuItem";
            this.elPadreToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.elPadreToolStripMenuItem.Text = "El padre";
            // 
            // crearHijoToolStripMenuItem
            // 
            this.crearHijoToolStripMenuItem.Name = "crearHijoToolStripMenuItem";
            this.crearHijoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearHijoToolStripMenuItem.Text = "Crear hijo";
            this.crearHijoToolStripMenuItem.Click += new System.EventHandler(this.crearHijoToolStripMenuItem_Click);
            // 
            // cerrarHijoToolStripMenuItem
            // 
            this.cerrarHijoToolStripMenuItem.Name = "cerrarHijoToolStripMenuItem";
            this.cerrarHijoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarHijoToolStripMenuItem.Text = "Cerrar hijo";
            this.cerrarHijoToolStripMenuItem.Click += new System.EventHandler(this.cerrarHijoToolStripMenuItem_Click);
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMDI";
            this.Text = "FormMDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem elPadreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearHijoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarHijoToolStripMenuItem;
    }
}