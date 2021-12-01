
namespace Tienda
{
    partial class InfoClothes
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
            this.infoClothe = new Componente.UserControl1();
            this.SuspendLayout();
            // 
            // infoClothe
            // 
            this.infoClothe.Location = new System.Drawing.Point(1, 2);
            this.infoClothe.Name = "infoClothe";
            this.infoClothe.Size = new System.Drawing.Size(249, 138);
            this.infoClothe.TabIndex = 0;
            // 
            // InfoClothes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 152);
            this.Controls.Add(this.infoClothe);
            this.Name = "InfoClothes";
            this.Text = "InfoClothes";
            this.Load += new System.EventHandler(this.InfoClothes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Componente.UserControl1 infoClothe;
    }
}