
namespace Tienda
{
    partial class BasketView
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
            this.btnCantidad = new System.Windows.Forms.Label();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridViewBasket = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBasket)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCantidad
            // 
            this.btnCantidad.AutoSize = true;
            this.btnCantidad.BackColor = System.Drawing.Color.Transparent;
            this.btnCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantidad.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCantidad.Location = new System.Drawing.Point(105, 104);
            this.btnCantidad.Name = "btnCantidad";
            this.btnCantidad.Size = new System.Drawing.Size(74, 18);
            this.btnCantidad.TabIndex = 2;
            this.btnCantidad.Text = "Cantidad";
            // 
            // txbCantidad
            // 
            this.txbCantidad.Location = new System.Drawing.Point(244, 105);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(147, 20);
            this.txbCantidad.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(434, 86);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(127, 52);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridViewBasket
            // 
            this.dataGridViewBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBasket.Location = new System.Drawing.Point(108, 203);
            this.dataGridViewBasket.Name = "dataGridViewBasket";
            this.dataGridViewBasket.Size = new System.Drawing.Size(428, 109);
            this.dataGridViewBasket.TabIndex = 6;
            // 
            // BasketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tienda.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(669, 391);
            this.Controls.Add(this.dataGridViewBasket);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.btnCantidad);
            this.Name = "BasketView";
            this.ShowIcon = false;
            this.Text = "Basket";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBasket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnCantidad;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridViewBasket;
    }
}