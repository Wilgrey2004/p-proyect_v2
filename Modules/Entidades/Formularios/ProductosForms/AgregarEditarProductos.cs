using MaterialSkin;
using MaterialSkin.Controls;
using p_proyect.Controller.ProductosController;
using p_proyect.Controller.ProveedorController;
using p_proyect.Modules.Entidades.dtos.dtoProductos;
using p_proyect.Modules.Enums;
using p_proyect.Utils;
using System;
using System.Windows.Forms;

namespace p_proyect.Modules.Entidades.Formularios.ProductosForms
{
    public partial class AgregarEditarProductos : MaterialForm
    {
        public Producto productoSeleccioando = new Producto();
        private ProductosControllerC productosControllerC = new ProductosControllerC();
        ProveedorControllerC proveedorcontrollerC = new ProveedorControllerC();
        public AgregarEditarProductos()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            // Fondos blancos
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Tema rojizo empresarial
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red800,   // Color principal (barra superior)
                Primary.Red900,   // Dark Primary
                Primary.Red700,   // Light Primary
                Accent.Red200,    // Acento (buttons, sliders)
                TextShade.WHITE   // Color del texto de la barra
            );
        }


        private async void AgregarEditarProductos_Load(object sender, EventArgs e)
        {

            ComboHelper.CargarEnumEnCombo<UnidadMedida>(UnidadMedida_txt);
            ComboHelper.CargarEnumEnCombo<TipoDeVenta>(TipoDeDeSalida_com);
            ComboHelper.CargarEnumComboEntidadIDNombre(ProvedoresIDNames_com, await proveedorcontrollerC.ObtenerTodosLosProveedores());

            if(productoSeleccioando == null)
            {
                Text = "Agregar Producto Nuevo!!";
            }
            else
            {
                Agregar_usuarios.Text = "Editar Producto";
                Text = $"Editar Producto Ya Existente {productoSeleccioando.Nombre}";
                CargarProductoEnControles(productoSeleccioando);
            }

        }

        private void materialMaskedTextBox7_Click(object sender, EventArgs e)
        {

        }
        private void CargarProductoEnControles(Producto producto)
        {
            if (producto == null)
                return;

            // ✅ TextBox
            Nombre_txt.Text = producto.Nombre ?? "";
            Descripcion_txt.Text = producto.Descripcion ?? "";
            CodigoBarra_txt.Text = producto.CodigoBarra ?? "";
            Marca_txt.Text = producto.Marca ?? "";
            Modelo_txt.Text = producto.Modelo ?? "";
            Cantidad_txt.Text = producto.Cantidad.ToString();
            StockMinimo_txt.Text = producto.StockMinimo.ToString();
            StockMaximo.Text = producto.StockMaximo.ToString();
            Precio_De_Compra_txt.Text = producto.PrecioCompra.ToString("0.00");
            Precio_de_Venta_txt.Text = producto.PrecioVenta.ToString("0.00");
            Ubicacion_txt.Text = producto.Ubicacion ?? "";

            // ✅ DateTimePicker
            if (producto.FechaExpiracion.HasValue)
                FechaExpiracion.Value = producto.FechaExpiracion.Value;
            else
                FechaExpiracion.Value = DateTime.Now;

            // ✅ ComboBoxes
            TipoDeDeSalida_com.SelectedItem = producto.TipoDeDeSalida;
            UnidadMedida_txt.SelectedItem = producto.UnidadMedida;

            // ✅ ComboBox de Proveedor (usa el Id como Value)
            ProvedoresIDNames_com.SelectedValue = producto.ProveedorId;
        }


        private ProductoCreateDto GenerarProducto()
        {
            return new ProductoCreateDto
            {
                Nombre = Nombre_txt.Text.Trim(),
                Descripcion = Descripcion_txt.Text,
                CodigoBarra = CodigoBarra_txt.Text,
                Marca = Marca_txt.Text.Trim(),
                Modelo = Modelo_txt.Text.Trim(),
                Cantidad = int.Parse(Cantidad_txt.Text.Trim()),
                StockMaximo = int.Parse(StockMaximo.Text.Trim()),
                StockMinimo = int.Parse(StockMinimo_txt.Text.Trim()),
                PrecioVenta = decimal.Parse(Precio_de_Venta_txt.Text.Trim()),
                PrecioCompra = decimal.Parse(Precio_De_Compra_txt.Text.Trim()),
                Ubicacion = Ubicacion_txt.Text.Trim(),
                TipoDeDeSalida = (TipoDeVenta)TipoDeDeSalida_com.SelectedItem,
                UnidadMedida = (UnidadMedida)UnidadMedida_txt.SelectedItem,
                ProveedorId = (int) ProvedoresIDNames_com.SelectedValue,
                FechaExpiracion =(DateTime) FechaExpiracion.Value
            };
        }

        private ProductoEditarDto GenerarProductoEditarDto()
        {
            return new ProductoEditarDto
            {
                Id = productoSeleccioando.Id, // ✅ Asegúrate de tener un TextBox o variable para el ID
                Nombre = Nombre_txt.Text.Trim(),
                Descripcion = Descripcion_txt.Text,
                CodigoBarra = CodigoBarra_txt.Text,
                Marca = Marca_txt.Text.Trim(),
                Modelo = Modelo_txt.Text.Trim(),
                Cantidad = int.Parse(Cantidad_txt.Text.Trim()),
                StockMaximo = int.Parse(StockMaximo.Text.Trim()),
                StockMinimo = int.Parse(StockMinimo_txt.Text.Trim()),
                PrecioVenta = decimal.Parse(Precio_de_Venta_txt.Text.Trim()),
                PrecioCompra = decimal.Parse(Precio_De_Compra_txt.Text.Trim()),
                Ubicacion = Ubicacion_txt.Text.Trim(),
                TipoDeDeSalida = (TipoDeVenta)TipoDeDeSalida_com.SelectedItem,
                UnidadMedida = (UnidadMedida)UnidadMedida_txt.SelectedItem,
                ProveedorId = (int)ProvedoresIDNames_com.SelectedValue,
                FechaExpiracion = (DateTime)FechaExpiracion.Value,
                //Activo = Activo_check.Checked, // ✅ si tienes un checkbox de estado
               // FechaActualizacion = DateTime.Now
            };
        }


        private async void Agregar_usuarios_Click(object sender, EventArgs e)
        {
            if (productoSeleccioando != null)
            {

                await productosControllerC.EditarProductoASync(GenerarProductoEditarDto());
                MessageBox.Show("Producto Editado Con exito!!");

                Close();
                return;

            }

          
           var producto = await productosControllerC.CrearProductoAsync(GenerarProducto());

            if(producto != null)
            {
                MessageBox.Show("Producto agrgeado con exito!!");
                Close();
                return;
            }


            return;

            

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CodigoBarra_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string codigo = CodigoBarra_txt.Text.Trim();

                CodigoBarra_txt.Text = codigo;


                //CargarProductos(codigo);
                //MessageBox.Show($"Codigo Escaneado {codigo} \n ");

                e.Handled = true;
                e.SuppressKeyPress = true;


            }
        }
    }
}
