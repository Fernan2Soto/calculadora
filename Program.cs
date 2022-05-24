using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaDeCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;

            menu();
            op = opcion(8);
            Console.Clear();
            switch (op)
            {
                case 0:
                    Console.WriteLine("SUMA");
                    int n1 = validacion("N1");
                    int n2 = validacion("n2");
                    int resultado = calculos.suma(n1, n2);
                    Console.WriteLine(+n1 +" + "+ n2 + " = "+resultado);
                    break;
                case 1:
                    Console.WriteLine("RESTA");
                    n1 = validacion("N1");
                    n2 = validacion("n2");
                    resultado = calculos.resta(n1, n2);
                    Console.WriteLine(+n1 + " - " + n2 + " = " + resultado);
                    break;
                case 2:
                    Console.WriteLine("DIVICION");
                    n1 = validacion("N1");
                    n2 = validacion("n2");
                    double res = calculos.div(n1, n2);
                    Console.WriteLine(+n1 + " / " + n2 + " = " + res);
                    break;
                case 3:
                    Console.WriteLine("MULTIPLICACION");
                    n1 = validacion("N1");
                    n2 = validacion("n2");
                    resultado = calculos.mult(n1, n2);
                    Console.WriteLine(+n1 + " x " + n2 + " = " + resultado);
                    break;
                case 4:
                    Console.WriteLine("EXPONENCIAL");
                    n1 = validacion("N1");
                    n2 = validacion("n2");
                    resultado = calculos.expo(n1, n2);
                    Console.WriteLine(+n1 + " ^ " + n2 + " = " + resultado);
                    break;
                case 5:
                    MenuCalArea();
                    op = opcion(3);
                    switch (op)
                    {
                        case 0:
                            Console.WriteLine("AREA CUADRADO / RECTANGULO");
                            n1 = validacion("N1");
                            n2 = validacion("n2");
                            resultado = calculos.mult(n1, n2);
                            Console.WriteLine( "base "+n1 + " *  altura" + n2 + " = " + resultado);
                            break;
                        case 1:
                            Console.WriteLine("AREA TRIANGULO");
                            n1 = validacion("N1");
                            n2 = validacion("n2");
                            resultado = calculos.mult(n1, n2);
                            Console.WriteLine("base " + n1 + " *  altura" + n2 + " / 2 = " + resultado);
                            break;
                        case 2:
                            Console.WriteLine("AREA CIRCULO");
                            n1 = validacion("N1");
                            res = calculos.areaCir(n1);
                            Console.WriteLine("radio " + n1 + " * " + n1 + "/ 3.14 = " + res);
                            break;
                        default:
                            break;
                    }
                    break;
                case 6:
                    MenuCalPerimetro();
                    op = opcion(4);
                    switch (op)
                    {
                        case 0:
                            Console.WriteLine("Perimetro Cuadrado / Rombo");
                            n1 = validacion("N1");
                            resultado = calculos.periCuadrado(n1);
                            Console.WriteLine("Perimetro " + n1 + "  = " + resultado);
                            break;
                        case 1:
                            Console.WriteLine("Perimetro de un triangulo");
                            n1 = validacion("N1");
                            n2 = validacion("n2");
                            int n3 = validacion("n3");
                            resultado = calculos.periTri(n1, n2 ,n3);
                            Console.WriteLine("suma de todos sus lados " + n1+ " + " + n2 +" + "+ n3 + " = " + resultado);
                            break;
                        case 2:
                            Console.WriteLine("Perimetro Rectangulo / Romboide");
                            n1 = validacion("N1");
                            n2 = validacion("N2");
                            resultado = calculos.periRect(n1 , n2);
                            Console.WriteLine("Perimetro  = " + resultado);
                            break;
                        case 3:
                            Console.WriteLine("Trapecio");
                            n1 = validacion("N1");
                            n2 = validacion("N2");
                            n3 = validacion("N3");
                            int n4 = validacion("N4");
                            resultado = calculos.periTrap(n1,n2,n3,n4);
                            Console.WriteLine("Perimetro   = " + resultado);
                            break;
                        default: Console.WriteLine("opcion invalida");
                            break;
                    }
                    break;
                case 7:
                    Console.WriteLine("RADIO");
                    n1 = validacion("N1");
                    res = calculos.radio(n1);
                    Console.WriteLine("Radio  = " + res);
                    break;
                default: Console.WriteLine("opcion invalida");
                    break;
            }

            Console.ReadKey();
        }

        static int validacion(string txt) {
            int num;
            bool val = false;
            do
            {
                Console.WriteLine("ingrese primer numero {0}",txt);
                val = int.TryParse(Console.ReadLine(), out num);
                if (num < 0)
                {
                    val = false;
                }

            } while (!val);
            return num;
        }
        static int opcion(int txt) {
            int num;
            bool val = false;
            do
            {
                Console.WriteLine("SELECCIONES UNA OPCION VALIDA", txt);
                val = int.TryParse(Console.ReadLine(), out num);
                if (num < 0 || num >= txt)
                {
                    val = false;
                    Console.Clear();
                    menu();
                }

            } while (!val);
            return num;
        }

        static void menu()
        {
            Console.WriteLine("SELECCIONE UNA OPCION INGRESANDO UN NUMERO:");
            Console.WriteLine("0 => Suma");
            Console.WriteLine("1 => Resta");
            Console.WriteLine("2 => Divicion");
            Console.WriteLine("3 => Multiplicacion");
            Console.WriteLine("4 => Exponencial");
            Console.WriteLine("5 => Calcular Area");
            Console.WriteLine("6 => Calcular perimetro");
            Console.WriteLine("7 => Calcular radio");

        }

        static void MenuCalArea()
        {
            Console.WriteLine("ELIJA QUE AREA CALCULAR");
            Console.WriteLine("0 => Cuadrado / Rectangulo");
            Console.WriteLine("1 => Triangulo");
            Console.WriteLine("2 => Circulo");
        }
        static void MenuCalPerimetro()
        {
            Console.WriteLine("ELIJA QUE PERIMETRO CALCULAR");
            Console.WriteLine("0 => Cuadrado / Rombo");
            Console.WriteLine("1 => Triangulo");
            Console.WriteLine("2 => Rectangulo / Romboide");
            Console.WriteLine("3 => Trapecio");
        }
    }
}
