using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
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

                if (prop == null)
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
        public static void BuscarPorCodigo<T>(object sender, EventArgs e, List<T> listadoOriginal, DataGridView dgv)
        {
            BaseMaskedTextBox txtBox = sender as BaseMaskedTextBox;
            string texto = txtBox.Text.Trim();

            if (!string.IsNullOrEmpty(texto))
            {
                // Obtener propiedades mediante reflexión
                var propCodigo = typeof(T).GetProperty("CodigoBarra");
                var propNombre = typeof(T).GetProperty("Nombre");

                if (propCodigo == null || propNombre == null)
                {
                    MessageBox.Show($"La clase {typeof(T).Name} debe contener 'CodigoBarra' y 'Nombre'.");
                    return;
                }

                // Filtrar combinando ambas propiedades
                var listaFiltrada = listadoOriginal
                    .Where(item =>
                    {
                        string codigo = propCodigo.GetValue(item)?.ToString();
                        string nombre = propNombre.GetValue(item)?.ToString();

                        bool coincideCodigo = !string.IsNullOrEmpty(codigo) &&
                                              codigo.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0;

                        bool coincideNombre = !string.IsNullOrEmpty(nombre) &&
                                              nombre.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0;

                        return coincideCodigo || coincideNombre;
                    })
                    .ToList();

                dgv.DataSource = null;
                dgv.DataSource = listaFiltrada;
            }
            else
            {
                // Si está vacío, mostrar lista original
                dgv.DataSource = null;
                dgv.DataSource = listadoOriginal;
            }
        }

    }
}
