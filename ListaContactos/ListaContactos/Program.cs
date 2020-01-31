using System;

namespace ListaContactos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contactos = new string[16];
            int opcion, opcionList, x = 0, z = 0;
            while (x == 0)
            {
                Console.WriteLine("****************************CONTACTOS************************** \n" +
                    "PARA AGREGAR[1] BORRAR[2] LISTAR[3] EDITAR[4]");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                // Bloque de codigo para agregar los poductos
                if (opcion == 1)
                {
                    Console.WriteLine("********LISTA DE CONTACTOS********");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.Write(i + ". ");
                            contactos[i] = new string(Console.ReadLine());
                        }
                        Console.Clear();       
                }
                //Bloque para eliminar productos.
                if (opcion == 2)
                {

                    Console.WriteLine("********LISTA DE CONTACTOS********");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine(i + ". " + contactos[i]);
                    }
                    Console.WriteLine("Escribe el numero del contacto que desea borrar");
                    z = Convert.ToInt32(Console.ReadLine());
                    contactos[z] = "";
                }


                // La linea de codigo siguiente sirve para listar contacto.
                if (opcion == 3)
                {
                    Console.WriteLine("********LISTA DE CONTACTOS********");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine(i + ". " + contactos[i]);
                    }
                }
                //Bloque para editar.
                if (opcion == 4)
                {
                            Console.WriteLine("********LISTA DE CONTACTOS********");
                            for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(i + ". " + contactos[i]);
                        }
                        Console.WriteLine("Escribe el numero del contacto que desea EDITAR");
                        z = Convert.ToInt32(Console.ReadLine());
                        contactos[z] = Console.ReadLine();
                    Console.Clear();
                   
                 }                
            }
        }
    }
}
