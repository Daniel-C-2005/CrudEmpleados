using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.Clases
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int Edad { get; set; }
        public string Cargo { get; set; }
        public int sueldo { get; set; }
       

        public Empleado(int id, string nombre, string apellido, int edad, string cargo, int sueldo)
        {
            Id = id;
            Nombre = nombre;
            this.Apellido = apellido;
            Edad = edad;
            Cargo = cargo;
            this.sueldo = sueldo;
        }
        public override string ToString()
        {
            return $"Id: {Id} Nombre: {Nombre} Apellido: {Apellido} Edad: {Edad} Cargo: {Cargo}";
        }
    }
}
