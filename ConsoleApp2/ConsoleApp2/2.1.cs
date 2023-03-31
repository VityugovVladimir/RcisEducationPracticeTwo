namespace ConsoleApp2

{
    using System;
    using System.Collections.Generic;

// УП 2.1
// Задание 1
      
        /*class Program
      {
          static void Main()
          {
              string J = Console.ReadLine();
              string S = Console.ReadLine();
              int count = 0; // 
              foreach (char c in S)
              {
                  if (J.IndexOf(c) != -1)
                  {
                      count++;
                  }
  
                  Console.WriteLine(count);
              }
          }
      }
  }


// Задание 2 



    /*class Program
    {
        static void Main()
        {
            int[] candidates1 = new int[5];
            for (int i = 0; i < candidates1.Length; i++)
            {
                Console.WriteLine($"Введите элемент массива");
                candidates1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Введите Target");
            int target1 = int.Parse(Console.ReadLine());
            IList<IList<int>> result1 = CombinationSum(candidates1, target1);
            Console.WriteLine("Результат 1:");
            PrintResult(result1);

            int[] candidates2 = new int[5];
            for (int i = 0; i < candidates2.Length; i++)
            {
                Console.WriteLine($"Введите элемент массива");
                candidates2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Введите Target");
            int target2 = int.Parse(Console.ReadLine());
            IList<IList<int>> result2 = CombinationSum(candidates2, target2);
            Console.WriteLine("Результат 2:");
            PrintResult(result2);
        }

        static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates);
            IList<IList<int>> result = new List<IList<int>>();
            FindCombinations(candidates, target, 0, new List<int>(), result);
            return result;
        }

        static void FindCombinations(int[] candidates, int target, int start, List<int> current,
            IList<IList<int>> result)
        {
            if (target == 0)
            {
                result.Add(new List<int>(current));
                return;
            }

            for (int i = start; i < candidates.Length && candidates[i] <= target; i++)
            {
                if (i > start && candidates[i] == candidates[i - 1])
                {
                    continue;
                }

                current.Add(candidates[i]);
                FindCombinations(candidates, target - candidates[i], i + 1, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }

        static void PrintResult(IList<IList<int>> result)
        {
            foreach (IList<int> list in result)
            {
                Console.Write("[");
                foreach (int number in list)
                {
                    Console.Write(number + ",");
                }

                Console.WriteLine("]");
            }

            Console.WriteLine();
        }
    }
}

*/


// 3
/*class prakcha
{
    static void Main()
    {
        int[] nums1 = new int [5];
        Random rand = new Random();
        for (int i = 0; i < nums1.Length; i++)
            nums1[i] = rand.Next(-3,20); 
        int[] nums2 = new int[5];
        for (int i = 0; i < nums2.Length; i++)
            nums2[i] = rand.Next(-3,20); 
        int[] nums3 = new int[5];
        for (int i = 0; i < nums3.Length; i++)
            nums3[i] = rand.Next(-3,20); 
        Console.WriteLine($"Первый массив {string.Join(", ", nums1)}");
        Console.WriteLine($"Есть ли повторения? {ContainsDuplicate(nums1)}");
        Console.WriteLine($"Второй массив {string.Join(", ", nums2)}");
        Console.WriteLine($" Есть ли повторения? {ContainsDuplicate(nums2)}");
        Console.WriteLine($"Третий массиов {string.Join(", ", nums3)}");
        Console.WriteLine($"Есть ли повторения? {ContainsDuplicate(nums3)}");
    }
    static bool ContainsDuplicate(int[] nums)
    {
        Array.Sort(nums); 
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                return true; 
            }
        }
        return false; 
    }
}


*/
   /* using System; //1

    namespace Practica
    {
        class Program
        {
            static void Main()
            {
                string jewelry = Console.ReadLine();
                string stones = Console.ReadLine();
                int count = 0;
                for (int i = 0; i < jewelry.Length; i++)
                {
                    for (int j = 0; j < stones.Length; j++)
                    {
                        if(jewelry[i] == stones[j])
                        {
                            count++;
                        }
                    }
                }
                Console.WriteLine($"{count}");
            }
        }
    }
 
*/


// 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

// ad89a00dd8809a7615a83ab93e12560b
