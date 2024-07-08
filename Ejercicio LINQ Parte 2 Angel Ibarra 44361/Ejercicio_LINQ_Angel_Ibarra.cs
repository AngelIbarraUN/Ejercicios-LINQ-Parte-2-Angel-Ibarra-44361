using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_LINQ_Angel_Ibarra
{
    public class Perro
    {
        public string Nombre { get; set; }

        public string Raza { get; set; }

        public int Edad { get; set; }

        public DateTime FechadeNacimiento { get; set; }

        public int Peso { get; set; }

        public int IdDueño { get; set; }

    }

    public class Dueño
    {
        public int IdDueño { get; set; }

        public string Nombre { get; set; }
    }
}
