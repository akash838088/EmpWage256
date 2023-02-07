using System;

namespace EmpWage
{
    public class UC1
    {


        public static void Attendance()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == 0)
            {
                Console.WriteLine("Employee is present");

            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}