namespace p_proyect
{
    partial class InicioDeSecion
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.ClaveDelUsuario = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.NombreDelUsuario = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(101, 78);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(235, 41);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Inicio de secion";
            this.materialLabel1.UseAccent = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::p_proyect.Properties.Resources.FondoDePantallaRojo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(3, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 588);
            this.panel1.TabIndex = 4;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton1.Location = new System.Drawing.Point(181, 420);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(114, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "Acceder";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // ClaveDelUsuario
            // 
            this.ClaveDelUsuario.AllowPromptAsInput = true;
            this.ClaveDelUsuario.AnimateReadOnly = false;
            this.ClaveDelUsuario.AsciiOnly = false;
            this.ClaveDelUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClaveDelUsuario.BeepOnError = false;
            this.ClaveDelUsuario.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ClaveDelUsuario.Depth = 0;
            this.ClaveDelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ClaveDelUsuario.HidePromptOnLeave = false;
            this.ClaveDelUsuario.HideSelection = true;
            this.ClaveDelUsuario.Hint = "Contraseña";
            this.ClaveDelUsuario.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.ClaveDelUsuario.LeadingIcon = global::p_proyect.Properties.Resources.avatar_de_usuario;
            this.ClaveDelUsuario.Location = new System.Drawing.Point(15, 289);
            this.ClaveDelUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClaveDelUsuario.Mask = "";
            this.ClaveDelUsuario.MaxLength = 32767;
            this.ClaveDelUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.ClaveDelUsuario.Name = "ClaveDelUsuario";
            this.ClaveDelUsuario.PasswordChar = '*';
            this.ClaveDelUsuario.PrefixSuffixText = null;
            this.ClaveDelUsuario.PromptChar = '_';
            this.ClaveDelUsuario.ReadOnly = false;
            this.ClaveDelUsuario.RejectInputOnFirstFailure = false;
            this.ClaveDelUsuario.ResetOnPrompt = true;
            this.ClaveDelUsuario.ResetOnSpace = true;
            this.ClaveDelUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ClaveDelUsuario.SelectedText = "";
            this.ClaveDelUsuario.SelectionLength = 0;
            this.ClaveDelUsuario.SelectionStart = 0;
            this.ClaveDelUsuario.ShortcutsEnabled = true;
            this.ClaveDelUsuario.Size = new System.Drawing.Size(485, 48);
            this.ClaveDelUsuario.SkipLiterals = true;
            this.ClaveDelUsuario.TabIndex = 1;
            this.ClaveDelUsuario.TabStop = false;
            this.ClaveDelUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClaveDelUsuario.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ClaveDelUsuario.TrailingIcon = null;
            this.ClaveDelUsuario.UseSystemPasswordChar = false;
            this.ClaveDelUsuario.ValidatingType = null;
            this.ClaveDelUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClaveDelUsuario_KeyDown);
            // 
            // NombreDelUsuario
            // 
            this.NombreDelUsuario.AllowPromptAsInput = true;
            this.NombreDelUsuario.AnimateReadOnly = false;
            this.NombreDelUsuario.AsciiOnly = false;
            this.NombreDelUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NombreDelUsuario.BeepOnError = false;
            this.NombreDelUsuario.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NombreDelUsuario.Depth = 0;
            this.NombreDelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NombreDelUsuario.HidePromptOnLeave = false;
            this.NombreDelUsuario.HideSelection = true;
            this.NombreDelUsuario.Hint = "Nombre";
            this.NombreDelUsuario.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.NombreDelUsuario.LeadingIcon = global::p_proyect.Properties.Resources.firma;
            this.NombreDelUsuario.Location = new System.Drawing.Point(15, 155);
            this.NombreDelUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NombreDelUsuario.Mask = "";
            this.NombreDelUsuario.MaxLength = 32767;
            this.NombreDelUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.NombreDelUsuario.Name = "NombreDelUsuario";
            this.NombreDelUsuario.PasswordChar = '\0';
            this.NombreDelUsuario.PrefixSuffixText = null;
            this.NombreDelUsuario.PromptChar = '_';
            this.NombreDelUsuario.ReadOnly = false;
            this.NombreDelUsuario.RejectInputOnFirstFailure = false;
            this.NombreDelUsuario.ResetOnPrompt = true;
            this.NombreDelUsuario.ResetOnSpace = true;
            this.NombreDelUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NombreDelUsuario.SelectedText = "";
            this.NombreDelUsuario.SelectionLength = 0;
            this.NombreDelUsuario.SelectionStart = 0;
            this.NombreDelUsuario.ShortcutsEnabled = true;
            this.NombreDelUsuario.Size = new System.Drawing.Size(485, 48);
            this.NombreDelUsuario.SkipLiterals = true;
            this.NombreDelUsuario.TabIndex = 0;
            this.NombreDelUsuario.TabStop = false;
            this.NombreDelUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NombreDelUsuario.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NombreDelUsuario.TrailingIcon = null;
            this.NombreDelUsuario.UseSystemPasswordChar = false;
            this.NombreDelUsuario.ValidatingType = null;
            this.NombreDelUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NombreDelUsuario_KeyDown);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.ClaveDelUsuario);
            this.materialCard1.Controls.Add(this.NombreDelUsuario);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(716, 91);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard1.Size = new System.Drawing.Size(520, 578);
            this.materialCard1.TabIndex = 5;
            // 
            // InicioDeSecion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 678);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InicioDeSecion";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.InicioDeSecion_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox NombreDelUsuario;
        private MaterialSkin.Controls.MaterialMaskedTextBox ClaveDelUsuario;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}