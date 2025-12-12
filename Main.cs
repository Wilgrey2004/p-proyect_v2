using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using p_proyect.Controller.AdeudoController;
using p_proyect.Controller.ClienteEspecialController;
using p_proyect.Controller.ClienteNormalController;
using p_proyect.Controller.NFCController;
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
using p_proyect.Modules.Entidades.Formularios.CompraForms;
using p_proyect.Modules.Entidades.Formularios.ProductosForms;
using p_proyect.Modules.Entidades.Formularios.ProveedorForms;
using p_proyect.Modules.Entidades.Formularios.UsuarioForms;
using p_proyect.Modules.Entidades.Formularios.VentaForms;
using p_proyect.Modules.Enums;
using p_proyect.Utils;
using p_proyect.Utils.Reportes;
using p_proyect.Utils.Rnc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_proyect
{
    public partial class Main : MaterialForm
    {
        Timer inactividadTimer = new Timer();
        int tiempoInactivo = 0;
        public Usuarios SecionActual = new Usuarios();
        private ProductosControllerC productosControllerC = new ProductosControllerC();
        private List<ProductoMostrarDto> productoMostrarDtos = new List<ProductoMostrarDto>();
        ProductosControllerC productoController = new ProductosControllerC();
        public Main()
        {
            InitializeComponent();

            inactividadTimer.Interval = 1000; // 1 segundo
            inactividadTimer.Tick += InactividadTimer_Tick;
            inactividadTimer.Start();

            // Eventos para detectar actividad
            this.MouseMove += ResetearInactividad;
            this.KeyPress += ResetearInactividad;
            this.MouseClick += ResetearInactividad;

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

        private void ResetearInactividad(object sender, EventArgs e)
        {
            tiempoInactivo = 0;
        }
        private void PausaTimer(object sender, EventArgs e)
        {
            inactividadTimer.Stop();
        }

        private void ReanudarTimer(object sender, EventArgs e)
        {
            tiempoInactivo = 0;
            inactividadTimer.Start();
        }




        private void InactividadTimer_Tick(object sender, EventArgs e)
        {
            tiempoInactivo++;

            // 60 segundos sin actividad
            if (tiempoInactivo >= 180)
            {
                inactividadTimer.Stop();
                MessageBox.Show("Sesión cerrada por inactividad.");

                // Aquí cierras sesión o rediriges al login
                SecionActual = null;
                Close();


            }
        }



        private async void RemoverSegunUsuario(Usuarios SecionActual)
        {
            // Mensaje para roles inválidos
            if (SecionActual.Rol == UserRole.None)
            {
                MessageBox.Show($"Este usuario no contiene un rol válido: {SecionActual.Nombre}", "Error!");
                Close();
                return;
            }

            switch (SecionActual.Rol)
            {
                case UserRole.Administrador:
                    //MessageBox.Show($"Bienvenido {SecionActual.Nombre}", "Saludo!");
                    break;

                case UserRole.GestorDeInventario:
                    RemoverPestanas(
                        GestionDeClientesEspeciales,  // comentado según tu estructura actual
                        GestionDeClientesNormales,
                        GestionVentaAlDetalle,
                        GestionUsers,
                        GestionDeProveedores,
                        //GestionDeInventario,
                        GestionDeClientesEspeciales,
                        GestionDeventas,
                        GestionDeCompras,
                        GestionDeAdeudos,
                        GestionAjustes
                    );
                    break;

                case UserRole.GestorDeCaja:
                    RemoverPestanas(
                        GestionDeClientesEspeciales,  // comentado según tu estructura actual
                        GestionDeClientesNormales,
                        GestionVentaAlDetalle,
                        GestionUsers,
                        GestionDeProveedores,
                        GestionDeInventario,
                        GestionDeClientesEspeciales,
                        GestionDeventas,
                        GestionDeCompras,
                        GestionDeAdeudos,
                        GestionAjustes
                    );
                    break;

                case UserRole.Vendedor:
                    RemoverPestanas(
                        GestionDeClientesEspeciales,  // comentado según tu estructura actual
                        GestionDeClientesNormales,
                        // GestionVentaAlDetalle,
                        GestionUsers,
                        GestionDeProveedores,
                        GestionDeInventario,
                        GestionDeClientesEspeciales,
                        GestionDeventas,
                        GestionDeCompras,
                        GestionAjustes

                    );
                    break;

                case UserRole.Empleado:

                    RemoverPestanas(GestionUsers, GestionAjustes);
                    break;
            }

            await CargarListaDeNotificaciones();
        }

        private void RemoverPestanas(params TabPage[] paginas)
        {
            foreach (var page in paginas)
            {
                if (Gestion.TabPages.Contains(page))
                {
                    Gestion.TabPages.Remove(page);
                }
            }
        }

        UsuarioControllerC usuarioControllerC = new UsuarioControllerC();
        List<UsuarioMostrarDto> Listado_De_usuarios_Mostrar = new List<UsuarioMostrarDto>();
        // List<Usuarios> Listado_De_usuarios_Original = new List<Usuarios>();
        private async void Main_Load(object sender, EventArgs e)
        {

            RemoverSegunUsuario(SecionActual);

            if (SecionActual.Rol == UserRole.Administrador)
            {
                await CargarTablaDeUsuarios();
                return;
            }

            if (SecionActual.Rol == UserRole.GestorDeInventario)
            {
                await CargarTablaProductos();
                return;
            }

            if (SecionActual.Rol == UserRole.Vendedor)
            {
                await CargarTablasVenta();
                return;
            }

            if (SecionActual.Rol == UserRole.Empleado)
            {
                await CargarTablaDeUsuarios();
                return;
            }

            if(SecionActual.Rol == UserRole.GestorDeCaja)
            {
                await CargarListaDeNotificaciones();
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
            PrecioPorUnidadDelProducto_txt_1.Text = string.Empty;
            numCantidadProducto.Value = 1;
            ProductoAComprarVenta = -1;
            TotalDelCarrito.Text = "0.00";
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
            PausaTimer(sender, e);
            AgregarEditarUsuarios aeuForms = new AgregarEditarUsuarios();

            aeuForms.ShowDialog();

            await CargarTablaDeUsuarios();
            ReanudarTimer(sender, e);

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
            PausaTimer(sender, e);
            if (IdUsuarioSeleccionado == -1)
            {
                MessageBox.Show("Por favor seleccione un usuario para editar.");
                ReanudarTimer(sender, e);
                return;
            }


            AgregarEditarUsuarios aeuForms = new AgregarEditarUsuarios();

            aeuForms.usuarioActual = await RegresarUsuario(IdUsuarioSeleccionado);

            aeuForms.ShowDialog();

            await CargarTablaDeUsuarios();
            ReanudarTimer(sender, e);
        }



        private void BuscarUsuarios_TextChanged(object sender, EventArgs e)
        {


            FindForNameHelper.BuscarPorNombre<UsuarioMostrarDto>(sender, e, Listado_De_usuarios_Mostrar, Usuarios_DataGrid);
        }

        private async void GenerarReportesUsuarios_Click(object sender, EventArgs e)
        {
            PausaTimer(sender, e);
            ReportesHelperForm reportesHelperForm = new ReportesHelperForm();

            reportesHelperForm.ListadoParaImprimirUsuarios = Listado_De_usuarios_Mostrar;

            reportesHelperForm.ShowDialog();

            await CargarTablaDeUsuarios();
            ReanudarTimer(sender, e);
        }

        private void ListadoDeProductosMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void materialButton5_Click(object sender, EventArgs e)
        {
            PausaTimer(sender, e);
            AgregarEditarProductos aePForms = new AgregarEditarProductos();
            aePForms.productoSeleccioando = null;
            aePForms.ShowDialog();
            await CargarTablaProductos();

            ReanudarTimer(sender, e);
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
            PausaTimer(sender, e);
            if (IdProductoSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un producto de la tabla");
                ReanudarTimer(sender, e);
                return;
            }

            ProductosControllerC productosControllerC = new ProductosControllerC();

            AgregarEditarProductos aePForms = new AgregarEditarProductos();

            aePForms.productoSeleccioando = productosControllerC.TraerUnProductoPorElId(IdProductoSeleccionado);
            aePForms.ShowDialog();

            await CargarTablaProductos();
            ReanudarTimer(sender, e);

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
            PausaTimer(sender, e);
            ReportesHelperForm reportesHelperForm = new ReportesHelperForm();
            reportesHelperForm.ListadoParaImprimirUsuarios = null;
            reportesHelperForm.ListadoParaImprimirProductos = productoMostrarDtos;

            reportesHelperForm.ShowDialog();

            await CargarTablaDeUsuarios();
            ReanudarTimer(sender, e);
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
            PausaTimer(sender, e);
            AgregarEditarProveedor agregarEditarProveedor = new AgregarEditarProveedor();

            agregarEditarProveedor.ShowDialog();

            await CargarListaDeProveedores();
            ReanudarTimer(sender, e);

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
            PausaTimer(sender, e);
            if (IdProveedorSeleccionado == -1)
            {
                MessageBox.Show("Por favor seleccione un proveedor para editar.");
                ReanudarTimer(sender, e);
                return;
            }
            AgregarEditarProveedor agregarEditarProveedor = new AgregarEditarProveedor();

            agregarEditarProveedor.proveedorActual = await proveedorControllerC_.TraerUnProveedorAsync(IdProveedorSeleccionado);

            agregarEditarProveedor.ShowDialog();

            await CargarListaDeProveedores();
            ReanudarTimer(sender, e);
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
            PausaTimer(sender, e);
            ReportesHelperForm reportesHelperForm = new ReportesHelperForm();

            reportesHelperForm.ListadoParaImprimirProveedor = listadoDeProveedoresMostrar;

            reportesHelperForm.ShowDialog();

            await CargarListaDeProveedores();
            ReanudarTimer(sender, e);
        }

        private void materialMaskedTextBox2_TextChanged(object sender, EventArgs e)
        {


            FindForNameHelper.BuscarPorNombre<ProveedorMostrarDto>(sender, e, listadoDeProveedoresMostrar, ProveedoresListadoShow);
        }

        private async void materialButton10_Click(object sender, EventArgs e)
        {
            MasInformacionProveedor masInformacionProveedor = new MasInformacionProveedor();
            PausaTimer(sender, e);
            if (IdProveedorSeleccionado == -1)
            {
                MessageBox.Show("Por favor seleccione un proveedor para ver mas informacion.");
                ReanudarTimer(sender, e);
                return;
            }

            masInformacionProveedor.proveedorMasinformacion = await proveedorControllerC_.TraerUnProveedorAsync(IdProveedorSeleccionado);


            masInformacionProveedor.ShowDialog();

            await CargarListaDeProveedores();
            PausaTimer(sender, e);


        }

        private async void materialButton14_Click(object sender, EventArgs e)
        {
            PausaTimer(sender, e);
            AgregarClienteEspecial agregarClienteEspecial = new AgregarClienteEspecial();
            agregarClienteEspecial.ShowDialog();
            await CargarListadoDeClientesEspeciales();
            ReanudarTimer(sender, e);
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
            PausaTimer(sender, e);
            if (IdClienteEspecialSeleccionado == -1)
            {
                MessageBox.Show("Necesita seleccionar a un Cliente Especial para editarlo");
                ReanudarTimer(sender, e);
                return;
            }

            ClienteEspecialEditar clienteEspecialEditar = new ClienteEspecialEditar();

            clienteEspecialEditar.clienteEspecial = await ClienteEspecialControllerC.TraerClienteEspecialPorIdAsync(IdClienteEspecialSeleccionado);

            clienteEspecialEditar.ShowDialog();

            await CargarListadoDeClientesEspeciales();
            ReanudarTimer(sender, e);

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
            PausaTimer(sender, e);

            ReportesHelperForm reportesHelperForm = new ReportesHelperForm();

            reportesHelperForm.ListadoParaImprimirClienteEspecial = listadoDeClientesEspecialesMostrar;

            reportesHelperForm.ShowDialog();

            await CargarListadoDeClientesEspeciales();

            ReanudarTimer(sender, e);

        }

        private async void CargarTablaSegunIndice_Admin()
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
                case 8:
                    Text = "Lista de compras";
                    await CargarListaDeCompras();
                    break;
                case 9:
                    Text = "Perfil";
                    CargarInformacionDelUsuario();
                    break;
                case 11:
                    Text = "Caja";
                    //MessageBox.Show("Bienvenido a caja");
                    await CargarListaDeNotificaciones();
                    break;
                default:
                    Text = string.Empty;
                    break;
            }
        }

        private async void CargarTablaSegunIndice_Empleado()
        {
            switch (Gestion.SelectedIndex)
            {

                case 0:
                    this.Text = "Gestión de Productos";
                    await CargarTablaProductos();
                    break;
                case 1:
                    this.Text = "Gestión de Proveedores";
                    await CargarListaDeProveedores();
                    break;
                case 2:
                    this.Text = "Gestión de Clientes Especiales";
                    await CargarListadoDeClientesEspeciales();
                    break;
                case 3:
                    Text = "Gestion de Clientes Normales";
                    await CargarListadoDeClientesNormales();
                    break;

                case 4:
                    Text = "Venta Al Detalle";
                    await CargarTablasVenta();
                    break;
                case 5:
                    Text = "Gestion de Ventas";
                    await CargarListaDeVentas();
                    break;

                case 6:
                    this.Text = "Gestion de adeudos";
                    await CargarAdeudos();
                    break;
                case 7:
                    Text = "Lista de compras";
                    await CargarListaDeCompras();
                    break;
                case 8:
                    Text = "Perfil";
                    CargarInformacionDelUsuario();
                    break;
                case 10:
                    Text = "Caja";
                    await CargarListaDeNotificaciones();
                    break;

                default:
                    Text = string.Empty;
                    break;

            }
        }
        private void Gestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SecionActual.Rol)
            {
                case UserRole.Administrador:
                    CargarTablaSegunIndice_Admin();
                    break;
                case UserRole.GestorDeInventario:
                    CargarTablaSegunIndice_Inventario();
                    break;
                case UserRole.Vendedor:
                    CargarTablaSegunIndice_Vendedor();
                    break;

                case UserRole.Empleado:
                    CargarTablaSegunIndice_Empleado();
                    break;
                case UserRole.GestorDeCaja:
                    CargarTablaSegunIndice_Caja();
                    break;

            }

        }
        private async void CargarTablaSegunIndice_Inventario()
        {
            switch (Gestion.SelectedIndex)
            {
                case 0:
                    Text = "Gestion de Productos";
                    await CargarTablaProductos();
                    break;
                case 1:
                    Text = "Perfil";
                    CargarInformacionDelUsuario();
                    break;
            }
        }
        private async void CargarTablaSegunIndice_Caja()
        {
            switch (Gestion.SelectedIndex)
            {
                case 0:
                    Text = "Perfil";
                    CargarInformacionDelUsuario();
                    break;
                case 1:

                    Text = "Caja";
                    await CargarListaDeNotificaciones();
                    break;

               
            }
        }
        private async void CargarTablaSegunIndice_Vendedor()
        {
            switch (Gestion.SelectedIndex)
            {
                case 0:
                    Text = "Gestion de Ventas";
                    await CargarTablasVenta();
                    break;

                case 1:
                    Text = "Gestion de Adeudos";
                    await CargarAdeudos();
                    break;
                case 2:
                    Text = "Perfil";
                    CargarInformacionDelUsuario();
                    break;
            }
        }
        List<ProductoMostrarDto> ListadoDeProductosAgotados = new List<ProductoMostrarDto>();
        private async Task CargarListaDeCompras()
        {
            ListadoDeProductosAgotados.Clear();

            ListadoDeProductosAgotados = await productoController.ObtenerProductosParaListaDeProductos();

            ListaDeCompras.DataSource = null;

            ListaDeCompras.DataSource = ListadoDeProductosAgotados;


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
            PausaTimer(sender, e);
            ReportesHelperForm reportesHelperForm = new ReportesHelperForm();

            reportesHelperForm.ListadoParaImprimirClienteNormal = ListadoClienteNormalMostrarDtos;

            reportesHelperForm.ShowDialog();


            await CargarListadoDeClientesNormales();
            ReanudarTimer(sender, e);

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


        private void ListadoDeProductosDisponibles_dg_CellClick(object sender, DataGridViewCellEventArgs e)
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

            ListadoDeProductosDisponibles_dg.Visible = false;


        }


        private void CargarProductoVentaEnCombos(ProductoVentasMostrarDto cargar)
        {
            if (cargar == null)
            {
                MessageBox.Show("Producto no encontrado");
                return;
            }
            Codigo_Del_Producto_txt.Text = cargar.CodigoBarra;
            Nombre_Del_Producto_txt.Text = cargar.Nombre;
            UnidadDeMedidaDelProducto.Text = cargar.unidadMedida.ToString();
            PrecioPorUnidadDelProducto_txt_1.Text = cargar.Precio.ToString();
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

                producto.PrecioVenta = decimal.Parse(PrecioPorUnidadDelProducto_txt_1.Text);

                CompraEntity compraAMappear = RegresarCompraCreada(producto);
                AgregarProductoAlCarrito(compraAMappear, decimal.Parse(PrecioPorUnidadDelProducto_txt_1.Text));
                return;
            }

            AgregarProductoAlCarrito(RegresarCompraCreada(),decimal.Parse(PrecioPorUnidadDelProducto_txt_1.Text));


        }

        private void AgregarProductoAlCarrito(CompraEntity compraEntity, decimal Precio)
        {
            compraEntity.PrecioUnitario = Precio;

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
            compraActuial.PrecioUnitario = decimal.Parse(PrecioPorUnidadDelProducto_txt_1.Text);

            return compraActuial;
        }

        Ventas UltimaVenta = new Ventas();

        private CompraEntity RegresarCompraCreada(Producto producto)
        {


            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                UltimaVenta = context.Ventas
                   .OrderByDescending(c => c.Id)
                   .FirstOrDefault();
            }


            CompraEntity compraActuial = new CompraEntity();

            //compraActuial.Id = ProductoAComprarVenta;
            compraActuial.CantidadDelProducto = Convert.ToInt32(numCantidadProducto.Value);
            compraActuial.IdProducto = producto.Id;

            compraActuial.ListaDeproductos = producto;
            compraActuial.PrecioUnitario = decimal.Parse(PrecioPorUnidadDelProducto_txt_1.Text);
            compraActuial.IdVenta = UltimaVenta.Id + 1;


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


            CarritoCompraDto carro_restar = new CarritoCompraDto("Restar");
            carro_restar.RestarUnoAlContador();

            if (CarritoDeCompras.Count == 0)
            {
                CarritoCompraDto carro = new CarritoCompraDto("Reiniciar");
                carro.ReiniciarContador();
                return;
            }




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
            try
            {
                if (carrito == null || carrito.Count == 0)
                {
                    MessageBox.Show("El carrito está vacío.");
                    return null;
                }

                var lista = new List<CompraEntity>();

                foreach (var item in carrito)
                {
                    var compra = CompraMapper.MapCarritoToCompra(item);
                    lista.Add(compra);
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al mapear el carrito a la lista de compras: " + ex.Message);

            }


        }

        public List<CarritoCompraDto> RegresarUnaListDeCarritoDto(List<CompraEntity> listado)
        {
            try
            {
                if (listado == null || listado.Count == 0)
                {
                    MessageBox.Show("La lista de compras está vacía.");
                    return null;
                }
                var lista = new List<CarritoCompraDto>();
                foreach (var item in listado)
                {
                    var carrito = CompraMapper.MapCompraToCarrito(item);
                    lista.Add(carrito);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mapear la lista de compras al carrito: " + ex.Message);
            }

        }

        public bool ConfirmarCompra(Ventas ventas)
        {
            if (ventas == null)
            {
                MessageBox.Show("Error: La venta no puede ser nula.");
                return false;
            }

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

        private bool ELCarritoEstaVacio(List<CarritoCompraDto> carrito)
        {
            if (carrito == null ||
              carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.");
                return false;
            }

            return true;
        }


        private void CargarRncALaventa(Ventas venta, RncLookupResult infoRnc)
        {
            RNCFormHelper rNCFormHelper = new RNCFormHelper();

            rNCFormHelper.ShowDialog();

            infoRnc = rNCFormHelper.InfoRnc;


            if (infoRnc == null)
            {
                MessageBox.Show("No se pudo obtener la información del RNC.");
                venta.RNC = "000000000";
                return;
            }

            venta.RNC = infoRnc.Rnc;

        }


        private async void CrearVenta(Ventas venta, List<CarritoCompraDto> carrito)
        {

            try
            {
                venta.ListadoDeCompras = RegresarUnaListaDeComprasEntity(carrito);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
                return;
            }

            venta.Descuento = decimal.Parse(Descuento_txt.Text) >= 0 ? decimal.Parse(Descuento_txt.Text) : 0;
            venta.Tipo_De_Venta = Modules.Enums.TipoDeVenta.VentaAlDetalle;
            venta.TotalEntero = ventaActualAlDetalle.CalcularTotalEntero();
            venta.MontoDescontado = ventaActualAlDetalle.CaluclarMontoDescontado();
            venta.TotalConElDescuento = ventaActualAlDetalle.CalcularTotalConElDescuento();
            venta.FechaCreacion = DateTime.Now;
            //venta.NFC = await new NFCController_().TraerparaImprimirNFC();
        }
        RncLookupResult InfoRnc = new RncLookupResult();
        string RNCNoValido = "000000000";

        private async void materialButton20_Click(object sender, EventArgs e)
        {


            PausaTimer(sender, e);

            if (!ELCarritoEstaVacio(CarritoDeCompras))
                return;


            if (MessagesHelpers.MensajeDeConfirmacion("¿El cliente quiere comprobante fiscal?", "Comprobante Fiscal", MessageBoxIcon.Question))
            {
                RNCFormHelper rNCFormHelper = new RNCFormHelper();
                NFCController_ nFCController_ = new NFCController_();
                rNCFormHelper.ShowDialog();

                InfoRnc = rNCFormHelper.InfoRnc;


                if (InfoRnc == null)
                {
                    MessageBox.Show("No se pudo obtener la información del RNC.");
                    ventaActualAlDetalle.RNC = RNCNoValido;
                    ventaActualAlDetalle.NFC = "No aplica";
                    return;
                }

                ventaActualAlDetalle.RNC = InfoRnc.Rnc;
                // ventaActualAlDetalle.NFC = await nFCController_.TraerparaImprimirNFC();
            }
            else
            {
                ventaActualAlDetalle.RNC = RNCNoValido;
                //ventaActualAlDetalle.NFC = "No aplica";
            }

            CrearVenta(ventaActualAlDetalle, CarritoDeCompras);

            if (NombreDelClienteParaLaFactura_txt.Text =="" && ventaActualAlDetalle.RNC == RNCNoValido)
            {
                MessageBox.Show("Es necesario un nombre par el cliente o un rnc","Es necesario un nombre para el cliente",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            NotificacionDeVenta nuevaNotificacion = new NotificacionDeVenta
            {
                NombreDelCliente = NombreDelClienteParaLaFactura_txt.Text == "" ? ventaActualAlDetalle.RNC : NombreDelClienteParaLaFactura_txt.Text,
                CarritoDeCompras = ventaActualAlDetalle.ListadoDeCompras,
                Rnc = InfoRnc.Rnc == "" ? RNCNoValido : InfoRnc.Rnc,
                Venta = ventaActualAlDetalle,
                ImprimirRecibo = true,
                FechaCreacion = DateTime.Now
            };


            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {

                context.Add(ventaActualAlDetalle);
                await context.SaveChangesAsync();
                context.NotificacionesDeVentas.Add(nuevaNotificacion);
                await context.SaveChangesAsync();
            }


            CarritoDeCompras.Clear();


            LimpiarCamposDeVenta();

            await CargarTablasVenta();

            ReanudarTimer(sender, e);

        }

        public async void ImprimirReciboDeVenta(List<CarritoCompraDto> carritoList, RncLookupResult infoRnc, Ventas venta)
        {
            if (infoRnc != null)
            {
                ImpresionRecibo recibo1 = new ImpresionRecibo(carritoList, infoRnc, venta);
                await recibo1.PrepararDatosAsync();
                recibo1.Imprimir();
                return;
            }


            ImpresionRecibo recibo = new ImpresionRecibo(carritoList);
            await recibo.PrepararDatosAsync();
            recibo.Imprimir();
        }

        private void RestarStock(List<CompraEntity> listado)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al restar el stock: " + ex.Message);
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


            try
            {
                lisatdoDeVentas.Clear();
                dataGridView1.DataSource = null;
                using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
                {
                    lisatdoDeVentas = await context.Ventas.ToListAsync();
                }
                dataGridView1.DataSource = lisatdoDeVentas;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de ventas: " + ex.Message);
                return;
            }

        }

        Ventas VentaSeleccionadaDelDatagrid = new Ventas();

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ventaSeleccionada = DataGridHelper.ObtenerIdSeleccionado(dataGridView1, e);

            if (ventaSeleccionada == -1)
            {
                MessageBox.Show("No se logro seleccionar");
                return;
            }

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                VentaSeleccionadaDelDatagrid = context.Ventas.FirstOrDefault(x => x.Id == ventaSeleccionada);

                if (VentaSeleccionadaDelDatagrid == null)
                {
                    MessageBox.Show("Venta No existe con el ID: " + VentaSeleccionadaDelDatagrid.Id.ToString());
                    return;
                }
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
            PausaTimer(sender, e);
            var respuesta = MessageBox.Show("Quieres Entrar a la seccion de reportes ?", "Pregunta sobre Generacion de reportes", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                ReanudarTimer(sender, e);
                return;
            }
            ReportesHelperForm reportesHelperForm = new ReportesHelperForm();

            reportesHelperForm.ListadoParaImprimirVentas = lisatdoDeVentas;

            reportesHelperForm.ShowDialog();
            ReanudarTimer(sender, e);


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
            PausaTimer(sender, e);

            if (!ELCarritoEstaVacio(CarritoDeCompras))
                return;

            RncLookupResult infoRnc = new RncLookupResult();


            if (MessagesHelpers.MensajeDeConfirmacion("¿El cliente quiere comprobante fiscal?", "Comprobante Fiscal", MessageBoxIcon.Question))
            {
                RNCFormHelper rNCFormHelper = new RNCFormHelper();

                rNCFormHelper.ShowDialog();

                InfoRnc = rNCFormHelper.InfoRnc;


                if (InfoRnc == null)
                {
                    MessageBox.Show("No se pudo obtener la información del RNC.");
                    ventaActualAlDetalle.RNC = "000000000";
                    return;
                }

                ventaActualAlDetalle.RNC = InfoRnc.Rnc;
            }

            // 3. Configurar datos iniciales
            CrearVenta(ventaActualAlDetalle, CarritoDeCompras);

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                try
                {
                    if (ConfirmarCompraCredito(ventaActualAlDetalle) == false)
                    {
                        return;
                    }


                    RestarStock(RegresarUnaListaDeComprasEntity(CarritoDeCompras));


                    ImprimirReciboDeVenta(CarritoDeCompras, infoRnc, ventaActualAlDetalle);

                    MessageBox.Show("Compra efectuada con éxito!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al guardar la venta \n" + ex.Message);
                }
            }

            ventaActualAlDetalle = null;

            TotalDelCarrito.Text = "0.00";

            await CargarTablasVenta();

            LimpiarCamposDeVenta();

            ReanudarTimer(sender, e);
        }

        private async void Usuarios_DataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            await CargarTablaDeUsuarios();
        }

        private void materialMaskedTextBox5_TextChanged(object sender, EventArgs e)
        {
            FindForNameHelper.BuscarPorNombre<ProductoMostrarDto>(sender, e, ListadoDeProductosAgotados, ListaDeCompras);
        }

        private void ListadoDeAdeudos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int IdProductoAgotandose = -1;
        private void ListaDeCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdProductoAgotandose = DataGridHelper.ObtenerIdSeleccionado(ListaDeCompras, e);

            if (IdProductoAgotandose != -1)
            {
                MessageBox.Show("ID seleccionado: " + IdProductoAgotandose);
            }
        }

        private void materialButton28_Click(object sender, EventArgs e)
        {

            var respuesta = MessageBox.Show("Queres Eliminar a este Producto de la lista de compras?", "Pregunta sobre Eliminacion", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.No)
            {
                return;
            }

            var productoAgotado = ListadoDeProductosAgotados.FirstOrDefault(x => x.Id == IdProductoAgotandose);

            ListadoDeProductosAgotados.Remove(productoAgotado);

            ListaDeCompras.DataSource = null;

            ListaDeCompras.DataSource = ListadoDeProductosAgotados;

        }

        private async void materialButton27_Click(object sender, EventArgs e)
        {
            ReportesHelperForm reportesHelperForm = new ReportesHelperForm();
            reportesHelperForm.ListadoParaImprimirUsuarios = null;
            reportesHelperForm.ListadoParaImprimirProductos = ListadoDeProductosAgotados;

            reportesHelperForm.ShowDialog();

            await CargarListaDeCompras();

        }

        private void materialMaskedTextBox6_TextChanged(object sender, EventArgs e)
        {
            FindForNameHelper.BuscarPorCodigo<ProductoVentasMostrarDto>(sender, e, listadoProductosDisponiblesVenta, ListadoDeProductosDisponibles_dg);

            // FindForNameHelper.BuscarPorCodigo<ProductoVentasMostrarDto>(sender, e, listadoProductosDisponiblesVenta, ListadoDeProductosDisponibles_dg);


        }

        private void materialMaskedTextBox6_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void CarritoDecompras_dg_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            // Evita errores si se hace clic en el encabezado
            if (e.RowIndex < 0) return;

        }

        private void CarritoDecompras_dg_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.RowIndex < 0) return;

        }

        private void CargarInformacionDelUsuario()
        {
            NombreDelUsuarioSecion.Text = SecionActual.Nombre;
            ApellidoDelUsuarioSecion.Text = SecionActual.Apellido;
            CedulaDelUsuarioSecion.Text = SecionActual.Cedula;
            CargoEmpleadoPerilTxt.Text = SecionActual.Rol.ToString();
            PasswordDeSeccion.Text = SecionActual.Contrasena;
            CorreoDelUsuarioSecion.Text = SecionActual.Correo;

        }

        private void materialButton29_Click(object sender, EventArgs e)
        {
            SecionActual = null;
            Close();
        }

        private void LimpiarVenta_Click(object sender, EventArgs e)
        {
            LimpiarCamposDeVenta();

        }

        private void materialButton30_Click(object sender, EventArgs e)
        {
            VerCarritoDeCompras verCarritoDeCompras = new VerCarritoDeCompras(VentaSeleccionadaDelDatagrid);

            verCarritoDeCompras.ShowDialog();

        }

        private void materialMaskedTextBox6_Click(object sender, EventArgs e)
        {
            ListadoDeProductosDisponibles_dg.Visible = true;
        }

        private void materialMaskedTextBox6_Leave(object sender, EventArgs e)
        {
            //ListadoDeProductosDisponibles_dg.Visible = false;
        }

        private async void materialButton31_Click(object sender, EventArgs e)
        {



            if (VentaSeleccionadaDelDatagrid == null)
                return;

            RncLookupResult rncLookupResult = RncHelper.LookupRnc(VentaSeleccionadaDelDatagrid.RNC);

            ImprimirReciboDeVenta(await RegresarListaDeProductosDeUnaVenta(VentaSeleccionadaDelDatagrid), rncLookupResult, VentaSeleccionadaDelDatagrid);
        }

        private async Task<List<CarritoCompraDto>> RegresarListaDeProductosDeUnaVenta(Ventas venta)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var CarritoSinParse = await context.ComprasEntity.Where(c => c.IdVenta == venta.Id)
                    .ToListAsync();

                List<Producto> ListadoDeProductos = new List<Producto>();


                foreach (var item in CarritoSinParse)
                {
                    var producto = await context.Productos.FirstOrDefaultAsync(x => x.Id == item.IdProducto);

                    producto.Cantidad = item.CantidadDelProducto;
                    producto.FechaCreacion = item.FechaCreacio;
                    ListadoDeProductos.Add(producto);
                }


                List<CarritoCompraDto> CarritoDeComprasParaEstaFactura = new List<CarritoCompraDto>();

                foreach (var item in ListadoDeProductos)
                {
                    CompraEntity compraAMappear = RegresarCompraCreada(item);
                    CarritoDeComprasParaEstaFactura.Add(CompraMapper.MapCompraToCarrito(compraAMappear));
                }


                return CarritoDeComprasParaEstaFactura;
            }

            //return null;
        }

        private void materialMaskedTextBox7_TextChanged(object sender, EventArgs e)
        {
            if (NCF_txt.Text.Length > 11)
            {
                MessageBox.Show("Los NCF no puede tener más de 11 caracteres.");
                NCF_txt.Text = NCF_txt.Text.Substring(0, 11);
                NCF_txt.SelectionStart = NCF_txt.Text.Length;
                return;
            }


        }

        private async void ActualizarNCF_Click(object sender, EventArgs e)
        {
            if (NCF_txt.Text.Length != 11)
            {
                MessageBox.Show("El NCF debe tener exactamente 11 caracteres.");
                return;
            }

            NFCController_ nFCController_ = new NFCController_();



            var TraerElUltimoNCF = await nFCController_.TraerElUltimoNFC();

            if (TraerElUltimoNCF == null)
            {
                NCF nuevoNCF;
                nuevoNCF = new NCF(NCF_txt.Text.Trim());

                var CrearNFCAsync = await nFCController_.CrearNuevoNFCAsync(nuevoNCF);

                MessageBox.Show("NCF creado con exito.");
                return;
            }

            await nFCController_.ActualizarNFC(TraerElUltimoNCF);
            MessageBox.Show("NCF Actualizado con exito");



        }

        private void materialMaskedTextBox7_Click(object sender, EventArgs e)
        {

        }

        List<NotificacionDeVenta> ListaDeNotificaciones = new List<NotificacionDeVenta>();
        private async Task CargarListaDeNotificaciones()
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                ListaDeNotificaciones = await context.NotificacionesDeVentas.Where(x => x.ImprimirRecibo == true).ToListAsync();

                dataGridView2.DataSource = null;

                dataGridView2.DataSource = ListaDeNotificaciones;
            }

        }

        private async void materialButton36_Click(object sender, EventArgs e)
        {

            if (Notificacion == null)
            {
                MessageBox.Show("No has seleccionado ninguna notificacion de venta", "No Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {

                Notificacion.Venta = await context.Ventas.FirstOrDefaultAsync(x => x.Id == Notificacion.VentaId);

                Notificacion.Venta.ListadoDeCompras = await context.ComprasEntity
                                                                       .Where(
                                                                                x =>
                                                                                x.IdVenta == Notificacion.Venta.Id
                                                                        ).ToListAsync();

                try
                {
                    if (ConfirmarCompra(Notificacion.Venta) == false)
                    {

                        return;
                    }

                    RestarStock(Notificacion.Venta.ListadoDeCompras);
                    
                    context.Ventas.Update(Notificacion.Venta);
                    await context.SaveChangesAsync();

                  


                    var CarritoConvertido = RegresarUnaListDeCarritoDto(Notificacion.Venta.ListadoDeCompras);


                    RncLookupResult rncInformacion = RncHelper.LookupRnc(Notificacion.Venta.RNC);
                    
                    ImprimirReciboDeVenta(CarritoConvertido, rncInformacion, Notificacion.Venta);

                    Notificacion.ImprimirRecibo = false;

                    context.NotificacionesDeVentas.Update(Notificacion);
                    await context.SaveChangesAsync();

                    await CargarListaDeNotificaciones();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al guardar la venta \n" + ex.Message);
                }
            }
        }

        int idNotificacionDeventa = -1;
        NotificacionDeVenta Notificacion = new NotificacionDeVenta();
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idNotificacionDeventa = DataGridHelper.ObtenerIdSeleccionado(dataGridView2, e);



            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                Notificacion = context.NotificacionesDeVentas.FirstOrDefault(x => x.Id == idNotificacionDeventa);
                if (Notificacion == null)
                {
                    MessageBox.Show("No se encontro la notificacion", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show($"has seleccionado la notificacion con el id {Notificacion.Id}; con el comprador {Notificacion.NombreDelCliente}; Con el id De Venta {Notificacion.VentaId}");
                }
            }
        }

        private void materialMaskedTextBox7_TextChanged_1(object sender, EventArgs e)
        {
            FindForNameHelper.BuscarPorNombre<NotificacionDeVenta>(sender, e, ListaDeNotificaciones, dataGridView2);
        }
    }
}
