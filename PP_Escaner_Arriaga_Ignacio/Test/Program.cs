
using Entidades;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro(1954, "J.R.R. Tolkien", "ISBN-13: 978-84-206-6066-8", "9788420660668", "El Señor de los Anillos", 200);

            Console.WriteLine($"Título: {libro.Titulo}");
            Console.WriteLine($"Autor: {libro.Autor}");
            Console.WriteLine($"Año: {libro.Anio}");
            Console.WriteLine($"Número normalizado: {libro.NumNormalizado}");
            Console.WriteLine($"Barcode: {libro.Barcode}");
            Console.WriteLine($"Estado: {libro.Estado}");

            libro.AvanzarEstado();
            Console.WriteLine($"Estado después de avanzar: {libro.Estado}");

        }
    }
}
