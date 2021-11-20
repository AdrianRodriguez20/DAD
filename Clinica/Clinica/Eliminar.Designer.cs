
namespace Clinica
{
    partial class ViewEliminar
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
            this.listViewPacientes = new System.Windows.Forms.ListView();
            this.columnaNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaApellidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaDireccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaCodigoPostal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaPoblacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaDni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnaNhc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txbContenido = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbBuscarPor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listViewPacientes
            // 
            this.listViewPacientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaNombre,
            this.columnaApellidos,
            this.columnaDireccion,
            this.columnaCodigoPostal,
            this.columnaPoblacion,
            this.columnaDni,
            this.ColumnaNhc});
            this.listViewPacientes.HideSelection = false;
            this.listViewPacientes.Location = new System.Drawing.Point(55, 109);
            this.listViewPacientes.Name = "listViewPacientes";
            this.listViewPacientes.Size = new System.Drawing.Size(683, 302);
            this.listViewPacientes.TabIndex = 1;
            this.listViewPacientes.UseCompatibleStateImageBehavior = false;
            this.listViewPacientes.View = System.Windows.Forms.View.Details;
            this.listViewPacientes.SelectedIndexChanged += new System.EventHandler(this.listViewPacientes_SelectedIndexChanged);
            // 
            // columnaNombre
            // 
            this.columnaNombre.Text = "Nombre";
            this.columnaNombre.Width = 105;
            // 
            // columnaApellidos
            // 
            this.columnaApellidos.Text = "Apellidos";
            this.columnaApellidos.Width = 106;
            // 
            // columnaDireccion
            // 
            this.columnaDireccion.Text = "Dirección";
            this.columnaDireccion.Width = 109;
            // 
            // columnaCodigoPostal
            // 
            this.columnaCodigoPostal.Text = "Código Postal";
            this.columnaCodigoPostal.Width = 110;
            // 
            // columnaPoblacion
            // 
            this.columnaPoblacion.Text = "Poblacion";
            this.columnaPoblacion.Width = 103;
            // 
            // columnaDni
            // 
            this.columnaDni.Text = "DNI";
            this.columnaDni.Width = 82;
            // 
            // ColumnaNhc
            // 
            this.ColumnaNhc.Text = "NHC";
            this.ColumnaNhc.Width = 75;
            // 
            // txbContenido
            // 
            this.txbContenido.Location = new System.Drawing.Point(374, 54);
            this.txbContenido.Name = "txbContenido";
            this.txbContenido.Size = new System.Drawing.Size(100, 20);
            this.txbContenido.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(514, 52);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbBuscarPor
            // 
            this.cmbBuscarPor.FormattingEnabled = true;
            this.cmbBuscarPor.Items.AddRange(new object[] {
            "DNI",
            "NHC"});
            this.cmbBuscarPor.Location = new System.Drawing.Point(192, 53);
            this.cmbBuscarPor.Name = "cmbBuscarPor";
            this.cmbBuscarPor.Size = new System.Drawing.Size(121, 21);
            this.cmbBuscarPor.TabIndex = 8;
            // 
            // ViewEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbBuscarPor);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbContenido);
            this.Controls.Add(this.listViewPacientes);
            this.Name = "ViewEliminar";
            this.Text = "Eliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPacientes;
        private System.Windows.Forms.ColumnHeader columnaNombre;
        private System.Windows.Forms.ColumnHeader columnaApellidos;
        private System.Windows.Forms.ColumnHeader columnaDireccion;
        private System.Windows.Forms.ColumnHeader columnaCodigoPostal;
        private System.Windows.Forms.ColumnHeader columnaPoblacion;
        private System.Windows.Forms.ColumnHeader columnaDni;
        private System.Windows.Forms.ColumnHeader ColumnaNhc;
        private System.Windows.Forms.TextBox txbContenido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbBuscarPor;
    }
}