using System;
using CrudC.Entidades;
using System.Collections.Generic;
using System.Text;

namespace CrudC.controllerNomina
{
    class ImprimirNomina
    {
        public static void Imprimir(List<nomina> nomina)
        {
            foreach (var item in nomina)
            {

                //Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Id {0} Fecha {1} Id Empleado {2} " +
                 "Sueldo {3} Dias {4} Total Basico {5} Comisiones {6} Dvengado {7} ", item.Id,
                    item.Fecha, item.IdEmpleado, item.Sueldo,
                    item.Dias, item.Total_Basico, item.Comisiones, item.Devengado);

            }
        }
    }
}
