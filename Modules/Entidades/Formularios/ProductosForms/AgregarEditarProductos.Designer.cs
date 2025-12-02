namespace p_proyect.Modules.Entidades.Formularios.ProductosForms
{
    partial class AgregarEditarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEditarProductos));
            this.Nombre_txt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.Descripcion_txt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.CodigoBarra_txt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.Marca_txt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.TipoDeDeSalida_com = new MaterialSkin.Controls.MaterialComboBox();
            this.Modelo_txt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.StockMinimo_txt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.StockMaximo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.UnidadMedida_txt = new MaterialSkin.Controls.MaterialComboBox();
            this.Precio_De_Compra_txt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.Precio_de_Venta_txt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.FechaExpiracion = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.Ubicacion_txt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.ProvedoresIDNames_com = new MaterialSkin.Controls.MaterialComboBox();
            this.Cantidad_txt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.Agregar_usuarios = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Nombre_txt
            // 
            this.Nombre_txt.AllowPromptAsInput = true;
            this.Nombre_txt.AnimateReadOnly = true;
            this.Nombre_txt.AsciiOnly = false;
            this.Nombre_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Nombre_txt.BeepOnError = false;
            this.Nombre_txt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Nombre_txt.Depth = 0;
            this.Nombre_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Nombre_txt.HidePromptOnLeave = false;
            this.Nombre_txt.HideSelection = true;
            this.Nombre_txt.Hint = "Nombre";
            this.Nombre_txt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.Nombre_txt.LeadingIcon = null;
            this.Nombre_txt.Location = new System.Drawing.Point(6, 142);
            this.Nombre_txt.Mask = "";
            this.Nombre_txt.MaxLength = 32767;
            this.Nombre_txt.MouseState = MaterialSkin.MouseState.OUT;
            this.Nombre_txt.Name = "Nombre_txt";
            this.Nombre_txt.PasswordChar = '\0';
            this.Nombre_txt.PrefixSuffixText = null;
            this.Nombre_txt.PromptChar = '_';
            this.Nombre_txt.ReadOnly = false;
            this.Nombre_txt.RejectInputOnFirstFailure = false;
            this.Nombre_txt.ResetOnPrompt = true;
            this.Nombre_txt.ResetOnSpace = true;
            this.Nombre_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Nombre_txt.SelectedText = "";
            this.Nombre_txt.SelectionLength = 0;
            this.Nombre_txt.SelectionStart = 0;
            this.Nombre_txt.ShortcutsEnabled = true;
            this.Nombre_txt.Size = new System.Drawing.Size(368, 48);
            this.Nombre_txt.SkipLiterals = true;
            this.Nombre_txt.TabIndex = 1;
            this.Nombre_txt.TabStop = false;
            this.Nombre_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Nombre_txt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Nombre_txt.TrailingIcon = global::p_proyect.Properties.Resources.firma;
            this.Nombre_txt.UseSystemPasswordChar = false;
            this.Nombre_txt.ValidatingType = null;
            // 
            // Descripcion_txt
            // 
            this.Descripcion_txt.AllowPromptAsInput = true;
            this.Descripcion_txt.AnimateReadOnly = true;
            this.Descripcion_txt.AsciiOnly = false;
            this.Descripcion_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Descripcion_txt.BeepOnError = false;
            this.Descripcion_txt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Descripcion_txt.Depth = 0;
            this.Descripcion_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Descripcion_txt.HidePromptOnLeave = false;
            this.Descripcion_txt.HideSelection = true;
            this.Descripcion_txt.Hint = "Descripcion";
            this.Descripcion_txt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.Descripcion_txt.LeadingIcon = null;
            this.Descripcion_txt.Location = new System.Drawing.Point(6, 233);
            this.Descripcion_txt.Mask = "";
            this.Descripcion_txt.MaxLength = 32767;
            this.Descripcion_txt.MouseState = MaterialSkin.MouseState.OUT;
            this.Descripcion_txt.Name = "Descripcion_txt";
            this.Descripcion_txt.PasswordChar = '\0';
            this.Descripcion_txt.PrefixSuffixText = null;
            this.Descripcion_txt.PromptChar = '_';
            this.Descripcion_txt.ReadOnly = false;
            this.Descripcion_txt.RejectInputOnFirstFailure = false;
            this.Descripcion_txt.ResetOnPrompt = true;
            this.Descripcion_txt.ResetOnSpace = true;
            this.Descripcion_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Descripcion_txt.SelectedText = "";
            this.Descripcion_txt.SelectionLength = 0;
            this.Descripcion_txt.SelectionStart = 0;
            this.Descripcion_txt.ShortcutsEnabled = true;
            this.Descripcion_txt.Size = new System.Drawing.Size(368, 48);
            this.Descripcion_txt.SkipLiterals = true;
            this.Descripcion_txt.TabIndex = 2;
            this.Descripcion_txt.TabStop = false;
            this.Descripcion_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Descripcion_txt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Descripcion_txt.TrailingIcon = global::p_proyect.Properties.Resources.lista_de_verificacion;
            this.Descripcion_txt.UseSystemPasswordChar = false;
            this.Descripcion_txt.ValidatingType = null;
            // 
            // CodigoBarra_txt
            // 
            this.CodigoBarra_txt.AllowPromptAsInput = true;
            this.CodigoBarra_txt.AnimateReadOnly = true;
            this.CodigoBarra_txt.AsciiOnly = false;
            this.CodigoBarra_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CodigoBarra_txt.BeepOnError = false;
            this.CodigoBarra_txt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.CodigoBarra_txt.Depth = 0;
            this.CodigoBarra_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CodigoBarra_txt.HidePromptOnLeave = false;
            this.CodigoBarra_txt.HideSelection = true;
            this.CodigoBarra_txt.Hint = "Codigo de Barra";
            this.CodigoBarra_txt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.CodigoBarra_txt.LeadingIcon = null;
            this.CodigoBarra_txt.Location = new System.Drawing.Point(6, 308);
            this.CodigoBarra_txt.Mask = "";
            this.CodigoBarra_txt.MaxLength = 32767;
            this.CodigoBarra_txt.MouseState = MaterialSkin.MouseState.OUT;
            this.CodigoBarra_txt.Name = "CodigoBarra_txt";
            this.CodigoBarra_txt.PasswordChar = '\0';
            this.CodigoBarra_txt.PrefixSuffixText = null;
            this.CodigoBarra_txt.PromptChar = '_';
            this.CodigoBarra_txt.ReadOnly = false;
            this.CodigoBarra_txt.RejectInputOnFirstFailure = false;
            this.CodigoBarra_txt.ResetOnPrompt = true;
            this.CodigoBarra_txt.ResetOnSpace = true;
            this.CodigoBarra_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CodigoBarra_txt.SelectedText = "";
            this.CodigoBarra_txt.SelectionLength = 0;
            this.CodigoBarra_txt.SelectionStart = 0;
            this.CodigoBarra_txt.ShortcutsEnabled = true;
            this.CodigoBarra_txt.Size = new System.Drawing.Size(368, 48);
            this.CodigoBarra_txt.SkipLiterals = true;
            this.CodigoBarra_txt.TabIndex = 3;
            this.CodigoBarra_txt.TabStop = false;
            this.CodigoBarra_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CodigoBarra_txt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.CodigoBarra_txt.TrailingIcon = global::p_proyect.Properties.Resources.producto_de_codigo_de_barras;
            this.CodigoBarra_txt.UseSystemPasswordChar = false;
            this.CodigoBarra_txt.ValidatingType = null;
            this.CodigoBarra_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodigoBarra_txt_KeyDown);
            // 
            // Marca_txt
            // 
            this.Marca_txt.AllowPromptAsInput = true;
            this.Marca_txt.AnimateReadOnly = true;
            this.Marca_txt.AsciiOnly = false;
            this.Marca_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Marca_txt.BeepOnError = false;
            this.Marca_txt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Marca_txt.Depth = 0;
            this.Marca_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Marca_txt.HidePromptOnLeave = false;
            this.Marca_txt.HideSelection = true;
            this.Marca_txt.Hint = "Marca";
            this.Marca_txt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.Marca_txt.LeadingIcon = null;
            this.Marca_txt.Location = new System.Drawing.Point(6, 385);
            this.Marca_txt.Mask = "";
            this.Marca_txt.MaxLength = 32767;
            this.Marca_txt.MouseState = MaterialSkin.MouseState.OUT;
            this.Marca_txt.Name = "Marca_txt";
            this.Marca_txt.PasswordChar = '\0';
            this.Marca_txt.PrefixSuffixText = null;
            this.Marca_txt.PromptChar = '_';
            this.Marca_txt.ReadOnly = false;
            this.Marca_txt.RejectInputOnFirstFailure = false;
            this.Marca_txt.ResetOnPrompt = true;
            this.Marca_txt.ResetOnSpace = true;
            this.Marca_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Marca_txt.SelectedText = "";
            this.Marca_txt.SelectionLength = 0;
            this.Marca_txt.SelectionStart = 0;
            this.Marca_txt.ShortcutsEnabled = true;
            this.Marca_txt.Size = new System.Drawing.Size(368, 48);
            this.Marca_txt.SkipLiterals = true;
            this.Marca_txt.TabIndex = 4;
            this.Marca_txt.TabStop = false;
            this.Marca_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Marca_txt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Marca_txt.TrailingIcon = global::p_proyect.Properties.Resources.etiquetas_de_productos;
            this.Marca_txt.UseSystemPasswordChar = false;
            this.Marca_txt.ValidatingType = null;
            // 
            // TipoDeDeSalida_com
            // 
            this.TipoDeDeSalida_com.AutoResize = false;
            this.TipoDeDeSalida_com.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TipoDeDeSalida_com.Depth = 0;
            this.TipoDeDeSalida_com.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TipoDeDeSalida_com.DropDownHeight = 174;
            this.TipoDeDeSalida_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoDeDeSalida_com.DropDownWidth = 121;
            this.TipoDeDeSalida_com.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TipoDeDeSalida_com.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TipoDeDeSalida_com.FormattingEnabled = true;
            this.TipoDeDeSalida_com.IntegralHeight = false;
            this.TipoDeDeSalida_com.ItemHeight = 43;
            this.TipoDeDeSalida_com.Location = new System.Drawing.Point(766, 307);
            this.TipoDeDeSalida_com.MaxDropDownItems = 4;
            this.TipoDeDeSalida_com.MouseState = MaterialSkin.MouseState.OUT;
            this.TipoDeDeSalida_com.Name = "TipoDeDeSalida_com";
            this.TipoDeDeSalida_com.Size = new System.Drawing.Size(368, 49);
            this.TipoDeDeSalida_com.StartIndex = 0;
            this.TipoDeDeSalida_com.TabIndex = 6;
            // 
            // Modelo_txt
            // 
            this.Modelo_txt.AllowPromptAsInput = true;
            this.Modelo_txt.AnimateReadOnly = true;
            this.Modelo_txt.AsciiOnly = false;
            this.Modelo_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Modelo_txt.BeepOnError = false;
            this.Modelo_txt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Modelo_txt.Depth = 0;
            this.Modelo_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Modelo_txt.HidePromptOnLeave = false;
            this.Modelo_txt.HideSelection = true;
            this.Modelo_txt.Hint = "Modelo";
            this.Modelo_txt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.Modelo_txt.LeadingIcon = null;
            this.Modelo_txt.Location = new System.Drawing.Point(6, 458);
            this.Modelo_txt.Mask = "";
            this.Modelo_txt.MaxLength = 32767;
            this.Modelo_txt.MouseState = MaterialSkin.MouseState.OUT;
            this.Modelo_txt.Name = "Modelo_txt";
            this.Modelo_txt.PasswordChar = '\0';
            this.Modelo_txt.PrefixSuffixText = null;
            this.Modelo_txt.PromptChar = '_';
            this.Modelo_txt.ReadOnly = false;
            this.Modelo_txt.RejectInputOnFirstFailure = false;
            this.Modelo_txt.ResetOnPrompt = true;
            this.Modelo_txt.ResetOnSpace = true;
            this.Modelo_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Modelo_txt.SelectedText = "";
            this.Modelo_txt.SelectionLength = 0;
            this.Modelo_txt.SelectionStart = 0;
            this.Modelo_txt.ShortcutsEnabled = true;
            this.Modelo_txt.Size = new System.Drawing.Size(368, 48);
            this.Modelo_txt.SkipLiterals = true;
            this.Modelo_txt.TabIndex = 7;
            this.Modelo_txt.TabStop = false;
            this.Modelo_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Modelo_txt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Modelo_txt.TrailingIcon = global::p_proyect.Properties.Resources.firma;
            this.Modelo_txt.UseSystemPasswordChar = false;
            this.Modelo_txt.ValidatingType = null;
            // 
            // StockMinimo_txt
            // 
            this.StockMinimo_txt.AllowPromptAsInput = true;
            this.StockMinimo_txt.AnimateReadOnly = true;
            this.StockMinimo_txt.AsciiOnly = false;
            this.StockMinimo_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StockMinimo_txt.BeepOnError = false;
            this.StockMinimo_txt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.StockMinimo_txt.Depth = 0;
            this.StockMinimo_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StockMinimo_txt.HidePromptOnLeave = false;
            this.StockMinimo_txt.HideSelection = true;
            this.StockMinimo_txt.Hint = "Cantidad Minima";
            this.StockMinimo_txt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.StockMinimo_txt.LeadingIcon = null;
            this.StockMinimo_txt.Location = new System.Drawing.Point(380, 233);
            this.StockMinimo_txt.Mask = "";
            this.StockMinimo_txt.MaxLength = 32767;
            this.StockMinimo_txt.MouseState = MaterialSkin.MouseState.OUT;
            this.StockMinimo_txt.Name = "StockMinimo_txt";
            this.StockMinimo_txt.PasswordChar = '\0';
            this.StockMinimo_txt.PrefixSuffixText = null;
            this.StockMinimo_txt.PromptChar = '_';
            this.StockMinimo_txt.ReadOnly = false;
            this.StockMinimo_txt.RejectInputOnFirstFailure = false;
            this.StockMinimo_txt.ResetOnPrompt = true;
            this.StockMinimo_txt.ResetOnSpace = true;
            this.StockMinimo_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StockMinimo_txt.SelectedText = "";
            this.StockMinimo_txt.SelectionLength = 0;
            this.StockMinimo_txt.SelectionStart = 0;
            this.StockMinimo_txt.ShortcutsEnabled = true;
            this.StockMinimo_txt.Size = new System.Drawing.Size(368, 48);
            this.StockMinimo_txt.SkipLiterals = true;
            this.StockMinimo_txt.TabIndex = 8;
            this.StockMinimo_txt.TabStop = false;
            this.StockMinimo_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StockMinimo_txt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.StockMinimo_txt.TrailingIcon = global::p_proyect.Properties.Resources.etiquetas_de_productos;
            this.StockMinimo_txt.UseSystemPasswordChar = false;
            this.StockMinimo_txt.ValidatingType = null;
            // 
            // StockMaximo
            // 
            this.StockMaximo.AllowPromptAsInput = true;
            this.StockMaximo.AnimateReadOnly = true;
            this.StockMaximo.AsciiOnly = false;
            this.StockMaximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StockMaximo.BeepOnError = false;
            this.StockMaximo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.StockMaximo.Depth = 0;
            this.StockMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StockMaximo.HidePromptOnLeave = false;
            this.StockMaximo.HideSelection = true;
            this.StockMaximo.Hint = "Cantidad maxima";
            this.StockMaximo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.StockMaximo.LeadingIcon = null;
            this.StockMaximo.Location = new System.Drawing.Point(380, 307);
            this.StockMaximo.Mask = "";
            this.StockMaximo.MaxLength = 32767;
            this.StockMaximo.MouseState = MaterialSkin.MouseState.OUT;
            this.StockMaximo.Name = "StockMaximo";
            this.StockMaximo.PasswordChar = '\0';
            this.StockMaximo.PrefixSuffixText = null;
            this.StockMaximo.PromptChar = '_';
            this.StockMaximo.ReadOnly = false;
            this.StockMaximo.RejectInputOnFirstFailure = false;
            this.StockMaximo.ResetOnPrompt = true;
            this.StockMaximo.ResetOnSpace = true;
            this.StockMaximo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StockMaximo.SelectedText = "";
            this.StockMaximo.SelectionLength = 0;
            this.StockMaximo.SelectionStart = 0;
            this.StockMaximo.ShortcutsEnabled = true;
            this.StockMaximo.Size = new System.Drawing.Size(368, 48);
            this.StockMaximo.SkipLiterals = true;
            this.StockMaximo.TabIndex = 9;
            this.StockMaximo.TabStop = false;
            this.StockMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StockMaximo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.StockMaximo.TrailingIcon = global::p_proyect.Properties.Resources.etiquetas_de_productos;
            this.StockMaximo.UseSystemPasswordChar = false;
            this.StockMaximo.ValidatingType = null;
            // 
            // UnidadMedida_txt
            // 
            this.UnidadMedida_txt.AutoResize = false;
            this.UnidadMedida_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UnidadMedida_txt.Depth = 0;
            this.UnidadMedida_txt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.UnidadMedida_txt.DropDownHeight = 174;
            this.UnidadMedida_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnidadMedida_txt.DropDownWidth = 121;
            this.UnidadMedida_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.UnidadMedida_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UnidadMedida_txt.FormattingEnabled = true;
            this.UnidadMedida_txt.IntegralHeight = false;
            this.UnidadMedida_txt.ItemHeight = 43;
            this.UnidadMedida_txt.Location = new System.Drawing.Point(766, 233);
            this.UnidadMedida_txt.MaxDropDownItems = 4;
            this.UnidadMedida_txt.MouseState = MaterialSkin.MouseState.OUT;
            this.UnidadMedida_txt.Name = "UnidadMedida_txt";
            this.UnidadMedida_txt.Size = new System.Drawing.Size(368, 49);
            this.UnidadMedida_txt.StartIndex = 0;
            this.UnidadMedida_txt.TabIndex = 11;
            // 
            // Precio_De_Compra_txt
            // 
            this.Precio_De_Compra_txt.AllowPromptAsInput = true;
            this.Precio_De_Compra_txt.AnimateReadOnly = true;
            this.Precio_De_Compra_txt.AsciiOnly = false;
            this.Precio_De_Compra_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Precio_De_Compra_txt.BeepOnError = false;
            this.Precio_De_Compra_txt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Precio_De_Compra_txt.Depth = 0;
            this.Precio_De_Compra_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Precio_De_Compra_txt.HidePromptOnLeave = false;
            this.Precio_De_Compra_txt.HideSelection = true;
            this.Precio_De_Compra_txt.Hint = "Precio de compra";
            this.Precio_De_Compra_txt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.Precio_De_Compra_txt.LeadingIcon = null;
            this.Precio_De_Compra_txt.Location = new System.Drawing.Point(380, 458);
            this.Precio_De_Compra_txt.Mask = "";
            this.Precio_De_Compra_txt.MaxLength = 32767;
            this.Precio_De_Compra_txt.MouseState = MaterialSkin.MouseState.OUT;
            this.Precio_De_Compra_txt.Name = "Precio_De_Compra_txt";
            this.Precio_De_Compra_txt.PasswordChar = '\0';
            this.Precio_De_Compra_txt.PrefixSuffixText = null;
            this.Precio_De_Compra_txt.PromptChar = '_';
            this.Precio_De_Compra_txt.ReadOnly = false;
            this.Precio_De_Compra_txt.RejectInputOnFirstFailure = false;
            this.Precio_De_Compra_txt.ResetOnPrompt = true;
            this.Precio_De_Compra_txt.ResetOnSpace = true;
            this.Precio_De_Compra_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Precio_De_Compra_txt.SelectedText = "";
            this.Precio_De_Compra_txt.SelectionLength = 0;
            this.Precio_De_Compra_txt.SelectionStart = 0;
            this.Precio_De_Compra_txt.ShortcutsEnabled = true;
            this.Precio_De_Compra_txt.Size = new System.Drawing.Size(368, 48);
            this.Precio_De_Compra_txt.SkipLiterals = true;
            this.Precio_De_Compra_txt.TabIndex = 12;
            this.Precio_De_Compra_txt.TabStop = false;
            this.Precio_De_Compra_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Precio_De_Compra_txt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Precio_De_Compra_txt.TrailingIcon = global::p_proyect.Properties.Resources.firma;
            this.Precio_De_Compra_txt.UseSystemPasswordChar = false;
            this.Precio_De_Compra_txt.ValidatingType = null;
            // 
            // Precio_de_Venta_txt
            // 
            this.Precio_de_Venta_txt.AllowPromptAsInput = true;
            this.Precio_de_Venta_txt.AnimateReadOnly = true;
            this.Precio_de_Venta_txt.AsciiOnly = false;
            this.Precio_de_Venta_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Precio_de_Venta_txt.BeepOnError = false;
            this.Precio_de_Venta_txt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Precio_de_Venta_txt.Depth = 0;
            this.Precio_de_Venta_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Precio_de_Venta_txt.HidePromptOnLeave = false;
            this.Precio_de_Venta_txt.HideSelection = true;
            this.Precio_de_Venta_txt.Hint = "Precio de venta";
            this.Precio_de_Venta_txt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.Precio_de_Venta_txt.LeadingIcon = null;
            this.Precio_de_Venta_txt.Location = new System.Drawing.Point(380, 386);
            this.Precio_de_Venta_txt.Mask = "";
            this.Precio_de_Venta_txt.MaxLength = 32767;
            this.Precio_de_Venta_txt.MouseState = MaterialSkin.MouseState.OUT;
            this.Precio_de_Venta_txt.Name = "Precio_de_Venta_txt";
            this.Precio_de_Venta_txt.PasswordChar = '\0';
            this.Precio_de_Venta_txt.PrefixSuffixText = null;
            this.Precio_de_Venta_txt.PromptChar = '_';
            this.Precio_de_Venta_txt.ReadOnly = false;
            this.Precio_de_Venta_txt.RejectInputOnFirstFailure = false;
            this.Precio_de_Venta_txt.ResetOnPrompt = true;
            this.Precio_de_Venta_txt.ResetOnSpace = true;
            this.Precio_de_Venta_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Precio_de_Venta_txt.SelectedText = "";
            this.Precio_de_Venta_txt.SelectionLength = 0;
            this.Precio_de_Venta_txt.SelectionStart = 0;
            this.Precio_de_Venta_txt.ShortcutsEnabled = true;
            this.Precio_de_Venta_txt.Size = new System.Drawing.Size(368, 48);
            this.Precio_de_Venta_txt.SkipLiterals = true;
            this.Precio_de_Venta_txt.TabIndex = 13;
            this.Precio_de_Venta_txt.TabStop = false;
            this.Precio_de_Venta_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Precio_de_Venta_txt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Precio_de_Venta_txt.TrailingIcon = global::p_proyect.Properties.Resources.firma;
            this.Precio_de_Venta_txt.UseSystemPasswordChar = false;
            this.Precio_de_Venta_txt.ValidatingType = null;
            // 
            // FechaExpiracion
            // 
            this.FechaExpiracion.BackColor = System.Drawing.Color.Transparent;
            this.FechaExpiracion.BorderColor = System.Drawing.Color.Silver;
            this.FechaExpiracion.BorderRadius = 1;
            this.FechaExpiracion.Color = System.Drawing.Color.Silver;
            this.FechaExpiracion.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.FechaExpiracion.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.FechaExpiracion.DisabledColor = System.Drawing.Color.Gray;
            this.FechaExpiracion.DisplayWeekNumbers = false;
            this.FechaExpiracion.DPHeight = 0;
            this.FechaExpiracion.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.FechaExpiracion.FillDatePicker = false;
            this.FechaExpiracion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FechaExpiracion.ForeColor = System.Drawing.Color.Black;
            this.FechaExpiracion.Icon = ((System.Drawing.Image)(resources.GetObject("FechaExpiracion.Icon")));
            this.FechaExpiracion.IconColor = System.Drawing.Color.Gray;
            this.FechaExpiracion.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.FechaExpiracion.LeftTextMargin = 5;
            this.FechaExpiracion.Location = new System.Drawing.Point(766, 458);
            this.FechaExpiracion.MinimumSize = new System.Drawing.Size(4, 32);
            this.FechaExpiracion.Name = "FechaExpiracion";
            this.FechaExpiracion.Size = new System.Drawing.Size(368, 32);
            this.FechaExpiracion.TabIndex = 14;
            this.FechaExpiracion.Value = new System.DateTime(2025, 11, 11, 0, 0, 0, 0);
            // 
            // Ubicacion_txt
            // 
            this.Ubicacion_txt.AllowPromptAsInput = true;
            this.Ubicacion_txt.AnimateReadOnly = true;
            this.Ubicacion_txt.AsciiOnly = false;
            this.Ubicacion_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Ubicacion_txt.BeepOnError = false;
            this.Ubicacion_txt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Ubicacion_txt.Depth = 0;
            this.Ubicacion_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Ubicacion_txt.HidePromptOnLeave = false;
            this.Ubicacion_txt.HideSelection = true;
            this.Ubicacion_txt.Hint = "Ubicacion";
            this.Ubicacion_txt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.Ubicacion_txt.LeadingIcon = null;
            this.Ubicacion_txt.Location = new System.Drawing.Point(766, 142);
            this.Ubicacion_txt.Mask = "";
            this.Ubicacion_txt.MaxLength = 32767;
            this.Ubicacion_txt.MouseState = MaterialSkin.MouseState.OUT;
            this.Ubicacion_txt.Name = "Ubicacion_txt";
            this.Ubicacion_txt.PasswordChar = '\0';
            this.Ubicacion_txt.PrefixSuffixText = null;
            this.Ubicacion_txt.PromptChar = '_';
            this.Ubicacion_txt.ReadOnly = false;
            this.Ubicacion_txt.RejectInputOnFirstFailure = false;
            this.Ubicacion_txt.ResetOnPrompt = true;
            this.Ubicacion_txt.ResetOnSpace = true;
            this.Ubicacion_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Ubicacion_txt.SelectedText = "";
            this.Ubicacion_txt.SelectionLength = 0;
            this.Ubicacion_txt.SelectionStart = 0;
            this.Ubicacion_txt.ShortcutsEnabled = true;
            this.Ubicacion_txt.Size = new System.Drawing.Size(368, 48);
            this.Ubicacion_txt.SkipLiterals = true;
            this.Ubicacion_txt.TabIndex = 15;
            this.Ubicacion_txt.TabStop = false;
            this.Ubicacion_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Ubicacion_txt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Ubicacion_txt.TrailingIcon = global::p_proyect.Properties.Resources.Direccion;
            this.Ubicacion_txt.UseSystemPasswordChar = false;
            this.Ubicacion_txt.ValidatingType = null;
            // 
            // ProvedoresIDNames_com
            // 
            this.ProvedoresIDNames_com.AutoResize = false;
            this.ProvedoresIDNames_com.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProvedoresIDNames_com.Depth = 0;
            this.ProvedoresIDNames_com.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ProvedoresIDNames_com.DropDownHeight = 174;
            this.ProvedoresIDNames_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProvedoresIDNames_com.DropDownWidth = 121;
            this.ProvedoresIDNames_com.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ProvedoresIDNames_com.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProvedoresIDNames_com.FormattingEnabled = true;
            this.ProvedoresIDNames_com.IntegralHeight = false;
            this.ProvedoresIDNames_com.ItemHeight = 43;
            this.ProvedoresIDNames_com.Location = new System.Drawing.Point(766, 385);
            this.ProvedoresIDNames_com.MaxDropDownItems = 4;
            this.ProvedoresIDNames_com.MouseState = MaterialSkin.MouseState.OUT;
            this.ProvedoresIDNames_com.Name = "ProvedoresIDNames_com";
            this.ProvedoresIDNames_com.Size = new System.Drawing.Size(368, 49);
            this.ProvedoresIDNames_com.StartIndex = 0;
            this.ProvedoresIDNames_com.TabIndex = 16;
            // 
            // Cantidad_txt
            // 
            this.Cantidad_txt.AllowPromptAsInput = true;
            this.Cantidad_txt.AnimateReadOnly = true;
            this.Cantidad_txt.AsciiOnly = false;
            this.Cantidad_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Cantidad_txt.BeepOnError = false;
            this.Cantidad_txt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Cantidad_txt.Depth = 0;
            this.Cantidad_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Cantidad_txt.HidePromptOnLeave = false;
            this.Cantidad_txt.HideSelection = true;
            this.Cantidad_txt.Hint = "Cantidad";
            this.Cantidad_txt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.Cantidad_txt.LeadingIcon = null;
            this.Cantidad_txt.Location = new System.Drawing.Point(380, 142);
            this.Cantidad_txt.Mask = "";
            this.Cantidad_txt.MaxLength = 32767;
            this.Cantidad_txt.MouseState = MaterialSkin.MouseState.OUT;
            this.Cantidad_txt.Name = "Cantidad_txt";
            this.Cantidad_txt.PasswordChar = '\0';
            this.Cantidad_txt.PrefixSuffixText = null;
            this.Cantidad_txt.PromptChar = '_';
            this.Cantidad_txt.ReadOnly = false;
            this.Cantidad_txt.RejectInputOnFirstFailure = false;
            this.Cantidad_txt.ResetOnPrompt = true;
            this.Cantidad_txt.ResetOnSpace = true;
            this.Cantidad_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cantidad_txt.SelectedText = "";
            this.Cantidad_txt.SelectionLength = 0;
            this.Cantidad_txt.SelectionStart = 0;
            this.Cantidad_txt.ShortcutsEnabled = true;
            this.Cantidad_txt.Size = new System.Drawing.Size(368, 48);
            this.Cantidad_txt.SkipLiterals = true;
            this.Cantidad_txt.TabIndex = 17;
            this.Cantidad_txt.TabStop = false;
            this.Cantidad_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Cantidad_txt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Cantidad_txt.TrailingIcon = global::p_proyect.Properties.Resources.etiquetas_de_productos;
            this.Cantidad_txt.UseSystemPasswordChar = false;
            this.Cantidad_txt.ValidatingType = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 82);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(179, 19);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Informacion del producto";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(763, 285);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(101, 19);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "Tipo de salida";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(763, 436);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(142, 19);
            this.materialLabel3.TabIndex = 20;
            this.materialLabel3.Text = "Fecha de expriacion";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(763, 359);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(88, 19);
            this.materialLabel4.TabIndex = 21;
            this.materialLabel4.Text = "Proveedores";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(763, 205);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(113, 19);
            this.materialLabel5.TabIndex = 22;
            this.materialLabel5.Text = "Tipo De Medida";
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
            this.Agregar_usuarios.Location = new System.Drawing.Point(9, 575);
            this.Agregar_usuarios.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Agregar_usuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.Agregar_usuarios.Name = "Agregar_usuarios";
            this.Agregar_usuarios.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Agregar_usuarios.Size = new System.Drawing.Size(116, 36);
            this.Agregar_usuarios.TabIndex = 23;
            this.Agregar_usuarios.Text = "Agregar";
            this.Agregar_usuarios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Agregar_usuarios.UseAccentColor = true;
            this.Agregar_usuarios.UseVisualStyleBackColor = true;
            this.Agregar_usuarios.Click += new System.EventHandler(this.Agregar_usuarios_Click);
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
            this.materialButton1.Location = new System.Drawing.Point(131, 575);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(124, 36);
            this.materialButton1.TabIndex = 24;
            this.materialButton1.Text = "Cancelar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // AgregarEditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 619);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.Agregar_usuarios);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Cantidad_txt);
            this.Controls.Add(this.ProvedoresIDNames_com);
            this.Controls.Add(this.Ubicacion_txt);
            this.Controls.Add(this.FechaExpiracion);
            this.Controls.Add(this.Precio_de_Venta_txt);
            this.Controls.Add(this.Precio_De_Compra_txt);
            this.Controls.Add(this.UnidadMedida_txt);
            this.Controls.Add(this.StockMaximo);
            this.Controls.Add(this.StockMinimo_txt);
            this.Controls.Add(this.Modelo_txt);
            this.Controls.Add(this.TipoDeDeSalida_com);
            this.Controls.Add(this.Marca_txt);
            this.Controls.Add(this.CodigoBarra_txt);
            this.Controls.Add(this.Descripcion_txt);
            this.Controls.Add(this.Nombre_txt);
            this.Name = "AgregarEditarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarEditarProductos";
            this.Load += new System.EventHandler(this.AgregarEditarProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox Nombre_txt;
        private MaterialSkin.Controls.MaterialMaskedTextBox Descripcion_txt;
        private MaterialSkin.Controls.MaterialMaskedTextBox CodigoBarra_txt;
        private MaterialSkin.Controls.MaterialMaskedTextBox Marca_txt;
        private MaterialSkin.Controls.MaterialComboBox TipoDeDeSalida_com;
        private MaterialSkin.Controls.MaterialMaskedTextBox Modelo_txt;
        private MaterialSkin.Controls.MaterialMaskedTextBox StockMinimo_txt;
        private MaterialSkin.Controls.MaterialMaskedTextBox StockMaximo;
        private MaterialSkin.Controls.MaterialComboBox UnidadMedida_txt;
        private MaterialSkin.Controls.MaterialMaskedTextBox Precio_De_Compra_txt;
        private MaterialSkin.Controls.MaterialMaskedTextBox Precio_de_Venta_txt;
        private Bunifu.UI.WinForms.BunifuDatePicker FechaExpiracion;
        private MaterialSkin.Controls.MaterialMaskedTextBox Ubicacion_txt;
        private MaterialSkin.Controls.MaterialComboBox ProvedoresIDNames_com;
        private MaterialSkin.Controls.MaterialMaskedTextBox Cantidad_txt;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton Agregar_usuarios;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}