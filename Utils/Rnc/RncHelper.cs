using Octetus.ConsultasDgii.Services;
using p_proyect.Utils.Rnc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Utils
{
    public static class RncHelper
    {
        public static RncLookupResult LookupRnc(string rncOrCedula)
        {
            try
            {
                var dgii = new ServicioConsultasWebDgii();
                var response = dgii.ConsultarRncContribuyentes(rncOrCedula.Trim());

                if (response.Success)
                {
                    return new RncLookupResult
                    {
                        Success = true,
                        Rnc = response.CedulaORnc,
                        Nombre = response.NombreORazónSocial,
                        ErrorMessage = null
                    };
                }
                else
                {
                    return new RncLookupResult
                    {
                        Success = false,
                        Rnc = rncOrCedula,
                        Nombre = null,
                        ErrorMessage = response.Message ?? "No se encontró contribuyente"
                    };
                }
            }
            catch (Exception ex)
            {
                return new RncLookupResult
                {
                    Success = false,
                    Rnc = rncOrCedula,
                    Nombre = null,
                    ErrorMessage = $"Error en consulta DGII: {ex.Message}"
                };
            }
        }
    }

   
}
