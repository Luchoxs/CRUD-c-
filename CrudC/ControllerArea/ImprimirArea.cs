using System;
using CrudC.Entidades;
using System.Collections.Generic;
using System.Text;

namespace CrudC.ControllerArea
{
    public class ImprimirArea
    {

        public static void ImprimirA(List<Areas> Areas)
        {
            foreach (var item in Areas)
            {

                //Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Id {0} Nombre {1}  " + " ", item.Id,
                    item.Nombre);

            }
        }


    }
}
