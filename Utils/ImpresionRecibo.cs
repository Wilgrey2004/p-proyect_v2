using p_proyect.Modules.Entidades.dtos.dtoCompras;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

public class ImpresionRecibo
{
    private readonly List<CarritoCompraDto> productos;
    private readonly Font fuente = new Font("Arial", 10);
    private int posicionY = 0;
    private readonly int maxWidth = 150;

    // Constructor para imprimir desde una lista
    public ImpresionRecibo(List<CarritoCompraDto> productos)
    {
        this.productos = productos;
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

    private void PrintPage(object sender, PrintPageEventArgs e)
    {
        Graphics g = e.Graphics;

        int margenIzquierdo = 10;
        int margenDerecho = 10;
        int margenSuperior = 20;
        int espacioLinea = 25;
        int pageWidth = e.PageBounds.Width;
        posicionY = margenSuperior;

        // Encabezado
        string empresa = "";
        float textWidth = g.MeasureString(empresa, fuente).Width;
        g.DrawString(empresa, fuente, Brushes.Black, pageWidth - margenDerecho - textWidth, posicionY);

        posicionY += espacioLinea;
        g.DrawString("Fecha: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"), fuente, Brushes.Black, margenDerecho, posicionY );
        posicionY += espacioLinea + 10;
        g.DrawString("Yeufris Rent Cart", fuente, Brushes.Black, margenIzquierdo, posicionY);
        posicionY += espacioLinea + 10;
        g.DrawString("Codigo De la Factura: ", fuente, Brushes.Black, margenIzquierdo, posicionY);

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
           // g.DrawString("*----------------------------------------------------*", fuente, Brushes.Black, margenIzquierdo, posicionY);
            //posicionY += espacioLinea;
        }

        posicionY += 10;
        g.DrawString("*----------------------------------------------------*", fuente, Brushes.Black, margenDerecho, posicionY);
        posicionY += espacioLinea + 10;
        g.DrawString("Total "+ TotalDeLaCompra, fuente, Brushes.Black, margenIzquierdo, posicionY);
        posicionY += espacioLinea + 10;
        g.DrawString("*----------------------------------------------------*", fuente, Brushes.Black, margenIzquierdo, posicionY);


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
