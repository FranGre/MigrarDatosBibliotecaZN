using System;

namespace MigrarDatosBibliotecaZN.Utilidades
{
    internal class Consola
    {
        public static void Escribir(string mensaje, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(mensaje);
            Console.ResetColor();
        }

        public static void EscribirError(string mensaje)
        {
            Escribir(mensaje, ConsoleColor.Red);
        }

        public static void EscribirExito(string mensaje)
        {
            Escribir(mensaje, ConsoleColor.Green);
        }

        public static void EscribirWarning(string mensaje)
        {
            Escribir(mensaje, ConsoleColor.DarkYellow);
        }
    }
}