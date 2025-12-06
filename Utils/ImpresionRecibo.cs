using p_proyect.Modules.Entidades;
using p_proyect.Modules.Entidades.dtos.dtoCompras;
using p_proyect.Utils.Rnc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

public class ImpresionRecibo
{
    private readonly List<CarritoCompraDto> productos;
    private readonly string RncDeLaEmpresa = "RNC: 132848632";
    private readonly string NombreDeLaEmpresa = "GRUPO YEJIMIS E.I.R.L";
    private readonly string Ubicacion = "AV. LIBERTAD NO 151, YAGUATE";
    private readonly string Telefono = "TEL: 849-449-8601/829-726-0794";
    private readonly string Fecha = "Fecha: " + DateTime.Now.ToString("dd-MM-yyyy  /   HH:mm");
    private readonly RncLookupResult rncLookupResult;
    private readonly Ventas ventas;
    private readonly Font fuente = new Font("Arial", 10);
    private int posicionY = 0;
    private readonly int maxWidth = 150;

    // Constructor para imprimir desde una lista

    public ImpresionRecibo(List<CarritoCompraDto> productos)
    {
        this.productos = productos;
    }

    public ImpresionRecibo(List<CarritoCompraDto> productos, RncLookupResult rncLookupResult, Ventas venta = null)
    {
        this.productos = productos;
        this.rncLookupResult = rncLookupResult;
        this.ventas = venta;
    }


    public void Imprimir()
    {
        using (PrintDocument printDocument = new PrintDocument())
        {
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom80mm", 300, 1000);
            printDocument.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);

            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        printDocument.PrinterSettings = printDialog.PrinterSettings;
                        printDocument.Print();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al imprimir: " + ex.Message);
                    }
                }
            }
        }
    }

    private string ComprovarRnc()
    {
        if (rncLookupResult != null && rncLookupResult.Success)
        {
            return rncLookupResult.Rnc;
        }
        else
        {
            return "000000000";
        }
    }

    private string comprovarNombre()
    {
        if (rncLookupResult != null && rncLookupResult.Success)
        {
            return rncLookupResult.Nombre;
        }
        else
        {
            return "Consumidor Final";
        }
    }


    private string CargarNumeroOCodigoDeLaFactura()
    {
        if (ventas != null)
        {
            return "0000" + ventas.Id.ToString();
        }
        else
        {
            return "000000";
        }
    }


    private string FechaDeCierreDeLaFactura()
    {
        int siguienteAño = DateTime.Now.Year + 1;
        DateTime fecha = new DateTime(siguienteAño, 12, 31);

        return fecha.ToString("yyyy-MM-dd");
    }

    private string CalcularItebis(decimal cantidad)
    {
        decimal itebis = cantidad * 0.18m;
        return itebis.ToString();
    }

    private void PrintPage(object sender, PrintPageEventArgs e)
    {
        Graphics g = e.Graphics;

        int margenIzquierdo = 10;
        int margenDerecho = 10;
        int margenSuperior = 20;
        int espacioLinea = 25;
        int pageWidth = e.PageBounds.Width;
        string rnc = ComprovarRnc();
        string EmpresaDelCliente = comprovarNombre();
        string numeroDeLaFacturaOCodigoDeEsta = CargarNumeroOCodigoDeLaFactura();
        string fechadelcierre = FechaDeCierreDeLaFactura();
        //string itebis;

        // Encabezado
        string empresa = NombreDeLaEmpresa;
        posicionY = margenSuperior;

        float textWidth = g.MeasureString(empresa, fuente).Width;

        posicionY += espacioLinea + 10;
        g.DrawString(empresa, fuente, Brushes.Black, pageWidth - margenDerecho - textWidth, posicionY);
        posicionY += espacioLinea + 10;
        g.DrawString(Ubicacion, fuente, Brushes.Black, pageWidth - margenDerecho - textWidth, posicionY);
        posicionY += espacioLinea + 10;
        g.DrawString(Telefono, fuente, Brushes.Black, pageWidth - margenDerecho - textWidth, posicionY);
        posicionY += espacioLinea;
        g.DrawString(RncDeLaEmpresa, fuente, Brushes.Black, margenIzquierdo, posicionY);
        posicionY += espacioLinea + 10;

        g.DrawString("*----------------------------------------------------*", fuente, Brushes.Black, margenIzquierdo, posicionY);
        posicionY += espacioLinea;
        g.DrawString("-__              F  A  C  T  U  R  A              __-", fuente, Brushes.Black, margenIzquierdo, posicionY);
        posicionY += espacioLinea + 10;
        g.DrawString("*----------------------------------------------------*", fuente, Brushes.Black, margenIzquierdo, posicionY);
        posicionY += espacioLinea;

        g.DrawString(Fecha, fuente, Brushes.Black, margenDerecho, posicionY);
        posicionY += espacioLinea + 10;

        g.DrawString($"Rnc Del Cliente: {rnc}", fuente, Brushes.Black, margenIzquierdo, posicionY);
        posicionY += espacioLinea + 10;

        g.DrawString("Numero De La Factura: " + numeroDeLaFacturaOCodigoDeEsta, fuente, Brushes.Black, margenIzquierdo, posicionY);
        posicionY += espacioLinea + 10;

        g.DrawString("Vivencia de la factura: " + fechadelcierre, fuente, Brushes.Black, margenIzquierdo, posicionY);
        posicionY += espacioLinea + 10;

        g.DrawString("*----------------------------------------------------*", fuente, Brushes.Black, margenIzquierdo, posicionY);
        posicionY += espacioLinea;
        decimal TotalDeLaCompra = 0;
        g.DrawString("Lista De Productos", fuente, Brushes.Black, margenDerecho, posicionY);
        posicionY += espacioLinea + 10;
        // Recorre la lista de productos
        foreach (var item in productos)
        {
            
            string nombre = AjustarNombreProducto(item.NombreProducto, maxWidth);
            
            string cantidad = item.Cantidad.ToString();
            
            string precio = item.PrecioUnitario.ToString("N2");
           
            string total = item.TotalProducto.ToString("N2");
            
            TotalDeLaCompra += item.TotalProducto;
            
            g.DrawString(nombre, fuente, Brushes.Black, margenIzquierdo, posicionY);
            
            g.DrawString(cantidad.PadLeft(3), fuente, Brushes.Black, margenIzquierdo + 100, posicionY);
           
            g.DrawString(precio, fuente, Brushes.Black, margenIzquierdo + 150, posicionY);
            
            g.DrawString(total, fuente, Brushes.Black, margenIzquierdo + 220, posicionY);
           
            posicionY += espacioLinea + 10;
            
        }

        posicionY += 10;
        g.DrawString("*----------------------------------------------------*", fuente, Brushes.Black, margenDerecho, posicionY);

        posicionY += espacioLinea + 10;
        g.DrawString("ITBIS --> " + CalcularItebis(TotalDeLaCompra), fuente, Brushes.Black, margenIzquierdo, posicionY);

        posicionY += espacioLinea + 10;
        g.DrawString("Total --> " + TotalDeLaCompra, fuente, Brushes.Black, margenIzquierdo, posicionY);
        posicionY += espacioLinea + 10;

        g.DrawString("*----------------------------------------------------*", fuente, Brushes.Black, margenIzquierdo, posicionY);
        posicionY += espacioLinea + 10;


        posicionY += espacioLinea + 10;
        g.DrawString("No Aceptamos Devoluciones despues de 24 Horas", fuente, Brushes.Black, margenIzquierdo, posicionY);
        posicionY += espacioLinea + 10;
        g.DrawString("No Aceptamos Devoluciones sin factura", fuente, Brushes.Black, margenIzquierdo, posicionY);
        posicionY += espacioLinea + 10;
        g.DrawString("Sin la mercancia, sin tikets, sucia, alterada, dañada, etc...", fuente, Brushes.Black, margenIzquierdo, posicionY);
        posicionY += espacioLinea + 10;


        g.DrawString("Gracias Por Preferirnos!!!", fuente, Brushes.Black, margenIzquierdo, posicionY);
        posicionY += espacioLinea + 10;
    }

    private string AjustarNombreProducto(string nombreProducto, int maxWidth)
    {
        using (Graphics g = Graphics.FromImage(new Bitmap(1, 1)))
        {
            int anchoTexto = (int)g.MeasureString(nombreProducto, fuente).Width;

            if (anchoTexto > maxWidth - 100)
                return nombreProducto.Substring(0, nombreProducto.Length / 2) + "...";
            else
                return nombreProducto;
        }
    }
}
