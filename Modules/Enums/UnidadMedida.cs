using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Enums
{
    public enum UnidadMedida
    {
        // Unidades generales
        Unidad = 1,
        Caja = 2,
        Paquete = 3,
        Libra = 4,
        Kilogramo = 5,
        Gramo = 6,
        Metro = 7,
        Centimetro = 8,
        Pieza = 9,

        // Líquidos
        Litro = 10,
        Mililitro = 11,

        // Pinturas – fracciones estándar
        CuartoGalon = 20,      // 1/4 de galón
        MedioGalon = 21,       // 1/2 galón
        TresCuartosGalon = 22, // 3/4 de galón
        Galon = 23,            // 1 galón
        CincoGalones = 24,     // Cubeta de 5 galones

        // Opcionales para ferreterías
        Onza = 30,
        Rollo = 31,
        Bolsa = 32,
        Docena = 33
    }

}
