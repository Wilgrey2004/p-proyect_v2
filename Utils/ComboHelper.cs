using MaterialSkin.Controls;
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
    }
}
