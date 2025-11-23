namespace p_proyect.Modules.Entidades.Formularios.ClienteEspecialForms
{
    partial class ClienteEspecialSeleccionarParaVentaACredito
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
            this.ListadoDeClienteEspeciales = new System.Windows.Forms.DataGridView();
            this.MontoDeLaVenta = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.NombreDelCliente = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.CreditoRestanteDelCliente = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.Agregar_usuarios = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDeClienteEspeciales)).BeginInit();
            this.SuspendLayout();
            // 
            // ListadoDeClienteEspeciales
            // 
            this.ListadoDeClienteEspeciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoDeClienteEspeciales.Location = new System.Drawing.Point(349, 67);
            this.ListadoDeClienteEspeciales.Name = "ListadoDeClienteEspeciales";
            this.ListadoDeClienteEspeciales.Size = new System.Drawing.Size(611, 465);
            this.ListadoDeClienteEspeciales.TabIndex = 0;
            this.ListadoDeClienteEspeciales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadoDeClienteEspeciales_CellClick);
            // 
            // MontoDeLaVenta
            // 
            this.MontoDeLaVenta.AllowPromptAsInput = true;
            this.MontoDeLaVenta.AnimateReadOnly = false;
            this.MontoDeLaVenta.AsciiOnly = false;
            this.MontoDeLaVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MontoDeLaVenta.BeepOnError = false;
            this.MontoDeLaVenta.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MontoDeLaVenta.Depth = 0;
            this.MontoDeLaVenta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MontoDeLaVenta.HidePromptOnLeave = false;
            this.MontoDeLaVenta.HideSelection = true;
            this.MontoDeLaVenta.Hint = "Monto de la venta";
            this.MontoDeLaVenta.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.MontoDeLaVenta.LeadingIcon = null;
            this.MontoDeLaVenta.Location = new System.Drawing.Point(40, 124);
            this.MontoDeLaVenta.Mask = "";
            this.MontoDeLaVenta.MaxLength = 32767;
            this.MontoDeLaVenta.MouseState = MaterialSkin.MouseState.OUT;
            this.MontoDeLaVenta.Name = "MontoDeLaVenta";
            this.MontoDeLaVenta.PasswordChar = '\0';
            this.MontoDeLaVenta.PrefixSuffixText = null;
            this.MontoDeLaVenta.PromptChar = '_';
            this.MontoDeLaVenta.ReadOnly = false;
            this.MontoDeLaVenta.RejectInputOnFirstFailure = false;
            this.MontoDeLaVenta.ResetOnPrompt = true;
            this.MontoDeLaVenta.ResetOnSpace = true;
            this.MontoDeLaVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MontoDeLaVenta.SelectedText = "";
            this.MontoDeLaVenta.SelectionLength = 0;
            this.MontoDeLaVenta.SelectionStart = 0;
            this.MontoDeLaVenta.ShortcutsEnabled = true;
            this.MontoDeLaVenta.Size = new System.Drawing.Size(250, 48);
            this.MontoDeLaVenta.SkipLiterals = true;
            this.MontoDeLaVenta.TabIndex = 1;
            this.MontoDeLaVenta.TabStop = false;
            this.MontoDeLaVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MontoDeLaVenta.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MontoDeLaVenta.TrailingIcon = null;
            this.MontoDeLaVenta.UseSystemPasswordChar = false;
            this.MontoDeLaVenta.ValidatingType = null;
            // 
            // NombreDelCliente
            // 
            this.NombreDelCliente.AllowPromptAsInput = true;
            this.NombreDelCliente.AnimateReadOnly = false;
            this.NombreDelCliente.AsciiOnly = false;
            this.NombreDelCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NombreDelCliente.BeepOnError = false;
            this.NombreDelCliente.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NombreDelCliente.Depth = 0;
            this.NombreDelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NombreDelCliente.HidePromptOnLeave = false;
            this.NombreDelCliente.HideSelection = true;
            this.NombreDelCliente.Hint = "Nombre Del Cliente";
            this.NombreDelCliente.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.NombreDelCliente.LeadingIcon = null;
            this.NombreDelCliente.Location = new System.Drawing.Point(40, 241);
            this.NombreDelCliente.Mask = "";
            this.NombreDelCliente.MaxLength = 32767;
            this.NombreDelCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.NombreDelCliente.Name = "NombreDelCliente";
            this.NombreDelCliente.PasswordChar = '\0';
            this.NombreDelCliente.PrefixSuffixText = null;
            this.NombreDelCliente.PromptChar = '_';
            this.NombreDelCliente.ReadOnly = false;
            this.NombreDelCliente.RejectInputOnFirstFailure = false;
            this.NombreDelCliente.ResetOnPrompt = true;
            this.NombreDelCliente.ResetOnSpace = true;
            this.NombreDelCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NombreDelCliente.SelectedText = "";
            this.NombreDelCliente.SelectionLength = 0;
            this.NombreDelCliente.SelectionStart = 0;
            this.NombreDelCliente.ShortcutsEnabled = true;
            this.NombreDelCliente.Size = new System.Drawing.Size(250, 48);
            this.NombreDelCliente.SkipLiterals = true;
            this.NombreDelCliente.TabIndex = 2;
            this.NombreDelCliente.TabStop = false;
            this.NombreDelCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NombreDelCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NombreDelCliente.TrailingIcon = null;
            this.NombreDelCliente.UseSystemPasswordChar = false;
            this.NombreDelCliente.ValidatingType = null;
            // 
            // CreditoRestanteDelCliente
            // 
            this.CreditoRestanteDelCliente.AllowPromptAsInput = true;
            this.CreditoRestanteDelCliente.AnimateReadOnly = false;
            this.CreditoRestanteDelCliente.AsciiOnly = false;
            this.CreditoRestanteDelCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreditoRestanteDelCliente.BeepOnError = false;
            this.CreditoRestanteDelCliente.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.CreditoRestanteDelCliente.Depth = 0;
            this.CreditoRestanteDelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CreditoRestanteDelCliente.HidePromptOnLeave = false;
            this.CreditoRestanteDelCliente.HideSelection = true;
            this.CreditoRestanteDelCliente.Hint = "Credito Del Cliente";
            this.CreditoRestanteDelCliente.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.CreditoRestanteDelCliente.LeadingIcon = null;
            this.CreditoRestanteDelCliente.Location = new System.Drawing.Point(40, 315);
            this.CreditoRestanteDelCliente.Mask = "";
            this.CreditoRestanteDelCliente.MaxLength = 32767;
            this.CreditoRestanteDelCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.CreditoRestanteDelCliente.Name = "CreditoRestanteDelCliente";
            this.CreditoRestanteDelCliente.PasswordChar = '\0';
            this.CreditoRestanteDelCliente.PrefixSuffixText = null;
            this.CreditoRestanteDelCliente.PromptChar = '_';
            this.CreditoRestanteDelCliente.ReadOnly = false;
            this.CreditoRestanteDelCliente.RejectInputOnFirstFailure = false;
            this.CreditoRestanteDelCliente.ResetOnPrompt = true;
            this.CreditoRestanteDelCliente.ResetOnSpace = true;
            this.CreditoRestanteDelCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CreditoRestanteDelCliente.SelectedText = "";
            this.CreditoRestanteDelCliente.SelectionLength = 0;
            this.CreditoRestanteDelCliente.SelectionStart = 0;
            this.CreditoRestanteDelCliente.ShortcutsEnabled = true;
            this.CreditoRestanteDelCliente.Size = new System.Drawing.Size(250, 48);
            this.CreditoRestanteDelCliente.SkipLiterals = true;
            this.CreditoRestanteDelCliente.TabIndex = 3;
            this.CreditoRestanteDelCliente.TabStop = false;
            this.CreditoRestanteDelCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CreditoRestanteDelCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.CreditoRestanteDelCliente.TrailingIcon = null;
            this.CreditoRestanteDelCliente.UseSystemPasswordChar = false;
            this.CreditoRestanteDelCliente.ValidatingType = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(37, 91);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(42, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Venta";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(37, 219);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(162, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Informacion del cliente";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = global::p_proyect.Properties.Resources.Cancelar;
            this.materialButton1.Image = global::p_proyect.Properties.Resources.Cancelar;
            this.materialButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialButton1.Location = new System.Drawing.Point(128, 494);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(124, 36);
            this.materialButton1.TabIndex = 28;
            this.materialButton1.Text = "Cancelar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // Agregar_usuarios
            // 
            this.Agregar_usuarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Agregar_usuarios.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Agregar_usuarios.Depth = 0;
            this.Agregar_usuarios.HighEmphasis = true;
            this.Agregar_usuarios.Icon = global::p_proyect.Properties.Resources.Aceprtar;
            this.Agregar_usuarios.Image = global::p_proyect.Properties.Resources.Aceprtar;
            this.Agregar_usuarios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Agregar_usuarios.Location = new System.Drawing.Point(6, 494);
            this.Agregar_usuarios.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Agregar_usuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.Agregar_usuarios.Name = "Agregar_usuarios";
            this.Agregar_usuarios.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Agregar_usuarios.Size = new System.Drawing.Size(116, 36);
            this.Agregar_usuarios.TabIndex = 27;
            this.Agregar_usuarios.Text = "Agregar";
            this.Agregar_usuarios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Agregar_usuarios.UseAccentColor = true;
            this.Agregar_usuarios.UseVisualStyleBackColor = true;
            this.Agregar_usuarios.Click += new System.EventHandler(this.Agregar_usuarios_Click);
            // 
            // ClienteEspecialSeleccionarParaVentaACredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 538);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.Agregar_usuarios);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.CreditoRestanteDelCliente);
            this.Controls.Add(this.NombreDelCliente);
            this.Controls.Add(this.MontoDeLaVenta);
            this.Controls.Add(this.ListadoDeClienteEspeciales);
            this.Name = "ClienteEspecialSeleccionarParaVentaACredito";
            this.Text = "Seleccionar Cliente especial para pagar a acredito";
            this.Load += new System.EventHandler(this.ClienteEspecialSeleccionarParaVentaACredito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDeClienteEspeciales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListadoDeClienteEspeciales;
        private MaterialSkin.Controls.MaterialMaskedTextBox MontoDeLaVenta;
        private MaterialSkin.Controls.MaterialMaskedTextBox NombreDelCliente;
        private MaterialSkin.Controls.MaterialMaskedTextBox CreditoRestanteDelCliente;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton Agregar_usuarios;
    }
}