using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I08___El_tiempo_pasa
{
    internal class CalcularFecha
    {
        public static int CalcularDias(DateTime fecha)
        {
            DateTime fechaHoy = DateTime.Now;

            TimeSpan dif = fechaHoy - fecha;

            int diasBisiestos = ContarDiasBisiestos(fecha.Year, fechaHoy.Year);
            int diasVividos = dif.Days - diasBisiestos;

            return diasVividos;

        }
        static int ContarDiasBisiestos(int startYear, int endYear)
        {
            int count = 0;
            for (int year = startYear; year <= endYear; year++)
            {
                if (DateTime.IsLeapYear(year))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
