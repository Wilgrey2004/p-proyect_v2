using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p_proyect.Modules.Entidades;

namespace p_proyect.Modules.Entidades.dtos.dtoProductos
{
    public static class ProductoMapper // Cambiado a clase estática para métodos de extensión
    {
        public static ProductoMostrarDto DeProductoAProductoDtoMostrar(this Producto p)
        {
            return new ProductoMostrarDto
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Descripcion = p.Descripcion,
                CodigoBarra = p.CodigoBarra,
                Marca = p.Marca,
                Modelo = p.Modelo,
                TipoDeDeSalida = p.TipoDeDeSalida,

                Cantidad = p.Cantidad,
                StockMinimo = p.StockMinimo,
                StockMaximo = p.StockMaximo,
                UnidadMedida = p.UnidadMedida,

                PrecioCompra = p.PrecioCompra,
                PrecioVenta = p.PrecioVenta,
                Ganancia = p.Ganancia,

                FechaExpiracion = p.FechaExpiracion,
                Ubicacion = p.Ubicacion,
                Activo = p.Activo,

                ProveedorId = p.ProveedorId,
                NombreProveedor = p.Proveedor_ != null ? p.Proveedor_.Nombre : null
            };
        }

        // CREATE DTO → Entidad
        public static Producto CrearYRegresarEntidadDeDto(this ProductoCreateDto dto)
        {
            return new Producto
            {
                Nombre = dto.Nombre,
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

                ProveedorId = dto.ProveedorId,
                Activo = true,
                FechaCreacion = DateTime.Now
            };
        }

        // UPDATE DTO → Entidad (aplica cambios)
        public static void ActualizarProducto(this Producto p, ProductoEditarDto dto)
        {
            p.Nombre = dto.Nombre;
            p.Descripcion = dto.Descripcion;
            p.CodigoBarra = dto.CodigoBarra;
            p.Marca = dto.Marca;
            p.Modelo = dto.Modelo;
            p.TipoDeDeSalida = dto.TipoDeDeSalida;

            p.Cantidad = dto.Cantidad;
            p.StockMinimo = dto.StockMinimo;
            p.StockMaximo = dto.StockMaximo;
            p.UnidadMedida = dto.UnidadMedida;

            p.PrecioCompra = dto.PrecioCompra;
            p.PrecioVenta = dto.PrecioVenta;

            p.FechaExpiracion = dto.FechaExpiracion;
            p.Ubicacion = dto.Ubicacion;
            p.Activo = dto.Activo;

            p.ProveedorId = dto.ProveedorId;

            p.FechaActualizacion = DateTime.Now;
        }
    }
}
