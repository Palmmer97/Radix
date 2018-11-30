using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " THE RADIX";
           
            
        perro:
            Console.Clear();
            Console.WriteLine(@"Seleccione el ejercicio
1.- Ejercicio (1)
2.- Ejercicio (2)
3.- Ejercicio (3)
4.- Ejercicio (4)
5.- Ejercicio (5)
6.-Salir");
            int a = int.Parse(Console.ReadLine());
            
            Radix OBJ = new Radix();

            if (a == 1)
            {
                OBJ.INSERTAR(10, 1);
                OBJ.METODORADIX();
                Console.ReadKey();
                OBJ.MORTRAR();
                Console.WriteLine("Teclee cualquier tecla");
                Console.ReadKey();
                goto perro;
            }
            if (a == 2)
            {
                OBJ.INSERTAR(9, 2);
                OBJ.METODORADIX();
                Console.ReadKey();
                OBJ.MORTRAR();
                Console.WriteLine("Teclee cualquier tecla");
                Console.ReadKey();
                goto perro;
                
               
            }

            if (a == 3)
            {
                Console.WriteLine(@" No Logre hacer que me permitiera 
ingresar con valores negativos solo funciona 1,2,5");
                Console.ReadKey();
                goto perro;
            
            }

            if (a == 4)
            {
                Console.WriteLine(@" No Logre hacer que me permitiera 
ingresar con valores negativos solo funciona 1,2,5");
                Console.ReadKey();
                goto perro;
               
            }
            if (a == 5)
            {
                OBJ.INSERTAR(7, 5);
                OBJ.METODORADIX();
                Console.ReadKey();
                OBJ.MORTRAR();
                Console.WriteLine("Teclee cualquier tecla");
                Console.ReadKey();
                goto perro;  
               
            }

            if (a == 6)
            {

                Console.WriteLine("Teclee cualquier tecla");
                Console.Clear();
                
                

            }

        
       

           
            Console.ReadKey();
        }
    }
}
