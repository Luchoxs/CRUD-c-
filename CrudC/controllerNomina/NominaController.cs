using CrudC.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudC.controllerNomina
{
    class NominaController
    {
         public NominaController()
         {

             _Nomina = new List<nomina>();

         }

         private List<nomina> _Nomina;
         public List<nomina> nomina { get { return _Nomina; } }

         #region LLenar lista
         //Metodo Llenar Lista
         public void LlenarLista()
         {

            var verificarId1 = nomina.Any(i => i.Id == 1);
            if (!verificarId1)
            {
                nomina.Add(new nomina()
                {
                    Id = 1,
                    Fecha = DateTime.Today,
                    IdEmpleado = 3,
                    Sueldo = 5000000,
                    Dias = 30,
                    Total_Basico = 5000000,
                    Comisiones = 60000,
                    Devengado = 5060000
                });



                nomina.Add(new nomina()
                {
                    Id = 2,
                    Fecha = DateTime.Today,
                    IdEmpleado = 3,
                    Sueldo = 3000000,
                    Dias = 15,
                    Total_Basico = 15000000,
                    Comisiones = 80000,
                    Devengado = 1580000
                });
                Console.WriteLine("201");
            }
            else
            {
                Console.WriteLine("Este Id ya existe");
            }
           


         }
        #endregion LLenar lista

        #region Imprimir Lista
        public void get()
        {
            List<nomina> lista = new List<nomina>();
            lista.AddRange(from o in nomina orderby o.Id ascending select o);
            if (lista.Count > 0)
            {
                ImprimirNomina.Imprimir(lista);
            }
            else
            {
                Console.WriteLine("[]");
            }

        }
        #endregion Imprimir Lista
        #region Buscar por ID
        //getxId
        public void getbyId(int id)
        {
            List<nomina> lista = new List<nomina>();
            lista.AddRange(from x in nomina where x.Id == id select x);
            ImprimirNomina.Imprimir(lista);
        }
        #endregion Buscar por ID
        #region Agregar Datos
        //Agregar Datos
        public void post(int id, int IdEmpleado, int Sueldo, int Dias,  int Comisiones)
        {
            var verificarId = nomina.Any(i => i.Id == id);
            if (!verificarId)
            {
                nomina.Add(new nomina()
                {
                    Id = id,
                    IdEmpleado=IdEmpleado,
                    Sueldo= Sueldo,
                    Dias=Dias,
                    Total_Basico= (Sueldo * Dias)/30,
                    Comisiones=Comisiones,
                    Devengado= ((Sueldo * Dias) / 30 )+ Comisiones


                });
                Console.WriteLine("201");
            }
            else
            {
                Console.WriteLine("Este Id ya existe");
            }
        }
        #endregion Agregar Datos
        #region Actualizar
        //Actualizar
        public void update(int id, int IdEmpleado, int Sueldo, int Dias, int Comisiones)
        {
            var ReplaceItem = new nomina
            {
                Id = id,
                IdEmpleado = IdEmpleado,
                Sueldo=Sueldo,
                Dias=Dias,
                Total_Basico = (Sueldo * Dias) / 30,
                Comisiones =Comisiones,
                Devengado = ((Sueldo * Dias) / 30) + Comisiones

            };
            var element = nomina.FirstOrDefault(i => i.Id == ReplaceItem.Id);
            nomina.Remove(element);
            nomina.Add(ReplaceItem);
        }
        #endregion Actualizar
        #region Eliminar
        public void DeletexId(int id)
        {
            //var EliminarItem = new Productos { Id = id };
            var element = nomina.FirstOrDefault(i => i.Id == id);
            nomina.Remove(element);
        }

        #endregion Eliminar
    }

}
