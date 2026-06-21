using System;
using System.Collections.Generic;

public class Agenda
{
    private List<Contacto> contactos = new List<Contacto>();

    public void Agregar()
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Teléfono: ");
        string telefono = Console.ReadLine();

        Console.Write("Correo: ");
        string correo = Console.ReadLine();

        contactos.Add(new Contacto(nombre, telefono, correo));

        Console.WriteLine("Contacto agregado correctamente.");
    }

    public void Mostrar()
    {
        if (contactos.Count == 0)
        {
            Console.WriteLine("No existen contactos.");
            return;
        }

        foreach (Contacto c in contactos)
        {
            c.Mostrar();
            Console.WriteLine("------------------------");
        }
    }

    public void Buscar()
    {
        Console.Write("Nombre a buscar: ");
        string nombre = Console.ReadLine();

        foreach (Contacto c in contactos)
        {
            if (c.Nombre.ToLower() == nombre.ToLower())
            {
                c.Mostrar();
                return;
            }
        }

        Console.WriteLine("Contacto no encontrado.");
    }

    public void Modificar()
    {
        Console.Write("Nombre del contacto a modificar: ");
        string nombre = Console.ReadLine();

        foreach (Contacto c in contactos)
        {
            if (c.Nombre.ToLower() == nombre.ToLower())
            {
                Console.Write("Nuevo teléfono: ");
                c.Telefono = Console.ReadLine();

                Console.Write("Nuevo correo: ");
                c.Correo = Console.ReadLine();

                Console.WriteLine("Contacto actualizado.");
                return;
            }
        }

        Console.WriteLine("Contacto no encontrado.");
    }

    public void Eliminar()
    {
        Console.Write("Nombre del contacto a eliminar: ");
        string nombre = Console.ReadLine();

        for (int i = 0; i < contactos.Count; i++)
        {
            if (contactos[i].Nombre.ToLower() == nombre.ToLower())
            {
                contactos.RemoveAt(i);
                Console.WriteLine("Contacto eliminado.");
                return;
            }
        }

        Console.WriteLine("Contacto no encontrado.");
    }
}