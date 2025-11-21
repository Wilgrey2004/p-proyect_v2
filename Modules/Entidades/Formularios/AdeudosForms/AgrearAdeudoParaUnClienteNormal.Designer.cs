namespace p_proyect.Modules.Entidades.Formularios.AdeudosForms
{
    partial class AgrearAdeudoParaUnClienteNormal
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.NombreDelCliente = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ContactoDelCliente = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.Agregar_usuarios = new MaterialSkin.Controls.MaterialButton();
            this.MontoDelAdeudo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.MontoDelAdeudo);
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.Agregar_usuarios);
            this.materialCard1.Controls.Add(this.ContactoDelCliente);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.NombreDelCliente);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 64);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(367, 456);
            this.materialCard1.TabIndex = 0;
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
            this.NombreDelCliente.Hint = "Nombre del Cliente *obligatorio";
            this.NombreDelCliente.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.NombreDelCliente.LeadingIcon = null;
            this.NombreDelCliente.Location = new System.Drawing.Point(20, 69);
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
            this.NombreDelCliente.Size = new System.Drawing.Size(326, 48);
            this.NombreDelCliente.SkipLiterals = true;
            this.NombreDelCliente.TabIndex = 4;
            this.NombreDelCliente.TabStop = false;
            this.NombreDelCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NombreDelCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NombreDelCliente.TrailingIcon = global::p_proyect.Properties.Resources.firma;
            this.NombreDelCliente.UseSystemPasswordChar = false;
            this.NombreDelCliente.ValidatingType = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(101, 28);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(164, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Informacion del Cliente";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // ContactoDelCliente
            // 
            this.ContactoDelCliente.AllowPromptAsInput = true;
            this.ContactoDelCliente.AnimateReadOnly = false;
            this.ContactoDelCliente.AsciiOnly = false;
            this.ContactoDelCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ContactoDelCliente.BeepOnError = false;
            this.ContactoDelCliente.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ContactoDelCliente.Depth = 0;
            this.ContactoDelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ContactoDelCliente.HidePromptOnLeave = false;
            this.ContactoDelCliente.HideSelection = true;
            this.ContactoDelCliente.Hint = "Contacto del cliente *obligatorio";
            this.ContactoDelCliente.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.ContactoDelCliente.LeadingIcon = null;
            this.ContactoDelCliente.Location = new System.Drawing.Point(20, 145);
            this.ContactoDelCliente.Mask = "";
            this.ContactoDelCliente.MaxLength = 32767;
            this.ContactoDelCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.ContactoDelCliente.Name = "ContactoDelCliente";
            this.ContactoDelCliente.PasswordChar = '\0';
            this.ContactoDelCliente.PrefixSuffixText = null;
            this.ContactoDelCliente.PromptChar = '_';
            this.ContactoDelCliente.ReadOnly = false;
            this.ContactoDelCliente.RejectInputOnFirstFailure = false;
            this.ContactoDelCliente.ResetOnPrompt = true;
            this.ContactoDelCliente.ResetOnSpace = true;
            this.ContactoDelCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ContactoDelCliente.SelectedText = "";
            this.ContactoDelCliente.SelectionLength = 0;
            this.ContactoDelCliente.SelectionStart = 0;
            this.ContactoDelCliente.ShortcutsEnabled = true;
            this.ContactoDelCliente.Size = new System.Drawing.Size(326, 48);
            this.ContactoDelCliente.SkipLiterals = true;
            this.ContactoDelCliente.TabIndex = 6;
            this.ContactoDelCliente.TabStop = false;
            this.ContactoDelCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ContactoDelCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ContactoDelCliente.TrailingIcon = global::p_proyect.Properties.Resources.llamada_telefonica;
            this.ContactoDelCliente.UseSystemPasswordChar = false;
            this.ContactoDelCliente.ValidatingType = null;
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
            this.materialButton1.Location = new System.Drawing.Point(121, 401);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(124, 36);
            this.materialButton1.TabIndex = 30;
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
            this.Agregar_usuarios.Location = new System.Drawing.Point(105, 334);
            this.Agregar_usuarios.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Agregar_usuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.Agregar_usuarios.Name = "Agregar_usuarios";
            this.Agregar_usuarios.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Agregar_usuarios.Size = new System.Drawing.Size(156, 36);
            this.Agregar_usuarios.TabIndex = 29;
            this.Agregar_usuarios.Text = "Crear Adeudo";
            this.Agregar_usuarios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Agregar_usuarios.UseAccentColor = true;
            this.Agregar_usuarios.UseVisualStyleBackColor = true;
            this.Agregar_usuarios.Click += new System.EventHandler(this.Agregar_usuarios_Click);
            // 
            // MontoDelAdeudo
            // 
            this.MontoDelAdeudo.AllowPromptAsInput = true;
            this.MontoDelAdeudo.AnimateReadOnly = false;
            this.MontoDelAdeudo.AsciiOnly = false;
            this.MontoDelAdeudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MontoDelAdeudo.BeepOnError = false;
            this.MontoDelAdeudo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MontoDelAdeudo.Depth = 0;
            this.MontoDelAdeudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MontoDelAdeudo.HidePromptOnLeave = false;
            this.MontoDelAdeudo.HideSelection = true;
            this.MontoDelAdeudo.Hint = "Monto del adeudo *obligatorio";
            this.MontoDelAdeudo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.MontoDelAdeudo.LeadingIcon = null;
            this.MontoDelAdeudo.Location = new System.Drawing.Point(20, 226);
            this.MontoDelAdeudo.Mask = "";
            this.MontoDelAdeudo.MaxLength = 32767;
            this.MontoDelAdeudo.MouseState = MaterialSkin.MouseState.OUT;
            this.MontoDelAdeudo.Name = "MontoDelAdeudo";
            this.MontoDelAdeudo.PasswordChar = '\0';
            this.MontoDelAdeudo.PrefixSuffixText = null;
            this.MontoDelAdeudo.PromptChar = '_';
            this.MontoDelAdeudo.ReadOnly = false;
            this.MontoDelAdeudo.RejectInputOnFirstFailure = false;
            this.MontoDelAdeudo.ResetOnPrompt = true;
            this.MontoDelAdeudo.ResetOnSpace = true;
            this.MontoDelAdeudo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MontoDelAdeudo.SelectedText = "";
            this.MontoDelAdeudo.SelectionLength = 0;
            this.MontoDelAdeudo.SelectionStart = 0;
            this.MontoDelAdeudo.ShortcutsEnabled = true;
            this.MontoDelAdeudo.Size = new System.Drawing.Size(326, 48);
            this.MontoDelAdeudo.SkipLiterals = true;
            this.MontoDelAdeudo.TabIndex = 31;
            this.MontoDelAdeudo.TabStop = false;
            this.MontoDelAdeudo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MontoDelAdeudo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MontoDelAdeudo.TrailingIcon = global::p_proyect.Properties.Resources.etiquetas_de_productos;
            this.MontoDelAdeudo.UseSystemPasswordChar = false;
            this.MontoDelAdeudo.ValidatingType = null;
            // 
            // AgrearAdeudoParaUnClienteNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 523);
            this.Controls.Add(this.materialCard1);
            this.Name = "AgrearAdeudoParaUnClienteNormal";
            this.Text = "Generar Adeudo";
            this.Load += new System.EventHandler(this.AgrearAdeudoParaUnClienteNormal_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialMaskedTextBox ContactoDelCliente;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox NombreDelCliente;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton Agregar_usuarios;
        private MaterialSkin.Controls.MaterialMaskedTextBox MontoDelAdeudo;
    }
}