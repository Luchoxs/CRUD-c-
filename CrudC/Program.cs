using System;
using CrudC.Entidades;
using System.Collections.Generic;
using CrudC.Controller;
using CrudC.ControllerArea;
using CrudC.controllerNomina;
namespace CrudC
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpleadosController emp = new EmpleadosController();
            AreaController ar = new AreaController();
            NominaController nom = new NominaController();
            int opc = 0 ;
            int id = 0;
            string nombre;
            string apellido;
            string direccion;
            string telefono;
            int IdEmpleado;
            int Sueldo;
            int Dias;
            int Comisiones;

        int idArea;

            do {
                Console.Clear();
                Console.WriteLine(" Selecione crud \n1.Empleado \n 2.Area \n 3.Nomina  \n 4.salir");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    
                    case 1:
                        #region CrudEmpleado
                        int opcE = 0;
                        Console.Clear();
                        Console.WriteLine(" Selecione crud \n1.Imprimir \n 2.BuscarxId \n 3.Insertar  \n 4.Editar \n 5.Eliminar \n 6.Salir");
                        opcE = Convert.ToInt32(Console.ReadLine());
                        
                        switch (opcE)
                        {

                            case 1:

                                Console.WriteLine("Empleados Registrados:");
                                
                                emp.LlenarLista();
                                emp.get();
                                Console.ReadKey();
                                break;

                            case 2:


                                Console.WriteLine("Buscar Empleado por Id: ");
                                
                                Console.Write("Digite id: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                emp.LlenarLista();
                                emp.getbyId(id);
                                Console.ReadKey();

                                break;

                            case 3:

                                Console.WriteLine("Insertar Empleado: ");
                                Console.Write("Introduzca Id: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Introduzca Nombre: ");
                                nombre = (Console.ReadLine());
                                Console.Write("Introduzca Apellido: ");
                                apellido = (Console.ReadLine());
                                Console.Write("Introduzca Direccion: ");
                                direccion =(Console.ReadLine());
                                Console.Write("Introduzca  Telefono: ");
                                telefono = (Console.ReadLine());
                                Console.Write("Introduzca  Area: ");
                                idArea = Convert.ToInt32(Console.ReadLine());
                                
                                emp.LlenarLista();
                                emp.post(id, nombre, apellido, direccion, telefono, idArea);
                                emp.get();
                                
                                
                                
                                
                                Console.ReadKey();


                                break;


                                case 4:

                                Console.WriteLine("Modificar Empleado: ");
                                Console.Write("Introduzca Id: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Introduzca Nombre: ");
                                nombre = (Console.ReadLine());
                                Console.Write("Introduzca Apellido: ");
                                apellido = (Console.ReadLine());
                                Console.Write("Introduzca Direccion: ");
                                direccion =(Console.ReadLine());
                                Console.Write("Introduzca  Telefono: ");
                                telefono = (Console.ReadLine());
                                Console.Write("Introduzca  Area: ");
                                idArea = Convert.ToInt32(Console.ReadLine());
                                
                                emp.LlenarLista();
                                emp.update(id, nombre, apellido, direccion, telefono, idArea);
                                emp.get();
                                
                                
                                
                                
                                Console.ReadKey();


                                break;


                            case 5:

                                Console.WriteLine("Eliminar producto: ");
                                Console.Write("Introduzca Id: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                emp.LlenarLista();
                                emp.DeletexId(id);
                                emp.get();
                                Console.ReadKey();


                                break;

                            case 6:

                                Console.WriteLine("Gracias por usarme");
                                Console.ReadKey();
                                break;

                        }
                        #endregion CrudEmpleado
                        break;


                    case 2:
                        #region Crud Area
                        int opcA = 0;
                        Console.Clear();
                        Console.WriteLine(" Selecione crud \n1.Imprimir \n 2.BuscarxId \n 3.Insertar  \n 4.Editar \n 5.Eliminar \n 6.Salir");
                        opcA = Convert.ToInt32(Console.ReadLine());


                        switch (opcA)
                        {
                            case 1:


                                Console.WriteLine("Area Registradas:");

                                ar.LlenarListaA();
                                ar.getA();
                                Console.ReadKey();
                                break;

                            case 2:

                                Console.WriteLine("Buscar Area por Id: ");

                                Console.Write("Digite id: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                ar.LlenarListaA();
                                ar.getbyIdA(id);
                                Console.ReadKey();

                                break;

                            case 3:

                                Console.WriteLine("Insertar Area: ");
                                Console.Write("Introduzca Id: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Introduzca Nombre: ");
                                nombre = (Console.ReadLine());

                                ar.LlenarListaA();
                                ar.postA( id, nombre);
                                ar.getA();
                                Console.ReadKey();
                                break;


                            case 4:

                                Console.WriteLine("Modificar Area: ");
                                Console.Write("Introduzca Id: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Introduzca Nombre: ");
                                nombre = (Console.ReadLine());



                                ar.LlenarListaA();
                                ar.updateA(id, nombre);
                                ar.getA();
                                Console.ReadKey();
                                break;

                            case 5:

                                Console.WriteLine("Eliminar producto: ");
                                Console.Write("Introduzca Id: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                ar.LlenarListaA();
                                ar.DeletexIdA(id);
                                ar.getA();
                                Console.ReadKey();
                                break;

                            case 6:

                                Console.WriteLine("Gracias por usarme");
                                Console.ReadKey();
                                break;

                        }
                        #endregion Crud Area
                        break;

                    case 3:
                        #region Crud nomina
                        int opcN = 0;
                        Console.Clear();
                        Console.WriteLine(" Selecione crud \n1.Imprimir \n 2.BuscarxId \n 3.Insertar  \n 4.Editar \n 5.Eliminar \n 6.Salir");
                        opcN = Convert.ToInt32(Console.ReadLine());

                        switch(opcN)
                        { 
                            case 1:
                                Console.WriteLine("nominas registradas:");

                                nom.LlenarLista();
                                nom.get();
                                Console.ReadKey();
                                break;

                            case 2:
                                Console.WriteLine("Buscar Nomina por Id: ");

                                Console.Write("Digite id: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                nom.LlenarLista();
                                nom.getbyId(id);
                                Console.ReadKey();
                                break;

                            case 3:

                                Console.WriteLine("Insertar Nomina: ");
                                Console.Write("Introduzca Id: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Introduzca ID de empleado: ");
                                IdEmpleado = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Introduzca el sueldo: ");
                                Sueldo= Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Insertar cantidad de dias: ");
                                Dias = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Introduzca las comisiones: ");
                                Comisiones= Convert.ToInt32(Console.ReadLine());

                                nom.LlenarLista();
                                nom.post(id,IdEmpleado,Sueldo,Dias,Comisiones);
                                nom.get();
                                Console.ReadKey();
                                break;

                            case 4:

                                Console.WriteLine("Modificar Empleado ");
                                Console.Write("Introduzca Id: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Introduzca Id empleado: ");
                                IdEmpleado = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Introduzca sueldo: ");
                                Sueldo = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Introduzca la cantidad de dias: ");
                                Dias = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Introduzca Comisiones: ");
                                Comisiones = Convert.ToInt32(Console.ReadLine());
                              

                                nom.LlenarLista();
                                nom.update(id, IdEmpleado,Sueldo, Dias, Comisiones);
                                nom.get();




                                Console.ReadKey();


                                break;

                            case 5:

                                Console.WriteLine("Eliminar nomina: ");
                                Console.Write("Introduzca Id: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                nom.LlenarLista();
                                nom.DeletexId(id);
                                nom.get();
                                Console.ReadKey();


                                break;

                        }
                        #endregion Crud nomina
                        break;



                }
            } while (opc != 4);
        }
    }
}
