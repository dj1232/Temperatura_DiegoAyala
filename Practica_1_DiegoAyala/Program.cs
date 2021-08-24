using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_DiegoAyala
{
    class Program
    {
        //Prototipo del Procedimiento Farenheit
        static void Faren()
        {
            Double cel, far;
            //Aparece en pantalla
            Console.Write("Ingrese los grados Celsius: ");

            //Lectura y conversion a double
            cel = Convert.ToDouble(Console.ReadLine());
            //Proceso de conversion
            far = cel * 9.0 / 5.0 + 32;

            //Impresion de datos
            Console.WriteLine("Los {0} grados Celsius son equivalentes a {1} grados Fahrenheit", cel, far);
        }//fin proceso farenheit

        static void Celsi()
        {
            Double cel, far;
            //Aparece en Pantalla
            Console.Write("Ingrese los grados Fahrenheit: ");

            //Lectura y conversion a double
            far = Convert.ToDouble(Console.ReadLine());
            //Proceso de Conversion
            cel = (far - 32) * 5.0 / 9.0;

            //Impresion de datos
            Console.WriteLine("Los {0} grados Fahrenheit son equivalentes a {1} grados Celsius", far, cel); 
        }//fin proceso fahrenheit

        static void Kel()
        {
            Double kel, cel;
            //Aparece en pantalla
            Console.Write("Ingrese los grados Celsius: ");

            //Lectura y conversion a Double
            cel = Convert.ToDouble(Console.ReadLine());
            //proceso de conversion
            kel = cel + 273.15;

            //Impresion de datos
            Console.WriteLine("Los {0} grados celsius son equivalentes a {1} grados Kelvin", cel, kel);
        }
        static void Main(string[] args)
        {
            string opc;
            Int16 repetir = 1 ;

            do
            {
                Console.Clear();
                Console.WriteLine("\t \t PROGRAMA PARA CONVERTIR TEMPERATURAS");
                Console.WriteLine("\nElige el tipo de conversion");
                Console.WriteLine("\n\nPresione F si quiere convertir Celsius a Fahrenheit");
                Console.WriteLine("Presione C si quiere convertir Fahrenheit a Celsius");
                Console.WriteLine("Presione K si quiere convertir Celsius a Kelvin");
                Console.WriteLine("\nEscoja F , C ó K: ");

                //Ingreso de datos
                opc = Console.ReadLine();
                opc = opc.ToUpper();

                switch (opc)
                {

                    case "F":
                        Console.WriteLine("\n Conversion a F");
                        //llamando al metodo
                        Faren();
                        Console.ReadKey();
                        Console.WriteLine("Desea volver al menú principal? (1-si / 2-no)");
                        repetir = Convert.ToInt16(Console.ReadLine());
                        while (repetir != 1 & repetir != 2)
                        {
                            Console.WriteLine("Ingrese valores aceptables (1-si / 2-no)");
                            repetir = Convert.ToInt16(Console.ReadLine());
                        }
                        break;

                    case "C":
                        Console.WriteLine("\n Conversion a C");
                        //llamndo al metodo
                        Celsi();
                        Console.ReadKey();
                        Console.WriteLine("Desea volver al menú principal? (1-si / 2-no)");
                        repetir = Convert.ToInt16(Console.ReadLine());
                        while (repetir != 1 & repetir != 2)
                        {
                            Console.WriteLine("Ingrese valores aceptables (1-si / 2-no)");
                            repetir = Convert.ToInt16(Console.ReadLine());
                        }
                        break;

                    case "K":
                        Console.WriteLine("\n Conversion a K");
                        //llamndo al metodo
                        Kel();
                        Console.ReadKey();
                        Console.WriteLine("Desea volver al menú principal? (1-si / 2-no)");
                        repetir = Convert.ToInt16(Console.ReadLine());
                        while (repetir != 1 & repetir != 2)
                        {
                            Console.WriteLine("Ingrese valores aceptables (1-si / 2-no)");
                            repetir = Convert.ToInt16(Console.ReadLine());
                        }
                        break;

                    default:
                        Console.WriteLine("\n Tipo de conversion no válida");
                        break;

                }
            } while (repetir == 1);
            //espera de una tecla
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Saliendo del Programa, Pase buen día...");
            Console.ReadKey();
        }
    }
}
