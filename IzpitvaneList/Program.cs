using System.Diagnostics.CodeAnalysis;

namespace IzpitvaneList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[26];
            InputGrades(grades);
            PrintIndexofgrades(grades);
            PrintMiddleAverage(grades);
            CountGreats(grades);
            GreatMdleAveage(grades);

        }
        static void InputGrades(int[]grades)
        {
            for (int i = 0;i < grades.Length;i++)
            {
                Console.WriteLine(grades);
                grades[i] = int.Parse(Console.ReadLine());
            }
        }

        static void PrintIndexofgrades(int[]grades)
        {
            Console.WriteLine($"Uchenicite  sus slab");
            for (int i = 0; i < grades.Length;i++)
            {
                if (grades[i] <= 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static int[] PrintMiddleAverage(int[]grades) 
        {
            List<int> list = new List<int>();
            for (int i = 0;i < grades.Length;i++)
            {
                if (grades[i] < 0) 
                {
                    list.Add(grades[i]);
                }
            }return list.ToArray();
        }

        static int CountGreats(int[]gredes)
        {
            int count = 0;
            foreach (int grades  in gredes)
            {
                if (grades > 0)
                {
                    count++;
                }
            }return count;    
        }

        static void GreatMdleAveage(int[]greade)
        {
            int index = greade.Length - 1;
            double sum = 0;
            for (int i = index; 1 <= index; i++)
            {
                sum += greade[i];
            }
        }


    }
}
