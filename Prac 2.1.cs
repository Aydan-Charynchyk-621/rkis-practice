using System;
using System.Collections.Generic;
using System.Linq;


class Programm
{
    static void Main(string[] args)
    {
        
        Console.Write("Введите J: ");
        string J = Console.ReadLine();
        Console.Write("Введите S: ");
        string S = Console.ReadLine();
        int count = 0;
        for (int i = 0; i < J.Length; i++)
        {
            if (S.Contains(J[i]))
            {
                count++;
            }
        }
        Console.WriteLine(count);*/

        /* 2 задание
        List<int> candidates = new List<int> {2, 3, 4, 2, 1};
        int target = 7;
        int cont = 0;

        List<int> current = new List<int>();

        Console.WriteLine("Цель: " + target);

        for (int i = 0; i < candidates.Count; i++)
        {
            cont = 0;
            current.Clear();
            for (int j = 0; j < candidates.Count; j++)
            {
                if (i != j) //если не равны
                {
                    cont += candidates[j];
                    current.Add(candidates[j]);
                }

                if (cont > target)
                {
                    break;
                }

                else if (cont == target)
                {
                    for (int n = 0; n < current.Count; n++)
                    {
                        Console.Write($"{current[n]} ");
                    }
                    Console.WriteLine();
                }
            } 
        }*/

        /* 3 задание
        List<int> array = new List<int> {1, 2, 3, 4, 1, 4};
        bool cont = false;
    
        for (int i = 0; i < array.Count; i++)
        {
            for (int j = 0; j < array.Count; j++)
            {
                if (i != j) // eсли не равны
                {
                    if(array[i] == array[j])
                    {
                        cont = true;
                        break;
                    }
                }
            }
        }
        Console.WriteLine(cont);*/
    }
}
1
