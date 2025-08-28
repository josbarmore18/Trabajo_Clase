using System;
using Garaje.Clases; // Agrega esta línea para importar la carpeta Clases

namespace Garaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ahora se puede usar 'Garaje' sin conflicto
            Clases.Garaje miGaraje = new Clases.Garaje(1, "Garaje Principal", 50, 20);

            Console.WriteLine($"Número de garaje: {miGaraje.numeroGaraje}");
            Console.WriteLine($"Descripción: {miGaraje.descripcion}");
            Console.WriteLine($"Capacidad total: {miGaraje.capacidadEspacios}");
            Console.WriteLine($"Espacios ocupados: {miGaraje.espaciosOcupados}");

            // Muestra los espacios disponibles
            Console.WriteLine($"\nEspacios disponibles: {miGaraje.getEspaciosDisponibles()}");

            // Actualiza los espacios ocupados
            int espaciosASolicitar = 5;
            Console.WriteLine($"\nSolicitando {espaciosASolicitar} nuevos espacios...");
            miGaraje.setEspaciosOcupados(espaciosASolicitar);

            // Vuelve a mostrar los espacios ocupados y disponibles
            Console.WriteLine($"\nEspacios ocupados ahora: {miGaraje.espaciosOcupados}");
            Console.WriteLine($"Espacios disponibles ahora: {miGaraje.getEspaciosDisponibles()}");

            Console.ReadLine();
        }
    }
}