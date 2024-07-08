
using Ejercicio_LINQ_Angel_Ibarra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {

    var perros = new List<Perro>
   {
    new Perro { Nombre = "Junior", Raza = "Chihuahua", Edad= 3,FechadeNacimiento = new DateTime(2021,9,22), Peso = 4 ,IdDueño=1},
    new Perro { Nombre = "Nacho", Raza = "Golden Retriever", Edad=6, FechadeNacimiento = new DateTime(2018,3,22), Peso = 29 ,IdDueño=2},
    new Perro { Nombre = "Negro", Raza = "Pastor Alemán", Edad=5, FechadeNacimiento = new DateTime(2019,10,3), Peso = 32,IdDueño=3},
    new Perro { Nombre = "Cooper", Raza = "Poodle", Edad=8, FechadeNacimiento = new DateTime(2016,11,5), Peso = 9,IdDueño=4},
    new Perro { Nombre = "Firulais", Raza = "Doberman", Edad=4, FechadeNacimiento = new DateTime(2020,12,4), Peso = 35,IdDueño=5},
    new Perro { Nombre = "Choco", Raza = "Labrador", Edad=7, FechadeNacimiento = new DateTime(2017,12,22), Peso = 31}
  };

        /*11.LINQ-Thenby & ThenByDescending
        var perrosordenadospornombreyraza = perros.OrderBy(p => p.Nombre).ThenByDescending(p => p.Raza);

        foreach (var perro in perrosordenadospornombreyraza)
        {
            Console.WriteLine($"{perro.Nombre} es de la raza {perro.Raza}");
        }
        */

        /*13.LINQ-Select
        var razadePerro = perros.Select(p => p.Raza).ToList();
        foreach (var raza in razadePerro)
        {
            Console.WriteLine(raza);
        }
        */
        /*14.LINQ-Count/LongCount

        Console.WriteLine("La cantidad de perros son: " + perros.Count());
        */

        /*15.LINQ-Suma/Máximo/Mínimo

        Console.WriteLine("La suma del peso de los perros es: " + (perros.Sum(p=>p.Peso)));

        Console.WriteLine("El peso máximo de los perros es: " + (perros.Max(p => p.Peso)));

        Console.WriteLine("El peso mínimo de los perros es: " + (perros.Min(p => p.Peso)));
         */

        /*19 LINQ-Aggregate
        var numeros = Enumerable.Range(1, 10);
        var resultadoNumero = numeros.Aggregate((a, b) => a * b);
        Console.WriteLine("El resultado es: " + resultadoNumero); 
        */
        /*21 LINQ-Contains

        var numeros = Enumerable.Range(1, 20);

        var numero1 = numeros.Contains(15);

        var numero2 = numeros.Contains(25);

        Console.WriteLine("¿El número 15 se encuentra dentro del rango? " + numero1);

        Console.WriteLine("¿El número 25 se encuentra dentro del rango? " + numero2); */

        /*22.LINQ-Any

        var existePesoMenora2 = perros.Any(p => p.Peso < 2);

        var existePesoMayora40 = perros.Any(p => p.Peso > 40);

        Console.WriteLine("¿Hay un perro con peso menor a 2? " + existePesoMenora2);

        Console.WriteLine("¿Hay un perro con peso mayor a 40? " + existePesoMayora40);*/

        /*27.LINQ-GroupBy

        var perrosagrupadosporRaza = perros.GroupBy(p => p.Raza);

        foreach(var grupoperro in perrosagrupadosporRaza)
        {
            Console.WriteLine($"Raza de perro: {grupoperro.Key}");
            foreach(var perrito in grupoperro)
            {
                Console.WriteLine($"- {perrito.Nombre}");
            }
        }

        /*29.LINQ-Join

        var Dueños = new List<Dueño>()
        {
            new Dueño{IdDueño=1,Nombre="Miguel Antonio Ruiz Torres"},
            new Dueño{IdDueño=2,Nombre="Javier Cruz de León"},
            new Dueño{IdDueño=3,Nombre="Laura Tovar Mireles"},
            new Dueño{IdDueño=4,Nombre="Angel Javier Ibarra Rico"},
            new Dueño{IdDueño=5,Nombre="Karla Rodríguez Santos"},
            new Dueño{IdDueño=6,Nombre="Luis Maldonado Aguilar"},
        };
        
         var perrosyDueños = perros.Join(Dueños, p => p.IdDueño, a => a.IdDueño, (perrito, dueñodeperro) => new
         {
             Perro = perrito,
             Dueño = dueñodeperro
         });
         
         foreach (var perydueñ in perrosyDueños)
         {
             Console.WriteLine($"{ perydueñ.Dueño.Nombre} es dueño de {perydueñ.Perro.Nombre}");
         }

        /*30.LINQ-GroupJoin
        var perrosyDueños2 = perros.GroupJoin(Dueños, p => p.IdDueño, a => a.IdDueño, (perrito, dueñodeperro) => new
        {
            Perro = perrito,
            Dueño = dueñodeperro
        });
        foreach (var perrosdueño in perrosyDueños2)
        {
            Console.WriteLine($"Los siguientes perros cuentan con un dueño: ");
            foreach(var perro in perrosdueño.Perro)
            {
                Console.WriteLine($"-{perros.Nombre}");  
            }
        }*/

        /*31.LINQ-Distinct & DistinctBy

        int[] numerorep = { 3, 2, 4, 5, 3, 2, 1 };

        var numerosrepetidos = numerorep.Distinct();

        foreach (var numeros in numerosrepetidos)
        {
            Console.WriteLine(numeros);
        }

        /*32-LINQ-Union & UnionBy

        int[] numeros1={ 2, 3, 1, 5, 7, 12, 1 };
        int[] numeros2d = { 4, 22, 10, 9, 2, 9, 1 };

        var uniondeNumeros = numeros1.Union(numeros2);
        
        foreach (var numeros in uniondeNumeros)
        {
            Console.WriteLine(numeros);
        }
        
        /*35.LINQ-Concat*/
        int[] numeros3 = { 20, 8, 3, 1, 0, 18, 11 };
        int[] numeros4 = { 7, 1, 5, 6, 3, 2, 12 };

        var resultadoConcat = numeros3.Concat(numeros4);
        foreach (var numero in resultadoConcat)
        {
            Console.WriteLine(numero);
        }
    }
}