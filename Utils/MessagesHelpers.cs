using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_proyect.Utils
{
    public static class MessagesHelpers
    {
        public static bool MensajeDeConfirmacion(string Mensaje,string Cabecera, MessageBoxIcon Icono)
        {
            var respuesta = MessageBox.Show(Mensaje, Cabecera , MessageBoxButtons.YesNo, Icono);
            if (respuesta == DialogResult.No)
            {
                return false;
            }

            return true;
        }

    }
}
