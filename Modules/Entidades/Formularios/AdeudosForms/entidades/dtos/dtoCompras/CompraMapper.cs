using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows.Forms;

namespace p_proyect.Modules.Entidades.dtos.dtoCompras
{
    public static class CompraMapper
    {
        // ===== ENTIDAD → MOSTRAR =====
        public static CompraMostrarDto ToMostrarDto(this Compra entity)
        {
            return new CompraMostrarDto
            {
                Id = entity.Id,
                //ClienteEspecialId = entity.ClienteEspecialId,
                Fecha = entity.Fecha,
                Total = entity.Total,
                Productos = entity.Productos
            };
        }

        // ===== ENTIDAD → EDITAR =====
        public static CompraEditarDto ToEditarDto(this Compra entity)
        {
            return new CompraEditarDto
            {
                Id = entity.Id,
                //ClienteEspecialId = entity.ClienteEspecialId,
                Fecha = entity.Fecha,
                Total = entity.Total,
                Productos = entity.Productos
            };
        }

        // ===== ENTIDAD → CREAR =====
        public static CompraCrearDto ToCrearDto(this Compra entity)
        {
            return new CompraCrearDto
            {
                //ClienteEspecialId = entity.ClienteEspecialId,
                Fecha = entity.Fecha,
                Total = entity.Total,
                Productos = entity.Productos
            };
        }

        // ===== CREAR DTO → ENTIDAD =====
        public static Compra ToEntity(this CompraCrearDto dto)
        {
            return new Compra
            {
                //ClienteEspecialId = dto.ClienteEspecialId,
                Fecha = dto.Fecha,
                Total = dto.Total,
                Productos = dto.Productos
            };
        }

        // ===== EDITAR DTO → ENTIDAD (UPDATE) =====
        public static void UpdateEntity(this CompraEditarDto dto, Compra entity)
        {
            //entity.ClienteEspecialId = dto.ClienteEspecialId;
            entity.Fecha = dto.Fecha;
            entity.Total = dto.Total;
            entity.Productos = dto.Productos;
        }

        public static CarritoCompraDto MapCompraToCarrito(CompraEntity compra)
        {
            return new CarritoCompraDto
            {
                CompraId = compra.Id,
                ProductoId = compra.IdProducto,
                NombreProducto = compra.ListaDeproductos?.Nombre,
                CodigoBarra = compra.ListaDeproductos?.CodigoBarra,
                Cantidad = compra.CantidadDelProducto,
                PrecioUnitario = compra.ListaDeproductos?.PrecioVenta ?? 0,
                UnidadMedida = compra.ListaDeproductos?.UnidadMedida.ToString(),
                FechaAgregado = compra.FechaCreacio
            };
        }

        public static CompraEntity MapCarritoToCompra(CarritoCompraDto dto)
        {

            var producto = new Producto();
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                producto = context.Productos.FirstOrDefault(x => x.Id == dto.ProductoId);
            }

            if (producto == null) {
                MessageBox.Show("Producto vacio!!");
                
            }
            return new CompraEntity
            {
                Id = dto.CompraId, // Si es una compra nueva debe ser 0
                IdProducto = dto.ProductoId,
                CantidadDelProducto = dto.Cantidad,

                // No incluyas el total aquí porque CompraEntity ya lo calcula
                // TotalPorElProducto => se calcula desde la entidad

                FechaCreacio = dto.FechaAgregado,
                PrecioUnitario = producto.PrecioVenta,

                // Navigation property (opcional; EF la llena si haces Include)
                ListaDeproductos = producto != null ? producto : null
            };
        }

    }
}
