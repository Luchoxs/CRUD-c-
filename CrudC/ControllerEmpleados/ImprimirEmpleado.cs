using System;
using CrudC.Entidades;
using System.Collections.Generic;
using System.Text;

namespace CrudC.Controller
{
    public static class ImprimirEmpleado
    {
        public static void Imprimir(List<Empleado> Empleado)
        {
            foreach (var item in Empleado)
            {

                //Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Id {0} Nombre {1} Apellido {2} " +
                 "Direccion {3} Telefono {4} Fecha{5} Area{6} ", item.Id,
                    item.Nombre, item.Apellido, item.Direccion,
                    item.Telefono,item.Fecha_Ingreso,item.IdArea);

            }
        }
    }
}
