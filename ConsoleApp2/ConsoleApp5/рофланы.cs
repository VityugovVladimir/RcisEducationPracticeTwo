using System;

namespace ConsoleApp5
{
    /* using System;
    class HelloWorld 
    {
        static void Main()
        {
            int ymnozenie = 0;
            int a = 1000;
            while (a >= 0)
            {
                a = a - 7;
                Console.WriteLine(a);
            }
            





        }
    }
  */

    /* class Program 
    {
        static void Main()
        {
            Console.WriteLine("Введите кол-во элементов массива: \t");
            int elements = int.Parse(Console.ReadLine());
            
            int[] array = new int [elements];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"элемент под индексом {i}");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(", ", array));
            
            
              
            


        }
    }
}

*/

   /* class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число n");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
    
    */
   /*class Program
   {
       static void Main()
       {   
           
           Console.WriteLine("Введите число количество чисел");
           int n = int.Parse(Console.ReadLine());
           int count = 0;
           int count1 = 0;
           int[] Polozitelnie = new int[n];
           Random rand = new Random();
           for (int i = 0; i < Polozitelnie.Length; i++)
               Polozitelnie[i] = rand.Next(10,20);
           int[] otrizatelnie = new int [n];
           for (int i = 0; i < otrizatelnie.Length; i++)
               otrizatelnie[i] = rand.Next(-10,-5);
           Console.WriteLine($"Первый массив {string.Join(", ", Polozitelnie)}");
           Console.WriteLine($"Второй массив {string.Join(", ", otrizatelnie)}");
           

           for (int i = 0; Polozitelnie.Length > i; i++)
           {
               if (Polozitelnie[i] > 0)
               {
                   count++;
               }
               
           }

           Console.WriteLine(count);
           
           
           
           for (int i = 0; otrizatelnie.Length > i; i++)
           {
               if (otrizatelnie[i] < 0)
               {
                   count1 ++;
               }
              
               
           }
           Console.Write(count1);
           

           


       }
   }
}