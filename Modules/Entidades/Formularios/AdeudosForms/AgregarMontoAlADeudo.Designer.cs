namespace p_proyect.Modules.Entidades.Formularios.AdeudosForms
{
    partial class AgregarMontoAlADeudo
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
            this.MontoTotalDelAdeudo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.AbonoDelAdeudo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.Agregar_usuarios = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.Agregar_usuarios);
            this.materialCard1.Controls.Add(this.AbonoDelAdeudo);
            this.materialCard1.Controls.Add(this.MontoTotalDelAdeudo);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 64);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(412, 477);
            this.materialCard1.TabIndex = 0;
            // 
            // MontoTotalDelAdeudo
            // 
            this.MontoTotalDelAdeudo.AllowPromptAsInput = true;
            this.MontoTotalDelAdeudo.AnimateReadOnly = false;
            this.MontoTotalDelAdeudo.AsciiOnly = false;
            this.MontoTotalDelAdeudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MontoTotalDelAdeudo.BeepOnError = false;
            this.MontoTotalDelAdeudo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MontoTotalDelAdeudo.Depth = 0;
            this.MontoTotalDelAdeudo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MontoTotalDelAdeudo.HidePromptOnLeave = false;
            this.MontoTotalDelAdeudo.HideSelection = true;
            this.MontoTotalDelAdeudo.Hint = "Monto De La Deuda";
            this.MontoTotalDelAdeudo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.MontoTotalDelAdeudo.LeadingIcon = global::p_proyect.Properties.Resources.bruto;
            this.MontoTotalDelAdeudo.Location = new System.Drawing.Point(16, 90);
            this.MontoTotalDelAdeudo.Mask = "";
            this.MontoTotalDelAdeudo.MaxLength = 32767;
            this.MontoTotalDelAdeudo.MouseState = MaterialSkin.MouseState.OUT;
            this.MontoTotalDelAdeudo.Name = "MontoTotalDelAdeudo";
            this.MontoTotalDelAdeudo.PasswordChar = '\0';
            this.MontoTotalDelAdeudo.PrefixSuffixText = null;
            this.MontoTotalDelAdeudo.PromptChar = '_';
            this.MontoTotalDelAdeudo.ReadOnly = true;
            this.MontoTotalDelAdeudo.RejectInputOnFirstFailure = false;
            this.MontoTotalDelAdeudo.ResetOnPrompt = true;
            this.MontoTotalDelAdeudo.ResetOnSpace = true;
            this.MontoTotalDelAdeudo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MontoTotalDelAdeudo.SelectedText = "";
            this.MontoTotalDelAdeudo.SelectionLength = 0;
            this.MontoTotalDelAdeudo.SelectionStart = 0;
            this.MontoTotalDelAdeudo.ShortcutsEnabled = true;
            this.MontoTotalDelAdeudo.Size = new System.Drawing.Size(378, 48);
            this.MontoTotalDelAdeudo.SkipLiterals = true;
            this.MontoTotalDelAdeudo.TabIndex = 0;
            this.MontoTotalDelAdeudo.TabStop = false;
            this.MontoTotalDelAdeudo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MontoTotalDelAdeudo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MontoTotalDelAdeudo.TrailingIcon = null;
            this.MontoTotalDelAdeudo.UseSystemPasswordChar = false;
            this.MontoTotalDelAdeudo.ValidatingType = null;
            // 
            // AbonoDelAdeudo
            // 
            this.AbonoDelAdeudo.AllowPromptAsInput = true;
            this.AbonoDelAdeudo.AnimateReadOnly = false;
            this.AbonoDelAdeudo.AsciiOnly = false;
            this.AbonoDelAdeudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AbonoDelAdeudo.BeepOnError = false;
            this.AbonoDelAdeudo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.AbonoDelAdeudo.Depth = 0;
            this.AbonoDelAdeudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AbonoDelAdeudo.HidePromptOnLeave = false;
            this.AbonoDelAdeudo.HideSelection = true;
            this.AbonoDelAdeudo.Hint = "Abono para el adeudo";
            this.AbonoDelAdeudo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.AbonoDelAdeudo.LeadingIcon = global::p_proyect.Properties.Resources.Edad;
            this.AbonoDelAdeudo.Location = new System.Drawing.Point(16, 174);
            this.AbonoDelAdeudo.Mask = "";
            this.AbonoDelAdeudo.MaxLength = 32767;
            this.AbonoDelAdeudo.MouseState = MaterialSkin.MouseState.OUT;
            this.AbonoDelAdeudo.Name = "AbonoDelAdeudo";
            this.AbonoDelAdeudo.PasswordChar = '\0';
            this.AbonoDelAdeudo.PrefixSuffixText = null;
            this.AbonoDelAdeudo.PromptChar = '_';
            this.AbonoDelAdeudo.ReadOnly = false;
            this.AbonoDelAdeudo.RejectInputOnFirstFailure = false;
            this.AbonoDelAdeudo.ResetOnPrompt = true;
            this.AbonoDelAdeudo.ResetOnSpace = true;
            this.AbonoDelAdeudo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AbonoDelAdeudo.SelectedText = "";
            this.AbonoDelAdeudo.SelectionLength = 0;
            this.AbonoDelAdeudo.SelectionStart = 0;
            this.AbonoDelAdeudo.ShortcutsEnabled = true;
            this.AbonoDelAdeudo.Size = new System.Drawing.Size(378, 48);
            this.AbonoDelAdeudo.SkipLiterals = true;
            this.AbonoDelAdeudo.TabIndex = 1;
            this.AbonoDelAdeudo.TabStop = false;
            this.AbonoDelAdeudo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AbonoDelAdeudo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.AbonoDelAdeudo.TrailingIcon = null;
            this.AbonoDelAdeudo.UseSystemPasswordChar = false;
            this.AbonoDelAdeudo.ValidatingType = null;
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
            this.materialButton1.Location = new System.Drawing.Point(142, 422);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(124, 36);
            this.materialButton1.TabIndex = 32;
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
            this.Agregar_usuarios.Location = new System.Drawing.Point(16, 422);
            this.Agregar_usuarios.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Agregar_usuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.Agregar_usuarios.Name = "Agregar_usuarios";
            this.Agregar_usuarios.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Agregar_usuarios.Size = new System.Drawing.Size(114, 36);
            this.Agregar_usuarios.TabIndex = 31;
            this.Agregar_usuarios.Text = "Aceptar";
            this.Agregar_usuarios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Agregar_usuarios.UseAccentColor = true;
            this.Agregar_usuarios.UseVisualStyleBackColor = true;
            this.Agregar_usuarios.Click += new System.EventHandler(this.Agregar_usuarios_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(23, 34);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(180, 19);
            this.materialLabel1.TabIndex = 33;
            this.materialLabel1.Text = "Agregar monto al adeudo";
            // 
            // AgregarMontoAlADeudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 544);
            this.Controls.Add(this.materialCard1);
            this.Name = "AgregarMontoAlADeudo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar monto al adeudo";
            this.Load += new System.EventHandler(this.AgregarMontoAlADeudo_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialMaskedTextBox MontoTotalDelAdeudo;
        private MaterialSkin.Controls.MaterialMaskedTextBox AbonoDelAdeudo;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton Agregar_usuarios;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}