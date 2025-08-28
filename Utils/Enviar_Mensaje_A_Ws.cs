using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_proyect.Utils
{
        public class Enviar_Mensaje_A_Ws
        {
                public static void EnviarMensaje( string Numero )
                {
                        Numero = Numero.Trim();
                        string Numero_Del_Cliente = string.IsNullOrWhiteSpace(Numero) ? "Teléfono no especificado" : Numero;
                        string Numero_Del_Cliente_Sin_Espacios = Numero_Del_Cliente.Replace(" ", "");
                        string Numero_Del_Cliente_Sin_Espacios_y_sin_guiones = Numero_Del_Cliente_Sin_Espacios.Replace("-", "");
                        string numero = Numero_Del_Cliente_Sin_Espacios_y_sin_guiones;
                        string url = $"https://wa.me/{numero}";
                        try
                        {
                                Process.Start(new ProcessStartInfo {
                                        FileName = url,
                                        UseShellExecute = true
                                });
                                MessageBox.Show("Mensaje enviado con exito.");
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Error al abrir WhatsApp: " + ex.Message);
                                return;
                        }
                }
        }
}
