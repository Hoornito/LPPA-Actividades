using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplicationClase2
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public bool CUILValidator(int tipo, string dni, int verificador)
        {
            bool resultadoVerificador;
            int x = 0;
            int suma = 0;
            int z = 0;

            if (string.IsNullOrEmpty(dni)) throw new ArgumentNullException(nameof(dni));
            if (dni.Length != 8) throw new ArgumentException(nameof(dni));
            
            string cuil = tipo.ToString() + dni + verificador.ToString();
            int[] multiplicadores = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            while (x < 10) 
            {
                int digito = int.Parse(cuil[x].ToString());
                int digitoValido = digito * multiplicadores[x];
                suma += digitoValido;

                x++;
            }

            z = suma % 11;
            int resultado = 11 - z;
            resultadoVerificador = (z == 0) ? (z == verificador) : (resultado == verificador);

            //if (z == 0)
            //    resultadoVerificador = (z == verificador);
            //else
            //    resultadoVerificador = (resultado == verificador);

            return resultadoVerificador;
        }
    }
}
