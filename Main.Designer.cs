namespace p_proyect
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Gestion = new MaterialSkin.Controls.MaterialTabControl();
            this.GestionUsers = new System.Windows.Forms.TabPage();
            this.GenerarReportesUsuarios = new MaterialSkin.Controls.MaterialButton();
            this.BuscarUsuarios = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.Eliminar_Usuario = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.Agregar_usuarios = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.Usuarios_DataGrid = new System.Windows.Forms.DataGridView();
            this.GestionDeInventario = new System.Windows.Forms.TabPage();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialMaskedTextBox1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.ListadoDeProductosMostrar = new System.Windows.Forms.DataGridView();
            this.GestionDeProveedores = new System.Windows.Forms.TabPage();
            this.materialButton10 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
            this.materialMaskedTextBox2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialButton7 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton8 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton9 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.ProveedoresListadoShow = new System.Windows.Forms.DataGridView();
            this.GestionDeClientesEspeciales = new System.Windows.Forms.TabPage();
            this.materialButton11 = new MaterialSkin.Controls.MaterialButton();
            this.NombreDelClienteEspecial_txt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialButton12 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton13 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton14 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.ListadoClienteEspecialDg = new System.Windows.Forms.DataGridView();
            this.usuarioMostrarDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoMostrarDtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productoMostrarDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Gestion.SuspendLayout();
            this.GestionUsers.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios_DataGrid)).BeginInit();
            this.GestionDeInventario.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDeProductosMostrar)).BeginInit();
            this.GestionDeProveedores.SuspendLayout();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresListadoShow)).BeginInit();
            this.GestionDeClientesEspeciales.SuspendLayout();
            this.materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoClienteEspecialDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioMostrarDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoMostrarDtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoMostrarDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Gestion
            // 
            this.Gestion.Controls.Add(this.GestionUsers);
            this.Gestion.Controls.Add(this.GestionDeInventario);
            this.Gestion.Controls.Add(this.GestionDeProveedores);
            this.Gestion.Controls.Add(this.GestionDeClientesEspeciales);
            this.Gestion.Depth = 0;
            resources.ApplyResources(this.Gestion, "Gestion");
            this.Gestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.Gestion.Multiline = true;
            this.Gestion.Name = "Gestion";
            this.Gestion.SelectedIndex = 0;
            this.Gestion.SelectedIndexChanged += new System.EventHandler(this.Gestion_SelectedIndexChanged);
            // 
            // GestionUsers
            // 
            this.GestionUsers.Controls.Add(this.GenerarReportesUsuarios);
            this.GestionUsers.Controls.Add(this.BuscarUsuarios);
            this.GestionUsers.Controls.Add(this.Eliminar_Usuario);
            this.GestionUsers.Controls.Add(this.materialButton1);
            this.GestionUsers.Controls.Add(this.Agregar_usuarios);
            this.GestionUsers.Controls.Add(this.materialLabel2);
            this.GestionUsers.Controls.Add(this.materialLabel1);
            this.GestionUsers.Controls.Add(this.materialCard1);
            resources.ApplyResources(this.GestionUsers, "GestionUsers");
            this.GestionUsers.Name = "GestionUsers";
            this.GestionUsers.UseVisualStyleBackColor = true;
            // 
            // GenerarReportesUsuarios
            // 
            resources.ApplyResources(this.GenerarReportesUsuarios, "GenerarReportesUsuarios");
            this.GenerarReportesUsuarios.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.GenerarReportesUsuarios.Depth = 0;
            this.GenerarReportesUsuarios.HighEmphasis = true;
            this.GenerarReportesUsuarios.Icon = global::p_proyect.Properties.Resources.Descripcion;
            this.GenerarReportesUsuarios.Image = global::p_proyect.Properties.Resources.Aceprtar;
            this.GenerarReportesUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.GenerarReportesUsuarios.Name = "GenerarReportesUsuarios";
            this.GenerarReportesUsuarios.NoAccentTextColor = System.Drawing.Color.Empty;
            this.GenerarReportesUsuarios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.GenerarReportesUsuarios.UseAccentColor = true;
            this.GenerarReportesUsuarios.UseVisualStyleBackColor = true;
            this.GenerarReportesUsuarios.Click += new System.EventHandler(this.GenerarReportesUsuarios_Click);
            // 
            // BuscarUsuarios
            // 
            this.BuscarUsuarios.AllowPromptAsInput = true;
            this.BuscarUsuarios.AnimateReadOnly = false;
            this.BuscarUsuarios.AsciiOnly = false;
            resources.ApplyResources(this.BuscarUsuarios, "BuscarUsuarios");
            this.BuscarUsuarios.BeepOnError = false;
            this.BuscarUsuarios.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.BuscarUsuarios.Depth = 0;
            this.BuscarUsuarios.HidePromptOnLeave = false;
            this.BuscarUsuarios.HideSelection = true;
            this.BuscarUsuarios.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.BuscarUsuarios.LeadingIcon = global::p_proyect.Properties.Resources.busqueda_de_lupa;
            this.BuscarUsuarios.Mask = "";
            this.BuscarUsuarios.MaxLength = 32767;
            this.BuscarUsuarios.MouseState = MaterialSkin.MouseState.OUT;
            this.BuscarUsuarios.Name = "BuscarUsuarios";
            this.BuscarUsuarios.PasswordChar = '\0';
            this.BuscarUsuarios.PromptChar = '_';
            this.BuscarUsuarios.ReadOnly = false;
            this.BuscarUsuarios.RejectInputOnFirstFailure = false;
            this.BuscarUsuarios.ResetOnPrompt = true;
            this.BuscarUsuarios.ResetOnSpace = true;
            this.BuscarUsuarios.SelectedText = "";
            this.BuscarUsuarios.SelectionLength = 0;
            this.BuscarUsuarios.SelectionStart = 0;
            this.BuscarUsuarios.ShortcutsEnabled = true;
            this.BuscarUsuarios.SkipLiterals = true;
            this.BuscarUsuarios.TabStop = false;
            this.BuscarUsuarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BuscarUsuarios.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.BuscarUsuarios.TrailingIcon = null;
            this.BuscarUsuarios.UseSystemPasswordChar = false;
            this.BuscarUsuarios.ValidatingType = null;
            this.BuscarUsuarios.TextChanged += new System.EventHandler(this.BuscarUsuarios_TextChanged);
            // 
            // Eliminar_Usuario
            // 
            resources.ApplyResources(this.Eliminar_Usuario, "Eliminar_Usuario");
            this.Eliminar_Usuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Eliminar_Usuario.Depth = 0;
            this.Eliminar_Usuario.HighEmphasis = true;
            this.Eliminar_Usuario.Icon = global::p_proyect.Properties.Resources.Cancelar;
            this.Eliminar_Usuario.Image = global::p_proyect.Properties.Resources.Aceprtar;
            this.Eliminar_Usuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.Eliminar_Usuario.Name = "Eliminar_Usuario";
            this.Eliminar_Usuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Eliminar_Usuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Eliminar_Usuario.UseAccentColor = true;
            this.Eliminar_Usuario.UseVisualStyleBackColor = true;
            this.Eliminar_Usuario.Click += new System.EventHandler(this.Eliminar_Usuario_Click);
            // 
            // materialButton1
            // 
            resources.ApplyResources(this.materialButton1, "materialButton1");
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = global::p_proyect.Properties.Resources.ListaDeCompras;
            this.materialButton1.Image = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // Agregar_usuarios
            // 
            resources.ApplyResources(this.Agregar_usuarios, "Agregar_usuarios");
            this.Agregar_usuarios.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Agregar_usuarios.Depth = 0;
            this.Agregar_usuarios.HighEmphasis = true;
            this.Agregar_usuarios.Icon = global::p_proyect.Properties.Resources.Aceprtar;
            this.Agregar_usuarios.Image = global::p_proyect.Properties.Resources.Aceprtar;
            this.Agregar_usuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.Agregar_usuarios.Name = "Agregar_usuarios";
            this.Agregar_usuarios.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Agregar_usuarios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Agregar_usuarios.UseAccentColor = true;
            this.Agregar_usuarios.UseVisualStyleBackColor = true;
            this.Agregar_usuarios.Click += new System.EventHandler(this.Agregar_usuarios_Click);
            // 
            // materialLabel2
            // 
            resources.ApplyResources(this.materialLabel2, "materialLabel2");
            this.materialLabel2.Depth = 0;
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.Usuarios_DataGrid);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.materialCard1, "materialCard1");
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            // 
            // Usuarios_DataGrid
            // 
            this.Usuarios_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.Usuarios_DataGrid, "Usuarios_DataGrid");
            this.Usuarios_DataGrid.Name = "Usuarios_DataGrid";
            this.Usuarios_DataGrid.RowTemplate.Height = 24;
            this.Usuarios_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Usuarios_DataGrid_CellClick);
            this.Usuarios_DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Usuarios_DataGrid_CellContentClick);
            // 
            // GestionDeInventario
            // 
            this.GestionDeInventario.Controls.Add(this.materialButton2);
            this.GestionDeInventario.Controls.Add(this.materialMaskedTextBox1);
            this.GestionDeInventario.Controls.Add(this.materialButton3);
            this.GestionDeInventario.Controls.Add(this.materialButton4);
            this.GestionDeInventario.Controls.Add(this.materialButton5);
            this.GestionDeInventario.Controls.Add(this.materialLabel3);
            this.GestionDeInventario.Controls.Add(this.materialLabel4);
            this.GestionDeInventario.Controls.Add(this.materialCard2);
            resources.ApplyResources(this.GestionDeInventario, "GestionDeInventario");
            this.GestionDeInventario.Name = "GestionDeInventario";
            this.GestionDeInventario.UseVisualStyleBackColor = true;
            this.GestionDeInventario.Click += new System.EventHandler(this.GestionDeInventario_Click);
            // 
            // materialButton2
            // 
            resources.ApplyResources(this.materialButton2, "materialButton2");
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = global::p_proyect.Properties.Resources.Descripcion;
            this.materialButton2.Image = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = true;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialMaskedTextBox1
            // 
            this.materialMaskedTextBox1.AllowPromptAsInput = true;
            this.materialMaskedTextBox1.AnimateReadOnly = false;
            this.materialMaskedTextBox1.AsciiOnly = false;
            resources.ApplyResources(this.materialMaskedTextBox1, "materialMaskedTextBox1");
            this.materialMaskedTextBox1.BeepOnError = false;
            this.materialMaskedTextBox1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.Depth = 0;
            this.materialMaskedTextBox1.HidePromptOnLeave = false;
            this.materialMaskedTextBox1.HideSelection = true;
            this.materialMaskedTextBox1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox1.LeadingIcon = global::p_proyect.Properties.Resources.busqueda_de_lupa;
            this.materialMaskedTextBox1.Mask = "";
            this.materialMaskedTextBox1.MaxLength = 32767;
            this.materialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            this.materialMaskedTextBox1.PasswordChar = '\0';
            this.materialMaskedTextBox1.PromptChar = '_';
            this.materialMaskedTextBox1.ReadOnly = false;
            this.materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox1.ResetOnPrompt = true;
            this.materialMaskedTextBox1.ResetOnSpace = true;
            this.materialMaskedTextBox1.SelectedText = "";
            this.materialMaskedTextBox1.SelectionLength = 0;
            this.materialMaskedTextBox1.SelectionStart = 0;
            this.materialMaskedTextBox1.ShortcutsEnabled = true;
            this.materialMaskedTextBox1.SkipLiterals = true;
            this.materialMaskedTextBox1.TabStop = false;
            this.materialMaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.TrailingIcon = null;
            this.materialMaskedTextBox1.UseSystemPasswordChar = false;
            this.materialMaskedTextBox1.ValidatingType = null;
            this.materialMaskedTextBox1.TextChanged += new System.EventHandler(this.materialMaskedTextBox1_TextChanged);
            // 
            // materialButton3
            // 
            resources.ApplyResources(this.materialButton3, "materialButton3");
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = global::p_proyect.Properties.Resources.Cancelar;
            this.materialButton3.Image = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = true;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // materialButton4
            // 
            resources.ApplyResources(this.materialButton4, "materialButton4");
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = global::p_proyect.Properties.Resources.ListaDeCompras;
            this.materialButton4.Image = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = true;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // materialButton5
            // 
            resources.ApplyResources(this.materialButton5, "materialButton5");
            this.materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton5.Image = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = true;
            this.materialButton5.UseVisualStyleBackColor = true;
            this.materialButton5.Click += new System.EventHandler(this.materialButton5_Click);
            // 
            // materialLabel3
            // 
            resources.ApplyResources(this.materialLabel3, "materialLabel3");
            this.materialLabel3.Depth = 0;
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            // 
            // materialLabel4
            // 
            resources.ApplyResources(this.materialLabel4, "materialLabel4");
            this.materialLabel4.Depth = 0;
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.ListadoDeProductosMostrar);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.materialCard2, "materialCard2");
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            // 
            // ListadoDeProductosMostrar
            // 
            this.ListadoDeProductosMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.ListadoDeProductosMostrar, "ListadoDeProductosMostrar");
            this.ListadoDeProductosMostrar.Name = "ListadoDeProductosMostrar";
            this.ListadoDeProductosMostrar.RowTemplate.Height = 24;
            this.ListadoDeProductosMostrar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadoDeProductosMostrar_CellClick);
            this.ListadoDeProductosMostrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadoDeProductosMostrar_CellContentClick);
            // 
            // GestionDeProveedores
            // 
            this.GestionDeProveedores.Controls.Add(this.materialButton10);
            this.GestionDeProveedores.Controls.Add(this.materialButton6);
            this.GestionDeProveedores.Controls.Add(this.materialMaskedTextBox2);
            this.GestionDeProveedores.Controls.Add(this.materialButton7);
            this.GestionDeProveedores.Controls.Add(this.materialButton8);
            this.GestionDeProveedores.Controls.Add(this.materialButton9);
            this.GestionDeProveedores.Controls.Add(this.materialLabel5);
            this.GestionDeProveedores.Controls.Add(this.materialLabel6);
            this.GestionDeProveedores.Controls.Add(this.materialCard3);
            resources.ApplyResources(this.GestionDeProveedores, "GestionDeProveedores");
            this.GestionDeProveedores.Name = "GestionDeProveedores";
            this.GestionDeProveedores.UseVisualStyleBackColor = true;
            // 
            // materialButton10
            // 
            resources.ApplyResources(this.materialButton10, "materialButton10");
            this.materialButton10.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton10.Depth = 0;
            this.materialButton10.HighEmphasis = true;
            this.materialButton10.Icon = global::p_proyect.Properties.Resources.Descripcion;
            this.materialButton10.Image = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton10.Name = "materialButton10";
            this.materialButton10.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton10.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton10.UseAccentColor = true;
            this.materialButton10.UseVisualStyleBackColor = true;
            this.materialButton10.Click += new System.EventHandler(this.materialButton10_Click);
            // 
            // materialButton6
            // 
            resources.ApplyResources(this.materialButton6, "materialButton6");
            this.materialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton6.Depth = 0;
            this.materialButton6.HighEmphasis = true;
            this.materialButton6.Icon = global::p_proyect.Properties.Resources.Descripcion;
            this.materialButton6.Image = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton6.Name = "materialButton6";
            this.materialButton6.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton6.UseAccentColor = true;
            this.materialButton6.UseVisualStyleBackColor = true;
            this.materialButton6.Click += new System.EventHandler(this.materialButton6_Click);
            // 
            // materialMaskedTextBox2
            // 
            this.materialMaskedTextBox2.AllowPromptAsInput = true;
            this.materialMaskedTextBox2.AnimateReadOnly = false;
            this.materialMaskedTextBox2.AsciiOnly = false;
            resources.ApplyResources(this.materialMaskedTextBox2, "materialMaskedTextBox2");
            this.materialMaskedTextBox2.BeepOnError = false;
            this.materialMaskedTextBox2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox2.Depth = 0;
            this.materialMaskedTextBox2.HidePromptOnLeave = false;
            this.materialMaskedTextBox2.HideSelection = true;
            this.materialMaskedTextBox2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox2.LeadingIcon = global::p_proyect.Properties.Resources.busqueda_de_lupa;
            this.materialMaskedTextBox2.Mask = "";
            this.materialMaskedTextBox2.MaxLength = 32767;
            this.materialMaskedTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox2.Name = "materialMaskedTextBox2";
            this.materialMaskedTextBox2.PasswordChar = '\0';
            this.materialMaskedTextBox2.PromptChar = '_';
            this.materialMaskedTextBox2.ReadOnly = false;
            this.materialMaskedTextBox2.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox2.ResetOnPrompt = true;
            this.materialMaskedTextBox2.ResetOnSpace = true;
            this.materialMaskedTextBox2.SelectedText = "";
            this.materialMaskedTextBox2.SelectionLength = 0;
            this.materialMaskedTextBox2.SelectionStart = 0;
            this.materialMaskedTextBox2.ShortcutsEnabled = true;
            this.materialMaskedTextBox2.SkipLiterals = true;
            this.materialMaskedTextBox2.TabStop = false;
            this.materialMaskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox2.TrailingIcon = null;
            this.materialMaskedTextBox2.UseSystemPasswordChar = false;
            this.materialMaskedTextBox2.ValidatingType = null;
            this.materialMaskedTextBox2.TextChanged += new System.EventHandler(this.materialMaskedTextBox2_TextChanged);
            // 
            // materialButton7
            // 
            resources.ApplyResources(this.materialButton7, "materialButton7");
            this.materialButton7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton7.Depth = 0;
            this.materialButton7.HighEmphasis = true;
            this.materialButton7.Icon = global::p_proyect.Properties.Resources.Cancelar;
            this.materialButton7.Image = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton7.Name = "materialButton7";
            this.materialButton7.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton7.UseAccentColor = true;
            this.materialButton7.UseVisualStyleBackColor = true;
            this.materialButton7.Click += new System.EventHandler(this.materialButton7_Click);
            // 
            // materialButton8
            // 
            resources.ApplyResources(this.materialButton8, "materialButton8");
            this.materialButton8.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton8.Depth = 0;
            this.materialButton8.HighEmphasis = true;
            this.materialButton8.Icon = global::p_proyect.Properties.Resources.ListaDeCompras;
            this.materialButton8.Image = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton8.Name = "materialButton8";
            this.materialButton8.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton8.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton8.UseAccentColor = true;
            this.materialButton8.UseVisualStyleBackColor = true;
            this.materialButton8.Click += new System.EventHandler(this.materialButton8_Click);
            // 
            // materialButton9
            // 
            resources.ApplyResources(this.materialButton9, "materialButton9");
            this.materialButton9.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton9.Depth = 0;
            this.materialButton9.HighEmphasis = true;
            this.materialButton9.Icon = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton9.Image = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton9.Name = "materialButton9";
            this.materialButton9.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton9.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton9.UseAccentColor = true;
            this.materialButton9.UseVisualStyleBackColor = true;
            this.materialButton9.Click += new System.EventHandler(this.materialButton9_Click);
            // 
            // materialLabel5
            // 
            resources.ApplyResources(this.materialLabel5, "materialLabel5");
            this.materialLabel5.Depth = 0;
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            // 
            // materialLabel6
            // 
            resources.ApplyResources(this.materialLabel6, "materialLabel6");
            this.materialLabel6.Depth = 0;
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.ProveedoresListadoShow);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.materialCard3, "materialCard3");
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            // 
            // ProveedoresListadoShow
            // 
            this.ProveedoresListadoShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.ProveedoresListadoShow, "ProveedoresListadoShow");
            this.ProveedoresListadoShow.Name = "ProveedoresListadoShow";
            this.ProveedoresListadoShow.RowTemplate.Height = 24;
            this.ProveedoresListadoShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProveedoresListadoShow_CellClick);
            // 
            // GestionDeClientesEspeciales
            // 
            this.GestionDeClientesEspeciales.Controls.Add(this.materialButton11);
            this.GestionDeClientesEspeciales.Controls.Add(this.NombreDelClienteEspecial_txt);
            this.GestionDeClientesEspeciales.Controls.Add(this.materialButton12);
            this.GestionDeClientesEspeciales.Controls.Add(this.materialButton13);
            this.GestionDeClientesEspeciales.Controls.Add(this.materialButton14);
            this.GestionDeClientesEspeciales.Controls.Add(this.materialLabel7);
            this.GestionDeClientesEspeciales.Controls.Add(this.materialLabel8);
            this.GestionDeClientesEspeciales.Controls.Add(this.materialCard4);
            resources.ApplyResources(this.GestionDeClientesEspeciales, "GestionDeClientesEspeciales");
            this.GestionDeClientesEspeciales.Name = "GestionDeClientesEspeciales";
            this.GestionDeClientesEspeciales.UseVisualStyleBackColor = true;
            // 
            // materialButton11
            // 
            resources.ApplyResources(this.materialButton11, "materialButton11");
            this.materialButton11.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton11.Depth = 0;
            this.materialButton11.HighEmphasis = true;
            this.materialButton11.Icon = global::p_proyect.Properties.Resources.Descripcion;
            this.materialButton11.Image = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton11.Name = "materialButton11";
            this.materialButton11.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton11.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton11.UseAccentColor = true;
            this.materialButton11.UseVisualStyleBackColor = true;
            this.materialButton11.Click += new System.EventHandler(this.materialButton11_Click);
            // 
            // NombreDelClienteEspecial_txt
            // 
            this.NombreDelClienteEspecial_txt.AllowPromptAsInput = true;
            this.NombreDelClienteEspecial_txt.AnimateReadOnly = false;
            this.NombreDelClienteEspecial_txt.AsciiOnly = false;
            resources.ApplyResources(this.NombreDelClienteEspecial_txt, "NombreDelClienteEspecial_txt");
            this.NombreDelClienteEspecial_txt.BeepOnError = false;
            this.NombreDelClienteEspecial_txt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NombreDelClienteEspecial_txt.Depth = 0;
            this.NombreDelClienteEspecial_txt.HidePromptOnLeave = false;
            this.NombreDelClienteEspecial_txt.HideSelection = true;
            this.NombreDelClienteEspecial_txt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.NombreDelClienteEspecial_txt.LeadingIcon = global::p_proyect.Properties.Resources.busqueda_de_lupa;
            this.NombreDelClienteEspecial_txt.Mask = "";
            this.NombreDelClienteEspecial_txt.MaxLength = 32767;
            this.NombreDelClienteEspecial_txt.MouseState = MaterialSkin.MouseState.OUT;
            this.NombreDelClienteEspecial_txt.Name = "NombreDelClienteEspecial_txt";
            this.NombreDelClienteEspecial_txt.PasswordChar = '\0';
            this.NombreDelClienteEspecial_txt.PromptChar = '_';
            this.NombreDelClienteEspecial_txt.ReadOnly = false;
            this.NombreDelClienteEspecial_txt.RejectInputOnFirstFailure = false;
            this.NombreDelClienteEspecial_txt.ResetOnPrompt = true;
            this.NombreDelClienteEspecial_txt.ResetOnSpace = true;
            this.NombreDelClienteEspecial_txt.SelectedText = "";
            this.NombreDelClienteEspecial_txt.SelectionLength = 0;
            this.NombreDelClienteEspecial_txt.SelectionStart = 0;
            this.NombreDelClienteEspecial_txt.ShortcutsEnabled = true;
            this.NombreDelClienteEspecial_txt.SkipLiterals = true;
            this.NombreDelClienteEspecial_txt.TabStop = false;
            this.NombreDelClienteEspecial_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NombreDelClienteEspecial_txt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NombreDelClienteEspecial_txt.TrailingIcon = null;
            this.NombreDelClienteEspecial_txt.UseSystemPasswordChar = false;
            this.NombreDelClienteEspecial_txt.ValidatingType = null;
            this.NombreDelClienteEspecial_txt.TextChanged += new System.EventHandler(this.NombreDelClienteEspecial_txt_TextChanged);
            // 
            // materialButton12
            // 
            resources.ApplyResources(this.materialButton12, "materialButton12");
            this.materialButton12.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton12.Depth = 0;
            this.materialButton12.HighEmphasis = true;
            this.materialButton12.Icon = global::p_proyect.Properties.Resources.Cancelar;
            this.materialButton12.Image = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton12.Name = "materialButton12";
            this.materialButton12.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton12.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton12.UseAccentColor = true;
            this.materialButton12.UseVisualStyleBackColor = true;
            this.materialButton12.Click += new System.EventHandler(this.materialButton12_Click);
            // 
            // materialButton13
            // 
            resources.ApplyResources(this.materialButton13, "materialButton13");
            this.materialButton13.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton13.Depth = 0;
            this.materialButton13.HighEmphasis = true;
            this.materialButton13.Icon = global::p_proyect.Properties.Resources.ListaDeCompras;
            this.materialButton13.Image = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton13.Name = "materialButton13";
            this.materialButton13.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton13.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton13.UseAccentColor = true;
            this.materialButton13.UseVisualStyleBackColor = true;
            this.materialButton13.Click += new System.EventHandler(this.materialButton13_Click);
            // 
            // materialButton14
            // 
            resources.ApplyResources(this.materialButton14, "materialButton14");
            this.materialButton14.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton14.Depth = 0;
            this.materialButton14.HighEmphasis = true;
            this.materialButton14.Icon = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton14.Image = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton14.Name = "materialButton14";
            this.materialButton14.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton14.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton14.UseAccentColor = true;
            this.materialButton14.UseVisualStyleBackColor = true;
            this.materialButton14.Click += new System.EventHandler(this.materialButton14_Click);
            // 
            // materialLabel7
            // 
            resources.ApplyResources(this.materialLabel7, "materialLabel7");
            this.materialLabel7.Depth = 0;
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            // 
            // materialLabel8
            // 
            resources.ApplyResources(this.materialLabel8, "materialLabel8");
            this.materialLabel8.Depth = 0;
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.ListadoClienteEspecialDg);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.materialCard4, "materialCard4");
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            // 
            // ListadoClienteEspecialDg
            // 
            this.ListadoClienteEspecialDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.ListadoClienteEspecialDg, "ListadoClienteEspecialDg");
            this.ListadoClienteEspecialDg.Name = "ListadoClienteEspecialDg";
            this.ListadoClienteEspecialDg.RowTemplate.Height = 24;
            this.ListadoClienteEspecialDg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadoClienteEspecialDg_CellClick);
            // 
            // usuarioMostrarDtoBindingSource
            // 
            this.usuarioMostrarDtoBindingSource.DataSource = typeof(p_proyect.Modules.Entidades.dtos.dtoUsuarios.UsuarioMostrarDto);
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataSource = typeof(p_proyect.Modules.Entidades.Proveedor);
            // 
            // productoMostrarDtoBindingSource1
            // 
            this.productoMostrarDtoBindingSource1.DataSource = typeof(p_proyect.Modules.Entidades.dtos.dtoProductos.ProductoMostrarDto);
            // 
            // productoMostrarDtoBindingSource
            // 
            this.productoMostrarDtoBindingSource.DataSource = typeof(p_proyect.Modules.Entidades.dtos.dtoProductos.ProductoMostrarDto);
            // 
            // proveedorBindingSource1
            // 
            this.proveedorBindingSource1.DataSource = typeof(p_proyect.Modules.Entidades.Proveedor);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Gestion);
            this.DrawerTabControl = this.Gestion;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Gestion.ResumeLayout(false);
            this.GestionUsers.ResumeLayout(false);
            this.GestionUsers.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios_DataGrid)).EndInit();
            this.GestionDeInventario.ResumeLayout(false);
            this.GestionDeInventario.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDeProductosMostrar)).EndInit();
            this.GestionDeProveedores.ResumeLayout(false);
            this.GestionDeProveedores.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresListadoShow)).EndInit();
            this.GestionDeClientesEspeciales.ResumeLayout(false);
            this.GestionDeClientesEspeciales.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoClienteEspecialDg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioMostrarDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoMostrarDtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoMostrarDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl Gestion;
        private System.Windows.Forms.TabPage GestionUsers;
        private System.Windows.Forms.TabPage GestionDeInventario;
        private MaterialSkin.Controls.MaterialButton Agregar_usuarios;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.DataGridView Usuarios_DataGrid;
        private MaterialSkin.Controls.MaterialButton Eliminar_Usuario;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialMaskedTextBox BuscarUsuarios;
        private MaterialSkin.Controls.MaterialButton GenerarReportesUsuarios;
        private System.Windows.Forms.TabPage GestionDeProveedores;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.DataGridView ListadoDeProductosMostrar;
        private System.Windows.Forms.BindingSource productoMostrarDtoBindingSource;
        private System.Windows.Forms.BindingSource usuarioMostrarDtoBindingSource;
        private System.Windows.Forms.BindingSource productoMostrarDtoBindingSource1;
        private MaterialSkin.Controls.MaterialButton materialButton6;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox2;
        private MaterialSkin.Controls.MaterialButton materialButton7;
        private MaterialSkin.Controls.MaterialButton materialButton8;
        private MaterialSkin.Controls.MaterialButton materialButton9;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.DataGridView ProveedoresListadoShow;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private MaterialSkin.Controls.MaterialButton materialButton10;
        private System.Windows.Forms.BindingSource proveedorBindingSource1;
        private System.Windows.Forms.TabPage GestionDeClientesEspeciales;
        private MaterialSkin.Controls.MaterialButton materialButton11;
        private MaterialSkin.Controls.MaterialMaskedTextBox NombreDelClienteEspecial_txt;
        private MaterialSkin.Controls.MaterialButton materialButton12;
        private MaterialSkin.Controls.MaterialButton materialButton13;
        private MaterialSkin.Controls.MaterialButton materialButton14;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private System.Windows.Forms.DataGridView ListadoClienteEspecialDg;
    }
}