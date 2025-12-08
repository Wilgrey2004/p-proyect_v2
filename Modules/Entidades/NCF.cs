using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades
{
    public class NCF
    {
        public  NCF() { }
        public NCF(string ncf)
        {
            if (ncf.Length == 11)
            {
                Serie = ncf.Substring(0,1);
                TipoDeComprovante = short.Parse(ncf.Substring(1, 2));
                SecuenciaDeCaracteres = int.Parse(ncf.Substring(3, 8));
            }
            else
            {
                //throw new ArgumentException("El NCF proporcionado no tiene la longitud correcta.");
            }
        }

        [Key]
        [DisplayName("Codigo Unico del Adeudo")]
        public int Id { get; set; }

        [DisplayName("Serie del comprovante fiscal")]
        public string Serie { get; set; }

        [DisplayName("Tipo de documento")]
        public short TipoDeComprovante { get; set; }
        [DisplayName("Numero Caracteres")]
        public int SecuenciaDeCaracteres { get; set; }


        public override string ToString()
        {
            string secuencia = $"{Serie}{TipoDeComprovante}{SecuenciaDeCaracteres}";
            if(secuencia.Length < 11)
            {
                int faltantes = 11 - secuencia.Length;
                secuencia = secuencia.Insert(3, new string('0', faltantes));
            }
            return secuencia;
        }

    }
}
