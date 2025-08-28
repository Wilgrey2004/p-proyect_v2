using p_proyect.Modules.Entidades.responses;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

public class ImpresionRecibo
{
        private readonly DataGridView dataGrid;
        private readonly Font fuente = new Font("Arial", 10);
        private int posicionY = 0;
        private readonly int maxWidth = 150; // Límite de ancho para el nombre del producto

        // Constructor que recibe un DataGridView
        public ImpresionRecibo( DataGridView dgv ) {
                this.dataGrid = dgv;
        }

        public ImpresionRecibo() { }

        /// <summary>
        /// Método general para imprimir. 
        /// Abre un diálogo para seleccionar impresora y luego imprime el DataGridView.
        /// </summary>
        public void Imprimir() {
                using (PrintDocument printDocument = new PrintDocument())
                {
                        // Configuración del tamaño de papel (80mm de ancho)
                        printDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom80mm", 300, 1000);
                        printDocument.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

                        // Evento que define cómo se dibuja la página
                        printDocument.PrintPage += new PrintPageEventHandler(PrintPage);

                        // Mostrar diálogo de impresión para que el usuario elija impresora
                        using (PrintDialog printDialog = new PrintDialog())
                        {
                                printDialog.Document = printDocument; // Enlazar el documento al diálogo
                                printDialog.AllowSomePages = false;   // Se podría activar si quieres rangos de páginas
                                printDialog.ShowHelp = false;

                                if (printDialog.ShowDialog() == DialogResult.OK)
                                {
                                        try
                                        {
                                                printDocument.PrinterSettings = printDialog.PrinterSettings;
                                                printDocument.Print(); // Imprimir con la impresora seleccionada
                                        } catch (Exception ex)
                                        {
                                                MessageBox.Show("Error al imprimir: " + ex.Message);
                                        }
                                }
                        }
                }
        }

        /// <summary>
        /// Método para imprimir un recibo de adeudo de un estudiante.
        /// También abre el diálogo para seleccionar impresora.
        /// </summary>
        public void ImprimirReciboDeAdeudoEstudianteCurso( Adeudo_Response adeudoInfo, string cuota ) {
                using (PrintDocument printDocument = new PrintDocument())
                {
                        printDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom80mm", 300, 600);
                        printDocument.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

                        // Evento inline para dibujar la página
                        printDocument.PrintPage += ( sender, e ) =>
                        {
                                Graphics g = e.Graphics;
                                int margenIzquierdo = 10;
                                int margenSuperior = 20;
                                int espacioLinea = 25;
                                int pageWidth = e.PageBounds.Width;
                                int y = margenSuperior;

                                // Encabezado
                                string empresa = "S.E.T.E.A";
                                float textWidth = g.MeasureString(empresa, fuente).Width;
                                g.DrawString(empresa, fuente, Brushes.Black, pageWidth - textWidth - 10, y);
                                y += espacioLinea;

                                g.DrawString("Tel: ", fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
                                g.DrawString("Fecha: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"), fuente, Brushes.Black, margenIzquierdo, y);
                                y += espacioLinea + 10;

                                // Detalles del adeudo
                                g.DrawString("Estudiante: " + adeudoInfo.Nombre_Estudiante, fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
                                g.DrawString("Curso: " + adeudoInfo.Nombre_Curso, fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
                                g.DrawString("Fecha del pago: " + adeudoInfo.Fecha_Del_Ultimo_Pago.ToString("dd-MM-yyyy"), fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
                                g.DrawString("Siguiente pago: " + adeudoInfo.Fecha_Del_Siguiente_Pago.ToString("dd-MM-yyyy"), fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
                                g.DrawString("Costo total: " + adeudoInfo.Adeudo, fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
                                g.DrawString("Restante a pagar: " + adeudoInfo.Restante_A_Pagar, fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;

                                y += 10;
                                g.DrawString("*---------------------------------------------*", fuente, Brushes.Black, margenIzquierdo, y); y += espacioLinea;
                                g.DrawString("Cuota: " + cuota, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, margenIzquierdo, y);
                                y += espacioLinea;
                                g.DrawString("¡Gracias por confiar en S.E.T.E.A!", fuente, Brushes.Black, margenIzquierdo, y);
                        };

                        // Mostrar el diálogo de impresión
                        using (PrintDialog printDialog = new PrintDialog())
                        {
                                printDialog.Document = printDocument;
                                if (printDialog.ShowDialog() == DialogResult.OK)
                                {
                                        try
                                        {
                                                printDocument.PrinterSettings = printDialog.PrinterSettings;
                                                printDocument.Print();
                                        } catch (Exception ex)
                                        {
                                                MessageBox.Show("Error al imprimir: " + ex.Message);
                                        }
                                }
                        }
                }
        }

        /// <summary>
        /// Lógica para dibujar la página de impresión con datos de DataGridView.
        /// </summary>
        private void PrintPage( object sender, PrintPageEventArgs e ) {
                Graphics g = e.Graphics;

                int margenIzquierdo = 10;
                int margenDerecho = 10;
                int margenSuperior = 20;
                int espacioLinea = 25;
                int pageWidth = e.PageBounds.Width;
                posicionY = margenSuperior;

                // Encabezado
                string empresa = "Mi Empresa";
                float textWidth = g.MeasureString(empresa, fuente).Width;
                g.DrawString(empresa, fuente, Brushes.Black, pageWidth - margenDerecho - textWidth, posicionY);

                posicionY += espacioLinea;
                g.DrawString("Tel: ", fuente, Brushes.Black, margenIzquierdo, posicionY);

                posicionY += espacioLinea;
                g.DrawString("Fecha: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"), fuente, Brushes.Black, margenIzquierdo, posicionY);
                posicionY += espacioLinea + 10;

                // Línea divisoria
                g.DrawString("*----------------------------------------------------*", fuente, Brushes.Black, margenIzquierdo, posicionY);
                posicionY += espacioLinea;

                // Recorrer filas del DataGridView
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                        if (row.Cells["Nombre Del Producto"].Value != null)
                        {
                                string producto = row.Cells["Nombre Del Producto"].Value.ToString();
                                string cantidad = row.Cells["cantidad Producto"].Value.ToString();
                                string precio = row.Cells["Precio Unidad"].Value.ToString();
                                string total = row.Cells["precio Por Cantidad"].Value.ToString();

                                string nombreAjustado = AjustarNombreProducto(producto, maxWidth);

                                g.DrawString(nombreAjustado, fuente, Brushes.Black, margenIzquierdo, posicionY);
                                g.DrawString(cantidad.PadLeft(3), fuente, Brushes.Black, margenIzquierdo + 100, posicionY);
                                g.DrawString(precio, fuente, Brushes.Black, margenIzquierdo + 150, posicionY);
                                g.DrawString(total, fuente, Brushes.Black, margenIzquierdo + 220, posicionY);

                                posicionY += espacioLinea;
                        }
                }

                // Línea final
                posicionY += 10;
                g.DrawString("*----------------------------------------------------*", fuente, Brushes.Black, margenIzquierdo, posicionY);
        }

        /// <summary>
        /// Método auxiliar que recorta el nombre del producto si es muy largo.
        /// </summary>
        private string AjustarNombreProducto( string nombreProducto, int maxWidth ) {
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
