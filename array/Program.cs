using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Övning 1
            Console.WriteLine("Välkommen!");
            Console.WriteLine("Övning 1");
            string[] namn = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Mata in ett namn: ");
                namn[i] = Console.ReadLine();
            }
            Console.Write("Dina Vänner: ");
            for (int i = 0; i < namn.Length; i++)
            {
                Console.Write(namn [i] + ", ");
               
            }

            Console.ReadLine();

            //Övning 2

            Console.WriteLine("Övning 2");

            int[] siffror = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Mata in ett heltal: ");
                siffror[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Dina tal baklänges:  ");
            for (int x = 9; x >=0; x--)
            {
                Console.Write(siffror[x] + ", ");
            }

            Console.ReadLine();
            */
            //Övning 3

            Console.WriteLine("Övning 3");

            int[] numbArray = { 12, 5, 6, 1, 2, 3, -2, -7, 0 };

            for (int i = 0; i < numbArray.Length; i++)
            {
                for (int x = 0; x < numbArray.Length; x++)
                {
                    if (numbArray[i] < numbArray[x])
                    {
                        int temp = numbArray[x];
                        numbArray[x] = numbArray[i];
                        numbArray[i] = temp;

                    }
                }
                Console.WriteLine(numbArray[]);
            }

        








        }
    }
}
