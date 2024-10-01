using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.BE;


namespace TP3.BLL
{
    public static class CalcularSueldo
    {
        public static decimal Calcular(Trabajador trabajador)
        {
            //if (trabajador.CantidadHoras <= 0 || trabajador.ValorHora <= 0)
            //{
            //    throw new ArgumentException("Cantidad de horas y valor de la hora deben ser mayores que cero.");
            //}

            return trabajador.CantidadHoras * trabajador.ValorHora;
        }
    }
}
