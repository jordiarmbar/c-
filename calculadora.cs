using System;

class Calculadora
{
    static void Main()
    {
        int numero1 = 0;
        bool valido1 = false;

        while (!valido1)
        {
            Console.Write("Escriba el primer número: ");
            string entrada = Console.ReadLine();
            valido1 = int.TryParse(entrada, out numero1);

            if (!valido1)
            {
                Console.WriteLine("Eso no es un número válido. Intenta otra vez.");
            }
        }

        int numero2 = 0;
        bool valido2 = false;

        while (!valido2)
        {
            Console.Write("Escriba el segundo número: ");
            string entrada = Console.ReadLine();
            valido2 = int.TryParse(entrada, out numero2);

            if (!valido2)
            {
                Console.WriteLine("Eso no es un número válido. Intenta otra vez.");
            }
        }

        int opcion = 0;

        do
        {
            Console.WriteLine("\n~~~ Menú de la Calculadora ~~~");
            Console.WriteLine("1.- Sumar");
            Console.WriteLine("2.- Restar");
            Console.WriteLine("3.- Multiplicar");
            Console.WriteLine("4.- Dividir");
            Console.WriteLine("5.- Potencia");
            Console.WriteLine("6.- Raíz Cuadrada");
            Console.WriteLine("7.- Salir");

            bool opcionValida = false;

            while (!opcionValida)
            {
                Console.Write("Selecciona una opción: ");
                string entradaOpcion = Console.ReadLine();
                opcionValida = int.TryParse(entradaOpcion, out opcion);

                if (!opcionValida || opcion < 1 || opcion > 7)
                {
                    Console.WriteLine("Opción inválida. Intenta otra vez.\n");
                    opcionValida = false;
                }
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Resultado: " + Sumar(numero1, numero2));
                    break;
                case 2:
                    Console.WriteLine("Resultado: " + Restar(numero1, numero2));
                    break;
                case 3:
                    Console.WriteLine("Resultado: " + Multiplicacion(numero1, numero2));
                    break;
                case 4:
                    double resultado = Division(numero1, numero2);
                    if (!double.IsNaN(resultado))
                        Console.WriteLine("Resultado: " + resultado);
                    break;
                case 5:
                    Console.WriteLine("Resultado: " + Potencia(numero1, numero2));
                    break;
                case 6:
                    double resultadoRaiz = RaizCuadrada(numero1);
                    if (!double.IsNaN(resultadoRaiz))
                        Console.WriteLine("La Raíz Cuadrada es: " + resultadoRaiz);
                    break;
                case 7:
                    Console.WriteLine("Saliendo...");
                    break;
            }

        } while (opcion != 7);
    }

    public static int Sumar(int numero1, int numero2)
    {
        return numero1 + numero2;
    }

    public static int Restar(int numero1, int numero2)
    {
        return numero1 - numero2;
    }

    public static int Multiplicacion(int numero1, int numero2)
    {
        return numero1 * numero2;
    }

    public static double Division(int numero1, int numero2)
    {
        if (numero2 == 0)
        {
            Console.WriteLine("No se puede dividir entre cero.");
            return double.NaN;
        }
        return (double)numero1 / numero2;
    }

    public static double Potencia(int numero1, int numero2)
    {
        return Math.Pow(numero1, numero2);
    }

    public static double RaizCuadrada(int numero1)
    {
        if (numero1 < 0)
        {
            Console.WriteLine("No se puede calcular la raíz cuadrada de un número negativo.");
            return double.NaN;
        }
        return Math.Sqrt(numero1);
    }
}
