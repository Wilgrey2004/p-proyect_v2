
using p_proyect.Modules.Entidades;
using p_proyect.Modules.Entidades.responses;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Threading;
using System.Windows.Forms;

public class ImpresionRecibo
{
        private DataGridView dataGrid;
        private Font fuente = new Font("Arial", 10);
        private int posicionY = 0;
        private int maxWidth = 150; // Límite de ancho para el nombre del producto

        public ImpresionRecibo( DataGridView dgv ) {
                this.dataGrid = dgv;
        }
        public ImpresionRecibo() {

        }

        public void Imprimir() {
                PrintDocument printDocument = new PrintDocument();

                // Ajustar tamaño de papel para 80 mm (aprox. 3 pulgadas = 300 centésimas de pulgada).
                PaperSize paperSize = new PaperSize("Custom80mm", 300, 1000);
                printDocument.DefaultPageSettings.PaperSize = paperSize;

                // Opcional: establecer márgenes a 0 si la impresora lo permite
                printDocument.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

                // Establecer el nombre exacto de la impresora
                printDocument.PrinterSettings.PrinterName = "80mm Series Printer";

                // Suscribirse al evento para dibujar la página
                printDocument.PrintPage += new PrintPageEventHandler(PrintPage);

                try
                {
                        printDocument.Print();
                } catch (Exception ex)
                {
                        MessageBox.Show("Error al imprimir: " + ex.Message);
                }
        }
        public void ImprimirReciboDeAdeudoEstudianteCurso( Adeudo_Response Adeudo_Response_Info, string Cuota ) {
                PrintDocument printDocument = new PrintDocument();
                PaperSize paperSize = new PaperSize("Custom80mm", 300, 600);
                printDocument.DefaultPageSettings.PaperSize = paperSize;
                printDocument.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                printDocument.PrinterSettings.PrinterName = "80mm Series Printer";

                printDocument.PrintPage += ( sender, e ) => {
                        Graphics g = e.Graphics;
                        int margenIzquierdo = 10;
                        int margenSuperior = 20;
                        int espacioLinea = 25;
                        int pageWidth = e.PageBounds.Width;
                        int y = margenSuperior;

                        // Encabezado
                        string empresa = "";
                        float textWidth = g.MeasureString(empresa, fuente).Width;
                        g.DrawString(empresa, fuente, Brushes.Black, pageWidth - textWidth - 10, y);
                        y += espacioLinea;
                        g.DrawString("", fuente, Brushes.Black, margenIzquierdo, y);
                        y += espacioLinea;
                        g.DrawString("Tel: ", fuente, Brushes.Black, margenIzquierdo, y);
                        y += espacioLinea;
                        g.DrawString("Fecha: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"), fuente, Brushes.Black, margenIzquierdo, y);
                        y += espacioLinea + 10;

                        // Detalles de reparación
                        g.DrawString("Estudiante: " + Adeudo_Response_Info.Nombre_Estudiante, fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
                        g.DrawString("Curso: " + Adeudo_Response_Info.Nombre_Curso, fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
                        g.DrawString("Fecha del pago: " + Adeudo_Response_Info.Fecha_Del_Ultimo_Pago.ToString("dd-MM-yyyy"), fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
                        g.DrawString("Siguiente pago: " + Adeudo_Response_Info.Fecha_Del_Siguiente_Pago.ToString("dd-MM-yyyy"), fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
                        g.DrawString("Costo total: " + Adeudo_Response_Info.Adeudo, fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
                        g.DrawString("Restante de a pagar: " + Adeudo_Response_Info.Restante_A_Pagar, fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
                        y += 10;
                        g.DrawString("*---------------------------------------------*", fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
                        g.DrawString("Cuota: " + Cuota, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, margenIzquierdo, y);
                        y += espacioLinea;
                        g.DrawString("¡Gracias por confiar en S.E.T.E.A!", fuente, Brushes.Black, margenIzquierdo, y);
                };

                try
                {
                        printDocument.Print();
                } catch (Exception ex)
                {
                        MessageBox.Show("Error al imprimir: " + ex.Message);
                }
        }

        //public void ImprimirReciboReparacion_De_Recibido( ReparacionesRPShowModels reparacion ) {
        //        PrintDocument printDocument = new PrintDocument();
        //        PaperSize paperSize = new PaperSize("Custom80mm", 300, 600);
        //        printDocument.DefaultPageSettings.PaperSize = paperSize;
        //        printDocument.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
        //        printDocument.PrinterSettings.PrinterName = "80mm Series Printer";

        //        printDocument.PrintPage += ( sender, e ) => {
        //                Graphics g = e.Graphics;
        //                int margenIzquierdo = 10;
        //                int margenSuperior = 20;
        //                int espacioLinea = 25;
        //                int pageWidth = e.PageBounds.Width;
        //                int y = margenSuperior;

        //                // Encabezado
        //                string empresa = "S.E.T.E.A/Factura de recepcion.";
        //                float textWidth = g.MeasureString(empresa, fuente).Width;
        //                g.DrawString(empresa, fuente, Brushes.Black, pageWidth - textWidth - 10, y);
        //                y += espacioLinea;
        //                g.DrawString("Servicios tecnologicos de americas", fuente, Brushes.Black, margenIzquierdo, y);
        //                y += espacioLinea;
        //                g.DrawString("Tel: 849-581-8773", fuente, Brushes.Black, margenIzquierdo, y);
        //                y += espacioLinea;
        //                g.DrawString("Fecha: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"), fuente, Brushes.Black, margenIzquierdo, y);
        //                y += espacioLinea + 10;

        //                // Detalles de reparación
        //                g.DrawString("Cliente: " + reparacion.Nombre_Cliente, fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
        //                g.DrawString("Correo: " + reparacion.Correo_Del_Cliente, fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
        //                g.DrawString("Dispositivo: " + reparacion.Marca_Dispositivo + " - " + reparacion.Tipo_Dispositivo, fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
        //                g.DrawString("Estado: " + reparacion.Estado, fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
        //                g.DrawString("Diagnóstico: " + reparacion.Diagnostico, fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
        //                g.DrawString("Fallo: " + reparacion.Fallo_Detectado, fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
        //                g.DrawString("Ingreso: " + reparacion.Fecha_Ingreso?.ToString("dd-MM-yyyy-hh:mm"), fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
        //                g.DrawString("Bono : " + reparacion.Cuota_Abono?.ToString("C2"), fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
        //                //g.DrawString("Entrega: " + reparacion.Fecha_Alta?.ToString("dd-MM-yyyy"), fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
        //                y += 10;
        //                g.DrawString("Firma del cliente:*---------------------------*", fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
        //                g.DrawString("Firma del tecnico:*---------------------------*", fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
        //                g.DrawString("*---------------------------------------------*", fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
        //                g.DrawString("Restante: " + reparacion.Dinero_restante_de_las_cuotas?.ToString("C2"), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, margenIzquierdo, y);
        //                g.DrawString("Total a pagar: " + reparacion.Cobro_Reparacion?.ToString("C2"), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, margenIzquierdo, y);
        //                y += espacioLinea;
        //                g.DrawString("¡Gracias por confiar en S.E.T.E.A!", fuente, Brushes.Black, margenIzquierdo, y);
        //        };

        //        try
        //        {
        //                printDocument.Print();
        //                Thread.Sleep(1500);
        //                printDocument.Print();
        //        } catch (Exception ex)
        //        {
        //                MessageBox.Show("Error al imprimir: " + ex.Message);
        //        }
        //}
        private void PrintPage( object sender, PrintPageEventArgs e ) {
                Graphics g = e.Graphics;

                // Ajustar márgenes y espaciados
                int margenIzquierdo = 10;
                int margenDerecho = 10; // Usaremos este margen para el cálculo de alineación derecha
                int margenSuperior = 20;
                int espacioLinea = 25;

                // Ancho total de la página (en las unidades del evento, normalmente se usan centésimas de pulgada)
                int pageWidth = e.PageBounds.Width;
                posicionY = margenSuperior;


                string empresa = "";
                float textWidth = g.MeasureString(empresa, fuente).Width;
                float xPos = pageWidth - margenDerecho - textWidth;
                g.DrawString(empresa, fuente, Brushes.Black, xPos, posicionY);

                posicionY += espacioLinea;
                string mensaje = "";
                textWidth = g.MeasureString(mensaje, fuente).Width;
                xPos = pageWidth - margenDerecho - textWidth;
                g.DrawString(mensaje, fuente, Brushes.Black, xPos, posicionY);

                // Dibujar teléfono alineado a la derecha en la siguiente línea
                posicionY += espacioLinea;
                string telefono = "Tel: ";
                textWidth = g.MeasureString(telefono, fuente).Width;
                xPos = pageWidth - margenDerecho - textWidth;
                g.DrawString(telefono, fuente, Brushes.Black, xPos, posicionY);

                // Fecha alineada a la izquierda
                posicionY += espacioLinea;
                g.DrawString("Fecha: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"),
                             fuente, Brushes.Black, margenIzquierdo, posicionY);
                posicionY += espacioLinea + 10;

                // Cabecera de columnas
                //g.DrawString("Producto", fuente, Brushes.Black, margenIzquierdo, posicionY);
                //g.DrawString("Cant", fuente, Brushes.Black, margenIzquierdo + 100, posicionY);
                //g.DrawString("P-Unidad", fuente, Brushes.Black, margenIzquierdo + 150, posicionY);
                //g.DrawString("Total", fuente, Brushes.Black, margenIzquierdo + 220, posicionY);
                posicionY += espacioLinea;
                g.DrawString("*----------------------------------------------------*",
                             fuente, Brushes.Black, margenIzquierdo, posicionY);
                posicionY += espacioLinea;

                // Calcular total de la venta
                //decimal totalVenta = CalcularTotalVenta();

                // Imprimir filas del DataGridView
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                        if (row.Cells["Nombre Del Producto"].Value != null)
                        {
                                string producto = row.Cells["Nombre Del Producto"].Value.ToString();
                                string cantidad = row.Cells["cantidad Producto"].Value.ToString();
                                string precio = row.Cells["Precio Unidad"].Value.ToString();
                                string total = row.Cells["precio Por Cantidad"].Value.ToString();

                                // Ajustar nombre del producto si excede el ancho
                                string nombreProductoAjustado = AjustarNombreProducto(producto, maxWidth);

                                g.DrawString(nombreProductoAjustado, fuente, Brushes.Black,
                                             margenIzquierdo, posicionY);
                                g.DrawString(cantidad.PadLeft(3), fuente, Brushes.Black,
                                             margenIzquierdo + 100, posicionY);
                                g.DrawString(precio, fuente, Brushes.Black,
                                             margenIzquierdo + 150, posicionY);
                                g.DrawString(total, fuente, Brushes.Black,
                                             margenIzquierdo + 220, posicionY);

                                posicionY += espacioLinea;
                        }
                }

                // Línea final
                posicionY += 10;
                g.DrawString("*----------------------------------------------------*",
                             fuente, Brushes.Black, margenIzquierdo, posicionY);
                posicionY += espacioLinea;

                // Imprimir total de la venta en negrita
                //g.DrawString("TOTAL: " + totalVenta.ToString("C2"),
                //             new Font("Arial", 12, FontStyle.Bold),
                //             Brushes.Black, margenIzquierdo + 150, posicionY);
                posicionY += espacioLinea;

                // Mensaje final
                g.DrawString("", fuente,
                             Brushes.Black, margenIzquierdo, posicionY);
        }

        // Calcula el total de la venta
        //private decimal CalcularTotalVenta() {
        //        decimal total = 0;
        //        foreach (DataGridViewRow row in dataGrid.Rows)
        //        {
        //                if (row.Cells["precio Por Cantidad"].Value != null)
        //                {
        //                        if (decimal.TryParse(row.Cells["precio Por Cantidad"].Value.ToString(), out decimal totalFila))
        //                        {
        //                                total += totalFila;
        //                        }
        //                }
        //        }
        //        return total;
        //}

        // Ajusta el nombre del producto para que no se desborde
        private string AjustarNombreProducto( string nombreProducto, int maxWidth ) {
                using (Graphics g = Graphics.FromImage(new Bitmap(1, 1)))
                {
                        int anchoTexto = (int)g.MeasureString(nombreProducto, fuente).Width;

                        // Si el ancho excede el límite, cortar el texto a la mitad y añadir un punto
                        if (anchoTexto > maxWidth - 100)
                        {
                                return nombreProducto.Substring(0, nombreProducto.Length / 2) + ".";
                        } else
                        {
                                return nombreProducto;
                        }
                }
        }


}
