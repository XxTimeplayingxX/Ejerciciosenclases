using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Ejerciciosenclases
{
    /// <summary>
    /// Descripción breve de EjerciciosEnClase
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class EjerciciosEnClase : System.Web.Services.WebService
    {

        [WebMethod]
        public string Saludar(String saludar)
        {
            return $"Hola {saludar}";
        }
        [WebMethod]
        public double SumarDosNumeros(double num1, double num2)
        {
            return num1 + num2;
        }
        [WebMethod]
        public double NumFactorial(double NumFactorial)
        {
            double resultFactorial = 1;
            for (int i = 1; i <= NumFactorial; i++)
            {
                resultFactorial *= i;
            }
            return resultFactorial;
        }

        [WebMethod]
        public int[] Ejercicio3()
        {
            //Random random = new Random();
            //int[] numero = new int[5];
            //int[] muestra = new int[5];
            //for (int i = 0; i < numero.Length; i++)
            //{
            //    numero[i] = random.Next(1, 100);
            //}

            //for (int i = 0; i < numero.Length; i++)
            //{
            //   muestra[i] = numero[i];
            //    return int[] { muestra[i] };
            //}
            return new int[] { 1, 2, 3, 4, 5 };
        }

        [WebMethod]
        public int ConvertirBinarioADecimal(string binaryNumber)
        {
            int decimalNumber = 0;
            int binaryBase = 2;

            for (int i = binaryNumber.Length - 1, j = 0; i >= 0; i--, j++)
            {
                int bit = int.Parse(binaryNumber[i].ToString());
                decimalNumber += bit * (int)Math.Pow(binaryBase, j);
            }

            return decimalNumber;
        }
    }
}
