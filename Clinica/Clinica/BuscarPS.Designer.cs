
namespace Clinica
{
    partial class BuscarPS
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
            this.buscarPacienteTreeView = new System.Windows.Forms.TreeView();
            this.cmbBuscarPor = new System.Windows.Forms.ComboBox();
            this.txbContenido = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buscarPacienteTreeView
            // 
            this.buscarPacienteTreeView.Location = new System.Drawing.Point(50, 104);
            this.buscarPacienteTreeView.Name = "buscarPacienteTreeView";
            this.buscarPacienteTreeView.Size = new System.Drawing.Size(507, 246);
            this.buscarPacienteTreeView.TabIndex = 0;
            this.buscarPacienteTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.buscarPacienteTreeView_AfterSelect);
            // 
            // cmbBuscarPor
            // 
            this.cmbBuscarPor.FormattingEnabled = true;
            this.cmbBuscarPor.Items.AddRange(new object[] {
            "DNI",
            "NHC"});
            this.cmbBuscarPor.Location = new System.Drawing.Point(142, 48);
            this.cmbBuscarPor.Name = "cmbBuscarPor";
            this.cmbBuscarPor.Size = new System.Drawing.Size(121, 21);
            this.cmbBuscarPor.TabIndex = 9;
            // 
            // txbContenido
            // 
            this.txbContenido.Location = new System.Drawing.Point(283, 49);
            this.txbContenido.Name = "txbContenido";
            this.txbContenido.Size = new System.Drawing.Size(100, 20);
            this.txbContenido.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(401, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // BuscarPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 384);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbContenido);
            this.Controls.Add(this.cmbBuscarPor);
            this.Controls.Add(this.buscarPacienteTreeView);
            this.Name = "BuscarPS";
            this.Text = "BuscarPS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView buscarPacienteTreeView;
        private System.Windows.Forms.ComboBox cmbBuscarPor;
        private System.Windows.Forms.TextBox txbContenido;
        private System.Windows.Forms.Button btnBuscar;
    }
}