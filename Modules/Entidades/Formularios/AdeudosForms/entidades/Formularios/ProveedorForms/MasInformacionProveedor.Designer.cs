namespace p_proyect.Modules.Entidades.Formularios.ProveedorForms
{
    partial class MasInformacionProveedor
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
            this.ListadoDeProductosDeEsteProveedor = new System.Windows.Forms.DataGridView();
            this.ProductosDelProveedoir = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.FechaDeAgregadiDelProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.UltimaCompraDelProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.ContactoDelProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.NombreProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton8 = new MaterialSkin.Controls.MaterialButton();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDeDeSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMaximoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gananciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaExpiracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nombreProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoMostrarDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDeProductosDeEsteProveedor)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoMostrarDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ListadoDeProductosDeEsteProveedor
            // 
            this.ListadoDeProductosDeEsteProveedor.AutoGenerateColumns = false;
            this.ListadoDeProductosDeEsteProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoDeProductosDeEsteProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.codigoBarraDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.tipoDeDeSalidaDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.stockMinimoDataGridViewTextBoxColumn,
            this.stockMaximoDataGridViewTextBoxColumn,
            this.unidadMedidaDataGridViewTextBoxColumn,
            this.precioCompraDataGridViewTextBoxColumn,
            this.precioVentaDataGridViewTextBoxColumn,
            this.gananciaDataGridViewTextBoxColumn,
            this.fechaExpiracionDataGridViewTextBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn,
            this.ubicacionDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.nombreProveedorDataGridViewTextBoxColumn});
            this.ListadoDeProductosDeEsteProveedor.DataSource = this.productoMostrarDtoBindingSource;
            this.ListadoDeProductosDeEsteProveedor.Location = new System.Drawing.Point(505, 110);
            this.ListadoDeProductosDeEsteProveedor.Name = "ListadoDeProductosDeEsteProveedor";
            this.ListadoDeProductosDeEsteProveedor.Size = new System.Drawing.Size(608, 537);
            this.ListadoDeProductosDeEsteProveedor.TabIndex = 4;
            this.ListadoDeProductosDeEsteProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadoDeProductosDeEsteProveedor_CellClick);
            // 
            // ProductosDelProveedoir
            // 
            this.ProductosDelProveedoir.AutoSize = true;
            this.ProductosDelProveedoir.Depth = 0;
            this.ProductosDelProveedoir.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductosDelProveedoir.Location = new System.Drawing.Point(553, 88);
            this.ProductosDelProveedoir.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProductosDelProveedoir.Name = "ProductosDelProveedoir";
            this.ProductosDelProveedoir.Size = new System.Drawing.Size(172, 19);
            this.ProductosDelProveedoir.TabIndex = 5;
            this.ProductosDelProveedoir.Text = "Productos del proveedor";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(28, 88);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(186, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Informacion del proveedor";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.FechaDeAgregadiDelProveedor);
            this.materialCard1.Controls.Add(this.UltimaCompraDelProveedor);
            this.materialCard1.Controls.Add(this.ContactoDelProveedor);
            this.materialCard1.Controls.Add(this.NombreProveedor);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(31, 121);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(457, 424);
            this.materialCard1.TabIndex = 7;
            // 
            // FechaDeAgregadiDelProveedor
            // 
            this.FechaDeAgregadiDelProveedor.AutoSize = true;
            this.FechaDeAgregadiDelProveedor.Depth = 0;
            this.FechaDeAgregadiDelProveedor.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.FechaDeAgregadiDelProveedor.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.FechaDeAgregadiDelProveedor.Location = new System.Drawing.Point(32, 342);
            this.FechaDeAgregadiDelProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.FechaDeAgregadiDelProveedor.Name = "FechaDeAgregadiDelProveedor";
            this.FechaDeAgregadiDelProveedor.Size = new System.Drawing.Size(350, 24);
            this.FechaDeAgregadiDelProveedor.TabIndex = 7;
            this.FechaDeAgregadiDelProveedor.Text = "Fecha en la que se agrego al proveedor";
            // 
            // UltimaCompraDelProveedor
            // 
            this.UltimaCompraDelProveedor.AutoSize = true;
            this.UltimaCompraDelProveedor.Depth = 0;
            this.UltimaCompraDelProveedor.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.UltimaCompraDelProveedor.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.UltimaCompraDelProveedor.Location = new System.Drawing.Point(32, 253);
            this.UltimaCompraDelProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.UltimaCompraDelProveedor.Name = "UltimaCompraDelProveedor";
            this.UltimaCompraDelProveedor.Size = new System.Drawing.Size(247, 24);
            this.UltimaCompraDelProveedor.TabIndex = 6;
            this.UltimaCompraDelProveedor.Text = "Ultima compra al proveedor";
            // 
            // ContactoDelProveedor
            // 
            this.ContactoDelProveedor.AutoSize = true;
            this.ContactoDelProveedor.Depth = 0;
            this.ContactoDelProveedor.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ContactoDelProveedor.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.ContactoDelProveedor.Location = new System.Drawing.Point(32, 156);
            this.ContactoDelProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.ContactoDelProveedor.Name = "ContactoDelProveedor";
            this.ContactoDelProveedor.Size = new System.Drawing.Size(254, 29);
            this.ContactoDelProveedor.TabIndex = 5;
            this.ContactoDelProveedor.Text = "Contacto del proveedor";
            // 
            // NombreProveedor
            // 
            this.NombreProveedor.AutoSize = true;
            this.NombreProveedor.Depth = 0;
            this.NombreProveedor.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.NombreProveedor.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.NombreProveedor.Location = new System.Drawing.Point(32, 67);
            this.NombreProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.NombreProveedor.Name = "NombreProveedor";
            this.NombreProveedor.Size = new System.Drawing.Size(241, 29);
            this.NombreProveedor.TabIndex = 4;
            this.NombreProveedor.Text = "Nombre del proveedor";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(34, 35);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Nombre";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(34, 137);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(65, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Contacto";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(34, 234);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(193, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Fecha de la ultima compra ";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(33, 323);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(136, 19);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Fecha de agregado";
            // 
            // materialFloatingActionButton1
            // 
            this.materialFloatingActionButton1.Depth = 0;
            this.materialFloatingActionButton1.Icon = global::p_proyect.Properties.Resources.logotipo_de_whatsapp;
            this.materialFloatingActionButton1.Location = new System.Drawing.Point(31, 591);
            this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton1.TabIndex = 8;
            this.materialFloatingActionButton1.Text = "Escribir Por Whattsap";
            this.materialFloatingActionButton1.UseVisualStyleBackColor = true;
            this.materialFloatingActionButton1.Click += new System.EventHandler(this.materialFloatingActionButton1_Click);
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = global::p_proyect.Properties.Resources.ListaDeCompras;
            this.materialButton4.Image = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialButton4.Location = new System.Drawing.Point(93, 572);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(180, 36);
            this.materialButton4.TabIndex = 13;
            this.materialButton4.Text = "Editar Producto";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = true;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // materialButton8
            // 
            this.materialButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton8.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton8.Depth = 0;
            this.materialButton8.HighEmphasis = true;
            this.materialButton8.Icon = global::p_proyect.Properties.Resources.ListaDeCompras;
            this.materialButton8.Image = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialButton8.Location = new System.Drawing.Point(93, 618);
            this.materialButton8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton8.Name = "materialButton8";
            this.materialButton8.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton8.Size = new System.Drawing.Size(187, 36);
            this.materialButton8.TabIndex = 21;
            this.materialButton8.Text = "Editar Proveedor";
            this.materialButton8.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton8.UseAccentColor = true;
            this.materialButton8.UseVisualStyleBackColor = true;
            this.materialButton8.Click += new System.EventHandler(this.materialButton8_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre del Producto";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // codigoBarraDataGridViewTextBoxColumn
            // 
            this.codigoBarraDataGridViewTextBoxColumn.DataPropertyName = "CodigoBarra";
            this.codigoBarraDataGridViewTextBoxColumn.HeaderText = "Código de Barra";
            this.codigoBarraDataGridViewTextBoxColumn.Name = "codigoBarraDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            // 
            // tipoDeDeSalidaDataGridViewTextBoxColumn
            // 
            this.tipoDeDeSalidaDataGridViewTextBoxColumn.DataPropertyName = "TipoDeDeSalida";
            this.tipoDeDeSalidaDataGridViewTextBoxColumn.HeaderText = "Tipo de Venta";
            this.tipoDeDeSalidaDataGridViewTextBoxColumn.Name = "tipoDeDeSalidaDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad Disponible";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // stockMinimoDataGridViewTextBoxColumn
            // 
            this.stockMinimoDataGridViewTextBoxColumn.DataPropertyName = "StockMinimo";
            this.stockMinimoDataGridViewTextBoxColumn.HeaderText = "Stock Mínimo";
            this.stockMinimoDataGridViewTextBoxColumn.Name = "stockMinimoDataGridViewTextBoxColumn";
            // 
            // stockMaximoDataGridViewTextBoxColumn
            // 
            this.stockMaximoDataGridViewTextBoxColumn.DataPropertyName = "StockMaximo";
            this.stockMaximoDataGridViewTextBoxColumn.HeaderText = "Stock Máximo";
            this.stockMaximoDataGridViewTextBoxColumn.Name = "stockMaximoDataGridViewTextBoxColumn";
            // 
            // unidadMedidaDataGridViewTextBoxColumn
            // 
            this.unidadMedidaDataGridViewTextBoxColumn.DataPropertyName = "UnidadMedida";
            this.unidadMedidaDataGridViewTextBoxColumn.HeaderText = "Unidad de Medida";
            this.unidadMedidaDataGridViewTextBoxColumn.Name = "unidadMedidaDataGridViewTextBoxColumn";
            // 
            // precioCompraDataGridViewTextBoxColumn
            // 
            this.precioCompraDataGridViewTextBoxColumn.DataPropertyName = "PrecioCompra";
            this.precioCompraDataGridViewTextBoxColumn.HeaderText = "Precio de Compra";
            this.precioCompraDataGridViewTextBoxColumn.Name = "precioCompraDataGridViewTextBoxColumn";
            // 
            // precioVentaDataGridViewTextBoxColumn
            // 
            this.precioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta";
            this.precioVentaDataGridViewTextBoxColumn.HeaderText = "Precio de Venta";
            this.precioVentaDataGridViewTextBoxColumn.Name = "precioVentaDataGridViewTextBoxColumn";
            // 
            // gananciaDataGridViewTextBoxColumn
            // 
            this.gananciaDataGridViewTextBoxColumn.DataPropertyName = "Ganancia";
            this.gananciaDataGridViewTextBoxColumn.HeaderText = "Ganancia";
            this.gananciaDataGridViewTextBoxColumn.Name = "gananciaDataGridViewTextBoxColumn";
            // 
            // fechaExpiracionDataGridViewTextBoxColumn
            // 
            this.fechaExpiracionDataGridViewTextBoxColumn.DataPropertyName = "FechaExpiracion";
            this.fechaExpiracionDataGridViewTextBoxColumn.HeaderText = "Fecha de Expiración";
            this.fechaExpiracionDataGridViewTextBoxColumn.Name = "fechaExpiracionDataGridViewTextBoxColumn";
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "Fecha en la que se agrego al inventario";
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            // 
            // ubicacionDataGridViewTextBoxColumn
            // 
            this.ubicacionDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion";
            this.ubicacionDataGridViewTextBoxColumn.HeaderText = "Ubicación en Almacén";
            this.ubicacionDataGridViewTextBoxColumn.Name = "ubicacionDataGridViewTextBoxColumn";
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Esta disponible";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            // 
            // nombreProveedorDataGridViewTextBoxColumn
            // 
            this.nombreProveedorDataGridViewTextBoxColumn.DataPropertyName = "NombreProveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.HeaderText = "Nombre del proveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.Name = "nombreProveedorDataGridViewTextBoxColumn";
            // 
            // productoMostrarDtoBindingSource
            // 
            this.productoMostrarDtoBindingSource.DataSource = typeof(p_proyect.Modules.Entidades.dtos.dtoProductos.ProductoMostrarDto);
            // 
            // materialButton5
            // 
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton5.Image = global::p_proyect.Properties.Resources.Aceprtar;
            this.materialButton5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialButton5.Location = new System.Drawing.Point(279, 572);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Size = new System.Drawing.Size(196, 36);
            this.materialButton5.TabIndex = 22;
            this.materialButton5.Text = "Agregar producto";
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = true;
            this.materialButton5.UseVisualStyleBackColor = true;
            this.materialButton5.Click += new System.EventHandler(this.materialButton5_Click);
            // 
            // MasInformacionProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 666);
            this.Controls.Add(this.materialButton5);
            this.Controls.Add(this.materialButton8);
            this.Controls.Add(this.materialButton4);
            this.Controls.Add(this.materialFloatingActionButton1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ProductosDelProveedoir);
            this.Controls.Add(this.ListadoDeProductosDeEsteProveedor);
            this.Name = "MasInformacionProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasInformacionProveedor";
            this.Load += new System.EventHandler(this.MasInformacionProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDeProductosDeEsteProveedor)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoMostrarDtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ListadoDeProductosDeEsteProveedor;
        private MaterialSkin.Controls.MaterialLabel ProductosDelProveedoir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDeDeSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMaximoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gananciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaExpiracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productoMostrarDtoBindingSource;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel FechaDeAgregadiDelProveedor;
        private MaterialSkin.Controls.MaterialLabel UltimaCompraDelProveedor;
        private MaterialSkin.Controls.MaterialLabel ContactoDelProveedor;
        private MaterialSkin.Controls.MaterialLabel NombreProveedor;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton8;
        private MaterialSkin.Controls.MaterialButton materialButton5;
    }
}