using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Seleccione una opción");
                Console.WriteLine("1. Rectángulo");
                Console.WriteLine("2. Triángulo");
                Console.WriteLine("3. Año Bisiesto");
                Console.WriteLine("4. Calculadora");
                Console.WriteLine("5. Salir");
                Console.Write("Elige una opción: ");

                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.Write("Ingrese la base del rectángulo: ");
                    float b = float.Parse(Console.ReadLine());

                    Console.Write("Ingrese la altura del rectángulo: ");
                    float h = float.Parse(Console.ReadLine());

                    Rectangulo rect = new Rectangulo(b, h);
                    Console.WriteLine($"Área del rectángulo es {rect.CalcularArea()}");
                    Rectangulo rect2 = new Rectangulo(b, h);
                    Console.WriteLine($"Perimetro del rectángulo es {rect.CalcularPerimetro()}");
                }
                else if (opcion == "2")
                {
                    Console.Write("Ingrese la base del triángulo: ");
                    float b = float.Parse(Console.ReadLine());

                    Console.Write("Ingrese la altura del triángulo: ");
                    float h = float.Parse(Console.ReadLine());

                    Triangulo tri = new Triangulo(b, h);
                    Console.WriteLine($"Área del triángulo es {tri.CalcularArea()}");
                }
                else if (opcion == "3")
                {
                    Console.Write("Ingrese el año: ");
                    int año = int.Parse(Console.ReadLine());
                    Año Bisiesto = new Año();
                    if (Bisiesto.EsBisiesto(año))
                        Console.WriteLine("Es bisiesto");
                    else
                        Console.WriteLine("No es bisiesto");
                }
                else if (opcion == "4")
                {
                    Calculadora calc = new Calculadora();
                    string continuar = "s";

                    while (continuar == "s")
                    {
                        Console.Write("Primer número: ");
                        int n1 = int.Parse(Console.ReadLine());

                        Console.Write("Segundo número: ");
                        int n2 = int.Parse(Console.ReadLine());

                        Console.Write("Operación (+, -, *, /, %): ");
                        string op = Console.ReadLine();

                        Console.WriteLine("Resultado: " + calc.Operar(n1, n2, op));

                        Console.Write("¿Desea seguir usando la calculadora? (s/n): ");
                        continuar = Console.ReadLine().ToLower();
                    }
                }
                else if (opcion == "6")
                {
                    Console.WriteLine("¡Gracias por usar!");
                    break;
                }
                    
                }
            }
        }
    } 
