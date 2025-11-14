using MaterialSkin.Controls;
using p_proyect.Modules.Entidades;
using p_proyect.Modules.Entidades.dtos.dtoProveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Utils
{
    public class ComboHelper
    {
        public static void CargarEnumEnCombo<TEnum>(MaterialComboBox combo) where TEnum : Enum
        {
            combo.Items.Clear();

            var valores = Enum.GetValues(typeof(TEnum))
                              .Cast<TEnum>()
                              .ToList();

            foreach (var item in valores)
            {
                combo.Items.Add(item);
            }

            // Opcional: seleccionar el primero automáticamente
            if (combo.Items.Count > 0)
                combo.SelectedIndex = 0;
        }
        

        public static void CargarEnumComboEntidadIDNombre(MaterialComboBox combo,List<ProveedorMostrarDto> listado)
        {
            combo.Items.Clear();

            // Asignar la lista directamente al combo
            combo.DataSource = listado;
            combo.DisplayMember = "Nombre"; // 👀 Se mostrará el nombre del proveedor
            combo.ValueMember = "Id";       // 👀 Guardará el ID como valor interno

            combo.SelectedIndex = -1; // 
        }

    }


}
