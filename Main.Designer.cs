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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Gestion.SuspendLayout();
            this.GestionUsers.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios_DataGrid)).BeginInit();
            this.GestionDeInventario.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Gestion
            // 
            this.Gestion.Controls.Add(this.GestionUsers);
            this.Gestion.Controls.Add(this.GestionDeInventario);
            this.Gestion.Controls.Add(this.tabPage1);
            this.Gestion.Depth = 0;
            resources.ApplyResources(this.Gestion, "Gestion");
            this.Gestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.Gestion.Multiline = true;
            this.Gestion.Name = "Gestion";
            this.Gestion.SelectedIndex = 0;
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
            this.materialCard2.Controls.Add(this.dataGridView1);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.materialCard2, "materialCard2");
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}