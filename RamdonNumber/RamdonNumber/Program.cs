using System;

namespace RamdonNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
                while (x == 0)
                {
                Random rnd = new Random();
                int num = rnd.Next(1, 100), adiv = 0;
                for (int i = 10; i >= 0; i--)
                {
                    Console.WriteLine("************ADIVINA EL NUMERO OCULTO DEL 1-100************");
                    Console.WriteLine("Tienes " + i + " oportunidades.");
                    adiv = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (adiv <= num + 5 && adiv >= num - 5)
                    {
                        Console.WriteLine("Estas muy caliente, sigue intentando.");
                    }
                    else if (adiv <= num + 10 && adiv >= num - 10)
                    {
                        Console.WriteLine("Estas caliente, sigue intentando.");
                    }
                    else if (adiv <= num + 20 && adiv >= num - 20)
                    {
                        Console.WriteLine("Te estas acercando, sigue intentando.");
                    }
                    else if (adiv <= num + 30 && adiv >= num - 30)
                    {
                        Console.WriteLine("Estas frio, pero sigue intentando.");
                    }
                    else if (adiv <= num + 50 && adiv >= num - 50)
                    {
                        Console.WriteLine("Estas muy frio,pero sigue intentando.");
                    }
                    if (adiv == num)
                    {
                        Console.WriteLine("###################################################################################################################### \n" +
                              "###################################################################################################################### \n" +
                              "###################################################################################################################### \n" +
                              "################################### EL NUMERO ERA " + num + " HAZ GANADOOOOOOOOOOOOOOOOO! ################################### \n" +
                              "###################################################################################################################### \n" +
                              "###################################################################################################################### \n" +
                              "###################################################################################################################### \n \n" +
                              "Si quieres seguir jugando escribe [0] si no escribe cualquier numero.");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    }
                }
                        Console.WriteLine("Y_Y --- Y_Y --- Y_Y --- Y_Y --- Y_Y EL NUMERO ERA " + num + " HAZ PERDIDO  --- Y_Y --- Y_Y --- Y_Y --- Y_Y --- Y_Y \n \n" +
                                "Si quieres seguir jugando escribe [0] si no escribe cualquier numero.");
                        x = Convert.ToInt32(Console.ReadLine());
                       Console.Clear();

            }
            
        }
    }
}
