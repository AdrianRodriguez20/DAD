
namespace Clinica
{
    partial class FichaPS
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
            this.listViewFicha = new System.Windows.Forms.ListView();
            this.columnaFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaMotivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaPreinscripción = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txbNhc = new System.Windows.Forms.TextBox();
            this.lblNhc = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewFicha
            // 
            this.listViewFicha.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaFecha,
            this.columnaMotivo,
            this.columnaPreinscripción});
            this.listViewFicha.HideSelection = false;
            this.listViewFicha.Location = new System.Drawing.Point(65, 114);
            this.listViewFicha.Name = "listViewFicha";
            this.listViewFicha.Size = new System.Drawing.Size(669, 276);
            this.listViewFicha.TabIndex = 0;
            this.listViewFicha.UseCompatibleStateImageBehavior = false;
            this.listViewFicha.View = System.Windows.Forms.View.Details;
            // 
            // columnaFecha
            // 
            this.columnaFecha.Text = "Fecha";
            this.columnaFecha.Width = 181;
            // 
            // columnaMotivo
            // 
            this.columnaMotivo.Text = "Motivo";
            this.columnaMotivo.Width = 240;
            // 
            // columnaPreinscripción
            // 
            this.columnaPreinscripción.Text = "Preinscripción";
            this.columnaPreinscripción.Width = 243;
            // 
            // txbNhc
            // 
            this.txbNhc.Location = new System.Drawing.Point(251, 61);
            this.txbNhc.Name = "txbNhc";
            this.txbNhc.Size = new System.Drawing.Size(100, 20);
            this.txbNhc.TabIndex = 6;
            // 
            // lblNhc
            // 
            this.lblNhc.AutoSize = true;
            this.lblNhc.Location = new System.Drawing.Point(248, 35);
            this.lblNhc.Name = "lblNhc";
            this.lblNhc.Size = new System.Drawing.Size(30, 13);
            this.lblNhc.TabIndex = 7;
            this.lblNhc.Text = "NHC";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(458, 59);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FichaPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblNhc);
            this.Controls.Add(this.txbNhc);
            this.Controls.Add(this.listViewFicha);
            this.Name = "FichaPS";
            this.Text = "FichaPS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewFicha;
        private System.Windows.Forms.ColumnHeader columnaFecha;
        private System.Windows.Forms.ColumnHeader columnaMotivo;
        private System.Windows.Forms.ColumnHeader columnaPreinscripción;
        private System.Windows.Forms.TextBox txbNhc;
        private System.Windows.Forms.Label lblNhc;
        private System.Windows.Forms.Button btnBuscar;
    }
}