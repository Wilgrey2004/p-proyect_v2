using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_proyect.Utils
{
    public class DataGridHelper
    {
        public static int ObtenerIdSeleccionado(DataGridView dataGrid, DataGridViewCellEventArgs e)
        {
            // Validar que el clic sea en una fila válida
            if (e.RowIndex < 0)
                return -1;

            // Obtener la fila clickeada
            var fila = dataGrid.Rows[e.RowIndex];

            // Tomar el ID desde la celda 0
            if (fila.Cells[0].Value != null)
            {
                int id;
                if (int.TryParse(fila.Cells[0].Value.ToString(), out id))
                {
                    return id;
                }
            }

            return -1; // Si falla algo
        }
    }
}
