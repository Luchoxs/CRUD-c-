using CrudC.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudC.Controller
{
    public class EmpleadosController
    {
        public EmpleadosController()
        {

            _Empleado = new List<Empleado>();

        }

        private List<Empleado> _Empleado;
        public List<Empleado> Empleado { get { return _Empleado; } }
        
        
        #region LLenar lista
        //Metodo Llenar Lista
        public void LlenarLista()
        {
            var verificarId1 = Empleado.Any(i => i.Id == 1 ) ;
            if (!verificarId1 )
            {
                Empleado.Add(new Empleado()
                {
                    Id = 1,
                    Nombre = "Aylen",
                    Apellido = "Sabrit",
                    Direccion = "Calle 69c",
                    Telefono = "300212",
                    Fecha_Ingreso = DateTime.Today,
                    IdArea = 1
                });



                Empleado.Add(new Empleado()
                {
                    Id = 2,
                    Nombre = "Luis",
                    Apellido = "Diaz",
                    Direccion = "Calle 45b",
                    Telefono = "123456",
                    Fecha_Ingreso = DateTime.Today,
                    IdArea = 1
                });


                Empleado.Add(new Empleado()
                {
                    Id = 3,
                    Nombre = "Andres",
                    Apellido = "Montiel",
                    Direccion = "Calle 75a",
                    Telefono = "789123",
                    Fecha_Ingreso = DateTime.Today,
                    IdArea = 1
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
            List<Empleado> lista = new List<Empleado>();
            lista.AddRange(from o in Empleado orderby o.Id ascending select o);
            if (lista.Count > 0)
            {
                ImprimirEmpleado.Imprimir(lista);
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
            List<Empleado> lista = new List<Empleado>();
            lista.AddRange(from x in Empleado where x.Id == id select x);
            ImprimirEmpleado.Imprimir(lista);
        }
        #endregion Buscar por ID
        #region Agregar Datos
        //Agregar Datos
        public void post(int id, string nombre, string apellido,
            string direccion, string telefono, int idArea)
        {
            var verificarId = Empleado.Any(i => i.Id == id);
            if (!verificarId)
            {
                Empleado.Add(new Empleado()
                {
                    Id = id,
                    Nombre = nombre,
                    Apellido = apellido,
                    Direccion = direccion,
                    Telefono = telefono,
                    IdArea = idArea
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
        public void update(int id, string nombre, string apellido,
            string direccion, string telefono, int idArea)
        {
            var ReplaceItem = new Empleado
            {
                Id = id,
                    Nombre = nombre,
                    Apellido = apellido,
                    Direccion = direccion,
                    Telefono = telefono,
                    IdArea = idArea
            };
            var element = Empleado.FirstOrDefault(i => i.Id == ReplaceItem.Id);
            Empleado.Remove(element);
            Empleado.Add(ReplaceItem);
        }
        #endregion Actualizar
        #region Eliminar
        public void DeletexId(int id)
        {
            //var EliminarItem = new Productos { Id = id };
            var element = Empleado.FirstOrDefault(i => i.Id == id);
            Empleado.Remove(element);
        }

        #endregion Eliminar


    }
}
