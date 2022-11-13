using CrudC.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CrudC.ControllerArea
{
    public class AreaController
    {
        public AreaController()
        {
            _Areas = new List<Areas>();
        }

        private List<Areas> _Areas;
        public List<Areas> Areas { get { return _Areas; } }
        #region LLenar lista
        // LLenar Lista
        public void LlenarListaA()
        {

            var verificarId1 = Areas.Any(i => i.Id == 1);
            if (!verificarId1)
            {
                Areas.Add(new Areas()
                {
                    Id = 1,
                    Nombre = "Planeacion",

                });

                Areas.Add(new Areas()
                {
                    Id = 2,
                    Nombre = "Contable",

                });

                Areas.Add(new Areas()
                {
                    Id = 3,
                    Nombre = "Recursos Humanos",

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
        public void getA()
        {
            List<Areas> lista = new List<Areas>();
            lista.AddRange(from o in Areas orderby o.Id ascending select o);
            if (lista.Count > 0)
            {
                ImprimirArea.ImprimirA(lista);
            }
            else
            {
                Console.WriteLine("[]");
            }

        }
        #endregion Imprimir Lista
        #region Buscar por ID
        //getxId
        public void getbyIdA(int id)
        {
            List<Areas> lista = new List<Areas>();
            lista.AddRange(from x in Areas where x.Id == id select x);
            ImprimirArea.ImprimirA(lista);
        }
        #endregion Buscar por ID
        #region Agregar Datos
        //Agregar Datos
        public void postA(int id, string nombre )
        {
            var verificarId = Areas.Any(i => i.Id == id);
            if (!verificarId)
            {
                Areas.Add(new Areas()
                {
                    Id = id,
                    Nombre = nombre,
                    
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
        public void updateA(int id, string nombre)
        {
            var ReplaceItem = new Areas
            {
                Id = id,
                Nombre = nombre,
                
            };
            var element = Areas.FirstOrDefault(i => i.Id == ReplaceItem.Id);
            Areas.Remove(element);
            Areas.Add(ReplaceItem);
        }
        #endregion Actualizar
        #region Eliminar
        public void DeletexIdA(int id)
        {
            //var EliminarItem = new Productos { Id = id };
            var element = Areas.FirstOrDefault(i => i.Id == id);
            Areas.Remove(element);
        }

        #endregion Eliminar
    }
}
