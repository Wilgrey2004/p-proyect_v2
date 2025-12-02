using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using p_proyect.Modules.Entidades.dtos.dtoCompras;
using p_proyect.Modules.Entidades.dtos.dtoProductos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace p_proyect.Modules.Entidades.Formularios.CompraForms
{
    public partial class VerCarritoDeCompras : MaterialForm
    {
        Ventas ventaSeleccionada = new Ventas();

        public VerCarritoDeCompras(Ventas ventaSeleccionada)
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

            this.ventaSeleccionada = ventaSeleccionada;
        }

        List<CarritoCompraDto> carritoDeComprasShow = new List<CarritoCompraDto>();

        private async void VerCarritoDeCompras_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var CarritoSinParse = await context.ComprasEntity.Where(c => c.IdVenta == ventaSeleccionada.Id)
                    .ToListAsync();

                List<Producto> ListadoDeProductos = new List<Producto>();


                foreach (var item in CarritoSinParse)
                {
                    var producto = await context.Productos.FirstOrDefaultAsync(x => x.Id == item.IdProducto);

                    producto.Cantidad = item.CantidadDelProducto;
                    producto.FechaCreacion = item.FechaCreacio;
                    ListadoDeProductos.Add(producto);
                }

                CarritoDeCompras.DataSource = ListadoDeProductos;
            }
        }
    }
}
