using System;
using System.Data;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            double GPA;
            int testScore;
            const double minGPA = 3.0;
            const int admin1 = 60;
            const int admin2 = 80;

            string inputString;
            Console.WriteLine("Enter grade point average: ");
            inputString = Console.ReadLine();
            GPA = Convert.ToDouble(inputString);

            Console.WriteLine("Enter test score: ");
            inputString = Console.ReadLine();
            testScore = Convert.ToInt32(inputString);

            if (GPA >= minGPA)
                if (testScore >= admin1)
                    Console.WriteLine("Accept ");
                else
                    Console.WriteLine("Reject ");
            else
                if (testScore >= admin2)
                Console.WriteLine("Accept ");
            else
                Console.WriteLine("Reject ");
        }
    }
}
