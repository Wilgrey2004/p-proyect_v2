using MaterialSkin;
using MaterialSkin.Controls;
using p_proyect.Controller.ProductosController;
using p_proyect.Controller.ProveedorController;
using p_proyect.Controller.UsuarioController;
using p_proyect.Modules.Entidades;
using p_proyect.Modules.Entidades.dtos.dtoProductos;
using p_proyect.Modules.Entidades.dtos.dtoProveedor;
using p_proyect.Modules.Entidades.dtos.dtoUsuarios;
using p_proyect.Modules.Entidades.Formularios.ProductosForms;
using p_proyect.Modules.Entidades.Formularios.ProveedorForms;
using p_proyect.Modules.Entidades.Formularios.UsuarioForms;
using p_proyect.Utils;
using p_proyect.Utils.Reportes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_proyect
{
    public partial class Main : MaterialForm
    {
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
            await CargarTablaProductos();
            await CargarListaDeProveedores();

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
            List<UsuarioMostrarDto> ListaFiltradaPorNombre = new List<UsuarioMostrarDto>();
            BaseMaskedTextBox txtBox = sender as BaseMaskedTextBox;
            if (txtBox.Text != string.Empty)
            {
                ListaFiltradaPorNombre = Listado_De_usuarios_Mostrar.FindAll(u => u.Nombre.IndexOf(txtBox.Text.Trim(), StringComparison.OrdinalIgnoreCase) >= 0);
                Usuarios_DataGrid.DataSource = null;
                Usuarios_DataGrid.DataSource = ListaFiltradaPorNombre;
            }
            else
            {
                Usuarios_DataGrid.DataSource = null;
                Usuarios_DataGrid.DataSource = Listado_De_usuarios_Mostrar;
            }
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
            List<ProductoMostrarDto> ListaFiltradaPorNombre = new List<ProductoMostrarDto>();
            BaseMaskedTextBox txtBox = sender as BaseMaskedTextBox;
            if (txtBox.Text != string.Empty)
            {
                ListaFiltradaPorNombre = productoMostrarDtos.FindAll(u => u.Nombre.IndexOf(materialMaskedTextBox1.Text.Trim(), StringComparison.OrdinalIgnoreCase) >= 0);
                ListadoDeProductosMostrar.DataSource = null;
                ListadoDeProductosMostrar.DataSource = ListaFiltradaPorNombre;
            }
            else
            {
                ListadoDeProductosMostrar.DataSource = null;
                ListadoDeProductosMostrar.DataSource = productoMostrarDtos;
            }
        }


        private async void materialButton3_Click(object sender, EventArgs e)
        {

            if(IdProductoSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un producto primero.");
                return;
            }

            var respuesta = MessageBox.Show("Estas seguro de que quieres eliminar al producto seleccionado?", "Pregunta por eliminacion", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }

            productoController.EliminarUnProductoPorElId(IdProductoSeleccionado);

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
            if(IdProveedorSeleccionado == -1)
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
            List<ProveedorMostrarDto> ListaFiltradaPorNombre = new List<ProveedorMostrarDto>();
            BaseMaskedTextBox txtBox = sender as BaseMaskedTextBox;
            if (txtBox.Text != string.Empty)
            {
                ListaFiltradaPorNombre = listadoDeProveedoresMostrar.FindAll(u => u.Nombre.IndexOf(materialMaskedTextBox2.Text.Trim(), StringComparison.OrdinalIgnoreCase) >= 0);
                ProveedoresListadoShow.DataSource = null;
                ProveedoresListadoShow.DataSource = ListaFiltradaPorNombre;
            }
            else
            {
                ProveedoresListadoShow.DataSource = null;
                ProveedoresListadoShow.DataSource = productoMostrarDtos;
            }
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
    }
}
