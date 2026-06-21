
using System;

class Program
{
    static void Main()
    {
        Agenda agenda = new Agenda();

        int opcion;

        do
        {
            Console.WriteLine("\n===== AGENDA TELEFÓNICA =====");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Mostrar contactos");
            Console.WriteLine("3. Buscar contacto");
            Console.WriteLine("4. Modificar contacto");
            Console.WriteLine("5. Eliminar contacto");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    agenda.Agregar();
                    break;

                case 2:
                    agenda.Mostrar();
                    break;

                case 3:
                    agenda.Buscar();
                    break;

                case 4:
                    agenda.Modificar();
                    break;

                case 5:
                    agenda.Eliminar();
                    break;

                case 6:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 6);
    }
}