using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Identity.Client;
using p_proyect.Controller.ProductosController;
using p_proyect.Controller.ProveedorController;
using p_proyect.Modules.Entidades.dtos.dtoProductos;
using p_proyect.Modules.Entidades.Formularios.ProductosForms;
using p_proyect.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_proyect.Modules.Entidades.Formularios.ProveedorForms
{
    public partial class MasInformacionProveedor : MaterialForm
    {

        public Proveedor proveedorMasinformacion = new Proveedor();
        public MasInformacionProveedor()
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

        private ProductosControllerC productosController = new ProductosControllerC();
        List<ProductoMostrarDto> ProveedorLListadoProductos = new List<ProductoMostrarDto>();

        public async Task CargarListadoDeProductosDelProveedor()
        {
            ListadoDeProductosDeEsteProveedor.DataSource = null;

            ProveedorLListadoProductos = await productosController.ObtenerTodosLosProductosDeUnProveedor(proveedorMasinformacion.Id);

            ListadoDeProductosDeEsteProveedor.DataSource = ProveedorLListadoProductos;


        }

        private void CargarInformacionDelProveedorEnControles()
        {
            NombreProveedor.Text = proveedorMasinformacion.Nombre;
            ContactoDelProveedor.Text = proveedorMasinformacion.Contacto;
            UltimaCompraDelProveedor.Text = proveedorMasinformacion.UltimaCompra.ToString();
            FechaDeAgregadiDelProveedor.Text = proveedorMasinformacion.FechaDeCreacion.ToString();
        }

        private async void MasInformacionProveedor_Load(object sender, EventArgs e)
        {
            if(proveedorMasinformacion.Id == 0)
            {
                MessageBox.Show("No se ha cargado la informacion del proveedor");
                Close();
                return;
            }


            Text = $"Mas detalles sobre el proveedor {proveedorMasinformacion.Nombre}";

            CargarInformacionDelProveedorEnControles();


             await CargarListadoDeProductosDelProveedor();
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {
            Enviar_Mensaje_A_Ws.EnviarMensaje(proveedorMasinformacion.Contacto);
        }

        int idDelProductoSeleccionado = -1; 

        private void ListadoDeProductosDeEsteProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idDelProductoSeleccionado = DataGridHelper.ObtenerIdSeleccionado(ListadoDeProductosDeEsteProveedor, e);

            if (idDelProductoSeleccionado != -1)
            {
                MessageBox.Show("ID seleccionado: " + idDelProductoSeleccionado);
            }
        }

        private async void materialButton4_Click(object sender, EventArgs e)
        {

            if (idDelProductoSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un producto de la tabla");
                return;
            }

            ProductosControllerC productosControllerC = new ProductosControllerC();

            AgregarEditarProductos aePForms = new AgregarEditarProductos();

            aePForms.productoSeleccioando = productosControllerC.TraerUnProductoPorElId(idDelProductoSeleccionado);
            aePForms.ShowDialog();

            await CargarListadoDeProductosDelProveedor();
        }

        private async    void materialButton8_Click(object sender, EventArgs e)
        {

            if (proveedorMasinformacion == null)
            {
                MessageBox.Show("Por favor seleccione un proveedor para editar.");
                return;
            }
            AgregarEditarProveedor agregarEditarProveedor = new AgregarEditarProveedor();

            agregarEditarProveedor.proveedorActual = proveedorMasinformacion;

            agregarEditarProveedor.ShowDialog();

            await CargarListadoDeProductosDelProveedor();

            CargarInformacionDelProveedorEnControles();
        }
    }
}
