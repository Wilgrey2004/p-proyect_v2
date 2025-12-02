using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Utils.Rnc
{
    public class RncLookupResult
    {
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DisplayName("Identificador unico")]

        public int Id { get; set; }

        public bool Success { get; set; }
        public string Rnc { get; set; }
        public string Nombre { get; set; }
        public string ErrorMessage { get; set; }

        override public string ToString()
        {
            if (Success)
            {
                return $"RNC/Cédula: {Rnc}\nNombre: {Nombre}";
            }
            else
            {
                return $"RNC/Cédula: {Rnc}\nError: {ErrorMessage}";
            }
        }
    }
}
