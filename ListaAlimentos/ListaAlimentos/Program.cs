using System;

namespace ListaAlimentos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frutas= new string[11], vegetales=new string[11], lacteos=new string[11]; 
            int opcion, opcionList,x=0,z=0;
            while (x == 0)
            {
                Console.WriteLine("                  LISTA ALIMENTOS \n" +
                    "PARA AGREGAR[1] BORRAR[2] LISTAR[3] EDITAR[4]");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                // Bloque de codigo para agregar los poductos
                if (opcion == 1)
                {
                    Console.WriteLine("Seleccione la lista a la que desea agregar \n" +
                    " Frutas[1] Vegetales[2] Lacteos[3]");
                    opcionList = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (opcionList == 1)
                    {
                        Console.WriteLine("                  LISTA FRUTAS \n");
                        for(int i = 1; i <= 10; i++)
                        {                          
                            Console.Write(i + ". "); 
                            frutas[i]= new string (Console.ReadLine());
                        }
                        Console.Clear();
                    }
                    if (opcionList == 2)
                    {
                        Console.WriteLine("                  LISTA VEGETALES \n");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.Write(i + ". ");
                            vegetales[i] = new string(Console.ReadLine());
                        }
                        Console.Clear();
                    }
                    if (opcionList == 3)
                    {
                        Console.WriteLine("                  LISTA LACTEOS \n");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.Write(i + ". ");
                            lacteos[i] = new string(Console.ReadLine());
                        }
                        Console.Clear();
                    }
                }
                //Bloque para eliminar productos.
                if (opcion == 2)
                {
                    Console.WriteLine("Seleccione la lista de la que desea borrar \n" +
                     " Frutas[1] Vegetales[2] Lacteos[3]");
                    opcionList = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (opcionList == 1)
                    {
                        Console.WriteLine("                  LISTA FRUTAS \n");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(i + ". " + frutas[i]);
                        }
                        Console.WriteLine("Escribe el numero del alimento que desea borrar");
                        z = Convert.ToInt32(Console.ReadLine());
                        frutas[z] = "";
                       
                    }
                    if (opcionList == 2)
                    {
                        Console.WriteLine("                  LISTA VEGETALES \n");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(i + ". " + vegetales[i]);
                        }
                        Console.WriteLine("Escribe el numero del alimento que desea borrar");
                        z = Convert.ToInt32(Console.ReadLine());
                        vegetales[z] = "";
                        
                    }
                    if (opcionList == 3)
                    {
                        Console.WriteLine("                  LISTA LACTEOS \n");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(i + ". " + lacteos[i]);
                        }
                        Console.WriteLine("Escribe el numero del alimento que desea borrar");
                        z = Convert.ToInt32(Console.ReadLine());
                        lacteos[z] = "";
                      
                    }
                }
                // La linea de codigo siguiente sirve para listar cada producto.
                if (opcion == 3)
                {
                    Console.WriteLine("Seleccione la lista a la que desea mostrar \n" +
                   " Frutas[1] Vegetales[2] Lacteos[3] TODOS[4]");
                    opcionList = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (opcionList == 1)
                    {
                        Console.WriteLine("                  LISTA FRUTAS \n");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(i + ". " + frutas[i]);
                        }
                    }
                    if (opcionList == 2)
                    {
                        Console.WriteLine("                  LISTA VEGETALES \n");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(i + ". " + vegetales[i]);
                        }
                    }
                    if (opcionList == 3)
                    {
                        Console.WriteLine("                  LISTA LACTEOS \n");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(i + ". " + lacteos[i]);
                        }
                    }
                    if (opcionList == 4) // Imprime todas las listas
                    {
                        Console.WriteLine("                  LISTA FRUTAS \n");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(i + ". " + frutas[i]);
                        }
                        Console.WriteLine("                  LISTA VEGETALES \n");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(i + ". " + vegetales[i]);
                        }
                        Console.WriteLine("                  LISTA LACTEOS \n");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(i + ". " + lacteos[i]);
                        }
                    }
                }
                //Bloque para editar.
                if (opcion == 4)
                {
                    Console.WriteLine("Seleccione la lista de la que desea EDITAR \n" +
                     " Frutas[1] Vegetales[2] Lacteos[3]");
                    opcionList = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (opcionList == 1)
                    {
                        Console.WriteLine("                  LISTA FRUTAS \n");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(i + ". " + frutas[i]);
                        }
                        Console.WriteLine("Escribe el numero del alimento que desea EDITAR");
                        z = Convert.ToInt32(Console.ReadLine());
                        frutas[z] =Console.ReadLine();
                    }
                    if (opcionList == 2)
                    {
                        Console.WriteLine("                  LISTA VEGETALES \n");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(i + ". " + vegetales[i]);
                        }
                        Console.WriteLine("Escribe el numero del alimento que desea EDITAR");
                        z = Convert.ToInt32(Console.ReadLine());
                        vegetales[z] = Console.ReadLine();
                    }
                    if (opcionList == 3)
                    {
                        Console.WriteLine("                  LISTA LACTEOS \n");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(i + ". " + lacteos[i]);
                        }
                        Console.WriteLine("Escribe el numero del alimento que desea EDITAR");
                        z = Convert.ToInt32(Console.ReadLine());
                        lacteos[z] = Console.ReadLine();
                    }
                }
            }

        }
    }
}
