using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            string opcion2;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos numeros");
                Console.WriteLine("[2] Imprmir la raiz cuadrada de los 10 primeros numeros enteros");
                Console.WriteLine("[3] Resta de dos numeros");
                Console.WriteLine("[4] Multiplicacion de dos numeros");
                Console.WriteLine("[5] Division de dos numeros");
                Console.WriteLine("[6] Imprimir los 10 primeros numeros primos");
                Console.WriteLine("[7] Conversion de Temperatura");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opcion y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer numero");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando....");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer numero");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c,d));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer numero");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicacion de {0} y {1} es {2}", e, f, Multíplicacion(e, f));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer numero");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La division de {0} y {1} es {2}", g, h, Division(g, h));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Calculando....");
                 
                        Console.ReadKey();
                        break;
                    case "7":
                        do 
                        {
                            Console.Clear();
                            Console.WriteLine("[1] C");
                            Console.WriteLine("[2] F");
                            Console.WriteLine("[0] Salir");
                            Console.WriteLine("Ingrese una opcion y presione ENTER");
                            opcion2 = Console.ReadLine();
                            switch (opcion2)
                            {
                                case "1":
                                    Console.WriteLine("Ingrese el numero a convertir");
                                    int x = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("La conversion de {0} es {1}", x, CTemperatura(x));
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.WriteLine("Calculando....");
                                    Raiz();
                                    Console.ReadKey();
                                    break;
                            }
                        } while (!opcion.Equals("0"));
                }
            } while (!opcion.Equals("0"));
        }

        static int Suma(int a, int b)
        {
            return a + b;

        }
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raiz cuadrada de {0} es:{1} ", i, Math.Sqrt(i));
            }
        }

        static int Resta(int c, int d) 
        { 
            return c - d;
        }

        static int Multíplicacion(int e, int f)
        {
            return e*f;
        }

        static int Division(int g, int h)
        {
            return g/h;
        }

        static void CTemperatura(int x)
        {
            return (x);
        }

        
    }
}
