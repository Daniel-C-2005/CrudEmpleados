using ConsoleApp1.Clases;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string databasePath = "C:\\tmp\\BaseData.db";

           
            GestorEmpleados gestorEmpleados = new GestorEmpleados(databasePath);

          
            gestorEmpleados.CrearTabla();

           
            Empleado empleado1 = new Empleado(1, "Nixon", "Pérez", 30, "Gerente",15000);
            Empleado empleado2 = new Empleado(2, "Gimena", "Medrano", 25, "Analista", 5000);

           
            gestorEmpleados.AgregarEmpleado(empleado1);
            gestorEmpleados.AgregarEmpleado(empleado2);



            List<Empleado> empleados = gestorEmpleados.ObtenerEmpleados();

          
            
            gestorEmpleados.ObtenerEmpleados().ForEach(e => Console.WriteLine("nombre "+ " "+ e.Nombre+ " " + "apellido" + " " + e.Apellido+" "+"edad"+ " " + e.Edad+" "+"puesto"+ " " + e.Cargo+" "+"sueldo"+ " " + e.sueldo));
        }
    }
}