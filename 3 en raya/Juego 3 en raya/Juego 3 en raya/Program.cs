using System;

class TresEnRaya
{
    static char[] tablero = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int jugadorActual = 1; // El jugador 1 empieza
    static int eleccion;
    static int estadoJuego = 0; // 0 = en curso, 1 = ganado, -1 = empate

    static void Main(string[] args)
    {
        do
        {
            Console.Clear();
            Console.WriteLine("¡Bienvenido al Tres en Raya!");
            Console.WriteLine("Jugador 1: X y Jugador 2: O");
            Console.WriteLine("\n");

            // Alternar entre jugadores
            if (jugadorActual % 2 == 1)
            {
                Console.WriteLine("Turno del Jugador 1");
            }
            else
            {
                Console.WriteLine("Turno del Jugador 2");
            }

            Console.WriteLine("\n");
            DibujarTablero();

            // Capturar la elección del jugador
            try
            {
                eleccion = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor, introduce un número.");
                Console.ReadLine();
                continue;
            }

            // Validar y marcar la casilla
            if (eleccion >= 1 && eleccion <= 9 && tablero[eleccion - 1] != 'X' && tablero[eleccion - 1] != 'O')
            {
                if (jugadorActual % 2 == 1)
                {
                    tablero[eleccion - 1] = 'X';
                    jugadorActual++;
                }
                else
                {
                    tablero[eleccion - 1] = 'O';
                    jugadorActual++;
                }
            }
            else
            {
                Console.WriteLine("Casilla inválida o ya ocupada. Presiona Enter para intentar de nuevo.");
                Console.ReadLine();
            }

            estadoJuego = ComprobarGanador();

        } while (estadoJuego == 0);

        Console.Clear();
        DibujarTablero();

        if (estadoJuego == 1)
        {
            Console.WriteLine("¡Felicidades, Jugador {0}, has ganado!", (jugadorActual % 2) + 1);
        }
        else
        {
            Console.WriteLine("¡Es un empate!");
        }

        Console.ReadLine();
    }

    // Dibuja el tablero de juego en la consola
    private static void DibujarTablero()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", tablero[0], tablero[1], tablero[2]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", tablero[3], tablero[4], tablero[5]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", tablero[6], tablero[7], tablero[8]);
        Console.WriteLine("     |     |      ");
    }

    // Comprueba si hay un ganador o si el juego ha terminado en empate
    private static int ComprobarGanador()
    {
        #region Comprobaciones de victoria
        // Horizontales
        if (tablero[0] == tablero[1] && tablero[1] == tablero[2]) return 1;
        if (tablero[3] == tablero[4] && tablero[4] == tablero[5]) return 1;
        if (tablero[6] == tablero[7] && tablero[7] == tablero[8]) return 1;

        // Verticales
        if (tablero[0] == tablero[3] && tablero[3] == tablero[6]) return 1;
        if (tablero[1] == tablero[4] && tablero[4] == tablero[7]) return 1;
        if (tablero[2] == tablero[5] && tablero[5] == tablero[8]) return 1;

        // Diagonales
        if (tablero[0] == tablero[4] && tablero[4] == tablero[8]) return 1;
        if (tablero[2] == tablero[4] && tablero[4] == tablero[6]) return 1;
        #endregion

        #region Comprobación de empate
        if (tablero[0] != '1' && tablero[1] != '2' && tablero[2] != '3' &&
            tablero[3] != '4' && tablero[4] != '5' && tablero[5] != '6' &&
            tablero[6] != '7' && tablero[7] != '8' && tablero[8] != '9')
        {
            return -1; // Empate
        }
        #endregion

        return 0; // Juego en curso
    }
}