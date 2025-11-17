using Microsoft.EntityFrameworkCore;
using p_proyect.Modules;
using p_proyect.Modules.Entidades.dtos.dtoProductos;
using p_proyect.Modules.Entidades.dtos.dtoVentas;
using p_proyect.Modules.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace p_proyect.Controller.ProductosController
{
    public class ProductosControllerC
    {
        public ProductosControllerC() { }



        public async Task<List<ProductoVentasMostrarDto>> ObtenerTodosLosproductosParaListaDeProductos(TipoDeVenta tipoDeVenta)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var listadoPuro = await context.Productos.Where(pro => pro.TipoDeDeSalida == tipoDeVenta && pro.Cantidad > 0).ToListAsync();
                List<ProductoVentasMostrarDto> listadoConvertido = new List<ProductoVentasMostrarDto>();
                for (int i = 0; i < listadoPuro.Count; i++)
                {
                    listadoConvertido.Add(ProductoMapper.DeProductoAProductoVentasDto(listadoPuro[i]));
                }

                return listadoConvertido;
            }
        }

        public async Task<List<ProductoMostrarDto>> ObtenerTodosLosProductos()
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var listado = context.Productos.ToList();

                List<ProductoMostrarDto> listadoConvertido = new List<ProductoMostrarDto>();

                for (int i = 0; i < listado.Count; i++)
                {
                    listadoConvertido.Add(ProductoMapper.DeProductoAProductoDtoMostrar(listado[i]));
                }

                return listadoConvertido;
            }
        }

        public async Task<ProductoVentasMostrarDto> TraerProductoPorElCodigo(string Codigo)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var productoACombertir = await context.Productos.FirstOrDefaultAsync(x => x.CodigoBarra == Codigo);

                return ProductoMapper.DeProductoAProductoVentasDto(productoACombertir);
            }
        }

        public async Task<Producto> TraerProductoPorElCodigo_(string Codigo)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                return await context.Productos.FirstOrDefaultAsync(x => x.CodigoBarra == Codigo);
            }
        }

        public async Task<List<ProductoMostrarDto>> ObtenerTodosLosProductosDeUnProveedor(int id)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var listado = context.Productos.Where(pro => pro.ProveedorId == id).ToList();

                List<ProductoMostrarDto> listadoConvertido = new List<ProductoMostrarDto>();

                for (int i = 0; i < listado.Count; i++)
                {
                    listadoConvertido.Add(ProductoMapper.DeProductoAProductoDtoMostrar(listado[i]));
                }

                return listadoConvertido;
            }
        }

        public async Task<Producto> EditarProductoASync(ProductoEditarDto dto)
        {
            if (dto.Id <= 0)
                throw new ArgumentException("Debe especificar un ID válido.");

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var producto = await context.Productos.FindAsync(dto.Id);

                if (producto == null)
                    throw new Exception("El producto no existe.");

                // Validaciones condicionales
                if (dto.Nombre != null && string.IsNullOrWhiteSpace(dto.Nombre))
                    throw new ArgumentException("El nombre no puede estar vacío.");

                if (dto.Cantidad != 0 && dto.Cantidad < 0)
                    throw new ArgumentException("La cantidad no puede ser negativa.");

                if (
                    !Enum.IsDefined(typeof(UnidadMedida), dto.UnidadMedida))
                    throw new ArgumentException("La unidad de medida es inválida.");

                if (
                    !Enum.IsDefined(typeof(TipoDeVenta), dto.TipoDeDeSalida))
                    throw new ArgumentException("El tipo de venta es inválido.");

                if (dto.StockMinimo != 0 && dto.StockMinimo < 0)
                    throw new ArgumentException("El stock mínimo no puede ser negativo.");

                if (dto.StockMaximo != 0 && dto.StockMaximo < 0)
                    throw new ArgumentException("El stock máximo no puede ser negativo.");

                if (dto.ProveedorId != 0 && dto.ProveedorId <= 0)
                    throw new ArgumentException("Debe especificar un proveedor válido.");

                // ✅ Aplicar solo lo recibido
                if (dto.Nombre != null) producto.Nombre = dto.Nombre.Trim();
                if (dto.Descripcion != null) producto.Descripcion = dto.Descripcion;
                if (dto.CodigoBarra != null) producto.CodigoBarra = dto.CodigoBarra;
                if (dto.Marca != null) producto.Marca = dto.Marca;
                if (dto.Modelo != null) producto.Modelo = dto.Modelo;
                if (dto.TipoDeDeSalida > 0) producto.TipoDeDeSalida = dto.TipoDeDeSalida;
                if (dto.Cantidad >= 0) producto.Cantidad = dto.Cantidad;
                if (dto.StockMinimo >= 0) producto.StockMinimo = dto.StockMinimo;
                if (dto.StockMaximo >= 0) producto.StockMaximo = dto.StockMaximo;
                if (dto.UnidadMedida != 0) producto.UnidadMedida = dto.UnidadMedida;
                if (dto.PrecioCompra >= 0) producto.PrecioCompra = dto.PrecioCompra;
                if (dto.PrecioVenta >= 0) producto.PrecioVenta = dto.PrecioVenta;
                if (dto.FechaExpiracion.HasValue) producto.FechaExpiracion = dto.FechaExpiracion;
                if (dto.Ubicacion != null) producto.Ubicacion = dto.Ubicacion;
                producto.Activo = dto.Activo;
                producto.ProveedorId = dto.ProveedorId;

                producto.FechaActualizacion = DateTime.UtcNow;

                context.Productos.Update(producto);

                await context.SaveChangesAsync();

                return producto;

            }
        }


        public async Task<Producto> CrearProductoAsync(ProductoCreateDto dto)
        {
            // Validaciones esenciales
            if (string.IsNullOrWhiteSpace(dto.Nombre))
                throw new ArgumentException("El nombre es obligatorio.");

            if (dto.Cantidad < 0)
                throw new ArgumentException("La cantidad no puede ser negativa.");

            if (dto.StockMinimo < 0 || dto.StockMaximo < 0)
                throw new ArgumentException("El stock no puede tener valores negativos.");

            if (!Enum.IsDefined(typeof(UnidadMedida), dto.UnidadMedida))
                throw new ArgumentException("La unidad de medida es inválida.");

            if (!Enum.IsDefined(typeof(TipoDeVenta), dto.TipoDeDeSalida))
                throw new ArgumentException("El tipo de venta es inválido.");

            if (dto.ProveedorId <= 0)
                throw new ArgumentException("Debe especificar un proveedor válido.");


            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var nuevoProducto = new Producto
                {
                    Nombre = dto.Nombre.Trim(),
                    Descripcion = dto.Descripcion,
                    CodigoBarra = dto.CodigoBarra,
                    Marca = dto.Marca,
                    Modelo = dto.Modelo,
                    TipoDeDeSalida = dto.TipoDeDeSalida,
                    Cantidad = dto.Cantidad,
                    StockMinimo = dto.StockMinimo,
                    StockMaximo = dto.StockMaximo,
                    UnidadMedida = dto.UnidadMedida,
                    PrecioCompra = dto.PrecioCompra,
                    PrecioVenta = dto.PrecioVenta,
                    FechaExpiracion = dto.FechaExpiracion,
                    Ubicacion = dto.Ubicacion,
                    Activo = true,
                    FechaCreacion = DateTime.UtcNow,
                    FechaActualizacion = DateTime.UtcNow,
                    ProveedorId = dto.ProveedorId
                };

                context.Productos.Add(nuevoProducto);
                await context.SaveChangesAsync();

                return nuevoProducto;
            }
        }
        public Producto TraerUnProductoPorElId(int id)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                return context.Productos.Find(id);
            }
        }

        public bool EliminarUnProductoPorElId(int id)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                context.Productos.Remove(TraerUnProductoPorElId(id));

                return true;
            }
        }
    }
}

