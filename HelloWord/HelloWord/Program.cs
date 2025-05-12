using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("====================================");
                Console.WriteLine("\tElige que datos quieres ver:\n");
                Console.WriteLine("1.- Tipos de datos");
                Console.WriteLine("2.- Conversion de Datos");
                Console.WriteLine("3.- Methods");
                Console.WriteLine("4.- Salida:");
                Console.WriteLine("Elige que opción:");
                int opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("====================================");
                switch (opcion)
                {
                    case 1:
                        new TypesData().TypeData();
                        Console.WriteLine("====================================");
                        break;
                    case 2:
                        new Convertions().ConvertionData();
                        Console.WriteLine("====================================");
                        break;
                    case 3:
                        new Methods().WriteSomething();
                        new Methods().WriteSomething1("Hola");
                        new Methods().WriteSomething2();
                        new Methods().WriteSomething3(2);
                        new Methods().UseTryCatch();

                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

            }

        }
    }
}
