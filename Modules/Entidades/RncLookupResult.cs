using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Utils.Rnc
{
    public class RncLookupResult
    {

        [Key]
        public string Rnc { get; set; }
        public bool Success { get; set; }
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
