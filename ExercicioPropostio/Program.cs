using System;
using System.Collections.Generic;
using ExercicioPropostio.Entities;

namespace ExercicioPropostio
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<OnlineCoursePortal> set = new HashSet<OnlineCoursePortal>();

            Console.Write("How many students for course A? ");
            int A = int.Parse(Console.ReadLine());
            for (int i = 0; i < A; i++)
            {
                int x = int.Parse(Console.ReadLine());
                set.Add(new OnlineCoursePortal(x));
            }
            Console.Write("How many students for course B? ");
            int B = int.Parse(Console.ReadLine());
            for (int i = 0; i < B; i++)
            {
                int x = int.Parse(Console.ReadLine());
                set.Add(new OnlineCoursePortal(x));
            }
            Console.Write("How many students for course C? ");
            int C = int.Parse(Console.ReadLine());
            for (int i = 0; i < C; i++)
            {
                int x = int.Parse(Console.ReadLine());
                set.Add(new OnlineCoursePortal(x));
            }

            Console.WriteLine("Total students: " + set.Count);

        }
    }
}
