namespace p_proyect.Modules.Entidades.Formularios.UsuarioForms
{
    partial class AgregarEditarUsuarios
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
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Agregar_usuarios = new MaterialSkin.Controls.MaterialButton();
            this.RolUsuario = new MaterialSkin.Controls.MaterialComboBox();
            this.Password_txt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.Correo_txt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.Cedula_text = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.LastName_txt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.Name_txt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialMaskedTextBox1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialMaskedTextBox1);
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.Agregar_usuarios);
            this.materialCard1.Controls.Add(this.RolUsuario);
            this.materialCard1.Controls.Add(this.Password_txt);
            this.materialCard1.Controls.Add(this.Correo_txt);
            this.materialCard1.Controls.Add(this.Cedula_text);
            this.materialCard1.Controls.Add(this.LastName_txt);
            this.materialCard1.Controls.Add(this.Name_txt);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(406, 655);
            this.materialCard1.TabIndex = 1;
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
            this.materialButton1.Location = new System.Drawing.Point(197, 600);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(124, 36);
            this.materialButton1.TabIndex = 8;
            this.materialButton1.Text = "Cancelar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 53);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(169, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Informacion del usuario";
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
            this.Agregar_usuarios.Location = new System.Drawing.Point(60, 600);
            this.Agregar_usuarios.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Agregar_usuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.Agregar_usuarios.Name = "Agregar_usuarios";
            this.Agregar_usuarios.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Agregar_usuarios.Size = new System.Drawing.Size(116, 36);
            this.Agregar_usuarios.TabIndex = 6;
            this.Agregar_usuarios.Text = "Agregar";
            this.Agregar_usuarios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Agregar_usuarios.UseAccentColor = true;
            this.Agregar_usuarios.UseVisualStyleBackColor = true;
            this.Agregar_usuarios.Click += new System.EventHandler(this.Agregar_usuarios_Click);
            // 
            // RolUsuario
            // 
            this.RolUsuario.AutoResize = false;
            this.RolUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RolUsuario.Depth = 0;
            this.RolUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.RolUsuario.DropDownHeight = 174;
            this.RolUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RolUsuario.DropDownWidth = 121;
            this.RolUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.RolUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RolUsuario.FormattingEnabled = true;
            this.RolUsuario.IntegralHeight = false;
            this.RolUsuario.ItemHeight = 43;
            this.RolUsuario.Location = new System.Drawing.Point(17, 423);
            this.RolUsuario.MaxDropDownItems = 4;
            this.RolUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.RolUsuario.Name = "RolUsuario";
            this.RolUsuario.Size = new System.Drawing.Size(368, 49);
            this.RolUsuario.StartIndex = 0;
            this.RolUsuario.TabIndex = 5;
            // 
            // Password_txt
            // 
            this.Password_txt.AllowPromptAsInput = true;
            this.Password_txt.AnimateReadOnly = true;
            this.Password_txt.AsciiOnly = false;
            this.Password_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Password_txt.BeepOnError = false;
            this.Password_txt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Password_txt.Depth = 0;
            this.Password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Password_txt.HidePromptOnLeave = false;
            this.Password_txt.HideSelection = true;
            this.Password_txt.Hint = "Contraseña";
            this.Password_txt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.Password_txt.LeadingIcon = null;
            this.Password_txt.Location = new System.Drawing.Point(17, 356);
            this.Password_txt.Mask = "";
            this.Password_txt.MaxLength = 32767;
            this.Password_txt.MouseState = MaterialSkin.MouseState.OUT;
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.PasswordChar = '*';
            this.Password_txt.PrefixSuffixText = null;
            this.Password_txt.PromptChar = '_';
            this.Password_txt.ReadOnly = false;
            this.Password_txt.RejectInputOnFirstFailure = false;
            this.Password_txt.ResetOnPrompt = true;
            this.Password_txt.ResetOnSpace = true;
            this.Password_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Password_txt.SelectedText = "";
            this.Password_txt.SelectionLength = 0;
            this.Password_txt.SelectionStart = 0;
            this.Password_txt.ShortcutsEnabled = true;
            this.Password_txt.Size = new System.Drawing.Size(368, 48);
            this.Password_txt.SkipLiterals = true;
            this.Password_txt.TabIndex = 4;
            this.Password_txt.TabStop = false;
            this.Password_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password_txt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Password_txt.TrailingIcon = global::p_proyect.Properties.Resources.avatar_de_usuario;
            this.Password_txt.UseSystemPasswordChar = false;
            this.Password_txt.ValidatingType = null;
            // 
            // Correo_txt
            // 
            this.Correo_txt.AllowPromptAsInput = true;
            this.Correo_txt.AnimateReadOnly = true;
            this.Correo_txt.AsciiOnly = false;
            this.Correo_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Correo_txt.BeepOnError = false;
            this.Correo_txt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Correo_txt.Depth = 0;
            this.Correo_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Correo_txt.HidePromptOnLeave = false;
            this.Correo_txt.HideSelection = true;
            this.Correo_txt.Hint = "Correo";
            this.Correo_txt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.Correo_txt.LeadingIcon = null;
            this.Correo_txt.Location = new System.Drawing.Point(20, 291);
            this.Correo_txt.Mask = "";
            this.Correo_txt.MaxLength = 32767;
            this.Correo_txt.MouseState = MaterialSkin.MouseState.OUT;
            this.Correo_txt.Name = "Correo_txt";
            this.Correo_txt.PasswordChar = '\0';
            this.Correo_txt.PrefixSuffixText = null;
            this.Correo_txt.PromptChar = '_';
            this.Correo_txt.ReadOnly = false;
            this.Correo_txt.RejectInputOnFirstFailure = false;
            this.Correo_txt.ResetOnPrompt = true;
            this.Correo_txt.ResetOnSpace = true;
            this.Correo_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Correo_txt.SelectedText = "";
            this.Correo_txt.SelectionLength = 0;
            this.Correo_txt.SelectionStart = 0;
            this.Correo_txt.ShortcutsEnabled = true;
            this.Correo_txt.Size = new System.Drawing.Size(368, 48);
            this.Correo_txt.SkipLiterals = true;
            this.Correo_txt.TabIndex = 3;
            this.Correo_txt.TabStop = false;
            this.Correo_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Correo_txt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Correo_txt.TrailingIcon = global::p_proyect.Properties.Resources.gmail;
            this.Correo_txt.UseSystemPasswordChar = false;
            this.Correo_txt.ValidatingType = null;
            // 
            // Cedula_text
            // 
            this.Cedula_text.AllowPromptAsInput = true;
            this.Cedula_text.AnimateReadOnly = true;
            this.Cedula_text.AsciiOnly = false;
            this.Cedula_text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Cedula_text.BeepOnError = false;
            this.Cedula_text.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Cedula_text.Depth = 0;
            this.Cedula_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Cedula_text.HidePromptOnLeave = false;
            this.Cedula_text.HideSelection = true;
            this.Cedula_text.Hint = "Cedula";
            this.Cedula_text.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.Cedula_text.LeadingIcon = null;
            this.Cedula_text.Location = new System.Drawing.Point(17, 227);
            this.Cedula_text.Mask = "";
            this.Cedula_text.MaxLength = 32767;
            this.Cedula_text.MouseState = MaterialSkin.MouseState.OUT;
            this.Cedula_text.Name = "Cedula_text";
            this.Cedula_text.PasswordChar = '\0';
            this.Cedula_text.PrefixSuffixText = null;
            this.Cedula_text.PromptChar = '_';
            this.Cedula_text.ReadOnly = false;
            this.Cedula_text.RejectInputOnFirstFailure = false;
            this.Cedula_text.ResetOnPrompt = true;
            this.Cedula_text.ResetOnSpace = true;
            this.Cedula_text.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cedula_text.SelectedText = "";
            this.Cedula_text.SelectionLength = 0;
            this.Cedula_text.SelectionStart = 0;
            this.Cedula_text.ShortcutsEnabled = true;
            this.Cedula_text.Size = new System.Drawing.Size(368, 48);
            this.Cedula_text.SkipLiterals = true;
            this.Cedula_text.TabIndex = 2;
            this.Cedula_text.TabStop = false;
            this.Cedula_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Cedula_text.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Cedula_text.TrailingIcon = global::p_proyect.Properties.Resources.cedula;
            this.Cedula_text.UseSystemPasswordChar = false;
            this.Cedula_text.ValidatingType = null;
            // 
            // LastName_txt
            // 
            this.LastName_txt.AllowPromptAsInput = true;
            this.LastName_txt.AnimateReadOnly = true;
            this.LastName_txt.AsciiOnly = false;
            this.LastName_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LastName_txt.BeepOnError = false;
            this.LastName_txt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.LastName_txt.Depth = 0;
            this.LastName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LastName_txt.HidePromptOnLeave = false;
            this.LastName_txt.HideSelection = true;
            this.LastName_txt.Hint = "Apellidos";
            this.LastName_txt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.LastName_txt.LeadingIcon = null;
            this.LastName_txt.Location = new System.Drawing.Point(17, 163);
            this.LastName_txt.Mask = "";
            this.LastName_txt.MaxLength = 32767;
            this.LastName_txt.MouseState = MaterialSkin.MouseState.OUT;
            this.LastName_txt.Name = "LastName_txt";
            this.LastName_txt.PasswordChar = '\0';
            this.LastName_txt.PrefixSuffixText = null;
            this.LastName_txt.PromptChar = '_';
            this.LastName_txt.ReadOnly = false;
            this.LastName_txt.RejectInputOnFirstFailure = false;
            this.LastName_txt.ResetOnPrompt = true;
            this.LastName_txt.ResetOnSpace = true;
            this.LastName_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LastName_txt.SelectedText = "";
            this.LastName_txt.SelectionLength = 0;
            this.LastName_txt.SelectionStart = 0;
            this.LastName_txt.ShortcutsEnabled = true;
            this.LastName_txt.Size = new System.Drawing.Size(368, 48);
            this.LastName_txt.SkipLiterals = true;
            this.LastName_txt.TabIndex = 1;
            this.LastName_txt.TabStop = false;
            this.LastName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LastName_txt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.LastName_txt.TrailingIcon = global::p_proyect.Properties.Resources.firma;
            this.LastName_txt.UseSystemPasswordChar = false;
            this.LastName_txt.ValidatingType = null;
            // 
            // Name_txt
            // 
            this.Name_txt.AllowPromptAsInput = true;
            this.Name_txt.AnimateReadOnly = true;
            this.Name_txt.AsciiOnly = false;
            this.Name_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Name_txt.BeepOnError = false;
            this.Name_txt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Name_txt.Depth = 0;
            this.Name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name_txt.HidePromptOnLeave = false;
            this.Name_txt.HideSelection = true;
            this.Name_txt.Hint = "Nombre";
            this.Name_txt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.Name_txt.LeadingIcon = null;
            this.Name_txt.Location = new System.Drawing.Point(17, 99);
            this.Name_txt.Mask = "";
            this.Name_txt.MaxLength = 32767;
            this.Name_txt.MouseState = MaterialSkin.MouseState.OUT;
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.PasswordChar = '\0';
            this.Name_txt.PrefixSuffixText = null;
            this.Name_txt.PromptChar = '_';
            this.Name_txt.ReadOnly = false;
            this.Name_txt.RejectInputOnFirstFailure = false;
            this.Name_txt.ResetOnPrompt = true;
            this.Name_txt.ResetOnSpace = true;
            this.Name_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Name_txt.SelectedText = "";
            this.Name_txt.SelectionLength = 0;
            this.Name_txt.SelectionStart = 0;
            this.Name_txt.ShortcutsEnabled = true;
            this.Name_txt.Size = new System.Drawing.Size(368, 48);
            this.Name_txt.SkipLiterals = true;
            this.Name_txt.TabIndex = 0;
            this.Name_txt.TabStop = false;
            this.Name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Name_txt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Name_txt.TrailingIcon = global::p_proyect.Properties.Resources.firma;
            this.Name_txt.UseSystemPasswordChar = false;
            this.Name_txt.ValidatingType = null;
            // 
            // materialMaskedTextBox1
            // 
            this.materialMaskedTextBox1.AllowPromptAsInput = true;
            this.materialMaskedTextBox1.AnimateReadOnly = true;
            this.materialMaskedTextBox1.AsciiOnly = false;
            this.materialMaskedTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox1.BeepOnError = false;
            this.materialMaskedTextBox1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.Depth = 0;
            this.materialMaskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox1.HidePromptOnLeave = false;
            this.materialMaskedTextBox1.HideSelection = true;
            this.materialMaskedTextBox1.Hint = "Numero de telefono";
            this.materialMaskedTextBox1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox1.LeadingIcon = null;
            this.materialMaskedTextBox1.Location = new System.Drawing.Point(21, 489);
            this.materialMaskedTextBox1.Mask = "";
            this.materialMaskedTextBox1.MaxLength = 32767;
            this.materialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            this.materialMaskedTextBox1.PasswordChar = '\0';
            this.materialMaskedTextBox1.PrefixSuffixText = null;
            this.materialMaskedTextBox1.PromptChar = '_';
            this.materialMaskedTextBox1.ReadOnly = false;
            this.materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox1.ResetOnPrompt = true;
            this.materialMaskedTextBox1.ResetOnSpace = true;
            this.materialMaskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox1.SelectedText = "";
            this.materialMaskedTextBox1.SelectionLength = 0;
            this.materialMaskedTextBox1.SelectionStart = 0;
            this.materialMaskedTextBox1.ShortcutsEnabled = true;
            this.materialMaskedTextBox1.Size = new System.Drawing.Size(368, 48);
            this.materialMaskedTextBox1.SkipLiterals = true;
            this.materialMaskedTextBox1.TabIndex = 9;
            this.materialMaskedTextBox1.TabStop = false;
            this.materialMaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.TrailingIcon = global::p_proyect.Properties.Resources.llamada_telefonica1;
            this.materialMaskedTextBox1.UseSystemPasswordChar = false;
            this.materialMaskedTextBox1.ValidatingType = null;
            // 
            // AgregarEditarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 750);
            this.Controls.Add(this.materialCard1);
            this.Name = "AgregarEditarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarEditarUsuarios";
            this.Load += new System.EventHandler(this.AgregarEditarUsuarios_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox Name_txt;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialMaskedTextBox Password_txt;
        private MaterialSkin.Controls.MaterialMaskedTextBox Correo_txt;
        private MaterialSkin.Controls.MaterialMaskedTextBox Cedula_text;
        private MaterialSkin.Controls.MaterialMaskedTextBox LastName_txt;
        private MaterialSkin.Controls.MaterialComboBox RolUsuario;
        private MaterialSkin.Controls.MaterialButton Agregar_usuarios;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
    }
}