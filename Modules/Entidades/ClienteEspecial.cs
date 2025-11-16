using p_proyect.Modules.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class ClienteEspecial
{
    [Key]
    public int Id { get; set; }

    // Datos personales
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Cedula { get; set; }
   
   
    public string Contacto { get; set; }
   

    // Metadatos
    public DateTime FechaCreacion { get; set; } = DateTime.Now;
    public DateTime? FechaDeEdicion { get; set; }
    public DateTime? FechaUltimaActualizacion { get; set; }
    public bool EsClienteActivo { get; set; } = true;

    // Compras
    public DateTime? UltimaCompra { get; set; }
    public int CantidadDeCompras { get; set; }
    public decimal TotalCompradoHistorico { get; set; }
    public List<Compra> HistorialCompras { get; set; }

    // Crédito
    public decimal LimiteDelCredito { get; set; }
    public decimal CreditoGastado { get; set; }
    public decimal CreditoDisponible => LimiteDelCredito - CreditoGastado;
    public DateTime? FechaUltimoPagoCredito { get; set; }
    public decimal? MontoUltimoPago { get; set; }

    // Descuento
    public decimal DescuentoPersonal { get; set; } = 0m;
}
