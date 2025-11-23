using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_proyect.Utils
{
    public static class FindForNameHelper
    {
        //List<ProveedorMostrarDto> ListaFiltradaPorNombre = new List<ProveedorMostrarDto>();
        //BaseMaskedTextBox txtBox = sender as BaseMaskedTextBox;
        //if (txtBox.Text != string.Empty)
        //{
        //    ListaFiltradaPorNombre = listadoDeProveedoresMostrar.FindAll(u => u.Nombre.IndexOf(materialMaskedTextBox2.Text.Trim(), StringComparison.OrdinalIgnoreCase) >= 0);
        //    ProveedoresListadoShow.DataSource = null;
        //    ProveedoresListadoShow.DataSource = ListaFiltradaPorNombre;
        //}
        //else
        //{
        //    ProveedoresListadoShow.DataSource = null;
        //    ProveedoresListadoShow.DataSource = productoMostrarDtos;
        //}


        public static void BuscarPorNombre<T>(object sender, EventArgs e, List<T> listadoOriginal, DataGridView dgv)
        {
            BaseMaskedTextBox txtBox = sender as BaseMaskedTextBox;
            string texto = txtBox.Text.Trim();

            if (!string.IsNullOrEmpty(texto))
            {
                // Obtener la propiedad "Nombre" mediante reflexión
                var prop = typeof(T).GetProperty("Nombre");

                if (prop == null)
                {
                    prop = typeof(T).GetProperty("NombreDelCliente");
                }

                if(prop == null)
                {
                    MessageBox.Show($"La clase {typeof(T).Name} no contiene la propiedad 'Nombre'.");
                    return;
                }

                // Filtrar usando reflexión
                var listaFiltrada = listadoOriginal
                    .Where(item =>
                    {
                        var valor = prop.GetValue(item) as string;
                        return valor != null &&
                               valor.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0;
                    })
                    .ToList();

                dgv.DataSource = null;
                dgv.DataSource = listaFiltrada;
            }
            else
            {
                dgv.DataSource = null;
                dgv.DataSource = listadoOriginal; // Lista original
            }
        }
    }
}
