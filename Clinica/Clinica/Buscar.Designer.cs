
namespace Clinica
{
    partial class ViewBuscar
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
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNhc = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbDni = new System.Windows.Forms.TextBox();
            this.txbNhc = new System.Windows.Forms.TextBox();
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
            this.listViewPacientes.Location = new System.Drawing.Point(30, 114);
            this.listViewPacientes.Name = "listViewPacientes";
            this.listViewPacientes.Size = new System.Drawing.Size(723, 302);
            this.listViewPacientes.TabIndex = 0;
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
            this.ColumnaNhc.Width = 132;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(78, 31);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI";
            // 
            // lblNhc
            // 
            this.lblNhc.AutoSize = true;
            this.lblNhc.Location = new System.Drawing.Point(320, 31);
            this.lblNhc.Name = "lblNhc";
            this.lblNhc.Size = new System.Drawing.Size(30, 13);
            this.lblNhc.TabIndex = 2;
            this.lblNhc.Text = "NHC";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(603, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txbDni
            // 
            this.txbDni.Location = new System.Drawing.Point(81, 64);
            this.txbDni.Name = "txbDni";
            this.txbDni.Size = new System.Drawing.Size(100, 20);
            this.txbDni.TabIndex = 4;
            // 
            // txbNhc
            // 
            this.txbNhc.Location = new System.Drawing.Point(323, 64);
            this.txbNhc.Name = "txbNhc";
            this.txbNhc.Size = new System.Drawing.Size(100, 20);
            this.txbNhc.TabIndex = 5;
            // 
            // ViewBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbNhc);
            this.Controls.Add(this.txbDni);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblNhc);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.listViewPacientes);
            this.Name = "ViewBuscar";
            this.Text = "Buscar";
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
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNhc;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbDni;
        private System.Windows.Forms.TextBox txbNhc;
    }
}