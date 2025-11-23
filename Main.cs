using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using p_proyect.Controller.AdeudoController;
using p_proyect.Controller.ClienteEspecialController;
using p_proyect.Controller.ClienteNormalController;
using p_proyect.Controller.ProductosController;
using p_proyect.Controller.ProveedorController;
using p_proyect.Controller.UsuarioController;
using p_proyect.Modules;
using p_proyect.Modules.Entidades;
using p_proyect.Modules.Entidades.dtos.dtoAdeudos;
using p_proyect.Modules.Entidades.dtos.dtoClienteEspecial;
using p_proyect.Modules.Entidades.dtos.dtoClienteNormal;
using p_proyect.Modules.Entidades.dtos.dtoCompras;
using p_proyect.Modules.Entidades.dtos.dtoProductos;
using p_proyect.Modules.Entidades.dtos.dtoProveedor;
using p_proyect.Modules.Entidades.dtos.dtoUsuarios;
using p_proyect.Modules.Entidades.dtos.dtoVentas;
using p_proyect.Modules.Entidades.Formularios.AdeudosForms;
using p_proyect.Modules.Entidades.Formularios.ClienteEspecialForms;
using p_proyect.Modules.Entidades.Formularios.ProductosForms;
using p_proyect.Modules.Entidades.Formularios.ProveedorForms;
using p_proyect.Modules.Entidades.Formularios.UsuarioForms;
using p_proyect.Modules.Entidades.Formularios.VentaForms;
using p_proyect.Modules.Enums;
using p_proyect.Utils;
using p_proyect.Utils.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_proyect
{
    public partial class Main : MaterialForm
    {

        public Usuarios SecionActual = new Usuarios();
        private ProductosControllerC productosControllerC = new ProductosControllerC();
        private List<ProductoMostrarDto> productoMostrarDtos = new List<ProductoMostrarDto>();
        ProductosControllerC productoController = new ProductosControllerC();
        public Main()
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


        UsuarioControllerC usuarioControllerC = new UsuarioControllerC();
        List<UsuarioMostrarDto> Listado_De_usuarios_Mostrar = new List<UsuarioMostrarDto>();
        // List<Usuarios> Listado_De_usuarios_Original = new List<Usuarios>();
        private async void Main_Load(object sender, EventArgs e)
        {


            await CargarTablaDeUsuarios();


            if (SecionActual.Rol == UserRole.Administrador)
            {
                MessageBox.Show($"Bienvenido {SecionActual.Nombre}", "Saludo!");
                return;
            }

            if (SecionActual.Rol == UserRole.GestorDeInventario)
            {
                Gestion.TabPages.Remove(GestionDeClientesEspeciales);
                Gestion.TabPages.Remove(GestionDeClientesNormales);
                Gestion.TabPages.Remove(GestionVentaAlDetalle);
                Gestion.TabPages.Remove(GestionUsers);
                return;
            }

            if (SecionActual.Rol == UserRole.Vendedor)
            {
                //Gestion.TabPages.Remove(GestionDeClientesEspeciales);
                Gestion.TabPages.Remove(GestionDeClientesNormales);
                //Gestion.TabPages.Remove(GestionVentaAlDetalle);
                // Gestion.TabPages.Remove(GestionUsers);

                return;
            }

            if (SecionActual.Rol == UserRole.None)
            {
                MessageBox.Show($"Este usuario no contiene en si un rol {SecionActual.Nombre}", "Error!");
                Close();
                return;
            }

            if (SecionActual.Rol == UserRole.Empleado)
            {
                MessageBox.Show($"Este usuario no contiene en si un rol {SecionActual.Nombre}", "Error!");
                Close();
                return;
            }





        }
        List<AdeudoMostrarDto> ListaDeAdeudos = new List<AdeudoMostrarDto>();
        AdeudoControllerC AdeudocontrollerC_ = new AdeudoControllerC();
        private async Task CargarAdeudos()
        {
            ListaDeAdeudos.Clear();
            ListaDeAdeudos = await AdeudocontrollerC_.ObtenerTodosLosAdeudosAsync();
            ListadoDeAdeudos.DataSource = null;
            ListadoDeAdeudos.DataSource = ListaDeAdeudos;
        }

        List<ProductoVentasMostrarDto> listadoProductosDisponiblesVenta = new List<ProductoVentasMostrarDto>();
        List<CarritoCompraDto> CarritoDeCompras = new List<CarritoCompraDto>();

        private void LimpiarCamposDeVenta()
        {
            Codigo_Del_Producto_txt.Text = string.Empty;
            Nombre_Del_Producto_txt.Text = string.Empty;
            UnidadDeMedidaDelProducto.Text = string.Empty;
            PrecioPorUnidadDelProducto_txt.Text = string.Empty;
            numCantidadProducto.Value = 1;
            ProductoAComprarVenta = -1;
        }
        private async Task CargarTablasVenta()
        {

            LimpiarCamposDeVenta();


            ListadoDeProductosDisponibles_dg.DataSource = null;
            listadoProductosDisponiblesVenta.Clear();
            listadoProductosDisponiblesVenta = await productosControllerC.ObtenerTodosLosproductosParaListaDeProductos();
            ListadoDeProductosDisponibles_dg.DataSource = listadoProductosDisponiblesVenta;

            CarritoDecompras_dg.DataSource = null;
            CarritoDeCompras.Clear();
            CarritoDecompras_dg.DataSource = CarritoDeCompras;



        }

        ClienteNormalControllerC ClienteNormalControllerC_ = new ClienteNormalControllerC();
        List<ClienteNormalMostrarDto> ListadoClienteNormalMostrarDtos = new List<ClienteNormalMostrarDto>();
        private async Task CargarListadoDeClientesNormales()
        {
            ListadoClienteNormalMostrarDtos.Clear();
            ListadoDeClientesNormalesDg.DataSource = null;


            ListadoClienteNormalMostrarDtos = await ClienteNormalControllerC_.ObtenerTodosLosClientesNormalesAsync();
            ListadoDeClientesNormalesDg.DataSource = ListadoClienteNormalMostrarDtos;

        }


        ClienteEspecialControllerC clienteEspecialControllerC = new ClienteEspecialControllerC();
        List<ClienteEspecialMostrarDto> listadoDeClientesEspecialesMostrar = new List<ClienteEspecialMostrarDto>();

        private async Task CargarListadoDeClientesEspeciales()
        {
            listadoDeClientesEspecialesMostrar = await clienteEspecialControllerC.ObtenerTodosLosClientesEspecialesAsync();
            ListadoClienteEspecialDg.DataSource = null;
            ListadoClienteEspecialDg.DataSource = listadoDeClientesEspecialesMostrar;
        }





        public async Task<List<Usuarios>> CargarLista()
        {
            return await usuarioControllerC.ObtenerTodosLosUsuariosAsync();
        }

        public async Task ConvertirListadoDeUsuarios(List<UsuarioMostrarDto> listadoMostrar)
        {
            // ListHelper.ClearList<Usuarios>(listadoOriginal);
            ListHelper.ClearList<UsuarioMostrarDto>(listadoMostrar);

            var listadoOriginal = await CargarLista();

            for (int i = 0; i < listadoOriginal.Count; i++)
            {
                for (int j = 0; j < listadoMostrar.Count; j++)
                {
                    if (listadoMostrar[j].Id == listadoOriginal[i].Id)
                    {
                        listadoMostrar.RemoveAt(j);
                    }
                }

                listadoMostrar.Add(UsuarioMostrarDto.Convertir(listadoOriginal[i]));
            }
        }

        public async Task CargarTablaDeUsuarios()
        {

            await ConvertirListadoDeUsuarios(Listado_De_usuarios_Mostrar);

            Usuarios_DataGrid.DataSource = Listado_De_usuarios_Mostrar;
        }

        public async Task CargarTablaProductos()
        {
            productoMostrarDtos = await productoController.ObtenerTodosLosProductos();
            ListadoDeProductosMostrar.DataSource = null;
            ListadoDeProductosMostrar.DataSource = productoMostrarDtos;


        }

        private async void Agregar_usuarios_Click(object sender, EventArgs e)
        {
            AgregarEditarUsuarios aeuForms = new AgregarEditarUsuarios();

            aeuForms.ShowDialog();

            await CargarTablaDeUsuarios();

        }


        private void Usuarios_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int IdUsuarioSeleccionado = -1;
        private void Usuarios_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdUsuarioSeleccionado = DataGridHelper.ObtenerIdSeleccionado(Usuarios_DataGrid, e);

            if (IdUsuarioSeleccionado != -1)
            {
                MessageBox.Show("ID seleccionado: " + IdUsuarioSeleccionado);
            }
        }

        private async void Eliminar_Usuario_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Quieres Eliminar El Usuario?", "Pregunta sobre agregado", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }

            if (await usuarioControllerC.EliminarUsuarioAsync(IdUsuarioSeleccionado))
            {
                IdUsuarioSeleccionado = -1;
                MessageBox.Show("Usuario eliminado correctamente.");
                await CargarTablaDeUsuarios();
            }
            else
            {
                MessageBox.Show("Error al eliminar el usuario. Verifica el ID seleccionado.");
            }
        }

        public async Task<Usuarios> RegresarUsuario(int id)
        {
            return await usuarioControllerC.TraerUsuarioPorId(id);
        }

        private async void materialButton1_Click(object sender, EventArgs e)
        {

            if (IdUsuarioSeleccionado == -1)
            {
                MessageBox.Show("Por favor seleccione un usuario para editar.");
                return;
            }


            AgregarEditarUsuarios aeuForms = new AgregarEditarUsuarios();

            aeuForms.usuarioActual = await RegresarUsuario(IdUsuarioSeleccionado);

            aeuForms.ShowDialog();

            await CargarTablaDeUsuarios();
        }



        private void BuscarUsuarios_TextChanged(object sender, EventArgs e)
        {


            FindForNameHelper.BuscarPorNombre<UsuarioMostrarDto>(sender, e, Listado_De_usuarios_Mostrar, Usuarios_DataGrid);
        }

        private async void GenerarReportesUsuarios_Click(object sender, EventArgs e)
        {
            ReportesHelperForm reportesHelperForm = new ReportesHelperForm();

            reportesHelperForm.ListadoParaImprimirUsuarios = Listado_De_usuarios_Mostrar;

            reportesHelperForm.ShowDialog();

            await CargarTablaDeUsuarios();
        }

        private void ListadoDeProductosMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void materialButton5_Click(object sender, EventArgs e)
        {
            AgregarEditarProductos aePForms = new AgregarEditarProductos();
            aePForms.productoSeleccioando = null;
            aePForms.ShowDialog();
            await CargarTablaProductos();
        }

        private void GestionDeInventario_Click(object sender, EventArgs e)
        {

        }
        int IdProductoSeleccionado = -1;

        private void ListadoDeProductosMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdProductoSeleccionado = DataGridHelper.ObtenerIdSeleccionado(ListadoDeProductosMostrar, e);

            if (IdProductoSeleccionado != -1)
            {
                MessageBox.Show("ID seleccionado: " + IdProductoSeleccionado);
            }
        }

        private async void materialButton4_Click(object sender, EventArgs e)
        {

            if (IdProductoSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un producto de la tabla");
                return;
            }

            ProductosControllerC productosControllerC = new ProductosControllerC();

            AgregarEditarProductos aePForms = new AgregarEditarProductos();

            aePForms.productoSeleccioando = productosControllerC.TraerUnProductoPorElId(IdProductoSeleccionado);
            aePForms.ShowDialog();

            await CargarTablaProductos();

        }

        private void materialMaskedTextBox1_TextChanged(object sender, EventArgs e)
        {


            FindForNameHelper.BuscarPorNombre<ProductoMostrarDto>(sender, e, productoMostrarDtos, ListadoDeProductosMostrar);
        }


        private async void materialButton3_Click(object sender, EventArgs e)
        {

            if (IdProductoSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un producto primero.");
                return;
            }

            var respuesta = MessageBox.Show("Estas seguro de que quieres eliminar al producto seleccionado?", "Pregunta por eliminacion", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }

            await productoController.EliminarUnProductoPorElId(IdProductoSeleccionado);

            await CargarTablaProductos();
        }

        private async void materialButton2_Click(object sender, EventArgs e)
        {

            ReportesHelperForm reportesHelperForm = new ReportesHelperForm();
            reportesHelperForm.ListadoParaImprimirUsuarios = null;
            reportesHelperForm.ListadoParaImprimirProductos = productoMostrarDtos;

            reportesHelperForm.ShowDialog();

            await CargarTablaDeUsuarios();
        }
        List<ProveedorMostrarDto> listadoDeProveedoresMostrar = new List<ProveedorMostrarDto>();
        ProveedorControllerC ProveedorControllerC_ = new ProveedorControllerC();
        private async Task CargarListaDeProveedores()
        {
            listadoDeProveedoresMostrar.Clear();

            listadoDeProveedoresMostrar = await ProveedorControllerC_.ObtenerTodosLosProveedores();

            ProveedoresListadoShow.DataSource = null;

            ProveedoresListadoShow.DataSource = listadoDeProveedoresMostrar;
        }


        private async void materialButton9_Click(object sender, EventArgs e)
        {
            AgregarEditarProveedor agregarEditarProveedor = new AgregarEditarProveedor();

            agregarEditarProveedor.ShowDialog();

            await CargarListaDeProveedores();

        }


        int IdProveedorSeleccionado = -1;

        private void ProveedoresListadoShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdProveedorSeleccionado = DataGridHelper.ObtenerIdSeleccionado(ProveedoresListadoShow, e);

            if (IdProveedorSeleccionado != -1)
            {
                MessageBox.Show("ID seleccionado: " + IdProveedorSeleccionado);
            }
        }
        ProveedorControllerC proveedorControllerC_ = new ProveedorControllerC();
        private async void materialButton8_Click(object sender, EventArgs e)
        {
            if (IdProveedorSeleccionado == -1)
            {
                MessageBox.Show("Por favor seleccione un proveedor para editar.");
                return;
            }
            AgregarEditarProveedor agregarEditarProveedor = new AgregarEditarProveedor();

            agregarEditarProveedor.proveedorActual = await proveedorControllerC_.TraerUnProveedorAsync(IdProveedorSeleccionado);

            agregarEditarProveedor.ShowDialog();

            await CargarListaDeProveedores();
        }

        private async void materialButton7_Click(object sender, EventArgs e)
        {
            if (IdProveedorSeleccionado == -1)
            {
                MessageBox.Show("Por favor seleccione un proveedor para Eliminar.");
                return;
            }

            var respuesta = MessageBox.Show("Quieres eliminar al proveedor seleccionado?", "Confirmacion de eliminacion", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }

            await proveedorControllerC_.EliminarProovedor(IdProveedorSeleccionado);

            await CargarListaDeProveedores();

        }

        private async void materialButton6_Click(object sender, EventArgs e)
        {
            ReportesHelperForm reportesHelperForm = new ReportesHelperForm();

            reportesHelperForm.ListadoParaImprimirProveedor = listadoDeProveedoresMostrar;

            reportesHelperForm.ShowDialog();

            await CargarListaDeProveedores();
        }

        private void materialMaskedTextBox2_TextChanged(object sender, EventArgs e)
        {


            FindForNameHelper.BuscarPorNombre<ProveedorMostrarDto>(sender, e, listadoDeProveedoresMostrar, ProveedoresListadoShow);
        }

        private async void materialButton10_Click(object sender, EventArgs e)
        {
            MasInformacionProveedor masInformacionProveedor = new MasInformacionProveedor();

            if (IdProveedorSeleccionado == -1)
            {
                MessageBox.Show("Por favor seleccione un proveedor para ver mas informacion.");
                return;
            }

            masInformacionProveedor.proveedorMasinformacion = await proveedorControllerC_.TraerUnProveedorAsync(IdProveedorSeleccionado);


            masInformacionProveedor.ShowDialog();

            await CargarListaDeProveedores();


        }

        private async void materialButton14_Click(object sender, EventArgs e)
        {
            AgregarClienteEspecial agregarClienteEspecial = new AgregarClienteEspecial();
            agregarClienteEspecial.ShowDialog();
            await CargarListadoDeClientesEspeciales();
        }

        int IdClienteEspecialSeleccionado = -1;
        private void ListadoClienteEspecialDg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdClienteEspecialSeleccionado = DataGridHelper.ObtenerIdSeleccionado(ListadoClienteEspecialDg, e);

            if (IdClienteEspecialSeleccionado != -1)
            {
                MessageBox.Show("ID seleccionado: " + IdClienteEspecialSeleccionado);
            }
        }

        ClienteEspecialControllerC ClienteEspecialControllerC = new ClienteEspecialControllerC();

        private async void materialButton13_Click(object sender, EventArgs e)
        {
            if (IdClienteEspecialSeleccionado == -1)
            {
                MessageBox.Show("Necesita seleccionar a un Cliente Especial para editarlo");
                return;
            }

            ClienteEspecialEditar clienteEspecialEditar = new ClienteEspecialEditar();

            clienteEspecialEditar.clienteEspecial = await ClienteEspecialControllerC.TraerClienteEspecialPorIdAsync(IdClienteEspecialSeleccionado);

            clienteEspecialEditar.ShowDialog();

            await CargarListadoDeClientesEspeciales();

        }

        private async void materialButton12_Click(object sender, EventArgs e)
        {
            if (IdClienteEspecialSeleccionado == -1)
            {
                MessageBox.Show("Necesita seleccionar a un Cliente Especial para Eliminarlo");
                return;
            }

            var respuesta = MessageBox.Show("Quieres Eliminar a este cliente especial?", "Pregunta sobre Eliminacion", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }


            var confirmacionEliminacion = await ClienteEspecialControllerC.EliminarClienteEspecialAsync(IdClienteEspecialSeleccionado);

            if (!confirmacionEliminacion)
            {
                MessageBox.Show("Error al eliminar el Cliente especial, trate otra vez");
                return;
            }

            MessageBox.Show("Se ha realizado correctamente la eliminacion!");
            await CargarListadoDeClientesEspeciales();




        }

        private async void materialButton11_Click(object sender, EventArgs e)
        {
            ReportesHelperForm reportesHelperForm = new ReportesHelperForm();

            reportesHelperForm.ListadoParaImprimirClienteEspecial = listadoDeClientesEspecialesMostrar;

            reportesHelperForm.ShowDialog();

            await CargarListadoDeClientesEspeciales();


        }

        private async void Gestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Gestion.SelectedIndex)
            {
                case 0:
                    this.Text = "Gestión de Usuarios";
                    await CargarTablaDeUsuarios();
                    break;

                case 1:
                    this.Text = "Gestión de Productos";
                    await CargarTablaProductos();
                    break;
                case 2:
                    this.Text = "Gestión de Proveedores";
                    await CargarListaDeProveedores();
                    break;
                case 3:
                    this.Text = "Gestión de Clientes Especiales";
                    await CargarListadoDeClientesEspeciales();
                    break;
                case 4:
                    Text = "Gestion de Clientes Normales";
                    await CargarListadoDeClientesNormales();
                    break;

                case 5:
                    Text = "Venta Al Detalle";
                    await CargarTablasVenta();
                    break;
                case 6:
                    Text = "Gestion de Ventas";
                    await CargarListaDeVentas();
                    break;

                case 7:
                    this.Text = "Gestion de adeudos";
                    await CargarAdeudos();
                    break;

                default:
                    Text = string.Empty;
                    break;

            }
        }

        private void NombreDelClienteEspecial_txt_TextChanged(object sender, EventArgs e)
        {

            FindForNameHelper.BuscarPorNombre<ClienteEspecialMostrarDto>(sender, e, listadoDeClientesEspecialesMostrar, ListadoClienteEspecialDg);

        }

        int IdClienteNormalSeleccionado = -1;
        private void ListadoDeClientesNormalesDg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdClienteNormalSeleccionado = DataGridHelper.ObtenerIdSeleccionado(ListadoDeClientesNormalesDg, e);

            if (IdClienteNormalSeleccionado != -1)
            {
                MessageBox.Show("ID seleccionado: " + IdClienteNormalSeleccionado);
            }
        }

        private void materialButton18_Click(object sender, EventArgs e)
        {

        }

        ClienteNormalControllerC ClienteNormalControllerC = new ClienteNormalControllerC();
        private async void materialButton16_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Quieres Eliminar a este cliente?", "Pregunta sobre Eliminacion", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }


            await ClienteNormalControllerC_.EliminarClienteNormalAsync(IdClienteNormalSeleccionado);

            MessageBox.Show("Eliminacion exitosa!!");
        }

        private async void materialButton15_Click(object sender, EventArgs e)
        {
            ReportesHelperForm reportesHelperForm = new ReportesHelperForm();

            reportesHelperForm.ListadoParaImprimirClienteNormal = ListadoClienteNormalMostrarDtos;

            reportesHelperForm.ShowDialog();


            await CargarListadoDeClientesNormales();


        }

        private void materialMaskedTextBox3_TextChanged(object sender, EventArgs e)
        {
            FindForNameHelper.BuscarPorNombre<ClienteNormalMostrarDto>(sender, e, ListadoClienteNormalMostrarDtos, ListadoDeClientesNormalesDg);
        }

        private void materialCard7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GestionUsers_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GestionDeProveedores_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }

        private void materialCard3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProveedoresListadoShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GestionDeClientesEspeciales_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void materialCard4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListadoClienteEspecialDg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GestionDeClientesNormales_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel9_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel10_Click(object sender, EventArgs e)
        {

        }

        private void materialCard5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListadoDeClientesNormalesDg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BuscarUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void materialMaskedTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialMaskedTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void NombreDelClienteEspecial_txt_Click(object sender, EventArgs e)
        {

        }

        private void materialMaskedTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void materialCard6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void CarritoDecompras_dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialLabel11_Click(object sender, EventArgs e)
        {

        }

        private void ListadoDeProductosDisponibles_dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialLabel12_Click(object sender, EventArgs e)
        {

        }

        private void usuarioMostrarDtoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void proveedorBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void productoMostrarDtoBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void productoMostrarDtoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void proveedorBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
        int ProductoAComprarVenta = -1;
        ProductoVentasMostrarDto productoSeleccionado = new ProductoVentasMostrarDto();


        private async void ListadoDeProductosDisponibles_dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductoAComprarVenta = DataGridHelper.ObtenerIdSeleccionado(ListadoDeProductosDisponibles_dg, e);

            if (ProductoAComprarVenta == -1)
            {
                MessageBox.Show("Error al seleccionar Producto");
                return;
            }

            productoSeleccionado = listadoProductosDisponiblesVenta.FirstOrDefault(x => x.Id == ProductoAComprarVenta);
            CargarProductoVentaEnCombos(productoSeleccionado);

            numCantidadProducto.Value = 1;

            numCantidadProducto.Maximum = productoSeleccionado.Stock;

            numCantidadProducto.Minimum = 1;


        }


        private void CargarProductoVentaEnCombos(ProductoVentasMostrarDto cargar)
        {
            Codigo_Del_Producto_txt.Text = cargar.CodigoDelProducto;
            Nombre_Del_Producto_txt.Text = cargar.Nombre;
            UnidadDeMedidaDelProducto.Text = cargar.unidadMedida.ToString();
            PrecioPorUnidadDelProducto_txt.Text = cargar.Precio.ToString();
        }
        Ventas ventaActualAlDetalle = new Ventas();
        CompraEntity compraActuial = new CompraEntity();
        private async void materialButton18_Click_1(object sender, EventArgs e)
        {

            if (numCantidadProducto.Value == 0)
            {
                MessageBox.Show("No hay una cantidad");
                return;
            }

            if (ProductoAComprarVenta == -1)
            {
                var producto = await productoController.TraerProductoPorElCodigo_(Codigo_Del_Producto_txt.Text.Trim());
                CompraEntity compraAMappear = RegresarCompraCreada(producto);
                AgregarProductoAlCarrito(compraAMappear);
                return;
            }

            AgregarProductoAlCarrito(RegresarCompraCreada());


        }

        private void AgregarProductoAlCarrito(CompraEntity compraEntity)
        {

            CarritoDeCompras.Add(CompraMapper.MapCompraToCarrito(compraEntity));


            CarritoDecompras_dg.DataSource = null;

            CarritoDecompras_dg.DataSource = CarritoDeCompras;

            TotalDelCarrito.Text = Convert.ToString(CarritoDeCompras.Sum(x => x.TotalProducto));

        }

        private CompraEntity RegresarCompraCreada()
        {
            Producto producto = productoController.TraerUnProductoPorElId(ProductoAComprarVenta);
            CompraEntity compraActuial = new CompraEntity();
            //compraActuial.Id = ProductoAComprarVenta;
            compraActuial.CantidadDelProducto = Convert.ToInt32(numCantidadProducto.Value);
            compraActuial.IdProducto = ProductoAComprarVenta;
            compraActuial.ListaDeproductos = producto == null ? null : producto;
            compraActuial.PrecioUnitario = producto.PrecioVenta;

            return compraActuial;
        }

        private CompraEntity RegresarCompraCreada(Producto producto)
        {
            CompraEntity compraActuial = new CompraEntity();
            //compraActuial.Id = ProductoAComprarVenta;
            compraActuial.CantidadDelProducto = Convert.ToInt32(numCantidadProducto.Value);
            compraActuial.IdProducto = producto.Id;
            compraActuial.ListaDeproductos = producto;
            compraActuial.PrecioUnitario = producto.PrecioVenta;


            return compraActuial;
        }

        private int ProductosDelCarritoInt = 0;


        private void CarritoDecompras_dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarritoDecompras_dg_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void materialButton19_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Estas seguro de eliminar", "Quieres Eliminar El ultimo producto agregado al carrito?", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }

            var carritoProductoAEliminar = CarritoDeCompras.Last();

            CarritoDeCompras.Remove(carritoProductoAEliminar);

            CarritoDecompras_dg.DataSource = null;

            CarritoDecompras_dg.DataSource = CarritoDeCompras;
        }

        private async void CargarProductoPorCodigo(string codigoProducto)

        {

            CargarProductoVentaEnCombos(await productoController.TraerProductoPorElCodigo(codigoProducto));
        }


        private void Codigo_Del_Producto_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string codigo = Codigo_Del_Producto_txt.Text.Trim();

                Codigo_Del_Producto_txt.Text = codigo;


                CargarProductoPorCodigo(codigo);

                //MessageBox.Show($"Codigo Escaneado {codigo} \n ");

                e.Handled = true;
                e.SuppressKeyPress = true;


            }
        }


        public List<CompraEntity> RegresarUnaListaDeComprasEntity(List<CarritoCompraDto> carrito)
        {
            var lista = new List<CompraEntity>();

            foreach (var item in carrito)
            {
                var compra = CompraMapper.MapCarritoToCompra(item);
                lista.Add(compra);
            }

            return lista;
        }

        public bool ConfirmarCompra(Ventas ventas)
        {
            VentaResumenForms ventaResumenForms = new VentaResumenForms();

            ventaResumenForms.VentaActual = ventas;

            ventaResumenForms.ShowDialog();

            if (ventaResumenForms.Confirmacion != true)
            {
                MessageBox.Show("Compra Cancelada.");
                return false;
            }

            //ventas.IdCliente = ventaResumenForms.
            return true;
        }

        public bool ConfirmarCompraCredito(Ventas ventas)
        {
            ClienteEspecialSeleccionarParaVentaACredito ventaResumenForms = new ClienteEspecialSeleccionarParaVentaACredito(ventas);

            ventaResumenForms.ShowDialog();

            if (ventaResumenForms.Confirmacion != true)
            {
                MessageBox.Show("Compra Cancelada.");
                return false;
            }

            ventas.IdCliente = ventaResumenForms.ClienteEspecialSeleccionado.Id;
            ventas.Pago = TipoDePago.PagoConCredito;


            return true;
        }


        private async void materialButton20_Click(object sender, EventArgs e)
        {

            var respuesta = MessageBox.Show("Estas aseguro de realizar esta venta?", "Confirmar Venta", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }
            // 1. Convertir el carrito a entidades
            ventaActualAlDetalle.ListadoDeCompras = RegresarUnaListaDeComprasEntity(CarritoDeCompras);

            // 2. Validaciones
            if (ventaActualAlDetalle.ListadoDeCompras == null ||
                ventaActualAlDetalle.ListadoDeCompras.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.");
                return;
            }

            // 3. Configurar datos iniciales
            ventaActualAlDetalle.Descuento = decimal.Parse(Descuento_txt.Text) >= 0 ? decimal.Parse(Descuento_txt.Text) : 0;
            //ventaActualAlDetalle.IdCliente = 0;
            ventaActualAlDetalle.Tipo_De_Venta = Modules.Enums.TipoDeVenta.VentaAlDetalle;

            // 4. Calcular totales UNA sola vez ANTES de guardar
            ventaActualAlDetalle.TotalEntero = ventaActualAlDetalle.CalcularTotalEntero();
            ventaActualAlDetalle.MontoDescontado = ventaActualAlDetalle.CaluclarMontoDescontado();
            ventaActualAlDetalle.TotalConElDescuento = ventaActualAlDetalle.CalcularTotalConElDescuento();
            ventaActualAlDetalle.FechaCreacion = DateTime.Now;

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                try
                {
                    if (ConfirmarCompra(ventaActualAlDetalle) == false)
                    {

                        return;
                    }
                    RestarStock(RegresarUnaListaDeComprasEntity(CarritoDeCompras));
                    // Guardar todo en un solo SaveChanges
                    context.Ventas.Add(ventaActualAlDetalle);
                    await context.SaveChangesAsync();

                    // naqui va
                    ImprimirReciboDeVenta(CarritoDeCompras);
                    MessageBox.Show("Compra efectuada con éxito!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al guardar la venta \n" + ex.Message);
                }
            }



            ventaActualAlDetalle = null;



            await CargarTablasVenta();
        }

        public void ImprimirReciboDeVenta(List<CarritoCompraDto> carritoList)
        {
            ImpresionRecibo recibo = new ImpresionRecibo(carritoList);
            recibo.Imprimir();
        }

        private void RestarStock(List<CompraEntity> listado)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                for (int i = 0; i < listado.Count; i++)
                {
                    var producto = context.Productos.FirstOrDefault(x => x.Id == listado[i].IdProducto);
                    if (producto == null) { continue; }

                    producto.Cantidad -= listado[i].CantidadDelProducto;

                    context.Productos.Update(producto);
                    context.SaveChanges();

                }

            }
        }

        private async void materialButton17_Click(object sender, EventArgs e)
        {
            ventaActualAlDetalle = null;



            await CargarTablasVenta();
        }

        int ventaSeleccionada = -1;

        List<Ventas> lisatdoDeVentas = new List<Ventas>();


        private async Task CargarListaDeVentas()
        {
            lisatdoDeVentas.Clear();
            dataGridView1.DataSource = null;
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                lisatdoDeVentas = await context.Ventas.ToListAsync();
            }
            dataGridView1.DataSource = lisatdoDeVentas;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ventaSeleccionada = DataGridHelper.ObtenerIdSeleccionado(dataGridView1, e);

            if (ventaSeleccionada == -1)
            {
                MessageBox.Show("No se logro seleccionar");
                return;
            }
        }

        private async void materialButton22_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Queres Eliminar Esta venta?", "Pregunta Sobre Eliminbacion", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var VentaAEliminar = await context.Ventas.FirstOrDefaultAsync(x => x.Id == ventaSeleccionada);

                context.Ventas.Remove(VentaAEliminar);

                await context.SaveChangesAsync();

                MessageBox.Show("venta Eliminada con exito");

                await CargarListaDeVentas();

                return;
            }
        }

        private void materialButton21_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Quieres Entrar a la seccion de reportes ?", "Pregunta sobre Generacion de reportes", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }
            ReportesHelperForm reportesHelperForm = new ReportesHelperForm();

            reportesHelperForm.ListadoParaImprimirVentas = lisatdoDeVentas;

            reportesHelperForm.ShowDialog();


        }
        int IdAdeudoSeleccionado = -1;
        private void ListadoDeAdeudos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdAdeudoSeleccionado = DataGridHelper.ObtenerIdSeleccionado(ListadoDeAdeudos, e);

            if (IdAdeudoSeleccionado != -1)
            {
                MessageBox.Show("ID seleccionado: " + IdAdeudoSeleccionado);
            }
        }

        private async void materialButton24_Click(object sender, EventArgs e)
        {

            var respuesta = MessageBox.Show("Queres Eliminar El adeudo?", "PREGUNTA SOBRE ELIMINACION", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }
            var confirmacion = await AdeudocontrollerC_.EliminarAdeudoAsync(IdAdeudoSeleccionado);

            if (confirmacion)
            {
                MessageBox.Show("Adeudo Eliminado");

                await CargarAdeudos();

                return;
            }

            if (!confirmacion)
            {
                MessageBox.Show("No de logro eliminar el adeudo");
                return;
            }
        }

        private void GestionDeAdeudos_Click(object sender, EventArgs e)
        {

        }

        private async void materialButton26_Click(object sender, EventArgs e)
        {

            if (IdAdeudoSeleccionado < 0)
            {
                MessageBox.Show("Selecciona un adeudo primero");
                return;
            }
            var respuesta = MessageBox.Show("Quieres agregar un abono a un adeudo?", "Pregunta sobre agregado", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }
            AdeudoMostrarDto adeudoSeleccionado = new AdeudoMostrarDto();

            adeudoSeleccionado = ListaDeAdeudos.FirstOrDefault(x => x.Id == IdAdeudoSeleccionado);

            if (adeudoSeleccionado == null)
            {
                return;
            }

            AgregarMontoAlADeudo agregarMontoAlADeudo = new AgregarMontoAlADeudo();


            agregarMontoAlADeudo.adeudoActual = adeudoSeleccionado;

            agregarMontoAlADeudo.ShowDialog();

            await CargarAdeudos();


        }

        private void materialMaskedTextBox4_TextChanged(object sender, EventArgs e)
        {
            FindForNameHelper.BuscarPorNombre<AdeudoMostrarDto>(sender, e, ListaDeAdeudos, ListadoDeAdeudos);
        }

        private async void materialButton25_Click(object sender, EventArgs e)
        {

            var respuesta = MessageBox.Show("Estas aseguro de realizar esta venta?", "Confirmar Venta", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }
            // 1. Convertir el carrito a entidades
            ventaActualAlDetalle.ListadoDeCompras = RegresarUnaListaDeComprasEntity(CarritoDeCompras);

            // 2. Validaciones
            if (ventaActualAlDetalle.ListadoDeCompras == null ||
                ventaActualAlDetalle.ListadoDeCompras.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.");
                return;
            }

            // 3. Configurar datos iniciales
            ventaActualAlDetalle.Descuento = decimal.Parse(Descuento_txt.Text) >= 0 ? decimal.Parse(Descuento_txt.Text) : 0;
            ventaActualAlDetalle.Tipo_De_Venta = Modules.Enums.TipoDeVenta.VentaAlDetalle;

            // 4. Calcular totales UNA sola vez ANTES de guardar
            ventaActualAlDetalle.TotalEntero = ventaActualAlDetalle.CalcularTotalEntero();
            ventaActualAlDetalle.MontoDescontado = ventaActualAlDetalle.CaluclarMontoDescontado();
            ventaActualAlDetalle.TotalConElDescuento = ventaActualAlDetalle.CalcularTotalConElDescuento();
            ventaActualAlDetalle.FechaCreacion = DateTime.Now;

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                try
                {
                    if (ConfirmarCompraCredito(ventaActualAlDetalle) == false)
                    {
                        return;
                    }
                    //ventaActualAlDetalle.IdCliente = 0;

                    RestarStock(RegresarUnaListaDeComprasEntity(CarritoDeCompras));
                    // Guardar todo en un solo SaveChanges
                    context.Ventas.Add(ventaActualAlDetalle);

                    await context.SaveChangesAsync();

                    ImprimirReciboDeVenta(CarritoDeCompras);

                    MessageBox.Show("Compra efectuada con éxito!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al guardar la venta \n" + ex.Message);
                }
            }



            ventaActualAlDetalle = null;



            await CargarTablasVenta();
        }

        private async void Usuarios_DataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            await CargarTablaDeUsuarios();
        }
    }
}
