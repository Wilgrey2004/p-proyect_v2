namespace p_proyect.Modules.Entidades.Formularios.CompraForms
{
    partial class VerCarritoDeCompras
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
            this.CarritoDeCompras = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.CarritoDeCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // CarritoDeCompras
            // 
            this.CarritoDeCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarritoDeCompras.Location = new System.Drawing.Point(6, 169);
            this.CarritoDeCompras.Name = "CarritoDeCompras";
            this.CarritoDeCompras.RowHeadersWidth = 62;
            this.CarritoDeCompras.RowTemplate.Height = 28;
            this.CarritoDeCompras.Size = new System.Drawing.Size(1034, 738);
            this.CarritoDeCompras.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(23, 115);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(521, 44);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Lista de productos de la compra";
            // 
            // VerCarritoDeCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 938);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.CarritoDeCompras);
            this.Name = "VerCarritoDeCompras";
            this.Text = "VerCarritoDeCompras";
            this.Load += new System.EventHandler(this.VerCarritoDeCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarritoDeCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CarritoDeCompras;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}